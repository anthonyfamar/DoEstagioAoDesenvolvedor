using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGestaoDeEstudantes
{
	internal class Program
	{
		static void Main(string[] args)
		{

			do
			{
				Console.WriteLine("=".PadLeft(40, '='));
				Console.WriteLine("Sistema de Gestão de Esudantes");
				Console.WriteLine("=".PadRight(40, '='));
				Console.WriteLine("1 - Estudante");
				Console.WriteLine("2 - Disciplina");
				Console.WriteLine("3 - Turma");
				Console.WriteLine("4 - Sair");
				Console.WriteLine("Selecione uma opção do menu: ");
				var opcao = Console.ReadLine();

				switch (opcao)
				{
					case "1":
						Console.WriteLine("Você entrou na área de gerenciamento de estudantes, escolha a opção desejada: ");
						break;
				}
			}
			while (true);
		}
	}
}
