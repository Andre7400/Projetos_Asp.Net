<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Calculadora.aspx.cs" Inherits="Aua1705.Calculadora" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <asp:UpdatePanel ID="UpdatePanel1" runat="server">
         <ContentTemplate>
     <br />
     <br />
    <asp:TextBox ID="txtCampo1" runat="server"></asp:TextBox>
    <asp:Label ID="lblMais" runat="server" Text="+"></asp:Label>
    <asp:TextBox ID="txtCampo2" runat="server"></asp:TextBox>
    <asp:Button ID="btnSomar" runat="server" Text="Somar" OnClick="btnSomar_Click" />
    <asp:Button ID="btnIgual" runat="server" Text="Igual" OnClick="btnIgual_Click" />
    <asp:TextBox ID="txtResultadoSoma" runat="server"></asp:TextBox>
             </ContentTemplate>
         </asp:UpdatePanel>
</asp:Content>
