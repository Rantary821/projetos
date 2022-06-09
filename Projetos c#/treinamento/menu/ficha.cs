using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu
{
    public partial class ficha : Form
    {
        int X = 0;
        int Y = 0;
        public ficha()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(imgs_MouseDown);
            this.MouseMove += new MouseEventHandler(imgs_MouseMove);
        }
        private void imgs_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void imgs_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
