using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace TesteMostrarImagens
{
    public partial class ZoomIMG : Form
    {
        int quantImg = Program.PathsImg.Count(), count = 0;

        string path;

        public ZoomIMG()
        {
            InitializeComponent();
        }
        private void ZoomIMG_Load(object sender, EventArgs e)
        {
            All();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            PicImageZoom.BackgroundImage.Dispose();
            this.Close();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            count++;
            All();
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
            count--;
            All();
        }

        void All()
        {
            try
            {
                PicImageZoom.BackgroundImage.Dispose();
            }
            catch(Exception ex)
            {

            }

            path = Program.PathsImg[count];

            TxtNomeArquivo.Text = Path.GetFileNameWithoutExtension(path);

            PicImageZoom.BackgroundImage = Image.FromFile(path);
            PicImageZoom.BackgroundImageLayout = ImageLayout.Zoom;

            if(quantImg == 1)
            {
                BtnPrev.Enabled = false;
                BtnNext.Enabled = false;
            }
            else
            if (count > 0 && count < (quantImg - 1))
            {
                BtnPrev.Enabled = true;
                BtnNext.Enabled = true;
            }
            else
            if (count == 0)
            {
                BtnPrev.Enabled = false;
                BtnNext.Enabled = true;
            }
            else
            if (count == (quantImg - 1))
            {
                BtnPrev.Enabled = true;
                BtnNext.Enabled = false;
            }
        }
    }
}
