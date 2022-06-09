using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Deployment;
using System.Deployment.Application;
using System.Security.Permissions;
using Microsoft.Win32;
using System.Diagnostics;

namespace Menu_Principal
{
    public partial class menu : Form
    {
        Updates up = new Updates(); // aba das atualizações

        Boolean ready = false;
        Boolean frmAberto;//pro efeito do menu não acontecer quando tem forma aberto
        public menu()
        {
            InitializeComponent();
        }

        void ButtonsCor()
        {
            BtncadAluno.FlatAppearance.BorderColor = Color.FromArgb(70, 70, 70);
            btnPesq.FlatAppearance.BorderColor = Color.FromArgb(70, 70, 70);
            BtnConfig.FlatAppearance.BorderColor = Color.FromArgb(70, 70, 70);
            BtnSair.FlatAppearance.BorderColor = Color.FromArgb(70, 70, 70);

            BtncadAluno.BackColor = Color.FromArgb(70, 70, 70);
            btnPesq.BackColor = Color.FromArgb(70, 70, 70);
            BtnConfig.BackColor = Color.FromArgb(70, 70, 70);
            BtnSair.BackColor = Color.FromArgb(70, 70, 70);
        }
        private void BtncadAluno_Click(object sender, EventArgs e)
        {
            ButtonsCor();
            BtncadAluno.BackColor = Color.FromArgb(40, 40, 40);
            BtncadAluno.FlatAppearance.BorderColor = Color.FromArgb(40, 40, 40);
            cadAluno cadA = new cadAluno();
            frmAberto = true;
            cadA.ShowDialog();
            frmAberto = false;
            mouseSai();
            ButtonsCor();
        }

        private void btnPesq_Click(object sender, EventArgs e)
        {
            ButtonsCor();
            btnPesq.BackColor = Color.FromArgb(40, 40, 40);
            btnPesq.FlatAppearance.BorderColor = Color.FromArgb(40, 40, 40);
            Pesquisa pesq = new Pesquisa();
            frmAberto = true;
            pesq.ShowDialog();
            frmAberto = false;
            mouseSai();
            ButtonsCor();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            string path = Program.Diretorio + @"\Perf\menu.txt", line;

           try
           {
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                LblMenu.Text = line;//Lateral//Maximizado

                if (LblMenu.Text == "Lateral")
                {
                    CheckMenu.Checked = false;

                    ImageMaxi.Visible = true;
                    ImageMini.Visible = false;

                    mostrarButtonsLateral();
                }
                else
                if (LblMenu.Text == "Maximizado")
                {
                    CheckMenu.Checked = true;
                    
                    ImageMaxi.Visible = false;
                    ImageMini.Visible = true;

                    mostrarButtonsMaximizado();
                }

                ready = true;
            }

            file.Dispose();
             }
             catch (Exception ex)
             {
                 if (!File.Exists(Program.Diretorio + @"\Perf\menu.txt"))
                 {
                     using (StreamWriter sw = File.CreateText(Program.Diretorio + @"\Perf\menu.txt"))
                     {
                         sw.WriteLine("Lateral");
                         sw.Dispose();
                         MessageBox.Show("deu ruim");

                         sw.Dispose();
                     }
                 }
             }

            utilidades uti = new utilidades();

            ButtonsCor();
            
            if (!Directory.Exists(Program.Diretorio))
            {
                Directory.CreateDirectory(Program.Diretorio);
            }

            if (!Directory.Exists(Program.AlunoCaminho))
            {
                Directory.CreateDirectory(Program.AlunoCaminho);
            }

            aumentaMenu();

            //Mostrar versão do programa, apenas quando instalado
            if (ApplicationDeployment.IsNetworkDeployed)
            {
                LblVersion.Text = string.Format("V.{0}", ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString(4));
            }

            uti.selectIdAluno();
            Program.id = uti.idd;
        }

