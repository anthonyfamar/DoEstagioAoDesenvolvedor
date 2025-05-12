using System;
using System.Collections.Generic;
using System.Configuration;
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

		public void InserirConta()
		{
			
		}

	}
}