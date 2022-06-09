using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoaresTeste1
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
            Application.Run(new Ficha());
        }
    }
}

/*
 *    codigo para verificar se o aluno já tem pasta e se não tiver ele cria
 *    
            string dir = @"C:\Users\Otavio\Desktop\Nay\" + CodAluno;
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

 ******************************************************************************************

      codigo para verificar se já tem o bloco de notas e salvar o codigo do aluno lá... se não tiver ele cria e salva o codigo lá

            string path = @"C:\Users\Otavio\Desktop\Nay\CodAluno.txt";

            if (!File.Exists(path))
            {
                //e escrevo os dados necessários
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Codigo do aluno 1111");
                }
            }
            else
            {
                //caso o arquivo já exista
                //apenas adiciono a linha ao arquivo
                //faço isso passando o valor true, logo após 
                //o path no stream writer
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    sw.WriteLine("Codigo do aluno 1111");
                }
            }

**********************************************************************************************
* 
*       ler bloco de notas
*       
*           string Codigo;
            using (StreamReader reader = new StreamReader("caminho do bloco de notas"))
            {
                Codigo = reader.ReadLine();
            }
* 
* 
* ********************************************************************************************
* 
*           busca o executavel do projeto do arquivo (filetoicon) e abre dentro do panel de maneira certa
*           
* 
*           System.Threading.Thread.Sleep(200);

            //Se já existe um app carregado dentro do Panel, fecha ele
            if (Child != IntPtr.Zero)
            {
                Win32.CloseWindow(Child);
                Child = IntPtr.Zero;
            }

            System.Diagnostics.Process p = System.Diagnostics.Process.Start(@"C:\Users\Otavio\Desktop\Projetos c#\LayoutSoares\FileToIconTest\FileToIconTest\bin\Debug\FileToIconTest.exe");
            while (p.MainWindowHandle == IntPtr.Zero)
            {
                p.Refresh();
                System.Threading.Thread.Sleep(200);
            }

            Child = p.MainWindowHandle;

#if NO_STYLE
            //--------------------------------
            //Retira a barra de título e as bordas da Janela do app externo
            int winLong = Win32.GetWindowLong(Child, Win32.GWL_STYLE);

            winLong &= ~((int)Win32.WS.WS_CAPTION | (int)Win32.WS.WS_THICKFRAME |
                (int)Win32.WS.WS_MINIMIZE | (int)Win32.WS.WS_MAXIMIZE);

            winLong &= ~((int)Win32.WS.WS_EX_DLGMODALFRAME |
                (int)Win32.WS.WS_EX_CLIENTEDGE | (int)Win32.WS.WS_EX_STATICEDGE | (int)Win32.WS.WS_POPUP);

            Win32.SetWindowLong(Child, Win32.GWL_STYLE, winLong);

            //------------------------------
            //Define a janela do app externo como filha do Panel
#endif
            Win32.SetParent(Child, pnlArq.Handle);
            Win32.ShowWindow(Child, Win32.nCmdShow.SW_SHOWMAXIMIZED);
            //Define a posição e o tamanho da Janela dentro do Panel
#if NO_STYLE
            Win32.SetWindowPos(Child, IntPtr.Zero, 0, 0, panel1.Size.Width, panel1.Size.Height, (uint)((uint)Win32.SWPF.FRAMECHANGED
                | (uint)Win32.SWPF.NOZORDER | (uint)Win32.SWPF.NOOWNERZORDER));
#endif



 ***********************************************************************************************
 * 
 * 
 * 
 * 
*/
