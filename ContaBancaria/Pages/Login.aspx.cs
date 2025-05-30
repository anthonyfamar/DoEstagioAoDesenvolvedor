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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string senha = txtSenha.Text.Trim();
            string conexao = ConfigurationManager.ConnectionStrings["MinhaConexao"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(conexao))
            {
                string sql = @"SELECT c.Id, c.NumConta, u.Nome, c.Saldo, u.Cpf, c.AgenciaId
                               FROM ContaBancaria c
                               INNER JOIN Usuario u ON c.UsuarioId = u.Id
                               WHERE c.NumConta = @NumConta AND u.Senha = @Senha";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@NumConta", txtConta.Text.Trim());
                cmd.Parameters.AddWithValue("@Senha", senha);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        Session["IdConta"] = reader["Id"].ToString();
                        Session["NumConta"] = reader["NumConta"].ToString();
                        Session["Nome"] = reader["Nome"].ToString();
                        Session["Saldo"] = reader["Saldo"].ToString();
                        Session["Cpf"] = reader["Cpf"].ToString();
                        Session["AgenciaId"] = reader["AgenciaId"].ToString();

                        Response.Redirect("PaginaInicial.aspx");
                    }
                    else
                    {
                        lblMensagem.Text = "<div class='alert alert-danger'>Número da conta ou senha inválidos.</div>";
                        EsconderMensagem.RegistrarScriptOcultarMensagem(this, lblMensagem.ClientID);
                    }
                }
                catch (Exception ex)
                {
                    lblMensagem.Text = "<div class='alert alert-danger'>Erro no login: " + ex.Message + "</div>";
                    EsconderMensagem.RegistrarScriptOcultarMensagem(this, lblMensagem.ClientID);
                }
            }
        }
    }
}