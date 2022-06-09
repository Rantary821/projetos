using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Menu : Form
    {     
        public Menu()
        {
            InitializeComponent();
        }
        public string nome;
        

        private void aluno_Click(object sender, EventArgs e)
        {
            CadastroAluno cadA = new CadastroAluno();
            if (!(Application.OpenForms.OfType<CadastroAluno>().Count() > 0))
            {
                cadA.MdiParent = this;
                cadA.Show(); // aqui
            }

            else
            {
                Application.OpenForms[cadA.Name].Focus(); // e aqui
            }

        }

        private void curso_Click(object sender, EventArgs e)
        {
            CadastroCurso form2 = new CadastroCurso(); // instanciei aqui pois irei usar em ambos os casos
            if (!(Application.OpenForms.OfType<CadastroCurso>().Count() > 0))
            {
                form2.MdiParent = this;
                form2.Show(); // aqui
            }

            else
            {
                Application.OpenForms[form2.Name].Focus(); // e aqui
            }
        }

        private void config_Click(object sender, EventArgs e)
        {
            configuracao confi = new configuracao();
            confi.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
