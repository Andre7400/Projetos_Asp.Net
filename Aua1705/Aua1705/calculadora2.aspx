<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="calculadora2.aspx.cs" Inherits="Aua1705.calculadora2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:TextBox ID="txtn1" runat="server"></asp:TextBox>
    <asp:Label ID="lblMais" runat="server" Text="+"></asp:Label>
    <asp:TextBox ID="txtn2" runat="server"></asp:TextBox>
    <asp:TextBox ID="resultadoSoma" runat="server"></asp:TextBox>
    <br />
    <asp:TextBox ID="txtn3" runat="server"></asp:TextBox>
    <asp:Label ID="lblMenos" runat="server" Text="-"></asp:Label>
    <asp:TextBox ID="txtn4" runat="server"></asp:TextBox>
    <asp:TextBox ID="resultadoMenos" runat="server"></asp:TextBox>
    <br />
    <asp:TextBox ID="txtn5" runat="server"></asp:TextBox>
    <asp:Label ID="lblVezes" runat="server" Text="x"></asp:Label>
    <asp:TextBox ID="txtn6" runat="server"></asp:TextBox>
    <asp:TextBox ID="resultadoVezes" runat="server"></asp:TextBox>
    <br />
    <asp:TextBox ID="txtn7" runat="server"></asp:TextBox>
    <asp:Label ID="lblDividido" runat="server" Text="/"></asp:Label>
    <asp:TextBox ID="txtn8" runat="server"></asp:TextBox>
    <asp:TextBox ID="resultadoDividido" runat="server"></asp:TextBox>
    <br />

</asp:Content>
