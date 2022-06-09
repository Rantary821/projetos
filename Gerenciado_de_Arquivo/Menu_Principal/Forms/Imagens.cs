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
using System.Drawing.Printing;
using System.Runtime.InteropServices;
using System.IO;
using BurnMedia;

namespace Menu_Principal
{
    public partial class Imagens : Form
    {
        int w, h, numPg,X,Y;
        bool vazio;
        string line;

        Image img;

        [DllImport("Shlwapi.dll", CharSet = CharSet.Auto)]
        public static extern Int32 StrFormatByteSize(
        long fileSize,
        [MarshalAs(UnmanagedType.LPTStr)] StringBuilder buffer,
        int bufferSize);

        private void Imagens_Load(object sender, EventArgs e)
        {
            int counter = 0;
            string line;
            string path = @"C:\Dropbox\FisoBarretos\Paths.txt";

            if (!System.IO.File.Exists(path))
            {
                BtnImprimir.Enabled = false;
                BtnEmail.Enabled = false;
                BtnGravar.Enabled = false;

                MessageBox.Show("Nenhum documento selecionado!");

                this.Close();
            }
            else
            if (System.IO.File.Exists(path))
            {
                string text = File.ReadAllText(path);

                if (text == "")
                {
                    BtnImprimir.Enabled = false;
                    BtnEmail.Enabled = false;
                    BtnGravar.Enabled = false;

                    MessageBox.Show("Nenhum documento selecionado!");

                    this.Close();
                }
                else
                {
                    // Read the file and display it line by line.
                    
                }
            }
            BuscaIamgens();
        }

        void LimpalayoutPanel()
        {
            //Liberar todo o espaço da memoria q o Layout panel usa
            List<Control> listControls = new List<Control>();

            foreach (Control control in LayPanel.Controls)
            {
                listControls.Add(control);
            }

            foreach (Control control in listControls)
            {
                LayPanel.Controls.Remove(control);
                control.Dispose();
            }
        }

        // PictureBoxes we use to display thumbnails.
        private List<PictureBox> PictureBoxes = new List<PictureBox>();

        // Thumbnail sizes.
        private const int ThumbWidth = 240;//largura
        private const int ThumbHeight = 248;

        void BuscaIamgens()
        {
            LayPanel.Controls.Clear();
            PictureBoxes = new List<PictureBox>();

            string path = @"C:\Dropbox\FisoBarretos\Paths.txt";
            string lines;

            System.IO.StreamReader file = new System.IO.StreamReader(path);
            while ((lines = file.ReadLine()) != null)
            {
                PictureBox pic = new PictureBox();

                using (var bmpTemp = new Bitmap(lines))
                {
                    img = new Bitmap(bmpTemp); //.GetThumbnailImage(90, 110, () => false, IntPtr.Zero);
                    bmpTemp.Dispose();
                }

                pic.ClientSize = new Size(ThumbWidth, ThumbHeight);
                pic.Image = img;
                pic.SizeMode = PictureBoxSizeMode.Zoom;

                FileInfo file_info = new FileInfo(lines);
                tipPicture.SetToolTip(pic, file_info.Name +
                    "\nCreated: " + file_info.CreationTime.ToShortDateString() +
                    "\n(" + pic.Image.Width + " x " + pic.Image.Height + ") " +
                    ToFileSizeApi(file_info.Length));
                pic.Tag = file_info;

                string name = Path.GetFileNameWithoutExtension(pic.Tag.ToString());

                CustomControl c = new CustomControl(pic, new Label { Text = name });
                LayPanel.Controls.Add(c);
            }
            file.Dispose();
        }

        public class CustomControl : Control
        {
            private PictureBox _Pic;
            private Label _label;
            public CustomControl(PictureBox Picture, Label label)
            {
                _Pic = Picture;
                _label = label;
                Height = Picture.Height + label.Height + 20;
                Width = Math.Max(Picture.Width, label.Width + 20);
                Controls.Add(_Pic);
                _Pic.Location = new Point(0, 0);
                Controls.Add(_label);
                _label.Location = new Point(35, Picture.Height);
                _label.Font = new Font("Arial", 10, FontStyle.Bold);
            }
        }

        // Return a file size created by the StrFormatByteSize API function.
        public static string ToFileSizeApi(long file_size)
        {
            StringBuilder sb = new StringBuilder(20);
            StrFormatByteSize(file_size, sb, 20);
            return sb.ToString();
        }


        private void BtnClose_Click(object sender, EventArgs e)
        {
            img.Dispose();
            LimpalayoutPanel();
            this.Close();
        }

        private void BtnEmail_Click(object sender, EventArgs e)
        {
            Email mail = new Email();
            mail.ShowDialog();
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        { //pageViewer = picturebox

            System.Drawing.Image img = System.Drawing.Image.FromFile(line);

            Image i = img;

            float newWidth = i.Width * 100 / i.HorizontalResolution;
            float newHeight = i.Height * 100 / i.VerticalResolution;

            float widthFactor = newWidth / e.PageBounds.Width;
            float heightFactor = newHeight / e.PageBounds.Height;

            if (widthFactor > 1 | heightFactor > 1)
            {
                if (widthFactor > heightFactor)
                {
                    newWidth = newWidth / widthFactor;
                    newHeight = newHeight / widthFactor;
                }
                else
                {
                    newWidth = newWidth / heightFactor;
                    newHeight = newHeight / heightFactor;
                }
            }
            e.Graphics.DrawImage(i, 0, 0, (int)newWidth, (int)newHeight);
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            Gravar burn = new Gravar();
            burn.ShowDialog();
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

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += PrintPage;
            //here to select the printer attached to user PC
            PrintDialog printDialog1 = new PrintDialog();
            printDialog1.Document = pd;
            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                numPg = pd.PrinterSettings.Copies;

                int counter = 0;
                string path = @"C:\Dropbox\FisoBarretos\Paths.txt";

                System.IO.StreamReader file = new System.IO.StreamReader(path);
                while ((line = file.ReadLine()) != null)
                {
                    int i = 0;
                    do
                    {
                        pd.Print();
                        i++;
                    }
                    while (i < numPg);

                    counter++;
                }
                file.Dispose();
            }
        }

        public Imagens()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(panel1_MouseDown);
            this.MouseMove += new MouseEventHandler(panel1_MouseMove);
        }
    }
}
