using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCSharp
{
	public class SimulacaoParcela
	{

		
		public int Quantidade { get; }

		public decimal ValorTotal 
		{ get { return ValorParcela * Quantidade; } }


		public decimal ValorJuros { get; }

		public decimal ValorParcela {  get; }

		public DateTime Vencimento { get; }

		public SimulacaoParcela(int quantidade, decimal valorJuros, decimal valorParcela, DateTime vencimento)
		{
			Quantidade = quantidade;
			ValorJuros = valorJuros;
			ValorParcela = valorParcela;
			Vencimento = vencimento;
		}
	}
}
