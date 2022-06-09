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
    public partial class MenuP : Form
    {
        string Click, Link;
        string dati;
        string hoje;
        string DiaVence;
        string ja;
        string pagou;
        string vencido;


        string conecta = "server=apelsin.com.br;user=apels630_Apelsin;database=apels630_Padaria;port=3306;password=Apel20Sun16;";

        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private MySqlDataReader reader, reader1, reader2;
        private DataSet mDataSet;
        private MySqlCommand cmd, cmd1, cmd2;

        public MenuP()
        {
            InitializeComponent();     
        }

        void ClicaBotao (Control con)
        {
            BtnProdutos.BackColor = Color.FromArgb(56, 56, 56);
            BtnClientes.BackColor = Color.FromArgb(56, 56, 56);
            BtnVender.BackColor = Color.FromArgb(56, 56, 56);
            BtnListVendas.BackColor = Color.FromArgb(56, 56, 56);
            BtnPagamento.BackColor = Color.FromArgb(56, 56, 56);
            BtnCaixa.BackColor = Color.FromArgb(56, 56, 56);
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            int dia = Convert.ToInt16(DateTime.Now.Day);
            int mes = Convert.ToInt16(DateTime.Now.Month);
            int ano = Convert.ToInt16(DateTime.Now.Year);
            string hj = Convert.ToString(dia + "/" + mes + "/" + ano);

            PicLogo.BringToFront();

            Program.x = this.Location.X + 120;
            Program.Y = this.Location.Y + 55;

            dati = "";
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
              this.WindowState = FormWindowState.Maximized;

            BtnClose.FlatAppearance.BorderSize = 0;
            BtnMini.FlatAppearance.BorderSize = 0;
            PnlMenu.Dock = DockStyle.Fill;
            PnlMenu.Visible = false;

            string data = Convert.ToString(DateTime.Now.Day) + "/" + Convert.ToString(DateTime.Now.Month) + "/" + Convert.ToString(DateTime.Now.Year);

            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();
            string sql = "SELECT * FROM `caixafecha` WHERE `Dia` = @Data;";
            using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
            {
                cmd.Parameters.AddWithValue("@Data", data);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dati = reader.GetString("Dia");
                }
                reader.Close();
            }
            if (dati == "")
            {
                sql = "INSERT INTO `caixafecha`(`Dia`, `Total`) VALUES (@Data, @Total);";
                using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
                {
                    cmd.Parameters.AddWithValue("@Data", data);
                    cmd.Parameters.AddWithValue("@Total", 0);
                    cmd.ExecuteNonQuery();
                }

                sql = "INSERT INTO `caixainout`(`Dia`, `Entrada`, `Saida`, `Hora`) VALUES (@dia, @entrada, @saida, @hora);";
                using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
                {
                    cmd.Parameters.AddWithValue("@dia", data);
                    cmd.Parameters.AddWithValue("@entrada", 0);
                    cmd.Parameters.AddWithValue("@saida", 0);
                    cmd.Parameters.AddWithValue("@hora", 0);
                    cmd.ExecuteNonQuery();
                }
            }

            if (dati == "")
            {
                MessageCaixa caixa = new MessageCaixa();
                caixa.ShowDialog();
            }
            ja = "n";
            sql = "SELECT diaVence FROM vence;";
            using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ja = reader.GetString("diaVence");
                }
                reader.Close();
            }

            if (ja == "n")
            {
                int count = 0;

                do
                {
                    count++;
                    dia++;
                    if (dia == 30)
                    {
                        dia = 1;
                        mes++;
                        if (mes == 12)
                        {
                            mes = 1;
                            ano++;
                        }
                    }
                } while (count < 10);

                string vence = dia + "/" + mes + "/" + ano;
                sql = "UPDATE `vence` SET diaVence = @Dia;";
                using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
                {
                    cmd.Parameters.AddWithValue("@Dia", vence);
                    cmd.ExecuteNonQuery();
                }
            }


            sql = "SELECT diaVence FROM vence;";
            using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DiaVence = reader.GetString("diaVence");
                }
                reader.Close();
            }
            mConn.Close();

            if (DiaVence == hj)
            {
                mConn = new MySqlConnection(conecta);
                mConn.Open();
                sql = "SELECT `Pagou` FROM `Pagamento`;";
                using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
                {
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        pagou = reader.GetString("Pagou");
                    }
                    reader.Close();
                }
                mConn.Close();
                if (pagou != "SIM")
                {
                    Program.venceu = "s";
                    BtnVender.Enabled = false;
                    label3.Enabled = false;

                    mConn = new MySqlConnection(Program.conexao);
                    mConn.Open();
                    sql = "UPDATE vence SET Vencido = 's';";
                    using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    mConn.Close();
                }
                if (pagou == "SIM")
                {
                    Program.venceu = "n";
                    BtnVender.Enabled = true;
                    label3.Enabled = true;

                    mConn = new MySqlConnection(Program.conexao);
                    mConn.Open();
                    sql = "UPDATE vence SET Vencido = 'n';";
                    using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    mConn.Close();
                }
            }
            else
            {
                mConn = new MySqlConnection(conecta);
                mConn.Open();

                sql = "SELECT diaVence FROM vence;";
                using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
                {
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        DiaVence = reader.GetString("diaVence");
                    }
                    reader.Close();
                }
                mConn.Close();

                if (DiaVence == hj)
                {
                    mConn = new MySqlConnection(conecta);
                    mConn.Open();
                    sql = "SELECT `Pagou` FROM `Pagamento`;";
                    using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            pagou = reader.GetString("Pagou");
                        }
                        reader.Close();
                    }
                    mConn.Close();

                    if (pagou != "SIM")
                    {
                        Program.venceu = "s";
                        BtnVender.Enabled = false;
                        label3.Enabled = false;

                        mConn = new MySqlConnection(Program.conexao);
                        mConn.Open();
                        sql = "UPDATE vence SET Vencido = 's';";
                        using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
                        {
                            cmd.ExecuteNonQuery();
                        }
                        mConn.Close();
                    }
                    if (pagou == "SIM")
                    {
                        Program.venceu = "n";
                        BtnVender.Enabled = true;
                        label3.Enabled = true;

                        mConn = new MySqlConnection(Program.conexao);
                        mConn.Open();
                        sql = "UPDATE vence SET Vencido = 'n';";
                        using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
                        {
                            cmd.ExecuteNonQuery();
                        }
                        mConn.Close();
                    }
                }


                vencido = "n";
                mConn = new MySqlConnection(Program.conexao);
                mConn.Open();
                sql = "SELECT Vencido FROM vence;";
                using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
                {
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        vencido = reader.GetString("Vencido");
                    }
                    reader.Close();
                }

                if (vencido == "s")
                {
                    mConn = new MySqlConnection(conecta);
                    mConn.Open();
                    sql = "SELECT `Pagou` FROM `Pagamento`;";
                    using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            pagou = reader.GetString("Pagou");
                        }
                        reader.Close();
                    }
                    mConn.Close();
                    if (pagou != "SIM")
                    {
                        Program.venceu = "s";
                        BtnVender.Enabled = false;
                        label3.Enabled = false;

                        mConn = new MySqlConnection(Program.conexao);
                        mConn.Open();
                        sql = "UPDATE vence SET Vencido = 's';";
                        using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
                        {
                            cmd.ExecuteNonQuery();
                        }
                        mConn.Close();
                    }
                    if (pagou == "SIM")
                    {
                        Program.venceu = "n";
                        BtnVender.Enabled = true;
                        label3.Enabled = true;

                        mConn = new MySqlConnection(Program.conexao);
                        mConn.Open();
                        sql = "UPDATE vence SET Vencido = 'n';";
                        using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
                        {
                            cmd.ExecuteNonQuery();
                        }
                        mConn.Close();
                    }

                }
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnProdutos_MouseEnter(object sender, EventArgs e)
        {
            BtnProdutos.BackColor = Color.DarkGray;
        }

        private void BtnProdutos_MouseLeave(object sender, EventArgs e)
        {
            if(Click != "prod")
            {
                BtnProdutos.BackColor = Color.FromArgb(56, 56, 56);
            }
        }

        private void BtnClientes_MouseEnter(object sender, EventArgs e)
        {
            BtnClientes.BackColor = Color.DarkGray;
        }

        private void BtnClientes_MouseLeave(object sender, EventArgs e)
        {
            if (Click != "cliente")
            {
                BtnClientes.BackColor = Color.FromArgb(56, 56, 56);
            }
        }

        private void BtnVender_MouseEnter(object sender, EventArgs e)
        {
            BtnVender.BackColor = Color.DarkGray;
        }

        private void BtnVender_MouseLeave(object sender, EventArgs e)
        {
            if (Click != "Vender")
            {
                BtnVender.BackColor = Color.FromArgb(56, 56, 56);
            }
        }

        private void BtnListVendas_MouseEnter(object sender, EventArgs e)
        {
            BtnListVendas.BackColor = Color.DarkGray;
        }

        private void BtnListVendas_MouseLeave(object sender, EventArgs e)
        {
            if (Click != "Vendas")
            {
                BtnListVendas.BackColor = Color.FromArgb(56, 56, 56);
            }
        }

        private void BtnPagamento_MouseEnter(object sender, EventArgs e)
        {
            BtnPagamento.BackColor = Color.DarkGray;
        }

        private void BtnPagamento_MouseLeave(object sender, EventArgs e)
        {
            if (Click != "paga")
            {
                BtnPagamento.BackColor = Color.FromArgb(56, 56, 56);
            }
        }

        private void BtnCaixa_MouseEnter(object sender, EventArgs e)
        {
            BtnCaixa.BackColor = Color.DarkGray;
        }

        private void BtnCaixa_MouseLeave(object sender, EventArgs e)
        {
            if (Click != "caix")
            {
                BtnCaixa.BackColor = Color.FromArgb(56, 56, 56);
            }
        }

        private void Menu_KeyDown(object sender, KeyEventArgs e)
        {
            if(Program.venceu != "s")
            {
                if (e.KeyCode == Keys.F1)
                {
                    if(BtnProdutos.Enabled == true)
                    {
                        BtnProdutos_Click(sender, e);
                    }             
                }
                if (e.KeyCode == Keys.F2)
                {
                    if (BtnClientes.Enabled == true)
                    {
                        BtnClientes_Click(sender, e);
                    }
                }
                if (e.KeyCode == Keys.F3)
                {
                    if (BtnVender.Enabled == true)
                    {
                        BtnVender_Click(sender, e);
                    }
                }
                if (e.KeyCode == Keys.F4)
                {
                    if (BtnListVendas.Enabled == true)
                    {
                        BtnListVendas_Click(sender, e);
                    }
                }
                if (e.KeyCode == Keys.F5)
                {
                    if (BtnPagamento.Enabled == true)
                    {
                        BtnPagamento_Click(sender, e);
                    }
                }
                if (e.KeyCode == Keys.F6)
                {
                    if (BtnCaixa.Enabled == true)
                    {
                        BtnCaixa_Click(sender, e);
                    }
                }             
            }
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }
        }

        private void BtnProdutos_Click(object sender, EventArgs e)
        {
            Click = "prod";
            lblLogo.Visible = false;
            PnlMenu.BringToFront();
            ClicaBotao(this);
            BtnProdutos.BackColor = Color.DarkGray;
            Produtos prod = new Produtos();
            prod.Location = new Point(
            prod.Left = this.Location.X + 120,
            prod.Top = this.Location.Y + 55);
            prod.ShowDialog();
            lblLogo.Visible = true;
            BtnProdutos.BackColor = Color.FromArgb(56, 56, 56);
            Click = "";
        }

        private void BtnCaixa_Click(object sender, EventArgs e)
        {
            Click = "caix";
            lblLogo.Visible = false;
            PnlMenu.BringToFront();
            ClicaBotao(this);
            BtnCaixa.BackColor = Color.DarkGray;
            Caixa caix = new Caixa();
            caix.ShowDialog();
            lblLogo.Visible = true;
            BtnCaixa.BackColor = Color.FromArgb(56, 56, 56);
            Click = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            BtnClientes_Click(sender, e);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            BtnPagamento_Click(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            BtnProdutos_Click(sender, e);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            BtnVender_Click(sender, e);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            BtnListVendas_Click(sender, e);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            BtnCaixa_Click(sender, e);
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            Click = "cliente";
            lblLogo.Visible = false;
            PnlMenu.BringToFront();
            ClicaBotao(this);
            BtnClientes.BackColor = Color.DarkGray;
            PesqClientes cleintes = new PesqClientes();
            cleintes.Location = new Point(
            cleintes.Left = this.Location.X + 120,
            cleintes.Top = this.Location.Y + 55);
            cleintes.ShowDialog();
            lblLogo.Visible = true;
            BtnClientes.BackColor = Color.FromArgb(56, 56, 56);
            Click = "";
        }

        private void BtnVender_Click(object sender, EventArgs e)
        {
            Click = "Vender";
            lblLogo.Visible = false;
            PnlMenu.BringToFront();
            ClicaBotao(this);
            BtnVender.BackColor = Color.DarkGray;
            Venda venda = new Venda();
            venda.Location = new Point(
            venda.Left = this.Location.X + 120,
            venda.Top = this.Location.Y + 55);
            venda.ShowDialog();
            lblLogo.Visible = true;
            BtnVender.BackColor = Color.FromArgb(56, 56, 56);
            Click = "";
        }

        private void BtnListVendas_Click(object sender, EventArgs e)
        {
            Click = "Vendas";
            lblLogo.Visible = false;
            PnlMenu.BringToFront();
            ClicaBotao(this);
            BtnListVendas.BackColor = Color.DarkGray;
            ListaVendas listvenda = new ListaVendas();
            listvenda.Location = new Point(
            listvenda.Left = this.Location.X + 120,
            listvenda.Top = this.Location.Y + 55);
            listvenda.ShowDialog();
            lblLogo.Visible = true;
            BtnListVendas.BackColor = Color.FromArgb(56, 56, 56);
            Click = "";
        }

        private void BtnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnPagamento_Click(object sender, EventArgs e)
        {
            Click = "paga";
            lblLogo.Visible = false;
            PnlMenu.BringToFront();
            ClicaBotao(this);
            BtnPagamento.BackColor = Color.DarkGray;
            Pagamento paga = new Pagamento();
            paga.Location = new Point(
            paga.Left = this.Location.X + 120,
            paga.Top = this.Location.Y + 55);
            paga.ShowDialog();
            lblLogo.Visible = true;
            BtnPagamento.BackColor = Color.FromArgb(56, 56, 56);
            Click = "";
        }
    }
}
