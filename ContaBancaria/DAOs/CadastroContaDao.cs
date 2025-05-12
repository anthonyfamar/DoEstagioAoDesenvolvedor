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

		public void InserirConta(string numConta, int idUsuario, int idAgencia, out string mensagem)
		{
			mensagem = "";

			if (string.IsNullOrEmpty(numConta) || idUsuario <= 0 || idAgencia <= 0)
			{
				mensagem = "<div class='alert alert-warning'>Por favor, preencha todos os campos.</div>";
				return;
			}

			try
			{
				using (SqlConnection conn = new SqlConnection(_conexao))
				{
					string sql = "INSERT INTO ContaBancaria(NumConta, IdUsuario, IdAgencia) VALUES (@NumConta, @IdUsuario, @IdAgencia)";

					SqlCommand cmd = new SqlCommand(sql, conn);

					cmd.Parameters.AddWithValue("@NumConta", numConta);
					cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
					cmd.Parameters.AddWithValue("@IdAgencia", idAgencia);

					conn.Open();
					cmd.ExecuteNonQuery();

					mensagem = "<div class='alert alert-success'>Conta cadastrada com sucesso!</div>";
				}
			}
			catch (SqlException ex)
			{
				if (ex.Number == 2627 || ex.Number == 2601)
				{
					mensagem = "<div class='alert alert-danger'>Erro: Conta já cadastrada.</div>";
				}
				else
				{
					mensagem = $"<div class='alert alert-danger'>Erro: {ex.Message}</div>";
				}
			}

		}
	}
}