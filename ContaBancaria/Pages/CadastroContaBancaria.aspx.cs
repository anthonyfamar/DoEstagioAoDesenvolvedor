using ContaBancaria.DAOs;
using ContaBancaria.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ContaBancaria.Pages
{
	public partial class CadastroUsuario : System.Web.UI.Page
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
				string numeroConta = GerarNumeroContaUnico();
				txtNumeroConta.Text = numeroConta;
			}

            if (!IsPostBack)
            {
                PopularAgencias();
            }
        }

        private void PopularAgencias()
        {
            string conexao = ConfigurationManager.ConnectionStrings["MinhaConexao"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(conexao))
            {
                string sql = "SELECT Id, NumAgencia FROM Agencia";
                SqlCommand cmd = new SqlCommand(sql, conn);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    ListaAgencia.Items.Clear();

                    ListaAgencia.Items.Add(new ListItem("Selecione uma opção", "0"));

                    while (reader.Read())
                    {
                        string numAgencia = reader["NumAgencia"].ToString();
                        string idAgencia = reader["Id"].ToString();

                        ListaAgencia.Items.Add(new ListItem(numAgencia, idAgencia));
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao carregar agências: " + ex.Message);
                }
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

            int idAgencia = Convert.ToInt32(ListaAgencia.SelectedValue);
            if (idAgencia == 0)
            {
                lblMensagem.Text = "<div class='alert alert-warning'>Por favor, selecione uma agência válida.</div>";
                EsconderMensagem.RegistrarScriptOcultarMensagem(this, lblMensagem.ClientID);
                return;
            }

            int idUsuario = daoUsuario.InserirUsuario(txtNomeCompleto.Text, txtCpf.Text, txtTelefone.Text, txtSenha.Text, out mensagem);
            if (idUsuario == 0)
            {
                lblMensagem.Text = mensagem;
                EsconderMensagem.RegistrarScriptOcultarMensagem(this, lblMensagem.ClientID);
                return;
            }

            daoConta.InserirConta(txtNumeroConta.Text, idUsuario, idAgencia, out mensagem);
            lblMensagem.Text = mensagem;

            if (mensagem.Contains("sucesso"))
            {
                LimparCampos();
            }

            EsconderMensagem.RegistrarScriptOcultarMensagem(this, lblMensagem.ClientID);
        }

        private void LimparCampos()
        {
            txtNomeCompleto.Text = "";
            txtCpf.Text = "";
            txtTelefone.Text = "";
            txtSenha.Text = "";
            txtNumeroConta.Text = GerarNumeroContaUnico();
            ListaAgencia.SelectedIndex = 0;
        }
    }
}