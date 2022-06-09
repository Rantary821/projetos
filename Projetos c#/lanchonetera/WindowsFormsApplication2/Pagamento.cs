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
    public partial class Pagamento : Form
    {
        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private MySqlDataReader reader, reader1, reader2;
        private DataSet mDataSet;
        private MySqlCommand cmd, cmd1, cmd2;

        string id;
        double divida;
        private void TxtValorPago_TextChanged(object sender, EventArgs e)
        {
            if (TxtValorPago.Text != "" && TxtValorPago.Text != "0")
            {
                BtnPagar.Enabled = true;
                BtnPagar.BackColor = Color.FromArgb(255, 127, 0);
                txtResult.Text = Convert.ToString(Convert.ToDouble(TxtDividaTotal.Text) - Convert.ToDouble(TxtValorPago.Text));
            }
            if (TxtValorPago.Text == "" || TxtValorPago.Text == "0" || TxtValorPago.Text == "00" || TxtValorPago.Text == "000" || TxtValorPago.Text == "0000" || TxtValorPago.Text == "00000" || TxtValorPago.Text == "000000" || TxtValorPago.Text == "0000000" || TxtValorPago.Text == "00000000" || TxtValorPago.Text == "000000000" || TxtValorPago.Text == "0000000000" || TxtValorPago.Text == "00000000000")
            {
                BtnPagar.Enabled = false;
                BtnPagar.BackColor = Color.Silver;
            }

        }

        private void BtnPagar_Click(object sender, EventArgs e)
        {
            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();

            string sql = "UPDATE clientes SET Divida = @Divida WHERE idCliente = @idcliente;";
            using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
            {
                cmd.Parameters.AddWithValue("@Divida", txtResult.Text);
                cmd.Parameters.AddWithValue("@idcliente", id);
                cmd.ExecuteNonQuery();
            }
            mConn.Close();
            BtnPagar.Enabled = false;
            TxtValorPago.Text = "";
            txtResult.Text = "";
            TxtDividaTotal.Text = "";
            TxtNome.Text = "";
            TxtCpf.Text = "";
            TxtRg.Text = "";
            TxtRua.Text = "";
            TxtBairro.Text = "";
            TxtNumero.Text = "";
            GridCompras.DataSource = null;
            GridCompras.Rows.Clear();
            Pagamento_Load(sender, e);
        }

        private void GridPagamento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            GridCompras.DataSource = null;
            GridCompras.Rows.Clear();
            TxtNome.Text = "";
            TxtCpf.Text = "";
            TxtRg.Text = "";
            TxtRua.Text = "";
            TxtBairro.Text = "";
            TxtNumero.Text = "";
            TxtDividaTotal.Text = "";
            TxtValorPago.Text = "";
            txtResult.Text = "";   
            GroupPaga.Enabled = false;
            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();

            id = GridPagamento.CurrentRow.Cells[0].Value.ToString(); 

            string sql = "SELECT Nome, Cpf, Rg, Rua, Bairro, Numero, Divida FROM `clientes` WHERE idCliente = @idcliente;";
            using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
            {
                cmd.Parameters.AddWithValue("@idCliente", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TxtNome.Text = reader.GetString("Nome");
                    TxtCpf.Text = reader.GetString("Cpf");
                    TxtRg.Text = reader.GetString("Rg");
                    TxtRua.Text = reader.GetString("Rua");
                    TxtBairro.Text = reader.GetString("Bairro");
                    TxtNumero.Text = reader.GetString("Numero");
                    TxtDividaTotal.Text = reader.GetString("Divida");
                    GroupPaga.Enabled = true;
                }
                reader.Close();
            }

            mDataSet = new DataSet();
            //codigo SQL
            try
            {
                mAdapter = new MySqlDataAdapter("SELECT Produto, PrecoUni, quant, DataCompra  FROM `vendas` WHERE idCliente = '" + id +"'", mConn);
                mAdapter.Fill(mDataSet, "Tabela_dados");
                //atribui para o datagrid
                GridCompras.DataSource = mDataSet;
                GridCompras.DataMember = "Tabela_dados";
                GridCompras.Columns[0].Width = 190;
                GridCompras.Columns[1].Width = 110;
                GridCompras.Columns[2].Width = 80;
                GridCompras.Columns[3].Width = 130;
                GridCompras.Columns[0].HeaderText = "Produto";
                GridCompras.Columns[1].HeaderText = "Pre.Uni";
                GridCompras.Columns[2].HeaderText = "quant";
                GridCompras.Columns[3].HeaderText = "DataCompra";
                GridCompras.RowHeadersWidth = 20;
                GridCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
                GridCompras.ColumnHeadersHeight = 30;

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

        string selectgrid = "SELECT idCliente, Nome, Cpf, Divida, DataNasc FROM clientes WHERE Divida <> 0;";

        public Pagamento()
        {
            InitializeComponent();
        }

        private void Pagamento_Load(object sender, EventArgs e)
        {
            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();
            mDataSet = new DataSet();
            //codigo SQL
            try
            {
                mAdapter = new MySqlDataAdapter(selectgrid, mConn);
                mAdapter.Fill(mDataSet, "Tabela_dados");
                //atribui para o datagrid
                GridPagamento.DataSource = mDataSet;
                GridPagamento.DataMember = "Tabela_dados";
                GridPagamento.Columns[0].Width = 0;
                GridPagamento.Columns[1].Width = 440;
                GridPagamento.Columns[2].Width = 210;
                GridPagamento.Columns[3].Width = 150;
                GridPagamento.Columns[4].Width = 140;
                GridPagamento.Columns[0].HeaderText = "";
                GridPagamento.Columns[1].HeaderText = "Nome";
                GridPagamento.Columns[2].HeaderText = "Cpf";
                GridPagamento.Columns[3].HeaderText = "Divida";
                GridPagamento.Columns[4].HeaderText = "Nascimento";
                GridPagamento.RowHeadersWidth = 20;
                GridPagamento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
                GridPagamento.ColumnHeadersHeight = 30;

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
