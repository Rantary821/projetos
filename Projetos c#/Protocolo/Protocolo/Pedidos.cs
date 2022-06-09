using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Protocolo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.LblMessage = "Deseja Escrever uma Mensagem?";
            Program.PicInterrog = "1";
            Program.PicAlert = "0";
            Program.PicError = "0";
            Program.PicVendaOK = "0";
            Program.btnNao = "1";
            Program.btnSim = "1";
            Program.btnOk = "0";

            Message message = new Message();
            message.ShowDialog();

            if (Program.MessageResult == "Y")
            {
                //form para escrever a mesagem para o aluno
            }
            if (Program.MessageResult == "N")
            {
                //Apenas envia a mensagem padrão
            }
        }
    }
}
