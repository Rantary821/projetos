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
using System.IO;

namespace SoaresTeste1
{
    public partial class Pesquisa : Form
    {
        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private MySqlDataReader reader;
        private MySqlCommand cmd;
        private DataSet mDataSet;
        private int ve;
        public Pesquisa()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void BuscarBanco(Control con)
        {
            try
            {
                utilidades uti = new utilidades();
                mConn = new MySqlConnection(uti.conexao);
                mConn.Open();
                string sql1 = "select `id`, `nome`, `rg`, `cpf`, `ra`, `sexo`, `dataNasc` from aluno where nome LIKE '" + txtNome.Text + "%'", sql2 = "select * from aluno where cpf LIKE '" + txtCpf.Text + "%'", sql3 = "select * from aluno where ra LIKE '" + txtRA.Text + "%'", sql4 = "select * from aluno";
                mDataSet = new DataSet();
                if (ve == 1)
                {
                    mAdapter = new MySqlDataAdapter(sql1, mConn);
                    mAdapter.Fill(mDataSet, "Tabela_dados");
                }
                else if (ve == 2)
                {
                    mAdapter = new MySqlDataAdapter(sql2, mConn);
                    mAdapter.Fill(mDataSet, "Tabela_dados");
                }
                else if (ve == 3)
                {
                    mAdapter = new MySqlDataAdapter(sql3, mConn);
                    mAdapter.Fill(mDataSet, "Tabela_dados");
                }
                else
                {
                    mAdapter = new MySqlDataAdapter(sql4, mConn);
                    mAdapter.Fill(mDataSet, "Tabela_dados");
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("" + e);
            }

            try {

                //atribui para o datagrid
                dataGri.DataSource = mDataSet;
                dataGri.DataMember = "Tabela_dados";

                dataGri.Columns[0].Width = 0;
                dataGri.Columns[1].Width = 300;
                dataGri.Columns[2].Width = 130;
                dataGri.Columns[3].Width = 130;
                dataGri.Columns[4].Width = 130;
                dataGri.Columns[5].Width = 120;
                dataGri.Columns[6].Width = 120;
                dataGri.Columns[0].HeaderText = "";
                dataGri.Columns[1].HeaderText = "Nome";
                dataGri.Columns[2].HeaderText = "RG";
                dataGri.Columns[3].HeaderText = "Cpf";
                dataGri.Columns[4].HeaderText = "Ra";
                dataGri.Columns[5].HeaderText = "Sexo";
                dataGri.Columns[6].HeaderText = "Nasc.";

                dataGri.RowHeadersWidth = 21;
                dataGri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
                dataGri.ColumnHeadersHeight = 23;

                mConn.Close();
            }catch(Exception e)
            {
                MessageBox.Show("" + e);
            }
        }
        private void btnPesq_Click(object sender, EventArgs e)
        {
            BuscarBanco(this);
        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            ve = 1;
        }

        private void txtRA_Enter(object sender, EventArgs e)
        {
            ve = 3;
        }

        private void txtCpf_Enter(object sender, EventArgs e)
        {
            ve = 2;
        }

        private void dataGri_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Program.id = dataGri.CurrentRow.Cells[0].Value.ToString();
            Program.nome = dataGri.CurrentRow.Cells[1].Value.ToString();
            Program.rg = dataGri.CurrentRow.Cells[2].Value.ToString();
            Program.cpf = dataGri.CurrentRow.Cells[3].Value.ToString();
            Program.ra = dataGri.CurrentRow.Cells[4].Value.ToString();
            Program.sexo = dataGri.CurrentRow.Cells[5].Value.ToString();
            Program.nasc = dataGri.CurrentRow.Cells[6].Value.ToString();

            string path = @"C:\Fotos\CodAluno.txt";
            string path2 = @"C:\Fotos\ImagemLocation.txt";

            File.Delete(path);

                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(Program.id);
                    sw.Dispose();
                }

            Ficha fich = new Ficha();

            this.Visible = false;
            fich.ShowDialog();
            dataGri.DataSource = null;
            this.Visible = true;

            File.Delete(path);
            File.Delete(path2);
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //Apertado o ENTER
            {
                btnPesq_Click(sender, e);
            }
        }

        private void txtCpf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //Apertado o ENTER
            {
                btnPesq_Click(sender, e);
            }
        }

        private void txtRA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //Apertado o ENTER
            {
                btnPesq_Click(sender, e);
            }
        }
    }
}
