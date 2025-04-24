using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaDeGestaoDeEstudantes.Services;

namespace SistemaDeGestaoDeEstudantes
{
	internal class Program
	{
		static void Main(string[] args)
		{

			do
			{
				Console.WriteLine("=".PadLeft(40, '='));
				Console.WriteLine("Sistema de Gestão de Estudantes");
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
						Console.WriteLine("Você entrou na área de estudante: ");
						Console.WriteLine("1 - Cadastrar estudante");
						Console.WriteLine("2 - Visualizar lista de estudantes");
						Console.WriteLine("3 - Excluir estudante");
						Console.WriteLine("4 - Voltar ao menu anterior");
						Console.WriteLine("Escolha a opção desejada: ");
						var opcaoMenuEstudante = Console.ReadLine();

						var estudanteService = new EstudanteService();
	
						if (opcaoMenuEstudante == "1")
							Console.WriteLine("Digite o nome do estudante: ");
							var nomeEstudante = Console.ReadLine();
							Console.WriteLine("Digite a matricula do estudante: ");
							var matriculaEstudante = int.Parse(Console.ReadLine());
								
							estudanteService.CadastrarAluno(nomeEstudante, matriculaEstudante);

						break;

				}
			}
			while (true);
		}
	}
}
