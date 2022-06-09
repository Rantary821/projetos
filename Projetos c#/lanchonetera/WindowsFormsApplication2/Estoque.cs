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
    public partial class Estoque : Form
    {

        public Estoque()
        {
            InitializeComponent();
            selectgrid = "SELECT nomeProduto, QuantidadeEstoque, quantMin, quantMax, preco FROM `produtos`;";
            selectgrid1 = "SELECT nome,cnpjcpf from fornecedor";
            SelectDataGrid(this);
            SelectFornecedor(this);
        }
        int idProduto;
        int idFornecedor;
        string selectgrid,selectgrid1;
        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private MySqlDataReader reader, reader1, reader2;
        private DataSet mDataSet;
        private MySqlCommand cmd, cmd1, cmd2;

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
                dataProduto.DataSource = mDataSet;
                dataProduto.DataMember = "Tabela_dados";
                dataProduto.Columns[0].Width = 300;
                dataProduto.Columns[1].Width = 120;
                dataProduto.Columns[2].Width = 120;
                dataProduto.Columns[3].Width = 120;
                dataProduto.Columns[0].HeaderText = "Nome do Produto";
                dataProduto.Columns[1].HeaderText = "Qnt Estoque";
                dataProduto.Columns[2].HeaderText = "Qnt Minima";
                dataProduto.Columns[3].HeaderText = "Qnt Maxima";
                dataProduto.Columns[4].HeaderText = "Preço";



            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR : " + ex);
            }
            mConn.Close();
        }
        void SelectFornecedor(Control con)
        {
            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();
            mDataSet = new DataSet();
            //codigo SQL
            try
            {
                mAdapter = new MySqlDataAdapter(selectgrid1, mConn);
                mAdapter.Fill(mDataSet, "Tabela_dados");
                //atribui para o datagrid
                dataForn.DataSource = mDataSet;
                dataForn.DataMember = "Tabela_dados";
                dataForn.Columns[0].Width = 350;
                dataForn.Columns[1].Width = 300;
                dataForn.Columns[0].HeaderText = "Nome do Fornecedor";
                dataForn.Columns[1].HeaderText = "CPF/CNPJ";
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR : " + ex);
            }
            mConn.Close();
        }
        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();
            string sql = "INSERT INTO produtos (idProduto,idFornecedor,quantidadeEstoque,quantMax,quantMin,nomeProduto,preco) VALUES (@idprod,@idforn,@qntEst,@qntMax,@qntMin,@nomeProd,@valor);";
            using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
            {
                cmd.Parameters.AddWithValue("@idprod", idProduto);
                cmd.Parameters.AddWithValue("@idforn", idFornecedor);
                cmd.Parameters.AddWithValue("@qntEst", txtQntEstoque.Text);
                cmd.Parameters.AddWithValue("@qntMax", txtQntMax.Text);
                cmd.Parameters.AddWithValue("@qntMin", txtQntMin.Text);
                cmd.Parameters.AddWithValue("@nomeProd", txtNomeProd.Text);
                cmd.Parameters.AddWithValue("@valor", txtPuni.Text);
                cmd.ExecuteNonQuery();
            }
            mConn.Close();
            SelectDataGrid(this);
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

        private void txtPuni_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double contador1, contador2;
                contador1 = Convert.ToDouble(txtPuni.Text);
                contador2 = Convert.ToDouble(txtQntEstoque.Text);
                contador2 = contador1 * contador2;
                precoTotal.Text = Convert.ToString(contador2);
            }
            catch
            {

            }
        }

        private void dataForn_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        { 
            comboFornecedor.Text = dataForn.CurrentRow.Cells[0].Value.ToString();
            txtCnpj.Text = dataForn.CurrentRow.Cells[1].Value.ToString();
            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();
            string sql = "select idFornecedor from fornecedor where cnpjcpf = '" + txtCnpj.Text + "'";
            mDataSet = new DataSet();
            //codigo SQL
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
                {
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        idFornecedor = reader.GetInt16("idFornecedor");
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR : " + ex);
            }
            mConn.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void txtQntMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void txtQntMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }
    }
}
