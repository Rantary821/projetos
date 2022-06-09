using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteMostrarImagens
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
            Application.Run(new Arquivo());
        }

        public static string PastaSistema = Environment.ExpandEnvironmentVariables(@"%ProgramFiles(x86)%\Apel\Etec\");
        public static string Folder, Temp = PastaSistema + @"Temp\", TypeCopy = "";
        public static string PathAuno = PastaSistema + @"0\"; 

        public static List<string> paths = new List<string>();

        
        public static string ImputTextPath, newname;

        //ApelMessageBox
        public static string MBButtons, MBButtonsText, MBLabels, MBIco, MBResposta, MBChecked;
        public static int index;

        public static List<string> PathsImg = new List<string>();
    }
}
