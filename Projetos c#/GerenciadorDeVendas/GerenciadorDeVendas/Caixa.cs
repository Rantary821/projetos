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
    public partial class Caixa : Form
    {
        //string stringPesq = "SELECT f.Dia, SUM(i.Entrada), SUM(i.Saida), f.Total FROM caixainout i JOIN caixafecha f ON f.Dia = i.Dia";
        int count;
        int i;
        string dia, entrada, saida, total;
        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private MySqlDataReader reader, reader1, reader2;
        private DataSet mDataSet;
        private MySqlCommand cmd, cmd1, cmd2;

        private void Caixa_KeyDown(object sender, KeyEventArgs e)
        {
            if (Program.venceu != "s")
            {
                if (e.KeyCode == Keys.F1)
                {
                    BtnCancel_Click(sender, e);
                }
            }
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnConfirma_Click(object sender, EventArgs e)
        {
            MessageCaixa caixa = new MessageCaixa();
            caixa.ShowDialog();
        }

        public Caixa()
        {
            InitializeComponent();
        }

        private void Caixa_Load(object sender, EventArgs e)
        {
            BtnClose.FlatAppearance.BorderSize = 0;
            BtnCancel.FlatAppearance.BorderSize = 0;
            BtnConfirma.FlatAppearance.BorderSize = 0;

            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();
            string sql = "SELECT MAX(IdDat) FROM `caixafecha`;";
            using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    count = reader.GetInt16("MAX(IdDat)");
                }
                reader.Close();
            }

            i = 1;

            do
            {
                sql = "SELECT f.Dia, SUM(i.Entrada), SUM(i.Saida), f.Total FROM caixainout i JOIN caixafecha f ON f.Dia = i.Dia WHERE f.IdDat = @IdDat;";
                using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
                {
                    cmd.Parameters.AddWithValue("@IdDat", i);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        dia = reader.GetString("Dia");
                        entrada = reader.GetString("SUM(i.Entrada)");
                        saida = reader.GetString("SUM(i.Saida)");
                        total = reader.GetString("Total");
                    }
                    reader.Close();
                }

                i++;

                GridCaixa.Rows.Add(dia, entrada, saida, total);
            } while (i <= count);
        }
    }
}
