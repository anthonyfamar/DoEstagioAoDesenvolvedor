using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ContaBancaria.Pages
{
	public partial class Saque : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void btnConfirmaSaque_Click(object sender, EventArgs e)
		{
			decimal valorSaque = decimal.Parse(txtValor.Text);
			decimal saldoAtual = (decimal)(Session["Saldo"] ?? 0M);

			if (valorSaque <= saldoAtual)
			{
				saldoAtual -= valorSaque;
				Session["Saldo"] = saldoAtual;
				Response.Redirect("PaginaInicial.aspx");
			}
			else
			{
				lblErro.Text = "Saldo Insuficiente!";
				lblErro.CssClass = "text-danger";
			}
		}
	}
}