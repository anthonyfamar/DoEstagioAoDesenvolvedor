using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Sql;
using System.Configuration;
namespace ContaBancaria.DAOs
{
	public class CadastroUsuarioDao //Classe que conversa com o banco de dados
	{
		private readonly string _conexao;

		public CadastroUsuarioDao(string conexao)
		{
			_conexao = conexao;
		}

		public void CadastrarUsuario()
		{
			
		}
	}
}