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

namespace Menu_Principal
{
    public partial class Config : Form
    {
        #region variaveis
        double  id, IdBusca, qnt;
        private MySqlCommand cmd;
        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private MySqlDataReader reader;
        string nome, rg, cpf, ra, dataNasc, sexo,emaill,tell,cell,email2,tell2,cell2;

        private void button3_Click(object sender, EventArgs e)
        {
            utilidades uti = new utilidades();
            try
            {
                mConn = new MySqlConnection(uti.conexao);
                mConn.Open();
                string sql = "TRUNCATE `aluno`";
                string sql1 = "truncate dados";
                using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
                {
                    cmd.ExecuteNonQuery();
                }
                using (MySqlCommand cmd = new MySqlCommand(sql1, mConn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao se comunicar com o Banco");
            }
        }
        #endregion

        #region changeCheck
        private void rad200_CheckedChanged(object sender, EventArgs e)
        {
            qnt = 200;
        }

        private void rad250_CheckedChanged(object sender, EventArgs e)
        {
            qnt = 250;
        }

        private void rad300_CheckedChanged(object sender, EventArgs e)
        {
            qnt = 300;
        }

        private void rad150_CheckedChanged(object sender, EventArgs e)
        {
            qnt = 150;
        }

        private void rad100_CheckedChanged(object sender, EventArgs e)
        {
            qnt = 100;
        }
         private void rad50_CheckedChanged(object sender, EventArgs e)
        {
            qnt = 50;
        }
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Config()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
       
            utilidades uti = new utilidades();

            for (int i = 0; i <= qnt; i++) {

                uti.selectIdAluno();
                id = uti.idd;
                nome = "teste" + id;
                emaill = "teste@" + id;
                cell = "500-" + id;
                tell = "500-" + id;
                uti.cadastraAluno(Convert.ToInt16(id),nome,rg, cpf,  ra,  dataNasc,  sexo,emaill,tell,cell,emaill,tell,cell);
                try
                {
                    mConn = new MySqlConnection(uti.conexao);
                    mConn.Open();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao se comunicar com o Banco");
                }          
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
                uti.ClearAllText(this);
                id++;
            }
        }
    }
}
