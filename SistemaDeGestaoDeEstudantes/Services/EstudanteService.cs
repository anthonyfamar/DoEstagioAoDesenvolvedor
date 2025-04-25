using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SistemaDeGestaoDeEstudantes.Entities;

namespace SistemaDeGestaoDeEstudantes.Services
{
	internal class EstudanteService
	{
		public List<Estudante> Estudantes { get; set; } = new List<Estudante>();

		public void CadastrarAluno(string nome, int matricula)
		{
			Estudantes.Add(new Estudante() { Nome = nome, Matricula = matricula });
		}

		public void VisualizarAluno()
		{
			Console.WriteLine("Lista de alunos: ");

			foreach (var estudante in Estudantes)
			{
				Console.WriteLine($"{estudante.Matricula} - {estudante.Nome}");
				Thread.Sleep(500);
			}

		}

		public bool RemoverAluno(int matricula)
		{
			var estudante = Estudantes.FirstOrDefault(e => e.Matricula == matricula);

			if (estudante == null)
				return false;

			Estudantes.Remove(estudante);
			return true;
		}


	}
}
