using System;
using System.Data;
using System.Data.SqlClient;
using System.Deployment.Application;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace ArquivoEtec
{
    public partial class Menu : Form
    {
        Utilidades uti = new Utilidades();

        //Seleção dos botões
        int Largura = 158, Altura = 63;

        SqlConnection mConn;

        Color MenuBackTitulo, MenuForetitulo, ForelblReg, BackForm, ForeLbl, ForeBnt, backBtnS, backBtnNS, BtnCloseEnter, BtnMiniEnter, ForeLblVersaoMenu;

        string DataMenu;

        public Menu()
        {
            InitializeComponent();

            //Mostrar versão do programa, apenas quando instalado
            if (ApplicationDeployment.IsNetworkDeployed)
            {
                lblVersion.Text = string.Format("Version {0}", ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString(4));
            }

            uti.buscaConfig();

            uti.GridviewColors(gridUp);

            Cores();

            PadraoButtons();

            timer1.Start();
            atualiza.Start();

            lblRegistros.Text = "Registros - " + uti.pesquisaQntPasta();

            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;

            upgrid();
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

        void upgrid()
        {
            string line;
            //List<string> Ups = new List<string>();

            var assm2 = Assembly.GetExecutingAssembly();
            using (var stream = assm2.GetManifestResourceStream("ArquivoEtec.Resources.Updates.Updates.txt"))
            {
                using (var reader = new StreamReader(stream))
                {
                    while (((line = reader.ReadLine()) != null))
                    {
                       // Ups.Add(line);
                        gridUp.Rows.Add(line);
                    }
                }
            }
        }

        void PadraoButtons()
        {
            //corrige os tamanhos dos botões
            btnCad.Size = new Size(Largura, Altura);
            btnConfig.Size = new Size(Largura, Altura);
            btnPesq.Size = new Size(Largura, Altura);
            btnCursos.Size = new Size(Largura, Altura);

            //corrige as cores
            btnCad.BackColor = backBtnNS;
            btnConfig.BackColor = backBtnNS;
            btnPesq.BackColor = backBtnNS;
            btnCursos.BackColor = backBtnNS;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToShortTimeString();
        }

        private void atualiza_Tick(object sender, EventArgs e)
        {
            lblRegistros.Text = "Registros - " + uti.pesquisaQntPasta();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Pesquisa pesq = new Pesquisa();
            pesq.Show();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            PadraoButtons();
            btnConfig.Size = new Size(Largura + 10, Altura);
            btnConfig.BackColor = backBtnS;
            btnConfig.FlatAppearance.BorderColor = backBtnS;

            Edit config = new Edit();
            config.ShowDialog();

            Cores();
            PadraoButtons();
        }

        private void ResetBanco_Click(object sender, EventArgs e)
        {
            Conect(true);

            string sql =    "truncate table aluno;"+
                            "truncate table contato;"+
                            "truncate table curso;"+
                            "truncate table endereco;"+
                            "truncate table config;" +
                            "truncate table datas;" +
                            "insert into config (tema, mostrarContatos)values ('', '');" +
                            "truncate table matricula;";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, mConn);


                uti.ApelMessageBox("Deseja realmente resetar o Banco de Dados ?; Reset!", "btn1 btn2 BtnClose;", "Sim; Não;", "a");
                if (Program.MBResposta == "Sim")
                {
                    cmd.ExecuteNonQuery();
                    uti.ApelMessageBox("O banco de dados foi resetado, e esta pronto para uso!; ", "btn3;", "ok", "c");
                }

            }catch(Exception ex)
            {
                uti.ApelMessageBox("Erro ao resetar p banco!; ", "btn3;", "ok", "c");
            }

            Conect(false);
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            PadraoButtons();
            btnCursos.Size = new Size(Largura + 10, Altura);
            btnCursos.BackColor = backBtnS;
            btnCursos.FlatAppearance.BorderColor = backBtnS;

            cadCurso curso = new cadCurso();
            curso.ShowDialog();

            PadraoButtons();
        }

        private void Menu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                uti.ApelMessageBox("Deseja mesmo sair do sistema?; ", "btn1 btn2", "Sim; Não;", "Q");
                if(Program.MBResposta == "Sim")
                {
                    this.Close();
                }
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Conect(true);

            lblNome.Text = "";

            try
            {
                string sql = "SELECT TOP 1 Nome, Datas from datas order by Id desc;";
                SqlCommand cmd = new SqlCommand(sql, mConn);
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string teste = reader.GetString(0) + " - " + reader.GetString(1);
                    lblNome.Text = teste;
                }
            }catch(Exception ex)
            {
               MessageBox.Show("" + ex);
            }

            if(lblNome.Text == "")
            {
                lblNome.Text = "Primeiro acesso!";
            }

            Conect(false);
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Conect(true);

            DataMenu = uti.Config(0);

            string data = "", sql = "";

            try
            {
                /*uti.ApelMessageBox("Deseja realemente sair do sistema?; Sair?", "btn1 btn2", "Sim; Cancelar;", "q");
                if(Program.MBResposta == "Sim")
                {*/
                    if(DataMenu.ToLower() == "true")
                    {
                        data = DateTime.Now.ToString();
                        sql = "insert into datas (Nome, Datas) values ('" + Environment.UserName + "','" + data + "')";
                    }
                    else
                    if (DataMenu.ToLower() == "false")
                    {
                        data = DateTime.Now.ToLongDateString() + "  " + DateTime.Now.ToLongTimeString(); 
                        sql = "insert into datas (Nome, Datas) values ('" + Environment.UserName + "','" + data + "')";
                    }
                    SqlCommand cmd = new SqlCommand(sql, mConn);
                    cmd.ExecuteNonQuery();
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            Conect(false);
        }

        private void btnPesq_Click(object sender, EventArgs e)
        {
            PadraoButtons();
            btnPesq.Size = new Size(Largura + 10, Altura);
            btnPesq.BackColor = backBtnS;
            btnPesq.FlatAppearance.BorderColor = backBtnS;

            Pesquisa pes = new Pesquisa();
            pes.ShowDialog();

            PadraoButtons();
        }

        private void btnCadd_Click(object sender, EventArgs e)
        {
            PadraoButtons();
            btnCad.Size = new Size(Largura + 10, Altura);
            btnCad.BackColor = backBtnS;
            btnCad.FlatAppearance.BorderColor = backBtnS;

            CadAluno cad = new CadAluno();
            cad.ShowDialog();

            PadraoButtons();
        }

        void Cores()//Preenchimento das cores do tema
        {
            //MenuBackTitulo, MenuForetitulo, ForelblReg, backBtnNS, backBtnS, BackForm, ForeLbl, ForeBnt;

            try
            {
                if (Utilidades.TodosOSTemas.Contains(Utilidades.Tema) && Utilidades.Tema != "")
                {
                    MenuBackTitulo = uti.Cores(0);
                    MenuForetitulo = uti.Cores(1);
                    ForelblReg = uti.Cores(2);
                    backBtnNS = uti.Cores(3);
                    backBtnS = uti.Cores(4);
                    BackForm = uti.Cores(7);
                    ForeLbl = uti.Cores(8);
                    ForeBnt = uti.Cores(9);
                    BtnCloseEnter = uti.Cores(18);
                    BtnMiniEnter = uti.Cores(19);
                    ForeLblVersaoMenu = uti.Cores(23);

                    ChangeColors(this);

                    lblRegistros.LinkColor = ForelblReg;
                    lblTitulo.ForeColor = MenuForetitulo;
                    lblTitulo.BackColor = MenuBackTitulo;
                    panel2.BackColor = MenuBackTitulo;
                    BtnClose.BackColor = MenuBackTitulo;
                    btnMini.BackColor = MenuBackTitulo;
                    lblVersion.ForeColor = ForeLblVersaoMenu;
                    this.BackColor = BackForm;

                    gridUp.DefaultCellStyle.ForeColor = MenuForetitulo;
                    gridUp.DefaultCellStyle.BackColor = BackForm;

                    gridUp.DefaultCellStyle.SelectionForeColor = MenuForetitulo;
                    gridUp.DefaultCellStyle.SelectionBackColor = BackForm;

                    gridUp.EnableHeadersVisualStyles = false;

                    gridUp.ColumnHeadersDefaultCellStyle.ForeColor = MenuForetitulo;
                    gridUp.ColumnHeadersDefaultCellStyle.BackColor = BackForm;

                    gridUp.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
                    gridUp.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;

                    gridUp.DefaultCellStyle.Font = new Font("Arial", 8, FontStyle.Bold);
                    gridUp.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);

                    gridUp.BackgroundColor = BackForm;
                }
                else
                {
                    Edit config = new Edit();
                    this.Hide();
                    config.ShowDialog();

                    uti.buscaConfig();
                    Cores();
                    this.Show();
                }
            }
            catch(Exception ex)
            {
                Edit config = new Edit();
                this.Hide();
                config.ShowDialog();

                uti.buscaConfig();
                Cores();
                this.Show();
            }
        }

        void ChangeColors(Control con)//Preenchimento das cores do tema
        {
            foreach (Control c in con.Controls)
            {
                if (c is GroupBox)
                    ((GroupBox)c).ForeColor = ForeLbl;
                if (c is Label)
                    ((Label)c).ForeColor = ForeLbl;
                else
                    ChangeColors(c);
            }
        }

        private void BtnClose_MouseEnter(object sender, EventArgs e)
        {
            BtnClose.BackColor = BtnCloseEnter;
        }

        private void BtnClose_MouseLeave(object sender, EventArgs e)
        {
            BtnClose.BackColor = MenuBackTitulo;
        }

        private void btnMini_MouseEnter(object sender, EventArgs e)
        {
            btnMini.BackColor = BtnMiniEnter;
        }

        private void btnMini_MouseLeave(object sender, EventArgs e)
        {
            btnMini.BackColor = MenuBackTitulo;
        }







        private void button1_Click(object sender, EventArgs e)
        {
            testeCadastros();
        }

        void testeCadastros()
        {
            string situacao ="", Cpf, Nome = "Aluno ", Rg = "rg ", Ano = "2018", Cel1 = "00000000", Cel2 = "00000000", Tel1 = "00000000", Tel2 = "00000000", Email1 = "aluno@hormail.com",
                   Email2 = "aluno@hormail.com", Bairro = "balbla", Rua = "balbla", Complemento = "casa", Cidade = "Icem", Numero = "1145", Cep = "1479000", Uf = "SP";

            int idMatricula = 0, idAluno = 0, CodCurso = 0;

            try
            {
                for (int i = 0; i <= 1; i++)
                {
                    int count = 0;
                    do
                    {
                        Conect(true);

                        using (IDbTransaction tran = mConn.BeginTransaction())
                        {
                            try
                            {
                                Cpf = GerarCpf();


                                if (count % 2 == 0)
                                {
                                    situacao = "SIM";
                                    idMatricula = uti.SelectMaxIDMatricula(situacao);
                                }
                                else
                                {
                                    situacao = "NAO";
                                    idMatricula = uti.SelectMaxIDMatricula(situacao);
                                }

                                idAluno = uti.SelectMaxIDAluno();
                                idAluno++;

                                if (CodCurso < 5)
                                {
                                    CodCurso++;
                                }
                                else
                                if (CodCurso == 5)
                                {
                                    CodCurso = 1;
                                }

                                uti.InsertIntoAluno(Nome + idAluno, Rg + idAluno, Cpf);
                                uti.InsertIntoContato(Cel1, Cel2, Tel1, Tel2, Email1, Email2, idAluno);
                                uti.InsertIntoEndereco(Rua, Bairro, Numero, Complemento, Cidade, Cep, Uf, idAluno.ToString());
                                uti.InsertIntoMatricula(idMatricula.ToString(), idAluno.ToString(), CodCurso.ToString(), Ano, situacao);

                                if(count % 10 == 0)
                                {
                                    uti.DeleleAluno(idMatricula.ToString());
                                }

                                tran.Commit();
                            }
                            catch
                            {
                                tran.Rollback();
                                throw;
                            }
                        }

                        Conect(false);

                        count++;
                    }
                    while (count < 1000);
                }//for
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de comunicação com o banco!" + ex);
            }

            uti.ApelMessageBox("Operação finalizada!", "btn1*", "Ok", "c");
        }

        public static String GerarCpf()
        {
            int soma = 0, resto = 0;
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            Random rnd = new Random();
            string semente = rnd.Next(100000000, 999999999).ToString();

            for (int i = 0; i < 9; i++)
                soma += int.Parse(semente[i].ToString()) * multiplicador1[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            semente = semente + resto;
            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(semente[i].ToString()) * multiplicador2[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            semente = semente + resto;
            return semente;
        }
    }
}
