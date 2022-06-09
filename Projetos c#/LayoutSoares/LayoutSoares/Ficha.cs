using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using ScannerDemo;
using WindowsFormsApplication1;
using FileToIconTest;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO;

namespace LayoutSoares
{
    public partial class Ficha : Form
    {
        public Ficha()
        {
            InitializeComponent();
        }

        int clickArq = 0;

        void buscaArq(Control con)
        {
            System.Threading.Thread.Sleep(200);

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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PScanner scanner = new PScanner();
            scanner.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("abre a buscador de arquivos, ai só permite achar fotos, e joga a foto no picture e depois pede pra confirmar a foto");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WebCam cam = new WebCam();
            cam.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("pra buscar arquivos q ta num pendrive ou coisa assim");
        }

        private IntPtr Child = IntPtr.Zero;

        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        private void button8_Click(object sender, EventArgs e)
        {
             buscaArq(this);
        }

        private void pnlArq_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
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
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string CodAluno = "2";
            string dir = @"C:\Users\Otavio\Desktop\Nay\" + CodAluno;
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            else
            {

            }
        }
    }
}
