using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleFuncionarios
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();


            BtnMenuCad.FlatAppearance.BorderSize = 1;
            BtnMenuCad.FlatAppearance.BorderSize = 0;
            BtnMenuPesq.FlatAppearance.BorderSize = 0;
            BtnMenuPresente.FlatAppearance.BorderSize = 0;
            BtnCad.FlatAppearance.BorderSize = 0;
            BtnLimpa.FlatAppearance.BorderSize = 0;
            BtnMini.FlatAppearance.BorderSize = 0;
            BtnClose.FlatAppearance.BorderSize = 0;
        }

        void desmarca(Control con)
        {
            BtnMenuCad.FlatAppearance.BorderSize = 0;
            BtnMenuPesq.FlatAppearance.BorderSize = 0;
            BtnMenuPresente.FlatAppearance.BorderSize = 0;
            BtnMenuCad.BackColor = Color.LightGray;
            BtnMenuPesq.BackColor = Color.LightGray;
            BtnMenuPresente.BackColor = Color.LightGray;
        }

        private void BtnMenuCad_Click(object sender, EventArgs e)
        {
            PnlPesq.Dock = DockStyle.None;
            PnlPesq.Visible = false;
            PnlPresente.Dock = DockStyle.None;
            PnlPresente.Visible = false;
            PnlCad.Dock = DockStyle.Fill;
            PnlCad.Visible = true;
            desmarca(this);
            BtnMenuCad.FlatAppearance.BorderSize = 1;
            BtnMenuCad.FlatAppearance.BorderColor = Color.LightGray;
            BtnMenuCad.BackColor = Color.Silver;
        }

        private void BtnMenuPesq_Click(object sender, EventArgs e)
        {
            PnlCad.Dock = DockStyle.None;
            PnlCad.Visible = false;
            PnlPresente.Dock = DockStyle.None;
            PnlPresente.Visible = false;
            PnlPesq.Dock = DockStyle.Fill;
            PnlPesq.Visible = true;
            desmarca(this);
            BtnMenuPesq.FlatAppearance.BorderSize = 1;
            BtnMenuPesq.FlatAppearance.BorderColor = Color.LightGray;
            BtnMenuPesq.BackColor = Color.Silver;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BtnMenuCad_Click(sender, e);
        }

        private void BtnMenuPresente_Click(object sender, EventArgs e)
        {
            PnlCad.Dock = DockStyle.None;
            PnlCad.Visible = false;
            PnlPesq.Dock = DockStyle.None;
            PnlPesq.Visible = false;
            PnlPresente.Dock = DockStyle.Fill;
            PnlPresente.Visible = true;
            desmarca(this);
            BtnMenuPresente.FlatAppearance.BorderSize = 1;
            BtnMenuPresente.FlatAppearance.BorderColor = Color.LightGray;
            BtnMenuPresente.BackColor = Color.Silver;
        }

        private void BtnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ficha FicPessoal = new ficha();
            FicPessoal.ShowDialog();
        }

        private void TxtValHora_TextChanged(object sender, EventArgs e)
        {
            if(TxtValHora.Text != "")
            {
                double ValHora;

                ValHora = Convert.ToDouble(TxtValHora.Text);
                TxtValDiaria.Text = Convert.ToString(ValHora * 8);
            }
            else
            {
                TxtValDiaria.Text = "";
            }
        }

        private void TxtValDiaria_TextChanged(object sender, EventArgs e)
        {
         
        }
    }
}
