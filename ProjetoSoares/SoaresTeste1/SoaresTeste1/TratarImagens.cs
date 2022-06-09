using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;
namespace SoaresTeste1
{
    public partial class TratarImagens : Form
    {
        int w, h;
        bool vazio;

        public TratarImagens()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TratarImagens_Load(object sender, EventArgs e)
        {
            int counter = 0;
            string line;
            string path = @"C:\Fotos\Paths.txt";

            if (!System.IO.File.Exists(path))
            {
                BtnImprimir.Enabled = false;
                BtnEmail.Enabled = false;
                BtnGravar.Enabled = false;

                MessageBox.Show("Nenhum documento selecionado!");
            }
            else
            if(System.IO.File.Exists(path))
            {
                string text = File.ReadAllText(path);

                if(text == "")
                {
                    BtnImprimir.Enabled = false;
                    BtnEmail.Enabled = false;
                    BtnGravar.Enabled = false;

                    MessageBox.Show("Nenhum documento selecionado!");
                }
                else
                {
                    // Read the file and display it line by line.
                    System.IO.StreamReader file = new System.IO.StreamReader(path);
                    while ((line = file.ReadLine()) != null)
                    {
                        System.Drawing.Image myImage = Image.FromFile(line);
                        imageList1.Images.Add(myImage);

                        this.listView1.View = View.LargeIcon;
                        this.imageList1.ImageSize = new Size(256, 256);
                        this.listView1.LargeImageList = this.imageList1;
                        //or
                        //this.listView1.View = View.SmallIcon;
                        //this.listView1.SmallImageList = this.imageList1;    
                        counter++;
                    }

                    file.Close();
                    for (int j = 0; j < this.imageList1.Images.Count; j++)
                    {
                        ListViewItem item = new ListViewItem();
                        item.ImageIndex = j;
                        this.listView1.Items.Add(item);
                    }
                }
            }   
        }

        class Printer
        {
            private string _imageFile;

            public void Print(string imageFile)
            {
                _imageFile = imageFile;

                PrintDocument pd = new PrintDocument();
                pd.PrintPage += new PrintPageEventHandler(pqr);
                pd.Print();
            }

            void pqr(object o, PrintPageEventArgs e)
            {
                System.Drawing.Image i = System.Drawing.Image.FromFile(_imageFile);
                Point p = new Point(0, 0);
                e.Graphics.DrawImage(i, p);
            }
        }

        private void BtnEmail_Click(object sender, EventArgs e)
        {
            Email em = new Email();
            em.ShowDialog();
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            PrintDialog pdi = new PrintDialog();

            PrinterSettings ps_Current = new PrinterSettings();

            pdi.Document = pd;
            if (pdi.ShowDialog() == DialogResult.OK)
            {
                int numPg = pd.PrinterSettings.Copies;

                int counter = 0;
                string line;
                string path = @"C:\Fotos\Paths.txt";

                System.IO.StreamReader file = new System.IO.StreamReader(path);
                while ((line = file.ReadLine()) != null)
                {
                   // MessageBox.Show("Imprimir arquivo " + Path.GetFileName(line));

                    int i = 0;
                    do
                    {
                        Printer newPrinter = new Printer();
                        newPrinter.Print(line);
                        i++;
                    }
                    while (i < numPg);

                    counter++;
                }
            }
        }
    }
}
