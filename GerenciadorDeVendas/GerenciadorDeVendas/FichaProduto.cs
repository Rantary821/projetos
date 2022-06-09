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
    public partial class FichaProduto : Form
    {
        string nome, obs, categoria, fornece, precoC, precoV, Uni;

        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private MySqlDataReader reader, reader1, reader2;
        private DataSet mDataSet;
        private MySqlCommand cmd, cmd1, cmd2;

        private void TxtObser_TextChanged(object sender, EventArgs e)
        {
            if (TxtObser.Text != obs)
            {
                BtnAtualizar.Enabled = true;
            }
            if (TxtObser.Text == obs)
            {
                BtnAtualizar.Enabled = false;
            }
        }

        private void TxtCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TxtCategoria.Text != categoria)
            {
                BtnAtualizar.Enabled = true;
            }
            if (TxtCategoria.Text == categoria)
            {
                BtnAtualizar.Enabled = false;
            }
        }

        private void TxtFornecedor_TextChanged(object sender, EventArgs e)
        {
            if (TxtFornecedor.Text != fornece)
            {
                BtnAtualizar.Enabled = true;
            }
            if (TxtFornecedor.Text == fornece)
            {
                BtnAtualizar.Enabled = false;
            }
        }

        private void TxtPrecoCusto_TextChanged(object sender, EventArgs e)
        {
            if (TxtPrecoCusto.Text != precoC)
            {
                BtnAtualizar.Enabled = true;
            }
            if (TxtPrecoCusto.Text == precoC)
            {
                BtnAtualizar.Enabled = false;
            }
        }

        private void TxtUniVenda_TextChanged(object sender, EventArgs e)
        {
            if (TxtUniVenda.Text != Uni)
            {
                BtnAtualizar.Enabled = true;
            }
            if (TxtUniVenda.Text == Uni)
            {
                BtnAtualizar.Enabled = false;
            }
        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {
            if (TxtNome.Text != nome)
            {
                BtnAtualizar.Enabled = true;
            }
            if (TxtNome.Text == nome)
            {
                BtnAtualizar.Enabled = false;
            }
        }

        public FichaProduto()
        {
            InitializeComponent();

            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();
            string sql = "SELECT NomeProduto, Categoria, Observacoes, Fornecedor, PrecoCusto, PrecoVenda, UniDeVenda, CodigoBusca FROM produtos WHERE IdProduto LIKE @Id;";
            using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
            {
                cmd.Parameters.AddWithValue("@Id", Program.idprodutoSelec);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    nome = TxtNome.Text = reader.GetString("NomeProduto");
                    categoria = TxtCategoria.Text = reader.GetString("Categoria");
                    fornece = TxtFornecedor.Text = reader.GetString("Fornecedor");
                    precoC = TxtPrecoCusto.Text = reader.GetString("PrecoCusto");
                    precoV = TxtPrecoVenda.Text = reader.GetString("PrecoVenda");
                    Uni = TxtUniVenda.Text = reader.GetString("UniDeVenda");
                    TxtCodBusca.Text = reader.GetString("CodigoBusca");
                    obs = TxtObser.Text = reader.GetString("Observacoes");
                }
                reader.Close();
            }
            BtnAtualizar.Enabled = false;
        }

        private void TxtPrecoVenda_TextChanged(object sender, EventArgs e)
        {
            if (TxtPrecoVenda.Text != precoV)
            {
                BtnAtualizar.Enabled = true;
            }
            if (TxtPrecoVenda.Text == precoV)
            {
                BtnAtualizar.Enabled = false;
            }
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

        private void FichaProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (Program.venceu != "s")
            {
                if (e.KeyCode == Keys.F1)
                {
                    BtnAtualizar_Click(sender, e);
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

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            BtnAtualizar.Enabled = false;

            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();
            string sql = "UPDATE produtos SET NomeProduto = @Nome ,Categoria = @Cat ,Observacoes = @obs ,Fornecedor = @fornece ,PrecoCusto = @precoC ,PrecoVenda = @precoV ,UniDeVenda = @uni WHERE IdProduto = @ID;";
            using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
            {
                cmd.Parameters.AddWithValue("@Nome", TxtNome.Text);
                cmd.Parameters.AddWithValue("@Cat", TxtCategoria.Text);
                cmd.Parameters.AddWithValue("@obs", TxtObser.Text);
                cmd.Parameters.AddWithValue("@fornece", TxtFornecedor.Text);
                cmd.Parameters.AddWithValue("@precoC", TxtPrecoCusto.Text);
                cmd.Parameters.AddWithValue("@precoV", TxtPrecoVenda.Text);
                cmd.Parameters.AddWithValue("@uni", TxtUniVenda.Text);
                cmd.Parameters.AddWithValue("@ID", TxtCodBusca.Text);
                cmd.ExecuteNonQuery();
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void FichaProduto_Load(object sender, EventArgs e)
        {
            BtnClose.FlatAppearance.BorderSize = 0;
            BtnAtualizar.FlatAppearance.BorderSize = 0;
            BtnCancel.FlatAppearance.BorderSize = 0;
        }
    }
}
