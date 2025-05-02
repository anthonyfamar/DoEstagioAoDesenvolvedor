using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ContaBancaria.Pages
{
	public partial class PaginaInicial : Page
	{

		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				if (Session["Saldo"] == null)
				{
					Session["Saldo"] = 0M;
				}
				AtualizarSaldoNaTela();
			}

			if (!IsPostBack)
			{
				ViewState["ContaReal"] = NumeroDaConta.Text;
				ViewState["ContaVisivel"] = false;
				NumeroDaConta.Text = "-----";
			}

			if (!IsPostBack)
			{
				ViewState["SaldoVisivel"] = false;
				SaldoAtual.Text = "-----";
			}
		}

		private void AtualizarSaldoNaTela()
		{
			decimal saldo = (decimal)Session["Saldo"];
			SaldoAtual.Text = saldo.ToString("F2");
		}

		protected void BtnDepositar_Click(object sender, EventArgs e)
		{
			Response.Redirect("~/Pages/Deposito.aspx");
		}

		protected void BtnSaque_Click(object sender, EventArgs e)
		{
			Response.Redirect("~/Pages/Saque.aspx");
		}

		protected void BtnTransferir_Click(object sender, EventArgs e)
		{
			Response.Redirect("~/Pages/Transferir.aspx");
		}

		protected void BtnPaginaInicial_Click(object sender, EventArgs e)
		{

		}

		protected void BtnMostrarConta_Click(object sender, EventArgs e)
		{
			bool visivel = (bool)(ViewState["ContaVisivel"]);

			if (visivel)
			{
				NumeroDaConta.Text = "-----";
				BtnMostrarConta.Text = "Mostrar Nº Conta";
				ViewState["ContaVisivel"] = false;
			}
			else
			{
				NumeroDaConta.Text = ViewState["ContaReal"].ToString();
				ViewState["ContaVisivel"] = true;
				BtnMostrarConta.Text = "Esconder Nº Conta";
			}
		}

		protected void BtnMostrarSaldo_Click(object sender, EventArgs e)
		{
			bool visivel = (bool)(ViewState["SaldoVisivel"]);
			decimal saldo = (decimal)Session["Saldo"];

			if (visivel)
			{
				SaldoAtual.Text = "-----";
				BtnMostrarSaldo.Text = "Mostrar Saldo";
				ViewState["SaldoVisivel"] = false;
			}
			else
			{
				SaldoAtual.Text = saldo.ToString("F2");
				ViewState["SaldoVisivel"] = true;
				BtnMostrarSaldo.Text = "Esconder Saldo";
			}

		}
	}
}