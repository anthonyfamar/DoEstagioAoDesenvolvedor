<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Deposito.aspx.cs" Inherits="ContaBancaria.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
	<main aria-labelledby="title">
		<div class="divCadastro">
				<header">
					<h3 class="header">Sistema bancário -  Depósito</h3>
				</header>

				<div class="card pt-2 pb-3 border-0" style="padding-left:80px">
					<div class="mb-3">
						<label for="txtAgencia">Agência:</label>
						<asp:TextBox runat="server" ID="txtAgencia" class="form-control"></asp:TextBox>
					</div>

					<div class="mb-3">
						<label for="txtContaDeposito">Conta para depósito:</label>
						<asp:TextBox runat="server" ID="txtContaDeposito" class="form-control"></asp:TextBox>
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

		</div>

		<div class="d-flex justify-content-center align-items-center pt-4">
			<asp:Button runat="server" ID="btnConfirmaDeposito" class="btn btn-midnightblueComBorder " text="Confirmar" OnClick="btnConfirmaDeposito_Click"/>
		</div>

    </main>
</asp:Content>
