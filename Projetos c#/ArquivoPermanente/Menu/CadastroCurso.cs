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

namespace Menu
{
    public partial class CadastroCurso : Form
    {

        public CadastroCurso()
        {
            InitializeComponent();
            mDataSet = new DataSet();
            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();
            mAdapter = new MySqlDataAdapter("select * from curso", mConn);
            mAdapter.Fill(mDataSet, "Tabela_dados");
            //atribui para o datagrid
            dataGridPesq.DataSource = mDataSet;
            dataGridPesq.DataMember = "Tabela_dados";
            dataGridPesq.Columns[1].Width = 300;
            dataGridPesq.Columns[1].HeaderText = "Nome do Curso";
        }
        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private DataSet mDataSet;
        int contador;
        private void txtNomeCurso_Click(object sender, EventArgs e)
        {

        }




        private void txtNomeCurso_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        internal static CadastroCurso retornaInstancia()
        {
            throw new NotImplementedException();
        }

        private void btnCons_Click(object sender, EventArgs e)
        {
        }

        private void btnCanc_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void btnCad_Click(object sender, EventArgs e)
        {

            mDataSet = new DataSet();
            mConn = new MySqlConnection(Program.conexao);
            string sql = "select * from curso;";
            MySqlCommand cmd = new MySqlCommand(sql, mConn);
            mConn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                contador = reader.GetInt16("idCurso");
                contador = contador + 1;
            }
            reader.Close();
            mConn.Close();
            mConn.Open();
            mAdapter = new MySqlDataAdapter("insert into curso (idCurso, nomeCurso) values ("+contador+", '"+txtNomeCurso.Text+"')", mConn);
            mAdapter.Fill(mDataSet, "Tabela_dados");
            ClearAllText(this);
            mAdapter = new MySqlDataAdapter("select * from curso", mConn);
            mAdapter.Fill(mDataSet, "Tabela_dados");
            //atribui para o datagrid
            dataGridPesq.DataSource = mDataSet;
            dataGridPesq.DataMember = "Tabela_dados";
            dataGridPesq.Columns[1].Width = 300;
            dataGridPesq.Columns[1].HeaderText = "Nome do Curso";
            mConn.Close();
        }

        private void btnExc_Click(object sender, EventArgs e)
        {
            mDataSet = new DataSet();
            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();
            try
            {
                mAdapter = new MySqlDataAdapter("DELETE FROM curso where idCurso = " + Program.xxx + "", mConn);
                mAdapter.Fill(mDataSet, "Tabela_dados");
            }catch (MySqlException ex)
            {
                MessageBox.Show("erro:"+ex);
            }
            mAdapter = new MySqlDataAdapter("select * from curso", mConn);
            mAdapter.Fill(mDataSet, "Tabela_dados");
            //atribui para o datagrid
            dataGridPesq.DataSource = mDataSet;
            dataGridPesq.DataMember = "Tabela_dados";
            dataGridPesq.Columns[1].Width = 300;
            dataGridPesq.Columns[1].HeaderText = "Nome do Curso";
        }

        private void dataGridPesq_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Program.xxx = dataGridPesq.CurrentRow.Cells[0].Value.ToString();

        }

        private void CadastroCurso_Load(object sender, EventArgs e)
        {

        }
    }
}
