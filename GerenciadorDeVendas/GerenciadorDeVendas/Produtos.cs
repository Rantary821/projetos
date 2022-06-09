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
    
    public partial class Produtos : Form
    {
        string stringPesq = "SELECT  CodigoBusca, NomeProduto, UniDeVenda, PrecoCusto, PrecoVenda , Categoria , Observacoes, Fornecedor FROM produtos WHERE NomeProduto <> 'delete'";

        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private MySqlDataReader reader, reader1, reader2;
        private DataSet mDataSet;
        private MySqlCommand cmd, cmd1, cmd2;

        public Produtos()
        {
            InitializeComponent();
        }

        private void Produtos_KeyDown(object sender, KeyEventArgs e)
        {
            if (Program.venceu != "s")
            {
                if (e.KeyCode == Keys.F1)
                {
                    if (BtnNovoP.Enabled == true)
                    {
                        BtnNovoP_Click(sender, e);
                    }
                }
                if (e.KeyCode == Keys.F2)
                {
                    if (BtnEdit.Enabled == true)
                    {
                        BtnEdit_Click(sender, e);
                    }
                }
                if (e.KeyCode == Keys.F3)
                {
                    if (BtnDelete.Enabled == true)
                    {
                        BtnDelete_Click(sender, e);
                    }
                }
                if (e.KeyCode == Keys.F4)
                {
                    if (BtnCancel.Enabled == true)
                    {
                        BtnCancel_Click(sender, e);
                    }
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

        private void TxtPesquisa_TextChanged(object sender, EventArgs e)
        {
            stringPesq = "SELECT CodigoBusca, NomeProduto, UniDeVenda, PrecoCusto, PrecoVenda , Categoria , Observacoes, Fornecedor FROM produtos WHERE NomeProduto <> 'delete' AND (CodigoBusca LIKE '" + TxtPesquisa.Text +"%' or NomeProduto LIKE '"+ TxtPesquisa.Text +"%')";
            selectProdutos(this);
        }

        private void GridProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Program.idprodutoSelec = GridProdutos.CurrentRow.Cells[0].Value.ToString();
            BtnEdit.Enabled = true;
            BtnDelete.Enabled = true;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            BtnDelete.Enabled = false;
            BtnEdit.Enabled = false;
            FichaProduto fichaP = new FichaProduto();
            this.Hide();
            fichaP.ShowDialog();
            stringPesq = "SELECT CodigoBusca, NomeProduto, UniDeVenda, PrecoCusto, PrecoVenda , Categoria , Observacoes, Fornecedor FROM produtos WHERE NomeProduto <> 'delete' AND (CodigoBusca LIKE '" + TxtPesquisa.Text + "%' or NomeProduto LIKE '" + TxtPesquisa.Text + "%')";
            selectProdutos(this);
            this.Show();
        }

        private void TxtPesquisa_Enter(object sender, EventArgs e)
        {
            BtnEdit.Enabled = false;
            BtnDelete.Enabled = false;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE produtos SET NomeProduto = 'Delete' WHERE IdProduto LIKE @Id;";
            using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
            {
                cmd.Parameters.AddWithValue("@Id", Program.idprodutoSelec);
                cmd.ExecuteNonQuery();
            }
            stringPesq = "SELECT CodigoBusca, NomeProduto, UniDeVenda, PrecoCusto, PrecoVenda , Categoria , Observacoes, Fornecedor FROM produtos WHERE NomeProduto <> 'delete' AND (CodigoBusca LIKE '" + TxtPesquisa.Text + "%' or NomeProduto LIKE '" + TxtPesquisa.Text + "%')";
            selectProdutos(this);
            BtnDelete.Enabled = false;
            BtnEdit.Enabled = false;
        }

        private void GridProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnEdit_Click(sender, e);
        }

        void selectProdutos (Control con)
        {
            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();
            mDataSet = new DataSet();
            //codigo SQL
            try
            {
                mAdapter = new MySqlDataAdapter(stringPesq, mConn);
                mAdapter.Fill(mDataSet, "Tabela_dados");
                //atribui para o datagrid
                GridProdutos.DataSource = mDataSet;
                GridProdutos.DataMember = "Tabela_dados";
                GridProdutos.Columns[0].Width = 50;
                GridProdutos.Columns[1].Width = 200;
                GridProdutos.Columns[2].Width = 110;
                GridProdutos.Columns[3].Width = 108;
                GridProdutos.Columns[4].Width = 108;
                GridProdutos.Columns[5].Width = 100;
                GridProdutos.Columns[6].Width = 200;
                GridProdutos.Columns[7].Width = 150;
                GridProdutos.Columns[0].HeaderText = "Codigo";
                GridProdutos.Columns[1].HeaderText = "Nome Produto";
                GridProdutos.Columns[2].HeaderText = "Unidade";
                GridProdutos.Columns[3].HeaderText = "Preco de Custo";
                GridProdutos.Columns[4].HeaderText = "Preco de Venda";
                GridProdutos.Columns[5].HeaderText = "Categoria";
                GridProdutos.Columns[6].HeaderText = "Observações";
                GridProdutos.Columns[7].HeaderText = "Fornecedor";

                GridProdutos.RowHeadersWidth = 20;
                GridProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
                GridProdutos.ColumnHeadersHeight = 30;

            }
            catch (Exception ex)
            {

            }
        }
    

        private void Produtos_Load(object sender, EventArgs e)
        {
            BtnClose.FlatAppearance.BorderSize = 0;
            BtnNovoP.FlatAppearance.BorderSize = 0;
            BtnDelete.FlatAppearance.BorderSize = 0;
            BtnEdit.FlatAppearance.BorderSize = 0;
            BtnCancel.FlatAppearance.BorderSize = 0;
            selectProdutos(this);
            if(Program.venceu == "s")
            {
                BtnNovoP.Enabled = false;
                BtnEdit.Enabled = false;
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNovoP_Click(object sender, EventArgs e)
        {
            BtnNovoP.FlatAppearance.BorderSize = 0;
            this.Hide();
            CadastroProdutos cadProd = new CadastroProdutos();
            cadProd.ShowDialog();
            stringPesq = "SELECT  CodigoBusca, NomeProduto, UniDeVenda, PrecoCusto, PrecoVenda , Categoria , Observacoes, Fornecedor FROM produtos WHERE NomeProduto <> 'delete'";
            selectProdutos(this);
            this.Show();
        }
    }
}
