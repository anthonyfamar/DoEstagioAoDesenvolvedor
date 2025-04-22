<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CalculadoraCompleta.aspx.cs" Inherits="CalculadoraWeb1.CalculadoraCompleta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
	<h1>
		Calculadora Completa
	</h1>
	<div class="row">
		<div class="col">
			Primeiro: <asp:Label runat="server" ID="PrimeiroNumeroLabel"></asp:Label>
		</div>
	</div>
	<div class="row">
		<div class="col">
			Atual: <asp:Label runat="server" ID="NumeroAtualLabel"></asp:Label>
		</div>
	</div>
</asp:Content>
