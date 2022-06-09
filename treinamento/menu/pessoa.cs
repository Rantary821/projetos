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

namespace menu
{
    public partial class pessoa : Form
    {
        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private MySqlDataReader reader;
        private DataSet mDataSet;
        private MySqlCommand cmd;
        int X = 0;
        int Y = 0, id;
        public pessoa()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(pessoa_MouseDown);
            this.MouseMove += new MouseEventHandler(pessoa_MouseMove);
        }
        private void pessoa_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void pessoa_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }
        private void btncancel_Click(object sender, EventArgs e)
        {
            ClearAllText(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            pessoa.ActiveForm.Close();
        }
       void selectId()
        {
            string sql = "SELECT MAX(id) FROM `aluno`";
            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();
            using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
            {
                //"reader = cmd.ExecuteReader();" assim não da certo, precisa do MySqlDataReader antes sempre
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //try-catch para verifica se o valor é nulo
                    try
                    {
                        //depois de pegar o maior numero de Matricula  joga para a variavel contador e soma +1 e depios joga para a variavel
                        id = reader.GetInt16("MAX(id)");
                    }
                    catch (System.Data.SqlTypes.SqlNullValueException ex)
                    {
                        //se for nulo a variavel NumMatricula recebe 0
                        id = 0;
                    }

                }
                reader.Close();
                id++;
            }
        }
        void ClearAllText(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                if (c is RadioButton)
                    ((RadioButton)c).Checked = false;
                if (c is MaskedTextBox)
                    ((MaskedTextBox)c).Clear();
                else
                    ClearAllText(c);
            }
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            selectId();
            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();    
            string sql = "INSERT INTO aluno (id, nome, sobrenome) values ("+id+", '"+txtNome.Text+"', '"+txtSobrenome.Text+"');";
            using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
            {
                cmd.ExecuteNonQuery();
            }
            ClearAllText(this);
        }
    }
}
