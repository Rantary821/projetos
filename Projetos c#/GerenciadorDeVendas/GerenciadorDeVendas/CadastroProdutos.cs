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
    public partial class CadastroProdutos : Form
    {
        int codB;
        string precoC;
        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private MySqlDataReader reader, reader1, reader2;
        private DataSet mDataSet;
        private MySqlCommand cmd, cmd1, cmd2;

        public CadastroProdutos()
        {
            InitializeComponent();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CadastroProdutos_KeyDown(object sender, KeyEventArgs e)
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

        private void TxtPrecoVenda_TextChanged(object sender, EventArgs e)
        {
     
        }

        private void TxtPrecoCusto_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPrecoVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (TxtPrecoVenda.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void TxtPrecoCusto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (TxtPrecoCusto.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CadastroProdutos_Load(object sender, EventArgs e)
        {
            BtnClose.FlatAppearance.BorderSize = 0;
            BtnCad.FlatAppearance.BorderSize = 0;
            BtnCancel.FlatAppearance.BorderSize = 0;

            try
            {
                mConn = new MySqlConnection(Program.conexao);
                mConn.Open();
                string sql = "SELECT Max(CodigoBusca) FROM `produtos`;";
                using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
                {
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        codB = reader.GetInt16("Max(CodigoBusca)");
                        codB = codB + 1;
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                codB = 1;
            }
            TxtCodBusca.Text = Convert.ToString(codB);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCad_Click(object sender, EventArgs e)
        {
            if(TxtCodBusca.Text != "" && TxtNome.Text != "" && TxtPrecoVenda.Text != "")
            {
                string precoV = (Convert.ToDouble(TxtPrecoVenda.Text)).ToString("N2");
                if(TxtPrecoCusto.Text == "")
                {
                    precoC = "0";
                }
                else
                {
                    precoC = (Convert.ToDouble(TxtPrecoCusto.Text)).ToString("N2");
                }

                mConn = new MySqlConnection(Program.conexao);
                mConn.Open();
                
                string sql = "INSERT INTO  produtos (NomeProduto, Categoria, Observacoes, Fornecedor, PrecoCusto, PrecoVenda, UniDeVenda, CodigoBusca) VALUES (@Nome, @Categoria, @Observações, @Fornecedor, @PrecoCusto, @PrecoVenda, @UniDeVenda, @CodigoBusca);";
                using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
                {
                    cmd.Parameters.AddWithValue("@Nome", TxtNome.Text);
                    cmd.Parameters.AddWithValue("@Categoria", TxtCategoria.Text);
                    cmd.Parameters.AddWithValue("@Observações", TxtObservs.Text);
                    cmd.Parameters.AddWithValue("@Fornecedor", TxtFornecedor.Text);
                    cmd.Parameters.AddWithValue("@PrecoCusto", precoC);
                    cmd.Parameters.AddWithValue("@PrecoVenda", precoV);
                    cmd.Parameters.AddWithValue("@UniDeVenda", TxtUniVenda.Text);
                    cmd.Parameters.AddWithValue("@CodigoBusca", TxtCodBusca.Text);
                    cmd.ExecuteNonQuery();
                }
                ClearAllText(this);
                MessageBox.Show("Cadastro Concluido!");
            }      

            else
                if (TxtNome.Text == "")
            {
                MessageBox.Show("Preencha o Nome do Produto!");
            }
            else
                if (TxtPrecoVenda.Text == "")
            {
                MessageBox.Show("Preencha o Preço de Venda!");
            }
            CadastroProdutos_Load(sender, e);
        }
    }
}
