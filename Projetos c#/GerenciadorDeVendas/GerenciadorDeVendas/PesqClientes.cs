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
    public partial class PesqClientes : Form
    {
        string stringPesq = "SELECT IdCliente, Nome, Cpf, Rg, Bairro, Rua, Numero, Telefone, Celular, Sexo, Nascimento FROM `clientes` WHERE Nome <> 'Delete'";
        string idCliente;

        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private MySqlDataReader reader, reader1, reader2;
        private DataSet mDataSet;
        private MySqlCommand cmd, cmd1, cmd2;

        public PesqClientes()
        {
            InitializeComponent();
        }

        void selectClientes(Control con)
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
                GridClientes.DataSource = mDataSet;
                GridClientes.DataMember = "Tabela_dados";
                GridClientes.Columns[0].Width = 0;
                GridClientes.Columns[1].Width = 242;
                GridClientes.Columns[2].Width = 110;
                GridClientes.Columns[3].Width = 80;
                GridClientes.Columns[4].Width = 140;
                GridClientes.Columns[5].Width = 60;
                GridClientes.Columns[6].Width = 70;
                GridClientes.Columns[7].Width = 100;
                GridClientes.Columns[8].Width = 100;
                GridClientes.Columns[9].Width = 80;
                GridClientes.Columns[10].Width = 90;
                GridClientes.Columns[0].HeaderText = "Id";
                GridClientes.Columns[1].HeaderText = "Nome";
                GridClientes.Columns[2].HeaderText = "Cpf";
                GridClientes.Columns[3].HeaderText = "Rg";
                GridClientes.Columns[4].HeaderText = "Bairro";
                GridClientes.Columns[5].HeaderText = "Rua";
                GridClientes.Columns[6].HeaderText = "Numero";
                GridClientes.Columns[7].HeaderText = "Telefone";
                GridClientes.Columns[8].HeaderText = "Celular";
                GridClientes.Columns[9].HeaderText = "Sexo";
                GridClientes.Columns[10].HeaderText = "Nascimento";

                //IdCliente, Nome, Cpf, Rg, Bairro, Rua, Numero, Referencia, Telefone, Celular, Sexo, Nascimento FROM `clientes` WHERE Nome <> 'Delete'";

                GridClientes.RowHeadersWidth = 20;
                GridClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
                GridClientes.ColumnHeadersHeight = 30;

            }
            catch (Exception ex)
            {

            }
        }

        private void TxtPesquisa_TextChanged(object sender, EventArgs e)
        {
            stringPesq = "SELECT IdCliente, Nome, Cpf, Rg, Bairro, Rua, Numero, Telefone, Celular, Sexo, Nascimento FROM `clientes` WHERE Nome <> 'Delete' AND (Nome LIKE '" + TxtPesquisa.Text + "%' or Cpf LIKE '" + TxtPesquisa.Text + "%' or Rg LIKE '" + TxtPesquisa.Text + "%')";
            selectClientes(this);
        }

        private void GridClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Program.selecionar == "sim")
            {
                //pega o id e voltar pra venda
                this.Close();
            }
            if (Program.selecionar != "sim")
            {
                Program.IdSelected = GridClientes.CurrentRow.Cells[0].Value.ToString();
                FichaCliente ficha = new FichaCliente();
                ficha.Location = new Point(
                ficha.Left = Program.x,
                ficha.Top = Program.Y);
                this.Hide();
                ficha.ShowDialog();
                selectClientes(this);
                this.Show();
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();

            string sql = "UPDATE clientes SET Nome = 'Delete' WHERE IdCliente LIKE @Id;";
            using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
            {
                cmd.Parameters.AddWithValue("@Id", idCliente);
                cmd.ExecuteNonQuery();
            }

            stringPesq = "SELECT IdCliente, Nome, Cpf, Rg, Bairro, Rua, Numero, Telefone, Celular, Sexo, Nascimento FROM `clientes` WHERE Nome <> 'Delete'";
            selectClientes(this);
            BtnExcluir.Enabled = false;
        }

        private void TxtPesquisa_Enter(object sender, EventArgs e)
        {
            BtnExcluir.Enabled = false;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (Program.selecionar == "sim")
            {
                Program.IdSelected = "0";
                this.Close();
            }
            if (Program.selecionar != "sim")
            {
                this.Close();
            }
        }

        private void PesqClientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (Program.venceu != "s")
            {
                if (e.KeyCode == Keys.F1)
                {
                    BtnNovoCliente_Click(sender, e);
                }
                if (e.KeyCode == Keys.F2)
                {
                    if (BtnExcluir.Enabled == true)
                    {
                        BtnExcluir_Click(sender, e);
                    }
                }
                if (e.KeyCode == Keys.F3)
                {
                    BtnCancel_Click(sender, e);
                }            
            }
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            BtnClose.FlatAppearance.BorderSize = 0;
            BtnExcluir.FlatAppearance.BorderSize = 0;
            BtnCancel.FlatAppearance.BorderSize = 0;
            BtnNovoCliente.FlatAppearance.BorderSize = 0;
            selectClientes(this);

            if(Program.venceu == "s")
            {
                BtnNovoCliente.Enabled = false;
                BtnExcluir.Enabled = false;
            }

            if (Program.selecionar == "sim")
            {
                BtnCancel.Enabled = true;
                BtnClose.Enabled = false;
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNovoCliente_Click(object sender, EventArgs e)
        {
            BtnNovoCliente.FlatAppearance.BorderSize = 0;
            this.Hide();
            CadClientes CadCliente = new CadClientes();
            CadCliente.ShowDialog();
            stringPesq = "SELECT IdCliente, Nome, Cpf, Rg, Bairro, Rua, Numero, Telefone, Celular, Sexo, Nascimento FROM `clientes` WHERE Nome <> 'Delete'";
            selectClientes(this);
            this.Show();
        }

        private void GridClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Program.selecionar == "sim")
            {
                Program.IdSelected = GridClientes.CurrentRow.Cells[0].Value.ToString();
                this.Close();
            }
            if (Program.selecionar != "sim")
            {
                idCliente = GridClientes.CurrentRow.Cells[0].Value.ToString();
                BtnExcluir.Enabled = true;
            }
        }
    }
}
