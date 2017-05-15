<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastraProjeto.aspx.cs" Inherits="Aula1505.CadastraProjeto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <asp:UpdatePanel ID="upnCampos" runat="server">
        <ContentTemplate>
    <div class="panel panel-default">
        <div class="panel-body">
            <div class="row">
                <asp:Label ID="LblNome" runat="server" Text="Nome"></asp:Label>
                <asp:TextBox ID="TxtNome" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Campo Nome é obrigatorio" 
                    ControlToValidate="TxtNome"
                    ></asp:RequiredFieldValidator>
            </div>
            <br />
            <div class="row">
                <asp:Label ID="lblDescricao" runat="server" Text="Descricao"></asp:Label>
                <asp:TextBox ID="txtDescricao" runat="server" TextMode="MultiLine"></asp:TextBox>
            </div>
            <br />
            <div class="row">
                <asp:Label ID="LblInativo" runat="server" Text="Ativo"></asp:Label>
                <asp:CheckBox ID="ChkAtivo" runat="server" />
            </div>
            <br />
            <div class="row">
                <asp:Button ID="BtnSalvar" runat="server" Text="Salvar" OnClick="BtnSalvar_Click" />
                <asp:Button ID="BtnCancelar" runat="server" Text="Canelar" OnClick="BtnCancelar_Click" CausesValidation="false" />
                
            </div>
            </div>
        </div>
            </ContentTemplate>
            </asp:UpdatePanel>
</asp:Content>
