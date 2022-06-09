using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Menu
{
    public partial class importacao : Form
    {
        string rg, nome, numeroP, concluinte, codcurso, ano;
        int count, outrocount, id;
        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private DataSet mDataSet;
        public importacao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mDataSet = new DataSet();
            mConn = new MySqlConnection(Program.conexao2);
            mConn.Open();
            /*  outrocount = 29227;
              mDataSet = new DataSet();
              string sql = "select * from alunos;";
              MySqlCommand cmd = new MySqlCommand(sql, mConn);
              mConn = new MySqlConnection(Program.conexao);
              mConn.Open();
              MySqlDataReader reader = cmd.ExecuteReader();
              do
              {
                  while (reader.Read())
                  {
                      rg = reader.GetString("RG");
                      nome = reader.GetString("Nome");
                      numeroP = reader.GetString("NumP");
                      codcurso = reader.GetString("CodCur");
                      ano = reader.GetString("Ano");
                      concluinte = reader.GetString("Concluintes");
                      count++;
                      id++;
                  }
                  //aluno
                  mAdapter = new MySqlDataAdapter("INSERT INTO aluno (idAluno, nomeAluno, RG) values ('" + id + "', '" + nome+ "', '" + rg + "');", mConn);
                  mAdapter.Fill(mDataSet, "Tabela_dados");
                  //matricula
                  //mAdapter = new MySqlDataAdapter("INSERT INTO matricula (anoEnt, concluinte, idAluno, idCurso, numeroMatricula, numeroPasta, id_arquivo) values ('" +  + "', '" + concluinte + "', '" +  + "','" +  + "', " +  + ", '" +  + "', '" +  + "');", mConn);
                  mAdapter.Fill(mDataSet, "Tabela_dados");
              } while (count < outrocount);
              mConn.Close();
              reader.Close();
              */
        }
    }
}
