using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaDeGestaoDeEstudantes.Entities;

namespace SistemaDeGestaoDeEstudantes.Services
{
	internal class DisciplinaService
	{
		public List<Disciplina> Disciplinas { get; set; } = new List<Disciplina>();

		public void CadastrarDisciplina(string nome, int cargaHoraria)
		{
			Disciplinas.Add(new Disciplina() { Nome = nome, CargaHoraria = cargaHoraria });
		}

		public void VisualizarDisciplina()
		{
			Console.WriteLine("Lista de disciplinas: ");

			foreach (var disciplina in Disciplinas)
			{
				Console.WriteLine($"{disciplina.Nome} - {disciplina.CargaHoraria} hrs");
			}
		}

		public DisciplinaService()
		{
			DefinirDisciplinasPadrao();
		}

		public void DefinirDisciplinasPadrao()
		{
			Disciplinas.Add(new Disciplina() { Nome = "Matemática", CargaHoraria = 80 });
			Disciplinas.Add(new Disciplina() { Nome = "Português", CargaHoraria = 60 });
			Disciplinas.Add(new Disciplina() { Nome = "História", CargaHoraria = 0 });
			Disciplinas.Add(new Disciplina() { Nome = "sla", CargaHoraria = 0 });

		}



	}
}
