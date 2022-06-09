using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        string val, first, operador, valOP;
        int countOp, countNum;
        decimal opera;
        string Click;
        string text;

        public Form1()
        {
            InitializeComponent();
        }

        void Inserir (Control con)
        {
            TxtNumero.Text = TxtNumero.Text + val;
        }

        void foco (Control con)
        {
            TxtNumero.Focus();
            TxtNumero.Select(TxtNumero.Text.Length, 0);
        }

        void operacao (Control con)
        {
            if(operador == "+")
            {
                opera = Convert.ToDecimal(TxtNumero.Text) + Convert.ToDecimal(valOP);
                TxtNumero.Text = Convert.ToString(opera);
            }
            if (operador == "-")
            {
                opera = Convert.ToDecimal(valOP) - Convert.ToDecimal(TxtNumero.Text);
                TxtNumero.Text = Convert.ToString(opera);
            }
            if (operador == "x")
            {
                opera = Convert.ToDecimal(valOP) * Convert.ToDecimal(TxtNumero.Text);
                TxtNumero.Text = Convert.ToString(opera);
            }
            if (operador == "/")
            {
                if(TxtNumero.Text == "0")
                {
                    TxtNumero.Text = "Impossivel dividir por zero";
                    TxtOperacao.Text = "";
                }
                else
                {
                    opera = Convert.ToDecimal(valOP) / Convert.ToDecimal(TxtNumero.Text);
                    TxtNumero.Text = Convert.ToString(opera);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BtnMini.FlatAppearance.BorderSize = 0;
            BtnClose.FlatAppearance.BorderSize = 0;
            BtnMais.FlatAppearance.BorderSize = 0;
            BtnMenos.FlatAppearance.BorderSize = 0;
            BtnDivide.FlatAppearance.BorderSize = 0;
            BtnMult.FlatAppearance.BorderSize = 0;
            BtnDelete.FlatAppearance.BorderSize = 0;
            BtnDeleteAll.FlatAppearance.BorderSize = 0;
            BtnApaga.FlatAppearance.BorderSize = 0;
            BtnPonto.FlatAppearance.BorderSize = 0;
            BtnIgual.FlatAppearance.BorderSize = 0;
            Btn0.FlatAppearance.BorderSize = 0;
            Btn1.FlatAppearance.BorderSize = 0;
            Btn2.FlatAppearance.BorderSize = 0;
            Btn3.FlatAppearance.BorderSize = 0;
            Btn4.FlatAppearance.BorderSize = 0;
            Btn5.FlatAppearance.BorderSize = 0;
            Btn6.FlatAppearance.BorderSize = 0;
            Btn7.FlatAppearance.BorderSize = 0;
            Btn8.FlatAppearance.BorderSize = 0;
            Btn9.FlatAppearance.BorderSize = 0;
            this.Focus();
        }
       

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if(countNum != 0)
            {
                TxtNumero.Text = "";
                countNum = 0;
            }
            val = "1";
            Inserir(this);
            foco(this);
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (countNum != 0)
            {
                TxtNumero.Text = "";
                countNum = 0;
            }
            val = "2";
            Inserir(this);
            foco(this);
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (countNum != 0)
            {
                TxtNumero.Text = "";
                countNum = 0;
            }
            val = "3";
            Inserir(this);
            foco(this);
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (countNum != 0)
            {
                TxtNumero.Text = "";
                countNum = 0;
            }
            val = "4";
            Inserir(this);
            foco(this);
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (countNum != 0)
            {
                TxtNumero.Text = "";
                countNum = 0;
            }
            val = "5";
            Inserir(this);
            foco(this);
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (countNum != 0)
            {
                TxtNumero.Text = "";
                countNum = 0;
            }
            val = "6";
            Inserir(this);
            foco(this);
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (countNum != 0)
            {
                TxtNumero.Text = "";
                countNum = 0;
            }
            val = "7";
            Inserir(this);
            foco(this);
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (countNum != 0)
            {
                TxtNumero.Text = "";
                countNum = 0;
            }
            val = "8";
            Inserir(this);
            foco(this);
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (countNum != 0)
            {
                TxtNumero.Text = "";
                countNum = 0;
            }
            val = "9";
            Inserir(this);
            foco(this);
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            if (countNum != 0)
            {
                TxtNumero.Text = "";
                countNum = 0;
            }
            val = "0";
            Inserir(this);
            foco(this);
        }

        private void BtnApaga_Click(object sender, EventArgs e)
        {
            if(TxtNumero.Text != "")
            {
                string num;
                num = TxtNumero.Text;
                num = num.Remove(num.Length - 1);
                TxtNumero.Text = num;
                foco(this);
            }      
        }

        private void BtnDeleteAll_Click(object sender, EventArgs e)
        {
            foco(this);
            TxtOperacao.Text = "";
            TxtNumero.Text = "";
            foco(this);
            countNum = 1;
            valOP = "0";
            countOp = 0;
            operador = "";
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            foco(this);
            TxtNumero.Text = "";
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            if (TxtNumero.Text != "")
            {
                string val = TxtNumero.Text;
                if (countOp != 0)
                {
                    if (Click != "Y")
                    {
                        operacao(this);
                        countOp = 0;
                    }
                    if (Click == "Y")
                    {
                        string op = TxtOperacao.Text;
                        op = op.Remove(op.Length - 1);
                        TxtOperacao.Text = op + "÷";
                    }
                }

                if (countOp == 0)
                {
                    countOp++;
                    countNum++;
                    TxtOperacao.Text = TxtOperacao.Text + " " + val + " " + "÷";
                    valOP = TxtNumero.Text;
                }
                operador = "/";
                Click = "Y";
            }
            foco(this);
        }

        private void BtnMult_Click(object sender, EventArgs e)
        {
            if (TxtNumero.Text != "")
            {
                string val = TxtNumero.Text;
                if (countOp != 0)
                {
                    if (Click != "Y")
                    {
                        operacao(this);
                        countOp = 0;
                    }
                    if (Click == "Y")
                    {
                        string op = TxtOperacao.Text;
                        op = op.Remove(op.Length - 1);
                        TxtOperacao.Text = op + "x";
                    }
                }

                if (countOp == 0)
                {
                    countOp++;
                    countNum++;
                    TxtOperacao.Text = TxtOperacao.Text + " " + val + " " + "x";
                    valOP = TxtNumero.Text;
                }
                operador = "x";
                Click = "Y";
            }
            foco(this);
        }

        private void TxtNumero_TextChanged(object sender, EventArgs e)
        {
            if(TxtNumero.Text == "Impossivel dividir por zero")
            {
                TxtNumero.Font = new Font(TxtNumero.Font.Name, 14);
                TxtNumero.TextAlign = HorizontalAlignment.Center;
                TxtOperacao.Text = "";
                foco(this);
                countNum = 1;
                valOP = "0";
                countOp = 0;
                operador = "";
            }
            else
            {
                TxtNumero.Font = new Font(TxtNumero.Font.Name, 33);
                TxtNumero.TextAlign = HorizontalAlignment.Right;
            }

            if(Click == "Y")
            {
                Click = "";
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.D0)
            {
                Btn0.PerformClick();
            }
            else
            if (e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1)
            {
                Btn1_Click(sender, e);
            }
            else
            if (e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D3)
            {
                Btn2_Click(sender, e);
            }
            else
            if (e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3)
            {
                Btn3_Click(sender, e);
            }
            else
            if (e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4)
            {
                Btn4_Click(sender, e);
            }
            else
            if (e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D5)
            {
                Btn5_Click(sender, e);
            }
            else
            if (e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.D6)
            {
                Btn6_Click(sender, e);
            }
            else
            if (e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.D7)
            {
                Btn7_Click(sender, e);
            }
            else
            if (e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.D8)
            {
                Btn8_Click(sender, e);
            }
            else
            if (e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.D9)
            {
                Btn9_Click(sender, e);
            }
            else
            if (e.KeyCode == Keys.Add)
            {
                BtnMais_Click(sender, e);
            }
            else 
            if (e.KeyCode == Keys.Divide)
            {
                BtnDivide_Click(sender, e);
            }
            else 
            if (e.KeyCode == Keys.Multiply)
            {
                BtnMult_Click(sender, e);
            }        
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "=":
                    BtnIgual_Click(sender, e);
                    break;

                default:
                    break;
            }

            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (TxtNumero.Text.Contains(","))
                    e.Handled = true; // Caso exista, aborte 

            }
            //aceita apenas números, tecla backspace e virgula.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                if (TxtNumero.Text == "Impossivel dividir por zero")
                {
                    TxtNumero.Text = "";
                }
                e.Handled = true;
            }

            if (e.KeyChar == ',')
            {
                BtnPonto_Click(sender, e);
            }
            else
            if (e.KeyChar == '-')
            {
                BtnMenos_Click(sender, e);
            }
            else
            if(e.KeyChar == (char)Keys.Back)
            {
                BtnApaga_Click(sender, e);
            }
            if (e.KeyChar == 13)
            {
                BtnIgual_Click(sender, e);
            }
        }

        private void Btn0_KeyDown(object sender, KeyEventArgs e)
        {
            Btn0.BackColor = Color.WhiteSmoke;
        }

        private void BtnMenos_Click(object sender, EventArgs e)
        {
            if (TxtNumero.Text != "")
            {
                string val = TxtNumero.Text;
                if (countOp != 0)
                {
                    if (Click != "Y")
                    {
                        operacao(this);
                        countOp = 0;
                    }
                    if (Click == "Y")
                    {
                        string op = TxtOperacao.Text;
                        op = op.Remove(op.Length - 1);
                        TxtOperacao.Text = op + "-";
                    }
                }

                if (countOp == 0)
                {
                    countOp++;
                    countNum++;
                    TxtOperacao.Text = TxtOperacao.Text + " " + val + " " + "-";
                    valOP = TxtNumero.Text;
                }
                operador = "-";
                Click = "Y";
            }
            foco(this);
        }

        private void BtnMais_Click(object sender, EventArgs e)
        {
            if(TxtNumero.Text != "")
            {
                string val = TxtNumero.Text;
                if (countOp != 0)
                {
                    if (Click != "Y")
                    {
                        operacao(this);
                        countOp = 0;
                    }
                    if (Click == "Y")
                    {
                        string op = TxtOperacao.Text;
                        op = op.Remove(op.Length - 1);
                        TxtOperacao.Text = op + "+";
                    }
                }

                if (countOp == 0)
                {
                    countOp++;
                    countNum++;
                    TxtOperacao.Text = TxtOperacao.Text + " " + val + " " + "+";
                    valOP = TxtNumero.Text;
                }
                operador = "+";
                Click = "Y";
            }
            foco(this);
        }

        private void BtnIgual_Click(object sender, EventArgs e)
        {
            if (operador == "+")
            {
                opera = Convert.ToDecimal(TxtNumero.Text) + Convert.ToDecimal(valOP);
                TxtNumero.Text = Convert.ToString(opera);
            }
            if (operador == "-")
            {
                opera = Convert.ToDecimal(valOP) - Convert.ToDecimal(TxtNumero.Text);
                TxtNumero.Text = Convert.ToString(opera);
            }
            if (operador == "x")
            {
                opera = Convert.ToDecimal(valOP) * Convert.ToDecimal(TxtNumero.Text);
                TxtNumero.Text = Convert.ToString(opera);
            }
            if (operador == "/")
            {
                if (TxtNumero.Text == "0")
                {
                    TxtNumero.Text = "Impossivel dividir por zero";
                    TxtOperacao.Text = "";
                }
                else
                {
                    opera = Convert.ToDecimal(valOP) /  Convert.ToDecimal(TxtNumero.Text);
                    TxtNumero.Text = Convert.ToString(opera);
                }
            }
            if(operador != "")
            {
                TxtOperacao.Text = "";
                foco(this);
                countNum = 1;
                valOP = "0";
                countOp = 0;
                operador = "";
            }
        }

        private void BtnPonto_Click(object sender, EventArgs e)
        {
            if(TxtNumero.Text == "")
            {
                TxtNumero.Text = "0";
            }

            if (TxtNumero.Text.Contains(","))
            {
                first = "n";
            }
            else
            {
                first = "y";
            }

            if (first != "n")
            {
                val = ",";
                first = "n";
                Inserir(this);
            }
            foco(this);
        }
    }
}
