using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleFuncionarios
{
    public partial class ficha : Form
    {
        public ficha()
        {
            InitializeComponent();
        }

        private void ficha_Load(object sender, EventArgs e)
        {
            BtnClose.FlatAppearance.BorderSize = 0;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
