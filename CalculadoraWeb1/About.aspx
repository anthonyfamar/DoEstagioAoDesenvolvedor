<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs"  Inherits="CalculadoraWeb1.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">

		<div>
			<asp:Button runat="server" Text="Calcular Fibonacci" OnClick="Unnamed_Click"/> <br />
			<asp:Button runat="server" text="Calcular Juros" OnClick="Unnamed_Click1" /> <br />
			<asp:Button runat="server" Text="Gerenciar Nomes" OnClick="Unnamed_Click2" />
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

			Informe o valor de financiamento: <asp:TextBox runat="server" ID="TextBoxValorFinanciamento"></asp:TextBox><br />
			Informe o percentual da taxa: <asp:TextBox runat="server" ID="TextBoxPercentualTaxa"></asp:TextBox><br />
			Informe em quantos meses deseja quitar: <asp:TextBox runat="server" ID="TextBoxMesesQuitacao"></asp:TextBox>

			<br />
			<br />

			<asp:Button runat="server" ID="CalcularFinanciamento" OnClick="CalcularFinanciamentoButton_Click" Text="Calcular" />
			<asp:Label runat="server" ID="StatusLabel"></asp:Label>

			<br />
			<br />
			<br />

			<asp:Repeater runat="server" ID="MinhaTabela">
				<HeaderTemplate>
					<table style="border: 1px solid black; text-align:center" width="40%">
						<tr style="border:1px solid black; background-color: #c2c2c2" >
							<th style="border:1px solid black" >Parcelas</th>
							<th style="border:1px solid black" >Valor Total</th>
							<th style="border:1px solid black" >Valor do Juros</th>
							<th style="border:1px solid black" >Vencimento</th>
						</tr>
				</HeaderTemplate>
				<ItemTemplate>
					<tr style="border:1px solid black" >
						<td style="border:1px solid black" ><%# DataBinder.Eval(Container.DataItem, "Quantidade") %> x <%# DataBinder.Eval(Container.DataItem, "ValorParcela") %></td>
						<td style="border:1px solid black" ><%# DataBinder.Eval(Container.DataItem, "ValorTotal") %></td>
						<td style="border:1px solid black" ><%# DataBinder.Eval(Container.DataItem, "ValorJuros") %></td>
						<td style="border:1px solid black" ><%# ((DateTime)DataBinder.Eval(Container.DataItem, "Vencimento")).ToString("dd/MM/yyyy") %></td>
					</tr>
				</ItemTemplate>
				<FooterTemplate>
				</table>
				</FooterTemplate>
			</asp:Repeater>
		</asp:Panel>

		<asp:Panel runat="server" ID="GerenciadorDeNomePanel" Visible="false">
			<h1>Gerenciador de Nomes</h1>

			Informe o nome: <asp:TextBox runat="server" ID="TextBoxInformeNome"></asp:TextBox>

			<br />
			<br />

			<asp:Button runat="server" ID="AdicionarNome" OnClick="AdicionarNome_Click" Text="Adicionar"/>
			<asp:Label runat="server" ID="StatusLabelNomes"></asp:Label>
			
			<br />
			<br />
			<br />

			<asp:Repeater runat ="server" ID="MinhaLista">
				<HeaderTemplate>
					<ul>
				</HeaderTemplate>
				<ItemTemplate>
					<li><a href="#" onclick="alert('<%# InverterONome(Container.DataItem.ToString()) %>')"><%# Container.DataItem %></a></li>
				</ItemTemplate>
				<FooterTemplate>
				</ul>
				</FooterTemplate>
			</asp:Repeater>
		</asp:Panel>
	</main>

</asp:Content>
