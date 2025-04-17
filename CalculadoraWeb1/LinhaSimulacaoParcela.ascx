<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LinhaSimulacaoParcela.ascx.cs" Inherits="CalculadoraWeb1.LinhaSimulacaoParcela" %>
<td style="border:1px solid black" ><= Linha.Quantidade %> x <%= Linha.ValorParcela %></td>
<td style="border:1px solid black" ><%= Linha.ValorTotal %></td>
<td style="border:1px solid black" ><%= Linha.ValorJuros%></td>
<td style="border:1px solid black" ><%= Linha.Vencimento.ToString("dd/MM/yyyy") %></td>