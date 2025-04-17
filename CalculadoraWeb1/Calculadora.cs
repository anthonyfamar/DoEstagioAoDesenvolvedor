using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CalculadoraWeb1
{
	public class Calculadora
	{
		public List<double> GerarNumerosFibonacci(double numero)
		{
			var listaFibonacci = new List<double>();
			listaFibonacci.Add(1);
			listaFibonacci.Add(1);

			for (int i = 2; i < numero; i++)
			{

				var novoValor = listaFibonacci[i - 1] + listaFibonacci[i - 2];
				listaFibonacci.Add(novoValor);

			}
			return listaFibonacci;
		}

		public decimal CalcularValorMontanteComjurosCompostos(decimal parcela, decimal taxa, int meses)
		{
			var resultado = parcela * (decimal)Math.Pow((double)(1M + taxa / 100M), meses);

			return Math.Round(resultado, decimals: 2);
		}

		public List<SimulacaoParcela> CalcularSimulacaoDeFinancimentos(decimal valorFinanciamento, decimal taxa, int parcelas, DateTime dataBase)
		{
			var lista = new List<SimulacaoParcela>();
			var vencimento = dataBase;

			for (int i = 0; i < parcelas; i++)
			{
				var meses = i + 1;
				var valorTotal = CalcularValorMontanteComjurosCompostos(valorFinanciamento, taxa, meses);
				var valorParcela = Math.Round((valorTotal / meses), decimals: 2);
				var totalJuros = Math.Round((valorParcela * meses) - valorFinanciamento, decimals: 2);

				vencimento = vencimento.AddDays(30);

				var financiamento = new SimulacaoParcela(meses, totalJuros, valorParcela, vencimento);
				lista.Add(financiamento);
			}
			return lista;
		}

		public List<SimulacaoParcela> CalcularSimulacaoDeFinancimentos(decimal valorFinanciamento, decimal taxa, int parcelas)
		{
			return CalcularSimulacaoDeFinancimentos(valorFinanciamento, taxa, parcelas, dataBase: DateTime.Now.Date);
		}
	}
}