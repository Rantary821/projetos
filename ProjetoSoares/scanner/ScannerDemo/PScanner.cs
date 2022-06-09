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

namespace ScannerDemo
{
    public partial class PScanner : Form
    {
        Int64 quality;

        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private MySqlDataReader reader;
        private MySqlCommand cmd;
        public int idd;
        public string conexao = "Persist Security info=False; server=localhost; database=soares;uid=root";

        public PScanner()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*System.Drawing.Rectangle workingRectangle = Screen.PrimaryScreen.WorkingArea;
            this.Size = new System.Drawing.Size(workingRectangle.Width - 800, workingRectangle.Height - 100);*/
            RadioMedia.Checked = true;
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
                MessageBox.Show("You need to select first an scanner device from the list",
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

            if(Program.ScanError == "false")
            {
                // Save the image
                Program.path = Path.Combine(Program.localfiles, txtNome.Text + imageExtension);

                string pathS = @"C:\Fotos\Imgn\" + txtNome.Text + imageExtension;

                image.SaveFile(pathS);

                using (Bitmap bmp1 = new Bitmap(pathS))
                {
                    ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);
                    System.Drawing.Imaging.Encoder myEncoder = System.Drawing.Imaging.Encoder.Quality;

                    EncoderParameters myEncoderParameters = new EncoderParameters(1);

                    EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, quality);
                    myEncoderParameters.Param[0] = myEncoderParameter;

                    bmp1.Save(Program.path, jpgEncoder, myEncoderParameters);
                }

                File.Delete(pathS);

                pictureBox1.Image = new Bitmap(Program.path);

                image = null;             
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

        private void button2_Click(object sender, EventArgs e)
        {
            ListScanners();
        }

        private void button4_Click(object sender, EventArgs e)
        {     
            pictureBox1.Image.Dispose();
            pictureBox1.Image = null;

            File.Delete(Program.localfiles + @"\" + txtNome.Text + ".png");

            BtnDigitaliza.Enabled = true;
            BtnClose.Enabled = true;
            txtNome.Enabled = true;
            txtDescri.Enabled = true;
            lblConfirm.Visible = false;
            BtnSim.Visible = false;
            BtnNao.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.Dispose();
            pictureBox1.Image = null;
            
            Console.WriteLine("Imagem Salva!");

            BtnDigitaliza.Enabled = true;
            BtnClose.Enabled = true;
            txtNome.Enabled = true;
            txtNome.Text = "";
            txtDescri.Text = "";
            txtDescri.Enabled = true;
            lblConfirm.Visible = false;
            BtnSim.Visible = false;
            BtnNao.Visible = false;
        }

        private void BtnDigitaliza_Click(object sender, EventArgs e)
        {
            if (Scanners.Items.Count == 0)
            {
                MessageBox.Show("Nenhum scanner encontrado, verifique sua conexão");
            }
            else
            {
                if(!System.IO.File.Exists(Program.localfiles + @"\" + txtNome.Text + ".png"))
                {
                    Task.Factory.StartNew(StartScanning).ContinueWith(result => TriggerScan());
                    lblConfirm.Visible = true;
                    BtnSim.Visible = true;
                    BtnNao.Visible = true;
                    BtnDigitaliza.Enabled = false;
                    BtnClose.Enabled = false;
                    txtNome.Enabled = false;
                    txtDescri.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Aluno já possui um arquivo com esse nome");
                }       
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if(txtNome.Text == "")
            {
                BtnDigitaliza.Enabled = false;
            }
            if (txtNome.Text != "")
            {
                BtnDigitaliza.Enabled = true;
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RadioAlta_CheckedChanged(object sender, EventArgs e)
        {
            if(RadioAlta.Checked)
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
    }
}
