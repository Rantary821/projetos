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

namespace ArquivoEtec
{
    public partial class cadCurso : Form
    {
        SqlConnection mConn;
        Utilidades uti = new Utilidades();

        string idC = "", NomeC = "";
        public cadCurso()
        {
            InitializeComponent();

            this.GridCursos.ScrollBars = ScrollBars.None;
            this.GridCursos.MouseWheel += new MouseEventHandler(mousewheel);

            Cores();

            PreencheGridCadastros();
        }

        public void mousewheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0 && GridCursos.FirstDisplayedScrollingRowIndex > 0)
            {
                GridCursos.FirstDisplayedScrollingRowIndex--;
            }
            else if (e.Delta < 0)
            {
                GridCursos.FirstDisplayedScrollingRowIndex++;
            }
        }

        void btnExcluirCancel(bool Excluir)
        {
            if(Excluir)
            {
                BtnExcluir.Text = "Cancelar";
                BtnExcluir.Image = Properties.Resources.cancel_32x32;
            }
            else
            {
                BtnExcluir.Text = "Delete";
                BtnExcluir.Image = Properties.Resources.trashCan_32x32;
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

        private void PreencheGridCadastros()
        {
            string sql = "SELECT IdCurso, NomeCurso FROM curso;";

            Conect(true);

            try
            {
                SqlCommand cmd = new SqlCommand(sql, mConn);
                cmd.Connection = mConn;
                cmd.CommandText = sql;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                GridCursos.DataSource = dataSet;
                GridCursos.DataMember = dataSet.Tables[0].TableName;

                GridCursos.Columns[0].Width = 80;
                GridCursos.Columns[1].Width = 400;

                GridCursos.Columns[0].HeaderText = "Cod";
                GridCursos.Columns[1].HeaderText = "Nome Curso";

                //Alinhamento centralizado para pasta e concluinte
                GridCursos.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                GridCursos.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                uti.GridviewColors(GridCursos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na busca de cursos!" + Environment.NewLine + ex);
            }

            Conect(false);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GridCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idC = GridCursos.CurrentRow.Cells[0].Value.ToString();
            NomeC = GridCursos.CurrentRow.Cells[1].Value.ToString();

            BtnExcluir.Enabled = true;
            btnExcluirCancel(false);
        }

        private void GridCursos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnExcluir.Enabled = true;
            btnExcluirCancel(true);

            BtnCad.Visible = false;
            BtnUpdate.Visible = true;

            idC = GridCursos.CurrentRow.Cells[0].Value.ToString();
            NomeC = GridCursos.CurrentRow.Cells[1].Value.ToString();

            TxtNomeCurso.Text = GridCursos.CurrentRow.Cells[1].Value.ToString();
            TxtNomeCurso.Focus();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            //
            Conect(true);

            try
            {
                string sql1 = "UPDATE curso SET NomeCurso = @NomeC WHERE IdCurso = @idC;";
                using (SqlCommand cmd = new SqlCommand(sql1, mConn))
                {
                    cmd.Parameters.AddWithValue("@NomeC", TxtNomeCurso.Text);
                    cmd.Parameters.AddWithValue("@IdC", idC);
                    cmd.ExecuteNonQuery();
                }

                TxtNomeCurso.Text = "";
                BtnExcluir.Enabled = false;
                BtnUpdate.Enabled = false;
                BtnUpdate.Visible = false;
                BtnCad.Visible = true;

                PreencheGridCadastros();
            }
            catch
            {

            }
            Conect(false);
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            Conect(true);

            try
            {
                if(BtnExcluir.Text.ToLower() == "delete")
                {
                    string sql1 = "DELETE FROM curso WHERE IdCurso = @idC;";
                    using (SqlCommand cmd = new SqlCommand(sql1, mConn))
                    {
                        cmd.Parameters.AddWithValue("@IdC", idC);
                        cmd.ExecuteNonQuery();
                    }

                    PreencheGridCadastros();
                }
                else
                {
                    btnExcluirCancel(false);                    
                }
            }
            catch
            {

            }

            TxtNomeCurso.Text = "";
            BtnExcluir.Enabled = false;
            BtnUpdate.Enabled = false;
            BtnUpdate.Visible = false;
            BtnCad.Visible = true;

            Conect(false);
        }

        private void BtnCad_Click(object sender, EventArgs e)
        {
            LblErro.Text = "";

            int idCurso = 0;

            Conect(true);

            idCurso = uti.SelectMaxIDCurso();
            idCurso++;

            if (TxtNomeCurso.Text != "")
            {
                try
                {
                    string sql2 = "INSERT INTO curso (NomeCurso, idCurso) VALUES (@Curso, @idCurso);";
                    using (SqlCommand cmd2 = new SqlCommand(sql2, mConn))
                    {
                        cmd2.Parameters.AddWithValue("@Curso", TxtNomeCurso.Text);
                        cmd2.Parameters.AddWithValue("@idCurso", idCurso);
                        cmd2.ExecuteNonQuery();
                    }

                    TxtNomeCurso.Text = "";
                    BtnExcluir.Enabled = false;
                    BtnUpdate.Enabled = false;
                    BtnUpdate.Visible = false;
                    BtnCad.Visible = true;

                    PreencheGridCadastros();
                }
                catch
                {

                }
            }
            else
            {
                LblErro.Text = "Preencha o nome do curso!";
            }
            Conect(false);
        }

        private void GridCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        bool mouseClicked;
        Point clickedAt;
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            mouseClicked = true;
            clickedAt = e.Location;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseClicked)
            {
                this.Location = new Point(Cursor.Position.X - clickedAt.X, Cursor.Position.Y - clickedAt.Y);
            }
        }

        private void cadCurso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && TxtNomeCurso.Text != "")
            {
                uti.ApelMessageBox("Dados não salvos serão perdidos; Sair do cadastro?", "btn1* btn2'", "Sim; Não;", "a");
                if (Program.MBResposta == "Sim")
                {
                    this.Close();
                }
            }
            else
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else
            if (e.KeyCode == Keys.Delete && BtnExcluir.Text.ToLower() == "delete")
            {
                BtnExcluir_Click(sender, e);
            }
        }

        private void TxtNomeCurso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && BtnCad.Visible)
            {
                BtnCad_Click(sender, e);
            }

            if (e.KeyCode == Keys.Enter && !BtnCad.Visible)
            {
                BtnUpdate_Click(sender, e);
            }
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClicked = false;
        }

        private void TextBoxes_TextChanged(object sender, EventArgs e)
        {
            LblErro.Text = "";

            if (TxtNomeCurso.Text == "" || TxtNomeCurso.Text == NomeC)
            {
                BtnExcluir.Enabled = true;
                BtnUpdate.Enabled = false;
            }
            else
            {
                BtnUpdate.Enabled = true;
            }
        }

        void Cores()//Preenchimento das cores do tema
        {
            uti.ChangeColors(this);

            lblTitulo.ForeColor = Utilidades.ForeTitulo;
            lblTitulo.BackColor = Utilidades.BackTitulo;
            BtnClose.BackColor = Utilidades.BackTitulo;
            LblErro.ForeColor = Utilidades.ForeLblError;
            this.BackColor = Utilidades.BackForm;
        }

        private void BtnClose_MouseEnter(object sender, EventArgs e)
        {
            BtnClose.BackColor = Utilidades.BtnCloseEnter;
        }

        private void cadCurso_Load(object sender, EventArgs e)
        {
            btnExcluirCancel(false);
        }

        private void BtnClose_MouseLeave(object sender, EventArgs e)
        {
            BtnClose.BackColor = Utilidades.BackTitulo;
        }
    }
}
