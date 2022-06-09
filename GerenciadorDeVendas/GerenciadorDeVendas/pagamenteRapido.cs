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
    public partial class pagamenteRapido : Form
    {
        double resultado;
        string Dia, Hora, total;
        decimal entrada, saida;

        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private MySqlDataReader reader, reader1, reader2;
        private DataSet mDataSet;
        private MySqlCommand cmd, cmd1, cmd2;

        public pagamenteRapido()
        {
            InitializeComponent();
        }

        private void pagamenteRapido_Load(object sender, EventArgs e)
        {
            BtnOK.FlatAppearance.BorderSize = 0;
            TxtValorTotal.Text = (Program.ValorTotal).ToString("N2");
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            this.Close();

            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();
            string sql = "INSERT INTO caixainout(Dia, Hora, Entrada, Saida) VALUES (@Dia, @Hora, @In, @Out);";
            using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
            {
                cmd.Parameters.AddWithValue("@Dia", Dia);
                cmd.Parameters.AddWithValue("@Hora", Hora);
                cmd.Parameters.AddWithValue("@In", entrada);
                cmd.Parameters.AddWithValue("@Out", saida);
                cmd.ExecuteNonQuery();
            }

            double final = Convert.ToDouble(entrada) - Convert.ToDouble(saida);

            sql = "SELECT Total FROM caixafecha WHERE Dia = @Dia;";
            using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
            {
                cmd.Parameters.AddWithValue("@Dia", Dia);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    total = reader.GetString("Total");
                }
                reader.Close();
            }
            final = final + Convert.ToDouble(total);

            sql = "UPDATE caixafecha SET Total = @Total WHERE Dia = @Dia;";
            using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
            {
                cmd.Parameters.AddWithValue("@Total", (final).ToString("N2"));
                cmd.Parameters.AddWithValue("@Dia", Dia);
                cmd.ExecuteNonQuery();
            }
        }

        private void TxtValorRecebido_TextChanged(object sender, EventArgs e)
        {
            Dia = Convert.ToString(DateTime.Now.Day) + "/" + Convert.ToString(DateTime.Now.Month) + "/" + Convert.ToString(DateTime.Now.Year);
            Hora = Convert.ToString(DateTime.Now.Hour) + ":" + Convert.ToString(DateTime.Now.Minute);

            if (TxtValorRecebido.Text != "")
            {
                resultado = Convert.ToDouble(TxtValorTotal.Text) - Convert.ToDouble(TxtValorRecebido.Text);
                if (resultado == 0)
                {
                    TxtTroco.Text = "Dinheiro na quantidade certa!";
                    BtnOK.Enabled = true;
                    entrada = Convert.ToDecimal(TxtValorRecebido.Text);
                    saida = 0;                 
                }
                else
                    if (resultado > 0)
                {
                    double falta = resultado;
                    TxtTroco.Text = "Dinheiro insuficiente, faltam R$" + (falta).ToString("N2");
                    BtnOK.Enabled = false;
                }
                else
                    if (resultado < 0)
                {
                    resultado = resultado * -1;
                    TxtTroco.Text = "Dar troco de R$" + (resultado).ToString("N2") + " ao cliente";
                    BtnOK.Enabled = true;
                    entrada = Convert.ToDecimal(TxtValorRecebido.Text);
                    saida = Convert.ToDecimal((resultado).ToString("N2"));
                }
            }
            if (TxtValorRecebido.Text == "")
            {
                TxtTroco.Text = "Digite o valo recebido!";
                BtnOK.Enabled = false;
            }
        }
    }
}
