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

namespace WindowsFormsApplication2
{
    public partial class Vendas : Form
    {
        int countRows, RowsSelected;
        string selectgrid, CompraFinalizada, cchecked;
        string ClickQuant, ClickValor;
        string InsertProd, InsertPrecototal, InsertUni, InsertQuant, InsertDetelhes, InsertIdCLiente, InsertIdVenda, InsertForma, InsertDivida;

        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private MySqlDataReader reader, reader1, reader2;
        private DataSet mDataSet;
        private MySqlCommand cmd, cmd1, cmd2;

        public Vendas()
        {
            InitializeComponent();
            selectgrid = "SELECT idCliente, Nome, Cpf FROM `clientes` WHERE Nome <> 'Excluido'";
            SelectDataGrid(this);
        }

        void SelectDataGrid(Control con)
        {
            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();
            mDataSet = new DataSet();
            //codigo SQL
            try
            {
                mAdapter = new MySqlDataAdapter(selectgrid, mConn);
                mAdapter.Fill(mDataSet, "Tabela_dados");
                //atribui para o datagrid
                GridClientes.DataSource = mDataSet;
                GridClientes.DataMember = "Tabela_dados";
                GridClientes.Columns[0].Width = 0;
                GridClientes.Columns[1].Width = 258;
                GridClientes.Columns[2].Width = 108;
                GridClientes.Columns[0].HeaderText = "";
                GridClientes.Columns[1].HeaderText = "Nome";
                GridClientes.Columns[2].HeaderText = "Cpf";
                GridClientes.RowHeadersWidth = 20;
                GridClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
                GridClientes.ColumnHeadersHeight = 30;

            }
            catch (Exception ex)
            {
                Program.LblMessage = "Um erro ocorreu!";
                Program.PicInterrog = "0";
                Program.PicAlert = "0";
                Program.PicVendaOK = "0";
                Program.PicError = "1";
                Program.btnNao = "0";
                Program.btnSim = "0";
                Program.btnOk = "1";

                FormMessageBox message = new FormMessageBox();
                message.ShowDialog();
            }
            mConn.Close();
        }

        private void CheckVista_CheckedChanged(object sender, EventArgs e)
        {
            if(CompraFinalizada != "Y")
            {
                if(cchecked != "y")
                {
                    if (CheckVista.Checked == true)
                    {
                        CheckVista.Checked = true;
                        CheckPrazo.Checked = false;
                    }
                    if (CheckVista.Checked == false)
                    {
                        CheckVista.Checked = false;
                        CheckPrazo.Checked = true;
                    }
                    GroupCompra1.Enabled = true;
                    GroupCompra2.Enabled = true;
                }              
            }       
        }

        private void CheckPrazo_CheckedChanged(object sender, EventArgs e)
        {
            if(CompraFinalizada != "Y")
            {
                if(cchecked != "y")
                {
                    if (CheckPrazo.Checked == true)
                    {
                        CheckVista.Checked = false;
                        CheckPrazo.Checked = true;
                    }
                    if (CheckPrazo.Checked == false)
                    {
                        CheckVista.Checked = true;
                        CheckPrazo.Checked = false;
                    }
                    GroupCompra1.Enabled = true;
                    GroupCompra2.Enabled = true;
                }       
            } 
        }

        private void ComboProduto_Enter(object sender, EventArgs e)
        {
            mDataSet = new DataSet();
            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();

            MySqlCommand mAdapter = new MySqlCommand("SELECT * FROM `produtos` ORDER by nomeProduto DESC", mConn);
            MySqlDataReader reader = mAdapter.ExecuteReader();//retorna dados resultantes da consulta em SQL
            DataTable table = new DataTable(); //estrutura da tabela do banco de dados ou de outra fonte de informação
            table.Load(reader); //carrega dados na tabela de acordo com a instrução sql passada 
            DataRow row = table.NewRow(); //representa uma linha de dados em um DataTable
            row["nomeProduto"] = ""; //para não gerar valor nulo e, consequentemente, evitar erro de execução


            this.ComboProduto.DataSource = table;
            this.ComboProduto.ValueMember = "idProduto";
            this.ComboProduto.DisplayMember = "nomeProduto";//obtem o nome do curso
            reader.Close();//fecha o objeto
            reader.Dispose();//liberamos o objeto da memoria
            ComboProduto.SelectedIndex = - 1;
            TxtPrecoUni.Text = "";
        }

