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
{//IdFucnionario
    public partial class Funcionarios : Form
    {
        string pesquisa, Verifica;

        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private MySqlDataReader reader, reader1, reader2;
        private DataSet mDataSet;
        private MySqlCommand cmd, cmd1, cmd2;
        int id;

        //String de conexão com o banco
        //////////////////////////////////////////////
        public Funcionarios()
        {
            InitializeComponent();
        }

        void SelectDataGrifd(Control con)
        {
            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();
            mDataSet = new DataSet();
            //codigo SQL
            try
            {
                mAdapter = new MySqlDataAdapter("SELECT IdFuncionario, Nome, Rg, Cpf, ValorDiaria FROM funcionario WHERE Nome <> 'Demitido'", mConn);
                mAdapter.Fill(mDataSet, "Tabela_dados");
                //atribui para o datagrid
                FuncionarioGrid.DataSource = mDataSet;
                FuncionarioGrid.DataMember = "Tabela_dados";
                FuncionarioGrid.Columns[0].Width = 0;
                FuncionarioGrid.Columns[1].Width = 368;
                FuncionarioGrid.Columns[2].Width = 180;
                FuncionarioGrid.Columns[3].Width = 180;
                FuncionarioGrid.Columns[4].Width = 115;
                FuncionarioGrid.Columns[0].HeaderText = "";
                FuncionarioGrid.Columns[1].HeaderText = "Nome";
                FuncionarioGrid.Columns[2].HeaderText = "RG";
                FuncionarioGrid.Columns[3].HeaderText = "Cpf";
                FuncionarioGrid.Columns[4].HeaderText = "ValorDiaria";
                FuncionarioGrid.RowHeadersWidth = 20;
                FuncionarioGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
                FuncionarioGrid.ColumnHeadersHeight = 30;

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

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            MySqlConnection mConn = new MySqlConnection(Program.conexao);
            mConn.Open();
            string sql3 = "select count(IdFuncionario) from funcionario;";
            using (MySqlCommand cmd = new MySqlCommand(sql3, mConn))
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetInt16("count(IdFuncionario)");
                    id++;
                }
                reader.Close();
                cmd.ExecuteNonQuery();
            }
            mConn.Close();
            mConn.Open();
            if (TxtNome.Text != string.Empty || TxtRg.Text != string.Empty || TxtCpf.Text != "000.000.000-00")
            {
                string sql1 = " INSERT INTO funcionario(IdFuncionario, Nome, Rg, Cpf, ValorDiaria) VALUES(@id, @Nome, @Rg, @Cpf, @ValorDiaria);";
                using (MySqlCommand cmd = new MySqlCommand(sql1, mConn))
                {
                    cmd.Parameters.AddWithValue("@Nome", TxtNome.Text);
                    cmd.Parameters.AddWithValue("@Rg", TxtRg.Text);
                    cmd.Parameters.AddWithValue("@Cpf", TxtCpf.Text);
                    cmd.Parameters.AddWithValue("@ValorDiaria", valD.Text);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    valD.Text = string.Empty;
                    TxtNome.Text = string.Empty;
                    TxtRg.Text = string.Empty;
                    TxtCpf.Text = "000.000.000-00";
                }
            }
            string sql2 = "select * from funcionario;";
            using (MySqlCommand cmd = new MySqlCommand(sql2, mConn))
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetInt16("IdFuncionario");
                }
                reader.Close();
                cmd.ExecuteNonQuery();
            }
            string sql = "INSERT INTO diastrabalhados (IdFuncionario, NumDias, diastrabalhados) VALUES (@IdFuncionario, @NumDias, @dias);";
            using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
            {
                cmd.Parameters.AddWithValue("@IdFuncionario", id);
                cmd.Parameters.AddWithValue("@NumDias", 0);
                cmd.Parameters.AddWithValue("@dias", 0);
                cmd.ExecuteNonQuery();
            }
            SelectDataGrifd(this);
            mConn.Close();
        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtRg_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == ','))
            {
                e.Handled = true;
            }
        }

        private void valD_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                mConn = new MySqlConnection(Program.conexao);
                mConn.Open();
                string sql = "UPDATE `funcionario` SET `Nome` = 'demitido' WHERE IdFuncionario = @id";
                using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
                {
                    cmd.Parameters.AddWithValue("@id", Program.IdFuncionario);
                    cmd.ExecuteNonQuery();
                }
                SelectDataGrifd(this);
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally {
                mConn.Close();
            }

                
        }

        private void FuncionarioGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Program.VarCheckDelFuncio == "sim")
            {
                Program.IdFuncionario = FuncionarioGrid.CurrentRow.Cells[0].Value.ToString();
                Program.Nome = FuncionarioGrid.CurrentRow.Cells[1].Value.ToString();
                Program.Rg = FuncionarioGrid.CurrentRow.Cells[2].Value.ToString();
                Program.Cpf = FuncionarioGrid.CurrentRow.Cells[3].Value.ToString();
                Program.ValorDiaria = FuncionarioGrid.CurrentRow.Cells[4].Value.ToString();
            }
        }

        private void FuncionarioGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Program.VarCheckGoFichas == "sim")
            {
                mConn = new MySqlConnection(Program.conexao);
                mConn.Open();
                Verifica = "";
                try
                {
                    Program.IdFuncionario = FuncionarioGrid.CurrentRow.Cells[0].Value.ToString();
                    Program.Nome = FuncionarioGrid.CurrentRow.Cells[1].Value.ToString();
                    Program.Rg = FuncionarioGrid.CurrentRow.Cells[2].Value.ToString();
                    Program.Cpf = FuncionarioGrid.CurrentRow.Cells[3].Value.ToString();
                    Program.ValorDiaria = FuncionarioGrid.CurrentRow.Cells[4].Value.ToString();

                }
                catch (Exception ex)
                {
                    Verifica = "Vazio";
                }

                if (Verifica != "Vazio")
                {
                    Ficha fich = new Ficha();
                    fich.ShowDialog();
                }
            }    
        }

        private void Funcionarios_Load(object sender, EventArgs e)
        {
            SelectDataGrifd(this);
        }

        private void TxtCpf_Enter(object sender, EventArgs e)
        {
            if (TxtCpf.Text == "000.000.000-00")
            {
                TxtCpf.SelectionStart = 0;
                TxtCpf.SelectAll();

            }
        }

        private void TxtCpf_Click(object sender, EventArgs e)
        {
            if (TxtCpf.Text == "000.000.000-00")
            {
                TxtCpf.SelectionStart = 0;
                TxtCpf.SelectAll();

            }
        }

        private void psqFoto_Click(object sender, EventArgs e)
        {
        }
    }
}
