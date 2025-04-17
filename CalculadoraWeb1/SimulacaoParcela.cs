using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculadoraWeb1
{
	public class SimulacaoParcela : System.Web.UI.Page
	{
		public int Quantidade { get; }

		public decimal ValorParcela { get; }

		public decimal ValorTotal
		{ get { return ValorParcela * Quantidade; } }

		public decimal ValorJuros { get; }

		public DateTime Vencimento { get; }

		public SimulacaoParcela(int quantidade, decimal valorJuros, decimal valorParcela, DateTime vencimento)
		{
			Quantidade = quantidade;
			ValorParcela = valorParcela;
			ValorJuros = valorJuros;
			Vencimento = vencimento;
		}
	}
}