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

namespace Menu_Principal
{
    public partial class Login : Form
    {
        int i,X,Y;
        string salvaSenha = @"C:\Dropbox\FisoBarretos\login\SaveSenha.txt";
        string LoginDados = @"C:\Dropbox\FisoBarretos\login\User.txt";
        string L = @"C:\Dropbox\FisoBarretos\login\L.txt", lu, su;

        public Login()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(label9_MouseDown);
            this.MouseMove += new MouseEventHandler(label9_MouseMove);
            this.ActiveControl = TxtSenha;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if(File.Exists(salvaSenha))
            {
                string line;
                
                using (StreamReader reader = new StreamReader(salvaSenha))
                {
                    line = reader.ReadLine();
                }

                if (line.ToUpper() == "YES")
                {
                    checkSalvaSenha.Checked = true;

                    using (StreamReader sr = new StreamReader(LoginDados))
                    while ((line = sr.ReadLine()) != null)
                    {
                        if(i == 0)
                        {
                            TxtUsuario.Text = line;
                            i++;
                        }
                        else
                        {
                            TxtSenha.Text = line;
                        }
                    }
                }
            }

            this.ActiveControl = TxtSenha;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            i = 0;
            string line;
            using (StreamReader sr = new StreamReader(L))
            while ((line = sr.ReadLine()) != null)
            {
                if (i == 0)
                {
                     lu = line;
                     i++;
                }
                else
                {
                     su = line;
                }
            }
            if(TxtUsuario.Text == lu && TxtSenha.Text == su)
            {
                if (checkSalvaSenha.Checked)
                {
                    if (File.Exists(LoginDados))
                    {
                        File.Delete(LoginDados);

                        using (StreamWriter sw = File.CreateText(LoginDados))
                        {
                            sw.WriteLine(TxtUsuario.Text, Environment.NewLine);
                            sw.WriteLine(TxtSenha.Text, Environment.NewLine);
                            sw.Dispose();
                        }
                    }
                    else
                    {
                        File.Delete(LoginDados);
                        using (StreamWriter sw = File.CreateText(LoginDados))
                        {
                            sw.WriteLine(TxtUsuario.Text, Environment.NewLine);
                            sw.WriteLine(TxtSenha.Text, Environment.NewLine);
                            sw.Dispose();
                        }
                    }
                }
                else
                {
                    if (File.Exists(LoginDados))
                    {
                        File.Delete(LoginDados);
                    }
                }

                menu mainn = new menu();
                this.Hide();
                mainn.Show();
            }   
        }

        private void label9_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                BtnLogin_Click(sender, e);
            }*/
        }

        private void TxtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
           /* if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                BtnLogin_Click(sender, e);
            }*/
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnLogin_Click(this, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                BtnCancel_Click(sender, e);
            }
        }

        private void checkLoginAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (checkLoginAuto.Checked)
            {
                TxtSenha.PasswordChar = '\0';
            }
            else
            {
                TxtSenha.PasswordChar = '*';
            }

            /*if(checkLoginAuto.Checked)
            {
                if(File.Exists(logAuto))
                {
                    using (StreamWriter sw = File.CreateText(logAuto))
                    {
                        sw.WriteLine("YES");
                        sw.Dispose();
                    }
                }
                else
                {
                    using (StreamWriter sw = File.CreateText(logAuto))
                    {
                        sw.WriteLine("YES");
                        sw.Dispose();
                    }
                }
            }
            else
            {
                if (File.Exists(logAuto))
                {
                    File.Delete(logAuto);
                }
            }*/
        }

        private void label9_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void checkSalvaSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSalvaSenha.Checked)
            {
                if (File.Exists(salvaSenha))
                {
                    using (StreamWriter sw = File.CreateText(salvaSenha))
                    {
                        sw.WriteLine("YES");
                        sw.Dispose();
                    }
                }
                else
                {
                    using (StreamWriter sw = File.CreateText(salvaSenha))
                    {
                        sw.WriteLine("YES");
                        sw.Dispose();
                    }
                }
            }
            else
            {
                if (File.Exists(salvaSenha))
                {
                    File.Delete(salvaSenha);
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
