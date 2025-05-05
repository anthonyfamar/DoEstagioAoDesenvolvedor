<%@ Page Title="Cadastro de Conta Bancária" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroContaBancaria.aspx.cs" Inherits="ContaBancaria.Pages.CadastroUsuario" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
	<main>
        <div class="d-flex justify-content-center align-items-center">
            <div class="card p-4 shadow" style="width: 100%; max-width: 400px; border: 1px solid #191970; left: -9px; top: -69px; margin-top: 0px;">
                <h4 class="text-center mb-4" style="color: #191970;">Cadastro de Conta Bancária</h4>

                <div class="mb-3" style="margin-left: 35px">
                    <label for="txtConta" class="form-label">Nome Completo</label>
                    <asp:TextBox runat="server" ID="txtNomeCompleto" class="form-control"></asp:TextBox>
                </div>

                <div class="mb-3" style="margin-left: 35px">
                    <label for="txtCpf" class="form-label">CPF</label>
                    <asp:TextBox runat="server" ID="txtCpf" class="form-control"></asp:TextBox>
                </div>

                <div class="mb-3" style="margin-left: 35px">
                    <label for="txtTelefone" class="form-label">Telefone</label>
                    <asp:TextBox runat="server" ID="txtTelefone" class="form-control"></asp:TextBox>
                </div>

                <div class="mb-3" style="margin-left: 35px">
                    <label for="txtAgencia" class="form-label">Agência</label>
                    <asp:TextBox runat="server" ID="txtAgencia" ReadOnly="true" class="form-control" style="border:none" text="8968"></asp:TextBox>
                </div>

                <div class="mb-3" style="margin-left: 35px">
                    <label for="txtNumeroConta" class="form-label">Nº da Conta</label>
                    <asp:TextBox runat="server" ID="txtNumeroConta" ReadOnly="true" class="form-control" style="border:none"></asp:TextBox>
                </div>

                <div class="mb-3" style="margin-left: 35px">
                    <label for="txtSenha" class="form-label">Senha</label>
                    <asp:TextBox runat="server" ID="txtSenha" TextMode="Password" class="form-control" placeholder="Senha"></asp:TextBox>
                </div>

                <asp:Button runat="server" ID="BtnCadastrar" Text="Confirmar" class="btn text-white" style="background-color: #191970; width:50%; margin-left: 100px; margin-top: 10px;" OnClick="BtnCadastrar_Click" />

            </div>
        </div>
    </main>
</asp:Content>
