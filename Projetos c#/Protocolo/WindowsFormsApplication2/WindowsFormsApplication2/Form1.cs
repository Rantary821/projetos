using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            REsutlado.Text = Convert.ToString((Convert.ToDouble(Txt1.Text) + Convert.ToDouble(Txt2.Text) + Convert.ToDouble(Txt3.Text) + Convert.ToDouble(Txt4.Text)) / 4);
        }
    }
}
