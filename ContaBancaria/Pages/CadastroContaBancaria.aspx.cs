using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ContaBancaria.DAOs;

namespace ContaBancaria.Pages
{
	public partial class CadastroUsuario : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				string numeroConta = GerarNumeroContaUnico();
				txtNumeroConta.Text = numeroConta;
			}
		}

		private string GerarNumeroContaUnico()
		{
			var rand = new Random();
			return rand.Next(100000, 999999).ToString();
		}

		protected void BtnCadastrar_Click(object sender, EventArgs e)
		{
			CadastroUsuarioDao dao = new CadastroUsuarioDao();
			string mensagem;

			dao.InserirUsuario(txtNomeCompleto.Text, txtCpf.Text, txtTelefone.Text, txtSenha.Text, out mensagem);
			lblMensagem.Text = mensagem;

		}
	}
}