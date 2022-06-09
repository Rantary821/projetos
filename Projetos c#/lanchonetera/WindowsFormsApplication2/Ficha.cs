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

namespace WindowsFormsApplication2
{//IdFucnionario
    public partial class Ficha : Form
    {
        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private MySqlDataReader reader, reader1, reader2;
        private DataSet mDataSet;
        private MySqlCommand cmd, cmd1, cmd2;
        string dia;
        string mes;
        string semana;
        string dias;

        int numDias;

        public Ficha()
        {
            InitializeComponent();
            IniciandoFicha(this);
        }

        private void Ficha_Load(object sender, EventArgs e)
        {
            TxtNome.Text = Program.Nome;
            TxtRg.Text = Program.Rg;
            TxtCpf.Text = Program.Cpf;
            txtDiaria.Text = Program.ValorDiaria;
            if (TxtQuantDias.Text != "")
            {
                double conta = Convert.ToDouble(TxtQuantDias.Text);
                double conta1 = Convert.ToDouble(txtDiaria.Text);
                conta = conta * conta1;
                txtSalFinal.Text = Convert.ToString(conta);
            }

        }
        void diama(Control con)
        {

            if (semana == "Sunday")
            {
                semana = "Domingo";
            }
            if (semana == "Monday")
            {
                semana = "Segunda-Feira";
            }
            if (semana == "Tuesday")
            {
                semana = "Terça-Feira";
            }
            if (semana == "Wednesday")
            {
                semana = "Quarta-Feira";
            }
            if (semana == "Thursday")
            {
                semana = "Quinta-Feira";
            }
            if (semana == "Friday")
            {
                semana = "Sexta-Feira";
            }
            if (semana == "Saturday")
            {
                semana = "Sabado";
            }
        }
        private void fecharMes_Click(object sender, EventArgs e)
        {
            try
            {
                mConn = new MySqlConnection(Program.conexao);
                mConn.Open();
                string sql = "SELECT count(NumDias) FROM `diastrabalhados` WHERE IdFuncionario = @IDFuncionario;";
                using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
                {
                    cmd.Parameters.AddWithValue("@IDFuncionario", Program.IdFuncionario);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        dias = reader.GetString("count(NumDias)");
                    }
                    reader.Close();
                }

                mes = Convert.ToString(DateTime.Now.Month);

                sql = "INSERT INTO salarios (IdFuncionario, salario, mes) VALUES (@IdFuncionario, @salario, @mes);";
                using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
                {
                    cmd.Parameters.AddWithValue("@IdFuncionario", Program.IdFuncionario);                   
                    cmd.Parameters.AddWithValue("@salario", txtSalFinal.Text);
                    cmd.Parameters.AddWithValue("@mes", mes);
                    cmd.ExecuteNonQuery();
                }
                sql = "DELETE FROM diastrabalhados where IdFuncionario = @idFuncionario";
                using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
                {
                    cmd.Parameters.AddWithValue("@idFuncionario", Program.IdFuncionario);
                    cmd.ExecuteNonQuery();
                }

                FichaDataGrid.Refresh();
                mAdapter = new MySqlDataAdapter("SELECT diastrabalhados FROM `diastrabalhados` WHERE IdFuncionario = '" + Program.IdFuncionario + "' and diastrabalhados <> 0", mConn);
                mDataSet.Clear();
                mAdapter.Fill(mDataSet, "Tabela_dados");
                //atribui para o datagrid
                FichaDataGrid.DataSource = mDataSet;
                FichaDataGrid.DataMember = "Tabela_dados";
                FichaDataGrid.Columns[0].Width = 205;
                FichaDataGrid.Columns[0].HeaderText = "Dias Trabalhados";
                FichaDataGrid.RowHeadersWidth = 20;
                FichaDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
                FichaDataGrid.ColumnHeadersHeight = 30;
                mConn.Close();
                TxtQuantDias.Text = "0";
                txtSalFinal.Text = "";
                numDias = 0;
            }
            
            catch (MySqlException ex)
            {
                Program.LblMessage = "Um erro ocorreu!";
                Program.PicInterrog = "0";
                Program.PicAlert = "0";
                Program.PicError = "1";
                Program.PicVendaOK = "0";
                Program.btnNao = "0";
                Program.btnSim = "0";
                Program.btnOk = "1";

                FormMessageBox message = new FormMessageBox();
                message.ShowDialog();

                if (Program.MessageResult == "O")
                {
                    this.Close();
                }
            }
        }

