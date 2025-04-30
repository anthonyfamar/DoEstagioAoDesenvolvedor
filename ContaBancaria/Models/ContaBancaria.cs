using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContaBancaria.Models
{
	public class ContaBancaria
	{
		public int NumConta { get; set; }

		public int Agencia { get; set; }

		public string TitularDaConta { get; set; }

		public decimal Valor {  get; set; }

		public decimal SaldoAtual {get; set; }

	}
}