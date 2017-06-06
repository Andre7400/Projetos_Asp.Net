<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Lista.aspx.cs" Inherits="ProjetoProva.Views.Consultas.Lista" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
    <br />
    <h1>Cadastrar Consultas</h1>
    <br />
    <asp:Label ID="lbl_Nome" runat="server" Text="Nome:"></asp:Label>
    <br />
    <asp:TextBox ID="txt_nome" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lbl_preco" runat="server" Text="preco:"></asp:Label>
    <br />
    <asp:TextBox ID="txt_preco" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lbl_data" runat="server" Text="Data da Consulta:"></asp:Label>
    <br />
    <asp:TextBox ID="txt_data" runat="server"></asp:TextBox>
    <br />
    <br />   
    <asp:Label ID="lbl_ID" runat="server" Text="Id do Medico:"></asp:Label>
    <br />
    <br /> 
    <asp:DropDownList ID="ddlMedico" runat="server" DataTextField="Nome" DataValueField="Id"></asp:DropDownList>
    <br />
    <br />
    <asp:Button ID="btn_salvar" runat="server" Text="Salvar" OnClick="btn_salvar_Click" />
    <br />
    <br />
    <br />
    <h1>Buscar Editar e Excluir Consulta</h1>
    <asp:Label ID="lbl_IdBuscar" runat="server" Text="ID:"></asp:Label>
    <asp:TextBox ID="txt_IdBuscar" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btn_buscar" runat="server" Text="Buscar" OnClick="btn_buscar_Click" />
    <br />
    <br />
    <br />
    <asp:Label ID="lbl_NomeBuscado" runat="server" Text="Nome:"></asp:Label>
    <asp:TextBox ID="txt_NomeBuscado" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lbl_precoBuscado" runat="server" Text="preco:"></asp:Label>
    <asp:TextBox ID="txt_PrecoBuscado" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lbl_dataBuscado" runat="server" Text="Data da Consulta:"></asp:Label>
    <asp:TextBox ID="txt_DataBuscado" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btn_editar" runat="server" Text="Editar" OnClick="btn_editar_Click" />
    <asp:Button ID="btn_excluir" runat="server" Text="Excluir" OnClick="btn_excluir_Click" />


            <br />
            <br />
            <h1>Consultas Ativas</h1>
            <asp:GridView ID="gv_Consultas" runat="server"></asp:GridView>
            
            <br />
            <h1>Consultas Inativas</h1>
            <asp:GridView ID="gv_ConsultasInativas" runat="server"></asp:GridView>
            <br />
            <br />
            <br />
            <h1>Medicos Ativos</h1>
            <asp:GridView ID="gv_Medicos" runat="server"></asp:GridView>
            <br />
            <h1>Medicos Inativos</h1>
            <asp:GridView ID="gv_MedicosInativos" runat="server"></asp:GridView>
            <br />



             </ContentTemplate>
        </asp:UpdatePanel>
           
</asp:Content>
