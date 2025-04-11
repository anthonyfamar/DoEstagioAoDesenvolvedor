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

		public SimulacaoParcela(int quantidade, decimal valorTotal)
		{
			Quantidade = quantidade;
			ValorTotal = valorTotal;
		}
	}
}
