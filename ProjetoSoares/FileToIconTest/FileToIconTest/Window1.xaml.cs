using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Forms.Integration;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Diagnostics;
using System.ComponentModel;
using QuickZip.Tools;

namespace FileToIconTest
{
    public class Model : INotifyPropertyChanged
    {
        string _path;
        string[] _files;
        bool _showFiles =true, _showFolders = false;
        public string Path { get { return _path; } set { _path = value; OnPropertyChanged("Path"); } }
        public string[] Files { get { return _files; } set { _files = value; OnPropertyChanged("Files"); } }
        public bool ShowFiles { get { return _showFiles; } set { _showFiles = value; OnPropertyChanged("ShowFiles"); } }
        public bool ShowFolders { get { return _showFolders; } set { _showFolders = value; OnPropertyChanged("ShowFolders"); } }

        public event PropertyChangedEventHandler PropertyChanged;
        Window1 _view;

        public Model(Window1 view)
        {
            _view = view;
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(
                    this,
                    new PropertyChangedEventArgs(propertyName)
                    );
            }

            //Lazy =D
            if (propertyName == "Path" || propertyName == "ShowFiles" || propertyName == "ShowFolders")
            {
                _view.ClearCache();
                List<string> folderAndFiles = new List<string>();
                if (ShowFolders) folderAndFiles.AddRange(Directory.GetDirectories(Path).ToArray());
                if (ShowFiles) folderAndFiles.AddRange(Directory.GetFiles(Path).ToArray());

                Files = folderAndFiles.ToArray();
            }
        }
    }
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        Model model;
        public Window1()
        {
            InitializeComponent();

            lerBloco(this);

            model = new Model(this);
            DataContext = model;
            model.Path = FileFin.AlunoCaminho;
            FileToIconConverter fic = this.Resources["fic"] as FileToIconConverter;
            fic.DefaultSize = 200;
            list.AddHandler(System.Windows.Controls.ListViewItem.PreviewMouseDownEvent, new MouseButtonEventHandler(list_MouseDown));         
        }

        public void ClearCache()
        {
            FileToIconConverter fic = this.Resources["fic"] as FileToIconConverter;
            //Clear Thumbnail only, icon is not cleared.
            fic.ClearInstanceCache();
        }

        void lerBloco(System.Windows.Controls.Control con)
        {
            using (StreamReader reader = new StreamReader(@"C:\Fotos\CodAluno.txt"))
            {
                FileFin.Codigo = reader.ReadLine();
            }

            FileFin.AlunoCaminho = (@"C:\Fotos\" + FileFin.Codigo);
        }

        private void change_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog dlg = new System.Windows.Forms.FolderBrowserDialog();
            dlg.SelectedPath = model.Path;
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                model.Path = dlg.SelectedPath;
        }

        private void list_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2 && e.LeftButton == MouseButtonState.Pressed)
            {
                if (list.SelectedValue is string)
                {
                    string dir = list.SelectedValue as string;
                    if (Directory.Exists(dir))
                    {
                        model.Path = dir;
                        e.Handled = true;
                    }
                }
            }
        }

        private void list_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
           /* string path = @"C:\Users\Otavio\Desktop\Nay\CodAluno.txt";

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
            teste teste = new teste();
            teste.Show();*/
        }

        private void list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                string path = @"C:\Fotos\Paths.txt";
                string path2 = @"C:\Fotos\ImagemLocation.txt";

                File.Delete(path);
                File.Delete(path2);

                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.Dispose();
                }

                using (StreamWriter sw = File.CreateText(path2))
                {
                    sw.Dispose();
                }

                foreach (var list in list.SelectedItems)
                {
                    //System.Windows.Forms.MessageBox.Show(list.ToString());   
                    string appendText = list.ToString() + Environment.NewLine;
                    File.AppendAllText(path, appendText, Encoding.UTF8);
                }

                foreach (var list in list.SelectedItems)
                {
                    //System.Windows.Forms.MessageBox.Show(list.ToString());   
                    string appendText = list.ToString() + Environment.NewLine;
                    File.AppendAllText(path2, appendText, Encoding.UTF8);
                }
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("" + e);
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ProcessStartInfo Info = new ProcessStartInfo();
            Info.Arguments = "/C ping 127.0.0.1 -n 2 && \"" + System.Windows.Forms.Application.ExecutablePath + @"C:\Users\Otavio\Desktop\ProjetoSoares\SoaresTeste1\SoaresTeste1\bin\Debug\FileToIconTest.exe";
            Info.WindowStyle = ProcessWindowStyle.Hidden;
            Info.CreateNoWindow = true;
            Info.FileName = "cmd.exe";
            Process.Start(Info);
            System.Windows.Forms.Application.Exit();
        }
    }
}
