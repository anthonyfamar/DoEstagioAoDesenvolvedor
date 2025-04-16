using System;
using System.Collections.Generic;
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
	}
}