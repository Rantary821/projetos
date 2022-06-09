using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }
        public static string nome, rg, data, pasta, curso, conc, MConfig, xxx, conexao = "Persist Security info=False; server=localhost; database=grupolegal;uid=root", conexao2 = "Persist Security info=False; server=192.168.1.7; database=grupolegal;uid=aluno; password=etec-2016;";
        public static int numeroMatricula, idAluno, QuantMatriculas, minimo;
        
    }

}
