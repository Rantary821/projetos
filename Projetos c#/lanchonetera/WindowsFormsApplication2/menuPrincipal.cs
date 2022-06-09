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
    public partial class menuPrincipal : Form
    {
        
        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private MySqlDataReader reader, reader1, reader2;
        private DataSet mDataSet;
        private MySqlCommand cmd, cmd1, cmd2;

        string FrmEscolhido, FrmParaFechar;
        int X = 0;
        int Y = 0;
        public menuPrincipal()
        {
            InitializeComponent();
            BtnMenu.FlatAppearance.BorderSize = 0;
            BtnMenu.ForeColor = Color.FromArgb(255, 127, 0);
            PanelForms.Dock = DockStyle.Fill;
            PanelMenuIncial.Dock = DockStyle.Fill;
            PanelMenuIncial.BringToFront();
            MenuAtual.FlatAppearance.BorderSize = 0;
            this.MouseDown += new MouseEventHandler(panel2_MouseDown);
            this.MouseMove += new MouseEventHandler(panel2_MouseMove);
            this.MouseDown += new MouseEventHandler(PanelMenuIncial_MouseDown);
            this.MouseMove += new MouseEventHandler(PanelMenuIncial_MouseMove);

            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();
            string sql = "SELECT CadFuncio, DelFuncio, GoFichas, GoEstoq, EnterProdutos, CadClientes, UpClientes, DelClientes, Vender, CheckCadFornece, Pagamentos FROM login WHERE IdUser = @IdUser;";
            using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
            {
                cmd.Parameters.AddWithValue("@IdUser", Program.IdUsuario);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Program.VarCheckGoEstoq = reader.GetString("GoEstoq");
                    Program.VarCheckCadCliente = reader.GetString("CadClientes");
                    Program.VarCheckCadFuncio = reader.GetString("CadFuncio");
                    Program.VarCheckDelCliente = reader.GetString("DelClientes");
                    Program.VarCheckDelFuncio = reader.GetString("DelFuncio");
                    Program.VarCheckGoFichas = reader.GetString("GoFichas");
                    Program.VarCheckGoProdutos = reader.GetString("EnterProdutos");
                    Program.VarCheckVender = reader.GetString("Vender");
                    Program.VarCheckUpdateCliente = reader.GetString("UpClientes");
                    Program.VarCheckCadFornece = reader.GetString("CheckCadFornece");
                    Program.VarCheckPagamentos = reader.GetString("Pagamentos");
                }
                reader.Close();

                if (Program.VarCheckPagamentos == "nao")
                {
                    BtnPagamento.Enabled = false;
                }
                if (Program.VarCheckCadFornece == "nao")
                {
                    btnFornecedor.Enabled = false;
                    BtnCadNewFornece.Enabled = false;
                }
                if (Program.VarCheckGoEstoq == "nao")
                {
                    BtnEstoque.Enabled = false;
                }
                if (Program.VarCheckCadCliente == "nao")
                {
                    BtnClientes.Enabled = false;
                    BtnAbrirCadastro.Enabled = false;
                }
                if (Program.VarCheckCadFuncio == "nao")
                {
                    BtnFuncionario.Enabled = false;
                }
                if (Program.VarCheckGoProdutos == "nao")
                {
                    BtnEntrada.Enabled = false;
                }
                if (Program.VarCheckVender == "nao")
                {
                    BtnVendas.Enabled = false;
                }
            }
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void fecha_Click(object sender, EventArgs e)
        {
            Program.LblMessage = "Deseja sair do programa?";
            Program.PicInterrog = "1";
            Program.PicAlert = "0";
            Program.PicError = "0";
            Program.PicVendaOK = "0";
            Program.btnNao = "1";
            Program.btnSim = "1";
            Program.btnOk = "0";

            FormMessageBox message = new FormMessageBox();
            message.ShowDialog();

            if(Program.MessageResult == "Y")
            {
                this.Close();
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void BtnVendas_Click(object sender, EventArgs e)
        {
            BtnVendas.BackColor = Color.FromArgb(255, 127, 0);
            BtnEntrada.BackColor = Color.Gray;
            BtnEstoque.BackColor = Color.Gray;
            BtnFuncionario.BackColor = Color.Gray;
            BtnClientes.BackColor = Color.Gray;
            btnFornecedor.BackColor = Color.Gray;
            BtnPagamento.BackColor = Color.Gray;
            BtnPedidos.BackColor = Color.Gray;
            BtnPedidos.Width = 190;
            BtnPagamento.Width = 190;
            btnFornecedor.Width = 190;
            BtnClientes.Width = 190;
            BtnVendas.Width = 198;
            BtnEntrada.Width = 190;
            BtnEstoque.Width = 190;
            BtnFuncionario.Width = 190;
            MenuAtual.Text = "Vendas";
            FrmEscolhido = "Vende";
            PanelForms.BringToFront();
            AbreForms(this);
            BtnAbrirCadastro.Visible = true;
            BtnAbrirCadastro.BringToFront();
        }

        private void BtnEntrada_Click(object sender, EventArgs e)
        {
            BtnEntrada.BackColor = Color.FromArgb(255, 127, 0);
            BtnVendas.BackColor = Color.Gray;
            BtnEstoque.BackColor = Color.Gray;
            BtnFuncionario.BackColor = Color.Gray;
            BtnClientes.BackColor = Color.Gray;
            btnFornecedor.BackColor = Color.Gray;
            BtnPagamento.BackColor = Color.Gray;
            BtnPedidos.BackColor = Color.Gray;
            BtnPedidos.Width = 190;
            BtnPagamento.Width = 190;
            btnFornecedor.Width = 190;
            BtnClientes.Width = 190;
            BtnEntrada.Width = 198;
            BtnVendas.Width = 190;
            BtnEstoque.Width = 190;
            BtnFuncionario.Width = 190;
            MenuAtual.Text = "Entrada de Produtos";
            FrmEscolhido = "Entra";
            PanelForms.BringToFront();
            AbreForms(this);
        }

        private void BtnEstoque_Click(object sender, EventArgs e)
        {
            BtnEstoque.BackColor = Color.FromArgb(255, 127, 0);
            BtnVendas.BackColor = Color.Gray;
            BtnEntrada.BackColor = Color.Gray;
            BtnFuncionario.BackColor = Color.Gray;
            BtnClientes.BackColor = Color.Gray;
            btnFornecedor.BackColor = Color.Gray;
            BtnPagamento.BackColor = Color.Gray;
            BtnPedidos.BackColor = Color.Gray;
            BtnPedidos.Width = 190;
            BtnPagamento.Width = 190;
            btnFornecedor.Width = 190;
            BtnClientes.Width = 190;
            BtnEstoque.Width = 198;
            BtnVendas.Width = 190;
            BtnEntrada.Width = 190;
            BtnFuncionario.Width = 190;
            MenuAtual.Text = "Estoque";
            FrmEscolhido = "Estoq";
            PanelForms.BringToFront();
            AbreForms(this);
            BtnCadNewFornece.BringToFront();
        }

        private void BtnFuncionario_Click(object sender, EventArgs e)
        {
            BtnFuncionario.BackColor = Color.FromArgb(255, 127, 0);
            BtnEstoque.BackColor = Color.Gray;
            BtnVendas.BackColor = Color.Gray;
            BtnEntrada.BackColor = Color.Gray;
            BtnClientes.BackColor = Color.Gray;
            btnFornecedor.BackColor = Color.Gray;
            BtnPagamento.BackColor = Color.Gray;
            BtnPedidos.BackColor = Color.Gray;
            BtnPedidos.Width = 190;
            BtnPagamento.Width = 190;
            btnFornecedor.Width = 190;
            BtnClientes.Width = 190;
            BtnFuncionario.Width = 198;
            BtnVendas.Width = 190;
            BtnEstoque.Width = 190;
            BtnEntrada.Width = 190;
            MenuAtual.Text = "Funcionarios";
            FrmEscolhido = "Funcio";
            PanelForms.BringToFront();
            AbreForms(this);
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            BtnClientes.BackColor = Color.FromArgb(255, 127, 0);
            BtnEstoque.BackColor = Color.Gray;
            BtnVendas.BackColor = Color.Gray;
            BtnEntrada.BackColor = Color.Gray;
            BtnFuncionario.BackColor = Color.Gray;
            btnFornecedor.BackColor = Color.Gray;
            BtnPagamento.BackColor = Color.Gray;
            BtnPedidos.BackColor = Color.Gray;
            BtnPedidos.Width = 190;
            BtnPagamento.Width = 190;
            btnFornecedor.Width = 190;
            BtnClientes.Width = 198;
            BtnFuncionario.Width = 190;
            BtnVendas.Width = 190;
            BtnEstoque.Width = 190;
            BtnEntrada.Width = 190;
            MenuAtual.Text = "Cadastro de Clientes";
            FrmEscolhido = "Clientes";
            PanelForms.BringToFront();
            AbreForms(this);
        }
        
        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            btnFornecedor.BackColor = Color.FromArgb(255, 127, 0);
            BtnClientes.BackColor = Color.Gray;
            BtnEstoque.BackColor = Color.Gray;
            BtnVendas.BackColor = Color.Gray;
            BtnEntrada.BackColor = Color.Gray;
            BtnFuncionario.BackColor = Color.Gray;
            BtnPagamento.BackColor = Color.Gray;
            BtnPedidos.BackColor = Color.Gray;
            BtnPedidos.Width = 190;
            BtnPagamento.Width = 190;
            btnFornecedor.Width = 198;
            BtnClientes.Width = 190;
            BtnFuncionario.Width = 190;
            BtnVendas.Width = 190;
            BtnEstoque.Width = 190;
            BtnEntrada.Width = 190;
            MenuAtual.Text = "Cadastro de Fornecedores";
            FrmEscolhido = "fornece";
            PanelForms.BringToFront();
            AbreForms(this);
        }


        private void BtnPagamento_Click(object sender, EventArgs e)
        {
            BtnPagamento.BackColor = Color.FromArgb(255, 127, 0);
            BtnClientes.BackColor = Color.Gray;
            BtnEstoque.BackColor = Color.Gray;
            BtnVendas.BackColor = Color.Gray;
            BtnEntrada.BackColor = Color.Gray;
            BtnFuncionario.BackColor = Color.Gray;
            btnFornecedor.BackColor = Color.Gray;
            BtnPedidos.BackColor = Color.Gray;
            BtnPedidos.Width = 190; 
            BtnPagamento.Width = 198;
            btnFornecedor.Width = 190;
            BtnClientes.Width = 190;
            BtnFuncionario.Width = 190;
            BtnVendas.Width = 190;
            BtnEstoque.Width = 190;
            BtnEntrada.Width = 190;
            MenuAtual.Text = "Pagamento";
            FrmEscolhido = "Paga";
            PanelForms.BringToFront();
            AbreForms(this);
        }

        private void BtnPedidos_Click(object sender, EventArgs e)
        {
            BtnPedidos.BackColor = Color.FromArgb(255, 127, 0);
            BtnPagamento.BackColor = Color.Gray;
            BtnClientes.BackColor = Color.Gray;
            BtnEstoque.BackColor = Color.Gray;
            BtnVendas.BackColor = Color.Gray;
            BtnEntrada.BackColor = Color.Gray;
            BtnFuncionario.BackColor = Color.Gray;
            btnFornecedor.BackColor = Color.Gray;
            BtnPedidos.Width = 198;
            BtnPagamento.Width = 190;
            btnFornecedor.Width = 190;
            BtnClientes.Width = 190;
            BtnFuncionario.Width = 190;
            BtnVendas.Width = 190;
            BtnEstoque.Width = 190;
            BtnEntrada.Width = 190;
            MenuAtual.Text = "Pedidos Abertos";
            FrmEscolhido = "Pedido";
            PanelForms.BringToFront();
            AbreForms(this);
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            PanelMenuIncial.BringToFront();
            MenuAtual.Text = "Menu Incial";
            BtnFuncionario.BackColor = Color.Gray;
            BtnEstoque.BackColor = Color.Gray;
            BtnVendas.BackColor = Color.Gray;
            BtnEntrada.BackColor = Color.Gray;
            BtnClientes.BackColor = Color.Gray;
            BtnPagamento.BackColor = Color.Gray;
            btnFornecedor.BackColor = Color.Gray;
            BtnPedidos.BackColor = Color.Gray;
            BtnPedidos.Width = 190;
            btnFornecedor.Width = 190;
            BtnPagamento.Width = 190;
            BtnClientes.Width = 190;
            BtnFuncionario.Width = 190;
            BtnVendas.Width = 190;
            BtnEstoque.Width = 190;
            BtnEntrada.Width = 190;
        }

        private void PanelMenuIncial_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void PanelMenuIncial_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void BtnAbrirCadastro_Click(object sender, EventArgs e)
        {
            BtnClientes_Click(sender, e);
        }

        private void BtnCadNewFornece_Click(object sender, EventArgs e)
        {
            btnFornecedor_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void menuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.apelsin.com.br");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.apelsin.com.br");
        }

        private void MenuAtual_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void MenuAtual_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        void AbreForms(Control con)
        {
            //Parte para abrir os forms
            if (FrmEscolhido == "Funcio")
            {
                Funcionarios funcio = new Funcionarios();
                funcio.TopLevel = false;
                funcio.FormBorderStyle = FormBorderStyle.None;
                funcio.Dock = DockStyle.Fill;
                PanelForms.Controls.Add(funcio);
                funcio.Show();
                funcio.BringToFront();
            }
            if (FrmEscolhido == "Estoq")
            {
                Estoque estoq = new Estoque();
                estoq.TopLevel = false;
                estoq.FormBorderStyle = FormBorderStyle.None;
                estoq.Dock = DockStyle.Fill;
                PanelForms.Controls.Add(estoq);
                estoq.Show();
                estoq.BringToFront();
            }
            if (FrmEscolhido == "Entra")
            {
                Entrada Entra = new Entrada();
                Entra.TopLevel = false;
                Entra.FormBorderStyle = FormBorderStyle.None;
                Entra.Dock = DockStyle.Fill;
                PanelForms.Controls.Add(Entra);
                Entra.Show();
                Entra.BringToFront();
            }
            if (FrmEscolhido == "Clientes")
            {
                CadastroDeClientes Clientes = new CadastroDeClientes();
                Clientes.TopLevel = false;
                Clientes.FormBorderStyle = FormBorderStyle.None;
                Clientes.Dock = DockStyle.Fill;
                PanelForms.Controls.Add(Clientes);
                Clientes.Show();
                Clientes.BringToFront();
            }

            if (FrmEscolhido == "fornece")
            {
                Fornecedor fornece = new Fornecedor();
                fornece.TopLevel = false;
                fornece.FormBorderStyle = FormBorderStyle.None;
                fornece.Dock = DockStyle.Fill;
                PanelForms.Controls.Add(fornece);
                fornece.Show();
                fornece.BringToFront();
            }

            if (FrmEscolhido == "Paga")
            {
                Pagamento Paga = new Pagamento();
                Paga.TopLevel = false;
                Paga.FormBorderStyle = FormBorderStyle.None;
                Paga.Dock = DockStyle.Fill;
                PanelForms.Controls.Add(Paga);
                Paga.Show();
                Paga.BringToFront();
            }
            if (FrmEscolhido == "Vende")
            {       
                Vendas Vende = new Vendas();
                Vende.TopLevel = false;
                Vende.FormBorderStyle = FormBorderStyle.None;
                Vende.Dock = DockStyle.Fill;
                PanelForms.Controls.Add(Vende);
                Vende.Show();
                Vende.BringToFront();
            }
            if (FrmEscolhido == "Pedido")
            {
                Pedidos Pedido = new Pedidos();
                Pedido.TopLevel = false;
                Pedido.FormBorderStyle = FormBorderStyle.None;
                Pedido.Dock = DockStyle.Fill;
                PanelForms.Controls.Add(Pedido);
                Pedido.Show();
                Pedido.BringToFront();
            }
        }
    }
}

