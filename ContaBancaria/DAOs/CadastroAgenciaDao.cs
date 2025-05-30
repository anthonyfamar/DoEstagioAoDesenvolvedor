using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ContaBancaria.DAOs
{
    public class CadastroAgenciaDao
    {
        private readonly string _conexao;

        public CadastroAgenciaDao()
        {
            _conexao = ConfigurationManager.ConnectionStrings["MinhaConexao"].ConnectionString;
        }

        public List<string> ListarAgencias(out string mensagem)
        {
            mensagem = "";
            List<string> agencias = new List<string>();

            try
            {
                using (SqlConnection conn = new SqlConnection(_conexao))
                {
                    string sql = "SELECT NumAgencia FROM Agencia";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        agencias.Add(reader["NumAgencia"].ToString());
                    }

                    mensagem = "<div class='alert alert-success'>Agências carregadas com sucesso!</div>";
                }
            }
            catch (SqlException ex)
            {
                mensagem = $"<div class='alert alert-danger'>Erro ao buscar agências: {ex.Message}</div>";
            }

            return agencias;
        }
    }
}