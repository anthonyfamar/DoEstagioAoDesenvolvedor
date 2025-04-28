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
                        <li class="buttonNavLateral buttonNavLateral; lisemoponto"><h5>Página inicial</h5></li>
                        <asp:Button runat="server" ID="BtnDepositar" text="Depositar" CssClass="buttonNavLateral buttonNavLateral; lisemoponto" OnClick="BtnDepositar_Click" />
                        <li class="buttonNavLateral buttonNavLateral; lisemoponto"><h5>Sacar</h5></li>
                        <li class="buttonNavLateral buttonNavLateral; lisemoponto"><h5>Transferir</h5></li>
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