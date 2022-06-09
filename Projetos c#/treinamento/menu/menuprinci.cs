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
    public partial class menuprinci : Form
    {
        public menuprinci()
        {
            InitializeComponent();
        }

        private void pessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pessoa pes = new pessoa();
            pes.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pesquisa pesq = new Pesquisa();
            pesq.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
