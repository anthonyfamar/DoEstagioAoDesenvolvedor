﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CalculadoraCompleta.aspx.cs" Inherits="CalculadoraWeb1.CalculadoraCompleta" %>
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
		<div class="col-2">
		</div>
		<div class="col-2">
		</div>
		<div class="col-2">
			<asp:Button runat="server" ID="LimparButton" Text="CE" CssClass="btn btn-primary btn-lg" OnClick="LimparButton_Click"/>
		</div>
		<div class ="col-2">
		</div>
	</div>
	<div class="row m-2">
		<div class="col-2">
			<asp:Button runat="server" ID="Numero7Button" Text="7" CssClass="btn btn-secondary btn-lg" OnClick="BtnAddNumero_Click" />
		</div>
		<div class="col-2">
			<asp:Button runat="server" ID="Numero8Button" Text="8" CssClass="btn btn-secondary btn-lg" OnClick="BtnAddNumero_Click"/>
		</div>
		<div class="col-2">
			<asp:Button runat="server" ID="Numero9Button" Text="9" CssClass="btn btn-secondary btn-lg" OnClick="BtnAddNumero_Click" />
		</div>
		<div class ="col-2">
			<asp:Button runat="server" ID="OperacaoDivisao" Text="÷" CssClass="btn btn-primary btn-lg" OnClick="OperacaoDivisao_Click" />
		</div>
	</div>
	<div class="row m-2">
		<div class="col-2">
			<asp:Button runat="server" ID="Numero4Button" Text="4" CssClass="btn btn-secondary btn-lg" OnClick="BtnAddNumero_Click" />
		</div>
		<div class="col-2">
			<asp:Button runat="server" ID="Numero5Button" Text="5" CssClass="btn btn-secondary btn-lg" OnClick="BtnAddNumero_Click" />
		</div>
		<div class="col-2">
			<asp:Button runat="server" ID="Numero6Button" Text="6" CssClass="btn btn-secondary btn-lg" OnClick="BtnAddNumero_Click" />
		</div>
		<div class="col-2">
			<asp:Button runat="server" ID="OperecaoMultiplicacao" Text="*" CssClass="btn btn-primary btn-lg" OnClick="OperecaoMultiplicacao_Click" />
		</div>
	</div>
	<div class="row m-2">
		<div class="col-2">
			<asp:Button runat="server" ID="Numero1Button" Text="1" CssClass="btn btn-secondary btn-lg" OnClick="BtnAddNumero_Click" />
		</div>
		<div class="col-2">
			<asp:Button runat="server" ID="Numero2Button" Text="2" CssClass="btn btn-secondary btn-lg" OnClick="BtnAddNumero_Click" />
		</div>
		<div class="col-2">
			<asp:Button runat="server" ID="Numero3Button" Text="3" CssClass="btn btn-secondary btn-lg" OnClick="BtnAddNumero_Click" />
		</div>
		<div class="col-2">
			<asp:Button runat="server" ID="OperacaoSubtrair" Text="-" CssClass="btn btn-primary btn-lg" OnClick="OperacaoSubtrairButton_Click" />
		</div>
	</div>
	<div class="row m-2">
		<div class="col-2">
			<asp:Button runat="server" ID="SinalButton" Text="+/-" CssClass="btn btn-primary btn-lg" OnClick="SinalButton_Click" />
		</div>
		<div class="col-2">
			<asp:Button runat="server" ID="Numero0Button" Text="0" CssClass="btn btn-secondary btn-lg" OnClick="Numero0Button_Click"/>
		</div>
		<div class="col-2">
			<asp:Button runat="server" ID="VirgulaButton" Text="," CssClass="btn btn-primary btn-lg" OnClick="VirgulaButton_Click" />
		</div>
		<div class="col-2">
			<asp:Button runat="server" ID="OperacaoSomar" Text="+" CssClass="btn btn-primary btn-lg" OnClick="OperacaoSomarButton_Click" />
		</div>
	</div>
</asp:Content>
