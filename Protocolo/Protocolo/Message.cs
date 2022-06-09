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

  //Exemplo de como usar o form de messagebox

  /*Program.LblMessage = "Um erro ocorreu!";
    Program.PicInterrog = "0";
    Program.PicAlert = "0";
    Program.PicError = "1";
    Program.PicVendaOK = "0";
    Program.btnNao = "0";
    Program.btnSim = "0";
    Program.btnOk = "1";

    Message message = new Message();
    message.ShowDialog();

      if (Program.MessageResult == "O")
      {
       this.Close();
      }*/ 

    public partial class Message : Form
    {
        public Message()
        {
            InitializeComponent();
            if (Program.btnNao == "1")
            {
                BtnNao.Visible = true;
            }
            if (Program.btnSim == "1")
            {
                BtnSim.Visible = true;
            }
            if (Program.btnOk == "1")
            {
                BtnOk.Visible = true;
            }
            if (Program.PicAlert == "1")
            {
                PictureAlerta.Visible = true;
            }
            if (Program.PicVendaOK == "1")
            {
                PictureVendaOK.Visible = true;
            }
            if (Program.PicError == "1")
            {
                PictureError.Visible = true;
            }
            if (Program.PicInterrog == "1")
            {
                PictureInterrogacao.Visible = true;
            }
            LblMenssagem.Text = Program.LblMessage;
            LblMenssagem.Visible = true;
        }

        private void BtnSim_Click(object sender, EventArgs e)
        {
            Program.MessageResult = "Y";
            this.Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            Program.MessageResult = "O";
            this.Close();
        }

        private void BtnNao_Click(object sender, EventArgs e)
        {
            Program.MessageResult = "N";
            this.Close();
        }
    }
}
