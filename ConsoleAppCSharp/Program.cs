using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCSharp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Olá, seja bem vindo!");

			Console.WriteLine("Informe o valor da parcela: ");
			var parcela = decimal.Parse(Console.ReadLine());

			Console.WriteLine("Informe o valor do juros:  ");
			var taxa = decimal.Parse(Console.ReadLine());

			Console.WriteLine("Informe a quantidade de meses: ");
			var meses = int.Parse(Console.ReadLine());

			var calculadora = new Calculadora();
			var calcularJurosComposto = calculadora.CalcularValorMontanteComJurosCompostos(parcela, taxa, meses);
			Console.WriteLine("O Valor total com juros ficou: R$ "+ calcularJurosComposto.ToString());
		}
	}
}
