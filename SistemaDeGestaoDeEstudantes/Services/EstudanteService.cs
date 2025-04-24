using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

		public List<Estudante> VisualizarAluno()
		{
			return Estudantes;
		}

		public bool RemoverAluno(string nome, int matricula)
		{
			var estudante = Estudantes.FirstOrDefault(e => e.Matricula == matricula);

			if (estudante == null)
				return false;

			Estudantes.Remove(estudante);
			return true;
		}


	}
}
