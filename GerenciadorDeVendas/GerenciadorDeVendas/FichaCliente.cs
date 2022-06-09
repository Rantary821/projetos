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
    public partial class FichaCliente : Form
    {
        double VP;
        string nome, cpf, rg, nasc, sexo, bairro, rua, numero, referencia, tel, cel;
        decimal divida;
        string resto;
        decimal saida, entrada;
        string total;

        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private MySqlDataReader reader, reader1, reader2;
        private DataSet mDataSet;
        private MySqlCommand cmd, cmd1, cmd2;

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {
            if (TxtNome.Text != nome)
            {
                BtnAtualizar.Enabled = true;
            }
            else
            {
                BtnAtualizar.Enabled = false;
            }
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            BtnAtualizar.Enabled = false;

            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();

            string sql = "UPDATE clientes SET Nome = @Nome, Cpf = @Cpf, Rg = @Rg, Nascimento = @Nascimento, Sexo = @Sexo, Bairro = @Bairro, Rua = @Rua, Numero = @Numero, Referencia = @Referencia, Telefone = @Telefone, Celular = @Celular WHERE IdCliente LIKE @Id;";
            using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
            {
                cmd.Parameters.AddWithValue("@Nome", TxtNome.Text);
                cmd.Parameters.AddWithValue("@Cpf", TxtCpf.Text);
                cmd.Parameters.AddWithValue("@Rg", TxtRg.Text);
                cmd.Parameters.AddWithValue("@Nascimento", TxtNasc.Text);
                cmd.Parameters.AddWithValue("@Sexo", ComboSexo.Text);
                cmd.Parameters.AddWithValue("@Bairro", TxtBairro.Text);
                cmd.Parameters.AddWithValue("@Rua", TxtRua.Text);
                cmd.Parameters.AddWithValue("@Numero", TxtNumero.Text);
                cmd.Parameters.AddWithValue("@Referencia", TxtReferencia.Text);
                cmd.Parameters.AddWithValue("@Telefone", TxtTel.Text);
                cmd.Parameters.AddWithValue("@Celular", TxtCel.Text);
                cmd.Parameters.AddWithValue("@Id", Program.IdSelected);
                cmd.ExecuteNonQuery();
            }

        }

        private void TxrValorPagar_TextChanged(object sender, EventArgs e)
        {
            if (TxtValorPagar.Text != "")
            {
                VP = Convert.ToDouble(TxtValorPagar.Text);
                BtnPagar.Enabled = true;
            }
            double VD = Convert.ToDouble(TxtdividaAtual.Text);
            if (VD < VP)
            {
                Lblrestante.Text = "Troco";
            }
            if (VD > VP)
            {
                Lblrestante.Text = "Valor Restante";
            }
            if (TxtValorPagar.Text != "")
            {
                TxtRestante.Text = Convert.ToString(divida - Convert.ToDecimal(TxtValorPagar.Text));
            }
            if (TxtValorPagar.Text == "")
            {
                TxtRestante.Text = "";
                BtnPagar.Enabled = false;
            }
            if (TxtValorPagar.Text == "0")
            {
                TxtRestante.Text = "";
                BtnPagar.Enabled = false;
            }
        }

        private void TxtValorPagar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (TxtValorPagar.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void BtnPagar_Click(object sender, EventArgs e)
        {
            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();

            string dia = Convert.ToString(DateTime.Now.Day) + "/" + Convert.ToString(DateTime.Now.Month) + "/" + Convert.ToString(DateTime.Now.Year);
            string hora = Convert.ToString(DateTime.Now.Hour) + ":" + Convert.ToString(DateTime.Now.Minute);

            resto = TxtRestante.Text;
            saida = 0;
            entrada = Convert.ToDecimal(TxtValorPagar.Text);

            if (Lblrestante.Text == "Troco")
            {
                MessageBox.Show("Dar troco de R$" + TxtRestante.Text + " ao cliente!");
                resto = "0";
                saida = Convert.ToDecimal(TxtRestante.Text);
            }

            string sql = "UPDATE `dividas` SET `DividaRestante`= @Divida WHERE IdCLiente = @ID;";
            using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
            {
                cmd.Parameters.AddWithValue("@ID", Program.IdSelected);
                cmd.Parameters.AddWithValue("@Divida", resto);
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

            TxtValorPagar.Text = "";
            TxtdividaAtual.Text = "0";

            sql = "SELECT d.DividaRestante FROM clientes c JOIN dividas d ON c.IdCliente = d.IdCLiente WHERE c.Nome <> 'Delete' AND d.DividaRestante > 0 AND c.IdCliente = @Id;";
            using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
            {
                cmd.Parameters.AddWithValue("@Id", Program.IdSelected);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TxtdividaAtual.Text = reader.GetString("DividaRestante");
                    divida = reader.GetDecimal("DividaRestante");
                }
            }
        }

        private void TxtRestante_TextChanged(object sender, EventArgs e)
        {
            if(TxtRestante.Text != "")
            {
                double VR = Convert.ToDouble(TxtRestante.Text);
                if (VR < 0)
                {
                    VR = VR * -1;
                    TxtRestante.Text = (VR).ToString("N2");
                }
            }       
        }

        private void FichaCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (Program.venceu != "s")
            {
                if (e.KeyCode == Keys.F1)
                {
                    BtnAtualizar_Click(sender, e);
                }
                if (e.KeyCode == Keys.F2)
                {
                    BtnPagar_Click(sender, e);
                }
                if (e.KeyCode == Keys.F3)
                {
                    BtnCancel_Click(sender, e);
                }
            }
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }
        }

        private void TxtdividaAtual_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtRg_TextChanged(object sender, EventArgs e)
        {
            if (TxtRg.Text != rg)
            {
                BtnAtualizar.Enabled = true;
            }
            else
            {
                BtnAtualizar.Enabled = false;
            }
        }

        private void TxtBairro_TextChanged(object sender, EventArgs e)
        {
            if (TxtBairro.Text != bairro)
            {
                BtnAtualizar.Enabled = true;
            }
            else
            {
                BtnAtualizar.Enabled = false;
            }
        }

        private void TxtRua_TextChanged(object sender, EventArgs e)
        {
            if (TxtRua.Text != rua)
            {
                BtnAtualizar.Enabled = true;
            }
            else
            {
                BtnAtualizar.Enabled = false;
            }
        }

        private void TxtNumero_TextChanged(object sender, EventArgs e)
        {
            if (TxtNumero.Text != numero)
            {
                BtnAtualizar.Enabled = true;
            }
            else
            {
                BtnAtualizar.Enabled = false;
            }
        }

        private void TxtReferencia_TextChanged(object sender, EventArgs e)
        {
            if (TxtReferencia.Text != referencia)
            {
                BtnAtualizar.Enabled = true;
            }
            else
            {
                BtnAtualizar.Enabled = false;
            }
        }

        private void TxtCpf_TextChanged(object sender, EventArgs e)
        {
            if (TxtCpf.Text != cpf)
            {
                BtnAtualizar.Enabled = true;
            }
            else
            {
                BtnAtualizar.Enabled = false;
            }
        }

        private void TxtNasc_TextChanged(object sender, EventArgs e)
        {
            if (TxtNasc.Text != nasc)
            {
                BtnAtualizar.Enabled = true;
            }
            else
            {
                BtnAtualizar.Enabled = false;
            }
        }

        private void ComboSexo_TextChanged(object sender, EventArgs e)
        {
            if (ComboSexo.Text != sexo)
            {
                BtnAtualizar.Enabled = true;
            }
            else
            {
                BtnAtualizar.Enabled = false;
            }
        }

        private void TxtTel_TextChanged(object sender, EventArgs e)
        {
            if (TxtTel.Text != tel)
            {
                BtnAtualizar.Enabled = true;
            }
            else
            {
                BtnAtualizar.Enabled = false;
            }
        }

        private void TxtCel_TextChanged(object sender, EventArgs e)
        {
            if (TxtCel.Text != cel)
            {
                BtnAtualizar.Enabled = true;
            }
            else
            {
                BtnAtualizar.Enabled = false;
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

        public FichaCliente()
        {
            InitializeComponent();

            BtnClose.FlatAppearance.BorderSize = 0;
            BtnAtualizar.FlatAppearance.BorderSize = 0;
            BtnCancel.FlatAppearance.BorderSize = 0;
            BtnAnterior.FlatAppearance.BorderSize = 0;
            BtnProximo.FlatAppearance.BorderSize = 0;
            BtnPagar.FlatAppearance.BorderSize = 0;
        }

        private void FichaCliente_Load(object sender, EventArgs e)
        {
          
            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();
            string sql = "SELECT Nome, Cpf, Rg, Nascimento, Sexo, Bairro, Rua, Numero, Referencia, Telefone, Celular FROM clientes WHERE IdCliente LIKE @Id;";
            using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
            {
                cmd.Parameters.AddWithValue("@Id", Program.IdSelected);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TxtNome.Text = reader.GetString("Nome");
                    TxtCpf.Text = reader.GetString("Cpf");
                    TxtRg.Text = reader.GetString("Rg");
                    TxtNasc.Text = reader.GetString("Nascimento");
                    ComboSexo.Text = reader.GetString("Sexo");
                    TxtBairro.Text = reader.GetString("Bairro");
                    TxtRua.Text = reader.GetString("Rua");
                    TxtNumero.Text = reader.GetString("Numero");
                    TxtReferencia.Text = reader.GetString("Referencia");
                    TxtTel.Text = reader.GetString("Telefone");
                    TxtCel.Text = reader.GetString("Celular");

                    nome = TxtNome.Text;
                    cpf = TxtCpf.Text;
                    rg = TxtRg.Text;
                    nasc = TxtNasc.Text;
                    sexo = ComboSexo.Text;
                    bairro = TxtBairro.Text;
                    rua = TxtRua.Text;
                    numero = TxtNumero.Text;
                    referencia = TxtReferencia.Text;
                    tel = TxtTel.Text;
                    cel = TxtCel.Text;
                }
                reader.Close();
            }
            BtnAtualizar.Enabled = false;

            mDataSet = new DataSet();

            mAdapter = new MySqlDataAdapter("SELECT p.NomeProduto, v.ValorUni, v.Quant, v.TotalUni FROM vendas v JOIN produtos p ON v.IdProduto = p.IdProduto JOIN clientes c ON c.IdCliente = v.IdCliente WHERE c.IdCliente = '" + Program.IdSelected + "'", mConn);
            mAdapter.Fill(mDataSet, "Tabela_dados");
            //atribui para o datagrid
            GridCompras.DataSource = mDataSet;
            GridCompras.DataMember = "Tabela_dados";
            GridCompras.Columns[0].Width = 220;
            GridCompras.Columns[1].Width = 130;
            GridCompras.Columns[2].Width = 110;
            GridCompras.Columns[0].HeaderText = "Produto";
            GridCompras.Columns[1].HeaderText = "Valor Uni";
            GridCompras.Columns[2].HeaderText = "Quantidade";

            GridCompras.RowHeadersWidth = 20;
            GridCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            GridCompras.ColumnHeadersHeight = 30;


            sql = "SELECT d.DividaRestante FROM clientes c JOIN dividas d ON c.IdCliente = d.IdCLiente WHERE c.Nome <> 'Delete' AND d.DividaRestante > 0 AND c.IdCliente = @Id;";
            using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
            {
                cmd.Parameters.AddWithValue("@Id", Program.IdSelected);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TxtdividaAtual.Text = reader.GetString("DividaRestante");
                    divida = reader.GetDecimal("DividaRestante");
                }
            }
        }
    }
}
