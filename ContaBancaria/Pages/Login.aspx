<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ContaBancaria.Pages.Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main>
        <div class="d-flex justify-content-center align-items-center">
            <div class="card p-4 shadow" style="width: 100%; max-width: 400px; border: 1px solid #191970;">
                <h3 class="text-center mb-4" style="color: #191970;">Login Bancário</h3>

                <div class="mb-3" style="margin-left: 35px">
                    <label for="txtConta" class="form-label">Nº da Conta</label>
                    <asp:TextBox runat="server" ID="txtConta" class="form-control" placeholder="Ex: 123456"></asp:TextBox>
                </div>

                <div class="mb-3" style="margin-left: 35px">
                    <label for="txtSenha" class="form-label">Senha</label>
                    <asp:TextBox runat="server" ID="txtSenha" TextMode="Password" class="form-control" placeholder="Senha"></asp:TextBox>
                </div>

                <asp:Button runat="server" ID="btnLogin" Text="Entrar" class="btn w-100 text-white" style="background-color: #191970; margin-left: 35px" OnClick="btnLogin_Click" />

                <div class="text-center mt-3">
                    <a href="CadastroUsuario.aspx" style="color: #191970;">Criar novo usuário</a>
                </div>
            </div>
        </div>
    </main>
</asp:Content>