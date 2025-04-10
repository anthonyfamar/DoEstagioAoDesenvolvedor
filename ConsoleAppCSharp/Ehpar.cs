using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCSharp
{
	internal class Ehpar
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hellow ...");
			Console.WriteLine("Informe um número, por favor...");
			Console.Write("Vamos ver se é par: ");

			var texto = Console.ReadLine();			

			if (int.TryParse(texto, out int numero))
			{
				var calculadora = new Calculadora();
				var par = calculadora.EhPar(numero);

				if (par)
				{
					Console.WriteLine("Muito bonito, vc digitou um numero par");
				}
				else
				{
					Console.WriteLine("Maravilha, este é um número impar");
				}
			}
			else
			{
				Console.WriteLine("Amigo! Por favor! Informe um numero!");
			}
		}
	}
}
