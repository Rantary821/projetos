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
    public partial class CadastroDeClientes : Form
    {
        int idcliente;
        string endereco, clickVerify;

        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private MySqlDataReader reader, reader1, reader2;
        private DataSet mDataSet;
        private MySqlCommand cmd, cmd1, cmd2;

        public CadastroDeClientes()
        {
            InitializeComponent();
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

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {
            if (TxtNome.Text != "" && clickVerify == "Y")
            {
                textChanged(this);
            }
            else
            if (TxtNome.Text != "" )
            {
                BtnCadastrar.Enabled = true;
                BtnCadastrar.BackColor = Color.FromArgb(255, 127, 0);
            }
            else
            if (TxtNome.Text == "" && TxtDataNasc.Text == "00/00/0000" && TxtRg.Text == "" && TxtCpf.Text == "" && TxtBairro.Text == "" && TxtRua.Text == "" && TxtNumero.Text == "")
            {
                BtnCadastrar.Enabled = false;
                BtnCadastrar.BackColor = Color.Silver;
            }
        }
    
        private void TxtDataNasc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (TxtDataNasc.Text != "" && clickVerify == "Y")
            {
                textChanged(this);
            }
            else
            if (TxtDataNasc.Text != "")
            {
                BtnCadastrar.Enabled = true;
                BtnCadastrar.BackColor = Color.FromArgb(255, 127, 0);
            }
            else
            if (TxtNome.Text == "" && TxtDataNasc.Text == "00/00/0000" && TxtRg.Text == "" && TxtCpf.Text == "" && TxtBairro.Text == "" && TxtRua.Text == "" && TxtNumero.Text == "")
            {
                BtnCadastrar.Enabled = false;
                BtnCadastrar.BackColor = Color.Silver;
            }
        }

        private void TxtRg_TextChanged(object sender, EventArgs e)
        {
            if (TxtRg.Text != "" && clickVerify == "Y")
            {
                textChanged(this);
            }
            else
            if (TxtRg.Text != "")
            {
                BtnCadastrar.Enabled = true;
                BtnCadastrar.BackColor = Color.FromArgb(255, 127, 0);
            }
            else
            if (TxtNome.Text == "" && TxtDataNasc.Text == "00/00/0000" && TxtRg.Text == "" && TxtCpf.Text == "" && TxtBairro.Text == "" && TxtRua.Text == "" && TxtNumero.Text == "")
            {
                BtnCadastrar.Enabled = false;
                BtnCadastrar.BackColor = Color.Silver;
            }
        }

        private void TxtCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }

        private void TxtBairro_TextChanged(object sender, EventArgs e)
        {
            if (TxtBairro.Text != "" && clickVerify == "Y")
            {
                textChanged(this);
            }
            else
            if (TxtBairro.Text != "")
            {
                BtnCadastrar.Enabled = true;
                BtnCadastrar.BackColor = Color.FromArgb(255, 127, 0);
            }
            else
            if (TxtNome.Text == "" && TxtDataNasc.Text == "00/00/0000" && TxtRg.Text == "" && TxtCpf.Text == "" && TxtBairro.Text == "" && TxtRua.Text == "" && TxtNumero.Text == "")
            {
                BtnCadastrar.Enabled = false;
                BtnCadastrar.BackColor = Color.Silver;
            }
        }

        private void TxtRua_TextChanged(object sender, EventArgs e)
        {
            if (TxtRua.Text != "" && clickVerify == "Y")
            {
                textChanged(this);
            }
            else
            if (TxtRua.Text != "")
            {
                BtnCadastrar.Enabled = true;
                BtnCadastrar.BackColor = Color.FromArgb(255, 127, 0);
            }
            else
            if (TxtNome.Text == "" && TxtDataNasc.Text == "00/00/0000" && TxtRg.Text == "" && TxtCpf.Text == "" && TxtBairro.Text == "" && TxtRua.Text == "" && TxtNumero.Text == "")
            {
                BtnCadastrar.Enabled = false;
                BtnCadastrar.BackColor = Color.Silver;
            }
        }

        private void TxtNumero_TextChanged(object sender, EventArgs e)
        {
            if (TxtNumero.Text != "" && clickVerify == "Y")
            {
                textChanged(this);
            }
            else
            if (TxtNumero.Text != "")
            {
                BtnCadastrar.Enabled = true;
                BtnCadastrar.BackColor = Color.FromArgb(255, 127, 0);
            }
            else
            if (TxtNome.Text == "" && TxtDataNasc.Text == "00/00/0000" && TxtRg.Text == "" && TxtCpf.Text == "" && TxtBairro.Text == "" && TxtRua.Text == "" && TxtNumero.Text == "")
            {
                BtnCadastrar.Enabled = false;
                BtnCadastrar.BackColor = Color.Silver;
            }
        }

        private void TxtCpf_TextChanged(object sender, EventArgs e)
        {
            if (TxtCpf.Text != "" && clickVerify == "Y")
            {
                textChanged(this);
            }
            else
           if (TxtCpf.Text != "")
            {
                BtnCadastrar.Enabled = true;
                BtnCadastrar.BackColor = Color.FromArgb(255, 127, 0);
            }
            else
           if (TxtNome.Text == "" && TxtDataNasc.Text == "00/00/0000" && TxtRg.Text == "" && TxtCpf.Text == "" && TxtBairro.Text == "" && TxtRua.Text == "" && TxtNumero.Text == "")
            {
                BtnCadastrar.Enabled = false;
                BtnCadastrar.BackColor = Color.Silver;
            }
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();
            string sql = "UPDATE clientes SET Nome = @Nome, Cpf = @Cpf, Rg = @Rg, DataNasc = @DataNasc, Rua = @Rua, Bairro = @Bairro, Numero = @Numero WHERE idCliente = @idCliente;";
            using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
            {
                cmd.Parameters.AddWithValue("@Nome", TxtNome.Text);
                cmd.Parameters.AddWithValue("@Cpf", TxtCpf.Text);
                cmd.Parameters.AddWithValue("@Rg", TxtRg.Text);
                cmd.Parameters.AddWithValue("@DataNasc", TxtDataNasc.Text);
                cmd.Parameters.AddWithValue("@Rua", TxtRua.Text);
                cmd.Parameters.AddWithValue("@Bairro", TxtBairro.Text);
                cmd.Parameters.AddWithValue("@Numero", TxtNumero.Text);
                cmd.Parameters.AddWithValue("@idCliente", idcliente);
                cmd.ExecuteNonQuery();
            }
            mConn.Close();
            SelectDataGrid(this);
            BtnAtualizar.BackColor = Color.Silver;
            BtnAtualizar.Enabled = false;
            ClearAllText(this);
            clickVerify = "";
        }

        private void DataGridClientes_Click(object sender, EventArgs e)
        {
            if (Program.VarCheckDelCliente == "sim")
            {
                try
                {
                    idcliente = Convert.ToInt16(DataGridClientes.CurrentRow.Cells[0].Value.ToString());
                    BtnExcluir.BackColor = Color.Red;
                    BtnExcluir.Enabled = true;
                }
                catch (Exception ex)
                {
                    BtnExcluir.Enabled = false;
                }
            }       
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();
            string sql = "UPDATE clientes SET Nome = @Nome WHERE idCliente = @idCliente;";
            using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
            {
                cmd.Parameters.AddWithValue("@Nome", "Excluido");
                cmd.Parameters.AddWithValue("@idCliente", idcliente);
                cmd.ExecuteNonQuery();
            }
            SelectDataGrid(this);
            mConn.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Program.VarCheckUpdateCliente == "sim")
            {
                try
                {
                    clickVerify = "";
                    idcliente = Convert.ToInt16(DataGridClientes.CurrentRow.Cells[0].Value.ToString());
                    TxtNome.Text = DataGridClientes.CurrentRow.Cells[1].Value.ToString();
                    TxtRg.Text = DataGridClientes.CurrentRow.Cells[2].Value.ToString();
                    TxtCpf.Text = DataGridClientes.CurrentRow.Cells[3].Value.ToString();
                    TxtBairro.Text = DataGridClientes.CurrentRow.Cells[4].Value.ToString();
                    TxtDataNasc.Text = DataGridClientes.CurrentRow.Cells[5].Value.ToString();
                    TxtRua.Text = DataGridClientes.CurrentRow.Cells[6].Value.ToString();
                    TxtNumero.Text = DataGridClientes.CurrentRow.Cells[7].Value.ToString();
                    clickVerify = "Y";
                    BtnCadastrar.Enabled = false;
                    BtnCadastrar.BackColor = Color.Silver;
                }
                catch (Exception ex)
                {
                    BtnExcluir.Enabled = false;
                }
            }      
        }

        void textChanged(Control con)
        {
            if(clickVerify == "Y")
            {
                BtnAtualizar.BackColor = Color.FromArgb(65, 133, 227);
                BtnAtualizar.Enabled = true;
            }
        }

        void SelectDataGrid(Control con)
        {
            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();
            mDataSet = new DataSet();
            //codigo SQL
            try
            {
                mAdapter = new MySqlDataAdapter("SELECT idCliente, Nome, Rg, Cpf, Bairro, DataNasc, Rua, Numero FROM `clientes` WHERE Nome <> 'Excluido'", mConn);
                mAdapter.Fill(mDataSet, "Tabela_dados");
                //atribui para o datagrid
                DataGridClientes.DataSource = mDataSet;
                DataGridClientes.DataMember = "Tabela_dados";
                DataGridClientes.Columns[0].Width = 0;
                DataGridClientes.Columns[1].Width = 278;
                DataGridClientes.Columns[2].Width = 110;
                DataGridClientes.Columns[3].Width = 110;
                DataGridClientes.Columns[4].Width = 180;
                DataGridClientes.Columns[5].Width = 115;
                DataGridClientes.Columns[6].Width = 0;
                DataGridClientes.Columns[7].Width = 0;
                DataGridClientes.Columns[0].HeaderText = "";
                DataGridClientes.Columns[1].HeaderText = "Nome";
                DataGridClientes.Columns[2].HeaderText = "RG";
                DataGridClientes.Columns[3].HeaderText = "Cpf";
                DataGridClientes.Columns[4].HeaderText = "bairro";
                DataGridClientes.Columns[5].HeaderText = "DataNasc";
                DataGridClientes.Columns[6].HeaderText = "";
                DataGridClientes.Columns[7].HeaderText = "";
                DataGridClientes.RowHeadersWidth = 20;
                DataGridClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
                DataGridClientes.ColumnHeadersHeight = 30;

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

                if (Program.MessageResult == "O")
                {
                    this.Close();
                }
            }
            mConn.Close();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();         
            string sql = "INSERT INTO clientes (Nome, Cpf, Rg, DataNasc, Rua, Bairro, Numero, Divida) VALUES (@Nome, @Cpf, @Rg, @DataNasc, @Rua, @Bairro, @Numero, @Divida);";
            using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
            {
                cmd.Parameters.AddWithValue("@Nome", TxtNome.Text);
                cmd.Parameters.AddWithValue("@Cpf", TxtCpf.Text);
                cmd.Parameters.AddWithValue("@Rg", TxtRg.Text);
                cmd.Parameters.AddWithValue("@DataNasc", TxtDataNasc.Text);
                cmd.Parameters.AddWithValue("@Rua", TxtRua.Text);
                cmd.Parameters.AddWithValue("@Bairro", TxtBairro.Text);
                cmd.Parameters.AddWithValue("@Numero", TxtNumero.Text); 
                cmd.Parameters.AddWithValue("@Divida", "0");
                cmd.ExecuteNonQuery();
            }
            mConn.Close();
            SelectDataGrid(this);
            ClearAllText(this);
            BtnCadastrar.Enabled = false;
            BtnCadastrar.BackColor = Color.Silver;
            TxtDataNasc.Text = "00000000";
        }
    }
}
