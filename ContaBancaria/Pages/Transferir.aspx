<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Transferir.aspx.cs" Inherits="ContaBancaria.Pages.Transferir" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
	<main aria-labelledby="title">
		<div class="divCadastro">
				<header">
					<h3 class="header">Sistema bancário -  Saque</h3>
				</header>

				<div class="card pt-2 pb-3 border-0" style="padding-left:80px">

					<div class="mb-3">
						<label for="ddlTipoTransferencia">Tipo de transferência:</label>
						<asp:DropDownList runat="server" ID="ddlTipoTransferencia" CssClass="form-select" >
							<asp:ListItem>Selecione uma opção</asp:ListItem>
							<asp:ListItem Text="TED" Value="ted"></asp:ListItem>
							<asp:ListItem Text="DOC" Value="doc"></asp:ListItem>
						</asp:DropDownList>
					</div>

					<div class="mb-3">
						<label for="txtAgencia">Agência:</label>
						<asp:TextBox runat="server" ID="txtAgencia" class="form-control"></asp:TextBox>
					</div>

					<div class="mb-3">
						<label for="txtContaTransferencia">Conta para transferência:</label>
						<asp:TextBox runat="server" ID="txtContaTransferencia" class="form-control"></asp:TextBox>
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
			<asp:Button runat="server" ID="btnConfirmaTransferencia" text="Confirmar" class="btn btn-midnightblueComBorder" OnClick="btnConfirmaTransferencia_Click"/>
		</div>

    </main>
</asp:Content>
