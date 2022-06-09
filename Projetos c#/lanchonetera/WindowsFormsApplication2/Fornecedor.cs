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
    public partial class Fornecedor : Form
    {
        public Fornecedor()
        {
            InitializeComponent();
            selectgrid = "SELECT nome, cnpjcpf, endereço, cidade,estado,telefone FROM `fornecedor`;";
            SelectDataGrid(this);
        }
        void SelectDataGrid(Control con)
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
                dataFornecedor.DataSource = mDataSet;
                dataFornecedor.DataMember = "Tabela_dados";
                dataFornecedor.Columns[0].Width = 300;
                dataFornecedor.Columns[1].Width = 150;
                dataFornecedor.Columns[2].Width = 300;
                dataFornecedor.Columns[3].Width = 150;
                dataFornecedor.Columns[4].Width = 50;
                dataFornecedor.Columns[0].HeaderText = "Nome do Fornecedor";
                dataFornecedor.Columns[1].HeaderText = "CNPJ/CPF";
                dataFornecedor.Columns[2].HeaderText = "Endereço";
                dataFornecedor.Columns[3].HeaderText = "Cidade";
                dataFornecedor.Columns[4].HeaderText = "UF";
            }
            catch (Exception ex)
            {
                Program.LblMessage = "Um erro ocorreu!";
                Program.PicInterrog = "0";
                Program.PicAlert = "0";
                Program.PicError = "1";
                Program.PicVendaOK = "0";
                Program.btnNao = "0";
                Program.btnSim = "0";
                Program.btnOk = "1";

                FormMessageBox message = new FormMessageBox();
                message.ShowDialog();
            }
            mConn.Close();
        }
        string selectgrid;
        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private MySqlDataReader reader, reader1, reader2;
        private DataSet mDataSet;
        private MySqlCommand cmd, cmd1, cmd2;

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();
            string sql = "INSERT INTO fornecedor (telefone,nome,endereço,cnpjcpf,cidade,estado) values (@tel,@nome,@ende,@cpf,@cida,@uf);";
            using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
            {
                cmd.Parameters.AddWithValue("@tel",txtTel.Text);
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@ende", txtEnd.Text);
                cmd.Parameters.AddWithValue("@cpf", txtCpf.Text);
                cmd.Parameters.AddWithValue("@cida", txtCidade.Text);
                cmd.Parameters.AddWithValue("@uf", txtuf.Text);
                cmd.ExecuteNonQuery();
            }
            mConn.Close();
            SelectDataGrid(this);
        }
    }
}
