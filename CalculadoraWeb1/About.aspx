<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="CalculadoraWeb1.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">

		<div>
			<asp:Button runat="server" Text="Calcular Fibonacci" OnClick="Unnamed_Click"/> <br />
			<asp:Button runat="server" text="Calcular Juros" OnClick="Unnamed_Click1" />
		</div>

		<asp:Panel runat="server" ID="FibonacciPanel" Visible="False">

			<h1>Calculadora Fibonacci</h1>
			Favor informar a quantidade de números: <asp:TextBox ID="TextBox1" OnTextChanged="TextBox1_TextChanged" runat="server"></asp:TextBox>

			<asp:Label runat="server" ID="TextoModificado" Text="Valor Original"></asp:Label>

			<br />
			<br />

			Quantidade de visitar na página: <asp:Label runat="server" ID="VisitasLabel"></asp:Label><br />
			Quantidade de alterações: <asp:Label runat="server" ID="AlteracoesLabel"></asp:Label>

			<br />
			<br />

			<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Carregar Números" />

			<br />
			<br />
			<br />

			<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

		</asp:Panel>

		<asp:Panel runat="server" ID="CalculoDeJurosPanel" Visible="false">
			<h1>Calculadora de Juros</h1>

		</asp:Panel>
	</main>

</asp:Content>
