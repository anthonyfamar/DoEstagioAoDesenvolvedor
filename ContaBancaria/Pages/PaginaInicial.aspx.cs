using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ContaBancaria
{
	public partial class _Default : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			

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
	}
}