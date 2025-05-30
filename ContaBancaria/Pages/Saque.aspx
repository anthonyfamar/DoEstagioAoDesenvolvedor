<%@ Page Title="Saque" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Saque.aspx.cs" Inherits="ContaBancaria.Pages.Saque" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
	<main aria-labelledby="title">
		<div class="divCadastro">
				<header">
					<h3 class="header">Sistema bancário -  Saque</h3>
				</header>

				<div class="card pt-2 pb-3 border-0" style="padding-left:80px">
					<div class="mb-3" >
						<label for="ListaAgencia" class="form-label">Agência</label>
						<asp:DropDownList runat="server" ID="ListaAgencia" CssClass="form-select" Enabled="false">
							<asp:ListItem Text="Selecione uma opção" Value="0"></asp:ListItem>
							<asp:ListItem Text="1958" Value="6"></asp:ListItem>
							<asp:ListItem Text="1936" Value="8"></asp:ListItem>
							<asp:ListItem Text="3214" Value="9"></asp:ListItem>
							<asp:ListItem Text="3384" Value="10"></asp:ListItem>
						</asp:DropDownList>
					</div>

					<div class="mb-3">
						<label for="txtContaDeposito">Conta</label>
						<asp:TextBox runat="server" ID="txtContaDeposito" class="form-control" ></asp:TextBox>
					</div>

					<div class="mb-3">
						<label for="txtCPF">CPF:</label>
						<asp:TextBox runat="server" ID="txtCPF" class="form-control"></asp:TextBox>
					</div>

					<div class="mb-3">
						<label for="txtValor">Valor:</label>
						<asp:TextBox runat="server" ID="txtValor" class="form-control" placeholder="R$ 0,00" ></asp:TextBox>
					</div>
				</div>
				<div class="text-center mb-3">
					<asp:Label runat="server" ID="lblErro"></asp:Label>
				</div>
		</div>

		<div class="d-flex justify-content-center align-items-center pt-4">
			<asp:Button runat="server" ID="btnConfirmaSaque" class="btn btn-midnightblueComBorder " text="Confirmar" OnClick="btnConfirmaSaque_Click"/>
			<a href="PaginaInicial.aspx" class="btn btn-midnightblueComBorder">Voltar</a>
		</div>

    </main>
</asp:Content>
