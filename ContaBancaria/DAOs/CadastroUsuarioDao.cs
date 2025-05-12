using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Sql;
using System.Configuration;
using System.Data.SqlClient;
namespace ContaBancaria.DAOs
{
	public class CadastroUsuarioDao //Classe que conversa com o banco de dados
	{
		private readonly string _conexao;

		public CadastroUsuarioDao()
		{
			_conexao = ConfigurationManager.ConnectionStrings["MinhaConexao"].ConnectionString;
		}

		public int InserirUsuario(string nome, string cpf, string telefone, string senha, out string mensagem)
		{
			mensagem = "";

			if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(cpf) || string.IsNullOrEmpty(telefone) || string.IsNullOrEmpty(senha))
			{
				mensagem = "<div class='alert alert-warning'>Por favor, preencha todos os campos.</div>";
				return 0;
			}

			try
			{
				using (SqlConnection conn = new SqlConnection(_conexao))
				{
					string sql = @"INSERT INTO Usuario(Nome, Cpf, Telefone, Senha) VALUES (@Nome, @Cpf, @Telefone, @Senha) SELECT SCOPE_IDENTITY();";
					SqlCommand cmd = new SqlCommand(sql, conn);

					cmd.Parameters.AddWithValue("@Nome", nome);
					cmd.Parameters.AddWithValue("@Cpf", cpf);
					cmd.Parameters.AddWithValue("@Telefone", telefone);
					cmd.Parameters.AddWithValue("@Senha", senha);

					conn.Open();
					object resultado = cmd.ExecuteScalar();
					if (resultado != null && int.TryParse(resultado.ToString(), out int idUsuario))
					{
						mensagem = "<div class='alert alert-success'>Usuário cadastrado com sucesso!</div>";
						return idUsuario;
					}
					else
					{
						mensagem = "<div class='alert alert-danger'>Erro ao cadastrar o usuário. ID não retornado.</div>";
						return 0;
					}
				}
			}
			catch (SqlException ex)
			{
				if (ex.Number == 2627 || ex.Number == 2601)
				{
					mensagem = "<div class='alert alert-danger'>Erro: CPF já cadastrado.</div>";
				}
				else
				{
					mensagem = $"<div class='alert alert-danger'>Erro: {ex.Message}</div>";
				}
				return 0;
			}
		}
	}
}