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

		public void InserirAgencia(string numAgencia, out string mensagem)
		{
			mensagem = "";

			if (string.IsNullOrEmpty(numAgencia))
			{
				mensagem = "<div class='alert alert-warning'>Por favor, preencha todos os campos.</div>";
				return;
			}

			try
			{
				using (SqlConnection conn = new SqlConnection(_conexao))
				{
					string sql = "INSERT INTO Agencia(NumAgencia) values (@NumAgencia)";
					SqlCommand cmd = new SqlCommand(sql, conn);

					cmd.Parameters.AddWithValue("@NumAgencia", numAgencia);

					conn.Open();
					cmd.ExecuteNonQuery();

					mensagem = "<div class='alert alert-success'>Agência cadastrada com sucesso!</div>";
				}
			}
			catch (SqlException ex)
			{
				if (ex.Number == 2627 || ex.Number == 2601)
				{
					mensagem = "<div class='alert alert-danger'>Erro: Agência já cadastrada.</div>";
				}
				else
				{
					mensagem = $"<div class='alert alert-danger'>Erro: {ex.Message}</div>";
				}	

			}


		}
	}
}