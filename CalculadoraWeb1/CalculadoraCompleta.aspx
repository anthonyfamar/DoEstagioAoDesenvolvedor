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
			Atual: <asp:Label runat="server" ID="NumeroAtualLabel" Text="0" ></asp:Label>
		</div>
	</div>
	<div class="row m-2">
		<div class="col-4">
			<asp:Button runat="server" ID="Numero7Button" Text="7" CssClass="btn btn-secondary btn-lg" OnClick="Numero7Button_Click" />
		</div>
		<div class="col-4">
			<asp:Button runat="server" ID="Numero8Button" Text="8" CssClass="btn btn-secondary btn-lg" OnClick="Numero8Button_Click"/>
		</div>
		<div class="col-4">
			<asp:Button runat="server" ID="Numero9Button" Text="9" CssClass="btn btn-secondary btn-lg" OnClick="Numero9Button_Click" />
		</div>
	</div>
	<div class="row m-2">
		<div class="col-4">
			<asp:Button runat="server" ID="Numero4Button" Text="4" CssClass="btn btn-secondary btn-lg" OnClick="Numero4Button_Click" />
		</div>
		<div class="col-4">
			<asp:Button runat="server" ID="Numero5Button" Text="5" CssClass="btn btn-secondary btn-lg" OnClick="Numero5Button_Click" />
		</div>
		<div class="col-4">
			<asp:Button runat="server" ID="Numero6Button" Text="6" CssClass="btn btn-secondary btn-lg" OnClick="Numero6Button_Click" />
		</div>
	</div>
	<div class="row m-2">
		<div class="col-4">
			<asp:Button runat="server" ID="Numero1Button" Text="1" CssClass="btn btn-secondary btn-lg" OnClick="Numero1Button_Click" />
		</div>
		<div class="col-4">
			<asp:Button runat="server" ID="Numero2Button" Text="2" CssClass="btn btn-secondary btn-lg" OnClick="Numero2Button_Click" />
		</div>
		<div class="col-4">
			<asp:Button runat="server" ID="Numero3Button" Text="3" CssClass="btn btn-secondary btn-lg" OnClick="Numero3Button_Click" />
		</div>
	</div>
	<div class="row m-2">
		<div class="col-4">
		</div>
		<div class="col-4">
			<asp:Button runat="server" ID="Numero0Button" Text="0" CssClass="btn btn-secondary btn-lg" OnClick="Numero0Button_Click"/>
		</div>
		<div class="col-4">
			<asp:Button runat="server" ID="OperacaoSomarButton" Text="+" CssClass="btn btn-primary btn-lg" OnClick="OperacaoSomarButton_Click" />
		</div>
	</div>
</asp:Content>
