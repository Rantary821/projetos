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
using System.Diagnostics;

namespace Menu_Principal
{
    public partial class ZoomIMG : Form
    {
        Image img;
        string imgePath;

        int L = 0;
        public ZoomIMG()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
           /* if (File.Exists(Program.ClickPath))
            {
                File.Delete(Program.ClickPath);
            }*/
            try
            {
                File.Delete(Program.ClickPath);
            }
            catch
            {

            }


            pictureBox1.BackgroundImage.Dispose();
            img.Dispose();
            this.Close();
        }

        private void ZoomIMG_Load(object sender, EventArgs e)
        {   
            imgePath =  System.IO.File.ReadAllText(Program.ClickPath);

            img = Image.FromFile(imgePath);
            pictureBox1.BackgroundImage = img;
            //img.Dispose();
            LblName.Text = Path.GetFileNameWithoutExtension(imgePath);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1 posição inicial
            // 2 inclinada direita
            // 3 cabeça para baixo
            // 4 inclinada esqueda
            if (L == 0 || L == 4)
            {
                //rotate the picture by 90 degrees and re-save the picture as a Jpeg
                pictureBox1.BackgroundImage.Dispose();
                img = Image.FromFile(imgePath);
                img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox1.BackgroundImage = img;

                L = 1;
            }
            else
            if (L == 1)
            {
                //rotate the picture by 90 degrees and re-save the picture as a Jpeg
                pictureBox1.BackgroundImage.Dispose();
                img = Image.FromFile(imgePath);
                img.RotateFlip(RotateFlipType.Rotate180FlipNone);
                pictureBox1.BackgroundImage = img;

                L = 2;
            }
            else
            if (L == 2)
            {
                //rotate the picture by 90 degrees and re-save the picture as a Jpeg
                pictureBox1.BackgroundImage.Dispose();
                img = Image.FromFile(imgePath);
                img.RotateFlip(RotateFlipType.Rotate270FlipNone);
                pictureBox1.BackgroundImage = img;

                L = 3;
            }
            else
            if (L == 3)
            {
                //rotate the picture by 90 degrees and re-save the picture as a Jpeg
                pictureBox1.BackgroundImage.Dispose();
                img = Image.FromFile(imgePath);
                pictureBox1.BackgroundImage = img;

                L = 4;
            }
        }

        private void ZoomIMG_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                BtnClose_Click(sender, e);
            }
        }
    }
}
