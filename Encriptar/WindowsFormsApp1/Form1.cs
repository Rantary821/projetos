using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string Converter(string Valor)
        {
            string[] ValorConvertido = new string[Valor.Length];
            string[] SenhaConvertida = new string[Valor.Length];

            Valor = Valor.Replace(" ", "#");
            Valor = Valor.RemoverAcentos();

            string line = "";
            int countVal = 0;

            // conversão dos valores da palavra/frase/texto
            var assm2 = Assembly.GetExecutingAssembly();
            using (var stream = assm2.GetManifestResourceStream("WindowsFormsApp1.Resources.teste.txt"))
            {
                using (var reader = new StreamReader(stream))
                {
                    while (((line = reader.ReadLine()) != null) && countVal < Valor.Length)
                    {
                        if (countVal < Valor.Length)
                        {
                            for (int i = 0; i < Valor.Length; i++)
                            {
                                if (Valor[i] == line[0])
                                {
                                    ValorConvertido[i] = line[2].ToString() + line[3].ToString() + line[4].ToString();
                                    countVal++;
                                }
                            }
                        }
                    }
                }
            }

            countVal = 0;
            line = "";
            int count = 0;
            // conversão dos valores da senha

            if (Valor.Length < Program.senha.Length)//precisa usar sempre o menor primeiro
            {
                count = Valor.Length;
            }
            else
            {
                count = Program.senha.Length;
            }

            var assm = Assembly.GetExecutingAssembly();
            using (var stream = assm.GetManifestResourceStream("WindowsFormsApp1.Resources.teste.txt"))
            {
                using (var reader = new StreamReader(stream))
                {
                    while (((line = reader.ReadLine()) != null) && countVal < count)
                    {
                        if (countVal < count)
                        {
                            for (int i = 0; i < count; i++)
                            {
                                if (Program.senha[i] == line[0])
                                {
                                    SenhaConvertida[i] = line[2].ToString() + line[3].ToString() + line[4].ToString();
                                    countVal++;
                                }
                            }
                        }
                    }
                }
            }

            if(countVal < Valor.Length)//Se a senha for menor do q o valor a ser convertido precisa terminar de preencher o array da senha
            {
                int i = 0;

                do
                {
                    SenhaConvertida[countVal] = SenhaConvertida[i];
                    countVal++;
                    i++;
                }
                while (countVal < Valor.Length);
            }

            string res = Encriptar(SenhaConvertida, ValorConvertido, Valor.Length);

            line = "";
            countVal = 0;
            Program.senha = "";

            return res;
        }

        private string Encriptar(string[] Senha, string[] Valor, int lenght)
        {
            string Resultado = "";

            for(int i = 0; i < lenght; i++)
            {
                Resultado += (Convert.ToInt32(Senha[i]) + Convert.ToInt32(Valor[i])) * 2;
            }

            return Resultado;
        }

        private string Desencriptar(string Valor)
        {
            int countVal = 0, count = 0, val = Valor.Length / 3, b = 0;
            string line = "", ConstVal = "";

            string[] ValorConvertido = new string[val];
            string[] SenhaConvertida = new string[val];

            string[] Result = new string[val];

            for (int i = 0; i < val; i++)
            {
                ConstVal += Valor[b];
                b++;
                ConstVal += Valor[b];
                b++;
                ConstVal += Valor[b];
                b++;

                ValorConvertido[i] = ConstVal;
                ConstVal = "";
            }

            // conversão dos valores da senha
            if (val < Program.senha.Length)
            {
                count = val;
            }
            else
            {
                count = Program.senha.Length;
            }

            var assm = Assembly.GetExecutingAssembly();
            using (var stream = assm.GetManifestResourceStream("WindowsFormsApp1.Resources.teste.txt"))
            {
                using (var reader = new StreamReader(stream))
                {
                    while (((line = reader.ReadLine()) != null) && countVal < count)
                    {
                        if (countVal < count)
                        {
                            for (int i = 0; i < count; i++)
                            {
                                if (Program.senha[i] == line[0])
                                {
                                    SenhaConvertida[i] = line[2].ToString() + line[3].ToString() + line[4].ToString();
                                    countVal++;
                                }
                            }
                        }
                    }
                }
            }

            if (countVal < val)
            {
                int i = 0;

                do
                {
                    SenhaConvertida[countVal] = SenhaConvertida[i];
                    countVal++;
                    i++;
                }
                while (countVal < val);
            }

            
            for(int i = 0; i < val; i++)
            {
                Result[i] = ((Convert.ToInt32(ValorConvertido[i]) / 2) - Convert.ToInt32(SenhaConvertida[i])).ToString();
            }

            countVal = 0;
            count = 0;
            line = "";

            string[] FinalConversion = new string[val];

            var assm2 = Assembly.GetExecutingAssembly();
            using (var stream = assm2.GetManifestResourceStream("WindowsFormsApp1.Resources.teste.txt"))
            {
                using (var reader = new StreamReader(stream))
                {
                    while (((line = reader.ReadLine()) != null) && countVal < val)
                    {
                        for (int i = 0; i < val; i++)
                        {
                            string veryLine = line[2].ToString() + line[3].ToString() + line[4].ToString();

                            if (Result[i] == veryLine)
                            {
                                FinalConversion[i] = line[0].ToString();
                                countVal++;
                            }
                        }
                    }
                }
            }

            string FinalResult = "";

            for(int i = 0; i < val; i++)
            {
                FinalResult += FinalConversion[i];
            }

            FinalResult = FinalResult.Replace("#", " ");

            return FinalResult;
        }

        private void btnEncript_Click(object sender, EventArgs e)
        {
           // txtSenha.Enabled = false;

            Program.senha = txtSenha.Text;

            string res = Converter(txtPalavra.Text);

            txtEncript.Text = res;
        }

        private void btnDesencript_Click(object sender, EventArgs e)
        {
            Program.senha = txtSenha.Text;

            txtDesencipt.Text = Desencriptar(txtEncript.Text);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtDesencipt.Text = "";
            txtEncript.Text = "";
            txtPalavra.Text = "";
            txtSenha.Text = "";

            txtSenha.Enabled = true;
        }
    }
}
