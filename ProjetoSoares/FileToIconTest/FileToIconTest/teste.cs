using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FileToIconTest
{
    public partial class teste : Form
    {
        public teste()
        {
            InitializeComponent();
        }

        private void teste_Load(object sender, EventArgs e)
        {
            string Codigo;
            using (StreamReader reader = new StreamReader(@"C:\Fotos\ImagemLocation.txt"))
            {
                Codigo = reader.ReadLine();
            }
            PictureBox pb = new PictureBox();
            Image Imagem = Image.FromFile(Codigo);
            pb.Image = Imagem;
            //pb.Height = Imagem.Height;
            //pb.Width = Imagem.Width;

            if(Imagem.Height > Imagem.Width)
            {
                pb.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }

            pb.Height = 572;
            pb.Width = 842; //842; 572

            pb.SizeMode = PictureBoxSizeMode.Zoom;
            flowLayoutPanel1.Controls.Add(pb);

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
