using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WIA;

namespace ScannerDemo
{
    public partial class PScanner : Form
    {
        public PScanner()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*System.Drawing.Rectangle workingRectangle = Screen.PrimaryScreen.WorkingArea;
            this.Size = new System.Drawing.Size(workingRectangle.Width - 800, workingRectangle.Height - 100);*/

            ListScanners();
        }


        private void ListScanners()
        {
            // Clear the ListBox.
            listBox1.Items.Clear();

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
                listBox1.Items.Add(
                    new Scanner(deviceManager.DeviceInfos[i])
                );
            }
            if (listBox1.Items.Count != 0)
            {
                //Inicia selecionado o primeiro scanner da lista
                listBox1.SelectedIndex = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listBox1.Items.Count == 0)
            {
                MessageBox.Show("Nenhum scanner encontrado, verifique sua conexão");
            }
            else
            {
                Task.Factory.StartNew(StartScanning).ContinueWith(result => TriggerScan());
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
                device = listBox1.SelectedItem as Scanner;
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
                var path = Path.Combine(Program.localfiles, textBox2.Text + imageExtension);

                image.SaveFile(path);

                pictureBox1.Image = new Bitmap(path);

                image = null;
            }           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListScanners();
        }

        private void button4_Click(object sender, EventArgs e)
        {     
            pictureBox1.Image.Dispose();
            pictureBox1.Image = null;

            File.Delete(Program.localfiles + textBox2.Text + ".png");

            button1.Enabled = true;
            label3.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.Dispose();
            pictureBox1.Image = null;

            Console.WriteLine("Imagem Salva!");

            button1.Enabled = true;
            label3.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*protected override void OnMouseWheel(MouseEventArgs mea)
        {
            // Override OnMouseWheel event, for zooming in/out with the scroll wheel
            if (pictureBox1.Image != null)
            {
                // If the mouse wheel is moved forward (Zoom in)
                if (mea.Delta > 0)
                {
                    // Check if the pictureBox dimensions are in range (15 is the minimum and maximum zoom level)
                    if ((pictureBox1.Width < (15 * this.Width)) && (pictureBox1.Height < (15 * this.Height)))
                    {
                        // Change the size of the picturebox, multiply it by the ZOOMFACTOR
                        pictureBox1.Width = (int)(pictureBox1.Width * 1.25);
                        pictureBox1.Height = (int)(pictureBox1.Height * 1.25);

                        // Formula to move the picturebox, to zoom in the point selected by the mouse cursor
                        pictureBox1.Top = (int)(mea.Y - 1.25 * (mea.Y - pictureBox1.Top));
                        pictureBox1.Left = (int)(mea.X - 1.25 * (mea.X - pictureBox1.Left));
                    }
                }
                else
                {
                    // Check if the pictureBox dimensions are in range (15 is the minimum and maximum zoom level)
                    if ((pictureBox1.Width > (this.Width / 15)) && (pictureBox1.Height > (this.Height / 15)))
                    {
                        // Change the size of the picturebox, divide it by the ZOOMFACTOR
                        pictureBox1.Width = (int)(pictureBox1.Width / 1.25);
                        pictureBox1.Height = (int)(pictureBox1.Height / 1.25);

                        // Formula to move the picturebox, to zoom in the point selected by the mouse cursor
                        pictureBox1.Top = (int)(mea.Y - 0.80 * (mea.Y - pictureBox1.Top));
                        pictureBox1.Left = (int)(mea.X - 0.80 * (mea.X - pictureBox1.Left));
                    }
                }
            }
        }*/
    }
}
