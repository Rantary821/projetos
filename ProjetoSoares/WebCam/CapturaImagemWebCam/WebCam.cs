using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class WebCam : Form
    {
        public DirectX.Capture.Filter Camera;
        public DirectX.Capture.Capture CaptureInfo;
        public DirectX.Capture.Filters CamContainer;
        Image capturaImagem;
        public string caminhoImagemSalva = null;

        int ImagemCod;

        public WebCam()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader(@"C:\Fotos\CodAluno.txt"))
            {
                Program.Codigo = reader.ReadLine();
            }

           CamContainer = new DirectX.Capture.Filters();  
           try
           {
             int no_of_cam = CamContainer.VideoInputDevices.Count;

             for (int i = 0; i < no_of_cam; i++ )
             {
                try
                {
                        // obtém o dispositivo de entrada do vídeo
                        Camera = CamContainer.VideoInputDevices[i];
 
                        // inicializa a Captura usando o dispositivo
                        CaptureInfo = new DirectX.Capture.Capture(Camera, null);
                                                                        
                        // Define a janela de visualização do vídeo
                        CaptureInfo.PreviewWindow = this.picWebCam;
 
                        // Capturando o tratamento de evento
                        CaptureInfo.FrameCaptureComplete += AtualizaImagem;
                                                 
                        // Captura o frame do dispositivo
                        CaptureInfo.CaptureFrame();
                         
                        // Se o dispositivo foi encontrado e inicializado então sai sem checar o resto
                        break;
                }
                catch (Exception ex) 
                {
                    throw ex;    
                }
            }
        }
        catch (Exception ex)
        {                
            MessageBox.Show(this, ex.Message);
        }
     }

        public void AtualizaImagem(PictureBox frame)
        {
            try
            {
                capturaImagem = frame.Image;
                this.picImagem.Image = capturaImagem;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
            }
        }
       
        private void btnCaptura_Click(object sender, EventArgs e)
        {
            try
            {
                picImagem.Visible = true;
                picWebCam.Visible = false;
                btnCaptura.Enabled = false;
                BtnVolta.Enabled = true;
                btnSalvar.Enabled = true;
                CaptureInfo.CaptureFrame();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(Program.AlunoCaminho + Program.Codigo + ".png"))
            {
                DialogResult confirm = MessageBox.Show("Aluno já possui foto no perfil, deseja substituir?", "Foto existente!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

                if (confirm.ToString().ToUpper() == "YES")
                {
                    salvaFoto(this);
                }
            }
            else
            {
                salvaFoto(this);
            }
        }


        void salvaFoto(Control con)
        {
            try
            {
                File.Delete(Program.AlunoCaminho + Program.Codigo + ".png");

                caminhoImagemSalva = Program.AlunoCaminho + Program.Codigo + ".png";
                picImagem.Image.Save(caminhoImagemSalva, ImageFormat.Png);
                MessageBox.Show("Foto salva com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
            }
        }
        private void BtnVolta_Click(object sender, EventArgs e)
        {
            btnSalvar.Enabled = false;
            BtnVolta.Enabled = false;
            btnCaptura.Enabled = true;
            picWebCam.Visible = true;
            picImagem.Visible = false;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Dispose();
        }

        private void WebCam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                btnCaptura_Click(sender, e);
            }
        }
    }
}
