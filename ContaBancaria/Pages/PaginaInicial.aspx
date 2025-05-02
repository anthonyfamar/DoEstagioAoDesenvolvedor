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
                        <asp:Button runat="server" ID="BtnPaginaInicial" Text="Página Inicial" class="btn btn-midnightblueNavLateral" OnClick="BtnPaginaInicial_Click" />
                        <asp:Button runat="server" ID="BtnDepositar" text="Depósito" class="btn btn-midnightblueNavLateral" OnClick="BtnDepositar_Click" />
                        <asp:Button runat="server" ID="BtnSaque" Text="Saque" class="btn btn-midnightblueNavLateral" OnClick="BtnSaque_Click" />
                        <asp:Button runat="server" ID="BtnTransferir" Text="Transferir" class="btn btn-midnightblueNavLateral" OnClick="BtnTransferir_Click" />
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