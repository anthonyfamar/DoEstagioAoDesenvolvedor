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
            if (Session["IdConta"] == null)
            {
                Response.Redirect("Login.aspx");
                return;
            }

            if (!IsPostBack)
            {
                if (Session["IdConta"] != null)
                {
                    ListaAgencia.SelectedValue = Session["AgenciaId"].ToString(); 
                    txtContaDeposito.Text = Session["NumConta"].ToString();
                    txtCPF.Text = Session["Cpf"].ToString();
                }
                else
                {

                    Response.Redirect("Login.aspx");
                    return;
                }
            }
        }

		protected void btnConfirmaSaque_Click(object sender, EventArgs e)
		{
            decimal valor;

            if (!decimal.TryParse(txtValor.Text, out valor) || valor <= 0)
            {
                lblMensagem.Text = "<div class='alert alert-warning'>Informe um valor válido para saque.</div>";
                return;
            }
		}

		protected void btnVoltar_Click(object sender, EventArgs e)
		{

		}
	}
}