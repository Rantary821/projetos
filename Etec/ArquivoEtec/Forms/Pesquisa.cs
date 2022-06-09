using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
namespace ArquivoEtec
{
    public partial class Pesquisa : Form
    {
        SqlConnection mConn;
        SqlCommand cmd;
        SqlDataReader reader;
        SqlDataAdapter datap;

        string sqlAtual = "";
        bool mouseClicked;
        Point clickedAt;

        Utilidades uti = new Utilidades();

        string situacao, VCpf, VNome, VRg, VAno, VCodCurso, VCel1, VCel2, VTel1, VTel2, VEmail1, VEmail2, VBairro, VRua, VComplemento, VCidade, VNumero, VCep, VUf;

        public Pesquisa()
        {
            InitializeComponent();

            this.GridDisplay.ScrollBars = ScrollBars.None;
            this.GridDisplay.MouseWheel += new MouseEventHandler(mousewheel);

            uti.GridviewColors(GridDisplay);
            Cores();
            PicDel.BackColor = Utilidades.PesqDel;
            PicNConclu.BackColor = Utilidades.PesqNConClu;
        }

        public void mousewheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0 && GridDisplay.FirstDisplayedScrollingRowIndex > 0)
            {
                GridDisplay.FirstDisplayedScrollingRowIndex--;
            }
            else if (e.Delta < 0)
            {
                GridDisplay.FirstDisplayedScrollingRowIndex++;
            }
        }

        void Conect(bool AbreFecha)
        {
            try
            {
                mConn = new SqlConnection(Program.conecta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errro de conexão com o banco!" + Environment.NewLine + ex);
            }

            if (AbreFecha)
            {
                mConn.Open();
            }
            else
            {
                mConn.Close();
            }
        }

        private void Pesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void CheckDeletados_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckDeletados.Checked)
            {
                LblDel.Visible = true;
                PicDel.Visible = true;
            }
            else
            if (!CheckDeletados.Checked)
            {
                LblDel.Visible = false;
                PicDel.Visible = false;
            }

            /*if (txtNome.Text != "" || TxtCpf.Text != "   .   .   -" || txtAno.Text != "")
            {
                    //estava dando erro e foi necessario esse codigo, mas agora está resolvido... NÂO APAGAR 
            }*/
            MontaSQL(sqlAtual);

        }

        private void label5_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClicked = false;
        }

        private void label5_MouseMove(object sender, MouseEventArgs e)
        {
            Pesquisa_MouseMove(this, e);
        }

        private void label5_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            mouseClicked = true;
            clickedAt = e.Location;
        }

        private void txtAno_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pesquisa_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClicked = false;
        }

        private void Pesquisa_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseClicked)
            {
                this.Location = new Point(Cursor.Position.X - clickedAt.X, Cursor.Position.Y - clickedAt.Y);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void ProcuraDeletados()
        {
            try
            {
                if (GridDisplay.Rows.Count > 0)
                {
                    for (int i = 0; i < GridDisplay.Rows.Count; i++)
                    {
                        string row = GridDisplay.Rows[i].Cells[5].Value.ToString().Trim();
                        if (row.Contains("SIM") == true)
                        {
                            GridDisplay.Rows[i].DefaultCellStyle.BackColor = Utilidades.PesqDel;
                        }
                    }
                }
                GridDisplay.ClearSelection();
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.ToString());
            }
        }

        void ProcurarNConcluinte()
        {
            try
            {
                if (GridDisplay.Rows.Count > 0)
                {
                    for (int i = 0; i < GridDisplay.Rows.Count; i++)
                    {
                        string row = GridDisplay.Rows[i].Cells[6].Value.ToString().Trim();
                        if (row.Contains("NAO") == true)
                        {
                            GridDisplay.Rows[i].DefaultCellStyle.BackColor = Utilidades.PesqNConClu;
                        }
                    }
                }
                GridDisplay.ClearSelection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void Pesquisa_Load(object sender, EventArgs e)
        {

        }

        private void TxtCpf_Click(object sender, EventArgs e)
        {
            if (TxtCpf.Text == "   .   .   -")
            {
                TxtCpf.Select(0, 0);
            }
        }

        private void TxtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                string cpf = TxtCpf.Text;

                cpf = String.Concat(cpf.Where(Char.IsDigit));

                MontaSQL("a.cpf LIKE '" + cpf + "%'");
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                MontaSQL("a.nome LIKE '" + txtNome.Text + "%'");
            }
        }

        private void txtAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                MontaSQL("m.AnoMat LIKE '" + txtAno.Text + "%'");
            }
        }

        void MontaSQL(string sql)
        {
            sqlAtual = sql;

            if (CheckDeletados.Checked)
            {
                sql = "select a.nome, a.cpf, c.NomeCurso, m.idPrimario, m.idMatricula as 'pasta', m.Deletado, m.Concluinte from aluno a join matricula m on m.idAluno = a.idAluno join curso c on c.IdCurso = m.idCurso where " + sql + " ORDER BY m.idPrimario DESC;";
            }
            else
            if (!CheckDeletados.Checked)
            {
                sql = "select a.nome, a.cpf, c.NomeCurso, m.idPrimario, m.idMatricula AS 'Pasta', m.Deletado, m.Concluinte FROM aluno a JOIN matricula m ON m.idAluno = a.idAluno JOIN curso c ON c.IdCurso = m.idCurso where " + sql + " AND Deletado = 'NAO' ORDER BY m.idPrimario DESC;";
            }

            pesquisa(sql);
        }

        void pesquisa(string sql)
        {
            try
            {
                Conect(true);

                SqlCommand cmd = new SqlCommand(sql, mConn);
                cmd.Connection = mConn;
                cmd.CommandText = sql;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                GridDisplay.DataSource = dataSet;
                GridDisplay.DataMember = dataSet.Tables[0].TableName;
                
                GridDisplay.Columns[0].HeaderText = "Nome";
                GridDisplay.Columns[1].HeaderText = "Cpf";
                GridDisplay.Columns[2].HeaderText = "Curso";
                GridDisplay.Columns[3].Visible = false;//IdPrimario
                GridDisplay.Columns[4].HeaderText = "Pasta";
                GridDisplay.Columns[5].Visible = false;//Deletado
                GridDisplay.Columns[6].Visible = false;//Concluinte

                GridDisplay.Columns[0].Width = 240;
                GridDisplay.Columns[1].Width = 120;
                GridDisplay.Columns[2].Width = 200;
                GridDisplay.Columns[4].Width = 70;

                GridDisplay.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                Conect(false);

                uti.GridviewColors(GridDisplay);

                ProcurarNConcluinte();
                ProcuraDeletados(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void GridDisplay_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(GridDisplay.CurrentRow.Cells[5].Value.ToString() != "SIM")
            {
                int idPrimario = Convert.ToInt32(GridDisplay.CurrentRow.Cells[3].Value.ToString());

                Ficha ficha = new Ficha();
                ficha.ShowDialog(ref idPrimario);

                //limpar grid após fechas a ficha
                GridDisplay.DataSource = null;
                GridDisplay.Refresh();

                sqlAtual = "";
            }
        }

        void Cores()//Preenchimento das cores do tema
        {
            uti.ChangeColors(this);

            lblTitulo.ForeColor = Utilidades.ForeTitulo;
            lblTitulo.BackColor = Utilidades.BackTitulo;
            BtnClose.BackColor = Utilidades.BackTitulo;
            this.BackColor = Utilidades.BackForm;
        }

        private void BtnClose_MouseEnter(object sender, EventArgs e)
        {
            BtnClose.BackColor = Utilidades.BtnCloseEnter;
        }

        private void BtnClose_MouseLeave(object sender, EventArgs e)
        {
            BtnClose.BackColor = Utilidades.BackTitulo;
        }

        void TextBoxFocado_Enter(object sender, EventArgs e)
        {
            TextBox txtbox = (TextBox)sender;
            txtbox.Focus();

            uti.TextBoxEmFoco(this);
        }

        void MaskedTextFocado_Enter(object sender, EventArgs e)
        {
            MaskedTextBox txtbox = (MaskedTextBox)sender;
            txtbox.Focus();

            uti.TextBoxEmFoco(this);
        }
    }
}
