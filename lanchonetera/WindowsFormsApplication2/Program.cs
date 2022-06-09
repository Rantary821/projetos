using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
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
            Application.Run(new Login());
        }
        public static string conexao = "Persist Security info=False; server=localhost; database=lanchonete;uid=root";
        public static string IdFuncionario, Nome, Rg, Cpf, ValorDiaria, dias;
        public static int IdUsuario;
        public static string VarCheckGoEstoq, VarCheckCadCliente, VarCheckCadFuncio, VarCheckDelCliente, VarCheckDelFuncio, VarCheckGoFichas, VarCheckGoProdutos, VarCheckVender, VarCheckUpdateCliente, VarCheckCadFornece, VarCheckPagamentos;
        public static string btnSim, btnNao, btnOk, PicAlert, PicInterrog, PicError, PicVendaOK, LblMessage, MessageResult;
    }
}
