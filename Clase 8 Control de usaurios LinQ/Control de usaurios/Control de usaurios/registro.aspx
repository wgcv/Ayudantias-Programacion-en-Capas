<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="registro.aspx.cs" Inherits="Control_de_usaurios.registro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
    .style1
    {
        width: 231px;
    }
    .style2
    {
        width: 231px;
        height: 21px;
    }
    .style3
    {
        height: 21px;
    }
    .style4
    {
        width: 231px;
        height: 29px;
    }
    .style5
    {
        height: 29px;
    }
    .style6
    {
        width: 231px;
        height: 22px;
    }
    .style7
    {
        height: 22px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width:100%;">
    <tr>
        <td class="style6">
        </td>
        <td class="style7">
            Registro</td>
        <td class="style7">
        </td>
    </tr>
    <tr>
        <td class="style1">
            Nombre</td>
        <td>
            <asp:TextBox ID="txtNombre" runat="server" style="margin-left: 0px"></asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style1">
            Apellido</td>
        <td>
            <asp:TextBox ID="txtApellido" runat="server" style="margin-left: 0px"></asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style4">
            Correo</td>
        <td class="style5">
            <asp:TextBox ID="txtCorreo" runat="server" style="margin-left: 0px"></asp:TextBox>
        </td>
        <td class="style5">
        </td>
    </tr>
    <tr>
        <td class="style1">
            Clave</td>
        <td>
            <asp:TextBox ID="txtClave" runat="server" style="margin-left: 0px" 
                TextMode="Password"></asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style1">
            Confirmar Clave</td>
        <td>
            <asp:TextBox ID="txtClave2" runat="server" style="margin-left: 0px" 
                TextMode="Password"></asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style1">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style2">
        </td>
        <td class="style3">
            <asp:Label ID="lblInformacion" runat="server"></asp:Label>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
        </td>
        <td class="style3">
        </td>
    </tr>
    <tr>
        <td class="style1">
            &nbsp;</td>
        <td>
            <asp:Button ID="btnEnviar" runat="server" onclick="btnEnviar_Click" 
                Text="Enviar" />
            <asp:Button ID="btnLimpiar" runat="server" Text="Limpiar" />
        </td>
        <td>
            &nbsp;</td>
    </tr>
</table>
</asp:Content>
