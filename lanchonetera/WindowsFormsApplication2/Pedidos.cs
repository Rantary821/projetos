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
    public partial class Pedidos : Form
    {
        int id;

        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private MySqlDataReader reader, reader1, reader2;
        private DataSet mDataSet;
        private MySqlCommand cmd, cmd1, cmd2;

        private void BtnAdicionarAoPedido_Click(object sender, EventArgs e)
        {
            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();

            if (TxtNome.Text != "" && ComboProduto.Text != "" && TxtPrecoUni.Text != "" && TxtValorTotal.Text != "" && TxtQuant.Text != "")
            {
                string sql = "INSERT INTO pedidosabertos (NumeroPedido, NomeCliente, Pedido, Preco, PrecoTotal, Quant) VALUES (@id, @Nome, @produto, @preco, @precoT, @quant);";
                using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@Nome", TxtNome.Text);
                    cmd.Parameters.AddWithValue("@produto", ComboProduto.Text);
                    cmd.Parameters.AddWithValue("@preco", TxtPrecoUni.Text);
                    cmd.Parameters.AddWithValue("@precoT", TxtValorTotal.Text);
                    cmd.Parameters.AddWithValue("@quant", TxtQuant.Text);
                    cmd.ExecuteNonQuery();
                }
                Pedidos_Load(sender, e);
                TxtNome.Text = "";
                ComboProduto.Text = "";
                TxtPrecoUni.Text = "";
                TxtValorTotal.Text = "";
                TxtQuant.Text = "";
            }
        }

        private void TxtPrecoUni_TextChanged(object sender, EventArgs e)
        {
            decimal preco, quant;
            if (TxtPrecoUni.Text != "" && TxtQuant.Text != "")
            {
                preco = Convert.ToDecimal(TxtPrecoUni.Text);
                quant = Convert.ToDecimal(TxtQuant.Text);
                TxtValorTotal.Text = Convert.ToString(preco * quant);
            }
            else
                if (TxtPrecoUni.Text != "" || TxtQuant.Text != "")
            {
                TxtValorTotal.Text = "0,00";
            }
        }

        private void TxtQuant_TextChanged(object sender, EventArgs e)
        {
            decimal preco, quant;
            if (TxtPrecoUni.Text != "" && TxtQuant.Text != "")
            {
                preco = Convert.ToDecimal(TxtPrecoUni.Text);
                quant = Convert.ToDecimal(TxtQuant.Text);
                TxtValorTotal.Text = Convert.ToString(preco * quant);
            }
            else
                if (TxtPrecoUni.Text != "" || TxtQuant.Text != "")
            {
                TxtValorTotal.Text = "0,00";
            }
        }

        private void ComboProduto_Enter(object sender, EventArgs e)
        {
            mDataSet = new DataSet();
            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();

            MySqlCommand mAdapter = new MySqlCommand("SELECT * FROM `produtos` ORDER by nomeProduto DESC", mConn);
            MySqlDataReader reader = mAdapter.ExecuteReader();//retorna dados resultantes da consulta em SQL
            DataTable table = new DataTable(); //estrutura da tabela do banco de dados ou de outra fonte de informação
            table.Load(reader); //carrega dados na tabela de acordo com a instrução sql passada 
            DataRow row = table.NewRow(); //representa uma linha de dados em um DataTable
            row["nomeProduto"] = ""; //para não gerar valor nulo e, consequentemente, evitar erro de execução


            this.ComboProduto.DataSource = table;
            this.ComboProduto.ValueMember = "idProduto";
            this.ComboProduto.DisplayMember = "nomeProduto";//obtem o nome do curso
            reader.Close();//fecha o objeto
            reader.Dispose();//liberamos o objeto da memoria
            ComboProduto.SelectedIndex = -1;
            TxtPrecoUni.Text = "";
        }

        private void ComboProduto_TextChanged(object sender, EventArgs e)
        {
            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();
            string sql = "SELECT preco FROM `produtos` WHERE nomeProduto = @nomeProduto;";
            using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
            {
                cmd.Parameters.AddWithValue("@nomeProduto", ComboProduto.Text);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TxtPrecoUni.Text = reader.GetString("preco");
                }
                reader.Close();
            }
        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
           // string 
        }

        private void BtnNewPedido_Click(object sender, EventArgs e)
        {
            id = 0;
            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();

            if(TxtNome.Text != "" && ComboProduto.Text != "" && TxtPrecoUni.Text != "" && TxtValorTotal.Text != "" && TxtQuant.Text != "")
            {
                string sql = "SELECT MAX(NumeroPedido) FROM pedidosabertos;";
                using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
                {
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        id = reader.GetInt16("MAX(NumeroPedido)");
                        id = id + 1;
                    }
                    reader.Close();
                }

                sql = "INSERT INTO pedidosabertos (NumeroPedido, NomeCliente, Pedido, Preco, PrecoTotal, Quant) VALUES (@id, @Nome, @produto, @preco, @precoT, @quant);";
                using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@Nome", TxtNome.Text);
                    cmd.Parameters.AddWithValue("@produto", ComboProduto.Text);
                    cmd.Parameters.AddWithValue("@preco", TxtPrecoUni.Text);
                    cmd.Parameters.AddWithValue("@precoT", TxtValorTotal.Text);
                    cmd.Parameters.AddWithValue("@quant", TxtQuant.Text);
                    cmd.ExecuteNonQuery();
                }
                Pedidos_Load(sender, e);
                TxtNome.Text = "";
                ComboProduto.Text = "";
                TxtPrecoUni.Text = "";
                TxtValorTotal.Text = "";
                TxtQuant.Text = "";
            }
        }

        private void GridPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt16(GridPedidos.CurrentRow.Cells[0].Value.ToString());
            TxtNome.Text = GridPedidos.CurrentRow.Cells[1].Value.ToString();
            BtnAdicionarAoPedido.Enabled = true;
            BtnFinalizar.Enabled = true;
        }

        public Pedidos()
        {
            InitializeComponent();
        }

        private void Pedidos_Load(object sender, EventArgs e)
        {
            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();
            mDataSet = new DataSet();
            //codigo SQL
            try
            {
                mAdapter = new MySqlDataAdapter("SELECT `NumeroPedido`, `NomeCliente`, `Pedido`, `Preco`, `Quant`, `PrecoTotal`  FROM `pedidosabertos` WHERE NumeroPedido <> 0", mConn);
                mAdapter.Fill(mDataSet, "Tabela_dados");
                //atribui para o datagrid
                GridPedidos.DataSource = mDataSet;
                GridPedidos.DataMember = "Tabela_dados";
                GridPedidos.Columns[0].Width = 50;
                GridPedidos.Columns[1].Width = 200;
                GridPedidos.Columns[2].Width = 320;
                GridPedidos.Columns[3].Width = 110;
                GridPedidos.Columns[4].Width = 90;
                GridPedidos.Columns[5].Width = 90;
                GridPedidos.Columns[0].HeaderText = "Nº";
                GridPedidos.Columns[1].HeaderText = "Nome cliente";
                GridPedidos.Columns[2].HeaderText = "Pedido";
                GridPedidos.Columns[3].HeaderText = "Preço uni";
                GridPedidos.Columns[4].HeaderText = "Quant";
                GridPedidos.Columns[5].HeaderText = "Total";
                GridPedidos.RowHeadersWidth = 20;
                GridPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
                GridPedidos.ColumnHeadersHeight = 30;

            }
            catch (Exception ex)
            {
                Program.LblMessage = "Um erro ocorreu!";
                Program.PicInterrog = "0";
                Program.PicAlert = "0";
                Program.PicVendaOK = "0";
                Program.PicError = "1";
                Program.btnNao = "0";
                Program.btnSim = "0";
                Program.btnOk = "1";

                FormMessageBox message = new FormMessageBox();
                message.ShowDialog();
            }
            mConn.Close();
        }
    }
}
