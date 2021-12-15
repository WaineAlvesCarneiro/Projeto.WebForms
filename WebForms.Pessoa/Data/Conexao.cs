using System;
using System.Data.SqlClient;

namespace WebForms.Pessoa.Data
{
    public class Conexao
    {
        protected SqlConnection sqlConexao;
        string sql = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Projetos\\Projeto.WebForms\\WebForms.Pessoa\\App_Data\\PessoaDB.mdf;Integrated Security=True";
        protected void Conectar() {
            try
            {
                sqlConexao = new SqlConnection(sql);
                sqlConexao.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
        protected void Desconectar()
        {
            try
            {
                sqlConexao.Close();
                sqlConexao.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}