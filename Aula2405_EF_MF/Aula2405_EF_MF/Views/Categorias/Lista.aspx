<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Lista.aspx.cs" Inherits="Aula2405_EF_MF.Views.Categorias.Lista" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <asp:UpdatePanel ID="UpdatePanel1" runat="server"> 
        <ContentTemplate>
    <asp:Label ID="lblNome" runat="server" Text="Nome:"></asp:Label>
    <br />
    <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblDes" runat="server" Text="Descricao"></asp:Label>
    <br />
    <asp:TextBox ID="txtDescricao" runat="server" TextMode="MultiLine"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click"  />
    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
<br />
            <h1> Categoria Ativos</h1>
     <asp:GridView ID="gvCategorias" runat="server"></asp:GridView>
            <br />
            <h1>Categoria Inativos</h1>
    <asp:GridView ID="gvCategoriasExcluidas" runat="server"></asp:GridView>

           </ContentTemplate> 
    </asp:UpdatePanel>

</asp:Content>
