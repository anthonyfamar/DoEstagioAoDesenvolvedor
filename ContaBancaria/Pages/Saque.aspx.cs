using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

            string numConta = Session["NumConta"].ToString();
            string cpf = Session["Cpf"].ToString();
            int agenciaId = Convert.ToInt32(Session["AgenciaId"]);
            int contaId = Convert.ToInt32(Session["IdConta"]);

            string conexao = System.Configuration.ConfigurationManager.ConnectionStrings["MinhaConexao"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(conexao))
            {
                string selectSql = @"SELECT c.Saldo
                                     FROM ContaBancaria c
                                     INNER JOIN Usuario u ON c.UsuarioId = u.Id 
                                     WHERE c.Id = @IdConta AND c.NumConta = @NumConta AND u.Cpf = @Cpf AND c.AgenciaId = @AgenciaId";

                SqlCommand cmd = new SqlCommand(selectSql, conn);
                cmd.Parameters.AddWithValue("@IdConta", contaId);
                cmd.Parameters.AddWithValue("@NumConta", numConta);
                cmd.Parameters.AddWithValue("@Cpf", cpf);
                cmd.Parameters.AddWithValue("@AgenciaId", agenciaId);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    decimal saldoAtual = Convert.ToDecimal(reader["Saldo"]);
                    reader.Close();

                    if (valor > saldoAtual)
                    {
                        lblMensagem.Text = "<div class='alert alert-warning'>Saldo insuficiente para realizar o saque.</div>";
                        return;
                    }

                    decimal novoSaldo = saldoAtual - valor;

                    string updateSql = "UPDATE ContaBancaria SET Saldo = @NovoSaldo WHERE Id = @IdConta";
                    SqlCommand updateCmd = new SqlCommand(updateSql, conn);
                    updateCmd.Parameters.AddWithValue("@NovoSaldo", novoSaldo);
                    updateCmd.Parameters.AddWithValue("@IdConta", contaId);
                    updateCmd.ExecuteNonQuery();

                    Session["Saldo"] = novoSaldo;

                    Response.Redirect("PaginaInicial.aspx");
                }
                else
                {
                    lblMensagem.Text = "<div class='alert alert-danger'>Erro ao localicar a conta. Verifique os dados informados.</div>";
                }
            }
        }
    }
}