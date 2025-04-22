using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculadoraWeb1
{
	public partial class About : Page
	{

		public List<string> Nomes
		{
			get
			{
				return (List<string>)ViewState["Nomes"];
			}
			set
			{
				ViewState["Nomes"] = value;
			}
		}

		public int QuantidadeDeCliques { get; set; }

		public int QuantidadeDeAlteracoes
		{
			get
			{
				return int.Parse(ViewState["QuantidadeDeAlteracoes"].ToString());
			}
			set
			{
				ViewState["QuantidadeDeAlteracoes"] = value.ToString();
			}
		}

		protected void Page_Load(object sender, EventArgs e)
		{


			if (!IsPostBack)
			{
				TextBox1.Text = "5";
				ImprimirSequenciaFibonacci(5);
				QuantidadeDeCliques = 0;
				QuantidadeDeAlteracoes = 0;
			}
			else
			{
				QuantidadeDeCliques = int.Parse(VisitasLabel.Text);
			}

			QuantidadeDeCliques += 1;
			VisitasLabel.Text = QuantidadeDeCliques.ToString();

			if (Nomes == null)
				Nomes = new List<string>();
		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			if (int.TryParse(TextBox1.Text, out int quantidade))
			{
				ImprimirSequenciaFibonacci(quantidade);
			}
			else
			{
				Label1.Text = "Favor informar um número válido!";
			}

		}

		private void ImprimirSequenciaFibonacci(int quantidade)
		{
			var calculadora = new Calculadora();
			var lista = calculadora.GerarNumerosFibonacci(quantidade);

			var html = new StringBuilder();
			html.Append("<ul>");
			for (int i = 0; i < lista.Count; i++)
			{
				html.Append("<li>");
				html.Append(lista[i]);
				html.Append("</li>");
			}
			html.Append("</ul>");

			Label1.Text = html.ToString();
		}

		protected void TextBox1_TextChanged(object sender, EventArgs e)
		{
			TextoModificado.Text = "Valor Alterado";
			QuantidadeDeAlteracoes += 1;
			AlteracoesLabel.Text = QuantidadeDeAlteracoes.ToString();
		}

		protected void Unnamed_Click(object sender, EventArgs e)
		{
			FibonacciPanel.Visible = true;
			CalculoDeJurosPanel.Visible = false;
			GerenciadorDeNomePanel.Visible = false;
		}

		protected void Unnamed_Click1(object sender, EventArgs e)
		{
			FibonacciPanel.Visible = false;
			CalculoDeJurosPanel.Visible = true;
			GerenciadorDeNomePanel.Visible = false;
		}

		protected void CalcularFinanciamentoButton_Click(object sender, EventArgs e)
		{
			if (decimal.TryParse(TextBoxValorFinanciamento.Text, out decimal valorFinanciamento))
			{
				if (decimal.TryParse(TextBoxPercentualTaxa.Text, out decimal taxa))
				{
					if (int.TryParse(TextBoxMesesQuitacao.Text, out int parcelas))
					{
						var calculadora = new Calculadora();
						var listaFinanciamento = calculadora.CalcularSimulacaoDeFinancimentos(valorFinanciamento, taxa, parcelas, dataBase: DateTime.Now.Date);

						StatusLabel.Text = "Financiamento calculado com sucesso!";

						MinhaTabela.DataSource = listaFinanciamento;
						MinhaTabela.DataBind();
					}
					else
					{
						StatusLabel.Text = "Insira uma quantidade de parcelas válidas!";
					}
				}
				else
				{
					StatusLabel.Text = "Insira uma taxa válida!";
				}
			}
			else
			{
				StatusLabel.Text = "Insira um valor de financiamento válido!";
			}
		}

		protected void Unnamed_Click2(object sender, EventArgs e)
		{

			FibonacciPanel.Visible = false;
			CalculoDeJurosPanel.Visible = false;
			GerenciadorDeNomePanel.Visible = true;

		}

		

		protected void AdicionarNome_Click(object sender, EventArgs e)
		{

			Nomes.Add(TextBoxInformeNome.Text);
			TextBoxInformeNome.Text = string.Empty;

			MinhaLista.DataSource = Nomes;
			MinhaLista.DataBind();
		}
	}
}