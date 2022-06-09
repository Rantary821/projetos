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

namespace Menu_Principal
{
    public partial class Ficha : Form
    {      
        int index, X,Y;

        Boolean exit;

        string FullNameArq;

        Image img;

        string PastaAluno;
        string nomearq;

        Image capturaImagem;
        public string PathSaveImg = null;

        Boolean ready, priE, priC, priT;
        int celIndex, telIndex, emailIndex;
        string update, Cel1, Cel2, Tel1, Tel2, Email1, Email2;

        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private MySqlDataReader reader;
        private MySqlCommand cmd;

        string local; 

        [DllImport("Shlwapi.dll", CharSet = CharSet.Auto)]
        public static extern Int32 StrFormatByteSize(
            long fileSize,
            [MarshalAs(UnmanagedType.LPTStr)] StringBuilder buffer,
            int bufferSize);

        public Ficha()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(label9_MouseDown);
            this.MouseMove += new MouseEventHandler(label9_MouseMove);
        }

        private void Ficha_Load(object sender, EventArgs e)
        {
            string path2 = @"C:\Dropbox\FisoBarretos\CA.txt";

            File.Delete(path2);

            using (StreamWriter sw = File.CreateText(path2))
            {
                sw.WriteLine(Program.id);
                sw.Dispose();
            }

            string path = Program.AlunoCaminho + Program.id + ".png";
            if (File.Exists(path))
            {
                Image img;
                using (var bmpTemp = new Bitmap(path))
                {
                    img = new Bitmap(bmpTemp);
                    PicPerfil.BackgroundImage = img;
                    PicPerfil.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }

            Program.PastaAluno = @"C:\Dropbox\FisoBarretos\" + Program.id;

            if (File.Exists(Program.ClickPath))
            {
                File.Delete(Program.ClickPath);
            }

            if (File.Exists(Program.paths))
            {
                File.Delete(Program.paths);
                using (StreamWriter sw = File.CreateText(Program.paths))
                {
                    sw.Dispose();
                }
            }
            else
            if (!File.Exists(Program.paths))
            {
                using (StreamWriter sw = File.CreateText(Program.paths))
                {
                    sw.Dispose();
                }
            }
            BuscaIamgens();

            utilidades uti = new utilidades();
            double id = Program.id;
            uti.fichaLoad(Convert.ToInt16(id), TxtName, TxtCpf, TxtRg, TxtRa, TxtNasc, TxtSexo,txtEmail,txtTel,txtCel);

            Program.nome = TxtName.Text;
            Program.cpf = TxtCpf.Text;
            Program.rg = TxtRg.Text;
            Program.ra = TxtRa.Text;
            Program.nasc = TxtNasc.Text;
            Program.sexo = TxtSexo.Text;



            Cel1 = txtCel.Items[0].ToString();
            Cel2 = txtCel.Items[1].ToString();

            Tel1 = txtTel.Items[0].ToString();
            Tel2 = txtTel.Items[1].ToString();
            Email1 = txtEmail.Items[0].ToString();
            Email2 = txtEmail.Items[1].ToString();

            txtCel.SelectedIndex = 0;
            txtTel.SelectedIndex = 0;
            txtEmail.SelectedIndex = 0;
            BtnAtualiza.Enabled = false;
            ready = true;
        }

        void LimpalayoutPanel()
        {
            //Liberar todo o espaço da memoria q o Layout panel usa
            List<Control> listControls = new List<Control>();

            foreach (Control control in LayoutPanel.Controls)
            {
                listControls.Add(control);
            }

            foreach (Control control in listControls)
            {
                LayoutPanel.Controls.Remove(control);
                control.Dispose();
            }
        }
        // PictureBoxes we use to display thumbnails.
        private List<PictureBox> PictureBoxes = new List<PictureBox>();

        // Thumbnail sizes.
        private const int ThumbWidth = 142;//largura
        private const int ThumbHeight = 150;

        void BuscaIamgens()
        {
            foreach (PictureBox pic in PictureBoxes)
            {
                pic.MouseClick -= PictureBox_MouseClick;
                pic.Dispose();
            }
            
            LayoutPanel.Controls.Clear();
            PictureBoxes = new List<PictureBox>();

            if (!Directory.Exists(Program.PastaAluno)) return;

            List<string> filenames = new List<string>();
            string[] patterns = {"*.*" };
            foreach (string pattern in patterns)
            {
                filenames.AddRange(Directory.GetFiles(Program.PastaAluno,
                    pattern, SearchOption.TopDirectoryOnly));
            }
            filenames.Sort();
            
            foreach (string filename in filenames)
            {
                PictureBox pic = new PictureBox();
               
                using (var bmpTemp = new Bitmap(filename))
                {
                     img = bmpTemp.GetThumbnailImage(90, 110, () => false, IntPtr.Zero);
                     bmpTemp.Dispose(); 
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
               
                string name = Path.GetFileNameWithoutExtension(pic.Tag.ToString());

                CustomControl c = new CustomControl(pic, new Label { Text = name });
                LayoutPanel.Controls.Add(c);
            }
            //img.Dispose();
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
                Width = Math.Max(Picture.Width, label.Width + 20);
                Controls.Add(_Pic);
                _Pic.Location = new Point(0, 0);
                Controls.Add(_label);
                _label.Location = new Point(15, Picture.Height);
                _label.Font = new Font("Arial", 8, FontStyle.Bold);
            }
        }

        // Return a file size created by the StrFormatByteSize API function.
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
                        pic.BackColor = Color.FromArgb(234, 123, 0);
                        pic.BorderStyle = BorderStyle.FixedSingle;

                        File.AppendAllText(Program.paths, string.Format("{0}{1}", file_into, Environment.NewLine));
                    }
                    else
                    if (pic.BackColor != LayoutPanel.BackColor)
                    {
                        pic.BackColor = LayoutPanel.BackColor;
                        pic.BorderStyle = BorderStyle.None;


                        string search_text = file_into.ToString();
                        string old;
                        string n = "";
                        StreamReader sr = File.OpenText(Program.paths);
                        while ((old = sr.ReadLine()) != null)
                        {
                            if (!old.Contains(search_text))
                            {
                                n += old + Environment.NewLine;
                            }
                        }
                        sr.Close();
                        File.WriteAllText(Program.paths, n);
                    }
                    break;
                //Botão direito do mouse
                case MouseButtons.Right:

