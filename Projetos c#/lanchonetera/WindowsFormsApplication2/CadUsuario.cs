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
    public partial class CadUsuario : Form
    {
        string VarCheckGoEstoq, VarCheckCadCliente, VarCheckCadFuncio, VarCheckDelCliente, VarCheckDelFuncio, VarCheckGoFichas, VarCheckGoProdutos, VarCheckVender, VarCheckUpdateCliente, VarCheckCadFornece, VarCheckPagamentos;
               

        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private MySqlDataReader reader, reader1, reader2;
        private DataSet mDataSet;
        private MySqlCommand cmd, cmd1, cmd2;


        public CadUsuario()
        {
            InitializeComponent();
            VarCheckGoEstoq = "nao";
            VarCheckCadCliente = "nao";
            VarCheckCadFuncio = "nao";
            VarCheckDelCliente = "nao";
            VarCheckDelFuncio = "nao";
            VarCheckGoFichas = "nao";
            VarCheckGoProdutos = "nao";
            VarCheckVender = "nao";
            VarCheckUpdateCliente = "nao"; 
            VarCheckCadFornece = "nao";
            VarCheckPagamentos = "nao";
        }
        private void CheckCadFuncio_CheckedChanged(object sender, EventArgs e)
        {
            if(CheckCadFuncio.Checked == true)
            {
                VarCheckCadFuncio = "sim";
            }
            if (CheckCadFuncio.Checked == false)
            {
                VarCheckCadFuncio = "nao";
            }
        }

        private void CheckDelFuncio_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckDelFuncio.Checked == true)
            {
                VarCheckDelFuncio = "sim";
            }
            if (CheckDelFuncio.Checked == false)
            {
                VarCheckDelFuncio = "nao";
            }
        }

        private void CheckGoFichas_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckGoFichas.Checked == true)
            {
                VarCheckGoFichas = "sim";
            }
            if (CheckGoFichas.Checked == false)
            {
                VarCheckGoFichas = "nao";
            }
        }

        private void CheckGoEstoq_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckGoEstoq.Checked == true)
            {
                VarCheckGoEstoq = "sim";
            }
            if (CheckGoEstoq.Checked == false)
            {
                VarCheckGoEstoq = "nao";
            }
        }

        private void CheckGoProdutos_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckGoProdutos.Checked == true)
            {
                VarCheckGoProdutos = "sim";
            }
            if (CheckGoProdutos.Checked == false)
            {
                VarCheckGoProdutos = "nao";
            }
        }

        private void CheckCadCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckCadCliente.Checked == true)
            {
                VarCheckCadCliente = "sim";
            }
            if (CheckCadCliente.Checked == false)
            {
                VarCheckCadCliente = "nao";
            }
        }

        private void CheckUpdateCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckUpdateCliente.Checked == true)
            {
                VarCheckUpdateCliente = "sim";
            }
            if (CheckUpdateCliente.Checked == false)
            {
                VarCheckUpdateCliente = "nao";
            }
        }

        private void CheckDelCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckDelCliente.Checked == true)
            {
                VarCheckDelCliente = "sim";
            }
            if (CheckDelCliente.Checked == false)
            {
                VarCheckDelCliente = "nao";
            }
        }

        private void CheckVender_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckVender.Checked == true)
            {
                VarCheckVender = "sim";
            }
            if (CheckVender.Checked == false)
            {
                VarCheckVender = "nao";
            }
        }

        private void CheckPagamentos_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckPagamentos.Checked == true)
            {
                VarCheckPagamentos = "sim";
            }
            if (CheckPagamentos.Checked == false)
            {
                VarCheckPagamentos = "nao";
            }
        }

        private void CheckCadFornecedores_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckCadFornecedores.Checked == true)
            {
                VarCheckCadFornece = "sim";
            }
            if (CheckCadFornecedores.Checked == false)
            {
                VarCheckCadFornece = "nao";
            }
        }

        private void TxtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void TxtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BtnCad_Click(sender, e);
            }
        }

        string user, pass, verifica;

        private void CheckSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if(CheckSelectAll.Checked == true)
            {
                CheckGoEstoq.Checked = true;
                CheckCadCliente.Checked = true;
                CheckCadFuncio.Checked = true;
                CheckDelCliente.Checked = true;
                CheckDelFuncio.Checked = true;
                CheckGoFichas.Checked = true;
                CheckGoProdutos.Checked = true;
                CheckVender.Checked = true;
                CheckUpdateCliente.Checked = true; 
                CheckCadFornecedores.Checked = true;
                CheckPagamentos.Checked = true;

                VarCheckGoEstoq = "sim";
                VarCheckCadCliente = "sim";
                VarCheckCadFuncio = "sim";
                VarCheckDelCliente = "sim";
                VarCheckDelFuncio = "sim";
                VarCheckGoFichas = "sim";
                VarCheckGoProdutos = "sim";
                VarCheckVender = "sim";
                VarCheckUpdateCliente = "sim";
                VarCheckCadFornece = "sim";
                VarCheckPagamentos = "sim";
            }
            if (CheckSelectAll.Checked == false)
            {
                CheckGoEstoq.Checked = false;
                CheckCadCliente.Checked = false;
                CheckCadFuncio.Checked = false;
                CheckDelCliente.Checked = false;
                CheckDelFuncio.Checked = false;
                CheckGoFichas.Checked = false;
                CheckGoProdutos.Checked = false;
                CheckVender.Checked = false;
                CheckUpdateCliente.Checked = false;
                CheckCadFornecedores.Checked = false;
                CheckPagamentos.Checked = false;

                VarCheckGoEstoq = "nao";
                VarCheckCadCliente = "nao";
                VarCheckCadFuncio = "nao";
                VarCheckDelCliente = "nao";
                VarCheckDelFuncio = "nao";
                VarCheckGoFichas = "nao";
                VarCheckGoProdutos = "nao";
                VarCheckVender = "nao"; 
                VarCheckUpdateCliente = "nao";
                VarCheckCadFornece = "nao";
                VarCheckPagamentos = "nao";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.LblMessage = "Deseja cancelar o cadastro atual?";
            Program.PicInterrog = "1";
            Program.PicAlert = "0";
            Program.PicVendaOK = "0";
            Program.PicError = "0";
            Program.btnNao = "1";
            Program.btnSim = "1";
            Program.btnOk = "0";

            FormMessageBox message = new FormMessageBox();
            message.ShowDialog();

            if (Program.MessageResult == "Y")
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void BtnCad_Click(object sender, EventArgs e)
        {
            if(TxtSenha.Text == "" || TxtUsuario.Text == "")
            {
                lblPassWrong.Visible = true;
                lblPassWrong.Text = "Preencha todos os campos!";
            }    
            else
            {
                verifica = "nao";
                mConn = new MySqlConnection(Program.conexao);
                mConn.Open();
                string sql = "SELECT Usuario FROM `login` WHERE Usuario LIKE @User;";
                using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
                {
                    cmd.Parameters.AddWithValue("@User", TxtUsuario.Text);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        lblPassWrong.Visible = true;
                        lblPassWrong.Text = "Usuario em uso!";
                        verifica = "sim";
                    }
                    reader.Close();
                }
                if (verifica == "nao")
                {
                    PanelPerms.BringToFront();
                }
            }
        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {     
            mConn = new MySqlConnection(Program.conexao); 
            mConn.Open(); 
            string sql = "INSERT INTO login (Usuario, Senha, CadFuncio, DelFuncio, GoFichas, GoEstoq, EnterProdutos, CadClientes, UpClientes, DelClientes, Vender, CheckCadFornece, Pagamentos) VALUES (@User, @Pass, @CadFuncio, @DelFuncio, @GoFichas, @GoEstoq, @EnterProdutos, @CadClientes, @UpClientes, @DelClientes, @Vender, @CheckCadFornece, @Pagamentos);";
            using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
            {
                cmd.Parameters.AddWithValue("@User", TxtUsuario.Text);
                cmd.Parameters.AddWithValue("@Pass", TxtSenha.Text);
                cmd.Parameters.AddWithValue("@CadFuncio", VarCheckCadFuncio);
                cmd.Parameters.AddWithValue("@DelFuncio", VarCheckDelFuncio);
                cmd.Parameters.AddWithValue("@GoFichas", VarCheckGoFichas);
                cmd.Parameters.AddWithValue("@GoEstoq", VarCheckGoEstoq);
                cmd.Parameters.AddWithValue("@EnterProdutos", VarCheckGoProdutos);
                cmd.Parameters.AddWithValue("@CadClientes", VarCheckCadCliente);
                cmd.Parameters.AddWithValue("@UpClientes", VarCheckUpdateCliente);
                cmd.Parameters.AddWithValue("@DelClientes", VarCheckDelCliente);
                cmd.Parameters.AddWithValue("@Vender", VarCheckVender); 
                cmd.Parameters.AddWithValue("@CheckCadFornece", VarCheckCadFornece);
                cmd.Parameters.AddWithValue("@Pagamentos", VarCheckPagamentos);
                cmd.ExecuteNonQuery();              
            }
            this.Close();
        }

        private void PanelPerms_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CadUsuario_Load(object sender, EventArgs e)
        {
            Panelcad.Dock = DockStyle.Fill;
            PanelPerms.Dock = DockStyle.Fill;
            Panelcad.BringToFront();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            
        }
    }
}
