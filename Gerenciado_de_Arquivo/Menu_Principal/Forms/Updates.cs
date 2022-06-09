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
    public partial class Updates : Form
    {
        string dia, mes, diames, qnt;
        utilidades uti = new utilidades();
        public Updates()
        {
            InitializeComponent();

        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }
        void diaMes(string diaSemana, string diaMes, string mes)
        {
            #region tradutorDiaSemana
            if (diaSemana == "Sunday")
            {
                lblDia.Text = "Domingo";
            }
            else if (diaSemana == "Monday")
            {
                lblDia.Text = "Segunda - Feira";
            }
            else if(diaSemana == "Tuesday")
            {
                lblDia.Text = "Terça - Feira";
            }
            else if (diaSemana == "Wednesday")
            {
                lblDia.Text = "Quarta - Feira";
            }
            else if (diaSemana == "Thursday")
            {
                lblDia.Text = "Quinta - Feira";
            }
            else if (diaSemana == "Friday")
            {
                lblDia.Text = "Sexta - Feira";
            }
            else if (diaSemana == "Saturday")
            {
                lblDia.Text = "Sábado";
            }
            #endregion
            #region DiaMes
            if (mes == "1")
            {
                lblMes.Text = "de Janeiro";
            }
            else if (mes == "2")
            {
                lblMes.Text = "de Fevereiro";
            }
            else if (mes == "3")
            {
                lblMes.Text = "de Março";
            }
            else if (mes == "4")
            {
                lblMes.Text = "de Abril";
            }
            else if (mes == "5")
            {
                lblMes.Text = "de Maio";
            }
            else if (mes == "6")
            {
                lblMes.Text = "de Junho";
            }
            else if (mes == "7")
            {
                lblMes.Text = "de Julho";
            }
            else if (mes == "8")
            {
                lblMes.Text = "de Agosto";
            }
            else if (mes == "9")
            {
                lblMes.Text = "de Setembro";
            }
            else if (mes == "10")
            {
                lblMes.Text = "de Outubro";
            }
            else if (mes == "11")
            {
                lblMes.Text = "de Novembro";
            }
            else if (mes == "12")
            {
                lblMes.Text = "de Dezembro";
            }
            #endregion
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToShortTimeString();
            dia = DateTime.Now.DayOfWeek.ToString();
            mes = DateTime.Now.Month.ToString();
            lblDiaMes.Text = DateTime.Now.Day.ToString();
            diaMes(dia, diames, mes);
            uti.CountAlunos();
            double alunos = uti.countAlunos;
            qnt = Convert.ToString(alunos);
            qnt = qnt + " Alunos cadastrados";
            lblQntAluno.Text = qnt;
        }
    }
}
