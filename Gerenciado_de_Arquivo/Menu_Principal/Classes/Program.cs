using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_Principal
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
            Application.Run(new menu());
        }
        public static double id;
        public static string PastaAluno, Codigo, ClickPath = @"C:\Dropbox\FisoBarretos\ClickPath.txt", paths = @"C:\Dropbox\FisoBarretos\Paths.txt", Diretorio = @"C:\Dropbox\FisoBarretos", AlunoCaminho = @"C:\Dropbox\FisoBarretos\Perf\";
        public static string nome, rg, cpf, ra, sexo, nasc;

        public static string  ScanError = "false", path;
        public static int idImagem;
    }   
}
