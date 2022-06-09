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
    public partial class Venda : Form
    {
        int tecla, idProd;
        decimal subTotal;
        decimal totalUni;
        decimal divida, totalGasto;

        string Divida;
        string TotalGasto, MostrarMessage;
        int i;
        string InsertIDprod, Insertprod, Insertquant, InsertvalUni, InsertTotalUni, InsertObsev;
        string adddivida;

        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private MySqlDataReader reader, reader1, reader2;
        private DataSet mDataSet;
        private MySqlCommand cmd, cmd1, cmd2;

        public Venda()
        {
            InitializeComponent();

            Program.IdSelected = "0";

            TxtFormaPaga.SelectedIndex = 0;

            mDataSet = new DataSet();
            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();

            MySqlCommand mAdapter = new MySqlCommand("SELECT IdProduto, NomeProduto FROM produtos WHERE NomeProduto <> 'Delete'", mConn);
            MySqlDataReader reader = mAdapter.ExecuteReader();//retorna dados resultantes da consulta em SQL
            DataTable table = new DataTable(); //estrutura da tabela do banco de dados ou de outra fonte de informação
            table.Load(reader); //carrega dados na tabela de acordo com a instrução sql passada 
            DataRow row = table.NewRow(); //representa uma linha de dados em um DataTable
            row["NomeProduto"] = ""; //para não gerar valor nulo e, consequentemente, evitar erro de execução

            this.TxtProduto.DataSource = table;
            this.TxtProduto.ValueMember = "IdProduto";
            this.TxtProduto.DisplayMember = "NomeProduto"; //obtem o nome do Produto
            reader.Close();//fecha o objeto
            reader.Dispose();//liberamos o objeto da memoria
            TxtProduto.SelectedIndex = -1;
        }

        private void TxtProduto_TextChanged(object sender, EventArgs e)
        {
            TxtQuant.Text = "1";
            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();
            string sql = "SELECT IdProduto, PrecoVenda FROM produtos WHERE NomeProduto <> 'Delete' and NomeProduto LIKE @Produto;";
            using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
            {
                cmd.Parameters.AddWithValue("@Produto", TxtProduto.Text);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TxtValorUni.Text = reader.GetString("PrecoVenda");
                    idProd = reader.GetInt16("IdProduto");
                }
                reader.Close();
            }         
        }

        private void TxtValorUni_TextChanged(object sender, EventArgs e)
        {
            if (TxtQuant.Text != "")
            {
                TxtTotalUni.Text = (Convert.ToDouble(TxtValorUni.Text) * Convert.ToDouble(TxtQuant.Text)).ToString("N2");
            }
        }

        private void TxtSubTotal_TextChanged(object sender, EventArgs e)
        {
            if(TxtQuantParcelas.Text == "I")
            {
                TxtValorParcelas.Text = (subTotal).ToString("N2");
            }
            else
            {
                TxtValorParcelas.Text = (Convert.ToDouble(TxtSubTotal.Text) / Convert.ToDouble(TxtQuantParcelas.Text)).ToString("N2");
            }
        }

        private void TxtQuantParcelas_TextChanged(object sender, EventArgs e)
        {
            if(TxtQuantParcelas.Text == "I")
            {
                TxtValorParcelas.Text = (subTotal).ToString("N2");
            }
            else
            if(TxtQuantParcelas.Text != "" && TxtQuantParcelas.Text != "0")
            {
                int count = GridItensCompra.Rows.Count;
                if(count > 0)
                {
                    BtnFinaliza.Enabled = true;
                }
                TxtValorParcelas.Text = (Convert.ToDouble(TxtSubTotal.Text) / Convert.ToDouble(TxtQuantParcelas.Text)).ToString("N2");

                int quant = Convert.ToInt16(TxtQuantParcelas.Text);
                tecla = quant;
                if (quant == 1)
                {
                    TxtFormaPaga.SelectedIndex = 0;
                }

                if (quant > 1)
                {
                    TxtFormaPaga.SelectedIndex = 1;
                }
            }
            if (TxtQuantParcelas.Text == "" || TxtQuantParcelas.Text == "0")
            {
                BtnFinaliza.Enabled = false;
                TxtFormaPaga.SelectedIndex = -1;
            }
            if (TxtQuantParcelas.Text == "I")
            {
                int count = GridItensCompra.Rows.Count;
                if (count > 0)
                {
                    BtnFinaliza.Enabled = true;
                }
                TxtFormaPaga.SelectedIndex = 2;
            }
        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            subTotal = subTotal + Convert.ToDecimal(TxtTotalUni.Text);
            TxtSubTotal.Text = Convert.ToString(subTotal);
       
            BtnFinaliza.Enabled = true;
            GridItensCompra.Rows.Add(idProd, TxtProduto.Text, TxtQuant.Text, TxtValorUni.Text, TxtTotalUni.Text, TxtObserv.Text);

            TxtProduto.SelectedIndex = -1;
            TxtQuant.Text = "1";
            TxtValorUni.Text = "0";
            TxtTotalUni.Text = "0";
            TxtObserv.Text = "";
        }

        private void TxtProduto_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtTotalUni_TextChanged(object sender, EventArgs e)
        {
            double val = Convert.ToDouble(TxtTotalUni.Text);
            if(val > 0)
            {
                BtnIncluir.Enabled = true;
            }
            if (val == 0)
            {
                BtnIncluir.Enabled = false;
            }
        }

        private void TxtValorUni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (TxtValorUni.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.IdSelected = "0";
        }

        private void Venda_KeyDown(object sender, KeyEventArgs e)
        {
            if (Program.venceu != "s")
            {
                if (e.KeyCode == Keys.F1)
                {
                    if (BtnFinaliza.Enabled == true)
                    {
                        BtnFinaliza_Click(sender, e);
                    }
                }
                if (e.KeyCode == Keys.F2)
                {
                    if (BtnSelectCliente.Enabled == true)
                    {
                        BtnSelectCliente_Click(sender, e);
                    }
                }
                if (e.KeyCode == Keys.F3)
                {
                    if (BtnIncluir.Enabled == true)
                    {
                        BtnIncluir_Click(sender, e);
                    }
                }
                if (e.KeyCode == Keys.F4)
                {
                    if (BtnExcluir.Enabled == true)
                    {
                        BtnExcluir_Click(sender, e);
                    }
                }
                if (e.KeyCode == Keys.F5)
                {
                    if (BtnCancel.Enabled == true)
                    {
                        BtnCancel_Click(sender, e);
                    }
                }     
            }
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TxtQuantParcelas_Enter(object sender, EventArgs e)
        {
            TxtQuantParcelas.SelectAll();
        }

        private void TxtQuantParcelas_Click(object sender, EventArgs e)
        {
            TxtQuantParcelas.SelectAll();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            subTotal = subTotal - totalUni;
            TxtSubTotal.Text = Convert.ToString(subTotal);

            GridItensCompra.Rows.RemoveAt(GridItensCompra.CurrentRow.Index);
            
            int count = GridItensCompra.Rows.Count;
            if (count == 0)
            {
                BtnFinaliza.Enabled = false;
                TxtSubTotal.Text = "0";
            }
            else
            {
                BtnFinaliza.Enabled = true;
            }
            BtnExcluir.Enabled = false;
        }

        private void GridItensCompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            totalUni = Convert.ToDecimal(GridItensCompra.CurrentRow.Cells[3].Value.ToString());
            BtnExcluir.Enabled = true;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Program.selecionar = "";
            this.Close();
        }

        private void BtnFinaliza_Click(object sender, EventArgs e)
        {
            string data = Convert.ToString(DateTime.Now.Day) + "/" + Convert.ToString(DateTime.Now.Month) + "/" + Convert.ToString(DateTime.Now.Year) + "  " + Convert.ToString(DateTime.Now.Hour) + ":" + Convert.ToString(DateTime.Now.Minute);

            int idVenda = 0;
            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();
            
            if(TxtFormaPaga.SelectedIndex == 0)
            {
                if(Program.IdSelected == "0")
                {
                    adddivida = "n";
                    MostrarMessage = "Sim";
                }
                if (Program.IdSelected != "0")
                {
                    adddivida = "s";
                    MostrarMessage = "Sim";

                    string sql = "SELECT DividaRestante, TotalGasto FROM dividas WHERE IdCLiente = @ID;";
                    using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
                    {
                        cmd.Parameters.AddWithValue("@ID", Program.IdSelected);
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            divida = reader.GetDecimal("DividaRestante");
                            totalGasto = reader.GetDecimal("TotalGasto");
                        }
                        reader.Close();
                    }

                    divida = divida + 0;
                    totalGasto = totalGasto + Convert.ToDecimal(TxtSubTotal.Text);

                    Divida = Convert.ToString(divida);
                    TotalGasto = Convert.ToString(totalGasto);

                    if (TxtFormaPaga.SelectedIndex == 1)
                    {
                        sql = "SELECT DividaRestante, TotalGasto FROM dividas WHERE IdCLiente LIKE @ID;";
                        using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
                        {
                            cmd.Parameters.AddWithValue("@ID", Program.IdSelected);
                            MySqlDataReader reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {
                                totalGasto = reader.GetDecimal("TotalGasto");
                            }
                            reader.Close();
                        }
                        totalGasto = totalGasto + Convert.ToDecimal(TxtSubTotal.Text);
                        TotalGasto = Convert.ToString(totalGasto);
                    }
                }
                divida = 0;
            }

            if (TxtFormaPaga.SelectedIndex == 1 || TxtFormaPaga.SelectedIndex == 2)
            {
                    string sql = "SELECT DividaRestante, TotalGasto FROM dividas WHERE IdCLiente = @ID;";
                    using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
                    {
                        cmd.Parameters.AddWithValue("@ID", Program.IdSelected);
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            divida = reader.GetDecimal("DividaRestante");
                            totalGasto = reader.GetDecimal("TotalGasto");
                        }
                        reader.Close();
                    }

                    divida = divida + Convert.ToDecimal(TxtSubTotal.Text);
                    totalGasto = totalGasto + Convert.ToDecimal(TxtSubTotal.Text);

                 Divida = Convert.ToString(divida);
                 TotalGasto = Convert.ToString(totalGasto);

                if (Program.IdSelected != "0")
                {
                    adddivida = "s";
                }
            }

            if(adddivida == "s")
            {
                string sql = "UPDATE `dividas` SET `DividaRestante`= @Divida, `TotalGasto`= @Gasto WHERE IdCLiente = @ID;";
                using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
                {
                    cmd.Parameters.AddWithValue("@ID", Program.IdSelected);
                    cmd.Parameters.AddWithValue("@Divida", Divida);
                    cmd.Parameters.AddWithValue("@Gasto", TotalGasto);
                    cmd.ExecuteNonQuery();
                }
            }

            string sql1 = "SELECT MAX(IdVenda) FROM vendas;";
            using (MySqlCommand cmd = new MySqlCommand(sql1, mConn))
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    try
                    {
                        idVenda = reader.GetInt16("MAX(IdVenda)");
                        idVenda = idVenda + 1;
                    }
                    catch(Exception ex)
                    {
                        idVenda = 1;
                    }           
                }
                reader.Close();
            }

            int count = GridItensCompra.Rows.Count;
       
            string sql2 = "INSERT INTO parcelas (IdCLiente, IdVenda, QuantParcelas, ValorParcelas, SubTotal, FormaPagamento) VALUES (@IdCLiente, @IdVenda, @QuantParcelas, @ValorParcelas, @SubTotal, @FormaPagamento);";
            using (MySqlCommand cmd = new MySqlCommand(sql2, mConn))
            {
                string parcelasquant = TxtQuantParcelas.Text;
                if (TxtQuantParcelas.Text == "I")
                {
                    parcelasquant = "Indefinido";
                }
                cmd.Parameters.AddWithValue("@IdCLiente", Program.IdSelected);
                cmd.Parameters.AddWithValue("@IdVenda", idVenda); 
                cmd.Parameters.AddWithValue("@QuantParcelas", parcelasquant);
                cmd.Parameters.AddWithValue("@ValorParcelas", TxtValorParcelas.Text);
                cmd.Parameters.AddWithValue("@SubTotal", TxtSubTotal.Text);
                cmd.Parameters.AddWithValue("@FormaPagamento", TxtFormaPaga.Text);
                cmd.ExecuteNonQuery();
            }

            do
            {
                InsertIDprod = GridItensCompra.Rows[i].Cells[0].Value.ToString();
                Insertprod = GridItensCompra.Rows[i].Cells[1].Value.ToString();
                Insertquant = GridItensCompra.Rows[i].Cells[2].Value.ToString();
                InsertvalUni = GridItensCompra.Rows[i].Cells[3].Value.ToString();
                InsertTotalUni = GridItensCompra.Rows[i].Cells[4].Value.ToString();
                InsertObsev = GridItensCompra.Rows[i].Cells[5].Value.ToString();
                i++;
                
                   string sql3 = "INSERT INTO vendas (IdVenda, IdProduto, IdCliente, Quant, ValorUni, TotalUni, Observações, DataVenda) VALUES (@IdVenda, @IdProduto, @IdCliente, @Quant, @ValorUni, @TotalUni, @Observações, @DataVenda);";
                   using (MySqlCommand cmd = new MySqlCommand(sql3, mConn))
                   {
                       cmd.Parameters.AddWithValue("@IdVenda", idVenda);
                       cmd.Parameters.AddWithValue("@IdProduto", InsertIDprod);
                       cmd.Parameters.AddWithValue("@IdCliente", Program.IdSelected);
                       cmd.Parameters.AddWithValue("@Quant", Insertquant);
                       cmd.Parameters.AddWithValue("@ValorUni", InsertvalUni);
                       cmd.Parameters.AddWithValue("@TotalUni", InsertTotalUni);
                       cmd.Parameters.AddWithValue("@Observações", InsertObsev);
                       cmd.Parameters.AddWithValue("@DataVenda", data);
                       cmd.ExecuteNonQuery();
                   }
                
            } while (i < count);

            if(MostrarMessage == "Sim")
            {
                Program.ValorTotal = Convert.ToDouble(subTotal);
                pagamenteRapido paga = new pagamenteRapido();
                paga.ShowDialog();
            }

            Program.IdSelected = "0";
            MostrarMessage = "";
            Divida = "0";
            idVenda = 0;
            TotalGasto = "0";
            TxtFormaPaga.Enabled = false;
            TxtFormaPaga.SelectedIndex = 0;
            TxtQuantParcelas.Text = "1";
            TxtQuantParcelas.Enabled = false;
            BtnFinaliza.Enabled = false;
            TxtProduto.SelectedIndex = -1;
            TxtQuant.Text = "1";
            TxtValorUni.Text = "0";
            TxtTotalUni.Text = "0";
            TxtSubTotal.Text = "0";
            TxtObserv.Text = "";
            TxtValorParcelas.Text = "0";
            GridItensCompra.DataSource = null;
            GridItensCompra.Rows.Clear();
            i = 0;
            count = 0;
            divida = 0;
            Divida = "0";
            totalGasto = 0;
            TotalGasto = "0";
            subTotal = 0;
        }

        private void TxtFormaPaga_TextChanged(object sender, EventArgs e)
        {
            if(TxtFormaPaga.Text == "À Vista")
            {
                TxtQuantParcelas.Text = "1";
            }
            if(TxtFormaPaga.Text == "Parcelado")
            {
                if(tecla == 2 || tecla < 2)
                {
                    TxtQuantParcelas.Text = "2";
                }
                else
                if(tecla > 2)
                {
                    TxtQuantParcelas.Text = Convert.ToString(tecla);
                }
            }
        }

        private void TxtQuant_TextChanged(object sender, EventArgs e)
        {
            if(TxtQuant.Text != "")
            {
                TxtTotalUni.Text = (Convert.ToDouble(TxtValorUni.Text) * Convert.ToDouble(TxtQuant.Text)).ToString("N2");
            }

        }

        private void Venda_Load(object sender, EventArgs e)
        {
            BtnClose.FlatAppearance.BorderSize = 0;
            BtnCancel.FlatAppearance.BorderSize = 0;
            BtnExcluir.FlatAppearance.BorderSize = 0;
            BtnIncluir.FlatAppearance.BorderSize = 0;
            BtnFinaliza.FlatAppearance.BorderSize = 0;
            BtnSelectCliente.FlatAppearance.BorderSize = 0;
            Program.IdSelected = "0";
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Program.selecionar = "";
            this.Close();
        }

        private void BtnSelectCliente_Click(object sender, EventArgs e)
        {
            Program.selecionar = "sim";
            this.Hide();
            PesqClientes pesq = new PesqClientes();
            pesq.Location = new Point(
            pesq.Left = Program.x,
            pesq.Top = Program.Y);
            pesq.ShowDialog();
            if(Program.IdSelected != "0")
            {
                TxtFormaPaga.Enabled = true;
                TxtQuantParcelas.Enabled = true;
            }
            if (Program.IdSelected == "0")
            {
                TxtFormaPaga.Enabled = false;
                TxtQuantParcelas.Enabled = false;
            }
            this.Show();
        }
    }
}
