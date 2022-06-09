using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ArquivoEtec
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

        public static string conecta = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + Path.GetPathRoot(Environment.SystemDirectory)  + @"Dropbox\Projetos c# - Backup\ArquivoRaphaelBrandao\Banco\DataBase\ArquivoEtec.mdf;Integrated Security=false;Min Pool Size=0;Max Pool Size=1000000; Connect Timeout=3";
        public static string conecta2 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Dropbox\Projetos c# - Backup\ArquivoRaphaelBrandao\Banco\DataBase\BancoStecSQL.mdf;Integrated Security=True;Connect Timeout=30";
        //Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\YoungSIR\Desktop\Arquivo\Morto.mdb
        //arquivos
        public static string PastaSistema = Path.GetPathRoot(Environment.SystemDirectory) + @"\\Dropbox\Projetos c# - Backup\ArquivoRaphaelBrandao\Banco\Alunos\", Id;
        public static string Folder, Temp = PastaSistema + @"Temp\", TypeCopy = "";
        public static string PathAuno; //PastaSistema + Id + @"\"; 

        public static List<string> paths = new List<string>(); 

        
        public static string ImputTextPath, newname;

        //ApelMessageBox
        public static string MBButtons, MBButtonsText, MBLabels, MBIco, MBResposta, MBChecked;
        public static int index;

        public static List<string> PathsImg = new List<string>();


        //Scanner
        public static string ScanError = "false";
    }
}
