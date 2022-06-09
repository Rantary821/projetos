using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication2
{
    public partial class Login : Form
    {
        string verifica;
        int tentativas;
        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private MySqlDataReader reader, reader1, reader2;
        private DataSet mDataSet;
        private MySqlCommand cmd, cmd1, cmd2;

        public Login()
        {
            InitializeComponent();
            BtnCadUser.FlatAppearance.BorderSize = 0;
        }

        private void TxtSenha_MouseClick(object sender, MouseEventArgs e)
        {
            TxtSenha.Text = "";
            TxtSenha.PasswordChar = '*';
            TxtSenha.ForeColor = Color.Black;
        }

        private void TxtUsuario_MouseClick(object sender, MouseEventArgs e)
        {
            if(TxtUsuario.Text == "Usuario")
            {
                TxtUsuario.Text = "";
            }
            TxtUsuario.ForeColor = Color.Black;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtUsuario_Leave(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "")
            {
                TxtUsuario.ForeColor = Color.DarkGray;
                TxtUsuario.Text = "Usuario";
            }
        }

        private void TxtSenha_Leave(object sender, EventArgs e)
        {
            if (TxtSenha.Text == "")
            {
                TxtSenha.ForeColor = Color.DarkGray;
                TxtSenha.PasswordChar = '\0';
                TxtSenha.Text = "Senha";
            }
        }

        private void TxtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void TxtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void TxtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BtnLogin_Click(sender, e);
            }
        }

        private void TxtSenha_Enter(object sender, EventArgs e)
        {
            TxtSenha.Text = "";
            TxtSenha.PasswordChar = '*';
            TxtSenha.ForeColor = Color.Black;
        }

        private void BtnCadUser_Click(object sender, EventArgs e)
        {
            if(TxtSenha.Text == "a" && TxtUsuario.Text == "a")
            {
                lblPassWrong.Visible = false;
                TxtUsuario.Text = "Usuario";
                TxtUsuario.ForeColor = Color.DarkGray;
                TxtSenha.Text = "Senha";
                TxtSenha.ForeColor = Color.DarkGray;
                CadUsuario cad = new CadUsuario();
                this.Visible = false;
                cad.ShowDialog();
                this.Visible = true;
            }
            else
             if (TxtSenha.Text == "Senha" || TxtUsuario.Text == "Usuario")
            {
                lblPassWrong.Visible = true;
                lblPassWrong.Text = "Digite o login do administrador!";
                TxtUsuario.Focus();
            }
            else
            {
                if (TxtSenha.Text != "123" || TxtUsuario.Text != "otavio")
                {
                    lblPassWrong.Visible = true;
                    lblPassWrong.Text = "Usuario ou senha incorretos!";
                    TxtUsuario.Focus();
                }            
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            verifica = "nao";
            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();
            string sql = "SELECT * FROM `login` WHERE Usuario LIKE @user and Senha like @Pass;";
            using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
            {
                cmd.Parameters.AddWithValue("@User", TxtUsuario.Text);
                cmd.Parameters.AddWithValue("@Pass", TxtSenha.Text);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Program.IdUsuario = reader.GetInt16("IdUser");
                    verifica = "sim";
                }
                reader.Close();
            }
            if (verifica == "sim")
            {              
                menuPrincipal menu = new menuPrincipal();
                TxtSenha.Text = "Senha";
                TxtSenha.ForeColor = Color.DarkGray;
                TxtUsuario.Text = "Usuario";
                TxtUsuario.ForeColor = Color.DarkGray;
                this.Visible = false;
                lblPassWrong.Visible = false;     
                menu.ShowDialog();
                this.Visible = true;
            }
            if (verifica == "nao")
            {
                lblPassWrong.Visible = true;
                lblPassWrong.Text = "Usuario ou senha incorretos!";
                TxtUsuario.Text = "";
                TxtSenha.Text = "";         
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "")
            {
                TxtUsuario.ForeColor = Color.Black;
            }
            if (TxtUsuario.Text != "Usuario")
            {
                TxtUsuario.ForeColor = Color.Black;
            }
        }
    }
}
