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
    public partial class configuracao : Form
    {
        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private DataSet mDataSet;

        string MConfig;

        public configuracao()
        {
            InitializeComponent();
            CheckConf2.Checked = false;
            CheckConf1.Checked = false;
            mDataSet = new DataSet();
            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();
            string sql = "SELECT NumeroPasta FROM `config`;";
            MySqlCommand cmd = new MySqlCommand(sql, mConn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                MConfig = reader.GetString("NumeroPasta");
            }
            mConn.Close();

            if (MConfig == "Config - 1")
            {
                CheckConf2.Checked = false;
                CheckConf1.Checked = true;
                groupBox2.Enabled = false;
            }
            else
            {
                CheckConf2.Checked = true;
                CheckConf1.Checked = false;
                groupBox2.Enabled = true;
            }
        }

        private void configuracao_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnPasta1_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            CheckConf2.Checked = false;
            CheckConf1.Checked = true;
            mDataSet = new DataSet();
            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();
            mAdapter = new MySqlDataAdapter("UPDATE `config` SET `NumeroPasta`= 'Config - 1';", mConn);
            mAdapter.Fill(mDataSet, "Tabela_dados");
            mDataSet.Clear();
        }

        private void BtnPasta2_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            CheckConf1.Checked = false;
            CheckConf2.Checked = true;
            mDataSet = new DataSet();
            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();
            mAdapter = new MySqlDataAdapter("UPDATE `config` SET `NumeroPasta` = 'Config - 2';", mConn);
            mAdapter.Fill(mDataSet, "Tabela_dados");
            mDataSet.Clear();
        }

        private void BtnManterSeq_Click(object sender, EventArgs e)
        {
            CheckNovaSeq.Checked = false;
            CheckMantSeq.Checked = true;
            mDataSet = new DataSet();
            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();
            mAdapter = new MySqlDataAdapter("UPDATE `config` SET `TrocaAno`= 'ManterSequencia';", mConn);
            mAdapter.Fill(mDataSet, "Tabela_dados");
            mDataSet.Clear();
        }

        private void BtnNovaSeq_Click(object sender, EventArgs e)
        {
            CheckNovaSeq.Checked = true;
            CheckMantSeq.Checked = false;
            mDataSet = new DataSet();
            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();
            mAdapter = new MySqlDataAdapter("UPDATE `config` SET `TrocaAno`= 'NovaSequencia';", mConn);
            mAdapter.Fill(mDataSet, "Tabela_dados");
            mDataSet.Clear();
        }

        private void CheckConf2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckConf1_CheckedChanged(object sender, EventArgs e)
        { 

        }

        private void configuracao_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(CheckConf2.Checked == true)
            {
                if(CheckMantSeq.Checked == true || CheckNovaSeq.Checked == true)
                {
                    e.Cancel = false;
                }
                else
                {
                    MessageBox.Show("Escolha uma opção para a sequencia da pasta!!");
                    e.Cancel = true;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
