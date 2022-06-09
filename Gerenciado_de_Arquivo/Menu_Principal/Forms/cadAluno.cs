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

namespace Menu_Principal
{
    public partial class cadAluno : Form
    {
        Boolean delAluno = false;
        int id, IdBusca, idMin;
        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private MySqlDataReader reader;
        private MySqlCommand cmd;
        int X = 0;
        int Y = 0;

        public cadAluno()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(panel2_MouseDown);
            this.MouseMove += new MouseEventHandler(panel2_MouseMove);
            this.ActiveControl = txtNome;
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            if(txtNome.Text != "")
            {
                try
                {
                    utilidades uti = new utilidades();
                    uti.selectIdAluno();
                    uti.SelectMinAluno();
                    idMin = uti.iddMIn;
                    id = uti.idd;
                    IdBusca = uti.idd + 1;
                    if (txtCel.Text == "(  )     -")
                    {
                        txtCel.Text = "1";
                    }
                    if (txtCel2.Text == "(  )     -")
                    {
                        txtCel2.Text = "2";
                    }
                    if (txtTel.Text == "(  )    -")
                    {
                        txtTel.Text = "1";
                    }
                    if (txtTel2.Text == "(  )    -")
                    {
                        txtTel2.Text = "2";
                    }
                    if (txtEmail.Text == "")
                    {
                        txtEmail.Text = "1";
                    }
                    if (txtEmail2.Text == "")
                    {
                        txtEmail2.Text = "2";
                    }
                    uti.cadastraAluno(Convert.ToInt16(id) , txtNome.Text, txtRg.Text, txtCpf.Text, txtRA.Text, txtNasc.Text, txtSexo.Text, txtEmail.Text, txtTel.Text, txtCel.Text, txtEmail2.Text, txtTel2.Text, txtCel2.Text);
                    uti.ClearAllText(this);
                }
                catch (Exception ex)
                {

                }
            }
            else
            if(txtNome.Text == "")
            {
                MessageBox.Show("Preencha todos os campos corretamente!");
            }
        }
        private void cadAluno_Load(object sender, EventArgs e)
        {
            utilidades uti = new utilidades();
            uti.selectIdAluno();
            uti.SelectMinAluno();
            idMin = uti.iddMIn;
            id = uti.idd;
            IdBusca = uti.idd;
            this.ActiveControl = txtNome;
        }

        void selectDadosBack()
        {
            Boolean right = true;
            do
            {
                IdBusca = IdBusca - 1;
                if (IdBusca >= idMin)
                {
                    delAluno = true;
                    btnCad.Enabled = false;
                    btnLimpa.Enabled = true;
                    BtnForward.Enabled = true;

                    utilidades uti = new utilidades();
                    uti.BlockThings(this);

                    try
                    {
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

                            if (VerificaNome.ToUpper() != "DELETE")
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
                    double verifica = IdBusca - 1;

                    if (verifica < idMin)
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

                    utilidades uti = new utilidades();
                    try
                    {
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

                            if (VerificaNome.ToUpper() != "DELETE")
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
                    BtnBack.Enabled = true;
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
                    delAluno = false;
                    utilidades uti = new utilidades();
                    uti.FreeThings(this);
                }
            }
            while (right);

        }

        //quando clica nos maskeds o curso vai direto pro inicio na primeira vez
        private delegate void PosicionaCursorDelegate(int posicao);

        private void BtnBack_Click(object sender, EventArgs e)
        {
            selectDadosBack();
        }

        private void BtnForward_Click(object sender, EventArgs e)
        {
            selectDadosForWard();
        }

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

        private void cadAluno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCad_Click(this, e);
            }
            if (e.KeyCode == Keys.Delete)
            {
                btnLimpa_Click_1(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
               BtnClose_Click(sender, e);
            }
            if(e.KeyCode.ToString() == "Oemcomma") //Oemcomma == <
            {
                BtnBack_Click(sender, e);
            }
            if (e.KeyCode.ToString() == "OemPeriod")//OemPeriod == >
            {
                BtnForward_Click(sender, e);
            }
        }

        private void btnLimpa_Click_1(object sender, EventArgs e)
        {
            if(delAluno)
            {
                utilidades uti = new utilidades();
                uti.deleteAluno(Convert.ToInt16(IdBusca));
                uti.selectIdAluno();
                uti.SelectMinAluno();
                idMin = uti.iddMIn;
                id = uti.idd;
                IdBusca = uti.idd;
                this.ActiveControl = txtNome;
                uti.ClearAllText(this);
                btnCad.Enabled = true;
                BtnForward.Enabled = false;
                BtnBack.Enabled = true;
                delAluno = false;
                uti.FreeThings(this);
            }
            else
            {
                utilidades uti = new utilidades();
                uti.ClearAllText(this);
            }
        }

        private void cadAluno_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                btnCad_Click(sender, e);
            }*/
        }

        private void txtCel2_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke(new PosicionaCursorDelegate(PosicionaCursor), new object[] { 0 });
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
