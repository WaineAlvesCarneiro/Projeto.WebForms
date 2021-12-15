using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using WebForms.Pessoa.Models;

namespace WebForms.Pessoa.Data
{
    public class GerPessoa : Conexao
    {
        #region Gravar
        public void Gravar(PessoaModel pessoaModel)
        {
            Conectar();
            try
            {
                SqlCommand comando = new SqlCommand("Gravar", sqlConexao)
                {
                    CommandType = CommandType.StoredProcedure
                };

                comando.Parameters.Add(new SqlParameter("@nome", pessoaModel.Nome));
                comando.Parameters.Add(new SqlParameter("@tipopessoa", pessoaModel.TipoPessoa));

                comando.ExecuteNonQuery();
                comando.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Desconectar();
            }
        }
        #endregion

        #region Consulta
        public List<PessoaModel> Consultar()
        {
            List<PessoaModel> lista = new List<PessoaModel>();
            Conectar();
            try
            {
                SqlCommand comando = new SqlCommand("Consultar", sqlConexao)
                {
                    CommandType = CommandType.StoredProcedure
                };

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    PessoaModel pessoaModel = new PessoaModel()
                    {
                        Id = int.Parse(reader[0] + ""),
                        Nome = reader[1] + "",
                        TipoPessoa = int.Parse(reader[2] + ""),
                    };
                    lista.Add(pessoaModel);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Desconectar();
            }
            return lista;
        }
        #endregion
    }
}