using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ContaBancaria.DAOs
{
	public class CadastroContaDao
	{
		private readonly string _conexao;

		public CadastroContaDao()
		{
			_conexao = ConfigurationManager.ConnectionStrings["MinhaConexao"].ConnectionString;
		}

        public bool ContaExiste(string numConta, int idAgencia)
        {
            using (SqlConnection conn = new SqlConnection(_conexao))
            {
                string sql = "SELECT COUNT(*) FROM ContaBancaria WHERE NumConta = @NumConta AND AgenciaId = @IdAgencia";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@NumConta", numConta);
                cmd.Parameters.AddWithValue("@IdAgencia", idAgencia);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();

                return count > 0;
            }
        }

        public void InserirConta(string numConta, int idUsuario, int idAgencia, out string mensagem)
		{
			mensagem = "";

			if (string.IsNullOrEmpty(numConta) || idUsuario <= 0 || idAgencia <= 0)
			{
				mensagem = "<div class='alert alert-warning'>Por favor, preencha todos os campos.</div>";
				return;
			}

            if (ContaExiste(numConta, idAgencia))
            {
                mensagem = "<div class='alert alert-danger'>Erro: Já existe uma conta com esse número nesta agência.</div>";
                return;
            }

            try
			{
				using (SqlConnection conn = new SqlConnection(_conexao))
				{
					string sql = "INSERT INTO ContaBancaria(NumConta, UsuarioId, AgenciaId, Saldo) VALUES (@NumConta, @UsuarioId, @AgenciaId, @Saldo)";

					SqlCommand cmd = new SqlCommand(sql, conn);

					cmd.Parameters.AddWithValue("@NumConta", numConta);
					cmd.Parameters.AddWithValue("@UsuarioId", idUsuario);
					cmd.Parameters.AddWithValue("@AgenciaId", idAgencia);
					cmd.Parameters.AddWithValue("@Saldo", 0.0m);

                    conn.Open();
					cmd.ExecuteNonQuery();

					mensagem = "<div class='alert alert-success'>Conta cadastrada com sucesso!</div>";
				}
			}
            catch (SqlException ex)
            {
                mensagem = $"<div class='alert alert-danger'>Erro: {ex.Message}</div>";
            }

        }
	}
}