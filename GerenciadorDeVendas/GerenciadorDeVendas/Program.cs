using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeVendas
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuP());
        }

        public static string conexao = "Persist Security info=False; server=localhost; database=gerenciadorcaixa; uid=root";
        public static string selecionar, IdSelected, idprodutoSelec, ValorInicialEscolhido, venceu;
        public static double ValorTotal;
        public static int x, Y;
    }
}

/* mConn = new MySqlConnection(Program.conexao);
   mConn.Open();
   string sql = "SELECT preco FROM `produtos` WHERE nomeProduto = @nomeProduto;";
   using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
   {
       cmd.Parameters.AddWithValue("@nomeProduto", ComboProduto.Text);
       MySqlDataReader reader = cmd.ExecuteReader();
       while (reader.Read())
       {
           TxtPrecoUni.Text = reader.GetString("preco");
       }
       reader.Close();
   }

   mConn = new MySqlConnection(Program.conexao);
   mConn.Open();
   sql = "UPDATE `clientes` SET `Divida`= @Divida WHERE idCliente = @idCliente;";
   using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
   {
        cmd.Parameters.AddWithValue("@Divida", InsertDivida);
        cmd.ExecuteNonQuery();
   }       

    mConn = new MySqlConnection(Program.conexao);
   mConn.Open();
   string sql = "INSERT INTO vendas (idCliente, Produto, idVenda, PrecoUni, quant, Detalhes, ValorTotal, DataCompra, Forma) VALUES (@idcliente, @prod, @idvenda, @precouni, @quant, @detalhes, @valortotal, @data, @Forma);";
           using (MySqlCommand cmd = new MySqlCommand(sql, mConn))
           {
               cmd.Parameters.AddWithValue("@idcliente", InsertIdCLiente);
               cmd.Parameters.AddWithValue("@idvenda", InsertIdVenda);
               cmd.Parameters.AddWithValue("@prod", InsertProd);
               cmd.Parameters.AddWithValue("@precouni", InsertUni);
               cmd.Parameters.AddWithValue("@quant", InsertQuant);
               cmd.Parameters.AddWithValue("@detalhes", InsertDetelhes);
               cmd.Parameters.AddWithValue("@valortotal", InsertPrecototal);
               cmd.Parameters.AddWithValue("@data", data);
               cmd.Parameters.AddWithValue("@Forma", InsertForma);
               cmd.ExecuteNonQuery();
           }
*/
/*
 *  if (e.KeyChar == '.' || e.KeyChar == ',')
     {
         //troca o . pela virgula
         e.KeyChar = ',';

         //Verifica se já existe alguma vírgula na string
         if (TxtPagar.Text.Contains(","))
         {
             e.Handled = true; // Caso exista, aborte 
         }
     }
     else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
     {
         e.Handled = true;
     }
 */
