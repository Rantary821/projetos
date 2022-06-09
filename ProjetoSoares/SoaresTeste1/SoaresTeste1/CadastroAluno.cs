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

namespace SoaresTeste1
{
    public partial class CadastroAluno : Form
    {
        int id, IdBusca, idMin;
         private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private MySqlDataReader reader;
        private MySqlCommand cmd;
        int X = 0;
        int Y = 0;
        public CadastroAluno()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(CadastroAluno_MouseDown);
            this.MouseMove += new MouseEventHandler(CadastroAluno_MouseMove);
        }

        private void CadastroAluno_Load(object sender, EventArgs e)
        {
            utilidades uti = new utilidades();
            uti.selectIdAluno();
            uti.SelectMinAluno();
            idMin = uti.iddMIn;
            id = uti.idd;
            IdBusca = uti.idd;
        }

        void selectDadosBack()
        {
            Boolean right = true;
            do
            {
                IdBusca = IdBusca - 1;
                if(IdBusca >= idMin)
                {
                    btnCad.Enabled = false;
                    btnLimpa.Enabled = true;
                    BtnForward.Enabled = true;
                    try
                    {
                        utilidades uti = new utilidades();
                        mConn = new MySqlConnection(uti.conexao);
                        mConn.Open();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Erro ao se comunicar com o Banco");
                    }

                    string sql = "SELECT a.nome, a.rg, a.cpf, a.ra, a.sexo, a.dataNasc, d.tel, d.cel, d.email FROM aluno a JOIN dados d ON d.idAluno = a.id WHERE a.id = " + IdBusca + ";";

                    using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
                    {
                        int i = 0;
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            string VerificaNome = reader.GetString("nome");
                      
                            if(VerificaNome != "Delete")
                            {
                                if(i == 0)
                                {
                                    txtNome.Text = reader.GetString("nome");
                                    txtRg.Text = reader.GetString("rg");
                                    txtCpf.Text = reader.GetString("cpf");
                                    txtRA.Text = reader.GetString("ra");
                                    txtSexo.Text = reader.GetString("sexo");
                                    txtNasc.Text = reader.GetString("dataNasc");
                                    txtEmail.Text = reader.GetString("email");
                                    txtTel.Text = reader.GetString("tel");
                                    txtCel.Text = reader.GetString("cel");
                                    i++;
                                }
                                else
                                {
                                    txtEmail2.Text = reader.GetString("email");
                                    txtTel2.Text = reader.GetString("tel");
                                    txtCel2.Text = reader.GetString("cel");
                                } 
                                right = false;
                            }    
                        }
                        reader.Close();
                        mConn.Close();
                    }
                    int verifica = IdBusca - 1;

                    if(verifica < idMin)
                    {
                        BtnBack.Enabled = false;
                        right = false;
                    }
                }    
                else
                {
                    BtnBack.Enabled = false;
                    right = false;
                }
            }
            while (right);         
        }

        void selectDadosForWard()
        {
            Boolean right = true;
            do
            {
                IdBusca = IdBusca + 1;
                if (IdBusca < id)
                {
                    BtnBack.Enabled = true;
                    try
                    {
                        utilidades uti = new utilidades();
                        mConn = new MySqlConnection(uti.conexao);
                        mConn.Open();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Erro ao se comunicar com o Banco");
                    }

                    string sql = "SELECT a.nome, a.rg, a.cpf, a.ra, a.sexo, a.dataNasc, d.tel, d.cel, d.email FROM aluno a JOIN dados d ON d.idAluno = a.id WHERE a.id = " + IdBusca + ";";

                    using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
                    {
                        int i = 0;
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            string VerificaNome = reader.GetString("nome");

                            if (VerificaNome != "Delete")
                            {
                                if (i == 0)
                                {
                                    txtNome.Text = reader.GetString("nome");
                                    txtRg.Text = reader.GetString("rg");
                                    txtCpf.Text = reader.GetString("cpf");
                                    txtRA.Text = reader.GetString("ra");
                                    txtSexo.Text = reader.GetString("sexo");
                                    txtNasc.Text = reader.GetString("dataNasc");
                                    txtEmail.Text = reader.GetString("email");
                                    txtTel.Text = reader.GetString("tel");
                                    txtCel.Text = reader.GetString("cel");
                                    i++;
                                }
                                else
                                {
                                    txtEmail2.Text = reader.GetString("email");
                                    txtTel2.Text = reader.GetString("tel");
                                    txtCel2.Text = reader.GetString("cel");
                                }
                                right = false;
                            }
                        }
                        reader.Close();
                        mConn.Close();
                    }
                }
                else
                {
                    BtnForward.Enabled = false;
                    right = false;
                    txtNome.Text = "";
                    txtRg.Text = "";
                    txtCpf.Text = "";
                    txtRA.Text = "";
                    txtSexo.Text = "";
                    txtNasc.Text = "";
                    txtEmail.Text = "";
                    txtTel.Text = "";
                    txtCel.Text = "";
                    txtEmail2.Text = "";
                    txtTel2.Text = "";
                    txtCel2.Text = "";
                    btnCad.Enabled = true;
                    btnLimpa.Enabled = false;
                }
            }
            while (right);

        }

        //quando clica nos maskeds o curso vai direto pro inicio na primeira vez
        private delegate void PosicionaCursorDelegate(int posicao);
        //quando clica nos maskeds o curso vai direto pro inicio na primeira vez
        private void PosicionaCursor(int posicao)
        {
            //quando clica nos maskeds o curso vai direto pro inicio na primeira vez
            txtCpf.SelectionStart = posicao;
            txtNasc.SelectionStart = posicao;
            txtCel.SelectionStart = posicao;
            txtTel.SelectionStart = posicao;
            txtCel2.SelectionStart = posicao;
            txtTel2.SelectionStart = posicao;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            utilidades uti = new utilidades();
            uti.ClearAllText(this);
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            utilidades uti = new utilidades();
            uti.selectIdAluno();
            uti.SelectMinAluno();
            idMin = uti.iddMIn;
            id = uti.idd;
            IdBusca = uti.idd + 1;
            uti.cadastraAluno(id,txtNome.Text,txtRg.Text,txtCpf.Text,txtRA.Text,txtNasc.Text,txtSexo.Text);
            try
            {
                mConn = new MySqlConnection(uti.conexao);
                mConn.Open();
            }catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao se comunicar com o Banco");
            }
            try
            {
                string insert = "insert into dados (tel, cel, email, idAluno) values ( @tel, @cel, @email, @idAluno)";
                string[] email = new string[2];
                string[] cel = new string[2];
                string[] tel = new string[2];
                id = uti.idd;   

                for (int count = 0; count <= 1; count++){
                    if (count == 0)
                    {
                        email[count] = txtEmail.Text;
                        cel[count] = txtCel.Text;
                        tel[count] = txtTel.Text;
                          using (MySqlCommand cmd = new MySqlCommand(insert, mConn))
                          {
                            cmd.Parameters.AddWithValue("@tel", tel[count]);
                            cmd.Parameters.AddWithValue("@cel", cel[count]);
                            cmd.Parameters.AddWithValue("@email", email[count]);
                            cmd.Parameters.AddWithValue("@idAluno", id);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    if (count == 1)
                    {
                        email[count] = txtEmail2.Text;
                        cel[count] = txtCel2.Text;
                        tel[count] = txtTel2.Text;
                        using (MySqlCommand cmd = new MySqlCommand(insert, mConn))
                        {
                            cmd.Parameters.AddWithValue("@tel", tel[count]);
                            cmd.Parameters.AddWithValue("@cel", cel[count]);
                            cmd.Parameters.AddWithValue("@email", email[count]);
                            cmd.Parameters.AddWithValue("@idAluno", id);
                            cmd.ExecuteNonQuery();
                        }

                    }

                }
                mConn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            uti.ClearAllText(this);
            id++;
        }

        //quando clica nos maskeds o curso vai direto pro inicio na primeira vez
        private void txtCpf_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke(new PosicionaCursorDelegate(PosicionaCursor), new object[] { 0 });
        }
        //quando clica nos maskeds o curso vai direto pro inicio na primeira vez
        private void txtNasc_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke(new PosicionaCursorDelegate(PosicionaCursor), new object[] { 0 });
        }
        //quando clica nos maskeds o curso vai direto pro inicio na primeira vez
        private void txtCel_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke(new PosicionaCursorDelegate(PosicionaCursor), new object[] { 0 });
        }
        //quando clica nos maskeds o curso vai direto pro inicio na primeira vez
        private void txtTel_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke(new PosicionaCursorDelegate(PosicionaCursor), new object[] { 0 });
        }

        private void txtTel2_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke(new PosicionaCursorDelegate(PosicionaCursor), new object[] { 0 });
        }

        private void txtCel2_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke(new PosicionaCursorDelegate(PosicionaCursor), new object[] { 0 });
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            selectDadosBack();
        }

        private void BtnForward_Click(object sender, EventArgs e)
        {
            selectDadosForWard();
        }

        private void CadastroAluno_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void CadastroAluno_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }
    }
}
