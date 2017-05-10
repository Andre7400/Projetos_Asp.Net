<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Aula_1005.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>Teste de texto IE6.</h2>
    <h3>Hello Friend!</h3>
    <p>Use this area to provide additional information.</p>
    <asp:Calendar ID="inicialCalendario" runat="server"></asp:Calendar>
    <br />
    <asp:TextBox ID="txt_data" runat="server" TextMode="DateTime"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btn_salvar" runat="server" OnClick="btn_salvar_Click" Text="Salvar" Width="63px" />
    <br />
</asp:Content>

