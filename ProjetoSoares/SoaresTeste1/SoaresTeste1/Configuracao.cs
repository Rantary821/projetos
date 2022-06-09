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

namespace SoaresTeste1
{
    public partial class Configuracao : Form
    {
        public bool verifica;
        public Configuracao()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Configuracao_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void verificacao()
        {
            if (radioButton1.Checked)
            {
                verifica = true;
            }
            else if (radioButton2.Checked)
            {
                verifica = false;
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            verificacao();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            verificacao();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
