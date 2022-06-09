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

namespace GerenciadorDeVendas
{
    public partial class CadClientes : Form
    {
        int id;
        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private MySqlDataReader reader, reader1, reader2;
        private DataSet mDataSet;
        private MySqlCommand cmd, cmd1, cmd2;


        public CadClientes()
        {
            InitializeComponent();
        }

        private void CadClientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (Program.venceu != "s")
            {
                if (e.KeyCode == Keys.F1)
                {
                    BtnCad_Click(sender, e);
                }
                if (e.KeyCode == Keys.F2)
                {
                    BtnCancel_Click(sender, e);
                }   
            }
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCad_Click(object sender, EventArgs e)
        {
            
            if(TxtNome.Text != "" && (TxtTelefone.Text != "(00)0000-0000" || TxtCelular.Text != "(00)0000-00000"))
            {
                mConn = new MySqlConnection(Program.conexao);
                mConn.Open();
                
                string sql = "INSERT INTO clientes (Nome, Cpf, Rg, Nascimento, Sexo, Bairro, Rua, Numero, Referencia, Telefone, Celular) VALUES (@Nome, @Cpf, @Rg, @Nasc, @Sexo, @bairro, @Rua, @Numero, @Refen, @Tel, @Cel);";
                using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
                {
                    cmd.Parameters.AddWithValue("@Nome", TxtNome.Text);
                    cmd.Parameters.AddWithValue("@Cpf", TxtCpf.Text);
                    cmd.Parameters.AddWithValue("@Rg", TxtRg.Text);
                    cmd.Parameters.AddWithValue("@Nasc", TxtNascimento.Text);
                    cmd.Parameters.AddWithValue("@Sexo", TxtSexo.Text);
                    cmd.Parameters.AddWithValue("@bairro", TxtBairro.Text);
                    cmd.Parameters.AddWithValue("@Rua", TxtRua.Text);
                    cmd.Parameters.AddWithValue("@Numero", TxtNumero.Text);
                    cmd.Parameters.AddWithValue("@Refen", TxtReferencia.Text);
                    cmd.Parameters.AddWithValue("@Tel", TxtTelefone.Text);
                    cmd.Parameters.AddWithValue("@Cel", TxtCelular.Text);
                    cmd.ExecuteNonQuery();
                }

                sql = "SELECT MAX(IdCliente) FROM clientes;";
                using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
                {
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        id = reader.GetInt16("MAX(IdCliente)");
                    }
                    reader.Close();
                }

                sql = "INSERT INTO dividas (IdCLiente, DividaRestante, TotalGasto) VALUES (@Id, @Divida, @Gasto);";
                using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Divida", 0);
                    cmd.Parameters.AddWithValue("@Gasto", 0);
                    cmd.ExecuteNonQuery();
                }

                ClearAllText(this);
                TxtTelefone.Text = "(00)0000-0000";
                TxtCelular.Text = "(00)0000-00000";
                TxtSexo.SelectedIndex = -1;
                MessageBox.Show("Cadastro Concluido!");
            }
            else
            if(TxtNome.Text == "")
            {
                MessageBox.Show("Preencha o Nome!");
            }
            else
            if (TxtTelefone.Text == "(00)0000-0000" || TxtCelular.Text == "(00)0000-00000")
            {
                MessageBox.Show("Preencha o telefone ou celular!");
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

        private void CadClientes_Load(object sender, EventArgs e)
        {
            BtnClose.FlatAppearance.BorderSize = 0;
            BtnCad.FlatAppearance.BorderSize = 0;
            BtnCancel.FlatAppearance.BorderSize = 0;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
