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
    public partial class MessageCaixa : Form
    {
        int id;
        string vallor;
        string dia, valorfecha, dat = Convert.ToString(DateTime.Now.Day) + "/" + Convert.ToString(DateTime.Now.Month) + "/" + Convert.ToString(DateTime.Now.Year);
        string hora = Convert.ToString(DateTime.Now.Hour) + ":" + Convert.ToString(DateTime.Now.Minute);
        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private MySqlDataReader reader, reader1, reader2;
        private DataSet mDataSet;
        private MySqlCommand cmd, cmd1, cmd2;

        private void MessageCaixa_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public MessageCaixa()
        {
            InitializeComponent();
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            vallor = TxtValorInicial.Text;

            if(TxtValorInicial.Text == "")
            {
                vallor = "0";
            }
            if (TxtValorInicial.Text == "0")
            {
                vallor = "0";
            }

            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();
            string sql = "UPDATE caixafecha SET Total = @Total WHERE Dia = @Dia;";
            using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
            {
                cmd.Parameters.AddWithValue("@Total", vallor);
                cmd.Parameters.AddWithValue("@Dia", dat);
                cmd.ExecuteNonQuery();
            }

            sql = "UPDATE `caixainout` SET `Entrada`= @In,`Saida`= @Out,`Hora`= @Hora WHERE `Dia`= @Dia;";
            using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
            {
                cmd.Parameters.AddWithValue("@Dia", dat);
                cmd.Parameters.AddWithValue("@Hora", "Abriu");
                cmd.Parameters.AddWithValue("@In", vallor);
                cmd.Parameters.AddWithValue("@Out", 0);
                cmd.ExecuteNonQuery();
            }
            this.Close();

        }

        private void MessageCaixa_Load(object sender, EventArgs e)
        {
            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();
            string sql = "SELECT max(IdDat) FROM caixafecha;";
            using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetInt16("max(IdDat)");
                }
                id = id - 1;
                reader.Close();
            }
            if(id >= 1)
            {
                sql = "SELECT f.Dia, f.Total FROM caixafecha f WHERE f.IdDat = @IdDat;";
                using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
                {
                    cmd.Parameters.AddWithValue("@IdDat", id);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        dia = reader.GetString("Dia");
                        valorfecha = reader.GetString("Total");
                    }
                    reader.Close();
                }

                TxtMensagem.Text = "No Dia " + dia + ", o caixa fechou em R$" + valorfecha;
                TxtValorInicial.Text = valorfecha;
            }
            if(id == 0)
            {
                TxtMensagem.Text = "Primeiro Registro";
                TxtValorInicial.Text = "0";
            }
        }
    }
}
