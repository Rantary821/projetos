using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using FileToIconTest;
using WindowsFormsApplication1;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO;
using ScannerDemo;
using System.Security;
using MySql.Data.MySqlClient;

namespace SoaresTeste1
{
    public partial class Ficha : Form
    {
        int i;
        string select, colum, textboz, update;
        Boolean ready, priE, priC, priT;

        int celIndex, telIndex, emailIndex;
        string Cel1, Cel2, Tel1, Tel2, Email1, Email2;

        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private MySqlDataReader reader;
        
        private MySqlCommand cmd;
        public int idd;
        public string conexao = "Persist Security info=False; server=localhost; database=soares;uid=root";
        public string caminhoImagemSalva = null;

        public Ficha()
        {
            InitializeComponent();
            //aqui vai ler o arquivo txt do codigo do aluno, para assim selecionar a pasta correta.
            using (StreamReader reader = new StreamReader(@"C:\Fotos\CodAluno.txt"))
            {
                Program.Codigo = reader.ReadLine();
            }

            Program.localfiles = Path.Combine(@"C:\Fotos\" + Program.Codigo);
        }

        string nomearq, NomeArqDelete;
        string deleteArq;
        string TextBoxes, TexTCompara;

        

        void Atualizacao(Control con)
        {
            if(TextBoxes != TexTCompara)
            {
                BtnAtualiza.Enabled = true;
            }
            else
            if (TextBoxes == TexTCompara)
            {
                BtnAtualiza.Enabled = false;
            }
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            TextBoxes = TxtName.Text;
            TexTCompara = Program.nome;
            Atualizacao(this);
        }

        private void TxtRg_TextChanged(object sender, EventArgs e)
        {
            TextBoxes = TxtRg.Text;
            TexTCompara = Program.rg;
            Atualizacao(this);
        }

        private void TxtCpf_TextChanged(object sender, EventArgs e)
        {
            TextBoxes = TxtCpf.Text;
            TexTCompara = Program.cpf;
            Atualizacao(this);
        }

        private void TxtRa_TextChanged(object sender, EventArgs e)
        {
            TextBoxes = TxtRa.Text;
            TexTCompara = Program.ra;
            Atualizacao(this);
        }

        private void TxtNasc_TextChanged(object sender, EventArgs e)
        {
            TextBoxes = TxtNasc.Text;
            TexTCompara = Program.nasc;
            Atualizacao(this);
        }

        private void TxtSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBoxes = TxtSexo.Text;
            TexTCompara = Program.sexo;
            Atualizacao(this);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            foreach (var process in Process.GetProcessesByName("FileToIconTest"))
            {
                process.Kill();
            }
           
            try
            {
                string path = @"C:\Fotos\Paths.txt";
                File.Delete(path);
            }
            catch(System.IO.IOException ex)
            {

            }      
        }

        private void Ficha_Load(object sender, EventArgs e)
        {
            TxtName.Text = Program.nome;
            TxtRg.Text = Program.rg;
            TxtCpf.Text = Program.cpf;
            TxtRa.Text = Program.ra;
            TxtSexo.Text = Program.sexo;
            TxtNasc.Text = Program.nasc;

            try
            {
                mConn = new MySqlConnection(conexao);
                mConn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro " + ex);
            }

            string sql = "SELECT cel, tel, email FROM `dados` where idAluno = " + Program.Codigo + "";
            using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
            {
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txtCel.Items.Add(reader.GetString("cel"));
                    txtEmail.Items.Add(reader.GetString("email"));
                    txtTel.Items.Add(reader.GetString("tel"));
                }
                reader.Close();
            }

            mConn.Close();

            txtCel.SelectedIndex = 0;
            txtTel.SelectedIndex = 0;
            txtEmail.SelectedIndex = 0;

            Cel1 = txtCel.Items[0].ToString();
            Cel2 = txtCel.Items[1].ToString();
            Tel1 = txtTel.Items[0].ToString();
            Tel2 = txtTel.Items[1].ToString();
            Email1 = txtEmail.Items[0].ToString();
            Email2 = txtEmail.Items[1].ToString();

