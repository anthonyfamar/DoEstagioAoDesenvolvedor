using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SistemaDeGestaoDeEstudantes.Services;

namespace SistemaDeGestaoDeEstudantes
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var estudanteService = new EstudanteService();

			do
			{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("=".PadLeft(40, '='));
				Console.WriteLine("Sistema de Gestão de Estudantes");
				Console.WriteLine("=".PadRight(40, '='));
				Console.ResetColor();
				Console.WriteLine("1 - Estudante");
				Console.WriteLine("2 - Disciplina");
				Console.WriteLine("3 - Turma");
				Console.WriteLine("4 - Sair");
				Console.Write("Selecione uma opção do menu: ");
				var opcao = Console.ReadLine();
				Console.WriteLine("=".PadRight(40, '='));

				switch (opcao)
				{
					case "1":
						AreaDoEstudante(estudanteService);
						break;

					case "2":
						AreaDaDisciplina();
						break;
					case "3":
						AreaDaTurma();
						break;
					default:
						Console.WriteLine("Programa finalizado.");
						return;
				}
			}
			while (true);
		}

		public static void AreaDoEstudante(EstudanteService estudanteService)
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("Você entrou na área de estudante: ");
			Console.ResetColor();
			Console.WriteLine("1 - Cadastrar estudante");
			Console.WriteLine("2 - Visualizar lista de estudantes");
			Console.WriteLine("3 - Excluir estudante");
			Console.WriteLine("4 - Voltar ao menu anterior");
			Console.Write("Escolha a opção desejada: ");
			var opcaoMenuEstudante = Console.ReadLine();

			switch (opcaoMenuEstudante)
			{
				case "1":
					Console.WriteLine("Digite o nome do estudante: ");
					var nomeEstudante = Console.ReadLine();
					Console.WriteLine("Digite a matricula do estudante: ");
					var matriculaEstudante = int.Parse(Console.ReadLine());

					estudanteService.CadastrarAluno(nomeEstudante, matriculaEstudante);

					Console.WriteLine($"Nome: {nomeEstudante}");
					Console.WriteLine($"Matricula: {matriculaEstudante}");
					Thread.Sleep(300);
					Console.WriteLine("Estudante cadastrado com sucesso!");
					Thread.Sleep(500);
					break;

				case "2":
					estudanteService.VisualizarAluno();
					break;

				case "3":
					Console.WriteLine("Digite a matricula do estudante que seja excluir:");
					matriculaEstudante = int.Parse(Console.ReadLine());

					estudanteService.RemoverAluno(matriculaEstudante);
					Console.WriteLine("Aluno removido com sucesso!");
					break;
			}


		}

		private static void AreaDaDisciplina()
		{
			throw new NotImplementedException();
		}

		private static void AreaDaTurma()
		{
			throw new NotImplementedException();
		}
	}
}
