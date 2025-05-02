using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ContaBancaria.Pages
{
	public partial class Deposito : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void btnConfirmaDeposito_Click(object sender, EventArgs e)
		{
			decimal valorDeposito = decimal.Parse(txtValor.Text);
			decimal saldoAtual = (decimal)(Session["Saldo"] ?? 0M);

			saldoAtual += valorDeposito;

			Session["Saldo"] = saldoAtual;
			Response.Redirect("PaginaInicial.aspx");
		}
	}
}