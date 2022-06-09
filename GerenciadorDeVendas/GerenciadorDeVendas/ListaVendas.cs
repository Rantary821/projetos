using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeVendas
{
    public partial class ListaVendas : Form
    {
        public ListaVendas()
        {
            InitializeComponent();
        }

        private void ListaVendas_Load(object sender, EventArgs e)
        {
            BtnClose.FlatAppearance.BorderSize = 0;
            BtnNovaVenda.FlatAppearance.BorderSize = 0;
            BtnExcluir.FlatAppearance.BorderSize = 0;
            BtnCancel.FlatAppearance.BorderSize = 0;

            if(Program.venceu == "s")
            {
                BtnNovaVenda.Enabled = false;
                BtnExcluir.Enabled = false;
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (TxtPreco.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void BtnNovaVenda_Click(object sender, EventArgs e)
        {
            Venda venda = new Venda();
            venda.Location = new Point(
            venda.Left = Program.x,
            venda.Top = Program.Y);
            venda.ShowDialog();
        }

        private void ListaVendas_KeyDown(object sender, KeyEventArgs e)
        {
            if (Program.venceu != "s")
            {
                if (e.KeyCode == Keys.F1)
                {
                    if (BtnNovaVenda.Enabled == true)
                    {
                        BtnNovaVenda_Click(sender, e);
                    }
                }
                if (e.KeyCode == Keys.F2)
                {
                    if (BtnExcluir.Enabled == true)
                    {
                        BtnExcluir_Click(sender, e);
                    }
                }
                if (e.KeyCode == Keys.F3)
                {
                    if (BtnCancel.Enabled == true)
                    {
                        BtnCancel_Click(sender, e);
                    }
                } 
            }
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
