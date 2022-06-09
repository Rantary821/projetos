using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Data.OleDb;

namespace ArquivoEtec
{
    public partial class CadAluno : Form
    {
        string sqlPesq = "select top 10 m.idPrimario, m.idMatricula, a.nome, c.NomeCurso, m.Concluinte " +
           "from aluno a JOIN dbo.matricula m ON m.idAluno = a.idAluno " +
           "JOIN dbo.curso c ON c.IdCurso = m.idCurso WHERE m.Deletado = 'NAO' ORDER by m.idPrimario DESC;", situacao, VCpf, VNome, VRg, VAno, VCodCurso, VCel1, VCel2, VTel1, VTel2, VEmail1, VEmail2, VBairro, VRua, VComplemento, VCidade, VNumero, VCep, VUf;
        int qnt;//, idMatricula;

        string idMatricula;

        bool modoUpdate = false;

        Utilidades uti = new Utilidades();

        SqlConnection mConn;


        public CadAluno()
        {
            InitializeComponent();

            this.gridUltimos.ScrollBars = ScrollBars.None;
            this.gridUltimos.MouseWheel += new MouseEventHandler(mousewheel);

            VerifyContato();

            Cores();
        }

        public void mousewheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0 && gridUltimos.FirstDisplayedScrollingRowIndex > 0)
            {
                gridUltimos.FirstDisplayedScrollingRowIndex--;
            }
            else if (e.Delta < 0)
            {
                gridUltimos.FirstDisplayedScrollingRowIndex++;
            }
        }

        void Conect(bool AbreFecha)
        {
            try
            {
                mConn = new SqlConnection(Program.conecta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errro de conexão com o banco!" + Environment.NewLine + ex);
            }

            if (AbreFecha)
            {
                mConn.Open();
            }
            else
            {
                mConn.Close();
            }
        }

        private void btnAtl_Click(object sender, EventArgs e)
        {
            if (txtLimit.Text != "")
            {
                qnt = Convert.ToInt32(txtLimit.Text);
            }
            else
            {
                qnt = 5;
            }

            string sqlPesq1 = "select top " + qnt + " m.idPrimario, m.idMatricula, a.nome, c.NomeCurso, m.Concluinte from aluno a " +
                "JOIN dbo.matricula m ON m.idAluno = a.idAluno JOIN dbo.curso c ON c.IdCurso = m.idCurso WHERE m.Deletado = 'NAO' ORDER by m.idPrimario DESC;";

            PreencheGridCadastros(sqlPesq1);
        }

        private void BtnClose_Click_1(object sender, EventArgs e)
        {
            uti.buscaConfig();
            this.Close();
        }

        private void PreencheGridCadastros(string sql)
        {
            Conect(true);

            try
            {
                SqlCommand cmd = new SqlCommand(sql, mConn);
                cmd.Connection = mConn;
                cmd.CommandText = sql;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                gridUltimos.DataSource = dataSet;
                gridUltimos.DataMember = dataSet.Tables[0].TableName;

                gridUltimos.Columns[0].Visible = false;//IdPrimario oculto para usar em pesquisas
                gridUltimos.Columns[1].Width = 80;
                gridUltimos.Columns[2].Width = 160;
                gridUltimos.Columns[3].Width = 160;
                gridUltimos.Columns[4].Width = 90;

                gridUltimos.Columns[1].HeaderText = "Pasta";
                gridUltimos.Columns[2].HeaderText = "Nome";
                gridUltimos.Columns[3].HeaderText = "Curso";
                gridUltimos.Columns[4].HeaderText = "Concluinte";

                //Alinhamento centralizado para pasta e concluinte
                gridUltimos.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                gridUltimos.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                uti.GridviewColors(gridUltimos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na busca de alunos!1" + Environment.NewLine + ex);
            }

            Conect(false);
        }

        private void CadAluno_Load(object sender, EventArgs e)
        {
            btnLimpar.Image = Properties.Resources.Limpar_32x32;//Para setar o icone de limpar
            BloquearLiberarTxts(false);//Bloquear os txts
            PreencheGridCadastros(sqlPesq);//Pesquisa ultimos alunos cadastrados
            boxContato.Enabled = false;//Bloqueia a area dos contatos

            buscaCursos();

            ComboCurso.SelectedIndex = -1;
            TxtCodCurso.Text = "";
        }

        void buscaCursos()
        {
            Conect(true);

            try
            {
                SqlCommand mAdapter = new SqlCommand("SELECT * FROM curso ORDER by IdCurso;", mConn);
                SqlDataReader reader = mAdapter.ExecuteReader();//retorna dados resultantes da consulta em SQL
                DataTable table = new DataTable(); //estrutura da tabela do banco de dados ou de outra fonte de informação
                table.Load(reader); //carrega dados na tabela de acordo com a instrução sql passada 
                DataRow row = table.NewRow(); //representa uma linha de dados em um DataTable
                row["NomeCurso"] = ""; //para não gerar valor nulo e, consequentemente, evitar erro de execução


                this.ComboCurso.DataSource = table;
                this.ComboCurso.ValueMember = "IdCurso";
                this.ComboCurso.DisplayMember = "NomeCurso";//obtem o nome do curso
                reader.Close();//fecha o objeto
                reader.Dispose();//liberamos o objeto da memoria

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na busca dos cursos cadastrados!" + Environment.NewLine + ex);
            }

            Conect(false);
        }

        void BloquearLiberarTxts(bool var)//false bloqueia  -  true desbloqueia
        {
            TxtNome.Enabled = var;
            TxtRg.Enabled = var;
            TxtCel1.Enabled = var;
            TxtCel2.Enabled = var;
            TxtTel1.Enabled = var;
            TxtTel2.Enabled = var;
            TxtEmail1.Enabled = var;
            TxtEmail2.Enabled = var;
            TxtBairro.Enabled = var;
            TxtRua.Enabled = var;
            TxtComplemento.Enabled = var;
            txtCidade.Enabled = var;
            txtUf.Enabled = var;
            TxtNumero.Enabled = var;
            TxtCep.Enabled = var;
            boxContato.Enabled = var;
        }

        void ClearAllText(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                if (c is MaskedTextBox)
                    ((MaskedTextBox)c).Clear();
                else
                    ClearAllText(c);
            }
        }
   
        private void RadNConcluinte_CheckedChanged(object sender, EventArgs e)
        {
            if (txtLimit.Text == "")
            {
                txtLimit.Text = "10";
            }

            if (RadNConcluinte.Checked)
            {
                GridDados.Enabled = true;
                BtnCad.Visible = true;
                situacao = "NAO";

                RadNConcluinte.BackColor = Utilidades.NConcluinteCor;
                RadConcluinte.BackColor = Utilidades.BackForm;

                if (!modoUpdate)
                {
                    idMatricula = uti.SelectMaxIDMatricula(situacao).ToString();
                    TxtPasta.Text = idMatricula.ToString();

                    PreencheGridCadastros("select top " + txtLimit.Text + " m.idPrimario, m.idMatricula, a.nome, c.NomeCurso, m.Concluinte from aluno a " +
                    "JOIN dbo.matricula m ON m.idAluno = a.idAluno JOIN dbo.curso c ON c.IdCurso = m.idCurso WHERE m.Deletado = 'NAO' AND m.Concluinte = 'NAO' ORDER by m.idPrimario DESC;");

                }
            }
            else
            {
                situacao = "";
            }

            if (RadConcluinte.Checked == false && RadNConcluinte.Checked == false)
            {
                GridDados.Enabled = false;
                BtnCad.Visible = false;
            }
        }

        private void RadConcluinte_CheckedChanged(object sender, EventArgs e)
        {
            if (txtLimit.Text == "")
            {
                txtLimit.Text = "10";
            }

            if (RadConcluinte.Checked)
            {
                GridDados.Enabled = true;
                BtnCad.Visible = true;
                situacao = "SIM";

                RadConcluinte.BackColor = Utilidades.ConcluinteCor;
                RadNConcluinte.BackColor = Utilidades.BackForm;

                if (!modoUpdate)
                {
                    idMatricula = uti.SelectMaxIDMatricula(situacao).ToString();
                    TxtPasta.Text = idMatricula.ToString();

                    PreencheGridCadastros("select top " + txtLimit.Text + " m.idPrimario, m.idMatricula, a.nome, c.NomeCurso, m.Concluinte from aluno a " +
                    "JOIN dbo.matricula m ON m.idAluno = a.idAluno JOIN dbo.curso c ON c.IdCurso = m.idCurso WHERE m.Deletado = 'NAO' AND m.Concluinte = 'SIM' ORDER by m.idPrimario DESC;");

                }
            }
            else
            {
                situacao = "";
            }

            if (RadConcluinte.Checked == false && RadNConcluinte.Checked == false)
            {
                GridDados.Enabled = false;
                BtnCad.Visible = false;
            }
        }

        private void BtnCad_Click(object sender, EventArgs e)
        {
            Conect(true);

            int idAluno = 0;
            string cpf = TxtCpf.Text, c1, c2, t1, t2;
            LblErro.Text = "";

            //Pegando apenas os digitos dos texts, para tirar a mascara
            cpf = String.Concat(cpf.Where(Char.IsDigit));
            c1 = String.Concat(TxtCel1.Text.Where(Char.IsDigit));
            c2 = String.Concat(TxtCel2.Text.Where(Char.IsDigit));
            t1 = String.Concat(TxtTel1.Text.Where(Char.IsDigit));
            t2 = String.Concat(TxtTel2.Text.Where(Char.IsDigit));

            //Verificação dos campos q devem estar preenchidos
            if ((RadConcluinte.Checked || RadNConcluinte.Checked) && TxtNome.Text != "" && TxtCpf.Text != "   .   .   -" && TxtPasta.Text != "" && TxtAno.Text != "" && TxtCodCurso.Text != "" && ImgTrue.Visible && ComboCurso.SelectedIndex != -1)
            {
                if (uti.BuscarCpf(cpf))//Caso o cpf já possua cadastro
                {
                    idAluno = uti.IDAlunoPorCPF(cpf);//Pega o id do aluno atravez do cpf
                    //Inserção da matricula
                    uti.InsertIntoMatricula(idMatricula.ToString(), idAluno.ToString(), TxtCodCurso.Text.ToString(), TxtAno.Text.ToString(), situacao);
                }
                else//Caso o cpf não possua cadastro
                {
                    try
                    {
                        idAluno = uti.SelectMaxIDAluno();
                        idAluno++;

                        using (IDbTransaction tran = mConn.BeginTransaction())
                        {
                            try
                            {
                                uti.InsertIntoAluno(TxtNome.Text, TxtRg.Text, cpf);
                                uti.InsertIntoContato(c1, c2, t1, t2, TxtEmail1.Text, TxtEmail2.Text, idAluno);
                                uti.InsertIntoEndereco(TxtRua.Text, TxtBairro.Text, TxtNumero.Text, TxtComplemento.Text, txtCidade.Text, TxtCep.Text, txtUf.Text, idAluno.ToString());
                                uti.InsertIntoMatricula(idMatricula.ToString(), idAluno.ToString(), TxtCodCurso.Text.ToString(), TxtAno.Text.ToString(), situacao);
                                tran.Commit();

                                PreencheGridCadastros(sqlPesq);
                            }
                            catch
                            {
                                tran.Rollback();
                                throw;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro de comunicação com o banco!" + ex);
                    }
                }

                ClearAllText(this);
                btnAtl_Click(sender, e);
                RadConcluinte.Checked = false;
                RadNConcluinte.Checked = false;
                BloquearLiberarTxts(false);


            }
            else
            {
                if (ImgTrue.Visible == false)
                {
                    LblErro.Text += "Cpf Invalido!  -  ";
                }

                if (TxtNome.Text == "")
                {
                    LblErro.Text += "Preencha o nome!  -  ";
                }

                if (TxtCpf.Text == "")
                {
                    LblErro.Text += "Preencha o Cpf!  -  ";
                }

                if (TxtAno.Text == "")
                {
                    LblErro.Text += "Preencha o ano!  -  ";
                }

                if (TxtCodCurso.Text == "" || ComboCurso.SelectedIndex == -1)
                {
                    LblErro.Text += "Selecione um curso!";
                }
            }
        }

        private void ComboCurso_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TxtCodCurso.Text = ComboCurso.SelectedValue.ToString();
            }
            catch
            {

            }
        }

        private void TxtCpf_Click(object sender, EventArgs e)
        {
            //Caso clique e não tenha nada preenchido leva o cursor para o inicio
            if (TxtCpf.Text == "   .   .   -")
            {
                TxtCpf.Select(0, 0);
            }
        }

        private void TxtCel1_Click(object sender, EventArgs e)
        {
            //Caso clique e não tenha nada preenchido leva o cursor para o inicio
            if (TxtCel1.Text == "(  )     -")
            {
                TxtCel1.Select(0, 0);
            }
        }

        private void TxtRg_Click(object sender, EventArgs e)
        {
            if (TxtRg.Text == "")
            {
                TxtRg.Select(0, 0);
            }
        }

        private void TxtTel1_Click(object sender, EventArgs e)
        {
            //Caso clique e não tenha nada preenchido leva o cursor para o inicio
            if (TxtTel1.Text == "(  )    -")
            {
                TxtTel1.Select(0, 0);
            }
        }

        private void TxtCel2_Click(object sender, EventArgs e)
        {
            //Caso clique e não tenha nada preenchido leva o cursor para o inicio
            if (TxtCel2.Text == "(  )     -")
            {
                TxtCel2.Select(0, 0);
            }
        }

        private void TxtTel2_Click(object sender, EventArgs e)
        {
            //Caso clique e não tenha nada preenchido leva o cursor para o inicio
            if (TxtTel2.Text == "(  )    -")
            {
                TxtTel2.Select(0, 0);
            }
        }

        private void TxtCpf_TextChanged(object sender, EventArgs e)
        {
            //validação do cpf
            
            string cpf = TxtCpf.Text, ValCpf = "";
            cpf = String.Concat(cpf.Where(Char.IsDigit)); //Concatena apenas os digitos para tirar a mascara

            if (cpf.Length >= 9)
            {
                if (cpf.Length == 11 && cpf.Distinct().Count() != 1) //varifica se o tamanho é igual a 11 digitos, verifica se possui todos os digitos iguais 
                {
                    int Sum = 0, Mult = 0, Dig1 = 0, Dig2 = 0;

                    Mult = 10; //Primeira multiplicação é feita por 10

                    for (int i = 0; i < 9; i++)//Validação do primeiro digito
                    {
                        ValCpf += cpf[i].ToString();

                        //Cada um dos primeiros 9 caracteres são multiplicados, o primeiro caracter por 10, o segundo por 9, terceiro por 8, etc.
                        Sum += (Convert.ToInt32(cpf[i].ToString()) * Mult);

                        Mult--;
                    }

                    if (((Sum * 10) % 11) > 9)//Caso o resultado da operação sejá maior q 9, obrigatoriamente o digito recebe valor 0
                    {
                        Dig1 = 0;
                    }
                    else//caso seja menor q 9, o digito recebe o proprio resultado da operação
                    {
                        Dig1 = (Sum * 10) % 11;
                    }

                    ValCpf += Dig1;

                    bool verify1 = uti.CompararCpf(10, ValCpf, cpf);//Comparãção dos digitos

                    if (verify1)//Caso a primeira comparação resulte em true 
                    {
                        Mult = 11;
                        ValCpf = "";
                        Sum = 0;

                        for (int i = 0; i < 10; i++)//Validação do segundo digito
                        {
                            ValCpf += cpf[i].ToString();

                            //Cada um dos primeiros 10 caracteres são multiplicados, o primeiro caracter por 11, o segundo por 10, terceiro por 9, etc.
                            Sum += (Convert.ToInt32(cpf[i].ToString()) * Mult);

                            Mult--;
                        }

                        if (((Sum * 10) % 11) > 9)//Caso o resultado for maior q 9 o digito revebe 0
                        {
                            Dig2 = 0;
                        }
                        else
                        {
                            Dig2 = (Sum * 10) % 11;//Caso o resultado for menor o digito recebe o proprio valor da operação
                        }

                        ValCpf += Dig2;

                        bool verify2 = uti.CompararCpf(11, ValCpf, cpf);//Nova comparação dos digitos

                        if (verify2)//Caso a segunda comparação resulte em true 
                            {
                            ImgTrue.Visible = true;
                            ImgFalse.Visible = false;
                            TxtCodCurso.Enabled = true;
                            ComboCurso.Enabled = true;
                            TxtAno.Enabled = true;
                        
                            if (uti.BuscarCpf(cpf))
                            {
                                BuscarDados(cpf, "a.cpf = @Pesq");
                            }
                            BloquearLiberarTxts(true);
                        }
                        else//Caso a segunda comparação resulte em false
                        {
                            ImgTrue.Visible = false;
                            ImgFalse.Visible = true;
                            TxtCodCurso.Enabled = false;
                            ComboCurso.Enabled = false;
                            TxtAno.Enabled = false;

                            BloquearLiberarTxts(false);
                        }
                    }
                    else//Caso a primeira comparação resulte em false
                    {
                        ImgTrue.Visible = false;
                        ImgFalse.Visible = true;
                    }
                }
                else
                if(cpf.Length == 11 && cpf.Distinct().Count() == 1)
                {
                    if(cpf == "00000000000")
                    {
                        /*uti.ApelMessageBox("Deseja mesmo cadastrar o aluno sem CPF?;", "btn1* btn2'", "Sim; Não;", "a");
                        if(Program.MBResposta == "Sim")
                        {*/
                            ImgTrue.Visible = true;
                            ImgFalse.Visible = false;
                            TxtCodCurso.Enabled = true;
                            ComboCurso.Enabled = true;
                            TxtAno.Enabled = true;

                            BloquearLiberarTxts(true);
                        //}
                    }
                }
            }
            if (cpf.Length < 11)
            {
                ImgFalse.Visible = false;
                ImgTrue.Visible = false;
            }

            if (modoUpdate)//caso esteja liberado o update no momento
            {
                ValidaUpdate();
            }
        }

        private void gridUltimos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            modoUpdate = false;
            string idPrimario = "", concluinte = "", cpf = "", idAluno = "";

            try
            {
                Conect(true);

                idPrimario = gridUltimos.CurrentRow.Cells[0].Value.ToString();

                string sql = "SELECT m.idCurso, m.idMatricula, a.cpf, m.AnoMat, m.Concluinte, a.idAluno " +
                    "FROM matricula m JOIN aluno a ON m.idAluno = a.idAluno " +
                    "WHERE m.idPrimario = @idPri";
                using (SqlCommand cmd1 = new SqlCommand(sql, mConn))
                {
                    cmd1.Parameters.AddWithValue("@idPri", idPrimario);
                    cmd1.ExecuteNonQuery();

                    SqlDataReader reader = cmd1.ExecuteReader();
                    while (reader.Read())
                    {
                        TxtCodCurso.Text = Convert.ToString(reader.GetInt32(0));
                        TxtPasta.Text = reader.GetString(1);
                        cpf = reader.GetString(2);
                        TxtAno.Text = Convert.ToString(reader.GetInt32(3));
                        concluinte = reader.GetString(4);
                        idAluno = reader.GetInt32(5).ToString();
                    }
                }

                modoUpdate = true;//Para diferencia operações de cadastro e operações de update

                if (concluinte == "SIM")
                {
                    RadConcluinte.CheckedChanged -= RadConcluinte_CheckedChanged;
                    RadConcluinte.Checked = true;
                    RadConcluinte.CheckedChanged += RadConcluinte_CheckedChanged;
                }
                else
                if (concluinte == "NAO")
                {
                    RadNConcluinte.CheckedChanged -= RadNConcluinte_CheckedChanged;
                    RadNConcluinte.Checked = true;
                    RadNConcluinte.CheckedChanged += RadNConcluinte_CheckedChanged;
                }

                BloquearLiberarTxts(true);
                GridDados.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

            if (cpf.Distinct().Count() == 1)
            {
                TxtCpf.TextChanged -= TxtCpf_TextChanged;
                TxtCpf.Text = cpf;
                TxtCpf.TextChanged += TxtCpf_TextChanged;

                BuscarDados(idAluno, "a.idAluno = @Pesq");
            }
            else
            {
                TxtCpf.Text = cpf;
            }

            TxtCpf.Enabled = false;
            BtnUpdate.Visible = false;
            BtnCad.Visible = false;
            BtnExcluir.Visible = true;
            RadConcluinte.Enabled = false;
            RadNConcluinte.Enabled = false;
            
            btnLimpar.Image = Properties.Resources.cancel_32x32;
            btnLimpar.Text = "CANCELAR";
            
            Pegavalores();
            Conect(false);
        }

        private bool BuscarDados(string Pesq, string sql)
        {
            bool AlunoExist = false;
            try
            {
                Conect(true);

                string sql1 = "SELECT a.nome, a.rg, c.Cel1, c.Cel2, c.Tel1, c.Tel2, c.Email1, c.Email2, e.bairro, e.rua, e.complemento, e.Cidade, e.numero, e.Cep, e.Uf" +
                " FROM aluno a INNER JOIN contato c ON a.IdAluno = c.IdAluno INNER JOIN endereco e ON a.IdAluno = e.IdAluno WHERE " + sql;
                using (SqlCommand cmd1 = new SqlCommand(sql1, mConn))
                {
                    cmd1.Parameters.AddWithValue("@Pesq", Pesq);
                    cmd1.ExecuteNonQuery();

                    SqlDataReader reader = cmd1.ExecuteReader();
                    while (reader.Read())
                    {
                        TxtNome.Text = reader.GetString(0);
                        TxtRg.Text = reader.GetString(1);
                        TxtCel1.Text = reader.GetString(2);
                        TxtCel2.Text = reader.GetString(3);
                        TxtTel1.Text = reader.GetString(4);
                        TxtTel2.Text = reader.GetString(5);
                        TxtEmail1.Text = reader.GetString(6);
                        TxtEmail2.Text = reader.GetString(7);
                        TxtBairro.Text = reader.GetString(8);
                        TxtRua.Text = reader.GetString(9);
                        TxtComplemento.Text = reader.GetString(10);
                        txtCidade.Text = reader.GetString(11);
                        TxtNumero.Text = reader.GetString(12);
                        TxtCep.Text = reader.GetString(13);
                        txtUf.Text = reader.GetString(14);

                        AlunoExist = true;
                    }
                }
                Conect(false);
            }
            catch(Exception)
            {

            }
            return AlunoExist;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ClearAllText(this);
            BloquearLiberarTxts(false);
            BtnCad.Visible = false;
            GridDados.Enabled = false;

            RadConcluinte.CheckedChanged -= RadConcluinte_CheckedChanged;
            RadNConcluinte.CheckedChanged -= RadNConcluinte_CheckedChanged;

            RadConcluinte.Checked = false;
            RadNConcluinte.Checked = false;

            RadConcluinte.CheckedChanged += RadConcluinte_CheckedChanged;
            RadNConcluinte.CheckedChanged += RadNConcluinte_CheckedChanged;

            modoUpdate = false;
            btnLimpar.Text = "LIMPAR (F3)";
            TxtCpf.Enabled = true;
            RadConcluinte.Enabled = true;
            RadNConcluinte.Enabled = true;
            BtnExcluir.Visible = false;
            btnLimpar.Image = Properties.Resources.Limpar_32x32;
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            Conect(true);

            uti.ApelMessageBox("Após a exclusão os dados do aluno não serão acessiveis!!;Excluir aluno?;", "Btn1* btn2'", "Sim; Não;", "A");
            if(Program.MBResposta == "Sim")
            {
                using (IDbTransaction tran = mConn.BeginTransaction())
                {
                    try
                    {
                        //chama metodo para "Excluir aluno"
                        uti.DeleleAluno(gridUltimos.CurrentRow.Cells[0].Value.ToString());

                        btnLimpar_Click(sender, e);//limar os campos

                        PreencheGridCadastros(sqlPesq);//preenche grid de ultimos cadastros
                        tran.Commit();
                    }
                    catch
                    {
                        MessageBox.Show("Erro ao tentar excluir o aluno!!");
                        tran.Rollback();
                        throw;
                    }
                }
            }
            
            Conect(false);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            mouseClicked = true;
            clickedAt = e.Location;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseClicked)
            {
                this.Location = new Point(Cursor.Position.X - clickedAt.X, Cursor.Position.Y - clickedAt.Y);
            }
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClicked = false;
        }
        bool mouseClicked;
        Point clickedAt;
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Conect(true);

                string idPrimario = gridUltimos.CurrentRow.Cells[0].Value.ToString();

                //Pegando apenas digitos para tirar a mascara
                string cpf = String.Concat(TxtCpf.Text.Where(Char.IsDigit));
                string c1 = String.Concat(TxtCel1.Text.Where(Char.IsDigit));
                string c2 = String.Concat(TxtCel2.Text.Where(Char.IsDigit));
                string t1 = String.Concat(TxtTel1.Text.Where(Char.IsDigit));
                string t2 = String.Concat(TxtTel2.Text.Where(Char.IsDigit));

                using (IDbTransaction tran = mConn.BeginTransaction())
                {
                    try
                    {
                        //Chamada dos metodos de update das tabelas
                        uti.UpdateAluno(idPrimario, TxtNome.Text, TxtRg.Text, cpf);
                        uti.UpdateContato(idPrimario, c1, c2, t1, t2, TxtEmail1.Text, TxtEmail2.Text);
                        uti.UpdateEndereco(idPrimario, TxtRua.Text, TxtBairro.Text, TxtNumero.Text, TxtComplemento.Text, txtCidade.Text, txtUf.Text, TxtCep.Text);
                        uti.UpdateMatricula(idPrimario, TxtAno.Text, TxtCodCurso.Text);
                        tran.Commit();
                    }
                    catch
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de comunicação com o banco!" + ex);
            }

            Conect(false);

            btnLimpar_Click(sender, e);//limpas os campos
            PreencheGridCadastros(sqlPesq);//preenche o grid de ultimos cadastros
        }

        private void ValidaUpdate()
        {
            bool valida = false;
            
            if( 
                TxtCodCurso.Text == VCodCurso &&
                TxtAno.Text == VAno &&
                TxtCpf.Text == VCpf && 
                TxtRg.Text == VRg &&
                TxtNome.Text == VNome &&
                TxtCel1.Text == VCel1 &&
                TxtCel2.Text == VCel2 &&
                TxtTel1.Text == VTel1 &&
                TxtTel2.Text == VTel2 &&
                TxtEmail1.Text == VEmail1 &&
                TxtEmail2.Text == VEmail2 &&
                TxtBairro.Text == VBairro &&
                TxtRua.Text == VRua &&
                TxtComplemento.Text == VComplemento &&
                txtCidade.Text == VCidade &&
                TxtNumero.Text == VNumero &&
                TxtCep.Text == VCep &&
                txtUf.Text == VUf)

            { valida = false; } else { valida = true; }

            string cpf = TxtCpf.Text;
            cpf = String.Concat(cpf.Where(Char.IsDigit));

            if (valida == true)
            {
                BtnUpdate.Visible = true;
                BtnExcluir.Visible = false;
            }
            else
            {
                BtnUpdate.Visible = false;
                BtnExcluir.Visible = true;
            }

            if(TxtCodCurso.Text == "" || TxtNome.Text == "" || TxtAno.Text == "" || ComboCurso.Text == "" || TxtCpf.Text == "   .   .   -")
            {
                BtnUpdate.Visible = false;
                BtnExcluir.Visible = true;
            }
            else
            if (cpf.Distinct().Count() == 1 && cpf != String.Concat(VCpf.Where(Char.IsDigit)))
            {
                if (ImgTrue.Visible == false && valida == true)
                {
                    BtnUpdate.Visible = false;
                }
                else
                if (ImgTrue.Visible == true && valida == true)
                {
                    BtnUpdate.Visible = true;
                }
            }
        }

        private void CadAluno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && btnLimpar.Text == "CANCELAR")
            {
                btnLimpar_Click(sender, e);
            }
            else
            if (e.KeyCode == Keys.Escape && BtnCad.Visible)
            {
                uti.ApelMessageBox("Dados não salvos serão perdidos; Sair do cadastro?", "btn1* btn2'", "Sim; Não;", "a");
                if (Program.MBResposta == "Sim")
                {
                    this.Close();
                }
            }
            else
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            if (e.KeyCode == Keys.Delete && BtnExcluir.Visible == true)
            {
                BtnExcluir_Click(sender, e);
            }

            if (e.KeyCode == Keys.Enter)
            {
                if(BtnCad.Visible == true)
                {
                    BtnCad_Click(sender, e);
                }
                else
                if (BtnUpdate.Visible == true)
                {
                    BtnUpdate_Click(sender, e);
                }
            }
        }

        private void Pegavalores()
        {
            VAno = TxtAno.Text;
            VCodCurso = TxtCodCurso.Text;
            VCpf = TxtCpf.Text;
            VRg = TxtRg.Text;
            VNome = TxtNome.Text;
            VCel1 = TxtCel1.Text;
            VCel2 = TxtCel2.Text;
            VTel1 =TxtTel1.Text;
            VTel2 = TxtTel2.Text;
            VEmail1 = TxtEmail1.Text;
            VEmail2 = TxtEmail2.Text;
            VBairro = TxtBairro.Text;
            VRua = TxtRua.Text;
            VComplemento = TxtComplemento.Text;
            VCidade = txtCidade.Text;
            VNumero = TxtNumero.Text;
            VCep = TxtCep.Text;
            VUf = txtUf.Text;
        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {
            if (modoUpdate)
            {
                ValidaUpdate();
            }
        }

        private void TxtRg_TextChanged(object sender, EventArgs e)
        {
            if (modoUpdate)
            {
                ValidaUpdate();
            }
        }

        private void TxtAno_TextChanged(object sender, EventArgs e)
        {
            if (modoUpdate)
            {
                ValidaUpdate();
            }
        }

        private void TxtCel1_TextChanged(object sender, EventArgs e)
        {
            if (modoUpdate)
            {
                ValidaUpdate();
            }
        }

        private void TxtTel1_TextChanged(object sender, EventArgs e)
        {
            if (modoUpdate)
            {
                ValidaUpdate();
            }
        }

        private void TxtCel2_TextChanged(object sender, EventArgs e)
        {
            if (modoUpdate)
            {
                ValidaUpdate();
            }
        }

        private void ComboCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TxtCodCurso.Text = ComboCurso.SelectedValue.ToString();
            }
            catch
            {

            }
        }

        private void GerarCPF_Click(object sender, EventArgs e)
        {
            TxtCpf.Text = Utilidades.GerarCpf();
        }

        private void TxtTel2_TextChanged(object sender, EventArgs e)
        {
            if (modoUpdate)
            {
                ValidaUpdate();
            }
        }

        private void TxtEmail2_TextChanged(object sender, EventArgs e)
        {
            if (modoUpdate)
            {
                ValidaUpdate();
            }
        }

        private void TxtBairro_TextChanged(object sender, EventArgs e)
        {
            if (modoUpdate)
            {
                ValidaUpdate();
            }
        }

        private void TxtRua_TextChanged(object sender, EventArgs e)
        {
            if (modoUpdate)
            {
                ValidaUpdate();
            }
        }

        private void TxtNumero_TextChanged(object sender, EventArgs e)
        {
            if (modoUpdate)
            {
                ValidaUpdate();
            }
        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {
            if (modoUpdate)
            {
                ValidaUpdate();
            }
        }

        private void TxtCep_TextChanged(object sender, EventArgs e)
        {
            if (modoUpdate)
            {
                ValidaUpdate();
            }
        }

        private void TxtComplemento_TextChanged(object sender, EventArgs e)
        {
            if (modoUpdate)
            {
                ValidaUpdate();
            }
        }

        private void txtUf_TextChanged(object sender, EventArgs e)
        {
            if (modoUpdate)
            {
                ValidaUpdate();
            }
        }

        private void TxtEmail1_TextChanged(object sender, EventArgs e)
        {
            if (modoUpdate)
            {
                ValidaUpdate();
            }
        }

        private void TxtCodCurso_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ComboCurso.SelectedValue = Convert.ToInt32(TxtCodCurso.Text);
            }
            catch
            {
                ComboCurso.SelectedIndex = -1;
            }

            if (modoUpdate)
            {
                ValidaUpdate();
            }
        }

        void VerifyContato()
        {
            if (Utilidades.MostrarContatos == "SIM")
            {
                hideContato(true);
            }
            else
            if (Utilidades.MostrarContatos == "NAO")
            {
                hideContato(false);
            }
        }

        private void btnEsconde_Click(object sender, EventArgs e)
        {
            if(btnEsconde.Text == "MOSTRAR CONTATO")
            {
                hideContato(true);
                uti.UpConfig(Utilidades.Tema, "SIM");
            }
            else
            if (btnEsconde.Text == "ESCONDER CONTATO")
            {
                hideContato(false);
                uti.UpConfig(Utilidades.Tema, "NAO");
            }
        }

        void hideContato(bool esconde)
        {
            if (esconde == false)
            {
                this.Height = 413;

                esconde = true;
                boxContato.Visible = false;
                boxContato.Enabled = false;
                btnEsconde.Text = "MOSTRAR CONTATO";

                btnEsconde.Image = Properties.Resources.unhide_32x32;
            }
            else
            if (esconde)
            {
                this.Height = 630;

                esconde = false;
                boxContato.Enabled = true;
                boxContato.Visible = true;
                btnEsconde.Text = "ESCONDER CONTATO";

                btnEsconde.Image = Properties.Resources.hide_32x32;
            }
        }

        void Cores()//Preenchimento das cores do tema
        {
            uti.ChangeColors(this);//txtLimit2

            lblTitulo.ForeColor = Utilidades.ForeTitulo;
            lblTitulo.BackColor = Utilidades.BackTitulo;
            BtnClose.BackColor = Utilidades.BackTitulo;
            txtLimit.ForeColor = Utilidades.ForeLbl;
            txtLimit.BackColor = Utilidades.BackForm;
            this.BackColor = Utilidades.BackForm;
            LblErro.ForeColor = Utilidades.ForeLblError;

            RadConcluinte.ForeColor = Utilidades.ForeLbl;
            RadConcluinte.FlatAppearance.CheckedBackColor = Utilidades.ConcluinteCor;
            RadConcluinte.FlatAppearance.MouseOverBackColor = Utilidades.ConcluinteCor;
            RadConcluinte.FlatAppearance.MouseDownBackColor = Utilidades.ConcluinteCor;

            RadNConcluinte.ForeColor = Utilidades.ForeLbl;
            RadNConcluinte.FlatAppearance.CheckedBackColor = Utilidades.NConcluinteCor;
            RadNConcluinte.FlatAppearance.MouseOverBackColor = Utilidades.NConcluinteCor;
            RadNConcluinte.FlatAppearance.MouseDownBackColor = Utilidades.NConcluinteCor;
        }

        private void BtnClose_MouseEnter(object sender, EventArgs e)
        {
            BtnClose.BackColor = Utilidades.BtnCloseEnter;
        }

        private void BtnClose_MouseLeave(object sender, EventArgs e)
        {
            BtnClose.BackColor = Utilidades.BackTitulo;
        }
        
        void TextBoxFocado_Enter(object sender, EventArgs e)
        {
            TextBox txtbox = (TextBox)sender;
            txtbox.Focus();

            uti.TextBoxEmFoco(this);
        }

        void MaskedTextFocado_Enter(object sender, EventArgs e)
        {
            MaskedTextBox txtbox = (MaskedTextBox)sender;
            txtbox.Focus();

            uti.TextBoxEmFoco(this);
        }




        //----------------------------------------------------------------------------------------------
        private void btnConverter_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.conecta2);

            string sql = "SELECT rg, codCur, nome, ano, pasta, concluinte FROM Alunos";//string 
            SqlCommand cmd = new SqlCommand(sql, con);

            con.Open();
            cmd.CommandType = CommandType.Text;

            RadConcluinte.CheckedChanged -= RadConcluinte_CheckedChanged;
            RadNConcluinte.CheckedChanged -= RadNConcluinte_CheckedChanged;

            SqlDataReader reader = null;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                TxtRg.Text = reader[0].ToString();
                TxtCodCurso.Text = reader[1].ToString();
                TxtNome.Text= reader[2].ToString();
                TxtAno.Text = reader[3].ToString();
                idMatricula = TxtPasta.Text = reader[4].ToString();
                TxtCpf.Text = "00000000000";

                if(reader[5].ToString().ToUpper() == "S")
                {
                    RadConcluinte.Checked = true;
                    situacao = "SIM";
                }
                else
                if(reader[5].ToString().ToUpper() == "N")
                {
                    RadNConcluinte.Checked = true;
                    situacao = "NAO";
                }

                BtnCad_Click(sender, e);

            }
            reader.Close();

            RadConcluinte.CheckedChanged += RadConcluinte_CheckedChanged;
            RadNConcluinte.CheckedChanged += RadNConcluinte_CheckedChanged;
        }
    }
}

