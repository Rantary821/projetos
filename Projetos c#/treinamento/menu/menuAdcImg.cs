using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security;
using MySql.Data.MySqlClient;

namespace menu
{

    public partial class Form1 : Form
    {
        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private MySqlDataReader reader;
        private DataSet mDataSet;
        private MySqlCommand cmd;
        int X = 0;
        int Y = 0;
        public Form1()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(Form1_MouseDown);
            this.MouseMove += new MouseEventHandler(Form1_MouseMove);
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void carregaImg_Click(object sender, EventArgs e)
        {
            limpaImg();
            carregarImgem(); 
        }
        public void limpaImg()
        {
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                flowLayoutPanel1.Controls.Remove(control);
                control.Dispose();
            }
            txtArquivo.Text = "";
        }
        void carregarImgem() {
            
            //define as propriedades do controle 
            //OpenFileDialog
            this.ofd1.Multiselect = true;
            this.ofd1.Title = "Selecionar Fotos";
            ofd1.InitialDirectory = @"C:\Users\macoratti\Pictures";
            //filtra para exibir somente arquivos de imagens
            ofd1.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
            ofd1.CheckFileExists = true;
            ofd1.CheckPathExists = true;
            ofd1.FilterIndex = 2;
            ofd1.RestoreDirectory = true;
            ofd1.ReadOnlyChecked = true;
            ofd1.ShowReadOnly = true;

            DialogResult dr = this.ofd1.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                // Le os arquivos selecionados 
                foreach (String arquivo in ofd1.FileNames)
                {
                    txtArquivo.Text += arquivo;
                    // cria um PictureBox
                    try
                    {
                        PictureBox pb = new PictureBox();
                        Image Imagem = Image.FromFile(arquivo);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        //para exibir as imagens em tamanho natural 
                        //descomente as linhas abaixo e comente as duas seguintes
                        //pb.Height = loadedImage.Height;
                        //pb.Width = loadedImage.Width;
                        pb.Height = 188;
                        pb.Width = 347;
                        //atribui a imagem ao PictureBox - pb
                        pb.Image = Imagem;
                        //inclui a imagem no containter flowLayoutPanel
                        flowLayoutPanel1.Controls.Add(pb);
                    }
                    catch (SecurityException ex)
                    {
                        // O usuário  não possui permissão para ler arquivos
                     //   MessageBox.Show("Erro de segurança Contate o administrador de segurança da rede.\n\n" +
                                                //    "Mensagem : " + ex.Message + "\n\n" +
                                                 //   "Detalhes (enviar ao suporte):\n\n" + ex.StackTrace);
                    }
                    catch (Exception ex)
                    {
                        // Não pode carregar a imagem (problemas de permissão)
                       // MessageBox.Show("Não é possível exibir a imagem : " + arquivo.Substring(file.LastIndexOf('\\'))
                                             //      + ". Você pode não ter permissão para ler o arquivo , ou " +
                                              //     " ele pode estar corrompido.\n\nErro reportado : " + ex.Message);
                    }
                }
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            limpaImg();
        }

        void conecta()
        {
            
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja inserir a informação?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                // rotina
                try
                {
                    System.IO.File.Copy(@"" + txtArquivo.Text + "", @"C:\treinamento\1.jpg");
                }catch(Exception ex)
                {
                    MessageBox.Show("erro: " + ex);
                }
                  limpaImg();
                //
                MessageBox.Show("Registro inserido com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        
        }
    }
}
