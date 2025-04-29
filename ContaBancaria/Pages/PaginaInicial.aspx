<%@ Page Title="Página Inicial" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PaginaInicial.aspx.cs" Inherits="ContaBancaria._Default" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
	<main aria-labelledby="title">
		<div class="div">

		    <header">
                <h3 class="header">Sistema bancário</h3>
            </header>

            <section>
                <nav class="banconavbar">
                    <ul class="ulalinhadoesquerda">
                        <asp:Button runat="server" ID="BtnPaginaInicial" Text="Página Inicial" class="btn btn-midnightblueNavLateral" OnClick="BtnPaginaInicial_Click" />
                        <asp:Button runat="server" ID="BtnDepositar" text="Depósito" class="btn btn-midnightblueNavLateral" OnClick="BtnDepositar_Click" />
                        <asp:Button runat="server" ID="BtnSaque" Text="Saque" class="btn btn-midnightblueNavLateral" OnClick="BtnSaque_Click" />
                        <asp:Button runat="server" ID="BtnTransferir" Text="Transferir" class="btn btn-midnightblueNavLateral" OnClick="BtnTransferir_Click" />
                    </ul>
                </nav>

                <article class="article">
                    <div class="tableInfo">
                        <ul class="ulalinhadoesquerda">
                            <li class="lisemoponto"><h4>Conta Nº: 111111</h4></li>
                            <li class="lisemoponto"><h4>Titular: João João</h4></li>
                            <li class="lisemoponto"><h4>Saldo: R$ 158798,00</h4></li>
                        </ul>
                    </div>
                    </br>
                    <div class="button-container">
                        <button class="buttonForaNav buttonForaNav">Mostrar Nº conta</button>
                        <button class="buttonForaNav buttonForaNav">Consultar Saldo</button>
                        <button class="buttonForaNav buttonForaNav">Pix</button>
                    </div>
                </article>
            </section>
		</div>
    </main>
</asp:Content>