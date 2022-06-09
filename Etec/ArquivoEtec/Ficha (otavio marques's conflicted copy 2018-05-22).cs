using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using TesteMostrarImagens;
using System.IO;

namespace ArquivoEtec
{
    public partial class Ficha : Form
    {
        SqlConnection mConn;

        bool modoUpdate = false;
        int IdPri;
        string situacao, VCpf, VNome, VRg, VAno, VCodCurso, VCel1, VCel2, VTel1, VTel2, VEmail1, VEmail2, VBairro, VRua, VComplemento, VCidade, VNumero, VCep, VUf;

        void ChamadaArquivos(string Id)
        {
            string IdPrimario = "0";
            Arquivo formArquivos = new Arquivo();

            formArquivos.ShowDialog(ref IdPrimario);

            formArquivos.TopLevel = false;

            formArquivos.Visible = true;

            //adding a panel in second form and placing the Form1 inside panel.

            this.Controls.Add(PnlArquivos);

            PnlArquivos.Controls.Add(formArquivos);
        }

        private void TxtCodCurso_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ComboCurso.SelectedValue = Convert.ToInt32(TxtCodCurso.Text);
            }
            catch
            {
                ComboCurso.SelectedIndex = -1;
            }

            if (modoUpdate)
            {
                ValidaUpdate();
            }
        }

        private void ComboCurso_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TxtCodCurso.Text = ComboCurso.SelectedValue.ToString();
            }
            catch
            {

            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            Conect(true);
            using (IDbTransaction tran = mConn.BeginTransaction())
            {
                try
                {
                    //chama metodo para "DeleteAluno"
                    uti.DeleleAluno(IdPri.ToString());

                    MessageBox.Show("Aluno excluido com sucesso");

                    this.Close();

                    tran.Commit();
                }
                catch
                {
                    MessageBox.Show("Erro ao tentar excluir o aluno!!");
                    tran.Rollback();
                    throw;
                }
            }
            Conect(false);
        }

        Utilidades uti = new Utilidades();

        public Ficha()
        {
            InitializeComponent();
        }

        void Conect(bool AbreFecha)
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

        public void ShowDialog(ref int idPrimario)
        {
            IdPri = idPrimario;
            this.ShowDialog();
        }

        private void Ficha_Load(object sender, EventArgs e)
        {
            BuscarDados(IdPri);
            Pegavalores();
            modoUpdate = true;

            buscaCursos();
            ComboCurso.SelectedIndex = -1;
            TxtCodCurso.Text = "";

            ChamadaArquivos(IdPri.ToString());
        }

        void BuscarDados(int idPrimario)
        {
            string concluinte = "", cpf = "";
            try
            {
                Conect(true);

                string sql1 = "SELECT a.nome, a.rg, c.Cel1, c.Cel2, c.Tel1, c.Tel2, c.Email1, c.Email2, e.bairro, e.rua, e.complemento, e.Cidade, e.numero, e.Cep, e.Uf, m.idCurso, m.idMatricula, m.AnoMat, m.Concluinte, a.cpf " +
                              "FROM aluno a JOIN contato c ON a.IdAluno = c.IdAluno JOIN endereco e ON a.IdAluno = e.IdAluno JOIN matricula m on a.idAluno = m.idAluno " +
                              "WHERE m.idPrimario = @Id;";
                using (SqlCommand cmd1 = new SqlCommand(sql1, mConn))
                {
                    cmd1.Parameters.AddWithValue("@Id", idPrimario);
                    cmd1.ExecuteNonQuery();

                    SqlDataReader reader = cmd1.ExecuteReader();
                    while (reader.Read())
                    {
                        TxtNome.Text = reader.GetString(0);
                        TxtRg.Text = reader.GetString(1);
                        TxtCel1.Text = reader.GetString(2);
                        TxtCel2.Text = reader.GetString(3);
                        TxtTel1.Text = reader.GetString(4);
                        TxtTel2.Text = reader.GetString(5);
                        TxtEmail1.Text = reader.GetString(6);
                        TxtEmail2.Text = reader.GetString(7);
                        TxtBairro.Text = reader.GetString(8);
                        TxtRua.Text = reader.GetString(9);
                        TxtComplemento.Text = reader.GetString(10);
                        txtCidade.Text = reader.GetString(11);
                        TxtNumero.Text = reader.GetString(12);
                        TxtCep.Text = reader.GetString(13);
                        txtUf.Text = reader.GetString(14);
                        TxtCodCurso.Text = reader.GetInt32(15).ToString();
                        TxtPasta.Text = reader.GetInt32(16).ToString();
                        TxtAno.Text = reader.GetInt32(17).ToString();
                        concluinte = reader.GetString(18);
                        cpf = reader.GetString(19);
                    }
                }

                Conect(false);

                if (concluinte == "SIM")
                {
                    RadConcluinte.Checked = true;
                }
                else
                if (concluinte == "NAO")
                {
                    RadNConcluinte.Checked = true;
                }

                TxtCpf.Text = cpf;
            }
            catch (Exception ex)
            {

            }
        }

        void buscaCursos()
        {
            Conect(true);

            try
            {
                SqlCommand mAdapter = new SqlCommand("SELECT * FROM curso ORDER by IdCurso;", mConn);
                SqlDataReader reader = mAdapter.ExecuteReader();//retorna dados resultantes da consulta em SQL
                DataTable table = new DataTable(); //estrutura da tabela do banco de dados ou de outra fonte de informação
                table.Load(reader); //carrega dados na tabela de acordo com a instrução sql passada 
                DataRow row = table.NewRow(); //representa uma linha de dados em um DataTable
                row["NomeCurso"] = ""; //para não gerar valor nulo e, consequentemente, evitar erro de execução


                this.ComboCurso.DataSource = table;
                this.ComboCurso.ValueMember = "IdCurso";
                this.ComboCurso.DisplayMember = "NomeCurso";//obtem o nome do curso
                reader.Close();//fecha o objeto
                reader.Dispose();//liberamos o objeto da memoria

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na busca dos cursos cadastrados!" + Environment.NewLine + ex);
            }

            Conect(false);
        }

        private void btnFecha_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtCpf_Click(object sender, EventArgs e)
        {
            //Caso clique e não tenha nada preenchido leva o cursor para o inicio
            if (TxtCpf.Text == "   .   .   -")
            {
                TxtCpf.Select(0, 0);
            }
        }

        private void TxtCel1_Click(object sender, EventArgs e)
        {
            //Caso clique e não tenha nada preenchido leva o cursor para o inicio
            if (TxtCel1.Text == "   .   .   -")
            {
                TxtCel1.Select(0, 0);
            }
        }

        private void TxtTel1_Click(object sender, EventArgs e)
        {
            //Caso clique e não tenha nada preenchido leva o cursor para o inicio
            if (TxtTel1.Text == "   .   .   -")
            {
                TxtTel1.Select(0, 0);
            }
        }

        private void TxtCel2_Click(object sender, EventArgs e)
        {
            //Caso clique e não tenha nada preenchido leva o cursor para o inicio
            if (TxtCel2.Text == "   .   .   -")
            {
                TxtCel2.Select(0, 0);
            }
        }

        private void TxtTel2_Click(object sender, EventArgs e)
        {
            //Caso clique e não tenha nada preenchido leva o cursor para o inicio
            if (TxtTel2.Text == "   .   .   -")
            {
                TxtTel2.Select(0, 0);
            }
        }

        private void TxtCpf_TextChanged(object sender, EventArgs e)
        {
            //validação do cpf

            string cpf = TxtCpf.Text, ValCpf = "";
            cpf = String.Concat(cpf.Where(Char.IsDigit)); //Concatena apenas os digitos para tirar a mascara

            if (cpf.Length >= 9)
            {
                if (cpf.Length == 11 && cpf.Distinct().Count() != 1) //varifica se o tamanho é igual a 11 digitos, verifica se possui todos os digitos iguais 
                {
                    int Sum = 0, Mult = 0, Dig1 = 0, Dig2 = 0;

                    Mult = 10; //Primeira multiplicação é feita por 10

                    for (int i = 0; i < 9; i++)//Validação do primeiro digito
                    {
                        ValCpf += cpf[i].ToString();

                        //Cada um dos primeiros 9 caracteres são multiplicados, o primeiro caracter por 10, o segundo por 9, terceiro por 8, etc.
                        Sum += (Convert.ToInt32(cpf[i].ToString()) * Mult);

                        Mult--;
                    }

                    if (((Sum * 10) % 11) > 9)//Caso o resultado da operação sejá maior q 9, obrigatoriamente o digito recebe valor 0
                    {
                        Dig1 = 0;
                    }
                    else//caso seja menor q 9, o digito recebe o proprio resultado da operação
                    {
                        Dig1 = (Sum * 10) % 11;
                    }

                    ValCpf += Dig1;

                    bool verify1 = uti.CompararCpf(10, ValCpf, cpf);//Comparãção dos digitos

                    if (verify1)//Caso a primeira comparação resulte em true 
                    {
                        Mult = 11;
                        ValCpf = "";
                        Sum = 0;

                        for (int i = 0; i < 10; i++)//Validação do segundo digito
                        {
                            ValCpf += cpf[i].ToString();

                            //Cada um dos primeiros 10 caracteres são multiplicados, o primeiro caracter por 11, o segundo por 10, terceiro por 9, etc.
                            Sum += (Convert.ToInt32(cpf[i].ToString()) * Mult);

                            Mult--;
                        }

                        if (((Sum * 10) % 11) > 9)//Caso o resultado for maior q 9 o digito revebe 0
                        {
                            Dig2 = 0;
                        }
                        else
                        {
                            Dig2 = (Sum * 10) % 11;//Caso o resultado for menor o digito recebe o proprio valor da operação
                        }

                        ValCpf += Dig2;

                        bool verify2 = uti.CompararCpf(11, ValCpf, cpf);//Nova comparação dos digitos

                        if (verify2)//Caso a segunda comparação resulte em true 
                        {
                            ImgTrue.Visible = true;
                            ImgFalse.Visible = false;
                        }
                        else//Caso a segunda comparação resulte em false
                        {
                            ImgTrue.Visible = false;
                            ImgFalse.Visible = true;
                        }
                    }
                    else//Caso a primeira comparação resulte em false
                    {
                        ImgTrue.Visible = false;
                        ImgFalse.Visible = true;
                    }
                }
            }
            if (cpf.Length < 11)
            {
                ImgFalse.Visible = false;
                ImgTrue.Visible = false;
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Conect(true);

                //Pegando apenas digitos para tirar a mascara
                string c1 = String.Concat(TxtCel1.Text.Where(Char.IsDigit));
                string c2 = String.Concat(TxtCel2.Text.Where(Char.IsDigit));
                string t1 = String.Concat(TxtTel1.Text.Where(Char.IsDigit));
                string t2 = String.Concat(TxtTel2.Text.Where(Char.IsDigit));

                using (IDbTransaction tran = mConn.BeginTransaction())
                {
                    try
                    {
                        //Chamada dos metodos de update das tabelas
                        uti.UpdateAluno(IdPri.ToString(), TxtNome.Text, TxtRg.Text);
                        uti.UpdateContato(IdPri.ToString(), c1, c2, t1, t2, TxtEmail1.Text, TxtEmail2.Text);
                        uti.UpdateEndereco(IdPri.ToString(), TxtRua.Text, TxtBairro.Text, TxtNumero.Text, TxtComplemento.Text, txtCidade.Text, txtUf.Text, TxtCep.Text);
                        uti.UpdateMatricula(IdPri.ToString(), TxtAno.Text, TxtCodCurso.Text);
                        tran.Commit();
                    }
                    catch
                    {
                        tran.Rollback();
                        throw;
                    }
                }

                BtnUpdate.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de comunicação com o banco!" + ex);
            }

            Conect(false);
        }

        private void ValidaUpdate()
        {
            bool valida = false;

            if (TxtCodCurso.Text == VCodCurso &&
                TxtAno.Text == VAno &&
                TxtCpf.Text == VCpf &&
                TxtRg.Text == VRg &&
                TxtNome.Text == VNome &&
                TxtCel1.Text == VCel1 &&
                TxtCel2.Text == VCel2 &&
                TxtTel1.Text == VTel1 &&
                TxtTel2.Text == VTel2 &&
                TxtEmail1.Text == VEmail1 &&
                TxtEmail2.Text == VEmail2 &&
                TxtBairro.Text == VBairro &&
                TxtRua.Text == VRua &&
                TxtComplemento.Text == VComplemento &&
                txtCidade.Text == VCidade &&
                TxtNumero.Text == VNumero &&
                TxtCep.Text == VCep &&
                txtUf.Text == VUf)

            { valida = false; } else { valida = true; }

            if (valida == true)
            {
                BtnUpdate.Visible = true;
            }
            else
            if (valida == false)
            {
                BtnUpdate.Visible = false;
            }

            if (TxtCodCurso.Text == "" || TxtNome.Text == "" || TxtAno.Text == "" || ComboCurso.Text == "")
            {
                BtnUpdate.Visible = false;
                BtnExcluir.Visible = true;
            }
        }

        private void Pegavalores()
        {
            VAno = TxtAno.Text;
            VCodCurso = TxtCodCurso.Text;
            VCpf = TxtCpf.Text;
            VRg = TxtRg.Text;
            VNome = TxtNome.Text;
            VCel1 = TxtCel1.Text;
            VCel2 = TxtCel2.Text;
            VTel1 = TxtTel1.Text;
            VTel2 = TxtTel2.Text;
            VEmail1 = TxtEmail1.Text;
            VEmail2 = TxtEmail2.Text;
            VBairro = TxtBairro.Text;
            VRua = TxtRua.Text;
            VComplemento = TxtComplemento.Text;
            VCidade = txtCidade.Text;
            VNumero = TxtNumero.Text;
            VCep = TxtCep.Text;
            VUf = txtUf.Text;
        }

        private void textBoxes_TextChanged(object sender, EventArgs e)
        {
            if (modoUpdate)
            {
                ValidaUpdate();
            }
        }

    }
}
