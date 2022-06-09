using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArquivoEtec
{
    public partial class MessageBoxApel : Form
    {
        string BtnEnterKeyDowm = "", BtnEscKeyDowm;

        Utilidades uti = new Utilidades();

        public MessageBoxApel()
        {
            InitializeComponent();
            Cores();
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

                if (Program.MBButtons.ToLower().Contains("btn1*"))
                {
                    BtnEnterKeyDowm = "btn1";
                }

                if (Program.MBButtons.ToLower().Contains("btn1'"))
                {
                    BtnEscKeyDowm = "btn1";
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

                if (Program.MBButtons.ToLower().Contains("btn2*"))
                {
                    BtnEnterKeyDowm = "btn2";
                }

                if (Program.MBButtons.ToLower().Contains("btn2'"))
                {
                    BtnEscKeyDowm = "btn2";
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

                if (Program.MBButtons.ToLower().Contains("btn3*"))
                {
                    BtnEnterKeyDowm = "btn3";
                }

                if (Program.MBButtons.ToLower().Contains("btn3'"))
                {
                    BtnEscKeyDowm = "btn3";
                }

                this.Focus();
            }

            if (Program.MBButtons.ToLower().Contains("btnclose"))
            {
                BtnClose.Visible = true;

                if (Program.MBButtons.ToLower().Contains("btnclose*"))
                {
                    BtnEnterKeyDowm = "btnclose";
                }

                if (Program.MBButtons.ToLower().Contains("btnclose'"))
                {
                    BtnEscKeyDowm = "btnclose";
                }
            }

            if (Program.MBButtons.ToLower().Contains("btncheck"))
            {
                CheckBox.Text = find(Program.MBButtonsText);
                CheckBox.Visible = true;
                CheckBox.Checked = false;

                if (CheckBox.Visible)
                {
                    UnCheckPic.Visible = true;
                }
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
                CheckPic.Visible = true;
                UnCheckPic.Visible = false;
            }
            else
            if(!CheckBox.Checked)
            {
                Program.MBChecked = "";
                CheckPic.Visible = false;
                UnCheckPic.Visible = true;
            }
        }

        void Cores()//Preenchimento das cores do tema
        {
            Utilidades.ChangeColorsForm = "MessageBoxApel";
            uti.ChangeColors(this);

            LblTitle.ForeColor = Utilidades.ForeTitulo;
            LblTitle.BackColor = Utilidades.BackTitulo;
            BtnClose.BackColor = Utilidades.BackTitulo;
            PicLogo.BackColor = Utilidades.BackTitulo;
            CheckBox.ForeColor = Utilidades.ForeLbl;
            CheckBox.FlatAppearance.CheckedBackColor = Utilidades.BackForm;
            CheckBox.FlatAppearance.MouseOverBackColor = Utilidades.BackForm;
            CheckBox.FlatAppearance.MouseDownBackColor = Utilidades.BackForm;
            this.BackColor = Utilidades.BackForm;
        }

        private void BtnClose_MouseEnter(object sender, EventArgs e)
        {
            BtnClose.BackColor = Utilidades.BtnCloseEnter;
        }

        private void MessageBoxApel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (BtnEnterKeyDowm == "btn1")
                {
                    Btn1_Click(sender, e);
                }
                else
                if (BtnEnterKeyDowm == "btn2")
                {
                    Btn2_Click(sender, e);
                }
                else
                if (BtnEnterKeyDowm == "btn3")
                {
                    Btn3_Click(sender, e);
                }
                else
                if (BtnEnterKeyDowm == "btnclose")
                {
                    BtnClose_Click(sender, e);
                }
            }

            if (e.KeyCode == Keys.Escape)
            {
                if (BtnEscKeyDowm == "btn1")
                {
                    Btn1_Click(sender, e);
                }
                else
                if (BtnEscKeyDowm == "btn2")
                {
                    Btn2_Click(sender, e);
                }
                else
                if (BtnEscKeyDowm == "btn3")
                {
                    Btn3_Click(sender, e);
                }
                else
                if (BtnEscKeyDowm == "btnclose")
                {
                    BtnClose_Click(sender, e);
                }
            }
        }

        private void BtnClose_MouseLeave(object sender, EventArgs e)
        {
            BtnClose.BackColor = Utilidades.BackTitulo;
        }
    }
}
