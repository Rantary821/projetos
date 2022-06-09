using System;
using System.Text.RegularExpressions;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO.Compression;


namespace ValidaCPF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnConver_Click(object sender, EventArgs e)
        {
            string cpf = TxtCpf.Text, ValCpf = "";

            cpf = String.Concat(cpf.Where(Char.IsDigit)); //Concatena apenas os digitos para tirar a mascara
          
            if (cpf.Length == 11 && cpf.Distinct().Count() != 1) //varifica se o tamanho é igual a 11 digitos, verifica se possui todos os digitos iguais 
            {
                int Sum = 0, Mult = 0, Dig1 = 0, Dig2 = 0;

                Mult = 10; //Primeira multiplicação é feita por 10

                for (int i = 0; i < 9; i++)//Validação do primeiro digito
                {
                    ValCpf += cpf[i].ToString();

                    //Cada um dos primeiros 9 caracteres são multiplicados, o primeiro caracter por 10, o segundo por 9, terceiro por 8, etc.
                    Sum += (Convert.ToInt32(cpf[i].ToString()) * Mult);

                    Mult--;
                }

                if (((Sum * 10) % 11) > 9)//Caso o resultado da operação sejá maior q 9, obrigatoriamente o digito recebe valor 0
                {
                    Dig1 = 0;
                }
                else//caso seja menor q 9, o digito recebe o proprio resultado da operação
                {
                    Dig1 = (Sum * 10) % 11;
                    ValCpf += Dig1;
                }

                bool verify1 = CompararCpf(10, ValCpf, cpf);//Comparãção dos digitos

                if (verify1)//Caso a primeira comparação resulte em true 
                {
                    Mult = 11;
                    ValCpf = "";
                    Sum = 0;

                    for (int i = 0; i < 10; i++)//Validação do segundo digito
                    {
                        ValCpf += cpf[i].ToString();

                        //Cada um dos primeiros 10 caracteres são multiplicados, o primeiro caracter por 11, o segundo por 10, terceiro por 9, etc.
                        Sum += (Convert.ToInt32(cpf[i].ToString()) * Mult);

                        Mult--;
                    }

                    if (((Sum * 10) % 11) > 9)//Caso o resultado for maior q 9 o digito revebe 0
                    {
                        Dig2 = 0;
                    }
                    else
                    {
                        Dig2 = (Sum * 10) % 11;//Caso o resultado for menor o digito recebe o proprio valor da operação
                        ValCpf += Dig2;
                    }

                    bool verify2 = CompararCpf(11, ValCpf, cpf);//Nova comparação dos digitos

                    if (verify2)//Caso a segunda comparação resulte em true 
                    {
                        TxtDigito1.Text = Dig1.ToString();
                        TxtDigito2.Text = Dig2.ToString();
                        TxtValidado.Text = ValCpf;
                    }
                    else//Caso a segunda comparação resulte em false
                    {
                        CpfInvalido();
                    }
                }
                else//Caso a primeira comparação resulte em false
                {
                    CpfInvalido();
                }
            }
            else
            {
                if(cpf.Distinct().Count() == 1)//Caso o cpf possui todos os digitos iguais
                {
                    MessageBox.Show("Cpf não pode ter todos os digitos iguais!");
                }
                if((11 - cpf.Length) != 0)//caso 
                {
                    MessageBox.Show("Faltam = " + (11 - cpf.Length) + " digitos!");
                }
            }
        }

        void CpfInvalido()//Caso o cpf não for valido
        {
            MessageBox.Show("Cpf Invalido!");
            TxtDigito1.Text = "";
            TxtDigito2.Text = "";
            TxtValidado.Text = "";
        }

        public bool CompararCpf(int Tamando, string CpfVal, string CpfOrigin)//Comparação dos digitos do cpf digitado com o cpf validado
        {
            bool V = false;

            for (int i = 0; i < Tamando; i++)
            {
                if (CpfVal[i] == CpfOrigin[i])
                {
                    V = true;//Caso todos os digito forem iguais recebe true
                }
                else
                {
                    V = false;//Caso algum for diferente recebe false
                }
            }

            if(V)//Retorna valor
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