            BtnAtualiza.Enabled = false;

            if (System.IO.File.Exists(@"C:\Fotos\Perfil\" + Program.Codigo +".png"))
            {
                PictureBox pb = new PictureBox();
                Image Imagem = Image.FromFile(@"C:\Fotos\Perfil\" + Program.Codigo + ".png");
                pb.Image = Imagem; 
                pb.Height = 170;
                pb.Width = 186;
                PicPerfil.BackgroundImage = pb.Image;
            }

            ready = true;
            /*DataSet mDataSet = new DataSet();
            mConn = new MySqlConnection(conexao);
            mConn.Open();

            i = 1;
            do
            {              
                if(i == 1)
                {
                    select = "SELECT email FROM `dados` WHERE idAluno = ";
                    colum = "email";
                }
                else
                if (i == 2)
                {
                    select = "SELECT tel FROM `dados` WHERE idAluno = ";
                    colum = "tel";
                }
                else
                if (i == 3)
                {
                    select = "SELECT cel FROM `dados` WHERE idAluno = ";
                    colum = "cel";
                }

                MySqlCommand mAdapter = new MySqlCommand(select + Program.Codigo, mConn);
                MySqlDataReader reader = mAdapter.ExecuteReader();//retorna dados resultantes da consulta em SQL
                DataTable table = new DataTable(); //estrutura da tabela do banco de dados ou de outra fonte de informação
                table.Load(reader); //carrega dados na tabela de acordo com a instrução sql passada 
                DataRow row = table.NewRow(); //representa uma linha de dados em um DataTable
                row[colum] = ""; //para não gerar valor nulo e, consequentemente, evitar erro de execução

                if(i == 1)
                {
                    this.txtEmail.DataSource = table;
                    this.txtEmail.ValueMember = colum;
                    this.txtEmail.DisplayMember = colum;//obtem o nome do email
                }
                else
                if (i == 2)
                {
                    this.txtTel.DataSource = table;
                    this.txtTel.ValueMember = colum;
                    this.txtTel.DisplayMember = colum;//obtem o nome do email
                }
                else
                if (i == 3)
                {
                    this.txtCel.DataSource = table;
                    this.txtCel.ValueMember = colum;
                    this.txtCel.DisplayMember = colum;//obtem o nome do email
                }  
                reader.Close();//fecha o objeto
                reader.Dispose();//liberamos o objeto da memoria
                mDataSet.Clear();
                i++;
            }
            while (i <= 3);

            mDataSet.Dispose();
            mConn.Close();*/
        }

        private IntPtr Child = IntPtr.Zero;

        private void Mcel_Click(object sender, EventArgs e)
        {
            string text;
            //ready pra não entrar no codigo enquanto o form ta abrindo
            if (ready)
            {
                //pri != true significa q é a primeira vez q ele clica no botão 
                if (priC != true)
                {
                    celIndex = txtCel.SelectedIndex;

                    txtCel.SelectedIndex = -1;

                    txtCel.DropDownStyle = ComboBoxStyle.DropDown;

                    if (celIndex == 0)
                    {
                        txtCel.Text = "Celular 1";
                    }
                    else
                    {
                        txtCel.Text = "Celular 2";
                    }
                    priC = true;
                    CCanc.Visible = true;
                    Mcel.BackColor = Color.Green;
                }
                else
                //pri == true significa q é a segunda vez q ele clica no botão 
                if (priC == true)
                {
                    if (celIndex == 0)
                    {
                        if (txtCel.Text != "Celular 1")
                        {
                            txtCel.Text = txtCel.Text.Insert(0, "(");
                            txtCel.Text = txtCel.Text.Insert(3, ")");
                            txtCel.Text = txtCel.Text.Insert(9, "-");
                        }

                        if (txtCel.Text != "Celular 1" && txtCel.Text != txtCel.Items[0].ToString() && txtCel.Text != txtCel.Items[1].ToString())
                        {
                            text = txtCel.Text;

                            update = "UPDATE `dados` SET `cel`= '" + text + "' WHERE `idAluno`= '" + Program.Codigo + "' AND cel = '" + txtCel.Items[0].ToString() + "';";
                            UpdateDados();

                            txtCel.Items[0] = text;
                            txtCel.DropDownStyle = ComboBoxStyle.DropDownList;

                            priC = false;
                            txtCel.SelectedIndex = 0;
                            Mcel.BackColor = Color.Gray;
                            CCanc.Visible = false;
                        }
                        else
                        if (txtCel.Text == "Celular 1")
                        {
                            priC = false;
                            txtCel.SelectedIndex = 0;
                            Mcel.BackColor = Color.Gray;
                            CCanc.Visible = false;
                        }
                        else
                        if (txtCel.Text == txtCel.Items[0].ToString())
                        {
                            MessageBox.Show("Digite um celular diferente do atual", "Celular Repetido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtCel.Text = "Celular 1";
                        }
                        else
                        if(txtCel.Text == txtCel.Items[1].ToString())
                        {
                            MessageBox.Show("Telefone digitado igual ao celular secundario", "Celular Repetido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtCel.Text = "Celular 1";
                        }
                    }
                    else
                    if (celIndex == 1)
                    {
                        if (txtCel.Text != "Celular 2")
                        {
                            txtCel.Text = txtCel.Text.Insert(0, "(");
                            txtCel.Text = txtCel.Text.Insert(3, ")");
                            txtCel.Text = txtCel.Text.Insert(9, "-");
                        }

                        if (txtCel.Text != "Celular 2" && txtCel.Text != txtCel.Items[1].ToString() && txtCel.Text != txtCel.Items[0].ToString())
                        {
                            text = txtCel.Text;

                            update = "UPDATE `dados` SET `cel`= '" + text + "' WHERE `idAluno`= '" + Program.Codigo + "' AND cel = '" + txtCel.Items[1].ToString() + "';";
                            UpdateDados();

                            txtCel.Items[1] = text;
                            txtCel.DropDownStyle = ComboBoxStyle.DropDownList;

                            priC = false;
                            txtCel.SelectedIndex = 0;
                            Mcel.BackColor = Color.Gray;
                            CCanc.Visible = false;
                        }
                        else
                        if (txtCel.Text == "Celular 2")
                        {
                            priC = false;
                            txtCel.SelectedIndex = 1;
                            Mcel.BackColor = Color.Gray;
                            CCanc.Visible = false;
                        }
                        else
                        if (txtCel.Text == txtCel.Items[1].ToString())
                        {
                            MessageBox.Show("Digite um celular diferente do atual", "Celular Repetido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtCel.Text = "Celular 2";
                        }
                        else
                        if (txtCel.Text == txtCel.Items[1].ToString())
                        {
                            MessageBox.Show("Telefone digitado igual ao celular primario", "Celular Repetido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtCel.Text = "Celular 2";
                        }
                    }
                    //se o text for difirente de novo email 1 ou novo email 2
                    //pega o text do combo 
                    //substitui o valor do index certo com o text
                    //atualiza no banco
                    //e pronto
                }
            }
        }

        private void ECanc_Click(object sender, EventArgs e)
        {
            MEmail.BackColor = Color.Gray;
            priE = false;
            txtEmail.SelectedIndex = 0;
            ECanc.Visible = false;
        }

        private void TCanc_Click(object sender, EventArgs e)
        {
            Mtel.BackColor = Color.Gray;
            priT = false;
            txtTel.SelectedIndex = 0;
            TCanc.Visible = false;
        }

        private void CCanc_Click(object sender, EventArgs e)
        {
            Mcel.BackColor = Color.Gray;
            priC = false;
            txtCel.SelectedIndex = 0;
            CCanc.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            BtnBuscar.Enabled = false;
         //  foreach (var process in Process.GetProcessesByName("FileToIconTest"))
        //  {

          //          process.Kill();

         //   }

            //Se já existe um app carregado dentro do Panel, fecha ele
            if (Child != IntPtr.Zero)
              {
                  Win32.CloseWindow(Child);
                  Child = IntPtr.Zero;
                  //pnlArq.Dispose();
                  pnlArq.Refresh();
              }
              string local;
              string path = Path.Combine(Application.StartupPath, "..\\..");
              DirectoryInfo dir_info = new DirectoryInfo(path);
              local = dir_info.FullName;
              local = local + @"\bin\Debug\FileToIconTest.exe";
              System.Diagnostics.Process p = System.Diagnostics.Process.Start(local);
              while (p.MainWindowHandle == IntPtr.Zero)
              {
                  p.Refresh();
                  System.Threading.Thread.Sleep(1000);
              }

              Child = p.MainWindowHandle;

  #if NO_STYLE
              //--------------------------------
              //Retira a barra de título e as bordas da Janela do app externo
              int winLong = Win32.GetWindowLong(Child, Win32.GWL_STYLE);

              winLong &= ~((int)Win32.WS.WS_CAPTION | (int)Win32.WS.WS_THICKFRAME |
                  (int)Win32.WS.WS_MINIMIZE | (int)Win32.WS.WS_MAXIMIZE);

              winLong &= ~((int)Win32.WS.WS_EX_DLGMODALFRAME |
                  (int)Win32.WS.WS_EX_CLIENTEDGE | (int)Win32.WS.WS_EX_STATICEDGE | (int)Win32.WS.WS_POPUP);

              Win32.SetWindowLong(Child, Win32.GWL_STYLE, winLong);

              //------------------------------
              //Define a janela do app externo como filha do Panel
  #endif
              Win32.SetParent(Child, pnlArq.Handle);
              Win32.ShowWindow(Child, Win32.nCmdShow.SW_SHOWMAXIMIZED);
              //Define a posição e o tamanho da Janela dentro do Panel
  #if NO_STYLE
              Win32.SetWindowPos(Child, IntPtr.Zero, 0, 0, panel1.Size.Width, panel1.Size.Height, (uint)((uint)Win32.SWPF.FRAMECHANGED
                  | (uint)Win32.SWPF.NOZORDER | (uint)Win32.SWPF.NOOWNERZORDER));
  #endif

            BtnBuscar.BackColor = Color.FromArgb(255, 126, 0);
            System.Threading.Thread.Sleep(200);
            BtnBuscar.Enabled = true;
        }

        private void Mtel_Click(object sender, EventArgs e)
        {          
            string text;
            //ready pra não entrar no codigo enquanto o form ta abrindo
            if (ready)
            {
                //pri != true significa q é a primeira vez q ele clica no botão 
                if (priT != true)
                {
                    telIndex = txtTel.SelectedIndex;

                    txtTel.SelectedIndex = -1;

                    txtTel.DropDownStyle = ComboBoxStyle.DropDown;

                    if (telIndex == 0)
                    {
                        txtTel.Text = "Telefone 1";
                    }
                    else
                    {
                        txtTel.Text = "Telefone 2";
                    }
                    priT = true;
                    TCanc.Visible = true;
                    Mtel.BackColor = Color.Green;
                }
                else
                //pri == true significa q é a segunda vez q ele clica no botão 
                //
                if (priT == true)
                {
                    if (telIndex == 0)
                    {
                        if (txtCel.Text != "Telefone 1")
                        {
                            txtTel.Text = txtTel.Text.Insert(0, "(");
                            txtTel.Text = txtTel.Text.Insert(3, ")");
                            txtTel.Text = txtTel.Text.Insert(8, "-");
                        }                       

                        if (txtTel.Text != "Telefone 1" && txtTel.Text != txtTel.Items[0].ToString() && txtTel.Text != txtTel.Items[1].ToString())
                        {       
                            text = txtTel.Text;

                            update = "UPDATE `dados` SET `tel`= '" + text + "' WHERE `idAluno`= '" + Program.Codigo + "' AND tel = '" + txtTel.Items[0].ToString() + "';";
                            UpdateDados();

                            txtTel.Items[0] = text;
                            txtTel.DropDownStyle = ComboBoxStyle.DropDownList;

                            priT = false;
                            txtTel.SelectedIndex = 0;
                            Mtel.BackColor = Color.Gray;
                            TCanc.Visible = false;
                        }
                        else
                        if (txtTel.Text == "Telefone 1")
                        {
                            priT = false;
                            txtTel.SelectedIndex = 0;
                            Mtel.BackColor = Color.Gray;
                            TCanc.Visible = false;
                        }
                        else
                        if (txtTel.Text == txtTel.Items[0].ToString())
                        {
                            MessageBox.Show("Digite um telefone diferente do atual", "Telefone Repetido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtTel.Text = "Telefone 1";
                        }
                        else
                        if(txtTel.Text == txtTel.Items[1].ToString())
                        {
                            MessageBox.Show("Telefone digitado igual ao Telefone secundario", "Telefone Repetido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtTel.Text = "Telefone 1";
                        }
                    }
                    else
                    if (telIndex == 1)
                    {
                        if (txtCel.Text != "Telefone 2")
                        {
                            txtTel.Text = txtTel.Text.Insert(0, "(");
                            txtTel.Text = txtTel.Text.Insert(3, ")");
                            txtTel.Text = txtTel.Text.Insert(8, "-");
                        }

                        if (txtTel.Text != "Telefone 2" && txtTel.Text != txtTel.Items[1].ToString() && txtTel.Text != txtTel.Items[0].ToString())
                        {
                            text = txtTel.Text;

                            update = "UPDATE `dados` SET `tel`= '" + text + "' WHERE `idAluno`= '" + Program.Codigo + "' AND tel = '" + txtTel.Items[1].ToString() + "';";
                            UpdateDados();

                            txtTel.Items[1] = text;
                            txtTel.DropDownStyle = ComboBoxStyle.DropDownList;

                            priT = false;
                            txtTel.SelectedIndex = 0;
                            Mtel.BackColor = Color.Gray;
                            TCanc.Visible = false;
                        }
                        else
                        if (txtTel.Text == "Telefone 2")
                        {
                            priT = false;
                            txtTel.SelectedIndex = 1;
                            Mtel.BackColor = Color.Gray;
                            TCanc.Visible = false;
                        }
                        else
                        if (txtTel.Text == txtTel.Items[1].ToString())
                        {
                            MessageBox.Show("Digite um telefone diferente do atual", "Telefone Repetido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtTel.Text = "Telefone 2";
                        }
                        else
                        if(txtTel.Text == txtTel.Items[0].ToString())
                        {
                            MessageBox.Show("Telefone digitado igual ao Telefone primario", "Telefone Repetido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtTel.Text = "Telefone 2";
                        }
                    }
                    //se o text for difirente de novo email 1 ou novo email 2
                    //pega o text do combo 
                    //substitui o valor do index certo com o text
                    //atualiza no banco
                    //e pronto
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PScanner scan = new PScanner();
            scan.ShowDialog();
            button8_Click(sender, e);
        }

        void InsertImagem(Control con)
        {
            string sql = "INSERT INTO `imagens`(`IdImagem`, `Nome`, `Descricao`, `IdAluno`) VALUES (@IdImagem,@Nome,@Descri,@IdAluno)";
            try
            {
                mConn = new MySqlConnection(conexao);
                mConn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao comunicar-se com o banco");
            }
            using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
            {
                cmd.Parameters.AddWithValue("@IdImagem", Program.idImagem);
                cmd.Parameters.AddWithValue("@Nome", @"B_" + nomearq);
                cmd.Parameters.AddWithValue("@Descri", "");
                cmd.Parameters.AddWithValue("@IdAluno", Program.Codigo);
                cmd.ExecuteNonQuery();
            }
        }

        private void MEmail_Click(object sender, EventArgs e)
        {
            string text;
            //ready pra não entrar no codigo enquanto o form ta abrindo
            if (ready)
            {
                //pri != true significa q é a primeira vez q ele clica no botão 
                if (priE != true)
                {
                    emailIndex = txtEmail.SelectedIndex;

                    txtEmail.SelectedIndex = -1;

                    txtEmail.DropDownStyle = ComboBoxStyle.DropDown;

                    if (emailIndex == 0)
                    {
                        txtEmail.Text = "Novo Email 1";
                    }
                    else
                    {
                        txtEmail.Text = "Novo Email 2";
                    }
                    priE = true;
                    ECanc.Visible = true;
                    MEmail.BackColor = Color.Green;
                }
                else
                //pri == true significa q é a segunda vez q ele clica no botão 
                if (priE == true)
                {
                    if (emailIndex == 0)
                    {
                        if (txtEmail.Text != "Novo Email 1" && txtEmail.Text != txtEmail.Items[0].ToString() && txtEmail.Text != txtEmail.Items[1].ToString())
                        {
                            text = txtEmail.Text;

                            update = "UPDATE `dados` SET `email`= '" + text + "' WHERE `idAluno`= '" + Program.Codigo + "' AND email = '" + txtEmail.Items[0].ToString() + "';";
                            UpdateDados();

                            txtEmail.Items[0] = text;
                            txtEmail.DropDownStyle = ComboBoxStyle.DropDownList;

                            priE = false;
                            txtEmail.SelectedIndex = 0;
                            MEmail.BackColor = Color.Gray;
                            ECanc.Visible = false;
                        }
                        else
                        if (txtEmail.Text == "Novo Email 1")
                        {
                            priE = false;
                            txtEmail.SelectedIndex = 0;
                            MEmail.BackColor = Color.Gray;
                            ECanc.Visible = false;
                        }
                        else
                        if (txtEmail.Text == txtEmail.Items[0].ToString())
                        {
                            MessageBox.Show("Digite um E-mail diferente do atual", "E-mail Repetido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        if(txtEmail.Text == txtEmail.Items[1].ToString())
                        {
                            MessageBox.Show("E-mail digitado igual ao e-mail secundario", "E-mail Repetido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    if (emailIndex == 1)
                    {
                        if (txtEmail.Text != "Novo Email 2" && txtEmail.Text != txtEmail.Items[1].ToString() && txtEmail.Text != txtEmail.Items[0].ToString())
                        {
                            text = txtEmail.Text;

                            update = "UPDATE `dados` SET `email`= '" + text + "' WHERE `idAluno`= '" + Program.Codigo + "' AND email = '" + txtEmail.Items[1].ToString() + "';";
                            UpdateDados();

                            txtEmail.Items[1] = text;
                            txtEmail.DropDownStyle = ComboBoxStyle.DropDownList;

                            priE = false;
                            txtEmail.SelectedIndex = 0;
                            MEmail.BackColor = Color.Gray;
                            ECanc.Visible = false;
                        }
                        else
                        if (txtEmail.Text == "Novo Email 2")
                        {
                            priE = false;
                            txtEmail.SelectedIndex = 1;
                            MEmail.BackColor = Color.Gray;
                            ECanc.Visible = false;
                        }
                        else
                        if (txtEmail.Text == txtEmail.Items[1].ToString())
                        {
                            MessageBox.Show("Digite um E-mail diferente do atual", "E-mail Repetido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        if (txtEmail.Text == txtEmail.Items[0].ToString())
                        {
                            MessageBox.Show("E-mail digitado igual ao e-mail primario", "E-mail Repetido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    //se o text for difirente de novo email 1 ou novo email 2
                    //pega o text do combo 
                    //substitui o valor do index certo com o text
                    //atualiza no banco
                    //e pronto
                }
            }
        }

        void UpdateDados()
        {
            try
            {
                mConn = new MySqlConnection(conexao);
                mConn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao se comunicar com o Banco");
            }
            string sql = update;
            using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
            {
                cmd.ExecuteNonQuery();
            }
            mConn.Close();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            /*if (ready)
            {
                emailIndex = txtEmail.SelectedIndex;

                string temp0, temp1, txt;

                txt = txtEmail.Text;
                temp0 = txtEmail.Items[0].ToString();
                temp1 = txtEmail.Items[1].ToString();

                if (emailIndex == 0)
                {
                    if (temp0 != txt)
                    {
                        BtnAtualiza.Enabled = true;
                    }
                    else
                    {
                        BtnAtualiza.Enabled = false;
                    }
                }
                else
                if (emailIndex == 1)
                {
                    if (temp1 != txt)
                    {
                        BtnAtualiza.Enabled = true;
                    }
                    else
                    {
                        BtnAtualiza.Enabled = false;
                    }
                }

                     if (temp0 != Email1 || temp1 != Email2)
                     {
                         BtnAtualiza.Enabled = true;
                     }
                     else
                     {
                         BtnAtualiza.Enabled = false;
                     }
                }*/
        }

        void buscarIdImagem(Control con)
        {
            try
            {
                mConn = new MySqlConnection(conexao);
                mConn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao se comunicar com o Banco");
            }

            string sql = "SELECT MAX(IdImagem) FROM imagens";

            using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //try-catch para verifica se o valor é nulo
                    try
                    {
                        Program.idImagem = reader.GetInt16("MAX(IdImagem)");
                        Program.idImagem++;
                    }
                    catch (System.Data.SqlTypes.SqlNullValueException ex)
                    {
                        Program.idImagem = 1;
                    }
                }
                reader.Close();
            }
        }

        private void BtnAtualiza_Click(object sender, EventArgs e)
        {
            utilidades uti = new utilidades();
            uti.AtualizaAluno(Convert.ToInt16(Program.id), TxtName.Text, TxtRg.Text, TxtCpf.Text, TxtRa.Text, TxtNasc.Text,txtTel.Text,txtCel.Text ,txtEmail.Text, TxtSexo.Text);

            Program.nome = TxtName.Text;
            Program.rg = TxtRg.Text;
            Program.cpf = TxtCpf.Text;
            Program.ra = TxtRa.Text;
            Program.sexo = TxtSexo.Text;
            Program.nasc = TxtNasc.Text;

            BtnAtualiza.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var process in Process.GetProcessesByName("WindowsFormsApplication1"))
            {
                process.Kill();
            }

            PicPerfil.BackgroundImage.Dispose();
            string local;
            string path = Path.Combine(Application.StartupPath, "..\\..");
            DirectoryInfo dir_info = new DirectoryInfo(path);
            local = dir_info.FullName;
            local = local + @"\bin\Debug\WindowsFormsApplication1.exe";
            Process myProcess = System.Diagnostics.Process.Start(local);

            myProcess.WaitForExit();

            System.Threading.Thread.Sleep(1);

            if (System.IO.File.Exists(@"C:\Fotos\Perfil\" + Program.Codigo + ".png"))
            {
                PictureBox pb = new PictureBox();
                Image Imagem = Image.FromFile(@"C:\Fotos\Perfil\" + Program.Codigo + ".png");
                pb.Image = Imagem;
                pb.Height = 170;
                pb.Width = 170;
                PicPerfil.BackgroundImage = pb.Image;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PicPerfil.BackgroundImage.Dispose();
            this.BuscaImagem.Multiselect = true;
            this.BuscaImagem.Title = "Selecionar Fotos";
            BuscaImagem.InitialDirectory = @"C:";
            //filtra para exibir somente arquivos de imagens
            BuscaImagem.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "|*.*";
            BuscaImagem.CheckFileExists = true;
            BuscaImagem.CheckPathExists = true;
            BuscaImagem.FilterIndex = 2;
            BuscaImagem.RestoreDirectory = true;
            BuscaImagem.ReadOnlyChecked = true;
            BuscaImagem.ShowReadOnly = true;

            DialogResult dr = this.BuscaImagem.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                // Le os arquivos selecionados 
                foreach (String arquivo in BuscaImagem.FileNames)
                {
                    nomearq += arquivo;
                    nomearq = Path.GetFileName(nomearq);
                    PictureBox pb = new PictureBox();
                    Image Imagem = Image.FromFile(arquivo);
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    //para exibir as imagens em tamanho natural 
                    //descomente as linhas abaixo e comente as duas seguintes
                    pb.Height = Imagem.Height;
                    pb.Width = Imagem.Width;
                    //pb.Height = 1000;
                    //pb.Width = 1000;
                    //atribui a imagem ao PictureBox - pb

                    pb.Image = Imagem;

                    if (System.IO.File.Exists(Program.AlunoCaminho + Program.Codigo + ".png"))
                    {
                        DialogResult confirm = MessageBox.Show("Aluno já possui foto no perfil, deseja substituir?", "Foto existente!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

                        if (confirm.ToString().ToUpper() == "YES")
                        {
                            caminhoImagemSalva = Program.AlunoCaminho + Program.Codigo + ".png";

                            File.Delete(caminhoImagemSalva);       
                                         
                            pb.Image.Save(caminhoImagemSalva);

                            PicPerfil.BackgroundImage = pb.Image;

                            MessageBox.Show("Foto salva com sucesso");
                        }
                    }
                    else
                    {
                        caminhoImagemSalva = Program.AlunoCaminho + Program.Codigo + ".png";

                        File.Delete(caminhoImagemSalva);

                        pb.Image.Save(caminhoImagemSalva);

                        PicPerfil.BackgroundImage = pb.Image;

                        MessageBox.Show("Foto salva com sucesso");
                    }
                }
            }
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            TratarImagens img = new TratarImagens();
            img.ShowDialog();
        }

        private void BuscarImagens_Click(object sender, EventArgs e)
        {
            this.BuscaImagem.Multiselect = true;
            this.BuscaImagem.Title = "Selecionar Fotos";
            BuscaImagem.InitialDirectory = @"C:";
            //filtra para exibir somente arquivos de imagens
            BuscaImagem.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "|*.*";
            BuscaImagem.CheckFileExists = true;
            BuscaImagem.CheckPathExists = true;
            BuscaImagem.FilterIndex = 2;
            BuscaImagem.RestoreDirectory = true;
            BuscaImagem.ReadOnlyChecked = true;
            BuscaImagem.ShowReadOnly = true;

            DialogResult dr = this.BuscaImagem.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                // Le os arquivos selecionados 
                foreach (String arquivo in BuscaImagem.FileNames)
                {
                    nomearq += arquivo;
                    nomearq = Path.GetFileName(nomearq);
                    PictureBox pb = new PictureBox();
                        Image Imagem = Image.FromFile(arquivo);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        //para exibir as imagens em tamanho natural 
                        //descomente as linhas abaixo e comente as duas seguintes
                        pb.Height = Imagem.Height;
                        pb.Width = Imagem.Width;
                    //pb.Height = 1000;
                    //pb.Width = 1000;
                    //atribui a imagem ao PictureBox - pb
                    
                    pb.Image = Imagem;

                    buscarIdImagem(this);
                    InsertImagem(this);
                    pb.Image.Save(Program.localfiles + @"\B_" + nomearq);         
                }
            }
            foreach (var process in Process.GetProcessesByName("FileToIconTest"))
            {
                process.Kill();
            }
            button8_Click(sender, e);
        }

        private void button6_Click(object sender, EventArgs e)
            {
            try
            {
                string line;
                string path = @"C:\Fotos\ImagemLocation.txt";

                DialogResult confirm = MessageBox.Show("Deseja mesmo excluir este(s) arquivo(s)?", "Excluir arquivo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

                if (confirm.ToString().ToUpper() == "YES")
                {
                    System.IO.StreamReader file = new System.IO.StreamReader(path);
                    while ((line = file.ReadLine()) != null)
                    {
                        
                        deleteArq = line;
                        NomeArqDelete = Path.GetFileName(deleteArq);

                        //file.Dispose();

                        if (deleteArq != "")
                        {
                            utilidades uti = new utilidades();
                            uti.deleteArqbanco(Program.Codigo, NomeArqDelete);

                            File.Delete(deleteArq);                            
                        }
                    }
                    file.Dispose();
                    File.Delete(path);
                }
                button8_Click(sender, e);
            }
            catch(System.IO.FileNotFoundException ex)
            {
                MessageBox.Show("Selecione um arquivo!");
            }

            
        }
    }
}
