using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace SoaresTeste1
{
    public partial class Menu : Form
    {
        int X = 0;
        int Y = 0;
        public Menu()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(Menu_MouseDown);
            this.MouseMove += new MouseEventHandler(Menu_MouseMove);
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;

            string dir1 = @"C:\Fotos";
            if (!Directory.Exists(dir1))
            {
                Directory.CreateDirectory(dir1);
            }

            string dir = @"C:\Fotos\Perfil";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            string dir2 = @"C:\Fotos\Imgn";
            if (!Directory.Exists(dir2))
            {
                Directory.CreateDirectory(dir2);
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroAluno cadA = new CadastroAluno();
            cadA.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pesquisa pesq = new Pesquisa();
            pesq.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Configuracao config = new Configuracao();
            config.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (var process in Process.GetProcessesByName("WindowsFormsApplication1"))
            {
                process.Kill();
            }

            foreach (var process in Process.GetProcessesByName("FileToIconTest"))
            {
                process.Kill();
            }

            try
            {
                string path = @"C:\Fotos\Paths.txt";
                File.Delete(path);
            }
            catch (System.IO.IOException ex)
            {

            }
            Application.Exit();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Menu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void Menu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }
    }
}
