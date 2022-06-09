using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using System.Drawing.Drawing2D;
using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack;
using System.Security.AccessControl;
using System.Threading;

namespace ArquivoEtec
{
    public partial class Arquivo : Form
    {
        Utilidades uti = new Utilidades();

        Image img;

        string name;

        Boolean checkYesNo;

        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Program.Folder = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                BuscaIamgens();
            }
            catch(Exception ex)
            {
               // MessageBox.Show(ex.ToString());
            }
        }

        private MySqlDataReader reader;
        private MySqlCommand cmd;

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            LimparRegistrosPaths();
        }

        [DllImport("Shlwapi.dll", CharSet = CharSet.Auto)]
        public static extern Int32 StrFormatByteSize(
            long fileSize,
            [MarshalAs(UnmanagedType.LPTStr)] StringBuilder buffer,
            int bufferSize);

        public Arquivo()
        {
            InitializeComponent();

            Cores();

            uti.GridviewColors(dataGridView1);
            uti.GridviewColors(dataGridView2);

            buscarPastas();

            dataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            Program.Folder = "";
        }

        // PictureBoxes we use to display thumbnails.
        private List<PictureBox> PictureBoxes = new List<PictureBox>();

        // Thumbnail sizes.
        private const int ThumbWidth = 120;//largura
        private const int ThumbHeight = 137;


        void BuscaIamgens()
        {
            foreach (PictureBox pic in PictureBoxes)
            {
                pic.MouseClick -= PictureBox_MouseClick;
                pic.Dispose();
            }

            LayoutPanel.Controls.Clear();
            PictureBoxes = new List<PictureBox>();

            if (!Directory.Exists(Program.Folder)) return;

            List<string> filenames = new List<string>();
            string[] patterns = { "*.*" };
            foreach (string pattern in patterns)
            {
                filenames.AddRange(Directory.GetFiles(Program.Folder,
                    pattern, SearchOption.TopDirectoryOnly));
            }
            filenames.Sort();

            foreach (string filename in filenames)
            {

                PictureBox pic = new PictureBox();

                try
                {
                    using (var bmpTemp = new Bitmap(filename))
                    {
                        img = bmpTemp.GetThumbnailImage(90, 110, () => false, IntPtr.Zero);

                        bmpTemp.Dispose();
                    }
                }
                catch
                {
                    ShellFile shellFile = ShellFile.FromFilePath(filename);
                    Bitmap shellThumb = shellFile.Thumbnail.ExtraLargeBitmap;

                    shellThumb.MakeTransparent();

                    img = shellThumb.GetThumbnailImage(81, 100, () => false, IntPtr.Zero);
                }

                pic.ClientSize = new Size(ThumbWidth, ThumbHeight);
                pic.Image = img;
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                pic.MouseClick += PictureBox_MouseClick;

                FileInfo file_info = new FileInfo(filename);
                tipPicture.SetToolTip(pic, file_info.Name +
                    "\nCreated: " + file_info.CreationTime.ToShortDateString() +
                    "\n(" + pic.Image.Width + " x " + pic.Image.Height + ") " +
                    ToFileSizeApi(file_info.Length));
                pic.Tag = file_info;

                name = Path.GetFileNameWithoutExtension(pic.Tag.ToString());

                string VerifyName1, VerifyName2;

                VerifyName1 = pic.Tag.ToString();
                //////////////////////////////

                int count = 0;

                if(Program.paths.Count() != 0)
                {
                    do
                    {
                        VerifyName2 = Program.paths[count];

                        if (VerifyName1 == VerifyName2)
                        {
                            pic.BackColor = Utilidades.SelectArqBackColor;
                        }
                        count++;
                    }
                    while (count <= (Program.paths.Count() - 1));
                }  

                CustomControl c = new CustomControl(pic, new Label { Text = name });
                LayoutPanel.Controls.Add(c);

            }

            filenames.Clear();
        }

        public class CustomControl : Control
        {
            private PictureBox _Pic;
            private Label _label;
            public CustomControl(PictureBox Picture, Label label)
            {
                _Pic = Picture;
                _label = label;
                Height = Picture.Height + label.Height;
                Width = Math.Max(Picture.Width, label.Width);
                Controls.Add(_Pic);
                _Pic.Location = new Point(0, 0);
                Controls.Add(_label);
                _label.Location = new Point(-3, Picture.Height);
                _label.Font = new Font("Arial", 8, FontStyle.Regular);
                _label.ForeColor = Utilidades.ForeLbl;
            }
        }

        public static string ToFileSizeApi(long file_size)
        {
            StringBuilder sb = new StringBuilder(20);
            StrFormatByteSize(file_size, sb, 20);
            return sb.ToString();
        }

        private void PictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            PictureBox pic = sender as PictureBox;

            FileInfo file_into = pic.Tag as FileInfo;

            switch (e.Button)
            {
                //Botão esquerdo do mouse
                case MouseButtons.Left:

                    if (pic.BackColor == LayoutPanel.BackColor)
                    {
                        pic.BackColor = Utilidades.SelectArqBackColor;

                        Program.paths.Add(file_into.ToString());

                        CopiarSelecionados(file_into.ToString(), "Copy");

                        Program.ImputTextPath = file_into.ToString();
                    }
                    else
                    if (pic.BackColor != LayoutPanel.BackColor)
                    {
                        pic.BackColor = LayoutPanel.BackColor;

                        int index = Program.paths.IndexOf(file_into.ToString());

                        Program.paths.RemoveAt(index);

                        CopiarSelecionados(file_into.ToString(), "Dell");
                    }

                    selecionados();

                    break;

                //Botão direito do mouse
                case MouseButtons.Right:

                    break;
            }
        }

        void selecionados()
        {
            this.dataGridView2.Rows.Clear();

            int count = 0;
            if (Program.paths.Count() != 0)
            {
                do
                {
                    string nome = Path.GetFileNameWithoutExtension(Program.paths[count]);

                    this.dataGridView2.Rows.Insert(count, nome);

                    count++;
                }
                while (count <= (Program.paths.Count() - 1));
            }
        }

        private void MenuStripRenomear_Click(object sender, EventArgs e)
        {
            if(Program.paths.Count() == 1)
            {
                LimparRegistrosPaths();
                Renomear textB = new Renomear();
                textB.ShowDialog();
               
                if(Program.newname != "")//para caso tiver cancelado o rename
                {
                    string destFile, ext;

                    ext = Path.GetExtension(Program.ImputTextPath);
                    destFile = Path.GetDirectoryName(Program.ImputTextPath) + @"\" + Program.newname + ext;

                    if (File.Exists(destFile))
                    {
                        uti.ApelMessageBox("Já existe um documento '" + Path.GetFileNameWithoutExtension(destFile) + "' no diretorio, deseja substitui-lo ou manter ambos?; Substituir ou manter arquivos?;", "btn1; btn2; btn3;", "Substituir; Manter; Cancelar;", "Alert");
                        if (Program.MBResposta.Contains("Substituir"))
                        {
                            File.Delete(destFile);
                            File.Move(Program.ImputTextPath, destFile);
                        }
                        else
                        if (Program.MBResposta.Contains("Manter"))
                        {
                            int count = 1;
                            Boolean test = true;
                            do
                            {
                                if (!File.Exists(Path.GetDirectoryName(destFile) + @"\" + Path.GetFileNameWithoutExtension(destFile) + " " + "(" + count + ")" + Path.GetExtension(destFile)))
                                {
                                    File.Copy(Program.ImputTextPath, Path.GetDirectoryName(destFile) + @"\" + Path.GetFileNameWithoutExtension(destFile) + " " + "(" + count + ")" + Path.GetExtension(destFile), true);
                                    test = true;
                                }
                                else
                                {
                                    test = false;
                                    count++;
                                }
                            }
                            while (test == false);
                        }

                    LimparRegistrosPaths();
                    }
                    else
                    {
                        File.Delete(destFile);
                        File.Move(Program.ImputTextPath, destFile);

                        LimparRegistrosPaths();
                    }
                }
            }
            else
            if(Program.paths.Count() > 1)
            {
                uti.ApelMessageBox("Selecione apenas um documento para renomear por vez!;Varios documentos selecionados!!", "btn3;", "Ok;", "Alert");
            }
            else
            if (Program.paths.Count() == 0)
            {
                uti.ApelMessageBox("Selecione o documento que deseja renomear!;Nenhum documento selecionado!!", "btn3;", "Ok;", "Alert");
            }
        }//Renomar Documento

        private void MenuStripAbrir_Click(object sender, EventArgs e)//Abrir Documentos
        {
            if (Program.paths.Count() != 0)
            {
                Program.PathsImg.Clear();

                string[] files = Directory.GetFiles(Program.Temp);
                foreach (var FileSource in files)
                {
                    System.Diagnostics.Process.Start(FileSource);
                }
            }
        }

        private void MenuStripCopiar_Click(object sender, EventArgs e)//Copiar Documento
        {
            Program.TypeCopy = "Copy";
        }

        private void MenuStripRecortar_Click(object sender, EventArgs e)//Recortar Documento
        {
            Program.TypeCopy = "Cut";
            dataGridView1_CellClick(this.dataGridView1, new DataGridViewCellEventArgs(0, 0));

        }

        private void MenuStripExcluir_Click(object sender, EventArgs e)
        {
            if (Program.paths.Count() != 0)
            {
                //Alert   Check   Error   Quest
                uti.ApelMessageBox("Deseja mesmo excluir o(s) documentos selecionados?; Excluir Documentos!!;", "btn1; btn2;", "Sim; Não;", "Quest");
                if (Program.MBResposta.Contains("Sim"))
                {
                    int count = 0;
                    do
                    {
                        File.Delete(Program.paths[count]);

                        count++;
                    }
                    while (count <= (Program.paths.Count() - 1));

                    LimparRegistrosPaths();
                }
            }
        }//Excluir Documento

        private void MenuStripResetar_Click(object sender, EventArgs e)
        {
            LimparRegistrosPaths();
        }//Resetar Documentos selecionados



        private void MenuStripColar_Click(object sender, EventArgs e)
        {
            if (Program.paths.Count() != 0 && Program.TypeCopy != "")
            {
                string PathDestino = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value.ToString());

                string[] files = Directory.GetFiles(Program.Temp);
                foreach (var FileName in files)
                {

                    if (File.Exists(PathDestino + @"\" + Path.GetFileName(FileName)))
                    {
                        verifyArquivo(FileName, PathDestino + @"\" + Path.GetFileName(FileName));
                    }
                    else
                    {
                        File.Copy(FileName, PathDestino + @"\" + Path.GetFileName(FileName), true);
                    }
                }
                checkYesNo = true;

                if (checkYesNo == true)
                {
                    if (Program.TypeCopy == "Cut")
                    {
                        int count = 0;
                        do
                        {
                            File.Delete(Program.paths[count]);

                            count++;
                        }
                        while (count <= (Program.paths.Count() - 1));
                    }
                }
                LimparRegistrosPaths();
                Program.TypeCopy = "";
                Program.MBChecked = "";
            }
        }//Colar documentos

        private void MenuStripNovaPasta_Click(object sender, EventArgs e)
        {
            string Novapasta = "Nova Pasta";
            int count = 1, fim = 0;

            if (!Directory.Exists(Program.PathAuno + Novapasta))
            {
                Directory.CreateDirectory(Program.PathAuno + Novapasta);
                this.dataGridView1.Rows.Insert(0, Novapasta, Program.PathAuno + Novapasta);
            }
            else
            {
                do
                {
                    if (!Directory.Exists(Program.PathAuno + Novapasta + "(" + count + ")"))
                    {
                        Directory.CreateDirectory(Program.PathAuno + Novapasta + "(" + count + ")");
                        fim = 1;

                        this.dataGridView1.Rows.Insert(0, Novapasta + "(" + count + ")", Program.PathAuno + Novapasta + "(" + count + ")");
                    }
                    else
                    {
                        count++;
                    }
                }
                while (fim == 0);
            }
            buscarPastas();
        }//Criar nova pasta

        private void MenuStripExcluirG_Click(object sender, EventArgs e)//Excluir pasta
        {
            string Folder = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value.ToString());

            if (Folder != Path.GetDirectoryName(Folder) + @"\Lixeira")
            {
                if (Directory.GetFileSystemEntries(Folder).Length > 0)
                {
                    uti.ApelMessageBox("Deseja salvar os documentos existentes nesta pasta?; Excluir Pasta!;", "btn1; btn2; btn3;", "Sim; Não; Cancelar;", "Alert");
                    if (Program.MBResposta.Contains("Sim"))
                    {
                        string PathDestino = Program.PathAuno + "Lixeira";

                        if (!Directory.Exists(PathDestino))
                        {
                            Directory.CreateDirectory(PathDestino);
                        }

                        string[] files = Directory.GetFiles(Folder);
                        foreach (var FileName in files)
                        {
                            string pathDest = PathDestino + @"\" + Path.GetFileName(FileName);

                            Program.MBResposta = "Manter";
                            Program.MBChecked = "Checked";

                            verifyArquivo(FileName, pathDest);

                            File.Delete(FileName);
                        }
                    }
                    if (Program.MBResposta.Contains("Não"))
                    {
                        Directory.Delete(Folder, true);                        
                    }
                }
                else
                {
                    Directory.Delete(Folder, true);
                }
            }
            else
            {
                Directory.Delete(Folder, true);
            }

            Program.MBResposta = "";
            Program.MBChecked = "";
            LimparRegistrosPaths();
            buscarPastas();
        }

        private void MenuStripRenomearG_Click(object sender, EventArgs e)//Renomear pasta
        {
            string Folder = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value.ToString()); //Pega o caminho da pasta que fica na segunda coluna do grid das pastas, coluna é oculta

            Program.ImputTextPath = Path.GetFileName(Folder); //ImputTextPath - variavel usada no form renomear

            LimparRegistrosPaths();
            Renomear rename = new Renomear();
            rename.ShowDialog();

            if (Program.newname != "Apel.cancel")//para caso tiver cancelado o renomeamento
            {
                if (!Directory.Exists(Program.PathAuno + Program.newname))//newname - Variavel com o novo nome escolhido
                {
                    string[] files = Directory.GetFiles(Folder);
                    foreach (var FileName in files)
                    {
                        File.Move(FileName, Program.Temp + Path.GetFileName(FileName));
                    }

                    Directory.Delete(Folder);

                    Directory.CreateDirectory(Program.PathAuno + Program.newname);

                    string[] files2 = Directory.GetFiles(Program.Temp);
                    foreach (var FileName in files2)
                    {
                        File.Move(FileName, Program.PathAuno + Program.newname + @"\" + Path.GetFileName(FileName));
                    }

                    LimparRegistrosPaths();
                    buscarPastas();
                }
            }
        }

        void buscarPastas()//Atualiza/Busca todos as pastas que o aluno possui
        {
            this.dataGridView1.Rows.Clear();

            Program.PathAuno = Program.PastaSistema + Program.Id + @"\";

            string[] fileArray = Directory.GetDirectories(Program.PathAuno);
            for (int i = 0; i < fileArray.Length; i++)
            {
                this.dataGridView1.Rows.Insert(0, Path.GetFileName(fileArray[i]), fileArray[i]);
            }
        }

        void verifyArquivo(string file, string PathDestino)
        {
            //Alert   Check   Error   Quest

            string name = Path.GetFileName(PathDestino);

            if (Program.MBChecked != "Checked")
            {
                uti.ApelMessageBox("Já existe um documento '" + name + "' no diretorio, deseja substitui-lo ou manter ambos?;Substituir ou manter arquivos", "btn1; btn2; btncheck;", "Substituir; Manter; Fazer o mesmo para todos?;", "A");
            }

            if (Program.MBResposta.Contains("Substituir"))
            {
                File.Copy(file, PathDestino, true);
            }
            else
            if (Program.MBResposta.Contains("Manter"))
            {
                int count = 1;
                Boolean test = true;
                do
                {
                    if (!File.Exists(Path.GetDirectoryName(PathDestino) + @"\" + Path.GetFileNameWithoutExtension(PathDestino) + " " + "(" + count + ")" + Path.GetExtension(PathDestino)))
                    {
                        File.Copy(file, Path.GetDirectoryName(PathDestino) + @"\" + Path.GetFileNameWithoutExtension(PathDestino) + " " + "(" + count + ")" + Path.GetExtension(PathDestino), true);
                        test = true;
                    }
                    else
                    {
                        test = false;
                        count++;
                    }
                }
                while (test == false);
            }
            else
            {
                checkYesNo = false;
            }
        }//Caso arquivo já exista da opção de substituir ou manter copia do mesmo

        private void MenuStripGrid_Opening(object sender, CancelEventArgs e)//esconder botõa colar se nada estiver selecionado 
        {
            if (Program.paths.Count() > 0 && Program.TypeCopy != "")
            {
                MenuStripColar.Visible = true;
            }
            else
            if (Program.paths.Count() == 0 || Program.TypeCopy == "")
            {
                MenuStripColar.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void LimparRegistrosPaths()//limpa os registro dos arquivos selecionados e atualiza a lista
        {
            if (Directory.Exists(Program.Temp))
            {
                DirectoryInfo di = new DirectoryInfo(Program.Temp);

                foreach (FileInfo file in di.GetFiles())
                {
                    file.Delete();
                }
            }
            else
            {
                Directory.CreateDirectory(Program.Temp);
            }

            Program.paths.Clear();

            selecionados();
            dataGridView1_CellClick(dataGridView1, new DataGridViewCellEventArgs(0, 0));
        }

        void CopiarSelecionados(string path, string copyORdell)//função para copiar os arquivos selecionados para a pasta temporaria
        {
            if(!Directory.Exists(Program.Temp))
            {
                Directory.CreateDirectory(Program.Temp);
            }

            if (copyORdell == "Copy")
            {
                string dest = Program.Temp + Path.GetFileName(path);
                File.Copy(path, dest, true);

                dest = "";
            }

            if (copyORdell == "Dell")
            {
                string dest = Program.Temp + Path.GetFileName(path);
                try
                {
                    File.Delete(dest);
                }
                catch
                {
                    Thread.Sleep(2000);
                    File.Delete(dest);
                }
            }
        }

        void Cores()//Preenchimento das cores do tema
        {
            lblTitulo.ForeColor = Utilidades.ForeTitulo;
            lblTitulo.BackColor = Utilidades.BackTitulo;

            lblPasta.ForeColor = Utilidades.ForeTitulo;
            lblPasta.BackColor = Utilidades.BackTitulo;

            lblSelec.ForeColor = Utilidades.ForeTitulo;
            lblSelec.BackColor = Utilidades.BackTitulo;



            this.BackColor = Utilidades.BackForm;
            LayoutPanel.BackColor = Utilidades.BackForm;
        }
    }
}
