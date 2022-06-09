using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Menu
{
    public partial class FichaPessoal : Form
    {
        int idArquivo, IDCursoBanco;
        int numerom;
        int IDArquivoDelete;
        string conta;
        int help;
        int? arquivoDelete;
        int count;
        int valorMaximo, valorMinimo;
        string TextoArquivo;
        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private DataSet mDataSet;
        public FichaPessoal()
        {
            InitializeComponent();
            txtNome.Text = Program.nome;
            txtdescC.Text = Program.curso;
            txtData.Text = Program.data;
            txtRg.Text = Program.rg;
            txtPasta.Text = Program.pasta;

            if (Program.conc == "NÃO")
            {
                Comboconcluinte.Text = "NÃO";
            }
            else
                Comboconcluinte.Text = "SIM";
            mDataSet = new DataSet();
            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();
            //seleciona id_arquivo se o numeroMatricula for igual o Program.numeroMatricula.
            mAdapter = new MySqlDataAdapter("select arquivo from arquivo where id_arquivo = " + Program.numeroMatricula + ";", mConn);
            mAdapter.Fill(mDataSet, "Tabela_dados");
            //faz a execução do comando sql
            dataArqu.DataSource = mDataSet;
            dataArqu.DataMember = "Tabela_dados";
            dataArqu.Columns[0].Name = "Arquivos";
            dataArqu.Columns[0].Width = 430;
            //faz um select na matricula para pegar o idAluno.
            string sql = "select * from matricula where numeroMatricula = " + Program.numeroMatricula + ";";
            mDataSet = new DataSet();
            MySqlCommand cmd = new MySqlCommand(sql, mConn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
               Program.idAluno = reader.GetInt16("idAluno");
                numerom = reader.GetInt16("numeroMatricula");
            }
            reader.Close();
            mConn.Close();
        }

        private void FichaPessoal_Load(object sender, EventArgs e)
        {
            btnAlt.Enabled = false;
            txtdescC.Text = Program.curso;
            string sql = "SELECT COUNT(numeroMatricula) FROM `matricula`";
            //passa os parametros para  conexão
            mConn = new MySqlConnection(Program.conexao);
            MySqlCommand cmd = new MySqlCommand(sql, mConn);
            mConn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            //INICIA UM LEITOR PARA PR
            while (reader.Read())
            {
                //Verifica a quantidade total de matriculas 
                Program.QuantMatriculas = reader.GetInt16("COUNT(numeroMatricula)");
                Program.QuantMatriculas = Program.QuantMatriculas + 1;
            }
            reader.Close();
        }
        void ClearAllText(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                if (c is RadioButton)
                    ((RadioButton)c).Checked = false;
                if (c is MaskedTextBox)
                    ((MaskedTextBox)c).Clear();
                else
                    ClearAllText(c);
            }
        }
        private void btnCanc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static implicit operator FichaPessoal(configuracao v)
        {
            throw new NotImplementedException();
        }
        private void btnAlt_Click(object sender, EventArgs e)
        {
            btnAlt.Enabled = false;
            int idAluno = numerom + 1;
            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();
            try
            {
                mAdapter = new MySqlDataAdapter("UPDATE aluno set nomeAluno = '" + txtNome.Text +"', RG = '"+txtRg.Text+"' where idAluno = " + idAluno + " ", mConn);
                mAdapter.Fill(mDataSet, "Tabela_dados");
                mAdapter = new MySqlDataAdapter("UPDATE matricula set concluinte = '" + Comboconcluinte.Text + "', idCurso = '" + IDCursoBanco + "' where idAluno = " + idAluno + " ", mConn);
                mAdapter.Fill(mDataSet, "Tabela_dados");
                MessageBox.Show("Dados cadastrais atualizado com sucesso.");
            }catch (MySqlException ex)
            {
                MessageBox.Show("Ocorreu um erro na hora de atualizar os dados cadastrais do aluno.");
            }

        }

        private void btnProx_Click(object sender, EventArgs e)
        {
            string sql3 = "SELECT MAX(numeroMatricula) FROM `matricula` WHERE concluinte = 'SIM' or concluinte = 'NÃO'";
            //passa os parametros para  conexão
            mConn = new MySqlConnection(Program.conexao);
            MySqlCommand cmd3 = new MySqlCommand(sql3, mConn);
            mConn.Open();
            MySqlDataReader reader3 = cmd3.ExecuteReader();
            while (reader3.Read())
            {
                valorMaximo = reader3.GetInt16("MAX(numeroMatricula)");
            }
             
            if (numerom < valorMaximo)
            {
                count = 1;
                do
                {
                    if(numerom < valorMaximo)
                    {
                        //Soma + 1 ao numero da matricula e faz um sql para fazer um select na matricula
                        numerom = numerom + 1;

                        //se o numero da matricula for igual o Program.numeroMatricula, ele seleciona e faz as bagaça.
                        string sql = "SELECT m.numeroMatricula, a.nomeAluno, a.RG, c.nomeCurso, m.numeroPasta, m.Concluinte, m.anoEnt FROM matricula m JOIN aluno AS a ON m.idAluno = a.idAluno JOIn curso AS c ON m.idCurso = c.idCurso WHERE m.numeroMatricula = '" + numerom + "' AND (concluinte = 'SIM' OR concluinte = 'NÃO') ";
                        //passa os parametros para  conexão
                        mConn = new MySqlConnection(Program.conexao);
                        MySqlCommand cmd = new MySqlCommand(sql, mConn);
                        mConn.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        //INICIA UM LEITOR PARA PREENCHER OS TEXT BOX À PARTIR DO BANDO DE DADOS.
                        while (reader.Read())
                        {
                            string check = reader.GetString("Concluinte");
                            if (check != "OUT")
                            {
                                help = 1;
                            }
                            else
                            {
                                help = 0;
                            }

                            if (help == 1)
                            {
                                txtNome.Text = reader.GetString("nomeAluno");
                                txtRg.Text = reader.GetString("RG");
                                txtData.Text = reader.GetString("anoEnt");
                                txtdescC.Text = reader.GetString("nomeCurso");
                                txtPasta.Text = reader.GetString("numeroPasta");
                                Comboconcluinte.Text = reader.GetString("Concluinte");
                                count = 0;
                            }
                            else
                                if (help == 0)
                            {
                                count = 1;
                            }
                        }
                        reader.Close();
                        mConn.Close();

                        //Limpa o mDataSet e mAdapter, pois senão ocorrerão bugs
                        mDataSet.Clear();
                        mAdapter = null;
                        dataArqu.Refresh();
                        mAdapter = new MySqlDataAdapter("SELECT a.arquivo FROM arquivo a INNER JOIN matricula m ON a.id_arquivo = m.numeroMatricula WHERE a.id_arquivo = '" + numerom + "'", mConn);
                        mAdapter.Fill(mDataSet, "Tabela_dados");
                        dataArqu.DataSource = mDataSet;
                        dataArqu.DataMember = "Tabela_dados";
                        dataArqu.Columns[0].Name = "Arquivos";
                        dataArqu.Columns[0].Width = 430;
                        mConn.Close();
                    }
                    else
                    {
                        numerom = numerom - 1;
                        count = 0;
                    }
                } while (count == 1);  
            }
            else
            {
                numerom = numerom - 1;
            }
            btnAlt.Enabled = false;
        }

        private void btnAnt_Click(object sender, EventArgs e)
        {
        string sql3 = "SELECT MIN(numeroMatricula) FROM `matricula` WHERE concluinte = 'SIM' or concluinte = 'NÃO'";
            //passa os parametros para  conexão
            mConn = new MySqlConnection(Program.conexao);
            MySqlCommand cmd3 = new MySqlCommand(sql3, mConn);
            mConn.Open();
            MySqlDataReader reader3 = cmd3.ExecuteReader();
            while (reader3.Read())
            {
                valorMinimo = reader3.GetInt16("MIN(numeroMatricula)");
            }

            if (numerom > valorMinimo)
            {
                count = 1;
                do
                {
                    if (numerom > valorMinimo)
                    {
                        //Soma + 1 ao numero da matricula e faz um sql para fazer um select na matricula
                        numerom = numerom - 1;

                        //se o numero da matricula for igual o Program.numeroMatricula, ele seleciona e faz as bagaça.
                        string sql = "SELECT m.numeroMatricula, a.nomeAluno, a.RG, c.nomeCurso, m.numeroPasta, m.Concluinte, m.anoEnt FROM matricula m JOIN aluno AS a ON m.idAluno = a.idAluno JOIn curso AS c ON m.idCurso = c.idCurso WHERE m.numeroMatricula = '" + numerom + "' AND (concluinte = 'SIM' OR concluinte = 'NÃO') ";
                        //passa os parametros para  conexão
                        mConn = new MySqlConnection(Program.conexao);
                        MySqlCommand cmd = new MySqlCommand(sql, mConn);
                        mConn.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        //INICIA UM LEITOR PARA PREENCHER OS TEXT BOX À PARTIR DO BANDO DE DADOS.
                        while (reader.Read())
                        {
                            string check = reader.GetString("Concluinte");
                            if (check != "OUT")
                            {
                                help = 1;
                            }
                            else
                            {
                                help = 0;
                            }

                            if (help == 1)
                            {
                                txtNome.Text = reader.GetString("nomeAluno");
                                txtRg.Text = reader.GetString("RG");
                                txtData.Text = reader.GetString("anoEnt");
                                txtdescC.Text = reader.GetString("nomeCurso");
                                txtPasta.Text = reader.GetString("numeroPasta");
                                Comboconcluinte.Text = reader.GetString("Concluinte");
                                count = 0;
                            }
                            else
                                if (help == 0)
                            {
                                count = 1;
                            }
                        }
                        reader.Close();
                        mConn.Close();

                        //Limpa o mDataSet e mAdapter, pois senão ocorrerão bugs
                        mDataSet.Clear();
                        mAdapter = null;
                        dataArqu.Refresh();
                        mAdapter = new MySqlDataAdapter("SELECT a.arquivo FROM arquivo a INNER JOIN matricula m ON a.id_arquivo = m.numeroMatricula WHERE a.id_arquivo = '" + numerom + "'", mConn);
                        mAdapter.Fill(mDataSet, "Tabela_dados");
                        dataArqu.DataSource = mDataSet;
                        dataArqu.DataMember = "Tabela_dados";
                        dataArqu.Columns[0].Name = "Arquivos";
                        dataArqu.Columns[0].Width = 430;
                        mConn.Close();
                    }
                    else
                    {
                        numerom = numerom - 1;
                        count = 0;
                    }
                } while (count == 1);
            }
            btnAlt.Enabled = false;
        }

        private void btnAdc_Click(object sender, EventArgs e)
        {
            if (txtItens.Text != "")
            {
                btnAdc.Enabled = false;
                mDataSet = new DataSet();
                mConn = new MySqlConnection(Program.conexao);
                mConn.Open();
                string sql = "select * from arquivo";
                MySqlCommand cmd = new MySqlCommand(sql, mConn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    idArquivo = Convert.ToInt16(reader.GetString("idarquivo"));
                    idArquivo = idArquivo + 1;
                }
                reader.Close();
                mAdapter = new MySqlDataAdapter("INSERT INTO arquivo (idArquivo, arquivo, id_arquivo) values (" + idArquivo + ", '" + txtItens.Text + "', " + numerom + ");", mConn);
                mAdapter.Fill(mDataSet, "Tabela_dados");
                mDataSet.Clear();
                mAdapter = new MySqlDataAdapter("SELECT arquivo FROM `arquivo` WHERE id_arquivo =  " + numerom + ";", mConn);
                mAdapter.Fill(mDataSet, "Tabela_dados");
                dataArqu.DataSource = mDataSet;
                dataArqu.DataMember = "Tabela_dados";
                dataArqu.Columns[0].Width = 450;
                txtItens.Text = "";
            }
        }

        private void btnExc_Click(object sender, EventArgs e)
        {
            btnExc.Enabled = false;
            mDataSet = new DataSet();
            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();
            string sql = "SELECT MAX(idArquivo) FROM arquivo WHERE arquivo = '"+ TextoArquivo +"' AND id_arquivo = '"+ numerom +"'";
            MySqlCommand cmd = new MySqlCommand(sql, mConn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if(TextoArquivo != "")
                {
                    IDArquivoDelete = reader.GetInt16("MAX(idArquivo)");
                }
            }
            reader.Close();
            mAdapter = new MySqlDataAdapter("DELETE FROM `arquivo` WHERE idArquivo = '"+ IDArquivoDelete +"'", mConn);
            mAdapter.Fill(mDataSet, "Tabela_dados");
            mDataSet.Clear();
            mAdapter = new MySqlDataAdapter("SELECT arquivo FROM `arquivo` WHERE id_arquivo =  " + numerom + ";", mConn);
            mAdapter.Fill(mDataSet, "Tabela_dados");
            dataArqu.DataSource = mDataSet;
            dataArqu.DataMember = "Tabela_dados";
            dataArqu.Columns[0].Width = 450;
        }

        private void txtdescC_Enter(object sender, EventArgs e)
        {
                
        }

        private void txtItens_Enter(object sender, EventArgs e)
        {
            btnAdc.Enabled = true;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            btnAlt.Enabled = true;
        }

        private void txtRg_TextChanged(object sender, EventArgs e)
        {
            btnAlt.Enabled = true;
        }

        private void txtPasta_TextChanged(object sender, EventArgs e)
        {
            btnAlt.Enabled = true;
        }

        private void txtData_TextChanged(object sender, EventArgs e)
        {
            btnAlt.Enabled = true;
        }

        private void Comboconcluinte_TextChanged(object sender, EventArgs e)
        {
            btnAlt.Enabled = true;
        }

        private void txtdescC_Click(object sender, EventArgs e)
        {
            mDataSet = new DataSet();
            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();
            MySqlCommand mAdapter = new MySqlCommand("SELECT * FROM curso ORDER BY idCurso DESC", mConn);
            MySqlDataReader reader1 = mAdapter.ExecuteReader();//retorna dados resultantes da consulta em SQL
            DataTable table = new DataTable(); //estrutura da tabela do banco de dados ou de outra fonte de informação
            table.Load(reader1); //carrega dados na tabela de acordo com a instrução sql passada 
            DataRow row = table.NewRow(); //representa uma linha de dados em um DataTable
            row["nomeCurso"] = ""; //para não gerar valor nulo e, consequentemente, evitar erro de execução
            this.txtdescC.DataSource = table;
            this.txtdescC.DisplayMember = "nomeCurso";//obtem o nome do curso
            reader1.Close();//fecha o objeto
            reader1.Dispose();//liberamos o objeto da memoria
            txtdescC.Text = Program.curso;
            btnAlt.Enabled = false;         
        }

        private void BtnExcAluno_Click(object sender, EventArgs e)
        {
            int idaluno = numerom + 1;
            mAdapter = new MySqlDataAdapter("DELETE FROM `arquivo` WHERE id_arquivo = '" + numerom + "'", mConn);
            mAdapter.Fill(mDataSet, "Tabela_dados");
            mConn.Close();
            mAdapter = new MySqlDataAdapter("UPDATE `matricula` SET `concluinte` = 'OUT' WHERE numeroMatricula = '" + numerom + "'", mConn);
            mAdapter.Fill(mDataSet, "Tabela_dados");
            mDataSet.Clear();
            mConn.Close();
            this.Close();
        }

        private void txtdescC_TabIndexChanged(object sender, EventArgs e)
        {
            txtdescC.Text = Program.curso;
            btnAlt.Enabled = false;
        }

        private void txtdescC_SelectedValueChanged(object sender, EventArgs e)
        {
                btnAlt.Enabled = true;
                mDataSet = new DataSet();
                mConn = new MySqlConnection(Program.conexao);
                string sql = "select * from curso where NomeCurso = '" + txtdescC.Text + "'";
                mConn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, mConn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    IDCursoBanco = reader.GetInt16("idCurso");
                }
        }

        private void txtPasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtRg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void dataArqu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtItens_Leave(object sender, EventArgs e)
        {
            if(txtItens.Text == "")
            {
                btnAdc.Enabled = false;
            }
        }

        private void dataArqu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TextoArquivo = dataArqu.CurrentRow.Cells[0].Value.ToString();
            btnExc.Enabled = true;
        }
    }
}