        void IniciandoFicha(Control con)
        {
            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();
            string sql = "SELECT NumDias FROM `diastrabalhados` WHERE IdFuncionario = @IDFuncionario;";
            using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
            {
                cmd.Parameters.AddWithValue("@IDFuncionario", Program.IdFuncionario);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TxtQuantDias.Text = reader.GetString("NumDias");
                }
                reader.Close();
            }
            mDataSet = new DataSet();
            mAdapter = new MySqlDataAdapter("SELECT diastrabalhados FROM `diastrabalhados` WHERE IdFuncionario = '" + Program.IdFuncionario + "' and diastrabalhados <> 0", mConn);
            mAdapter.Fill(mDataSet, "Tabela_dados");
            //atribui para o datagrid
            FichaDataGrid.DataSource = mDataSet;
            FichaDataGrid.DataMember = "Tabela_dados";
            FichaDataGrid.Columns[0].Width = 205;
            FichaDataGrid.Columns[0].HeaderText = "Dias Trabalhados";
            FichaDataGrid.RowHeadersWidth = 20;
            FichaDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            FichaDataGrid.ColumnHeadersHeight = 30;
            mConn.Close();

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.dias = "";
            dia = Convert.ToString(DateTime.Now.Day);
            mes = Convert.ToString(DateTime.Now.Month);
            semana = Convert.ToString(DateTime.Now.DayOfWeek);
            mConn = new MySqlConnection(Program.conexao);
            mConn.Open();
            if (semana == "Sunday")
            {
                semana = "Domingo";
            }
            if (semana == "Monday")
            {
                semana = "Segunda-Feira";
            }
            if (semana == "Tuesday")
            {
                semana = "Terça-Feira";
            }
            if (semana == "Wednesday")
            {
                semana = "Quarta-Feira";
            }
            if (semana == "Thursday")
            {
                semana = "Quinta-Feira";
            }
            if (semana == "Friday")
            {
                semana = "Sexta-Feira";
            }
            if (semana == "Saturday")
            {
                semana = "Sabado";
            }
            
            string sql = "SELECT NumDias FROM `diastrabalhados` WHERE IdFuncionario = @IDFuncionario;";
            using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
            {
                cmd.Parameters.AddWithValue("@IDFuncionario", Program.IdFuncionario);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    numDias = reader.GetInt16("NumDias");
                }
                reader.Close();
            }
            numDias = numDias + 1;
            string dataCompleta = dia + "/" + mes + " " + semana;

            string sql1 = "select diastrabalhados from diastrabalhados where IdFuncionario = @IDFuncionario and diastrabalhados = @dia";
            using (MySqlCommand cmd = new MySqlCommand(sql1, mConn))
            {
                cmd.Parameters.AddWithValue("@IDFuncionario", Program.IdFuncionario);
                cmd.Parameters.AddWithValue("@dia", dataCompleta);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
            {
                Program.dias = reader.GetString("diastrabalhados");
            }
                reader.Close();
            }


            if (Program.dias == dataCompleta)
            {
                Program.LblMessage = "Já há registro no dia: " + dataCompleta;
                Program.PicInterrog = "0";
                Program.PicAlert = "1";
                Program.PicError = "0";
                Program.PicVendaOK = "0";
                Program.btnNao = "0";
                Program.btnSim = "0";
                Program.btnOk = "1";

                FormMessageBox message = new FormMessageBox();
                message.ShowDialog();
            }
            else
            {

                sql = "INSERT INTO diastrabalhados (IdFuncionario, DiasTrabalhados, NumDias) VALUES (@IdFuncionario, @DiasTrabalhados, @NumDias);";
                using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
                {
                    cmd.Parameters.AddWithValue("@IdFuncionario", Program.IdFuncionario);
                    cmd.Parameters.AddWithValue("@DiasTrabalhados", dataCompleta);
                    cmd.Parameters.AddWithValue("@NumDias", numDias);
                    cmd.ExecuteNonQuery();
                }
         
            }
            mDataSet = new DataSet();
            mAdapter = new MySqlDataAdapter("SELECT diastrabalhados FROM `diastrabalhados` WHERE IdFuncionario = '" + Program.IdFuncionario + "' and diastrabalhados <> 0", mConn);
            mAdapter.Fill(mDataSet, "Tabela_dados");
            //atribui para o datagrid
            FichaDataGrid.DataSource = mDataSet;
            FichaDataGrid.DataMember = "Tabela_dados";
            FichaDataGrid.Columns[0].Width = 205;
            FichaDataGrid.Columns[0].HeaderText = "Dias Trabalhados";
            FichaDataGrid.RowHeadersWidth = 20;
            FichaDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            FichaDataGrid.ColumnHeadersHeight = 30;
           


            string sql12 = "SELECT NumDias FROM `diastrabalhados` WHERE IdFuncionario = @IDFuncionario and diastrabalhados <> 0;";
            using (MySqlCommand cmd = new MySqlCommand(sql12, mConn))
            {
                cmd.Parameters.AddWithValue("@IDFuncionario", Program.IdFuncionario);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TxtQuantDias.Text = reader.GetString("NumDias");
                }
                reader.Close();
                double conta = Convert.ToDouble(TxtQuantDias.Text);
                double conta1 = Convert.ToDouble(txtDiaria.Text);
                conta = conta * conta1;
                txtSalFinal.Text = Convert.ToString(conta);
               

                string sql22 = "UPDATE `funcionario` SET `SalarioFinal` = @salario WHERE IdFuncionario = @id";
                using (MySqlCommand cmd2 = new MySqlCommand(sql22, mConn))
                {
                    cmd2.Parameters.AddWithValue("@salario", txtSalFinal.Text);
                    cmd2.Parameters.AddWithValue("@id", Program.IdFuncionario);
                    cmd2.ExecuteNonQuery();
                }
                
            }
            mConn.Close();
        }
    }
}
