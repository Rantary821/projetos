using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using MySql.Data.MySqlClient;
/*
 pesquisa registro 
 select nome,date_format(emissao,'%d/%m/%y') from cliente
 where name= "";
 if (textCodigo.Text != ""){
    //colocar select
    //
    MySqlDataReade Resultado = Consulta.ExecuteReader();
    if(mostraResultados.HasRows)
    {
    while (mostraResultado.HasRow)
    {
        textNome.Text = Resultados["nome"].ToString;
    }
    }
    }
    */
namespace Menu
{
    public partial class CadastroAluno : Form
    {
        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private DataSet mDataSet;

        private string strsql = "";
        int NumMatricula, CodCurso, CodAluno, maximo, CountMatricula, teste = 0;
        int contador;
        int Contadorbtn = 0;
        string concluinte, trocaAno;
        int numeroMatricula;
        public CadastroAluno()
        {
            InitializeComponent();
            labelCod.Text = "1";
            //txtPasta.Text = "1";
            mDataSet = new DataSet();
            mConn = new MySqlConnection(Program.conexao);
            int contador;
            string sql = "select * from aluno;";
            MySqlCommand cmd = new MySqlCommand(sql, mConn);
            mConn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string numero = reader.GetString("idAluno");
                contador = Convert.ToInt16(numero);
                contador = contador + 1;
                labelCod.Text = Convert.ToString(contador);
            }
            mConn.Close();
            reader.Close();

