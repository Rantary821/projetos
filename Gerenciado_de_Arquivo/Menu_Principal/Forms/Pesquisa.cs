using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_Principal
{
    public partial class Pesquisa : Form
    {
        int X, Y;
        public Pesquisa()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(label9_MouseDown);
            this.MouseMove += new MouseEventHandler(label9_MouseMove);
            this.ActiveControl = nome;

            
        }

        utilidades uti = new utilidades();

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPesq_Click(object sender, EventArgs e)
        {
            try
            {
                uti.Pesquisa(nome.Text, cpf.Text, ra.Text, dataPesq);
                dataPesq.Columns[0].Width = 0;
                dataPesq.Columns[1].Width = 300;
                dataPesq.Columns[2].Width = 130;
                dataPesq.Columns[3].Width = 130;
                dataPesq.Columns[4].Width = 130;
                dataPesq.Columns[5].Width = 120;
                dataPesq.Columns[6].Width = 120;
                dataPesq.Columns[0].HeaderText = "";
                dataPesq.Columns[1].HeaderText = "Nome";
                dataPesq.Columns[2].HeaderText = "RG";
                dataPesq.Columns[3].HeaderText = "Cpf";
                dataPesq.Columns[4].HeaderText = "Ra";
                dataPesq.Columns[5].HeaderText = "Sexo";
                dataPesq.Columns[6].HeaderText = "Nasc.";

            }catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void nome_TextChanged(object sender, EventArgs e)
        {
            uti.ve = 1;
        }

        private void cpf_TextChanged(object sender, EventArgs e)
        {
            uti.ve = 2;
        }

        private void ra_TextChanged(object sender, EventArgs e)
        {
            uti.ve = 3;
        }

        private void Pesquisa_Load(object sender, EventArgs e)
        {
            this.ActiveControl = nome;
        }

        private void dataPesq_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            uti.ficha(dataPesq);
            Ficha ficha = new Ficha();
            ficha.ShowDialog();

            dataPesq.DataSource = null;
        }

        private void nome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //Apertado o ENTER
            {
                btnPesq_Click(sender, e);
            }
        }

        private void cpf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //Apertado o ENTER
            {
                btnPesq_Click(sender, e);
            }
        }

        private void ra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //Apertado o ENTER
            {
                btnPesq_Click(sender, e);
            }
        }

        private void label9_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void Pesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                BtnClose_Click(sender, e);
            }
        }

        private void label9_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }
    }
}
