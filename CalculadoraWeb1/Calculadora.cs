using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculadoraWeb1
{
	public class Calculadora
	{
		public List<int> GerarNumerosFibonacci(int numero)
		{
			var listaFibonacci = new List<int>();
			listaFibonacci.Add(1);
			listaFibonacci.Add(1);

			for (int i = 2; i < numero; i++) 
			{

				var novoValor = listaFibonacci[i - 1] + listaFibonacci[i - 2];
				listaFibonacci.Add(novoValor);
				
			}
			return listaFibonacci;
		}
		public void TestarTeoriaDeInstanciacao(int numero, string nome, bool eh) 
		{
			
		}
	}
}