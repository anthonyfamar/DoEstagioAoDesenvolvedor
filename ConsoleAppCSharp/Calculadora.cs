using System;
using System.Collections.Generic;
using System.Data.SqlTypes;

namespace ConsoleAppCSharp
{
	public class Calculadora
	{

		public bool EhPar(int numero)
		{
			if (numero % 2 == 0)
				return true;
			return false;
		}

		public decimal CalcularTotalJurosSimples(decimal valorDaParcela, decimal percentual)
		{
			return Math.Round((valorDaParcela * percentual) / 100.0M, decimals: 2);
		}

		public int CalcularMaximoDivisorComum(int[] numeros)
		{
			var maior = ConsultarMaiorNumero(numeros);
			var mdc = 0;

			for (int n = 1; n <= maior; n++)
			{
				var divisores = 0;
				for (int i = 0; i < numeros.Length; i++)
				{
					if (numeros[i] % n == 0)
						divisores++;
				}
				if (divisores == numeros.Length)
					mdc = n;
			}

			return mdc;
		}

		private int ConsultarMaiorNumero(int[] numeros)
		{
			var maior = numeros[0];

			for (int n = 1; n < numeros.Length; n++)
			{
				if (numeros[n] > maior)
					maior = numeros[n];
			}
			return maior;
		}

		public decimal CalcularValorMontanteComJurosCompostos(decimal parcela, decimal taxa, int meses)
		{

			var resultado = parcela * (decimal)Math.Pow((double)(1M + taxa / 100M), meses);

			return Math.Round(resultado, decimals: 2);
		}

		public List<SimulacaoParcela> CalcularSimulacaoDeFinanciamentos(decimal valorFinancimento, decimal taxa, int parcelas, DateTime dataBase)
		{
			var lista = new List<SimulacaoParcela>();
			var vencimento = dataBase;

			for (int parcela = 0; parcela < parcelas; parcela++)
			{
				var meses = parcela + 1;
				var valorTotal = CalcularValorMontanteComJurosCompostos(valorFinancimento, taxa, meses);
				var valorParcela = Math.Round((valorTotal / meses), decimals: 2);
				var totalJuros = Math.Round((valorParcela * meses) - valorFinancimento, decimals: 2);

				vencimento = vencimento.AddDays(30);

				var financimento = new SimulacaoParcela(meses, totalJuros, valorParcela, vencimento);
				lista.Add(financimento);
			}

			return lista;
		}

		public List<SimulacaoParcela> CalcularSimulacaoDeFinanciamentos(decimal valorFinancimento, decimal taxa, int parcelas)
		{
			return CalcularSimulacaoDeFinanciamentos(valorFinancimento, taxa, parcelas, dataBase: DateTime.Now.Date);
		}
	}
}
