<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="CalculadoraWeb1.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
		<h1>Calculadora Fibonacci</h1>

		<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Carregar Números" />

		<br />
		<br />
		<br />

		<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
	</main>

</asp:Content>
