using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppCSharp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Olá, seja bem vindo!");
			Console.Write("Informe o valor do financimento: ");
			decimal valorFinancimento = decimal.Parse(Console.ReadLine());
			Console.Write("Informe o porcentual da taxa:  ");
			decimal taxa = decimal.Parse(Console.ReadLine());
			Console.Write("Informe em quantos meses deseja quitar: ");
			int parcelas = int.Parse(Console.ReadLine());

			Console.WriteLine("\nInstante, calcule...\n");
			Console.WriteLine($"            Total Financiado: R$ {valorFinancimento.ToString("F2", CultureInfo.InvariantCulture)}");
			Console.WriteLine($"            Taxa Utilizada: {taxa}%");
			Console.WriteLine($"            Meses: {parcelas}");


			var calculadora = new Calculadora();

			var listaFinanciamento = calculadora.CalcularSimulacaoDeFinanciamentos(valorFinancimento, taxa, parcelas);

			Console.WriteLine("\nFinanciamento...\n");

			foreach (var parcela in listaFinanciamento)
			{
				Console.WriteLine($"{parcela.Quantidade} x {parcela.ValorParcela} ===> R$ {parcela.ValorTotal} [Valor do juros: R$ {parcela.ValorJuros}.]");
				Thread.Sleep(500);
			}
						

			//for (int i = 1; i <= parcelas; i++)
			//{
			//	Console.WriteLine($"{i} x {listaFinanciamento[i-1].ValorParcela:N2} ===> R$ {listaFinanciamento[i-1].ValorTotal:N2} " +
			//	$"[Valor do Juros: R$ {listaFinanciamento[i-1].ValorJuros:N2}]");
			//	Thread.Sleep(1 * 500);
			//}
		}
	}
}
