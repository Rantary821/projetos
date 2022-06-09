using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArquivoEtec
{
    public partial class Edit : Form
    {
        Utilidades uti = new Utilidades();

        string mostrarContat = "";
        public Edit()
        {
            InitializeComponent();

            uti.buscaConfig();

            if(Utilidades.MostrarContatos == "SIM")
            {
                MostraCont.Checked = true;
            }
            else
            if (Utilidades.MostrarContatos == "NAO")
            {
                MostraCont.Checked = false;
            }

            ComboTema.Text = Utilidades.Tema;

            try
            {
                if (Utilidades.TodosOSTemas.Contains(Utilidades.Tema) && Utilidades.Tema != "")
                {
                    Cores();
                }
                else
                {
                    BtnUpdate.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                BtnUpdate.Enabled = false;
            }

            mostrarContat = "";
        }

        void Update()
        {
            if(ComboTema.Text != "" && mostrarContat != "")
            {
                uti.UpConfig(ComboTema.Text, mostrarContat);
                uti.buscaConfig();
            }
            else
            if(ComboTema.Text != "" && mostrarContat == "")
            {
                uti.UpConfig(ComboTema.Text, "NAO");
                uti.buscaConfig();
            }

            if(ComboTema.Text == "")
            {
                BtnUpdate.Enabled = false;
            }

            Cores();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Update();

            uti.ApelMessageBox("Alterações salvas!; ", "btn3", "Ok", "c");

            this.Close();
        }

        private void MostraCont_CheckedChanged(object sender, EventArgs e)
        {
            if (MostraCont.Checked)
            {
                mostrarContat = "SIM";
            }
            else
            if (!MostraCont.Checked)
            {
                mostrarContat = "NAO";
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Edit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void ComboTema_SelectedIndexChanged(object sender, EventArgs e)
        {
            Utilidades.Tema = ComboTema.Text;
            Cores();
            Update();
            BtnUpdate.Enabled = true;
        }

        void Cores()//Preenchimento das cores do tema
        {
            uti.BuscaCores();
            uti.ChangeColors(this);

            lblTitulo.ForeColor = Utilidades.ForeTitulo;
            lblTitulo.BackColor = Utilidades.BackTitulo;
            BtnClose.BackColor = Utilidades.BackTitulo;
            this.BackColor = Utilidades.BackForm;
            tabGeral.BackColor = Utilidades.BackForm;
        }

        private void BtnClose_MouseEnter(object sender, EventArgs e)
        {
            BtnClose.BackColor = Utilidades.BtnCloseEnter;
        }

        private void BtnClose_MouseLeave(object sender, EventArgs e)
        {
            BtnClose.BackColor = Utilidades.BackTitulo;
        }
    }
}
