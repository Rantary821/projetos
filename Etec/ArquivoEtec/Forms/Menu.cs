using System;
using System.Data;
using System.Data.SqlClient;
using System.Deployment.Application;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Threading;
using System.Linq;

namespace ArquivoEtec
{
    public partial class Menu : Form
    {
        Utilidades uti = new Utilidades();

        //Seleção dos botões
        int Largura = 158, Altura = 63, P, cnt = 0, count;

        SqlConnection mConn;

        string DataMenu;

        public Menu()
        {
            InitializeComponent();

            //Mostrar versão do programa, apenas quando instalado
            if (ApplicationDeployment.IsNetworkDeployed)
            {
                lblVersion.Text = string.Format("Version {0}", ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString(4));
            }

            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;            

            timer1.Start();
            atualiza.Start();

            lblRegistros.Text = "Registros - " + uti.pesquisaQntPasta();

            UpdateTema();

            upgrid();
        }

        void UpdateTema()
        {
            uti.buscaConfig();

            uti.BuscaCores();

            Cores();

            uti.GridviewColors(gridUp);

            PadraoButtons();
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
            btnCad.BackColor = Utilidades.backBtnNS;
            btnConfig.BackColor = Utilidades.backBtnNS;
            btnPesq.BackColor = Utilidades.backBtnNS;
            btnCursos.BackColor = Utilidades.backBtnNS;
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
            UpdateTema();
            PadraoButtons();
            btnConfig.Size = new Size(Largura + 10, Altura);
            btnConfig.BackColor = Utilidades.backBtnS;
            btnConfig.FlatAppearance.BorderColor = Utilidades.backBtnS;

            Edit config = new Edit();
            config.ShowDialog();

            UpdateTema();
            PadraoButtons();
        }

        private void ResetBanco_Click(object sender, EventArgs e)
        {
            Conect(true);

            string sql = "truncate table aluno;" +
                            "truncate table contato;" +
                            "truncate table endereco;" +
                            "truncate table config;" +
                            "truncate table datas;" +
                            "insert into config (tema, mostrarContatos) values ('', '');" +
                            "truncate table matricula;";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, mConn);


                uti.ApelMessageBox("Deseja realmente resetar o Banco de Dados?; Reset!", "btn1* btn2' BtnClose;", "Sim; Não;", "a");
                if (Program.MBResposta == "Sim")
                {
                    cmd.ExecuteNonQuery();
                    uti.ResetPastaAlnos();
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
            UpdateTema();
            PadraoButtons();
            btnCursos.Size = new Size(Largura + 10, Altura);
            btnCursos.BackColor = Utilidades.backBtnS;
            btnCursos.FlatAppearance.BorderColor = Utilidades.backBtnS;

            cadCurso curso = new cadCurso();
            curso.ShowDialog();

            PadraoButtons();
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
            }
            catch (Exception ex)
            {
               
            }

            if(lblNome.Text == "")
            {
                lblNome.Text = "Primeiro acesso!";
            }

            Conect(false);

            UpdateTema();
        }