        private void ComboProduto_TextChanged(object sender, EventArgs e)
        {
            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();
            string sql = "SELECT preco FROM `produtos` WHERE nomeProduto = @nomeProduto;";
            using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
            {
                cmd.Parameters.AddWithValue("@nomeProduto", ComboProduto.Text);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TxtPrecoUni.Text = reader.GetString("preco");
                }
                reader.Close();
            }
        }

        void ClearAllText(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                if (c is RadioButton)
                    ((RadioButton)c).Checked = false;
                if (c is MaskedTextBox)
                    ((MaskedTextBox)c).Clear();
                else
                    ClearAllText(c);
            }  
        }

        private void CheckSemCadastro_CheckedChanged(object sender, EventArgs e)
        {
            if(CompraFinalizada != "Y")
            {
                if (CheckSemCadastro.Checked == true)
                {
                    ClearAllText(this);
                    TxtValorTotal.Text = "0,00";
                    TxtValorFinal.Text = "0,00";
                    TxtQuantTotal.Text = "0";
                    TxtQuant.Text = "1";
                    LblSelecione.Visible = false;
                    CheckComCadastro.Checked = false;
                    GroupFormaPagemento.Enabled = false;
                    GroupCompra1.Enabled = true;
                    GroupCompra2.Enabled = true;
                    CheckVista.Checked = true;
                    CheckPrazo.Checked = false;
                }
                if (CheckSemCadastro.Checked == false)
                {
                    ClearAllText(this);
                    TxtValorTotal.Text = "0,00";
                    TxtValorFinal.Text = "0,00";
                    TxtQuantTotal.Text = "0";
                    TxtQuant.Text = "1";
                    CheckComCadastro.Checked = true;
                    GroupFormaPagemento.Enabled = false;
                    GroupCompra1.Enabled = false;
                    GroupCompra2.Enabled = false;
                    CheckVista.Checked = false;
                    CheckPrazo.Checked = false;
                }
            }
            
        }

        private void TxtPrecoUni_TextChanged(object sender, EventArgs e)
        {
            decimal preco, quant;
            if(TxtPrecoUni.Text != "" && TxtQuant.Text != "")
            {
                preco = Convert.ToDecimal(TxtPrecoUni.Text);
                quant = Convert.ToDecimal(TxtQuant.Text);
                TxtValorTotal.Text = Convert.ToString(preco * quant);
            }
            else
                if(TxtPrecoUni.Text != "" || TxtQuant.Text != "")
            {
                TxtValorTotal.Text = "0,00";
            }
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            BtnRemover.Enabled = false;
            BtnFinalizarCompra.Enabled = true;
           /* int numRows = GridVendas.RowCount;
            if(numRows == 0)
            {
                countRows = 0;
            }
            else
            {
                countRows = countRows + 1;
            }*/

            GridVendas.Rows.Add(ComboProduto.Text, TxtPrecoUni.Text, TxtQuant.Text, TxtValorTotal.Text, TxtDetalhes.Text);

            double soma = Convert.ToDouble(TxtValorFinal.Text) + Convert.ToDouble(TxtValorTotal.Text);
            int quanti = Convert.ToInt16(TxtQuantTotal.Text) + Convert.ToInt16(TxtQuant.Text);
            ClearAllText(this);
            TxtValorTotal.Text = "0,00";
            TxtQuant.Text = "1";
            TxtQuantTotal.Text = Convert.ToString(quanti);
            TxtValorFinal.Text = Convert.ToString(soma);
            ComboProduto.SelectedIndex = -1;     
        }

        private void TxtNomePesq_TextChanged(object sender, EventArgs e)
        {
            selectgrid = "SELECT idCliente, Nome, Cpf Numero FROM `clientes` WHERE Nome like '" + TxtNomePesq.Text + "%'";
            SelectDataGrid(this);
        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            BtnRemover.Enabled = false;
            TxtValorFinal.Text = Convert.ToString(Convert.ToDouble(TxtValorFinal.Text) - Convert.ToDouble(ClickValor));
            TxtQuantTotal.Text = Convert.ToString(Convert.ToInt16(TxtQuantTotal.Text) - Convert.ToInt16(ClickQuant));
            GridVendas.Rows.RemoveAt(GridVendas.CurrentRow.Index);
            ClickQuant = "0";
            ClickValor = "0";
            int count = GridVendas.Rows.Count;
            if(count == 0)
            {
                BtnFinalizarCompra.Enabled = false;
            }
            else
            {
                BtnFinalizarCompra.Enabled = true;
            }
        }

        private void BtnFinalizarCompra_Click(object sender, EventArgs e)
        {
            if(CheckVista.Checked == false && CheckPrazo.Checked == false)
            {
                Program.LblMessage = "Selecione uma forma de pagamento!";
                Program.PicInterrog = "0";
                Program.PicAlert = "1";
                Program.PicVendaOK = "0";
                Program.PicError = "0";
                Program.btnNao = "0";
                Program.btnSim = "0";
                Program.btnOk = "1";

                FormMessageBox message = new FormMessageBox();
                message.ShowDialog();
            }
            else
            {
                string data = Convert.ToString(DateTime.Now.Day) + "/" + Convert.ToString(DateTime.Now.Month) + "/" + Convert.ToString(DateTime.Now.Year) + "  " + Convert.ToString(DateTime.Now.Hour) + ":" + Convert.ToString(DateTime.Now.Minute);
                BtnFinalizarCompra.Enabled = false;
                BtnRemover.Enabled = false;
                mConn = new MySqlConnection(Program.conexao);
                mConn.Open();
                int count = GridVendas.Rows.Count;

                if (CheckSemCadastro.Checked == true)
                {
                    InsertIdCLiente = "0";
                    InsertIdVenda = "0";
                    InsertForma = "Vista";
                }
                if (CheckComCadastro.Checked == true)
                {
                    if (CheckVista.Checked == true)
                    {
                        InsertForma = "Vista";
                    }

                    if (CheckPrazo.Checked == true)
                    {
                        InsertForma = "Prazo"; 

                        mConn = new MySqlConnection(Program.conexao);
                        mConn.Open();
                        string sql = "SELECT Divida FROM `clientes` WHERE idCliente = @idCliente;";
                        using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
                        {
                            cmd.Parameters.AddWithValue("@idCliente", InsertIdCLiente);
                            MySqlDataReader reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {
                                InsertDivida = reader.GetString("Divida");
                                InsertDivida = Convert.ToString(Convert.ToDouble(InsertDivida) + Convert.ToDouble(TxtValorFinal.Text));
                            }
                            reader.Close();
                        }

                        sql = "UPDATE `clientes` SET `Divida`= @Divida WHERE idCliente = @idCliente;";
                        using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
                        {
                            cmd.Parameters.AddWithValue("@Divida", InsertDivida);
                            cmd.Parameters.AddWithValue("@idCliente", InsertIdCLiente);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                int i = 0;
                do
                {
                    InsertProd = GridVendas.Rows[i].Cells[0].Value.ToString();
                    InsertUni = GridVendas.Rows[i].Cells[1].Value.ToString();
                    InsertQuant = GridVendas.Rows[i].Cells[2].Value.ToString();
                    InsertPrecototal = GridVendas.Rows[i].Cells[3].Value.ToString();
                    InsertDetelhes = GridVendas.Rows[i].Cells[4].Value.ToString();
                    i++;
                    string sql = "INSERT INTO vendas (idCliente, Produto, idVenda, PrecoUni, quant, Detalhes, ValorTotal, DataCompra, Forma) VALUES (@idcliente, @prod, @idvenda, @precouni, @quant, @detalhes, @valortotal, @data, @Forma);";
                    using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
                    {
                        cmd.Parameters.AddWithValue("@idcliente", InsertIdCLiente);
                        cmd.Parameters.AddWithValue("@idvenda", InsertIdVenda);
                        cmd.Parameters.AddWithValue("@prod", InsertProd);
                        cmd.Parameters.AddWithValue("@precouni", InsertUni);
                        cmd.Parameters.AddWithValue("@quant", InsertQuant);
                        cmd.Parameters.AddWithValue("@detalhes", InsertDetelhes);
                        cmd.Parameters.AddWithValue("@valortotal", InsertPrecototal);
                        cmd.Parameters.AddWithValue("@data", data);
                        cmd.Parameters.AddWithValue("@Forma", InsertForma);
                        cmd.ExecuteNonQuery();
                    }
                } while (i < count);

                Program.LblMessage = "Venda efetuada com sucesso!";
                Program.PicVendaOK = "1";
                Program.PicInterrog = "0";
                Program.PicAlert = "0";
                Program.PicError = "0";
                Program.btnNao = "0";
                Program.btnSim = "0";
                Program.btnOk = "1";

                FormMessageBox message = new FormMessageBox();
                message.ShowDialog();
               
                GridVendas.DataSource = null;
                GridVendas.Rows.Clear();
                GroupCompra1.Enabled = false;
                GroupCompra2.Enabled = false;
                GroupFormaPagemento.Enabled = false;
                GridClientes.Enabled = false;
                CompraFinalizada = "Y";
                CheckVista.Checked = false;
                CheckPrazo.Checked = false;
                CheckComCadastro.Checked = false;
                CheckSemCadastro.Checked = false;
                CompraFinalizada = "N";
                TxtQuantTotal.Text = "0";
                TxtValorFinal.Text = "0,00";
            }
        }

        private void GridVendas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClickQuant = GridVendas.CurrentRow.Cells[2].Value.ToString();
            ClickValor = GridVendas.CurrentRow.Cells[3].Value.ToString();
            BtnRemover.Enabled = true;        

        }

        private void TxtCpfPesq_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            selectgrid = "SELECT idCliente, Nome, Cpf Numero FROM `clientes` WHERE Cpf like '" + TxtCpfPesq.Text + "%'";
            SelectDataGrid(this);
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            ClearAllText(this);
            TxtValorTotal.Text = "0,00";
            TxtValorFinal.Text = "0,00";
            TxtQuantTotal.Text = "0";
            TxtQuant.Text = "1";
            ComboProduto.SelectedIndex = -1;
        }

        private void TxtQuant_TextChanged(object sender, EventArgs e)
        {
            decimal preco, quant;
            if (TxtPrecoUni.Text != "" && TxtQuant.Text != "")
            {
                preco = Convert.ToDecimal(TxtPrecoUni.Text);
                quant = Convert.ToDecimal(TxtQuant.Text);
                TxtValorTotal.Text = Convert.ToString(preco * quant);
            }
            else
                if (TxtPrecoUni.Text != "" || TxtQuant.Text != "")
            {
                TxtValorTotal.Text = "0,00";
            }
        }

        private void GridClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            InsertIdCLiente = GridClientes.CurrentRow.Cells[0].Value.ToString();
            InsertIdVenda = InsertIdCLiente;
            LblSelecione.Visible = false;
            GroupFormaPagemento.Enabled = true;
            GroupCompra1.Enabled = false;
            GroupCompra2.Enabled = false;
        }

        private void CheckComCadastro_CheckedChanged(object sender, EventArgs e)
        {
            if (CompraFinalizada != "Y")
            {
                if (CheckComCadastro.Checked == true)
                {
                    ClearAllText(this);
                    TxtValorTotal.Text = "0,00";
                    TxtValorFinal.Text = "0,00";
                    TxtQuantTotal.Text = "0";
                    TxtQuant.Text = "1";
                    CheckSemCadastro.Checked = false;
                    LblSelecione.Visible = true;
                    GridClientes.Enabled = true;
                    GroupCompra1.Enabled = false;
                    GroupCompra2.Enabled = false;
                    cchecked = "y";
                    CheckVista.Checked = false;
                    CheckPrazo.Checked = false;
                    cchecked = "n";
                }
                if (CheckComCadastro.Checked == false)
                {
                    ClearAllText(this);
                    TxtValorTotal.Text = "0,00";
                    TxtValorFinal.Text = "0,00";
                    TxtQuantTotal.Text = "0";
                    TxtQuant.Text = "1";
                    GridClientes.Enabled = false;
                    CheckSemCadastro.Checked = true;
                    GroupFormaPagemento.Enabled = false;
                    GroupCompra1.Enabled = false;
                    GroupCompra2.Enabled = false;
                }
            }           
        }
    }
}
