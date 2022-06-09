using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.IO;

namespace Menu_Principal
{
    class utilidades
    {
        #region variaveis
        string nome, rg, cpf, ra, sexo, nasc, email, tel, cel, email2, tel2, cel2, idBackup, insert1, insert2, insert3;
        string pathBackUp = @"C:\Dropbox\FisoBarretos\BackupAlunos.txt";
        int id, IdBusca, idMin;

        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private MySqlDataReader reader;
        private MySqlCommand cmd;
        private DataSet mDataSet;
        public int idd, iddMIn, countAlunos;
        public int ve;
        public string conexao = "server=localhost; database=soares; UID=root; PASSWORD = 06200318; port=3306";
        
        #endregion


        #region clearBlock
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

        public void BlockThings(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Enabled = false;
                if (c is RadioButton)
                    ((RadioButton)c).Enabled = false;
                if (c is ComboBox)
                    ((ComboBox)c).Enabled = false;
                if (c is MaskedTextBox)
                    ((MaskedTextBox)c).Enabled = false;
                else
                    BlockThings(c);
            }
        }

        public void FreeThings(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Enabled = true;
                if (c is RadioButton)
                    ((RadioButton)c).Enabled = true;
                if (c is ComboBox)
                    ((ComboBox)c).Enabled = true;
                if (c is MaskedTextBox)
                    ((MaskedTextBox)c).Enabled = true;
                else
                    FreeThings(c);
            }
        }

        #endregion


        #region pesquisas
        public void TesteCadastros()//Inserir alunos pra teste
        {
            selectIdAluno();

            double id = idd, c = 0;
            string nome, outros;

            mConn = new MySqlConnection(conexao);
            mConn.Open();

            do
            {
                int count = 0;
                nome = "Aluno nº " + id.ToString();
                outros = "Teste: " + id.ToString();

                string sql1 = "INSERT INTO `aluno`(`id`, `nome`, `rg`, `cpf`, `ra`, `sexo`, `dataNasc`) VALUES ('" + id + "','"+nome+"', '"+ outros + "', '" + outros + "', '" + outros + "', ' Masculino ', '" + outros+"');";
                using (MySqlCommand cmd = new MySqlCommand(sql1, mConn))
                {
                    cmd.ExecuteNonQuery();
                }

                do
                {
                    string sql2 = "INSERT INTO `dados`(`tel`, `cel`, `email`, `idAluno`) VALUES ('" + outros + "', '" + outros + "', '" + outros + "', '" + id + "');";
                    using (MySqlCommand cmd = new MySqlCommand(sql2, mConn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    count++;
                } while (count < 2);

                Directory.CreateDirectory(@"C:\Dropbox\FisoBarretos\" + id);
                id++;
                c++;
            }
            while (c < 600);// <- Quantidade de registros  
            mConn.Close();
        }

        public void Pesquisa(string nome, string cpf, string rg, DataGridView data)
        {
            try
            {
                mConn = new MySqlConnection(conexao);
                mConn.Open();
                string sql1 = "select `id`, `nome`, `rg`, `cpf`, `ra`, `sexo`, `dataNasc` from aluno where (nome LIKE '%" + nome + "%' AND nome <> 'DELETE')",
                       sql2 = "select * from aluno where (cpf LIKE '%" + cpf + "%' AND nome <> 'DELETE')",
                       sql3 = "select * from aluno where (ra LIKE '%" + rg + "%' AND nome <> 'DELETE')",
                       sql4 = "select * from aluno where nome <> 'DELETE'";
                mDataSet = new DataSet();
                if (ve == 1)
                {
                    mAdapter = new MySqlDataAdapter(sql1, mConn);
                    mAdapter.Fill(mDataSet, "Tabela_dados");
                }
                else if (ve == 2)
                {
                    mAdapter = new MySqlDataAdapter(sql2, mConn);
                    mAdapter.Fill(mDataSet, "Tabela_dados");
                }
                else if (ve == 3)
                {
                    mAdapter = new MySqlDataAdapter(sql3, mConn);
                    mAdapter.Fill(mDataSet, "Tabela_dados");
                }
                else
                {
                    mAdapter = new MySqlDataAdapter(sql4, mConn);
                    mAdapter.Fill(mDataSet, "Tabela_dados");
                }
                data.DataSource = mDataSet;
                data.DataMember = "Tabela_dados";


            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Erro ao tentar conectar com o banco de Dados!");
            }
        }
        public void selectIdAluno()
        {
            string sql = "SELECT MAX(id) FROM aluno";
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
                        idd = reader.GetInt32("MAX(id)");
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

        public void CountAlunos()
        {
            string sql = "SELECT COUNT(id) FROM `aluno` where nome <> 'DELETE'";
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
                        countAlunos = reader.GetInt32("COUNT(id)");
                    }
                    catch (System.Data.SqlTypes.SqlNullValueException ex)
                    {
                        //se for nulo a variavel NumMatricula recebe 0
                        countAlunos = 0;
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
                        iddMIn = reader.GetInt32("MIN(id)");
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

        #endregion


        #region ficha
        public void ficha(DataGridView data)
        {
            try
            {
                Program.id = Convert.ToInt16(data.CurrentRow.Cells[0].Value.ToString());
            } catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro inexperado! Por favor tente novamente.");
            }
        }
        public void fichaLoad(int id, TextBox nome, MaskedTextBox cpf, TextBox rg, TextBox ra, MaskedTextBox nasc, ComboBox sexo, ComboBox email, ComboBox tel, ComboBox cel)
        {
            try
            {
                mConn = new MySqlConnection(conexao);
                mConn.Open();
                string sql = "SELECT a.nome, a.rg, a.cpf, a.ra, a.sexo, a.dataNasc, d.tel, d.cel, d.email FROM aluno a JOIN dados d ON d.idAluno = a.id WHERE a.id = " + id + ";";
                using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
                {
                    int i = 0;
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string VerificaNome = reader.GetString("nome");

                        if (VerificaNome != "Delete")
                        {
                            if (i == 0)
                            {
                                nome.Text = reader.GetString("nome");
                                rg.Text = reader.GetString("rg");
                                cpf.Text = reader.GetString("cpf");
                                ra.Text = reader.GetString("ra");
                                sexo.Text = reader.GetString("sexo");
                                nasc.Text = reader.GetString("dataNasc");
                                email.Items.Add(reader.GetString("email"));
                                tel.Items.Add(reader.GetString("tel"));
                                cel.Items.Add(reader.GetString("cel"));
                                i++;
                            }
                            else
                            {
                                email.Items.Add(reader.GetString("email"));
                                tel.Items.Add(reader.GetString("tel"));
                                cel.Items.Add(reader.GetString("cel"));
                            }
                        }
                    }
                    reader.Close();
                    mConn.Close();
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Erro ao tentar conectar com o banco de Dados!");
            }
        }

        #endregion


        #region cadastroBackup
        public void cadastraAluno(int id, string nome, string rg, string cpf, string ra, string dataNasc, string sexo, string emaill, string tell, string cell, string email2, string tell2, string cel2)
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
            if (nome != "")
            {
                string sql = "INSERT INTO aluno (id, nome, rg, cpf, ra, dataNasc, sexo) values (" + id + ", '" + nome + "','" + rg + "','" + cpf + "','" + ra + "','" + dataNasc + "','" + sexo + "');";
                using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
                {
                    cmd.ExecuteNonQuery();
                }
                #region cadastroDados
                try
                {
                    string insert = "insert into dados (tel, cel, email, idAluno) values ( @tel, @cel, @email, @idAluno)";
                    string[] email = new string[2];
                    string[] cel = new string[2];
                    string[] tel = new string[2];


                    for (int count = 0; count <= 1; count++)
                    {
                        if (count == 0)
                        {
                            email[count] = emaill;
                            cel[count] = cell;
                            tel[count] = tell;
                            using (MySqlCommand cmd = new MySqlCommand(insert, mConn))
                            {
                                cmd.Parameters.AddWithValue("@tel", tel[count]);
                                cmd.Parameters.AddWithValue("@cel", cel[count]);
                                cmd.Parameters.AddWithValue("@email", email[count]);
                                cmd.Parameters.AddWithValue("@idAluno", id);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        if (count == 1)
                        {
                            email[count] = email2;
                            cel[count] = cel2;
                            tel[count] = tell2;
                            using (MySqlCommand cmd = new MySqlCommand(insert, mConn))
                            {
                                cmd.Parameters.AddWithValue("@tel", tel[count]);
                                cmd.Parameters.AddWithValue("@cel", cel[count]);
                                cmd.Parameters.AddWithValue("@email", email[count]);
                                cmd.Parameters.AddWithValue("@idAluno", id);
                                cmd.ExecuteNonQuery();
                            }

                        }
                        #endregion
                        //    codigo para verificar se o aluno já tem pasta e se não tiver ele cria
                        string dir = @"C:\Dropbox\FisoBarretos\" + idd;
                        if (!Directory.Exists(dir))
                        {
                            Directory.CreateDirectory(dir);                          
                        }



                    }
                }
                catch (Exception ex) {
                    MessageBox.Show("" + ex);
                }
             }
             mConn.Close();
        } 

        public void deleteAluno(int id)
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
                string sql = "UPDATE aluno set nome = 'DELETE' WHERE id = "+ id +";";
                using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
                {
                    cmd.ExecuteNonQuery();
                }
            mConn.Close();
        }

        public void backupBanco()
        {
            try
            {
                mConn = new MySqlConnection(conexao);
                mConn.Open();

                string sql = "SELECT a.id, a.nome, a.rg, a.cpf, a.ra, a.sexo, a.dataNasc, d.tel, d.cel, d.email FROM aluno a JOIN dados d ON d.idAluno = a.id;";

                using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
                {
                    if (File.Exists(pathBackUp))
                    {
                        File.Delete(pathBackUp);
                        using (StreamWriter sw = File.CreateText(pathBackUp))
                        {
                            sw.Dispose();
                        }
                    }
                    else
                    if (!File.Exists(pathBackUp))
                    {
                        using (StreamWriter sw = File.CreateText(pathBackUp))
                        {
                            sw.Dispose();
                        }
                    }

                    int i = 0;
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if (i == 0)
                        {
                            idBackup = reader.GetString("id");
                            nome = reader.GetString("nome");
                            rg = reader.GetString("rg");
                            cpf = reader.GetString("cpf");
                            ra = reader.GetString("ra");
                            sexo = reader.GetString("sexo");
                            nasc = reader.GetString("dataNasc");
                            email = reader.GetString("email");
                            tel = reader.GetString("tel");
                            cel = reader.GetString("cel");
                            i++;

                            insert1 = "INSERT INTO aluno(id, nome, rg, cpf, ra, sexo, dataNasc) VALUES ('" + idBackup + "', '" + nome + "', '" + rg + "', '" + cpf + "', '" + ra + "', '" + sexo + "', '" + nasc + "');";
                            insert2 = "INSERT INTO dados(tel, cel, email, idAluno) VALUES ('" + tel + "', '" + cel + "', '" + email + "', '" + idBackup + "');";
                            File.AppendAllText(pathBackUp, string.Format("{0}{1}", insert1, Environment.NewLine));
                            File.AppendAllText(pathBackUp, string.Format("{0}{1}", insert2, Environment.NewLine));
                        }
                        else
                        {
                            email2 = reader.GetString("email");
                            tel2 = reader.GetString("tel");
                            cel2 = reader.GetString("cel");

                            insert3 = "INSERT INTO dados(tel, cel, email, idAluno) VALUES ('" + tel2 + "', '" + cel2 + "', '" + email2 + "', '" + idBackup + "');";
                            File.AppendAllText(pathBackUp, string.Format("{0}{1}", insert3, Environment.NewLine));
                            File.AppendAllText(pathBackUp, string.Format("{0}{1}", "", Environment.NewLine));
                            i = 0;
                        }
                    }
                    reader.Close();
                    mConn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao se comunicar com o Banco");
            }
        }
        #endregion
    }

}