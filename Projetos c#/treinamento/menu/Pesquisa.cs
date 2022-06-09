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

namespace menu
{
    public partial class Pesquisa : Form
    {
        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private MySqlDataReader reader;
        private DataSet mDataSet;
        private MySqlCommand cmd;
        private bool ve;
        public Pesquisa()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Pesquisa.ActiveForm.Close();
        }
        void BuscarBanco(Control con)
        {
            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();
            string sql1 = "select nome, sobrenome from aluno where nome LIKE '" + txtNome.Text + "%'", sql2 = "select nome, sobrenome from aluno where sobrenome LIKE '" + txtSobrenome.Text +"%'";
            mDataSet = new DataSet();
            if (ve)
            {
                mAdapter = new MySqlDataAdapter(sql1, mConn);
                mAdapter.Fill(mDataSet, "Tabela_dados");
            }
            else
            {
                mAdapter = new MySqlDataAdapter(sql2, mConn);
                mAdapter.Fill(mDataSet, "Tabela_dados");
            }

            //atribui para o datagrid
            dataGri.DataSource = mDataSet;
            dataGri.DataMember = "Tabela_dados";
            dataGri.Columns[0].Width = 200;
            dataGri.Columns[0].HeaderText = "Nome";
            dataGri.Columns[1].Width = 200;
            dataGri.Columns[1].HeaderText = "Sobrenome";
            mConn.Close();
        }

        private void btnPesq_Click(object sender, EventArgs e)
        {
            BuscarBanco(this);
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            ve = true;
        }

        private void txtSobrenome_TextChanged(object sender, EventArgs e)
        {
            ve = false;
        }
    }
}
