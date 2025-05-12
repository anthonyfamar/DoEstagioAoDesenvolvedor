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

			CadastroUsuarioDao daoUsuario = new CadastroUsuarioDao();
			CadastroAgenciaDao daoAgencia = new CadastroAgenciaDao();
			CadastroContaDao daoConta = new CadastroContaDao();
			string mensagem;

			int idUsuario = daoUsuario.InserirUsuario(txtNomeCompleto.Text, txtCpf.Text, txtTelefone.Text, txtSenha.Text, out mensagem);
			if (idUsuario == 0)
			{
				lblMensagem.Text = mensagem;
				return;
			}

			int idAgencia = daoAgencia.InserirAgencia(ListaAgencia.Text, out mensagem);
			if (idAgencia == 0)
			{
				lblMensagem.Text = mensagem;
				return;
			}

			daoConta.InserirConta(txtNumeroConta.Text, idUsuario, idAgencia, out mensagem);
			lblMensagem.Text = mensagem;

		}
	}
}