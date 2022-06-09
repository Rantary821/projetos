using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WIA;
using MySql.Data.MySqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ScannerDemo;
using Menu_Principal;

namespace Menu_Principal
{
    public partial class PScanner : Form
    {
        Int64 quality;
        string pathSTemp2;
        public int idd,X,Y;

        string pathBackup;
        public PScanner()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(panel1_MouseDown);
            this.MouseMove += new MouseEventHandler(panel1_MouseMove);
            this.ActiveControl = txtNome;
        }

        private void PScanner_Load(object sender, EventArgs e)
        {
            RadioMedia.Checked = true;
            RadioColorido.Checked = true;
            ListScanners();
        }

        private void ListScanners()
        {
            // Clear the ListBox.
            Scanners.Items.Clear();

            // Create a DeviceManager instance
            var deviceManager = new DeviceManager();

            // Loop through the list of devices and add the name to the listbox
            for (int i = 1; i <= deviceManager.DeviceInfos.Count; i++)
            {
                // Add the device only if it's a scanner
                if (deviceManager.DeviceInfos[i].Type != WiaDeviceType.ScannerDeviceType)
                {
                    continue;
                }

                // Add the Scanner device to the listbox (the entire DeviceInfos object)
                // Important: we store an object of type scanner (which ToString method returns the name of the scanner)
                Scanners.Items.Add(
                    new Scanner(deviceManager.DeviceInfos[i])
                );
            }
            if (Scanners.Items.Count != 0)
            {
                //Inicia selecionado o primeiro scanner da lista
                Scanners.SelectedIndex = 0;
            }
        }

        private void TriggerScan()
        {
            Console.WriteLine("Imagem digitalizada!");
        }

        public void StartScanning()
        {
            Scanner device = null;

            this.Invoke(new MethodInvoker(delegate ()
            {
                device = Scanners.SelectedItem as Scanner;
            }));

            if (device == null)
            {
                MessageBox.Show("Selecione um scanner da lista!",
                                "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ImageFile image = new ImageFile();
            string imageExtension = "";

            this.Invoke(new MethodInvoker(delegate ()
            {
                image = device.ScanPNG();
                imageExtension = ".png";
            }));

            if (Scanner.ScanError == false)
            {
                // Save the image
                Program.path = Program.Diretorio + @"\" + Program.id + @"\" + txtNome.Text + imageExtension;//Path.Combine(Program.localfiles, txtNome.Text + imageExtension);

                if (!Directory.Exists(@"C:\tempIMG"))
                {
                    Directory.CreateDirectory(@"C:\tempIMG");
                }

                pathSTemp2 = @"C:\tempIMG" + @"\" + txtNome.Text + "T.png";

                image.SaveFile(pathSTemp2);

                QualityLevel();

                pictureBox1.Image = new Bitmap(Program.path);

                image = null;

                File.Delete(pathSTemp2);

                if (Directory.Exists(@"C:\tempIMG"))
                {
                    Directory.Delete(@"C:\tempIMG");
                }
            }   
        }

        private void QualityLevel()//funfa
        {
            try
            {
                using (var bitmap = new Bitmap(pathSTemp2))
                {
                    using (Bitmap Bit = new Bitmap(bitmap))
                    {
                        ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);

                        System.Drawing.Imaging.Encoder myEncoder = System.Drawing.Imaging.Encoder.Quality;

                        EncoderParameters myEncoderParameters = new EncoderParameters(1);

                        EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, quality);

                        myEncoderParameters.Param[0] = myEncoderParameter;

                        Bit.Save(Program.path, jpgEncoder, myEncoderParameters);

                        Bit.Dispose();
                        bitmap.Dispose();
                    }                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }      
        }

        private ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnDigitaliza_Click(object sender, EventArgs e)
        {
            if(BtnSim.Visible == false)
            {
                if (Scanners.Items.Count == 0)
                {
                    MessageBox.Show("Nenhum scanner encontrado, verifique sua conexão");
                }
                else
                {
                    if (!System.IO.File.Exists(Program.Diretorio + @"\" + Program.id + @"\" + txtNome.Text + ".png"))
                    {
                        Task.Factory.StartNew(StartScanning).ContinueWith(result => TriggerScan());
                        lblConfirm.Visible = true;
                        BtnSim.Visible = true;
                        BtnNao.Visible = true;
                        BtnClose.Enabled = false;
                        txtNome.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Aluno já possui um arquivo com esse nome");
                    }
                }
            }
            else
            {
                MessageBox.Show("Confirme a imagem por favor!");
            }
        }

        private void BtnSim_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.Dispose();
            //pictureBox1.Image = null;

            Console.WriteLine("Imagem Salva!");

            BtnClose.Enabled = true;
            txtNome.Enabled = true;
            txtNome.Text = "";
            lblConfirm.Visible = false;
            BtnSim.Visible = false;
            BtnNao.Visible = false;
        }

        private void BtnNao_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.Dispose();
            //pictureBox1.Image = null;

            File.Delete(Program.path);

            BtnClose.Enabled = true;
            txtNome.Enabled = true;
            lblConfirm.Visible = false;
            BtnSim.Visible = false;
            BtnNao.Visible = false;
        }

        private void RadioAlta_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioAlta.Checked)
            {
                quality = 95L;
            }
        }

        private void RadioMedia_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioMedia.Checked)
            {
                quality = 70L;
            }
        }

        private void RadioBaixa_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioBaixa.Checked)
            {
                quality = 45L;
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if(txtNome.Text != "")
            {
                BtnDigitaliza.Enabled = true;
            }
            else
            if (txtNome.Text == "")
            {
                BtnDigitaliza.Enabled = false;
            }

            Program.path = Program.Diretorio + @"\" + Program.id + @"\" + txtNome.Text + ".png";

            if(File.Exists(Program.path))
            {
                lblExists.Text = "Arquivo com mesmo nome existente!";
                BtnDigitaliza.Enabled = false;
            }
            else
            {
                lblExists.Text = "";
                BtnDigitaliza.Enabled = true;
            }
        }

        private void RadioColorido_CheckedChanged(object sender, EventArgs e)
        {
            if(RadioColorido.Checked)
            {
                Scanner.color_mode = 1;
            }
        }

        private void RadioPB_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioPB.Checked)
            {
                Scanner.color_mode = 2;
            }
        }

        private void BtnAtualiza_Click(object sender, EventArgs e)
        {
            ListScanners();
        }

        private void PScanner_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(txtNome.Text != "")
                {
                    if (BtnSim.Visible)
                    {
                        BtnSim_Click(this, e);
                    }
                    else
                    {
                        BtnDigitaliza_Click(sender, e);
                    }
                }                
            }
            if (e.KeyCode == Keys.Escape)
            {
                if(BtnNao.Visible)
                {
                    BtnNao_Click(sender, e);
                }
                else
                {
                    BtnClose_Click(sender, e);
                }
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }
    }
}
