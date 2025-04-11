using System;
using System.Security.Cryptography.X509Certificates;
using ConsoleAppCSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleAppCSharpTests
{
	[TestClass]
	public class CalculadoraTest
	{
		[TestMethod]
		public void AoVerificarSeUmNumeroEhParDeveRetornarVerdadeiro()
		{
			//Causa/Cenário DEVE Efeito/Resultado

			var calculadora = new Calculadora();
			var par = calculadora.EhPar(2);
			if (par == false)
			{
				throw new Exception("O Número dois é par!");
			}
		}

		[TestMethod]
		public void AoVerificarSeUmNumeroEhImparDeveRetornarFalso()
		{
			var calculadora = new Calculadora();
			var impar = (calculadora.EhPar(3) == false);

			if (impar == false)
			{
				throw new Exception("O número tres é impar!");
			}
		}

		[TestMethod]
		public void AoCalcularJurosSimplesDeUmaParcelaDeveInformarValorCorreto()
		{
			var parcela = 562.3M;
			var taxa = 2.5M;

			var calculadora = new Calculadora();
			var totalDoJuros = calculadora.CalcularTotalJurosSimples(parcela, taxa);

			if (totalDoJuros != 14.06M)
			{
				throw new Exception("Favor calcular corretamente o valor do juros!");
			}

			//Arrange
			parcela = 255.18M;
			taxa = 1.78M;

			//Act
			totalDoJuros = calculadora.CalcularTotalJurosSimples(parcela, taxa);

			//Assert
			if (totalDoJuros != 4.54M)
			{
				throw new Exception("Favor calcular corretamento o valor do juros!");
			}
		}

		[TestMethod]
		public void AoCalcularOMaximoDivisorComumDeVariosNumerosDeveEncontrarOResultadoCorreto()
		{
			var numeros = new int[] { 21, 54, 69, 15, 27, 18 };
			var calculadora = new Calculadora();

			var mdc = calculadora.CalcularMaximoDivisorComum(numeros);

			if (mdc != 3)
			{
				throw new Exception("O MDC dos números [21, 54, 69, 15, 27, 18] deve ser 3, " +
				"porém, foi encontrada" + mdc.ToString());
			}

			numeros = new int[] { 15, 15, 15, 30, 45, 60 };
			mdc = calculadora.CalcularMaximoDivisorComum(numeros);

			if (mdc != 15)
			{
				throw new Exception("O MDC dos numeros [15, 15, 15, 30, 45, 60] " +
				" deve ser 15, porém, foi encontrado" + mdc.ToString());
			}
		}

		[TestMethod]
		public void AoCalcularJurosCompostosDeUmaParcelaDeveRetornarValorCorreto()
		{
			var calculadora = new Calculadora();
			var parcela = 562.3M;
			var taxa = 1.5M;
			var meses = 3;

			var montante = calculadora.CalcularValorMontanteComJurosCompostos(parcela, taxa, meses);

			if (montante != 587.98M)
			{
				throw new Exception("O Valor da parcela não foi calculado corretamente: " + montante.ToString());
			}
		}

		[TestMethod]
		public void SeRealizarUmaSimulacaoDeParcelamentoDeveEncontrarOsValoresCorretos()
		{
			//Arrange
			var calculadora = new Calculadora();
			var valorFinancimento = 562.3M;
			var taxa = 1.5M;
			var parcelas = 3;

			//Act
			var simulacao = calculadora.CalcularSimulacaoDeFinanciamentos(valorFinancimento, taxa, parcelas);

			//Assert

			if (simulacao.Count != 3)
				throw new Exception("Não foi calculado a quantidade correta de parcelas!");

			var valoresEsperados = new decimal[] { 570.73M, 579.3M, 587.98M };

			for (int parcela = 1; parcela <= 3; parcela++)
			{
				if (simulacao[parcela - 1].Quantidade != parcela)
					throw new Exception("A quantidade de parcelas da parcela [" + parcela.ToString() + "] esta errada!");

				if (simulacao[parcela - 1].ValorTotal != valoresEsperados[parcela - 1])
					throw new Exception("O valor da parcela [" + parcela.ToString() + "] está errado!" +
					$"Esperavamos {valoresEsperados[parcela - 1]}, porém está calculando {simulacao[parcela - 1].ValorTotal}");
			}
		}
	}
}
