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

		public decimal ValorTotal { get; }

		public decimal ValorJuros { get; }

		public decimal ValorParcela {  get; }

		public SimulacaoParcela(int quantidade, decimal valorTotal, decimal valorJuros, decimal valorParcela)
		{
			Quantidade = quantidade;
			ValorTotal = valorTotal;
			ValorJuros = valorJuros;
			ValorParcela = valorParcela;
		}
	}
}
