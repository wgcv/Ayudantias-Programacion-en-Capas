<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="reserva.aspx.cs" Inherits="MetodoGet.reserva" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
    .style1
    {
        width: 230px;
    }
    .style2
    {
        width: 230px;
        height: 21px;
    }
    .style3
    {
        height: 21px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width:100%;">
    <tr>
        <td class="style1">
            &nbsp;</td>
        <td>
            <asp:Label ID="Label1" runat="server" Text="Reserva con éxito"></asp:Label>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style2">
            <asp:Label ID="Label2" runat="server" Text="Nombre:"></asp:Label>
        </td>
        <td class="style3">
            <asp:Label ID="lblNombre" runat="server" Text="Label"></asp:Label>
        </td>
        <td class="style3">
        </td>
    </tr>
    <tr>
        <td class="style2">
            <asp:Label ID="Label3" runat="server" Text="Apellido"></asp:Label>
        </td>
        <td class="style3">
            <asp:Label ID="lblApellido" runat="server" Text="Label"></asp:Label>
        </td>
        <td class="style3">
        </td>
    </tr>
    <tr>
        <td class="style1">
            <asp:Label ID="Label4" runat="server" Text="Sexo"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lblSexo" runat="server" Text="Label"></asp:Label>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style1">
            <asp:Label ID="Label5" runat="server" Text="Película"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lblPelicula" runat="server" Text="Label"></asp:Label>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style1">
            <asp:Label ID="Label6" runat="server" Text="Snacks"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lblSnacks" runat="server" Text="Label"></asp:Label>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style1">
            &nbsp;</td>
        <td>
            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                Text="Regresar" />
        </td>
        <td>
            &nbsp;</td>
    </tr>
</table>
</asp:Content>
