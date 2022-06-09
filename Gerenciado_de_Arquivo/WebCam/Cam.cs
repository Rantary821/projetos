using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WebCam
{
    public partial class Cam : Form
    {
        public DirectX.Capture.Filter Camera;
        public DirectX.Capture.Capture CaptureInfo;
        public DirectX.Capture.Filters CamContainer;
        Image capturaImagem;
        public string caminhoImagemSalva = null;

        int ImagemCod;

        public Cam()
        {
            InitializeComponent();
        }

        private void Cam_Load(object sender, EventArgs e)
        {
            try
            {
                string exeFolder = System.Reflection.Assembly.GetExecutingAssembly().Location;
                string path2 = @"C:\Dropbox\FisoBarretos\exepath\"; //ExePath.txt

                if (!Directory.Exists(path2))
                {
                    Directory.CreateDirectory(path2);

                    using (StreamWriter sw = File.CreateText(path2 + "ExePath.txt"))
                    {
                        sw.WriteLine(exeFolder);
                        sw.Dispose();
                    }

                    this.Close();
                }
                else
                {
                    using (StreamWriter sw = File.CreateText(path2 + "ExePath.txt"))
                    {
                        sw.WriteLine(exeFolder);
                        sw.Dispose();
                    }
                }
                
                using (StreamReader reader = new StreamReader(@"C:\Dropbox\FisoBarretos\CA.txt"))
                {
                    Program.Codigo = reader.ReadLine();
                }
            }
            catch(Exception ex)
            {

            }

            CamContainer = new DirectX.Capture.Filters();
            try
            {
                int no_of_cam = CamContainer.VideoInputDevices.Count;

                for (int i = 0; i < no_of_cam; i++)
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

        void salvaFoto(Control con)
        {
            try
            {
                File.Delete(Program.AlunoCaminho + Program.Codigo + ".png");

                caminhoImagemSalva = Program.AlunoCaminho + Program.Codigo + ".png";
                picImagem.Image.Save(caminhoImagemSalva, ImageFormat.Png);
                MessageBox.Show("Foto salva com sucesso");

                string tipo = "Comum";

                ImageBackup(caminhoImagemSalva, Program.Codigo, tipo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
            }
        }

        void ImageBackup(string path, string id, string tipo)
        {

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
        }

        private void Cam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                btnCaptura_Click(sender, e);
            }
            this.Focus();
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
    }
}
