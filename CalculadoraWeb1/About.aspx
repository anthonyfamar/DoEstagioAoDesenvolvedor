<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="CalculadoraWeb1.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %>.</h2>
        <h3>Your application description page.</h3>
        <p>Use this area to provide additional information.</p>

        <p>
            Seja <b>Bem Vindo</b>:
            <ul>
<%
    var calculadora = new CalculadoraWeb1.Calculadora();
    
    foreach (var numero in calculadora.GerarNumerosFibonacci(10))
    {
           %><li><% =numero %></li><%
        }
%>
    


            </ul>
        </p>
    </main>
</asp:Content>