        void aumentaMenu()
        {
            if(LblMenu.Text == "Lateral") //Lateral//Maximizado
            {
                var desktopWorkingArea = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea;
                this.Size = new Size(0, desktopWorkingArea.Bottom);
                this.Left = desktopWorkingArea.Right - this.Width;
                this.Top = 0;
            }
            if(LblMenu.Text == "Maximizado")
            {
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void menu_MouseLeave(object sender, EventArgs e)
        {
            panel1_MouseHover(sender, e);
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            mouseSai();
        }

        void mouseSai()
        {
            if (LblMenu.Text == "Lateral")
            {
                var desktopWorkingArea = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea;
                if (frmAberto != true)
                {
                    if (this.ClientRectangle.Contains(this.PointToClient(Cursor.Position)))
                    {
                        this.Opacity = 1.0;
                    }
                    else
                    {
                        int loopctr = 0;

                        for (loopctr = 100; loopctr >= 5; loopctr -= 10)
                        {
                            this.Opacity = loopctr / 99.0;
                            this.Refresh();
                            System.Threading.Thread.Sleep(10);


                            this.Size = new Size(this.Width - 14, desktopWorkingArea.Bottom);
                            this.Left = desktopWorkingArea.Right - this.Width;
                        }

                        this.Size = new Size(0, desktopWorkingArea.Bottom);
                        this.Left = desktopWorkingArea.Right - this.Width;

                        up.Visible = false; // aba das atualizações
                                            //  up1.Visible = false;
                    }
                }
            }
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            if (LblMenu.Text == "Lateral")
            {
                if (frmAberto != true)
                {
                    if (this.ClientRectangle.Contains(this.PointToClient(Cursor.Position)))
                    {
                        var desktopWorkingArea = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea;
                        this.Size = new Size(80, desktopWorkingArea.Bottom);
                        this.Left = desktopWorkingArea.Right - this.Width;
                        this.Opacity = 1.0;

                        up.Visible = true; //aba das atualizações
                        up.Left = desktopWorkingArea.Right - 650;
                        up.Top = desktopWorkingArea.Bottom - 200;
                    }
                }
            }
        }
        #region mouseLeave
        private void cadAluno_MouseLeave(object sender, EventArgs e)
        {
            mouseSai();
        }

        private void btnPesq_MouseLeave(object sender, EventArgs e)
        {
            mouseSai();
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            mouseSai();
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            mouseSai();
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            mouseSai();
        }
        #endregion

        private void button4_Click(object sender, EventArgs e)
        {
            bool turnOff = false;

            string dia = DateTime.Now.DayOfWeek.ToString().ToLower();
            if(dia == "friday")//friday
            {
                DialogResult confirm = MessageBox.Show("Deseja realizar o backup?", "Backup Semanal", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

                if (confirm.ToString().ToUpper() == "YES")
                {
                    this.Hide();
                    up.Hide();

                    DialogResult confirm2 = MessageBox.Show("Deseja desligar o computador ao final do backup?", "Backup Semanal", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                    if (confirm.ToString().ToUpper() == "YES")
                    {
                        turnOff = true;
                    }
                        utilidades uti = new utilidades();
                        uti.backupBanco();
                        
                    if(turnOff)
                    {
                        Process.Start("Shutdown", "-i");
                    }
                }
            }
            Application.Exit();
        }
        #region mouseHover

        private void BtncadAluno_MouseHover(object sender, EventArgs e)
        {
            panel1_MouseHover(sender, e);
        }

        private void btnPesq_MouseHover(object sender, EventArgs e)
        {
            panel1_MouseHover(sender, e);
        }

        private void BtnConfig_MouseHover(object sender, EventArgs e)
        {
            panel1_MouseHover(sender, e);
        }

        private void BtnSair_MouseHover(object sender, EventArgs e)
        {
            panel1_MouseHover(sender, e);
        }
        #endregion
        #region KeyDown

        private void menu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                BtncadAluno_Click(sender, e);
            }
            if (e.KeyCode == Keys.F3)
            {
                btnPesq_Click(sender, e);
            }
            if (e.KeyCode == Keys.F4)
            {
                BtnConfig_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                button4_Click(sender, e);
            }
        }
        #endregion
        private void BtnConfig_Click(object sender, EventArgs e)
        {
            Config config = new Config();
            config.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            utilidades uti = new utilidades();
            uti.TesteCadastros();
        }

        private void CheckMenu_CheckedChanged(object sender, EventArgs e)
        {
            if (ready == true)
            {
                if (CheckMenu.Checked == true)
                {
                    LblMenu.Text = "Maximizado";
                    ImageMaxi.Visible = true;
                    ImageMini.Visible = false;

                    using (StreamWriter sw = File.CreateText(Program.Diretorio + @"\Perf\menu.txt"))
                    {
                        sw.WriteLine("Maximizado");
                        sw.Dispose();
                    }
                }
                else
                if (CheckMenu.Checked == false)
                {
                    LblMenu.Text = "Lateral";
                    ImageMaxi.Visible = false;
                    ImageMini.Visible = true;

                    using (StreamWriter sw = File.CreateText(Program.Diretorio + @"\Perf\menu.txt"))
                    {
                        sw.WriteLine("Lateral");
                        sw.Dispose();
                    }
                }
                Application.Restart();
                Environment.Exit(0);

                ready = true;
            }
            else
            {
                ready = true;
            }

        }

        private void BtncadAluno2_Click(object sender, EventArgs e)
        {
            BtncadAluno_Click(sender, e);
        }

        private void btnPesq2_Click(object sender, EventArgs e)
        {
            btnPesq_Click(sender, e);
        }

        private void BtnConfig2_Click(object sender, EventArgs e)
        {
            BtnConfig_Click(sender, e);
        }

        private void BtnSair2_Click(object sender, EventArgs e)
        {
            button4_Click(sender, e);
        }

        void mostrarButtonsLateral()
        {
            BtncadAluno.Visible = true;
            btnPesq.Visible = true;
            BtnConfig.Visible = true;
            BtnSair.Visible = true;

            BtncadAluno2.Visible = false;
            btnPesq2.Visible = false;
            BtnConfig2.Visible = false;
            BtnSair2.Visible = false;
        }
        void mostrarButtonsMaximizado()
        {
            BtncadAluno.Visible = false;
            btnPesq.Visible = false;
            BtnConfig.Visible = false;
            BtnSair.Visible = false;

            BtncadAluno2.Visible = true;
            btnPesq2.Visible = true;
            BtnConfig2.Visible = true;
            BtnSair2.Visible = true;
        }

        private void ImageMaxi_Click(object sender, EventArgs e)
        {
            CheckMenu.Checked = true;
        }

        private void ImageMini_Click(object sender, EventArgs e)
        {
            CheckMenu.Checked = false;
        }
    }
}
