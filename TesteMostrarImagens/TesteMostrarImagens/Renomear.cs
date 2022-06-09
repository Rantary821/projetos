using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteMostrarImagens
{
    public partial class Renomear : Form
    {
        public Renomear()
        {
            InitializeComponent();
        }

        private void ImputTextBox_Load(object sender, EventArgs e)
        {
            textBox1.Text = Path.GetFileNameWithoutExtension(Program.ImputTextPath);
            textBox2.Text = Path.GetFileNameWithoutExtension(Program.ImputTextPath);
            textBox2.SelectAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox2.Text.ToLower() != null && textBox2.Text.Length <= 16 && textBox1.Text.ToLower() != textBox2.Text.ToLower())
            {
                Program.newname = textBox2.Text.ToLower();
                this.Close();
            }
            
            if(textBox2.Text.Length > 16 && textBox1.Text != textBox2.Text)
            {
                ApelMessageBox("O nome do arquivo deve possuir no maximo 16 caracteres para um bom funcionamento, salvar mesmo assim?;Limite de caracteres!!;", "btn1; btn2;", "Sim; Não;", "A");
                if(Program.MBResposta.Contains("Sim"))
                {
                    Program.newname = textBox2.Text.ToLower();
                    this.Close();
                }
                else
                {
                    textBox2.Focus();
                    textBox2.SelectAll();                    
                }
            }
            else
            if(textBox1.Text.ToLower() == textBox2.Text.ToLower())
            {
                ApelMessageBox("Informe um novo nome diferente para o arquivo!; Nome Invalido!;", "btn2;", "Ok;", "A");
                textBox2.Focus();
                textBox2.SelectAll();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Program.newname = "Apel.cancel";
            this.Close();
        }

        void ApelMessageBox(string TextORTittle, string buttons, string buttonsText, string Ico)
        {
            //Exemplo de um chamada com todas as possibilidades:
            //ApelMessageBox("Texto;Titulo;", "Btn1; Btn2; Btn3; BtnClose; btnCheck;", "Sim; Não; Cancel; Fazer isso para todos?;", "Alert";

            Program.MBLabels = TextORTittle;     //Texto;Titulo;                                - (Texto; - Apenas texto) (;Titulo; - Apenas Titulo)
            Program.MBButtons = buttons;         //Btn1; Btn2; Btn3; btnCheck; BtnClose;        - (Retirar botões indesejados - ex: btn1; btnClose; - ex: btnclose
            Program.MBButtonsText = buttonsText; //Sim; Não; Cancel; Fazer isso para todos?;    - (Colocar os texto dos botões na mesma ordem dos respectivos botões
            Program.MBIco = Ico;                 //Alert Check Error Quest

            MessageBoxApel Apel = new MessageBoxApel();
            Apel.ShowDialog();
        }
    }
}
