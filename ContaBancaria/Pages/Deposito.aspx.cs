using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            int agenciaId = int.Parse(ListaAgencia.SelectedValue);
            decimal valor;

            if (!decimal.TryParse(txtValor.Text, out valor) || valor <= 0)
            {
                lblMensagem.Text = "<div class='alert alert-warning'>Informe um valor válido para depósito.</div>";
                return;
            }

            string conexao = System.Configuration.ConfigurationManager.ConnectionStrings["MinhaConexao"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(conexao))
            {
                string selectSql = @"SELECT c.Id, c.Saldo
                                     FROM ContaBancaria c 
                                     INNER JOIN Usuario u ON c.UsuarioId = u.Id
                                     WHERE c.NumConta = @NumConta AND u.Cpf = @Cpf AND c.AgenciaId = @AgenciaId";

                SqlCommand cmd = new SqlCommand(selectSql, conn);
                cmd.Parameters.AddWithValue("@NumConta", numConta);
                cmd.Parameters.AddWithValue("@Cpf", cpf);
                cmd.Parameters.AddWithValue("@AgenciaId", agenciaId);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int ContaId = Convert.ToInt32(reader["Id"]);
                    decimal saldoAtual = Convert.ToDecimal(reader["Saldo"]);
                    reader.Close();

                    decimal novoSaldo = saldoAtual + valor;

                    string updateSql = @"UPDATE ContaBancaria SET Saldo = @NovoSaldo WHERE Id = @Id";
                    SqlCommand updateCmd = new SqlCommand(updateSql, conn);
                    updateCmd.Parameters.AddWithValue("@NovoSaldo", novoSaldo);
                    updateCmd.Parameters.AddWithValue("@Id", ContaId);
                    updateCmd.ExecuteNonQuery();

                    if (Session["IdConta"] != null && Session["NumConta"].ToString() == numConta)
                    {
                        Session["Saldo"] = novoSaldo;
                    }

                    Response.Redirect("PaginaInicial.aspx");
                }
                else
                {
                    lblMensagem.Text = "<div class='alert alert-danger'>Conta, CPF ou agência inválidos.</div>";
                }
            }
        }
    }
}