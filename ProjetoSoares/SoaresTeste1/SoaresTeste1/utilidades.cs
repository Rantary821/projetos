using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Net.Mail;

namespace SoaresTeste1
{
   public class utilidades
    {
        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private MySqlDataReader reader;
        private MySqlCommand cmd;
        public int idd, iddMIn;
        public string conexao = "Persist Security info=False; server=localhost; database=soares;uid=root";

        //limpa os texto
        public void ClearAllText(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                if (c is RadioButton)
                    ((RadioButton)c).Checked = false;
                if (c is ComboBox)
                    ((ComboBox)c).SelectedIndex = -1;
                if (c is MaskedTextBox)
                    ((MaskedTextBox)c).Clear();
                else
                    ClearAllText(c);
            }
        }
        //seleciona o id do aluno e add +1
        public void selectIdAluno()
        {
            string sql = "SELECT MAX(id) FROM `aluno`";
            try
            {
                mConn = new MySqlConnection(conexao);
                mConn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro " + ex);
            }
            using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
            {
                //"reader = cmd.ExecuteReader();" assim não da certo, precisa do MySqlDataReader antes sempre
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //try-catch para verifica se o valor é nulo
                    try
                    {
                        //depois de pegar o maior numero de Matricula  joga para a variavel contador e soma +1 e depios joga para a variavel
                        idd = reader.GetInt16("MAX(id)");
                    }
                    catch (System.Data.SqlTypes.SqlNullValueException ex)
                    {
                        //se for nulo a variavel NumMatricula recebe 0
                        idd = 0;
                    }

                }
                reader.Close();
                mConn.Close();
                idd++;
            }
        }

        public void SelectMinAluno()
        {
            string sql = "SELECT MIN(id) FROM `aluno`";
            try
            {
                mConn = new MySqlConnection(conexao);
                mConn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro " + ex);
            }
            using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
            {
                //"reader = cmd.ExecuteReader();" assim não da certo, precisa do MySqlDataReader antes sempre
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    try
                    {
                        //depois de pegar o maior numero de Matricula  joga para a variavel contador e soma +1 e depios joga para a variavel
                        iddMIn = reader.GetInt16("MIN(id)");
                    }
                    catch (System.Data.SqlTypes.SqlNullValueException ex)
                    {
                        //se for nulo a variavel NumMatricula recebe 0
                        idd = 0;
                    }          
                }
                reader.Close();
                mConn.Close();
            }
        }

        //cadastra o aluno no banco
        public void cadastraAluno (int id,string nome, string rg, string cpf, string ra, string dataNasc, string sexo)
        {
            try
            {
                mConn = new MySqlConnection(conexao);
                mConn.Open();
            }catch(MySqlException ex)
            {
                MessageBox.Show("Erro ao se comunicar com o Banco");
            }
            if(nome != "")
            {
                string sql = "INSERT INTO aluno (id, nome, rg, cpf, ra, dataNasc, sexo) values (" + id + ", '" + nome + "','" + rg + "','" + cpf + "','" + ra + "','" + dataNasc + "','" + sexo + "');";
                using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
                {
                    cmd.ExecuteNonQuery();
                }
            //    codigo para verificar se o aluno já tem pasta e se não tiver ele cria
            string dir = @"C:\fotos\" + idd;
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
            }
            else
            {
                MessageBox.Show("Preencha os campos corretamente");
            }
            mConn.Close();
        }



        public void deleteArqbanco(string idAluno, string nome)
        {
            try
            {
                mConn = new MySqlConnection(conexao);
                mConn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao se comunicar com o Banco");
            }

            string sql = "DELETE FROM `imagens` WHERE @IdAluno and Nome = @Nome";
            using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
            {
                cmd.Parameters.AddWithValue("@IdAluno", idAluno);
                cmd.Parameters.AddWithValue("@Nome", nome);
                cmd.ExecuteNonQuery();
            }
            mConn.Close();
        }
        public void S(Control con, bool ver)
        {
            foreach (Control c in con.Controls)
            {
                if (ver)
                {
                    if (c is Panel)
                        ((Panel)c).BackColor = System.Drawing.Color.Black;
                    if (c is Label)
                        ((Label)c).ForeColor = System.Drawing.Color.White;
                }
                else
                {
                    if (c is Panel)
                        ((Panel)c).BackColor = System.Drawing.Color.Silver;
                    if (c is Label)
                        ((Label)c).ForeColor = System.Drawing.Color.Black;
                }
            }
        }

        public void AtualizaAluno(int id, string nome, string rg, string cpf, string ra, string dataNasc, string tel, string cel, string email, string sexo)
        {
            try
            {
                mConn = new MySqlConnection(conexao);
                mConn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao se comunicar com o Banco");
            }
                string sql = "UPDATE `aluno` SET `nome`= '" + nome + "',`rg`= '"+ rg + "',`cpf`= '"+ cpf + "',`ra`='"+ ra + "',`sexo`='"+ sexo + "',`dataNasc`='"+ dataNasc + "' WHERE id = '"+ id + "' ;";
                using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
                {
                    cmd.ExecuteNonQuery();
                }
            mConn.Close();
        }

        public static void sendMail(string server, string From, string to, string subject, string body, string Cc, string fileAttachment)
        {
            SmtpClient smtp = new SmtpClient(server);
            MailMessage mailSend = new MailMessage();
            mailSend.From = new MailAddress(From.Replace(';', ','));
            mailSend.To.Add(to.Replace(';', ','));
            if (!String.IsNullOrEmpty(Cc))
                mailSend.CC.Add(Cc);
            mailSend.Subject = subject;
            mailSend.SubjectEncoding = System.Text.Encoding.UTF8;
            mailSend.Body = body;
            mailSend.BodyEncoding = System.Text.Encoding.UTF8;
            mailSend.IsBodyHtml = true;
            mailSend.Attachments.Add(new Attachment(fileAttachment));
            smtp.Send(mailSend);
        }


       
    }
}
