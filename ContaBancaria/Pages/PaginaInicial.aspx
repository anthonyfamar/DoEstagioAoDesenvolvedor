<%@ Page Title="Página Inicial" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PaginaInicial.aspx.cs" Inherits="ContaBancaria.Pages.PaginaInicial" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
	<main aria-labelledby="title">
		<div class="divPaginaInicial">

		    <header">
                <h3 class="header">Sistema bancário - Página Inicial</h3>
            </header>

            <section>
                <nav class="banconavbar">
                    <ul class="ulalinhadoesquerda">
                        <a href="PaginaInicial.aspx" class="btn btn-midnightblueNavLateral">Página Inicial</a>
                        <a href="Deposito.aspx" class="btn btn-midnightblueNavLateral">Depósito</a>
                        <a href="Saque.aspx" class="btn btn-midnightblueNavLateral">Saque</a>
                        <a href="Transferir.aspx" class="btn btn-midnightblueNavLateral">Transferência</a>
                        
                    </ul>
                </nav>

                <article class="article">
                    <div class="tableInfo">
                        <div class="row">
                            <div class="h4">
                                Titular: <asp:Label runat="server" ID="TitularDaConta" class="h4" Text="oi"></asp:Label>
                            </div>
                            <div class="h4">
                                Conta Nº: <asp:Label runat="server" ID="NumeroDaConta" class="h4" Text="55487"></asp:Label>
                            </div>
                            <div class="h4">
                                Saldo Atual: R$ <asp:Label runat="server" ID="SaldoAtual"></asp:Label>
                            </div>
                        </div>
                    </div>
                    </br>
                    <div class="button-container">
                        <asp:Button runat="server" ID="BtnMostrarConta" Text="Mostrar Nº Conta" CssClass="buttonForaNav buttonForaNav" OnClick="BtnMostrarConta_Click" />
                        <asp:Button runat="server" ID="BtnMostrarSaldo" Text="Mostrar Saldo" CssClass="buttonForaNav buttonForaNav" OnClick="BtnMostrarSaldo_Click" />
                        <button class="buttonForaNav buttonForaNav">Pix</button>
                    </div>
                </article>
            </section>
		</div>
    </main>
</asp:Content>