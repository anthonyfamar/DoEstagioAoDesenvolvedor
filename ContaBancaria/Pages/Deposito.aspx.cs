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
            if (Session["IdConta"] == null)
            {
                Response.Redirect("Login.aspx");
                return;
            }
        }

		protected void btnConfirmaDeposito_Click(object sender, EventArgs e)
		{

			string numConta = txtContaDeposito.Text.Trim();
            string cpf = txtCPF.Text.Trim();
            int adenciaId = int.Parse(ListaAgencia.SelectedValue);
            decimal valor;

            if (!decimal.TryParse(txtValor.Text, out valor) || valor <= 0)
            {
                lblMensagem.Text = "<div class='alert alert-warning'>Informe um valor válido para depósito.</div>";
                return;
            }
		}
    }
}