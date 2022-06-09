using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteMostrarImagens
{
    public partial class MessageBoxApel : Form
    {
        public MessageBoxApel()
        {
            InitializeComponent();
        }


        private string find(string Frases)
        {
            string verify = "";
            bool check = false;

            do
            {
                if (Program.index < Frases.Length)
                {
                    if (Frases[Program.index].ToString() != ";")
                    {
                        verify += Frases[Program.index].ToString();
                        Program.index++;
                    }
                    else
                    {
                        check = true;
                    }
                }
                else
                {
                    check = true;
                }
            }
            while (check == false);

            Program.index++;

            return verify;
        }

        private void MessageBoxApel_Load(object sender, EventArgs e)
        {
            PicAlert.Visible = false;
            PicCheck.Visible = false;
            PicError.Visible = false;
            PicQuest.Visible = false;

            int c = 0;
            string ButtonFirst = "", ButtonSecond = "";

            //Caso esteja faltando o ";" no final quando declarado
            if (Program.MBButtonsText[Program.MBButtonsText.Length-1].ToString() != ";")
            {
                Program.MBButtonsText += ";";
            }

            if (Program.MBLabels[Program.MBLabels.Length - 1].ToString() != ";")
            {
                Program.MBLabels += ";";
            }

            LblTexto.Text = find(Program.MBLabels);
            LblTitle.Text = find(Program.MBLabels);
            Program.index = 0;


            if (Program.MBButtons.ToLower().Contains("btn1"))
            {
                Btn1.Text = find(Program.MBButtonsText);
                Btn1.Visible = true;

                if(c == 0)
                {
                    ButtonFirst = "btn1";
                    c++;
                }
                else
                if(c == 1)
                {
                    ButtonSecond = "btn1";
                    c++;
                }
                else
                {
                    c++;
                }
            }

            if (Program.MBButtons.ToLower().Contains("btn2"))
            {
                Btn2.Text = find(Program.MBButtonsText);
                Btn2.Visible = true;

                if (c == 0)
                {
                    ButtonFirst = "btn2";
                    c++;
                }
                else
                if (c == 1)
                {
                    ButtonSecond = "btn2";
                    c++;
                }
                else
                {
                    c++;
                }
            }

            if (Program.MBButtons.ToLower().Contains("btn3"))
            {
                Btn3.Text = find(Program.MBButtonsText);
                Btn3.Visible = true;

                if (c == 0)
                {
                    ButtonFirst = "btn3";
                    c++;
                }
                else
                if(c == 1)
                {
                    ButtonSecond = "btn3";
                    c++;
                }
                else
                {
                    c++;
                }
            }

            if (Program.MBButtons.ToLower().Contains("btnclose"))
            {
                btnClose.Visible = true;
            }

            if (Program.MBButtons.ToLower().Contains("btncheck"))
            {
                CheckBox.Text = find(Program.MBButtonsText);
                CheckBox.Visible = true;
                CheckBox.Checked = false;
            }

            ///////////////////////escolhe o icone/////////////////Alert   Check   Error   Quest            
            if (Program.MBIco.ToUpper()[0].ToString() == "A")
            { 
                PicAlert.Visible = true;
            }
            else
            if (Program.MBIco.ToUpper()[0].ToString() == "C")
            {
                PicCheck.Visible = true;
            }
            else
            if (Program.MBIco.ToUpper()[0].ToString() == "E")
            {
                PicError.Visible = true;
            }
            else
            if (Program.MBIco.ToUpper()[0].ToString()  == "Q")
            {
                PicQuest.Visible = true;
            }


            Program.index = 0;

            if(c == 2)//Esqueda - 210; 168   Direit - 335; 168
            {
                if (ButtonFirst == "btn1" && ButtonSecond == "btn2")
                {
                    Btn1.Location = new Point(210, 168);
                    Btn2.Location = new Point(335, 168);
                }
                else
                if (ButtonFirst == "btn1" && ButtonSecond == "btn3")
                {
                    Btn1.Location = new Point(210, 168);
                    Btn3.Location = new Point(335, 168);
                }
                else
                if (ButtonFirst == "btn2" && ButtonSecond == "btn3")
                {
                    Btn2.Location = new Point(210, 168);
                    Btn3.Location = new Point(335, 168);
                }
            }
            c = 0;
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            Program.MBResposta = Btn1.Text;
            this.Close();
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            Program.MBResposta = Btn2.Text;
            this.Close();
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            Program.MBResposta = Btn3.Text;
            this.Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Program.MBResposta = "Close";
            this.Close();
        }


        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(CheckBox.Checked)
            {
                Program.MBChecked = "Checked";
            }
            else
            if(CheckBox.Checked)
            {
                Program.MBChecked = "";
            }
        }
    }
}
