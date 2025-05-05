<%@ Page Title="Cadastro de usuário" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroUsuario.aspx.cs" Inherits="ContaBancaria.Pages.CadastroUsuario" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main>
        <div class="d-flex justify-content-center align-items-center">
            <div class="card p-4 shadow" style="width: 100%; max-width: 400px; border: 1px solid #191970; left: -9px; top: -69px; margin-top: 0px;">
                <h3 class="text-center mb-4" style="color: #191970;">Cadastro de usuário</h3>

                <div class="mb-3" style="margin-left: 35px">
                    <label for="txtConta" class="form-label">Nome Completo</label>
                    <asp:TextBox runat="server" ID="txtNomeCompleto" class="form-control"></asp:TextBox>
                </div>

                <div class="mb-3" style="margin-left: 35px">
                    <label for="txtAgencia" class="form-label">Agência</label>
                    <asp:TextBox runat="server" ID="txtAgencia" class="form-control" text="8968"></asp:TextBox>
                </div>

                <div class="mb-3" style="margin-left: 35px">
                    <label for="NumeroConta" class="form-label">Nº da Conta</label>
                    <asp:TextBox runat="server" ID="NumeroConta" class="form-control"></asp:TextBox>
                </div>

                <div class="mb-3" style="margin-left: 35px">
                    <label for="txtSenha" class="form-label">Senha</label>
                    <asp:TextBox runat="server" ID="txtSenha" TextMode="Password" class="form-control" placeholder="Senha"></asp:TextBox>
                </div>

                <asp:Button runat="server" ID="BtnCadastrar" Text="Confirmar" class="btn text-white" style="background-color: #191970; width:50%; margin-left: 100px; margin-top: 30px;" OnClick="BtnCadastrar_Click" />

            </div>
        </div>
    </main>
</asp:Content>
