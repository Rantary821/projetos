using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;
using System.IO;
using System.Reflection;

namespace ArquivoEtec
{
    public class Utilidades
    {
        public static string ChangeColorsForm,Tema, MostrarContatos, TodosOSTemas = "Dark;Light";

        public static Color MenuBackTitulo, MenuForetitulo, ForelblReg, backBtnNS, backBtnS, BackTitulo, ForeTitulo, BackForm, ForeLbl,
            ForeBtn, BackBtn, BackTab, SelectArqBackColor, ConcluinteCor, NConcluinteCor, GrdBackLineNS, GrdForeLineNS, GrdBackLineS, GrdForeLineS, GrdBackTitulo, GrdForeTitulo,
            BtnCloseEnter, BtnMiniEnter, ForeBnt2, PesqNConClu, PesqDel, ForeLblVersaoMenu, GridBackColor, TxtNSelectBackColor,
            TxtSelectBackColor, TxtNSelectForeColor, TxtSelectForeColor, ForeLblError;//Todas as varias para as cores dos temas

        private SqlConnection mConn;

        void conexão(bool AbreFecha)
        {
            try
            {
                mConn = new SqlConnection(Program.conecta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errro de conexão com o banco!" + Environment.NewLine + ex);
            }

            if (AbreFecha)
            {
                mConn.Open();
            }
            else
            {
                mConn.Close();
            }
        }

        public void ApelMessageBox(string TextORTittle, string buttons, string buttonsText, string Ico)
        {
            //Exemplo de um chamada com todas as possibilidades:
            //ApelMessageBox("Texto;Titulo;", "Btn1; Btn2; Btn3; BtnClose; btnCheck;", "Sim; Não; Cancel; Fazer isso para todos?;", "Alert";

            Program.MBLabels = TextORTittle;     //Texto;Titulo;                                - (Texto; - Apenas texto) (;Titulo; - Apenas Titulo)
            Program.MBButtons = buttons;         //Btn1; Btn2; Btn3; btnCheck; BtnClose;        - (Retirar botões indesejados - ex: btn1; btnClose; - ex: btnclose
            Program.MBButtonsText = buttonsText; //Sim; Não; Cancel; Fazer isso para todos?;    - (Colocar os texto dos botões na mesma ordem dos respectivos botões
            Program.MBIco = Ico;                 //Alert Check Error Quest                      - (Pode ser escrito o nome completo ou apenas a inicial

            //btn1* - Para ser chamado com Enter  
            //btn2' - para ser chamado com Esc

            MessageBoxApel Apel = new MessageBoxApel();
            Apel.Focus();
            Apel.ShowDialog();
        }

        public bool CompararCpf(int Tamando, string CpfVal, string CpfOrigin)//Comparação dos digitos do cpf digitado com o cpf validado
        {
            bool V = false;

            for (int i = 0; i < Tamando; i++)
            {
                if (CpfVal[i] == CpfOrigin[i])
                {
                    V = true;//Caso todos os digito forem iguais recebe true
                }
                else
                {
                    V = false;//Caso algum for diferente recebe false
                }
            }

            if (V)//Retorna valor
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void GridviewColors(DataGridView Grid)//Padrão de fonts e cores para todos os grids
        {
            Grid.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            Grid.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);

            Grid.DefaultCellStyle.ForeColor = Utilidades.GrdForeLineNS;
            Grid.DefaultCellStyle.BackColor = Utilidades.GrdBackLineNS;

            Grid.DefaultCellStyle.SelectionForeColor = Utilidades.GrdForeLineS;
            Grid.DefaultCellStyle.SelectionBackColor = Utilidades.GrdBackLineS;

            Grid.ColumnHeadersDefaultCellStyle.ForeColor = Utilidades.GrdForeTitulo;
            Grid.ColumnHeadersDefaultCellStyle.BackColor = Utilidades.GrdBackTitulo;

            Grid.BackgroundColor = Utilidades.GridBackColor;

            Grid.EnableHeadersVisualStyles = false;
            Grid.AllowUserToResizeRows = false;
        }

        public int SelectMaxIDAluno()
        {
            int idAluno = 0;
            conexão(true);

            string sql = "SELECT MAX(idAluno) FROM aluno";
            using (SqlCommand cmd = new SqlCommand(sql, mConn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    try
                    {
                        idAluno = reader.GetInt32(0);
                    }
                    catch (System.Data.SqlTypes.SqlNullValueException)
                    {
                        idAluno = 0;
                    }
                }
            }

            conexão(false);

            return idAluno;
        }

        public int SelectMaxIDCurso()
        {
            int idCurso = 0;
            conexão(true);

            string sql = "SELECT MAX(idCurso) FROM curso;";
            using (SqlCommand cmd = new SqlCommand(sql, mConn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    try
                    {
                        idCurso = reader.GetInt32(0);
                    }
                    catch (System.Data.SqlTypes.SqlNullValueException)
                    {
                        idCurso = 0;
                    }
                }
            }

            conexão(false);

            return idCurso;
        }

        public string SelectMaxIDMatricula(string situacao)
        {
            conexão(true);

            string idMatricula = "0";
            //
            string sql1 = "SELECT  top 1* FROM matricula WHERE Concluinte = @Concluinte AND Deletado = 'NAO' ORDER BY idPrimario DESC;";

            SqlCommand cmd1 = new SqlCommand(sql1, mConn);
            cmd1.Parameters.AddWithValue("@Concluinte", situacao);
            cmd1.ExecuteNonQuery();

            SqlDataReader reader = cmd1.ExecuteReader();

            while (reader.Read())
            {
                try
                {
                    idMatricula = reader.GetString(1);
                }
                catch (System.Data.SqlTypes.SqlNullValueException)
                {
                    idMatricula = "0";
                }
            }

            idMatricula = (Convert.ToInt32(idMatricula) + 1).ToString();

            conexão(false);

            return idMatricula;
        }

       

        public void InsertIntoAluno(string nome, string rg, string cpf)
        {
            conexão(true);

            string sql2 = "INSERT INTO aluno(nome, rg, cpf) VALUES (@Nome, @Rg, @Cpf);";
            using (SqlCommand cmd2 = new SqlCommand(sql2, mConn))
            {

                cmd2.Parameters.AddWithValue("@Nome", nome);
                cmd2.Parameters.AddWithValue("@Rg", rg);
                cmd2.Parameters.AddWithValue("@Cpf", cpf);
                cmd2.ExecuteNonQuery();
            }
            conexão(false);
        }

        public void InsertIntoContato(string cel1, string cel2, string tel1, string tel2, string email1, string email2, int idAluno)
        {
            conexão(true);

            string sql3 = "INSERT INTO contato(Cel1, Cel2, Tel1, Tel2, Email1, Email2, IdAluno) VALUES (@c1, @c2, @t1, @t2, @Em1, @em2, @id);";
            using (SqlCommand cmd3 = new SqlCommand(sql3, mConn))
            {
                cmd3.Parameters.AddWithValue("@c1", cel1);
                cmd3.Parameters.AddWithValue("@c2", cel2);
                cmd3.Parameters.AddWithValue("@t1", tel1);
                cmd3.Parameters.AddWithValue("@t2", tel2);
                cmd3.Parameters.AddWithValue("@Em1", email1);
                cmd3.Parameters.AddWithValue("@Em2", email2);
                cmd3.Parameters.AddWithValue("@id", idAluno);
                cmd3.ExecuteNonQuery();
            }
            conexão(false);
        }

        public void InsertIntoEndereco(string rua, string bairro, string numero, string complemento, string Cidade, string cep, string Uf, string IdAluno)
        {
            conexão(true);

            string sql4 = "INSERT INTO endereco(rua, bairro, numero, complemento, Cidade, Uf, Cep, IdAluno) VALUES (@Rua, @Bairro, @num, @comple, @cidade, @uf, @Cep, @Id);";
            using (SqlCommand cmd4 = new SqlCommand(sql4, mConn))
            {
                cmd4.Parameters.AddWithValue("@Rua", rua);
                cmd4.Parameters.AddWithValue("@Bairro", bairro);
                cmd4.Parameters.AddWithValue("@num", numero);
                cmd4.Parameters.AddWithValue("@comple", complemento);
                cmd4.Parameters.AddWithValue("@cidade", Cidade);
                cmd4.Parameters.AddWithValue("@Uf", Uf);
                cmd4.Parameters.AddWithValue("@Cep", cep);
                cmd4.Parameters.AddWithValue("@Id", IdAluno);
                cmd4.ExecuteNonQuery();
            }

            conexão(false);
        }

        public void InsertIntoMatricula(string idMatricula, string idAluno, string idCurso, string AnoMat, string Concluinte)
        {
            conexão(true);

            string sql5 = "INSERT INTO matricula(idMatricula, idAluno, idCurso, AnoMat, Concluinte, Deletado) VALUES (@idM, @IdA, @IdC, @Ano, @Concluinte, @del);";
            using (SqlCommand cmd5 = new SqlCommand(sql5, mConn))
            {
                cmd5.Parameters.AddWithValue("@idM", idMatricula);
                cmd5.Parameters.AddWithValue("@IdA", idAluno);
                cmd5.Parameters.AddWithValue("@IdC", idCurso);
                cmd5.Parameters.AddWithValue("@Ano", AnoMat);
                cmd5.Parameters.AddWithValue("@Concluinte", Concluinte);
                cmd5.Parameters.AddWithValue("@del", "NAO");
                cmd5.ExecuteNonQuery();
            }

            conexão(false);
        }

        public int IDAlunoPorCPF(string cpf)
        {
            conexão(true);

            int Id = 0;

            string sql1 = "SELECT idAluno FROM aluno WHERE cpf = @Cpf";
            using (SqlCommand cmd1 = new SqlCommand(sql1, mConn))
            {
                cmd1.Parameters.AddWithValue("@Cpf", cpf);
                cmd1.ExecuteNonQuery();

                SqlDataReader reader = cmd1.ExecuteReader();
                while (reader.Read())
                {
                    Id = reader.GetInt32(0);
                }
            }

            conexão(false);

            return Id;
        }

        public bool BuscarCpf(string cpf)

        {
            conexão(true);

            int V = 0;

            string sql1 = "SELECT COUNT(*) FROM aluno WHERE cpf = @Cpf";
            using (SqlCommand cmd1 = new SqlCommand(sql1, mConn))
            {
                cmd1.Parameters.AddWithValue("@Cpf", cpf);
                cmd1.ExecuteNonQuery();

                SqlDataReader reader = cmd1.ExecuteReader();
                while (reader.Read())
                {
                    try
                    {
                        V = reader.GetInt32(0);
                    }
                    catch (System.Data.SqlTypes.SqlNullValueException)
                    {
                        V = 0;
                    }

                }
            }
            conexão(false);

            if (V == 1 && cpf.Distinct().Count() != 1)
            {
                return true;
            }
            if (V >= 2 && cpf.Distinct().Count() != 1)
            {
                int id = 0;

                try
                {
                    for(int i = 0; i < V--; i++)
                    {
                        conexão(true);

                        string sql2 = "SELECT min(idAluno), max(idAluno) FROM aluno WHERE cpf = @Cpf";
                        using (SqlCommand cmd1 = new SqlCommand(sql2, mConn))
                        {
                            cmd1.Parameters.AddWithValue("@Cpf", cpf);
                            cmd1.ExecuteNonQuery();

                            SqlDataReader reader = cmd1.ExecuteReader();
                            while (reader.Read())
                            {
                                AlunoRepetido(reader.GetInt32(0), reader.GetInt32(1));
                            }
                            reader.Close();
                        }
                        conexão(false);
                    } 
                }
                catch(Exception ex)
                {
                    return false;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AlunoRepetido(int idAlunoMin, int idAlunoMax)
        {
            conexão(true);

            try
            {
                string sql = "DELETE FROM aluno WHERE idAluno = @idMin;";
                using (SqlCommand cmd = new SqlCommand(sql, mConn))
                {
                    cmd.Parameters.AddWithValue("@idMin", idAlunoMin);
                    cmd.ExecuteNonQuery();
                }

                string sql2 = "UPDATE matricula SET idAluno = @idMax WHERE idAluno = @idMin;";
                using (SqlCommand cmd = new SqlCommand(sql2, mConn))
                {
                    cmd.Parameters.AddWithValue("@idMin", idAlunoMin);
                    cmd.Parameters.AddWithValue("@idMax", idAlunoMax);
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {

            }

            conexão(false);
        }
        public void DeleleAluno(string idPrimario)
        {
            conexão(true);

            try
            {
                string sql = "UPDATE matricula SET Deletado = 'SIM' WHERE idPrimario = @Id;";
                using (SqlCommand cmd = new SqlCommand(sql, mConn))
                {
                    cmd.Parameters.AddWithValue("@Id", idPrimario);
                    cmd.ExecuteNonQuery();
                }

                if(Directory.Exists(Program.PastaSistema + idPrimario))
                {
                    Directory.Delete(Program.PastaSistema + idPrimario, true);
                }
            }
            catch
            {

            }

            conexão(false);
        }

        public void buscaConfig()
        {
            conexão(true);

            try
            {
                string sql = "SELECT tema, mostrarContatos FROM config;";
                using (SqlCommand cmd = new SqlCommand(sql, mConn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Tema = reader.GetString(0);
                        MostrarContatos = reader.GetString(1);
                    }
                }
            }
            catch (SqlException)
            {
                Tema = "";
                MostrarContatos = "";
            }

            conexão(false);
        }
        public void UpConfig(string tema, string contato)
        {
            conexão(true);

            string sql = "UPDATE config SET tema = @tema, mostrarContatos = @Contat;";
            using (SqlCommand cmd = new SqlCommand(sql, mConn))
            {
                cmd.Parameters.AddWithValue("@tema", tema);
                cmd.Parameters.AddWithValue("@Contat", contato);


                cmd.ExecuteNonQuery();
            }

            conexão(false);
        }

        public void UpdateMatricula(string idPrimario, string ano, string idCurso)
        {
            conexão(true);

            string sql = "UPDATE matricula SET AnoMat = @ano, idCurso = @idCurso WHERE idPrimario = @id;";
            using (SqlCommand cmd = new SqlCommand(sql, mConn))
            {
                cmd.Parameters.AddWithValue("@Id", idPrimario);
                cmd.Parameters.AddWithValue("@idCurso", idCurso);
                cmd.Parameters.AddWithValue("@ano", ano);

                cmd.ExecuteNonQuery();
            }

            conexão(false);
        }

        public void UpdateEndereco(string idPrimario, string rua, string bairro, string numero, string complemento, string Cidade, string Uf, string cep)
        {
            conexão(true);

            string sql2 = "UPDATE endereco SET rua = @rua, bairro = @bairro, numero = @numero, complemento = @Comple, Cidade = @City, Uf = @uf, Cep = @cep FROM endereco e JOIN matricula m ON m.idAluno = e.IdAluno WHERE m.idPrimario = @id;";
            using (SqlCommand cmd2 = new SqlCommand(sql2, mConn))
            {
                cmd2.Parameters.AddWithValue("@Id", idPrimario);
                cmd2.Parameters.AddWithValue("@rua", rua);
                cmd2.Parameters.AddWithValue("@bairro", bairro);
                cmd2.Parameters.AddWithValue("@numero", numero);
                cmd2.Parameters.AddWithValue("@Comple", complemento);
                cmd2.Parameters.AddWithValue("@City", Cidade);
                cmd2.Parameters.AddWithValue("@uf", Uf);
                cmd2.Parameters.AddWithValue("@cep", cep);
                cmd2.ExecuteNonQuery();
            }

            conexão(false);
        }

        public void UpdateContato(string idPrimario, string cel1, string cel2, string tel1, string tel2, string email1, string email2)
        {
            conexão(true);

            string sql3 = "UPDATE contato SET Cel1 = @cel1, Cel2 = @cel2, Tel1 = @tel1, Tel2 = @tel2, Email1 = @email1, Email2 = @email2 FROM contato c JOIN matricula m ON m.idAluno = c.IdAluno WHERE m.idPrimario = @id;";
            using (SqlCommand cmd3 = new SqlCommand(sql3, mConn))
            {
                cmd3.Parameters.AddWithValue("@Id", idPrimario);
                cmd3.Parameters.AddWithValue("@cel1", cel1);
                cmd3.Parameters.AddWithValue("@cel2", cel2);
                cmd3.Parameters.AddWithValue("@tel1", tel1);
                cmd3.Parameters.AddWithValue("@tel2", tel2);
                cmd3.Parameters.AddWithValue("@email1", email1);
                cmd3.Parameters.AddWithValue("@email2", email2);
                cmd3.ExecuteNonQuery();
            }

            conexão(false);
        }

        public void UpdateAluno(string idPrimario, string nome, string rg, string cpf)
        {
            conexão(true);

            string sql4 = "UPDATE aluno SET nome = @nome, rg = @rg, cpf = @cpf FROM aluno a JOIN matricula m ON m.idAluno = a.IdAluno WHERE m.idPrimario = @id;";
            using (SqlCommand cmd4 = new SqlCommand(sql4, mConn))
            {
                cmd4.Parameters.AddWithValue("@Id", idPrimario);
                cmd4.Parameters.AddWithValue("@nome", nome);
                cmd4.Parameters.AddWithValue("@rg", rg);
                cmd4.Parameters.AddWithValue("@cpf", cpf);
                cmd4.ExecuteNonQuery();
            }

            conexão(false);
        }

        public void ResetPastaAlnos()
        {
            if (Directory.Exists(Program.PastaSistema))
            {
                Directory.Delete(Program.PastaSistema, true);

                Directory.CreateDirectory(Program.PastaSistema);

                Directory.CreateDirectory(Program.Temp);
            }
        }

        public string pesquisaQntPasta()
        {
            conexão(true);
            string Registros= "";

            try
            {
                string sql = "Select count(idPrimario) from matricula where Deletado = 'NAO';";
                using (SqlCommand cmd = new SqlCommand(sql, mConn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Registros = reader.GetInt32(0).ToString();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(""+ex);
            }

            return Registros;
            conexão(false);
        }

        public static String GerarCpf()
        {
            int soma = 0, resto = 0;
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            Random rnd = new Random();
            string semente = rnd.Next(100000000, 999999999).ToString();

            for (int i = 0; i < 9; i++)
                soma += int.Parse(semente[i].ToString()) * multiplicador1[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            semente = semente + resto;
            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(semente[i].ToString()) * multiplicador2[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            semente = semente + resto;
            return semente;
        }

        public Color convertRGB(string RGB)
        {
            string[] V = RGB.Split(';');
            V[3] = "0";
            int[] C = Array.ConvertAll<string, int>(V, int.Parse);

            Color cor = Color.FromArgb(C[0], C[1], C[2]);

            return cor;
        }
        
        public Color Cores(int Cod)
        {
            Color Cor = new Color();

            Cor = Color.White;
            
            if (Tema != "")
            {
                string line;
                List<string> Lines = new List<string>();

                var assm2 = Assembly.GetExecutingAssembly();
                using (var stream = assm2.GetManifestResourceStream("ArquivoEtec.Resources.Temas." + Tema + ".Cores.txt"))
                {
                    using (var reader = new StreamReader(stream))
                    {
                        while (((line = reader.ReadLine()) != null))
                        {
                            Lines.Add(line);
                        }
                    }
                }
                Cor = convertRGB(Lines[Cod]);    
            }
            return Cor;
        }

        public string Config(int Cod)
        {
            string config = "";
            if (Tema != "")
            {
                string line;
                List<string> Lines = new List<string>();

                var assm2 = Assembly.GetExecutingAssembly();
                using (var stream = assm2.GetManifestResourceStream("ArquivoEtec.Resources.Temas." + Tema + ".Config.txt"))
                {
                    using (var reader = new StreamReader(stream))
                    {
                        while (((line = reader.ReadLine()) != null))
                        {
                            Lines.Add(line);
                        }
                    }
                }
                string[] V = Lines[Cod].Split(';');
                config = V[0];
            }
            return config;
        }

        public void BuscaCores()
        {
           //-----------------------------Menu
            MenuBackTitulo = Cores(1);
            MenuForetitulo = Cores(2);
            backBtnNS = Cores(3);
            backBtnS = Cores(4);
            ForelblReg = Cores(5);
            ForeLblVersaoMenu = Cores(6);
           //-----------------------------MessageBox / Scaner
            ForeBnt2 = Cores(8);
            BackBtn = Cores(9);
           //-----------------------------Ficha
            BackTab = Cores(11);
            SelectArqBackColor = Cores(12);
            //-----------------------------Grid
            GrdBackLineNS = Cores(14);
            GrdForeLineNS = Cores(15);
            GrdBackLineS = Cores(16);
            GrdForeLineS = Cores(17);
            GrdBackTitulo = Cores(18);
            GrdForeTitulo = Cores(19);
            GridBackColor = Cores(20);
           //-----------------------------Pesquisa
            PesqNConClu = Cores(22);
            PesqDel = Cores(23);
           //-----------------------------Geral
            BackTitulo = Cores(25);
            ForeTitulo = Cores(26);
            BackForm = Cores(27);
            ForeLbl = Cores(28);
            ForeBtn = Cores(29);
            BtnCloseEnter = Cores(30);
            BtnMiniEnter = Cores(31);
            TxtNSelectBackColor = Cores(32);
            TxtNSelectForeColor = Cores(33);
            TxtSelectBackColor = Cores(34);
            TxtSelectForeColor = Cores(35);
            ForeLblError = Cores(36);
            ConcluinteCor = Cores(37);
            NConcluinteCor = Cores(38);
        }

        public void ChangeColors(Control con)//Preenchimento das cores do tema
        {
            foreach (Control c in con.Controls)
            {
                if (c is GroupBox)
                    ((GroupBox)c).ForeColor = Utilidades.ForeLbl;
                if (c is Label)
                    ((Label)c).ForeColor = Utilidades.ForeLbl;

                if(ChangeColorsForm == "MessageBoxApel" || ChangeColorsForm == "PScanner")
                {
                    if (c is Button)
                        ((Button)c).ForeColor = Utilidades.ForeBnt2;
                    if (c is Button)
                        ((Button)c).BackColor = Utilidades.BackBtn;
                }
                else
                {
                    if (c is Button)
                        ((Button)c).ForeColor = Utilidades.ForeBtn;
                }

                if (c is TextBox)
                    ((TextBox)c).BackColor = Utilidades.TxtNSelectBackColor;
                if (c is TextBox)
                    ((TextBox)c).ForeColor = Utilidades.TxtNSelectForeColor;

                if (c is MaskedTextBox)
                    ((MaskedTextBox)c).BackColor = Utilidades.TxtNSelectBackColor;
                if (c is MaskedTextBox)
                    ((MaskedTextBox)c).ForeColor = Utilidades.TxtNSelectForeColor;

                if (c is ComboBox)
                    ((ComboBox)c).BackColor = Utilidades.TxtNSelectBackColor;
                if (c is ComboBox)
                    ((ComboBox)c).ForeColor = Utilidades.TxtNSelectForeColor;
                else
                    ChangeColors(c);
            }
        }

        public void TextBoxEmFoco(Control con)//Preenchimento das cores do tema
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox && c.Focused)
                {
                    if(c.Name != "txtLimit")
                    {
                        ((TextBox)c).BackColor = Utilidades.TxtSelectBackColor;
                        ((TextBox)c).ForeColor = Utilidades.TxtSelectForeColor;
                    }
                }
                else
                if (c is TextBox && !c.Focused)
                {
                    if(c.Name != "txtLimit")
                    {
                        ((TextBox)c).BackColor = Utilidades.TxtNSelectBackColor;
                        ((TextBox)c).ForeColor = Utilidades.TxtNSelectForeColor;
                    }
                }
                else
                if (c is MaskedTextBox && c.Focused)
                {
                    ((MaskedTextBox)c).BackColor = Utilidades.TxtSelectBackColor;
                    ((MaskedTextBox)c).ForeColor = Utilidades.TxtSelectForeColor;
                }
                else
                if (c is MaskedTextBox && !c.Focused)
                {
                    ((MaskedTextBox)c).BackColor = Utilidades.TxtNSelectBackColor;
                    ((MaskedTextBox)c).ForeColor = Utilidades.TxtNSelectForeColor;
                }

                else
                    TextBoxEmFoco(c);
            }
        }
    }
}