            mDataSet = new DataSet();
            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();
            string sql1 = "SELECT NumeroPasta FROM `config`;";
            MySqlCommand cmd1 = new MySqlCommand(sql1, mConn);
            MySqlDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                Program.MConfig = reader1.GetString("NumeroPasta");
            }
            mConn.Close();
            reader.Close();
        }

        void AnteriorProximo(Control con)
        {
            
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
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void txtNomeA_TextChanged(object sender, EventArgs e)
        {
            mDataSet = new DataSet();
            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();
            //codigo SQL
            try
                {
                    mAdapter = new MySqlDataAdapter("SELECT m.numeroMatricula, a.nomeAluno, a.RG, c.nomeCurso, m.numeroPasta, m.Concluinte, m.anoEnt FROM    matricula m JOIN    aluno AS a ON    m.idAluno = a.idAluno JOIn   curso AS c ON   m.idCurso = c.idCurso WHERE  a.nomeAluno LIKE '" + txtNomeA.Text + "%' and (m.concluinte = 'SIM' or m.concluinte = 'NÃO');", mConn);
                    mAdapter.Fill(mDataSet, "Tabela_dados");
                    //atribui para o datagrid
                    dataGridPesq.DataSource = mDataSet;
                    dataGridPesq.DataMember = "Tabela_dados";
                    dataGridPesq.Columns[0].Width = 0;
                    dataGridPesq.Columns[1].Width = 350;
                    dataGridPesq.Columns[2].Width = 140;
                    dataGridPesq.Columns[3].Width = 250;
                    dataGridPesq.Columns[4].Width = 100;
                    dataGridPesq.Columns[5].Width = 80;
                    dataGridPesq.Columns[6].Width = 90;
                    dataGridPesq.Columns[1].HeaderText = "Nome do Aluno";
                    dataGridPesq.Columns[2].HeaderText = "RG";
                    dataGridPesq.Columns[3].HeaderText = "Nome do Curso";
                    dataGridPesq.Columns[4].HeaderText = "NºPasta";
                    dataGridPesq.Columns[5].HeaderText = "Concluinte";
                    dataGridPesq.Columns[6].HeaderText = "Ano";

                    dataGridPesq.RowHeadersWidth = 21;
                    dataGridPesq.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
                    dataGridPesq.ColumnHeadersHeight = 23;

                }
                catch(Exception ex)
                {
                    MessageBox.Show("ERROR : " + ex);
                }
            
            }
        

        private void txtNumP_TextChanged(object sender, EventArgs e)
        {
            mDataSet = new DataSet();
            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();
            //codigo SQL
            mAdapter = new MySqlDataAdapter("SELECT m.numeroMatricula, a.nomeAluno, a.RG, c.nomeCurso, m.numeroPasta, m.Concluinte, m.anoEnt FROM    matricula m JOIN    aluno AS a ON    m.idAluno = a.idAluno JOIn   curso AS c ON   m.idCurso = c.idCurso WHERE  a.nomeAluno LIKE '" + txtNumP.Text + "%' and (m.concluinte = 'SIM' or m.concluinte = 'NÃO');", mConn);
            mAdapter.Fill(mDataSet, "Tabela_dados");
            //atribui para o datagrid
            dataGridPesq.DataSource = mDataSet;
            dataGridPesq.DataMember = "Tabela_dados";
            dataGridPesq.Columns[0].Width = 0;
            dataGridPesq.Columns[1].Width = 350;
            dataGridPesq.Columns[2].Width = 140;
            dataGridPesq.Columns[3].Width = 250;
            dataGridPesq.Columns[4].Width = 100;
            dataGridPesq.Columns[5].Width = 80;
            dataGridPesq.Columns[6].Width = 90;
            dataGridPesq.Columns[1].HeaderText = "Nome do Aluno";
            dataGridPesq.Columns[2].HeaderText = "RG";
            dataGridPesq.Columns[3].HeaderText = "Nome do Curso";
            dataGridPesq.Columns[4].HeaderText = "NºPasta";
            dataGridPesq.Columns[5].HeaderText = "Concluinte";
            dataGridPesq.Columns[6].HeaderText = "Ano";

            dataGridPesq.RowHeadersWidth = 21;
            dataGridPesq.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridPesq.ColumnHeadersHeight = 23;
        }

        private void txtNomeRg_TextChanged(object sender, EventArgs e)
        {
            mDataSet = new DataSet();
            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();
            //codigo SQL
            try
            {
                mAdapter = new MySqlDataAdapter("SELECT m.numeroMatricula, a.nomeAluno, a.RG, c.nomeCurso, m.numeroPasta, m.Concluinte, m.anoEnt FROM    matricula m JOIN    aluno AS a ON    m.idAluno = a.idAluno JOIn   curso AS c ON   m.idCurso = c.idCurso WHERE  a.nomeAluno LIKE '" + txtRG.Text + "%' and (m.concluinte = 'SIM' or m.concluinte = 'NÃO');", mConn);
                mAdapter.Fill(mDataSet, "Tabela_dados");
                //atribui para o datagrid
                dataGridPesq.DataSource = mDataSet;
                dataGridPesq.DataMember = "Tabela_dados";
                dataGridPesq.Columns[0].Width = 0;
                dataGridPesq.Columns[1].Width = 350;
                dataGridPesq.Columns[2].Width = 140;
                dataGridPesq.Columns[3].Width = 250;
                dataGridPesq.Columns[4].Width = 100;
                dataGridPesq.Columns[5].Width = 80;
                dataGridPesq.Columns[6].Width = 90;
                dataGridPesq.Columns[1].HeaderText = "Nome do Aluno";
                dataGridPesq.Columns[2].HeaderText = "RG";
                dataGridPesq.Columns[3].HeaderText = "Nome do Curso";
                dataGridPesq.Columns[4].HeaderText = "NºPasta";
                dataGridPesq.Columns[5].HeaderText = "Concluinte";
                dataGridPesq.Columns[6].HeaderText = "Ano";

                dataGridPesq.RowHeadersWidth = 21;
                dataGridPesq.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
                dataGridPesq.ColumnHeadersHeight = 23;

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR : " + ex);
            }
        }

        private void btnCad_Click_1(object sender, EventArgs e)
        {
                //Vereficando se os campos Nome, Rg e Curso estão preenchidos
                if(txtNome.Text == "" || txtRG.Text == "" || txtdescC.Text == "")
                {
                //Caso não estejam preenchidos mostra uma mensagem
                MessageBox.Show("Preencha todos os campos!!");
                }
                else
                {
                groupBox2.Enabled = false;
                //Abre a conexão com o banco de dados
                mDataSet = new DataSet();
                mConn = new MySqlConnection(Program.conexao);
                mConn.Open();
                //Pegando dados da tabela matricula do banco de dados
                string sql = "select * from matricula";
                MySqlCommand cmd = new MySqlCommand(sql, mConn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //Colocando dado em uma variavel
                    int contador = Convert.ToInt16(reader.GetString("numeroMatricula"));
                    //Adicionando um numero a matricula
                    contador = contador + 1;
                    numeroMatricula = contador;
                }
                reader.Close();
                //Inserindo dados do novo cadastro na tabela aluno
                mAdapter = new MySqlDataAdapter("INSERT INTO aluno (idAluno, nomeAluno, RG) values ('" + labelCod.Text + "', '" + txtNome.Text + "', '" + txtRG.Text + "');", mConn);
                mAdapter.Fill(mDataSet, "Tabela_dados");
                //Inserindo dados do novo cadastro na tabela matricula
                mAdapter = new MySqlDataAdapter("INSERT INTO matricula (anoEnt, concluinte, idAluno, idCurso, numeroMatricula, numeroPasta, id_arquivo) values ('" + txtData.Text + "', '" + concluinte + "', '" + labelCod.Text + "','" + txtCod.Text + "', " + numeroMatricula + ", '" + txtPasta.Text + "', '" + numeroMatricula + "');", mConn);
                mAdapter.Fill(mDataSet, "Tabela_dados");
                //limpando todos os textbox
                ClearAllText(this);
                txtdescC.Text = "";
                contador = Convert.ToInt16(labelCod.Text);
                contador = contador + 1;
                labelCod.Text = Convert.ToString(contador);
                //Colocando a data atual no textbox da data
                string ano = DateTime.Now.Year.ToString();
                txtData.Text = ano;
            }
        }

        private void txtdescC_Enter(object sender, EventArgs e)
        {
            mDataSet = new DataSet();
            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();

            MySqlCommand mAdapter = new MySqlCommand("SELECT * FROM curso ORDER BY idCurso DESC", mConn);
            MySqlDataReader reader = mAdapter.ExecuteReader();//retorna dados resultantes da consulta em SQL
            DataTable table = new DataTable(); //estrutura da tabela do banco de dados ou de outra fonte de informação
            table.Load(reader); //carrega dados na tabela de acordo com a instrução sql passada 
            DataRow row = table.NewRow(); //representa uma linha de dados em um DataTable
            row["nomeCurso"] = ""; //para não gerar valor nulo e, consequentemente, evitar erro de execução


            this.txtdescC.DataSource = table;
            this.txtdescC.ValueMember = "idCurso";
            this.txtdescC.DisplayMember = "nomeCurso";//obtem o nome do curso
            reader.Close();//fecha o objeto
            reader.Dispose();//liberamos o objeto da memoria
        }

        private void comboNome_TextChanged_1(object sender, EventArgs e)
        {
            mDataSet = new DataSet();
            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();
            //codigo SQL
            try
            {
                mAdapter = new MySqlDataAdapter("SELECT m.numeroMatricula, a.nomeAluno, a.RG, c.nomeCurso, m.numeroPasta, m.Concluinte, m.anoEnt FROM    matricula m JOIN    aluno AS a ON    m.idAluno = a.idAluno JOIn   curso AS c ON   m.idCurso = c.idCurso WHERE  a.nomeAluno LIKE '" + comboNome.Text + "%' and (m.concluinte = 'SIM' or m.concluinte = 'NÃO');", mConn);
                mAdapter.Fill(mDataSet, "Tabela_dados");
                //atribui para o datagrid
                dataGridPesq.DataSource = mDataSet;
                dataGridPesq.DataMember = "Tabela_dados";
                dataGridPesq.Columns[0].Width = 0;
                dataGridPesq.Columns[1].Width = 350;
                dataGridPesq.Columns[2].Width = 140;
                dataGridPesq.Columns[3].Width = 250;
                dataGridPesq.Columns[4].Width = 100;
                dataGridPesq.Columns[5].Width = 80;
                dataGridPesq.Columns[6].Width = 90;
                dataGridPesq.Columns[1].HeaderText = "Nome do Aluno";
                dataGridPesq.Columns[2].HeaderText = "RG";
                dataGridPesq.Columns[3].HeaderText = "Nome do Curso";
                dataGridPesq.Columns[4].HeaderText = "NºPasta";
                dataGridPesq.Columns[5].HeaderText = "Concluinte";
                dataGridPesq.Columns[6].HeaderText = "Ano";
                dataGridPesq.RowHeadersWidth = 21;
                dataGridPesq.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
                dataGridPesq.ColumnHeadersHeight = 23;

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR : " + ex);
            }
        }

        private void btnCons_Click(object sender, EventArgs e)
        {

        }

        private void dataGridPesq_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void dataGridPesq_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int pega = 0;
            try
            {
                Program.nome = dataGridPesq.CurrentRow.Cells[1].Value.ToString();
                Program.pasta = dataGridPesq.CurrentRow.Cells[4].Value.ToString();
                Program.rg = dataGridPesq.CurrentRow.Cells[2].Value.ToString();
                Program.data = dataGridPesq.CurrentRow.Cells[6].Value.ToString();
                Program.curso = dataGridPesq.CurrentRow.Cells[3].Value.ToString();
                Program.conc = dataGridPesq.CurrentRow.Cells[5].Value.ToString();
                Program.numeroMatricula = Convert.ToInt16(dataGridPesq.CurrentRow.Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {
                pega = 1;
            }

            if(pega == 0)
            {
                FichaPessoal ficha = new FichaPessoal();
                ficha.ShowDialog();
                this.Refresh();
                txtNomeA.Text = "";
                txtNumP.Text = "";
                txtNomeRg.Text = "";
                comboNome.Text = "";

                mDataSet.Clear();
                mAdapter = null;
               
            }
        }


        private void CadastroAluno_Load(object sender, EventArgs e)
        {
            string ano = DateTime.Now.Year.ToString();
            txtData.Text = ano;
        }

        private void txtPasta_Enter(object sender, EventArgs e)
        {
            string sql = "SELECT* FROM aluno";
            mDataSet = new DataSet();
            mConn = new MySqlConnection(Program.conexao);
            MySqlCommand cmd = new MySqlCommand(sql, mConn);
            mConn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                txtPasta.Text = reader.GetString("numeroPasta");
            }
        }
        private void txtdescC_TextChanged(object sender, EventArgs e)
        {
            mDataSet = new DataSet();
            mConn = new MySqlConnection(Program.conexao);
            string sql = "select * from curso where NomeCurso = '" + txtdescC.Text + "'";
            mConn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, mConn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                txtCod.Text = reader.GetString("idCurso");
            }
        }

        private void txtPasta_Enter_1(object sender, EventArgs e)
        {
           
        }

        private void txtDataEnt_TextChanged(object sender, EventArgs e)
        {
            mDataSet = new DataSet();
            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();
            //codigo SQL
            mAdapter = new MySqlDataAdapter("SELECT m.numeroMatricula, a.nomeAluno, a.RG, c.nomeCurso, m.numeroPasta, m.Concluinte, m.anoEnt FROM    matricula m JOIN    aluno AS a ON    m.idAluno = a.idAluno JOIn   curso AS c ON   m.idCurso = c.idCurso WHERE  m.anoEnt LIKE '" + txtDataEnt.Text + "%' and (m.concluinte = 'SIM' or m.concluinte = 'NÃO');", mConn);
            mAdapter.Fill(mDataSet, "Tabela_dados");
            //atribui para o datagrid
            dataGridPesq.DataSource = mDataSet;
            dataGridPesq.DataMember = "Tabela_dados";
            dataGridPesq.Columns[0].Width = 0;
            dataGridPesq.Columns[1].Width = 350;
            dataGridPesq.Columns[2].Width = 140;
            dataGridPesq.Columns[3].Width = 250;
            dataGridPesq.Columns[4].Width = 100;
            dataGridPesq.Columns[5].Width = 80;
            dataGridPesq.Columns[6].Width = 90;
            dataGridPesq.Columns[1].HeaderText = "Nome do Aluno";
            dataGridPesq.Columns[2].HeaderText = "RG";
            dataGridPesq.Columns[3].HeaderText = "Nome do Curso";
            dataGridPesq.Columns[4].HeaderText = "NºPasta";
            dataGridPesq.Columns[5].HeaderText = "Concluinte";
            dataGridPesq.Columns[6].HeaderText = "Ano";

            dataGridPesq.RowHeadersWidth = 21;
            dataGridPesq.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridPesq.ColumnHeadersHeight = 23;
        }

        private void txtRG_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void btnCanc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radC_CheckedChanged_1(object sender, EventArgs e)
        {
            txtdescC.Enabled = true;
            txtNome.Enabled = true;
            txtRG.Enabled = true;
            txtNome.Text = "";
            txtData.Text = "";
            string ano = DateTime.Now.Year.ToString();
            txtData.Text = ano;
            txtRG.Text = "";
            txtCod.Text = "";
            txtdescC.Text = "";
            btnProx.Enabled = false;
            btnCad.Enabled = true;
            Contadorbtn = 0;
            maximo = 0;
            NumMatricula = 0;
            txtNome.Focus();
            if (radC.Checked == true)
            {
                groupBox2.Enabled = true;
                concluinte = "SIM";
                string sql = "SELECT count(numeroPasta) from matricula WHERE concluinte = 'SIM'";
                mDataSet = new DataSet();
                mConn = new MySqlConnection(Program.conexao);
                MySqlCommand cmd = new MySqlCommand(sql, mConn);
                mConn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if(Program.MConfig == "Config - 1")
                    {
                        int contador;
                        contador = Convert.ToInt16(reader.GetString("count(numeroPasta)"));
                        contador ++;
                        txtPasta.Text = Convert.ToString(contador);
                    }
                    else
                        if(Program.MConfig == "Config - 2")
                    {
                        string sql2 = "SELECT TrocaAno FROM `config`";
                        mDataSet = new DataSet();
                        mConn = new MySqlConnection(Program.conexao);
                        MySqlCommand cmd2 = new MySqlCommand(sql2, mConn);
                        mConn.Open();
                        MySqlDataReader reader2 = cmd2.ExecuteReader();

                        while (reader2.Read())
                        {
                            trocaAno = reader2.GetString("TrocaAno");
                            if (trocaAno == "ManterSequencia")
                            {
                                int contador;
                                contador = Convert.ToInt16(reader.GetString("count(numeroPasta)"));
                                contador = contador + 1;
                                txtPasta.Text = Convert.ToString(txtData.Text + " - " + contador);
                            }
                            else
                                if (trocaAno == "NovaSequencia")
                            {
                                string sql3 = "SELECT count(numeroPasta) from matricula WHERE concluinte = 'SIM' and anoEnt = '" + txtData.Text + "'";
                                mDataSet = new DataSet();
                                mConn = new MySqlConnection(Program.conexao);
                                MySqlCommand cmd3 = new MySqlCommand(sql3, mConn);
                                mConn.Open();
                                MySqlDataReader reader3 = cmd3.ExecuteReader();

                                while (reader3.Read())
                                {
                                    int contador;
                                    contador = Convert.ToInt16(reader3.GetString("count(numeroPasta)"));
                                    contador = contador + 1;
                                    txtPasta.Text = Convert.ToString(txtData.Text + " - " + contador);
                                }
                            }
                        }      
                    }                
                }
            }else if (radNc.Checked == true)
            {
                groupBox2.Enabled = true;
                concluinte = "NÃO";
                string sql = "SELECT count(numeroPasta) from matricula WHERE concluinte = 'NÃO'";
                mDataSet = new DataSet();
                mConn = new MySqlConnection(Program.conexao);
                MySqlCommand cmd = new MySqlCommand(sql, mConn);
                mConn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (Program.MConfig == "Config - 1")
                    {
                        contador = Convert.ToInt16(reader.GetString("count(numeroPasta)"));
                        contador = contador + 1;
                        txtPasta.Text = Convert.ToString(contador);
                    }
                    else
                       if (Program.MConfig == "Config - 2")
                    {
                        string sql2 = "SELECT TrocaAno FROM `config`";
                        mDataSet = new DataSet();
                        mConn = new MySqlConnection(Program.conexao);
                        MySqlCommand cmd2 = new MySqlCommand(sql2, mConn);
                        mConn.Open();
                        MySqlDataReader reader2 = cmd2.ExecuteReader();

                        while (reader2.Read())
                        {
                            trocaAno = reader2.GetString("TrocaAno");
                            if (trocaAno == "ManterSequencia")
                            {
                                int contador;
                                contador = Convert.ToInt16(reader.GetString("count(numeroPasta)"));
                                contador = contador + 1;
                                txtPasta.Text = Convert.ToString(txtData.Text + " - " + contador);
                            }
                            else
                                if (trocaAno == "NovaSequencia")
                            {
                                string sql3 = "SELECT count(numeroPasta) from matricula WHERE concluinte = 'NÃO' and anoEnt = '" + txtData.Text + "'";
                                mDataSet = new DataSet();
                                mConn = new MySqlConnection(Program.conexao);
                                MySqlCommand cmd3 = new MySqlCommand(sql3, mConn);
                                mConn.Open();
                                MySqlDataReader reader3 = cmd3.ExecuteReader();

                                while (reader3.Read())
                                {
                                    int contador;
                                    contador = Convert.ToInt16(reader3.GetString("count(numeroPasta)"));
                                    contador = contador + 1;
                                    txtPasta.Text = Convert.ToString(txtData.Text + " - " + contador);
                                }
                            }
                        }
                    }
                }
            }
        }

       private void btnProx_Click(object sender, EventArgs e)
        {
            try
            {
                txtNome.Text = "";
                txtData.Text = "";
                txtRG.Text = "";
                txtCod.Text = "";
                txtdescC.Text = "";

                if (radC.Checked == true && NumMatricula < maximo)
                {
                    NumMatricula = NumMatricula + 1;

                    teste = 0;
                    do
                    {
                        if (NumMatricula < maximo)
                        {
                            //Pegando agora os dados dos alunos da tebela matricula
                            mDataSet = new DataSet();
                            mConn = new MySqlConnection(Program.conexao);
                            string sql1 = "SELECT * FROM `matricula` WHERE numeroMatricula = '" + NumMatricula + "' ";
                            mConn.Open();
                            MySqlCommand cmd1 = new MySqlCommand(sql1, mConn);
                            MySqlDataReader reader1 = cmd1.ExecuteReader();

                            while (reader1.Read())
                            {
                                string verifica = reader1.GetString("concluinte");

                                if (verifica == "SIM")
                                {
                                    //Preenchendo os TextBoxs com os dados
                                    txtPasta.Text = reader1.GetString("numeroPasta");
                                    txtData.Text = reader1.GetString("anoEnt");

                                    //Capturando o Codigo do curso e o Id do aluno
                                    CodCurso = reader1.GetInt16("idCurso");
                                    CodAluno = reader1.GetInt16("idAluno");
                                    teste = 0;
                                }
                                else
                                {
                                    teste = 1;
                                    NumMatricula = NumMatricula + 1;
                                }
                            }
                            reader1.Close();
                        }
                        else
                        {
                            teste = 0;
                        }
                    } while (teste == 1);

                    if (NumMatricula < maximo)
                    {
                        //Pegando agora os dados dos alunos da tebela aluno
                        mDataSet = new DataSet();
                        mConn = new MySqlConnection(Program.conexao);
                        string sql2 = "SELECT * FROM `aluno` WHERE idAluno = '" + CodAluno + "'";
                        mConn.Open();
                        MySqlCommand cmd2 = new MySqlCommand(sql2, mConn);
                        MySqlDataReader reader2 = cmd2.ExecuteReader();

                        while (reader2.Read())
                        {
                            txtNome.Text = reader2.GetString("nomeAluno");
                            txtRG.Text = reader2.GetString("RG");
                        }
                        reader2.Close();


                        //Pegando agora os dados dos alunos da tebela curso
                        mDataSet = new DataSet();
                        mConn = new MySqlConnection(Program.conexao);
                        string sql3 = "SELECT nomeCurso FROM `curso` WHERE idCurso = '" + CodCurso + "'";
                        mConn.Open();
                        MySqlCommand cmd3 = new MySqlCommand(sql3, mConn);
                        MySqlDataReader reader3 = cmd3.ExecuteReader();

                        while (reader3.Read())
                        {
                            txtdescC.Text = reader3.GetString("nomeCurso");
                        }
                        reader3.Close();
                    }
                    if (NumMatricula == maximo)
                    {
                        btnProx.Enabled = false;
                        groupBox2.Enabled = true;
                        btnCad.Enabled = true;
                        string ano = DateTime.Now.Year.ToString();
                        txtData.Text = ano;
                        string sql = "SELECT COUNT(numeroPasta) from matricula WHERE concluinte = 'SIM'";
                        mDataSet = new DataSet();
                        mConn = new MySqlConnection(Program.conexao);
                        MySqlCommand cmd = new MySqlCommand(sql, mConn);
                        mConn.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            int contador;
                            contador = Convert.ToInt16(reader.GetString("COUNT(numeroPasta)"));
                            contador = contador + 1;
                            txtPasta.Text = Convert.ToString(txtData.Text + " - " + contador);
                            txtCod.Enabled = false;
                        }
                    }
                }
               
                //Não conluintes
           else if (radNc.Checked == true && NumMatricula < maximo)
                {
                    NumMatricula = NumMatricula + 1;

                    teste = 0;
                    do
                    {
                        if (NumMatricula < maximo)
                        {
                            //Pegando agora os dados dos alunos da tebela matricula
                            mDataSet = new DataSet();
                            mConn = new MySqlConnection(Program.conexao);
                            string sql1 = "SELECT * FROM `matricula` WHERE numeroMatricula = '" + NumMatricula + "' ";
                            mConn.Open();
                            MySqlCommand cmd1 = new MySqlCommand(sql1, mConn);
                            MySqlDataReader reader1 = cmd1.ExecuteReader();

                            while (reader1.Read())
                            {
                                string verifica = reader1.GetString("concluinte");

                                if (verifica == "NÃO")
                                {
                                    //Preenchendo os TextBoxs com os dados
                                    txtPasta.Text = reader1.GetString("numeroPasta");
                                    txtData.Text = reader1.GetString("anoEnt");

                                    //Capturando o Codigo do curso e o Id do aluno
                                    CodCurso = reader1.GetInt16("idCurso");
                                    CodAluno = reader1.GetInt16("idAluno");
                                    teste = 0;
                                }
                                else
                                {
                                    teste = 1;
                                    NumMatricula = NumMatricula + 1;
                                }
                            }
                            reader1.Close();
                        }
                        else
                        {
                            teste = 0;
                        }
                    } while (teste == 1);

                    if (NumMatricula < maximo)
                    {
                        //Pegando agora os dados dos alunos da tebela aluno
                        mDataSet = new DataSet();
                        mConn = new MySqlConnection(Program.conexao);
                        string sql2 = "SELECT * FROM `aluno` WHERE idAluno = '" + CodAluno + "'";
                        mConn.Open();
                        MySqlCommand cmd2 = new MySqlCommand(sql2, mConn);
                        MySqlDataReader reader2 = cmd2.ExecuteReader();

                        while (reader2.Read())
                        {
                            txtNome.Text = reader2.GetString("nomeAluno");
                            txtRG.Text = reader2.GetString("RG");
                        }
                        reader2.Close();


                        //Pegando agora os dados dos alunos da tebela curso
                        mDataSet = new DataSet();
                        mConn = new MySqlConnection(Program.conexao);
                        string sql3 = "SELECT nomeCurso FROM `curso` WHERE idCurso = '" + CodCurso + "'";
                        mConn.Open();
                        MySqlCommand cmd3 = new MySqlCommand(sql3, mConn);
                        MySqlDataReader reader3 = cmd3.ExecuteReader();

                        while (reader3.Read())
                        {
                            txtdescC.Text = reader3.GetString("nomeCurso");
                        }
                        reader3.Close();
                    }
                    if (NumMatricula == maximo)
                    {
                        btnProx.Enabled = false;
                        txtNome.Enabled = true;
                        groupBox2.Enabled = true;
                        txtRG.Enabled = true;
                        txtCod.Enabled = true;
                        txtdescC.Enabled = true;
                        btnCad.Enabled = true;
                        string ano = DateTime.Now.Year.ToString();
                        txtData.Text = ano;
                        string sql = "SELECT COUNT(numeroPasta) from matricula WHERE concluinte = 'NÃO'";
                        mDataSet = new DataSet();
                        mConn = new MySqlConnection(Program.conexao);
                        MySqlCommand cmd = new MySqlCommand(sql, mConn);
                        mConn.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            contador = Convert.ToInt16(reader.GetString("COUNT(numeroPasta)"));
                            contador = contador + 1;
                            txtPasta.Text = Convert.ToString(contador);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Um erro inesperado aconteceu!");
                this.Close();
            }         
        }

        private void txtNomeRg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mDataSet = new DataSet();
                //codigo SQL
                try
                {
                    mAdapter = new MySqlDataAdapter("SELECT m.numeroMatricula, a.nomeAluno, a.RG, c.nomeCurso, m.numeroPasta, m.Concluinte, m.anoEnt FROM    matricula m JOIN    aluno AS a ON    m.idAluno = a.idAluno JOIn   curso AS c ON   m.idCurso = c.idCurso WHERE  a.RG LIKE '" + txtNomeRg.Text + "%' and (m.concluinte = 'SIM' or m.concluinte = 'NÃO');", mConn);
                    mAdapter.Fill(mDataSet, "Tabela_dados");
                    //atribui para o datagrid
                    dataGridPesq.DataSource = mDataSet;
                    dataGridPesq.DataMember = "Tabela_dados";
                    dataGridPesq.Columns[0].Width = 0;
                    dataGridPesq.Columns[1].Width = 350;
                    dataGridPesq.Columns[2].Width = 140;
                    dataGridPesq.Columns[3].Width = 250;
                    dataGridPesq.Columns[4].Width = 100;
                    dataGridPesq.Columns[5].Width = 80;
                    dataGridPesq.Columns[6].Width = 90;
                    dataGridPesq.Columns[1].HeaderText = "Nome do Aluno";
                    dataGridPesq.Columns[2].HeaderText = "RG";
                    dataGridPesq.Columns[3].HeaderText = "Nome do Curso";
                    dataGridPesq.Columns[4].HeaderText = "NºPasta";
                    dataGridPesq.Columns[5].HeaderText = "Concluinte";
                    dataGridPesq.Columns[6].HeaderText = "Ano";

                    dataGridPesq.RowHeadersWidth = 21;
                    dataGridPesq.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
                    dataGridPesq.ColumnHeadersHeight = 23;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR : " + ex);
                }
            }
        }

        private void dataGridPesq_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtDataEnt_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mDataSet = new DataSet();
                //codigo SQL
                mAdapter = new MySqlDataAdapter("SELECT m.numeroMatricula, a.nomeAluno, a.RG, c.nomeCurso, m.numeroPasta, m.Concluinte, m.anoEnt FROM    matricula m JOIN    aluno AS a ON    m.idAluno = a.idAluno JOIn   curso AS c ON   m.idCurso = c.idCurso WHERE  m.anoEnt LIKE '" + txtDataEnt.Text + "%' and (m.concluinte = 'SIM' or m.concluinte = 'NÃO');", mConn);
                mAdapter.Fill(mDataSet, "Tabela_dados");
                //atribui para o datagrid
                dataGridPesq.DataSource = mDataSet;
                dataGridPesq.DataMember = "Tabela_dados";
                dataGridPesq.Columns[0].Width = 0;
                dataGridPesq.Columns[1].Width = 350;
                dataGridPesq.Columns[2].Width = 140;
                dataGridPesq.Columns[3].Width = 250;
                dataGridPesq.Columns[4].Width = 100;
                dataGridPesq.Columns[5].Width = 80;
                dataGridPesq.Columns[6].Width = 90;
                dataGridPesq.Columns[1].HeaderText = "Nome do Aluno";
                dataGridPesq.Columns[2].HeaderText = "RG";
                dataGridPesq.Columns[3].HeaderText = "Nome do Curso";
                dataGridPesq.Columns[4].HeaderText = "NºPasta";
                dataGridPesq.Columns[5].HeaderText = "Concluinte";
                dataGridPesq.Columns[6].HeaderText = "Ano";

                dataGridPesq.RowHeadersWidth = 21;
                dataGridPesq.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
                dataGridPesq.ColumnHeadersHeight = 23;
            }
        }

        private void btnAnt_Click(object sender, EventArgs e)
        {
            /*txtNome.Enabled = true;
            txtRG.Enabled = true;
            txtCod.Enabled = true;
            txtCod.Enabled = true;*/
            groupBox2.Enabled = true;
            btnCad.Enabled = false;
            //Conluintes
            if (radC.Checked == true)
            {
                if (Contadorbtn == 0)
                {
                    numeroMatricula = 0;
                    Contadorbtn = 1;

                    //Verificando se há algum aluno cadastrado
                    mDataSet = new DataSet();
                    mConn = new MySqlConnection(Program.conexao);
                    string sql5 = "SELECT COUNT(numeroMatricula) FROM `matricula` where concluinte = 'SIM'";
                    mConn.Open();
                    MySqlCommand cmd5 = new MySqlCommand(sql5, mConn);
                    MySqlDataReader reader5 = cmd5.ExecuteReader();
                    while (reader5.Read())
                    {
                        CountMatricula = reader5.GetInt16("COUNT(numeroMatricula)");
                    }
                    reader5.Close();

                    if (CountMatricula != 0)
                    {
                        btnProx.Enabled = true;
                        //Pegando o primeiro numero de matricula cadastrado como concluinte
                        mDataSet = new DataSet();
                        mConn = new MySqlConnection(Program.conexao);
                        string sql4 = "SELECT MIN(numeroMatricula) FROM `matricula` WHERE concluinte = 'SIM'";
                        mConn.Open();
                        MySqlCommand cmd4 = new MySqlCommand(sql4, mConn);
                        MySqlDataReader reader4 = cmd4.ExecuteReader();

                        while (reader4.Read())
                        {
                            Program.minimo = reader4.GetInt16("MIN(numeroMatricula)");
                        }
                        reader4.Close();

                        //Pegando o ultimo numero de matricula cadastrado
                        mDataSet = new DataSet();
                        mConn = new MySqlConnection(Program.conexao);
                        string sql = "SELECT MAX(numeroMatricula) FROM `matricula`";
                        mConn.Open();
                        MySqlCommand cmd = new MySqlCommand(sql, mConn);
                        MySqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            NumMatricula = reader.GetInt16("MAX(numeroMatricula)");
                            maximo = reader.GetInt16("MAX(numeroMatricula)");
                            maximo = maximo + 1;
                        }
                        reader.Close();

                        teste = 0;
                        do
                        {
                            //Pegando agora os dados dos alunos da tebela matricula
                            mDataSet = new DataSet();
                            mConn = new MySqlConnection(Program.conexao);
                            string sql1 = "SELECT * FROM `matricula` WHERE numeroMatricula = '" + NumMatricula + "' ";
                            mConn.Open();
                            MySqlCommand cmd1 = new MySqlCommand(sql1, mConn);
                            MySqlDataReader reader1 = cmd1.ExecuteReader();

                            while (reader1.Read())
                            {
                                string verifica = reader1.GetString("concluinte");

                                if (verifica == "SIM")
                                {
                                    //Preenchendo os TextBoxs com os dados
                                    txtPasta.Text = reader1.GetString("numeroPasta");
                                    txtData.Text = reader1.GetString("anoEnt");

                                    //Capturando o Codigo do curso e o Id do aluno
                                    CodCurso = reader1.GetInt16("idCurso");
                                    CodAluno = reader1.GetInt16("idAluno");
                                    teste = 0;
                                }
                                else
                                {
                                    teste = 1;
                                    NumMatricula = NumMatricula - 1;
                                }
                            }
                            reader1.Close();
                        } while (teste == 1);

                        //Pegando agora os dados dos alunos da tebela aluno
                        mDataSet = new DataSet();
                        mConn = new MySqlConnection(Program.conexao);
                        string sql2 = "SELECT * FROM `aluno` WHERE idAluno = '" + CodAluno + "'";
                        mConn.Open();
                        MySqlCommand cmd2 = new MySqlCommand(sql2, mConn);
                        MySqlDataReader reader2 = cmd2.ExecuteReader();

                        while (reader2.Read())
                        {
                            txtNome.Text = reader2.GetString("nomeAluno");
                            txtRG.Text = reader2.GetString("RG");
                        }
                        reader2.Close();

                        //Pegando agora os dados dos alunos da tebela curso
                        mDataSet = new DataSet();
                        mConn = new MySqlConnection(Program.conexao);
                        string sql3 = "SELECT nomeCurso FROM `curso` WHERE idCurso = '" + CodCurso + "'";
                        mConn.Open();
                        MySqlCommand cmd3 = new MySqlCommand(sql3, mConn);
                        MySqlDataReader reader3 = cmd3.ExecuteReader();

                        while (reader3.Read())
                        {
                            txtdescC.Text = reader3.GetString("nomeCurso");
                        }
                        reader3.Close();
                        groupBox2.Enabled = false;
                    }
                }
                else
                    if (Contadorbtn == 1)
                    {
                    if (NumMatricula > Program.minimo)
                    {
                        NumMatricula = NumMatricula - 1;
                        do
                        {
                            //Pegando agora os dados dos alunos da tebela matricula
                            mDataSet = new DataSet();
                            mConn = new MySqlConnection(Program.conexao);
                            string sql1 = "SELECT * FROM `matricula` WHERE numeroMatricula = '" + NumMatricula + "' ";
                            mConn.Open();
                            MySqlCommand cmd1 = new MySqlCommand(sql1, mConn);
                            MySqlDataReader reader1 = cmd1.ExecuteReader();

                            while (reader1.Read())
                            {
                                string verifica = reader1.GetString("concluinte");

                                if (verifica == "SIM")
                                {
                                    //Preenchendo os TextBoxs com os dados
                                    txtPasta.Text = reader1.GetString("numeroPasta");
                                    txtData.Text = reader1.GetString("anoEnt");

                                    //Capturando o Codigo do curso e o Id do aluno
                                    CodCurso = reader1.GetInt16("idCurso");
                                    CodAluno = reader1.GetInt16("idAluno");
                                    teste = 0;
                                }
                                else
                                {
                                    teste = 1;
                                    NumMatricula = NumMatricula - 1;
                                }
                            }
                            reader1.Close();
                        } while (teste == 1);

                        //Pegando agora os dados dos alunos da tebela aluno
                        mDataSet = new DataSet();
                        mConn = new MySqlConnection(Program.conexao);
                        string sql2 = "SELECT * FROM `aluno` WHERE idAluno = '" + CodAluno + "'";
                        mConn.Open();
                        MySqlCommand cmd2 = new MySqlCommand(sql2, mConn);
                        MySqlDataReader reader2 = cmd2.ExecuteReader();

                        while (reader2.Read())
                        {
                            txtNome.Text = reader2.GetString("nomeAluno");
                            txtRG.Text = reader2.GetString("RG");
                        }
                        reader2.Close();

                        //Pegando agora os dados dos alunos da tebela curso
                        mDataSet = new DataSet();
                        mConn = new MySqlConnection(Program.conexao);
                        string sql3 = "SELECT nomeCurso FROM `curso` WHERE idCurso = '" + CodCurso + "'";
                        mConn.Open();
                        MySqlCommand cmd3 = new MySqlCommand(sql3, mConn);
                        MySqlDataReader reader3 = cmd3.ExecuteReader();

                        while (reader3.Read())
                        {
                            txtdescC.Text = reader3.GetString("nomeCurso");
                        }
                        reader3.Close();
                        groupBox2.Enabled = false;
                    }
                }
                numeroMatricula = numeroMatricula + 1;
                groupBox2.Enabled = false;
                btnProx.Enabled = true;
            }
            //Não concluintes
            else
            if (radNc.Checked == true)
            {
                if (Contadorbtn == 0)
                {
                    numeroMatricula = 0;
                    Contadorbtn = 1;

                    //Verificando se há algum aluno cadastrado
                    mDataSet = new DataSet();
                    mConn = new MySqlConnection(Program.conexao);
                    string sql5 = "SELECT COUNT(numeroMatricula) FROM `matricula` where concluinte = 'NÃO'";
                    mConn.Open();
                    MySqlCommand cmd5 = new MySqlCommand(sql5, mConn);
                    MySqlDataReader reader5 = cmd5.ExecuteReader();
                    while (reader5.Read())
                    {
                        CountMatricula = reader5.GetInt16("COUNT(numeroMatricula)");
                    }
                    reader5.Close();

                    if (CountMatricula != 0)
                    {
                        btnProx.Enabled = true;
                        //Pegando o primeiro numero de matricula cadastrado como concluinte
                        mDataSet = new DataSet();
                        mConn = new MySqlConnection(Program.conexao);
                        string sql4 = "SELECT MIN(numeroMatricula) FROM `matricula` WHERE concluinte = 'NÃO'";
                        mConn.Open();
                        MySqlCommand cmd4 = new MySqlCommand(sql4, mConn);
                        MySqlDataReader reader4 = cmd4.ExecuteReader();

                        while (reader4.Read())
                        {
                            Program.minimo = reader4.GetInt16("MIN(numeroMatricula)");
                        }
                        reader4.Close();

                        //Pegando o ultimo numero de matricula cadastrado
                        mDataSet = new DataSet();
                        mConn = new MySqlConnection(Program.conexao);
                        string sql = "SELECT MAX(numeroMatricula) FROM `matricula`";
                        mConn.Open();
                        MySqlCommand cmd = new MySqlCommand(sql, mConn);
                        MySqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            NumMatricula = reader.GetInt16("MAX(numeroMatricula)");
                            maximo = reader.GetInt16("MAX(numeroMatricula)");
                            maximo = maximo + 1;
                        }
                        reader.Close();


                        do
                        {
                            //Pegando agora os dados dos alunos da tebela matricula
                            mDataSet = new DataSet();
                            mConn = new MySqlConnection(Program.conexao);
                            string sql1 = "SELECT * FROM `matricula` WHERE numeroMatricula = '" + NumMatricula + "' ";
                            mConn.Open();
                            MySqlCommand cmd1 = new MySqlCommand(sql1, mConn);
                            MySqlDataReader reader1 = cmd1.ExecuteReader();

                            while (reader1.Read())
                            {
                                string verifica = reader1.GetString("concluinte");

                                if (verifica == "NÃO")
                                {
                                    //Preenchendo os TextBoxs com os dados
                                    txtPasta.Text = reader1.GetString("numeroPasta");
                                    txtData.Text = reader1.GetString("anoEnt");

                                    //Capturando o Codigo do curso e o Id do aluno
                                    CodCurso = reader1.GetInt16("idCurso");
                                    CodAluno = reader1.GetInt16("idAluno");
                                    teste = 0;
                                }
                                else
                                {
                                    teste = 1;
                                    NumMatricula = NumMatricula - 1;
                                }

                            }
                            reader1.Close();
                        } while (teste == 1);

                        //Pegando agora os dados dos alunos da tebela aluno
                        mDataSet = new DataSet();
                        mConn = new MySqlConnection(Program.conexao);
                        string sql2 = "SELECT * FROM `aluno` WHERE idAluno = '" + CodAluno + "'";
                        mConn.Open();
                        MySqlCommand cmd2 = new MySqlCommand(sql2, mConn);
                        MySqlDataReader reader2 = cmd2.ExecuteReader();

                        while (reader2.Read())
                        {
                            txtNome.Text = reader2.GetString("nomeAluno");
                            txtRG.Text = reader2.GetString("RG");
                        }
                        reader2.Close();

                        //Pegando agora os dados dos alunos da tebela curso
                        mDataSet = new DataSet();
                        mConn = new MySqlConnection(Program.conexao);
                        string sql3 = "SELECT nomeCurso FROM `curso` WHERE idCurso = '" + CodCurso + "'";
                        mConn.Open();
                        MySqlCommand cmd3 = new MySqlCommand(sql3, mConn);
                        MySqlDataReader reader3 = cmd3.ExecuteReader();

                        while (reader3.Read())
                        {
                            txtdescC.Text = reader3.GetString("nomeCurso");
                        }
                        reader3.Close();
                        groupBox2.Enabled = false; 
                    }
                }
                else
               if (Contadorbtn == 1)
                {
                    if (NumMatricula > Program.minimo)
                    {
                        do
                        {
                            NumMatricula = NumMatricula - 1;
                            //Pegando agora os dados dos alunos da tebela matricula
                            mDataSet = new DataSet();
                            mConn = new MySqlConnection(Program.conexao);
                            string sql1 = "SELECT * FROM `matricula` WHERE numeroMatricula = '" + NumMatricula + "' ";
                            mConn.Open();
                            MySqlCommand cmd1 = new MySqlCommand(sql1, mConn);
                            MySqlDataReader reader1 = cmd1.ExecuteReader();

                            while (reader1.Read())
                            {
                                string verifica = reader1.GetString("concluinte");

                                if (verifica == "NÃO")
                                {
                                    //Preenchendo os TextBoxs com os dados
                                    txtPasta.Text = reader1.GetString("numeroPasta");
                                    txtData.Text = reader1.GetString("anoEnt");

                                    //Capturando o Codigo do curso e o Id do aluno
                                    CodCurso = reader1.GetInt16("idCurso");
                                    CodAluno = reader1.GetInt16("idAluno");
                                    teste = 0;
                                }
                                else
                                {
                                    teste = 1;
                                    if (NumMatricula == Program.minimo)
                                    {
                                        teste = 0;
                                    }
                                }

                            }
                            reader1.Close();
                        } while (teste == 1);

                        //Pegando agora os dados dos alunos da tebela aluno
                        mDataSet = new DataSet();
                        mConn = new MySqlConnection(Program.conexao);
                        string sql2 = "SELECT * FROM `aluno` WHERE idAluno = '" + CodAluno + "'";
                        mConn.Open();
                        MySqlCommand cmd2 = new MySqlCommand(sql2, mConn);
                        MySqlDataReader reader2 = cmd2.ExecuteReader();

                        while (reader2.Read())
                        {
                            txtNome.Text = reader2.GetString("nomeAluno");
                            txtRG.Text = reader2.GetString("RG");
                        }
                        reader2.Close();

                        //Pegando agora os dados dos alunos da tebela curso
                        mDataSet = new DataSet();
                        mConn = new MySqlConnection(Program.conexao);
                        string sql3 = "SELECT nomeCurso FROM `curso` WHERE idCurso = '" + CodCurso + "'";
                        mConn.Open();
                        MySqlCommand cmd3 = new MySqlCommand(sql3, mConn);
                        MySqlDataReader reader3 = cmd3.ExecuteReader();

                        while (reader3.Read())
                        {
                            txtdescC.Text = reader3.GetString("nomeCurso");
                        }
                        reader3.Close();
                        groupBox2.Enabled = false;
                    }
                    numeroMatricula = numeroMatricula + 1;
                    groupBox2.Enabled = false;
                    btnProx.Enabled = true;
                }             
            }
        }

        private void txtNomeA_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mDataSet = new DataSet();
                //codigo SQL
                try
                {
                    mAdapter = new MySqlDataAdapter("SELECT m.numeroMatricula, a.nomeAluno, a.RG, c.nomeCurso, m.numeroPasta, m.Concluinte, m.anoEnt FROM    matricula m JOIN    aluno AS a ON    m.idAluno = a.idAluno JOIn   curso AS c ON   m.idCurso = c.idCurso WHERE  a.nomeAluno LIKE '" + txtNomeA.Text + "%' and (m.concluinte = 'SIM' or m.concluinte = 'NÃO');", mConn);
                    mAdapter.Fill(mDataSet, "Tabela_dados");
                    //atribui para o datagrid
                    dataGridPesq.DataSource = mDataSet;
                    dataGridPesq.DataMember = "Tabela_dados";
                    dataGridPesq.Columns[0].Width = 0;
                    dataGridPesq.Columns[1].Width = 350;
                    dataGridPesq.Columns[2].Width = 140;
                    dataGridPesq.Columns[3].Width = 250;
                    dataGridPesq.Columns[4].Width = 100;
                    dataGridPesq.Columns[5].Width = 80;
                    dataGridPesq.Columns[6].Width = 90;
                    dataGridPesq.Columns[1].HeaderText = "Nome do Aluno";
                    dataGridPesq.Columns[2].HeaderText = "RG";
                    dataGridPesq.Columns[3].HeaderText = "Nome do Curso";
                    dataGridPesq.Columns[4].HeaderText = "NºPasta";
                    dataGridPesq.Columns[5].HeaderText = "Concluinte";
                    dataGridPesq.Columns[6].HeaderText = "Ano";

                    dataGridPesq.RowHeadersWidth = 21;
                    dataGridPesq.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
                    dataGridPesq.ColumnHeadersHeight = 23;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR : " + ex);
                }
            }
        }


        private void txtNumP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mDataSet = new DataSet();
                //codigo SQL
                mAdapter = new MySqlDataAdapter("SELECT m.numeroMatricula, a.nomeAluno, a.RG, c.nomeCurso, m.numeroPasta, m.Concluinte, m.anoEnt FROM    matricula m JOIN    aluno AS a ON    m.idAluno = a.idAluno JOIn   curso AS c ON   m.idCurso = c.idCurso WHERE  m.numeroPasta LIKE '" + txtNumP.Text + "%' and (m.concluinte = 'SIM' or m.concluinte = 'NÃO');", mConn);
                mAdapter.Fill(mDataSet, "Tabela_dados");
                //atribui para o datagrid
                dataGridPesq.DataSource = mDataSet;
                dataGridPesq.DataMember = "Tabela_dados";
                dataGridPesq.Columns[0].Width = 0;
                dataGridPesq.Columns[1].Width = 350;
                dataGridPesq.Columns[2].Width = 140;
                dataGridPesq.Columns[3].Width = 250;
                dataGridPesq.Columns[4].Width = 100;
                dataGridPesq.Columns[5].Width = 80;
                dataGridPesq.Columns[6].Width = 90;
                dataGridPesq.Columns[1].HeaderText = "Nome do Aluno";
                dataGridPesq.Columns[2].HeaderText = "RG";
                dataGridPesq.Columns[3].HeaderText = "Nome do Curso";
                dataGridPesq.Columns[4].HeaderText = "NºPasta";
                dataGridPesq.Columns[5].HeaderText = "Concluinte";
                dataGridPesq.Columns[6].HeaderText = "Ano";

                dataGridPesq.RowHeadersWidth = 21;
                dataGridPesq.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
                dataGridPesq.ColumnHeadersHeight = 23;
            }
        }

        private void comboNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mDataSet = new DataSet();
                //codigo SQL
                try
                {
                    mAdapter = new MySqlDataAdapter("SELECT m.numeroMatricula, a.nomeAluno, a.RG, c.nomeCurso, m.numeroPasta, m.Concluinte, m.anoEnt FROM    matricula m JOIN    aluno AS a ON    m.idAluno = a.idAluno JOIn   curso AS c ON   m.idCurso = c.idCurso WHERE  c.nomeCurso LIKE '" + comboNome.Text + "%' and (m.concluinte = 'SIM' or m.concluinte = 'NÃO');", mConn);
                    mAdapter.Fill(mDataSet, "Tabela_dados");
                    //atribui para o datagrid
                    dataGridPesq.DataSource = mDataSet;
                    dataGridPesq.DataMember = "Tabela_dados";
                    dataGridPesq.Columns[0].Width = 0;
                    dataGridPesq.Columns[1].Width = 350;
                    dataGridPesq.Columns[2].Width = 140;
                    dataGridPesq.Columns[3].Width = 250;
                    dataGridPesq.Columns[4].Width = 100;
                    dataGridPesq.Columns[5].Width = 80;
                    dataGridPesq.Columns[6].Width = 90;
                    dataGridPesq.Columns[1].HeaderText = "Nome do Aluno";
                    dataGridPesq.Columns[2].HeaderText = "RG";
                    dataGridPesq.Columns[3].HeaderText = "Nome do Curso";
                    dataGridPesq.Columns[4].HeaderText = "NºPasta";
                    dataGridPesq.Columns[5].HeaderText = "Concluinte";
                    dataGridPesq.Columns[6].HeaderText = "Ano";
                    dataGridPesq.RowHeadersWidth = 21;
                    dataGridPesq.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
                    dataGridPesq.ColumnHeadersHeight = 23;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR : " + ex);
                }
            }
        }
        private void radNc_CheckedChanged(object sender, EventArgs e)
        {
            txtdescC.Enabled = true;
            txtNome.Enabled = true;
            txtRG.Enabled = true;
            txtNome.Text = "";
            txtData.Text = "";
            string ano = DateTime.Now.Year.ToString();
            txtData.Text = ano;
            txtRG.Text = "";
            txtCod.Text = "";
            txtdescC.Text = "";
            btnProx.Enabled = false;
            btnCad.Enabled = true;
            Contadorbtn = 0;
            maximo = 0;
            NumMatricula = 0;
            txtNome.Focus();
            if (radC.Checked == true)
            {
                groupBox2.Enabled = true;
                concluinte = "SIM";
                string sql = "SELECT COUNT(numeroPasta) from matricula WHERE concluinte = 'SIM'";
                mDataSet = new DataSet();
                mConn = new MySqlConnection(Program.conexao);
                MySqlCommand cmd = new MySqlCommand(sql, mConn);
                mConn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (Program.MConfig == "Config - 1")
                    {
                        int contador;
                        contador = Convert.ToInt16(reader.GetString("COUNT(numeroPasta)"));
                        contador = contador + 1;
                        txtPasta.Text = Convert.ToString(contador);
                    }
                    else
                        if (Program.MConfig == "Config - 2")
                    {
                        string sql2 = "SELECT TrocaAno FROM `config`";
                        mDataSet = new DataSet();
                        mConn = new MySqlConnection(Program.conexao);
                        MySqlCommand cmd2 = new MySqlCommand(sql2, mConn);
                        mConn.Open();
                        MySqlDataReader reader2 = cmd2.ExecuteReader();

                        while (reader2.Read())
                        {
                            trocaAno = reader2.GetString("TrocaAno");
                            if (trocaAno == "ManterSequencia")
                            {
                                int contador;
                                contador = Convert.ToInt16(reader.GetString("COUNT(numeroPasta)"));
                                contador = contador + 1;
                                txtPasta.Text = Convert.ToString(txtData.Text + " - " + contador);
                            }
                            else
                                if (trocaAno == "NovaSequencia")
                            {
                                string sql3 = "SELECT COUNT(numeroPasta) from matricula WHERE concluinte = 'SIM' and anoEnt = '" + txtData.Text + "'";
                                mDataSet = new DataSet();
                                mConn = new MySqlConnection(Program.conexao);
                                MySqlCommand cmd3 = new MySqlCommand(sql3, mConn);
                                mConn.Open();
                                MySqlDataReader reader3 = cmd3.ExecuteReader();

                                while (reader3.Read())
                                {
                                    int contador;
                                    contador = Convert.ToInt16(reader3.GetString("COUNT(numeroPasta)"));
                                    contador = contador + 1;
                                    txtPasta.Text = Convert.ToString(txtData.Text + " - " + contador);
                                }
                            }
                        }
                    }
                }
            }
            else if (radNc.Checked == true)
            {
                groupBox2.Enabled = true;
                concluinte = "NÃO";
                string sql = "SELECT COUNT(numeroPasta) from matricula WHERE concluinte = 'NÃO'";
                mDataSet = new DataSet();
                mConn = new MySqlConnection(Program.conexao);
                MySqlCommand cmd = new MySqlCommand(sql, mConn);
                mConn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (Program.MConfig == "Config - 1")
                    {
                        contador = Convert.ToInt16(reader.GetString("COUNT(numeroPasta)"));
                        contador = contador + 1;
                        txtPasta.Text = Convert.ToString(contador);
                    }
                    else
                       if (Program.MConfig == "Config - 2")
                    {
                        string sql2 = "SELECT TrocaAno FROM `config`";
                        mDataSet = new DataSet();
                        mConn = new MySqlConnection(Program.conexao);
                        MySqlCommand cmd2 = new MySqlCommand(sql2, mConn);
                        mConn.Open();
                        MySqlDataReader reader2 = cmd2.ExecuteReader();

                        while (reader2.Read())
                        {
                            trocaAno = reader2.GetString("TrocaAno");
                            if (trocaAno == "ManterSequencia")
                            {
                                int contador;
                                contador = Convert.ToInt16(reader.GetString("COUNT(numeroPasta)"));
                                contador = contador + 1;
                                txtPasta.Text = Convert.ToString(txtData.Text + " - " + contador);
                            }
                            else
                                if (trocaAno == "NovaSequencia")
                            {
                                string sql3 = "SELECT COUNT(numeroPasta) from matricula WHERE concluinte = 'NÃO' and anoEnt = '" + txtData.Text + "'";
                                mDataSet = new DataSet();
                                mConn = new MySqlConnection(Program.conexao);
                                MySqlCommand cmd3 = new MySqlCommand(sql3, mConn);
                                mConn.Open();
                                MySqlDataReader reader3 = cmd3.ExecuteReader();

                                while (reader3.Read())
                                {
                                    int contador;
                                    contador = Convert.ToInt16(reader3.GetString("COUNT(numeroPasta)"));
                                    contador = contador + 1;
                                    txtPasta.Text = Convert.ToString(txtData.Text + " - " + contador);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