        private void Menu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                P = 0;
                this.Close();
            }

            if (e.KeyCode == Keys.F1)
            {
                btnCadd_Click(sender, e);
            }
            if (e.KeyCode == Keys.F2)
            {
                btnPesq_Click(sender, e);
            }
            if (e.KeyCode == Keys.F3)
            {
                btnCursos_Click(sender, e);
            }
            if (e.KeyCode == Keys.F4)
            {
                btnConfig_Click(sender, e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Conect(true);

            DataMenu = uti.Config(0);

            string data = "", sql = "";

            try
            {
                uti.ApelMessageBox("Deseja realemente sair do sistema?; Sair?", "btn1* btn2'", "Sim; Cancelar;", "q");
                if (Program.MBResposta == "Sim")
                {
                    if (DataMenu.ToLower() == "true")
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

                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            Conect(false);
        }

        void FecharMenu()
        {
            
        }

        private void btnPesq_Click(object sender, EventArgs e)
        {
            UpdateTema();
            PadraoButtons();
            btnPesq.Size = new Size(Largura + 10, Altura);
            btnPesq.BackColor = Utilidades.backBtnS;
            btnPesq.FlatAppearance.BorderColor = Utilidades.backBtnS;

            Pesquisa pes = new Pesquisa();
            pes.ShowDialog();

            PadraoButtons();
        }

        private void btnCadd_Click(object sender, EventArgs e)
        {
            UpdateTema();
            PadraoButtons();
            btnCad.Size = new Size(Largura + 10, Altura);
            btnCad.BackColor = Utilidades.backBtnS;
            btnCad.FlatAppearance.BorderColor = Utilidades.backBtnS;

            CadAluno cad = new CadAluno();
            cad.ShowDialog();

            PadraoButtons();
        }

        void Cores()//Preenchimento das cores do tema
        {
            try
            {
                if (Utilidades.TodosOSTemas.Contains(Utilidades.Tema) && Utilidades.Tema != "")
                {
                    uti.ChangeColors(this);
                    
                    lblRegistros.LinkColor = Utilidades.ForelblReg;
                    lblTitulo.ForeColor = Utilidades.MenuForetitulo;
                    lblTitulo.BackColor = Utilidades.MenuBackTitulo;
                    panel2.BackColor = Utilidades.MenuBackTitulo;
                    BtnClose.BackColor = Utilidades.MenuBackTitulo;
                    btnMini.BackColor = Utilidades.MenuBackTitulo;
                    lblVersion.ForeColor = Utilidades.ForeLblVersaoMenu;
                    picLoad.BackColor = Utilidades.MenuBackTitulo;
                    this.BackColor = Utilidades.BackForm;

                    gridUp.DefaultCellStyle.ForeColor = Utilidades.MenuForetitulo;
                    gridUp.DefaultCellStyle.BackColor = Utilidades.BackForm;

                    gridUp.DefaultCellStyle.SelectionForeColor = Utilidades.MenuForetitulo;
                    gridUp.DefaultCellStyle.SelectionBackColor = Utilidades.BackForm;

                    gridUp.EnableHeadersVisualStyles = false;

                    gridUp.ColumnHeadersDefaultCellStyle.ForeColor = Utilidades.MenuForetitulo;
                    gridUp.ColumnHeadersDefaultCellStyle.BackColor = Utilidades.BackForm;

                    gridUp.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
                    gridUp.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;

                    gridUp.DefaultCellStyle.Font = new Font("Arial", 8, FontStyle.Bold);
                    gridUp.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);

                    gridUp.BackgroundColor = Utilidades.BackForm;
                }
                else
                {
                    Edit config = new Edit();
                    this.Hide();
                    config.ShowDialog();

                    uti.buscaConfig();
                    uti.BuscaCores();
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
                uti.BuscaCores();
                Cores();
                this.Show();
            }
        }

        private void BtnClose_MouseEnter(object sender, EventArgs e)
        {
            BtnClose.BackColor = Utilidades.BtnCloseEnter;
        }

        private void BtnClose_MouseLeave(object sender, EventArgs e)
        {
            BtnClose.BackColor = Utilidades.MenuBackTitulo;
        }

        private void btnMini_MouseEnter(object sender, EventArgs e)
        {
            btnMini.BackColor = Utilidades.BtnMiniEnter;
        }

        private void btnMini_MouseLeave(object sender, EventArgs e)
        {
            btnMini.BackColor = Utilidades.MenuBackTitulo;
        }







        /// <summary>
        /// AREA DE TESTES
         
        private Thread ThreadUpLoadIMg = null;
        delegate void BmpDelegate(Bitmap BitBmp);

        private void backGroundWoker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            testeCadastros(Convert.ToInt32(txtQuant.Text));
        }

        private void WorkerTesteCpf_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            testeValidaCpf();
        }

        private void UpLoading()
        {
            try
            {
                P = 100;

                do
                {
                    Bitmap bmp = new Bitmap(Assembly.GetEntryAssembly().GetManifestResourceStream("ArquivoEtec.Resources.Loading.Dark-" + cnt + ".png"));
                    this.SetLoadingImg(bmp);
                    bmp.Dispose();

                    cnt++;

                    if (cnt == 99)
                    {
                        cnt = 0;
                    }

                    Thread.Sleep(60);
                }
                while (cnt < P);

                Bitmap bmp1 = new Bitmap(Assembly.GetEntryAssembly().GetManifestResourceStream("ArquivoEtec.Resources.Loading.Dark-" + 0 + ".png"));
                this.SetLoadingImg(bmp1);
            }
            catch { }
        }

        private void SetLoadingImg(Bitmap bmp)
        {
            try
            {
                if (this.picLoad.InvokeRequired)
                {
                    BmpDelegate d = new BmpDelegate(SetLoadingImg);
                    this.Invoke(d, new object[] { bmp });
                }
                else
                {
                    if (P != 0)
                    {
                        this.picLoad.Text = count.ToString();
                    }
                    else
                    {
                        this.picLoad.Text = "";
                    }

                    this.picLoad.BackgroundImage = bmp;
                    this.picLoad.Refresh();
                }
            }
            catch { }
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if(txtQuant.Text != "")
            {
                try
                {
                    this.ThreadUpLoadIMg = new Thread(new ThreadStart(this.UpLoading));
                    this.ThreadUpLoadIMg.Start();

                    backGroundWoker.RunWorkerAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }   
        }

        void testeCadastros(int quant)
        {
            ImageList Loads;
            Image img;

            string situacao = "", Cpf, Nome = "Aluno ", Rg = "rg ", Ano = "2018", Cel1 = "00000000", Cel2 = "00000000", Tel1 = "00000000", Tel2 = "00000000", Email1 = "aluno@hormail.com",
                   Email2 = "aluno@hormail.com", Bairro = "balbla", Rua = "balbla", Complemento = "casa", Cidade = "Icem", Numero = "1145", Cep = "1479000", Uf = "SP", idMatricula = "0";

            int Total = quant, idAluno = 0, CodCurso = 0;

            try
            {
                for (int i = 0; i <= 1; i++)
                {
                    count = 0;
                    do
                    {
                        Conect(true);

                        using (IDbTransaction tran = mConn.BeginTransaction())
                        {
                            try
                            {
                                Cpf = Utilidades.GerarCpf();

                                if (i == 0)
                                {
                                    situacao = "SIM";
                                    idMatricula = uti.SelectMaxIDMatricula(situacao);
                                }
                                else
                                if (i == 1)
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
                                tran.Commit();
                            }
                            catch
                            {
                                tran.Rollback();
                                throw;
                            }
                        }

                        count++;

                        Conect(false);
                    }
                    while (count < Total);
                }//for
            }
            catch (Exception ex)
            {

            }

            P = 0;

            uti.ApelMessageBox("Operação finalizada!", "btn3*", "Ok", "c");
        }

        public bool validaCpfTestes(string cpf)
        {
            string ValCpf = "";

            bool valida = false;

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
                            valida = true;
                        }
                        else//Caso a segunda comparação resulte em false
                        {
                            valida = false;
                        }
                    }
                    else//Caso a primeira comparação resulte em false
                    {
                        valida = false;
                    }
                }
            }
            if (cpf.Length < 11)
            {
                valida = false;
            }

            return valida;
        }

        void testeValidaCpf()
        {
            int q = Convert.ToInt32(TxtTesteCpf.Text);

            count = 0;

            bool valida = false;

            for (int i = 0; i < q; i++)
            {
                string cpf = Utilidades.GerarCpf();
                valida = validaCpfTestes(cpf);

                if (!valida)
                {
                    MessageBox.Show("Cpf " + cpf + " Invalido!");
                    i = q;
                }

                count++;
            }

            P = 0;
            MessageBox.Show("Validações finalizadas!");
        }

        private void btnTesteCpf_Click(object sender, EventArgs e)
        {
            this.ThreadUpLoadIMg = new Thread(new ThreadStart(this.UpLoading));
            this.ThreadUpLoadIMg.Start();

            WorkerTesteCpf.RunWorkerAsync();
        }
        
        /// </summary>
    }
}
