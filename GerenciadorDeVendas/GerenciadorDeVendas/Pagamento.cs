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
    public partial class Pagamento : Form
    {
        string stringPesq = "SELECT c.IdCliente, c.Nome, c.Cpf, d.DividaRestante, d.TotalGasto FROM clientes c JOIN dividas d ON c.IdCliente = d.IdCLiente WHERE c.Nome <> 'Delete' AND d.DividaRestante > 0";
        string divida, pago;
        decimal saida, entrada;
        string total;

        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private MySqlDataReader reader, reader1, reader2;
        private DataSet mDataSet;
        private MySqlCommand cmd, cmd1, cmd2;

        public Pagamento()
        {
            InitializeComponent();
            GridDividas.BringToFront();
        }

        void selectDividas(Control con)
        {
            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();
            mDataSet = new DataSet();
            //codigo SQL
            try
            {
                mAdapter = new MySqlDataAdapter(stringPesq, mConn);
                mAdapter.Fill(mDataSet, "Tabela_dados");
                //atribui para o datagrid
                GridDividas.DataSource = mDataSet;
                GridDividas.DataMember = "Tabela_dados";
                GridDividas.Columns[0].Width = 0;
                GridDividas.Columns[1].Width = 300;
                GridDividas.Columns[2].Width = 160;
                GridDividas.Columns[3].Width = 130;
                GridDividas.Columns[4].Width = 130;
                GridDividas.Columns[0].HeaderText = "";
                GridDividas.Columns[1].HeaderText = "Nome";
                GridDividas.Columns[2].HeaderText = "Cpf";
                GridDividas.Columns[3].HeaderText = "Divida Restante";
                GridDividas.Columns[4].HeaderText = "Total Gasto";

                GridDividas.RowHeadersWidth = 20;
                GridDividas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
                GridDividas.ColumnHeadersHeight = 30;
            }
            catch (Exception ex)
            {

            }
        }

        private void GridDividas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Program.IdSelected = GridDividas.CurrentRow.Cells[0].Value.ToString();
            FichaCliente fich = new FichaCliente();
            this.Hide();
            fich.ShowDialog();
            selectDividas(this);
            this.Show();
        }

        private void GridDividas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Program.IdSelected = GridDividas.CurrentRow.Cells[0].Value.ToString();
            divida = GridDividas.CurrentRow.Cells[3].Value.ToString();
            TxtPagar.Enabled = true;
            TxtPagar.Text = "";
            TxtResto.Text = "";
        }

        private void TxtPagar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (TxtPagar.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void Pagamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (Program.venceu != "s")
            {
                if (e.KeyCode == Keys.F1)
                {
                    BtnPagar_Click(sender, e);
                }
                if (e.KeyCode == Keys.F2)
                {
                    BtnCancel_Click(sender, e);
                } 
            }
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }
        }

        private void TxtResto_TextChanged(object sender, EventArgs e)
        {
            if (TxtResto.Text != "")
            {
                double VR = Convert.ToDouble(TxtResto.Text);
                if (VR < 0)
                {
                    VR = VR * -1;
                    TxtResto.Text = (VR).ToString("N2");
                    LblRestante.Text = "Troco";
                }
                else
                    if(VR > 0)
                {
                    LblRestante.Text = "Restante";
                }
            }
        }

        private void BtnPagar_Click(object sender, EventArgs e)
        {
            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();

            saida = 0;
            entrada = Convert.ToDecimal(TxtPagar.Text);
            string dia = Convert.ToString(DateTime.Now.Day) + "/" + Convert.ToString(DateTime.Now.Month) + "/" + Convert.ToString(DateTime.Now.Year);
            string hora = Convert.ToString(DateTime.Now.Hour) + ":" + Convert.ToString(DateTime.Now.Minute);

            string Restante = TxtResto.Text;

            if (LblRestante.Text == "Troco")
            {
                MessageBox.Show("Dar troco de R$" + TxtResto.Text + " ao cliente!");
                Restante = "0";
                saida = Convert.ToDecimal(TxtResto.Text);
            }
            
            string sql = "UPDATE `dividas` SET `DividaRestante`= @Divida WHERE IdCLiente = @ID;";
            using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
            {
                cmd.Parameters.AddWithValue("@ID", Program.IdSelected);
                cmd.Parameters.AddWithValue("@Divida", Restante);
                cmd.ExecuteNonQuery();
            }

            sql = "INSERT INTO caixainout(Dia, Hora, Entrada, Saida) VALUES (@Dia, @Hora, @In, @Out);";
            using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
            {
                cmd.Parameters.AddWithValue("@Dia", dia);
                cmd.Parameters.AddWithValue("@Hora", hora);
                cmd.Parameters.AddWithValue("@In", entrada);
                cmd.Parameters.AddWithValue("@Out", saida);
                cmd.ExecuteNonQuery();
            }
            double final = Convert.ToDouble(entrada) - Convert.ToDouble(saida);

            sql = "SELECT Total FROM caixafecha WHERE Dia = @Dia;";
            using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
            {
                cmd.Parameters.AddWithValue("@Dia", dia);
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
                cmd.Parameters.AddWithValue("@Dia", dia);
                cmd.ExecuteNonQuery();
            }

            TxtResto.Text = "";
            TxtPagar.Text = "";
            TxtPagar.Enabled = false;
            BtnPagar.Enabled = false;
            selectDividas(this);
        }

        private void TxtPagar_TextChanged(object sender, EventArgs e)
        {
            if (TxtPagar.Text != "" && TxtPagar.Text != "0")
            {
                    TxtResto.Text = Convert.ToString(Convert.ToDouble(divida) - Convert.ToDouble(TxtPagar.Text));
            }         
            if (TxtPagar.Text != "0")
            {
                BtnPagar.Enabled = true;
            }
            if (TxtPagar.Text == "")
            {
                BtnPagar.Enabled = false;
                TxtResto.Text = "";
            }
            if (TxtPagar.Text == "0")
            {
                BtnPagar.Enabled = false;
                TxtResto.Text = "";
            }
        }

        private void Pagamento_Load(object sender, EventArgs e)
        {
            BtnClose.FlatAppearance.BorderSize = 0;
            BtnCancel.FlatAppearance.BorderSize = 0;
            selectDividas(this);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