                    if (File.Exists(Program.ClickPath))
                    {
                        File.Delete(Program.ClickPath);

                        using (StreamWriter sw = File.CreateText(Program.ClickPath))
                        {
                            sw.Write(file_into);
                            sw.Dispose();
                        }
                    }
                    else
                    if (!File.Exists(Program.ClickPath))
                    {
                        using (StreamWriter sw = File.CreateText(Program.ClickPath))
                        {
                            sw.Write(file_into);
                            sw.Dispose();
                        }
                    }

                    ZoomIMG imge = new ZoomIMG();
                    imge.ShowDialog();
                    break;
            }      
        }
        
        private void BtnClose_Click(object sender, EventArgs e)
        {
            string path2 = @"C:\Dropbox\FisoBarretos\CA.txt";
            File.Delete(path2);
            //LimpalayoutPanel();
            File.Delete(Program.paths);
            this.Close();
        }

        private void BuscarImagens_Click(object sender, EventArgs e)
        {
            this.BuscaImagem.Multiselect = true;
            this.BuscaImagem.Title = "Selecionar Arquivos";
            BuscaImagem.InitialDirectory = @"C:";
            //filtra para exibir somente arquivos de imagens
            BuscaImagem.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "|*.*";
            BuscaImagem.CheckFileExists = true;
            BuscaImagem.CheckPathExists = true;
            BuscaImagem.FilterIndex = 2;
            BuscaImagem.RestoreDirectory = true;
            BuscaImagem.ReadOnlyChecked = true;
            BuscaImagem.ShowReadOnly = true;


            string ext;
            DialogResult dr = this.BuscaImagem.ShowDialog();
           
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                foreach (String arquivo in BuscaImagem.FileNames)
                {
                    string Nome = Path.GetFileNameWithoutExtension(arquivo);

                    FullNameArq = Program.PastaAluno + @"\" + Nome + ".png";

                    if (File.Exists(FullNameArq))
                    {
                        
                        nomearq += arquivo;
                        ext = Path.GetExtension(nomearq);

                        nomearq = Path.GetFileNameWithoutExtension(nomearq);
                        int i = 1;
                        
                        do
                        {
                            FullNameArq = "";
                            FullNameArq = Program.PastaAluno + @"\" + nomearq + "-" + i + ".png";

                            if (File.Exists(FullNameArq))
                            {
                                exit = false;
                                i++;
                            }
                            else
                            {
                                exit = true;
                            }
                        }
                        while (exit == false);
                    }
                    
                    PictureBox pb = new PictureBox();

                    Image Imag = Image.FromFile(arquivo);

                    string Save = FullNameArq;

                    QualityLevel(Imag, Save);
                }
                LimpalayoutPanel();
                BuscaIamgens();
            }
        }

        void ImageBackup(string path, string id, string tipo)
        {

        }

        private void QualityLevel(Image img, string PathSave)//funfa
        {
            try
            {
                using (var bitmap = new Bitmap(img))
                {
                    using (Bitmap Bit = new Bitmap(bitmap))
                    {
                        ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);

                        System.Drawing.Imaging.Encoder myEncoder = System.Drawing.Imaging.Encoder.Quality;

                        EncoderParameters myEncoderParameters = new EncoderParameters(1);

                        EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, 60L);

                        myEncoderParameters.Param[0] = myEncoderParameter;

                        Bit.Save(PathSave, jpgEncoder, myEncoderParameters);

                        Bit.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }

        private void BuscaFoto_Click(object sender, EventArgs e)
        {
            PicPerfil.BackgroundImage.Dispose();

            this.BuscaImagem.Multiselect = true;
            this.BuscaImagem.Title = "Selecionar Fotos";
            BuscaImagem.InitialDirectory = @"C:";
            //filtra para exibir somente arquivos de imagens
            BuscaImagem.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "|*.*";
            BuscaImagem.CheckFileExists = true;
            BuscaImagem.CheckPathExists = true;
            BuscaImagem.FilterIndex = 2;
            BuscaImagem.RestoreDirectory = true;
            BuscaImagem.ReadOnlyChecked = true;
            BuscaImagem.ShowReadOnly = true;

            DialogResult dr = this.BuscaImagem.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                foreach (String arquivo in BuscaImagem.FileNames)
                {
                    nomearq += arquivo;
                    nomearq = Path.GetFileName(nomearq);
                    PictureBox pb = new PictureBox();
                    Image Imagem = Image.FromFile(arquivo);
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb.Height = Imagem.Height;
                    pb.Width = Imagem.Width;                  
                    pb.Image = Imagem;

                    if (System.IO.File.Exists(Program.AlunoCaminho + Program.id + ".png"))
                    {
                        DialogResult confirm = MessageBox.Show("Deseja substituir a foto existente?", "Foto existente!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

                        if (confirm.ToString().ToUpper() == "YES")
                        {
                            PathSaveImg = Program.AlunoCaminho + Program.id + ".png";

                            File.Delete(PathSaveImg);

                            pb.Image.Save(PathSaveImg);

                            PicPerfil.BackgroundImage = pb.Image;

                            MessageBox.Show("Foto salva com sucesso");
                        }
                    }
                    else
                    {
                        PathSaveImg = Program.AlunoCaminho + Program.id + ".png";

                        File.Delete(PathSaveImg);

                        pb.Image.Save(PathSaveImg);

                        PicPerfil.BackgroundImage = pb.Image;

                        MessageBox.Show("Foto salva com sucesso");
                    }
                }
            }
        }

        private void TxtSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Atualizacao(this);
        }

        private void btnCam_Click(object sender, EventArgs e)
        {
            string local;
            try
            {
                PicPerfil.BackgroundImage.Dispose();
            }
            catch(Exception ex)
            {

            }
            
            using (StreamReader reader = new StreamReader(@"C:\Dropbox\FisoBarretos\exepath\ExePath.txt"))
            {
                local = reader.ReadLine();
            }

            Process myProcess = System.Diagnostics.Process.Start(local);

            myProcess.WaitForExit();

            System.Threading.Thread.Sleep(1);

            string path = Program.AlunoCaminho + Program.id + ".png";
            if (File.Exists(path))
            {
                Image img;
                using (var bmpTemp = new Bitmap(path))
                {
                    img = new Bitmap(bmpTemp);
                    PicPerfil.BackgroundImage = img;
                    PicPerfil.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void btnApaga_Click(object sender, EventArgs e)
        {
            try
            {
                string line;
                string path = @"C:\Dropbox\FisoBarretos\Paths.txt";
                string deleteArq;

                DialogResult confirm = MessageBox.Show("Deseja mesmo excluir este(s) arquivo(s)?", "Excluir arquivo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

                if (confirm.ToString().ToUpper() == "YES")
                {
                    System.IO.StreamReader file = new System.IO.StreamReader(path);
                    while ((line = file.ReadLine()) != null)
                    {
                        deleteArq = line;
                        File.Delete(deleteArq);
                    }
                    file.Dispose();
                    File.Delete(path);
                }
                LimpalayoutPanel();
                BuscaIamgens();
            }
            catch (System.IO.FileNotFoundException ex)
            {
                MessageBox.Show("Selecione um arquivo!");
            }
        }

        private void btnImagens_Click(object sender, EventArgs e)
        {
            Imagens imgs = new Imagens();
            imgs.ShowDialog();
        }

        private void BtnScam_Click(object sender, EventArgs e)
        {
            PScanner scamm = new PScanner();
            scamm.ShowDialog();
            LimpalayoutPanel();
            BuscaIamgens();
        }

        private void Ficha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                BtnClose_Click(sender, e);
            }
            if (e.KeyCode.ToString() == "F5")
            {
                if(BtnAtualiza.Enabled)
                {
                    BtnAtualiza_Click(sender, e);
                }
            }
            if (e.Control && e.KeyCode == Keys.C)
            {
                btnCam_Click(sender, e);
            }
            if (e.Control && e.KeyCode == Keys.F)
            {
                BuscaFoto_Click(sender, e);
            }
            if (e.Control && e.KeyCode == Keys.A)
            {
                BuscarImagens_Click(sender, e);
            }
            if (e.Control && e.KeyCode == Keys.P)
            {
                BtnScam_Click(sender, e);
            }
            if (e.Control && e.KeyCode == Keys.P)
            {
                BtnScam_Click(sender, e);
            }
            if (e.KeyCode == Keys.Delete)
            {
                btnApaga_Click(sender, e);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void label9_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void TxtCpf_TextChanged(object sender, EventArgs e)
        {
            Atualizacao(this);
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            Atualizacao(this);
        }

        private void TxtRg_TextChanged(object sender, EventArgs e)
        {
            Atualizacao(this);
        }

        private void TxtRa_TextChanged(object sender, EventArgs e)
        {
            Atualizacao(this);
        }

        private void TxtNasc_TextChanged(object sender, EventArgs e)
        {
            Atualizacao(this);
        }

        private void BtnAtualiza_Click(object sender, EventArgs e)
        {
            utilidades uti = new utilidades();
    
            try
            {
                mConn = new MySqlConnection(uti.conexao);
                mConn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao se comunicar com o Banco");
            }

            string sql = "UPDATE `aluno` SET `nome`= '" + TxtName.Text + "',`rg`= '" + TxtRg.Text + "',`cpf`= '" + TxtCpf.Text + "',`ra`='" + TxtRa.Text + "',`sexo`='" + TxtSexo.Text + "',`dataNasc`='" + TxtNasc.Text + "' WHERE id = '" + Program.id + "' ;";
            using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
            {
                cmd.ExecuteNonQuery();
            }
            mConn.Close();

            BtnAtualiza.Enabled = false;

            Program.nome = TxtName.Text;
            Program.cpf = TxtCpf.Text;
            Program.rg = TxtRg.Text;
            Program.ra = TxtRa.Text;
            Program.nasc = TxtNasc.Text;
            Program.sexo = TxtSexo.Text;
        }

        void Atualizacao(Control con)
        {
            if (Program.nome != TxtName.Text || Program.cpf != TxtCpf.Text || Program.rg != TxtRg.Text || Program.ra != TxtRa.Text || Program.nasc != TxtNasc.Text || Program.sexo != TxtSexo.Text)
            {
                BtnAtualiza.Enabled = true;
            }
            else
            {
                BtnAtualiza.Enabled = false;
            }
        }

        void UpdateDados()
        {
            utilidades uti = new utilidades();
            try
            {
                mConn = new MySqlConnection(uti.conexao);
                mConn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao se comunicar com o Banco");
            }
            string sql = update;
            using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
            {
                cmd.ExecuteNonQuery();
            }
            mConn.Close();
        }

        private void Mcel_Click(object sender, EventArgs e)
        {
            string text;
            //ready pra não entrar no codigo enquanto o form ta abrindo
            if (ready)
            {
                //pri != true significa q é a primeira vez q ele clica no botão 
                if (priC != true)
                {
                    celIndex = txtCel.SelectedIndex;

                    txtCel.SelectedIndex = -1;

                    txtCel.DropDownStyle = ComboBoxStyle.DropDown;

                    if (celIndex == 0)
                    {
                        txtCel.Text = "Celular 1";
                    }
                    else
                    {
                        txtCel.Text = "Celular 2";
                    }
                    priC = true;
                    CCanc.Visible = true;
                    Mcel.BackColor = Color.Green;
                }
                else
                //pri == true significa q é a segunda vez q ele clica no botão 
                if (priC == true)
                {
                    if (celIndex == 0)
                    {
                        if (txtCel.Text != "Celular 1")
                        {
                            txtCel.Text = txtCel.Text.Insert(0, "(");
                            txtCel.Text = txtCel.Text.Insert(3, ")");
                            txtCel.Text = txtCel.Text.Insert(9, "-");
                        }

                        if (txtCel.Text != "Celular 1" && txtCel.Text != txtCel.Items[0].ToString() && txtCel.Text != txtCel.Items[1].ToString())
                        {
                            text = txtCel.Text;

                            update = "UPDATE `dados` SET `cel`= '" + text + "' WHERE `idAluno`= '" + Program.id + "' AND cel = '" + txtCel.Items[0].ToString() + "';";
                            UpdateDados();

                            txtCel.Items[0] = text;
                            txtCel.DropDownStyle = ComboBoxStyle.DropDownList;

                            priC = false;
                            txtCel.SelectedIndex = 0;
                            Mcel.BackColor = Color.Gray;
                            CCanc.Visible = false;
                        }
                        else
                        if (txtCel.Text == "Celular 1")
                        {
                            priC = false;
                            txtCel.SelectedIndex = 0;
                            Mcel.BackColor = Color.Gray;
                            CCanc.Visible = false;
                            txtCel.SelectedIndex = 0;
                        }
                        else
                        if (txtCel.Text == txtCel.Items[0].ToString())
                        {
                            MessageBox.Show("Digite um celular diferente do atual", "Celular Repetido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtCel.Text = "Celular 1";
                        }
                        else
                        if (txtCel.Text == txtCel.Items[1].ToString())
                        {
                            MessageBox.Show("Telefone digitado igual ao celular secundario", "Celular Repetido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtCel.Text = "Celular 1";
                        }
                    }
                    else
                    if (celIndex == 1)
                    {
                        if (txtCel.Text != "Celular 2")
                        {
                            txtCel.Text = txtCel.Text.Insert(0, "(");
                            txtCel.Text = txtCel.Text.Insert(3, ")");
                            txtCel.Text = txtCel.Text.Insert(9, "-");
                        }

                        if (txtCel.Text != "Celular 2" && txtCel.Text != txtCel.Items[1].ToString() && txtCel.Text != txtCel.Items[0].ToString())
                        {
                            text = txtCel.Text;

                            update = "UPDATE `dados` SET `cel`= '" + text + "' WHERE `idAluno`= '" + Program.id + "' AND cel = '" + txtCel.Items[1].ToString() + "';";
                            UpdateDados();

                            txtCel.Items[1] = text;
                            txtCel.DropDownStyle = ComboBoxStyle.DropDownList;

                            priC = false;
                            txtCel.SelectedIndex = 0;
                            Mcel.BackColor = Color.Gray;
                            CCanc.Visible = false;
                        }
                        else
                        if (txtCel.Text == "Celular 2")
                        {
                            priC = false;
                            txtCel.SelectedIndex = 1;
                            Mcel.BackColor = Color.Gray;
                            CCanc.Visible = false;
                            txtCel.SelectedIndex = 0;
                        }
                        else
                        if (txtCel.Text == txtCel.Items[1].ToString())
                        {
                            MessageBox.Show("Digite um celular diferente do atual", "Celular Repetido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtCel.Text = "Celular 2";
                        }
                        else
                        if (txtCel.Text == txtCel.Items[1].ToString())
                        {
                            MessageBox.Show("Telefone digitado igual ao celular primario", "Celular Repetido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtCel.Text = "Celular 2";
                        }
                    }
                }
            }
        }

        private void Mtel_Click(object sender, EventArgs e)
        {
            string text;
            //ready pra não entrar no codigo enquanto o form ta abrindo
            if (ready)
            {
                //pri != true significa q é a primeira vez q ele clica no botão 
                if (priT != true)
                {
                    telIndex = txtTel.SelectedIndex;

                    txtTel.SelectedIndex = -1;

                    txtTel.DropDownStyle = ComboBoxStyle.DropDown;

                    if (telIndex == 0)
                    {
                        txtTel.Text = "Telefone 1";
                    }
                    else
                    {
                        txtTel.Text = "Telefone 2";
                    }
                    priT = true;
                    TCanc.Visible = true;
                    Mtel.BackColor = Color.Green;
                }
                else
                //pri == true significa q é a segunda vez q ele clica no botão 
                if (priT == true)
                {
                    if (telIndex == 0)
                    {
                        if (txtTel.Text != "Telefone 1")
                        {
                            txtTel.Text = txtTel.Text.Insert(0, "(");
                            txtTel.Text = txtTel.Text.Insert(3, ")");
                            txtTel.Text = txtTel.Text.Insert(8, "-");
                        }

                        if (txtTel.Text != "Telefone 1" && txtTel.Text != txtTel.Items[0].ToString() && txtTel.Text != txtTel.Items[1].ToString())
                        {
                            text = txtTel.Text;

                            update = "UPDATE `dados` SET `tel`= '" + text + "' WHERE `idAluno`= '" + Program.id + "' AND tel = '" + txtTel.Items[0].ToString() + "';";
                            UpdateDados();

                            txtTel.Items[0] = text;
                            txtTel.DropDownStyle = ComboBoxStyle.DropDownList;

                            priT = false;
                            txtTel.SelectedIndex = 0;
                            Mtel.BackColor = Color.Gray;
                            TCanc.Visible = false;
                        }
                        else
                        if (txtTel.Text == "Telefone 1")
                        {
                            priT = false;
                            txtTel.SelectedIndex = 0;
                            Mtel.BackColor = Color.Gray;
                            TCanc.Visible = false;
                            txtTel.SelectedIndex = 0;
                        }
                        else
                        if (txtTel.Text == txtTel.Items[0].ToString())
                        {
                            MessageBox.Show("Digite um Telefone diferente do atual", "Celular Repetido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtTel.Text = "Celular 1";
                        }
                        else
                        if (txtTel.Text == txtTel.Items[1].ToString())
                        {
                            MessageBox.Show("Telefone digitado igual ao Telefone secundario", "Celular Repetido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtTel.Text = "Celular 1";
                        }
                    }
                    else
                    if (telIndex == 1)
                    {
                        if (txtTel.Text != "Telefone 2")
                        {
                            txtTel.Text = txtTel.Text.Insert(0, "(");
                            txtTel.Text = txtTel.Text.Insert(3, ")");
                            txtTel.Text = txtTel.Text.Insert(8, "-");
                        }

                        if (txtTel.Text != "Telefone 2" && txtTel.Text != txtTel.Items[1].ToString() && txtTel.Text != txtTel.Items[0].ToString())
                        {
                            text = txtTel.Text;

                            update = "UPDATE `dados` SET `tel`= '" + text + "' WHERE `idAluno`= '" + Program.id + "' AND tel = '" + txtTel.Items[1].ToString() + "';";
                            UpdateDados();

                            txtTel.Items[1] = text;
                            txtTel.DropDownStyle = ComboBoxStyle.DropDownList;

                            priT = false;
                            txtTel.SelectedIndex = 0;
                            Mtel.BackColor = Color.Gray;
                            TCanc.Visible = false;
                        }
                        else
                        if (txtTel.Text == "Telefone 2")
                        {
                            priT = false;
                            txtTel.SelectedIndex = 1;
                            Mtel.BackColor = Color.Gray;
                            TCanc.Visible = false;
                            txtTel.SelectedIndex = 0;
                        }
                        else
                        if (txtTel.Text == txtTel.Items[1].ToString())
                        {
                            MessageBox.Show("Digite um Telefone diferente do atual", "Celular Repetido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtTel.Text = "Telefone 2";
                        }
                        else
                        if (txtTel.Text == txtTel.Items[1].ToString())
                        {
                            MessageBox.Show("Telefone digitado igual ao Telefone primario", "Celular Repetido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtTel.Text = "Telefone 2";
                        }
                    }
                }
            }
        }


        private void MEmail_Click(object sender, EventArgs e)
        {
            string text;
            //ready pra não entrar no codigo enquanto o form ta abrindo
            if (ready)
            {
                //pri != true significa q é a primeira vez q ele clica no botão 
                if (priE != true)
                {
                    emailIndex = txtEmail.SelectedIndex;

                    txtEmail.SelectedIndex = -1;

                    txtEmail.DropDownStyle = ComboBoxStyle.DropDown;

                    if (emailIndex == 0)
                    {
                        txtEmail.Text = "Novo Email 1";
                    }
                    else
                    {
                        txtEmail.Text = "Novo Email 2";
                    }
                    priE = true;
                    ECanc.Visible = true;
                    MEmail.BackColor = Color.Green;
                }
                else
                //pri == true significa q é a segunda vez q ele clica no botão 
                if (priE == true)
                {
                    if (emailIndex == 0)
                    {
                        if (txtEmail.Text != "Novo Email 1" && txtEmail.Text != txtEmail.Items[0].ToString() && txtEmail.Text != txtEmail.Items[1].ToString())
                        {
                            text = txtEmail.Text;

                            update = "UPDATE `dados` SET `email`= '" + text + "' WHERE `idAluno`= '" + Program.id + "' AND email = '" + txtEmail.Items[0].ToString() + "';";
                            UpdateDados();

                            txtEmail.Items[0] = text;
                            txtEmail.DropDownStyle = ComboBoxStyle.DropDownList;

                            priE = false;
                            txtEmail.SelectedIndex = 0;
                            MEmail.BackColor = Color.Gray;
                            ECanc.Visible = false;
                        }
                        else
                        if (txtEmail.Text == "Novo Email 1")
                        {
                            priE = false;
                            txtEmail.SelectedIndex = 0;
                            MEmail.BackColor = Color.Gray;
                            ECanc.Visible = false;
                            txtEmail.SelectedIndex = 0;
                        }
                        else
                        if (txtEmail.Text == txtEmail.Items[0].ToString())
                        {
                            MessageBox.Show("Digite um E-mail diferente do atual", "E-mail Repetido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtEmail.Text = "Novo Email 1";
                        }
                        else
                        if (txtEmail.Text == txtEmail.Items[1].ToString())
                        {
                            MessageBox.Show("E-mail digitado igual ao e-mail secundario", "E-mail Repetido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtEmail.Text = "Novo Email 1";
                        }
                    }
                    else
                    if (emailIndex == 1)
                    {
                        if (txtEmail.Text != "Novo Email 2" && txtEmail.Text != txtEmail.Items[1].ToString() && txtEmail.Text != txtEmail.Items[0].ToString())
                        {
                            text = txtEmail.Text;

                            update = "UPDATE `dados` SET `email`= '" + text + "' WHERE `idAluno`= '" + Program.id + "' AND email = '" + txtEmail.Items[1].ToString() + "';";
                            UpdateDados();

                            txtEmail.Items[1] = text;
                            txtEmail.DropDownStyle = ComboBoxStyle.DropDownList;

                            priE = false;
                            txtEmail.SelectedIndex = 0;
                            MEmail.BackColor = Color.Gray;
                            ECanc.Visible = false;
                        }
                        else
                        if (txtEmail.Text == "Novo Email 2")
                        {
                            priE = false;
                            txtEmail.SelectedIndex = 1;
                            MEmail.BackColor = Color.Gray;
                            ECanc.Visible = false;
                            txtEmail.SelectedIndex = 0;
                        }
                        else
                        if (txtEmail.Text == txtEmail.Items[1].ToString())
                        {
                            MessageBox.Show("Digite um E-mail diferente do atual", "E-mail Repetido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtEmail.Text = "Novo Email 2";
                        }
                        else
                        if (txtEmail.Text == txtEmail.Items[0].ToString())
                        {
                            MessageBox.Show("E-mail digitado igual ao e-mail primario", "E-mail Repetido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtEmail.Text = "Novo Email 2";
                        }
                    }
                }
            }
        }
    }
}
