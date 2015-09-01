<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MaestraLinq.aspx.cs" Inherits="Control_de_usaurios.MaestraLinq" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            height: 130px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%;">
        <tr>
            <td>
                &nbsp;</td>
            <td>
                Maestra LinQ</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>Nombre</asp:ListItem>
                    <asp:ListItem>Apellido</asp:ListItem>
                    <asp:ListItem>Correo</asp:ListItem>
                </asp:DropDownList>
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Button" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
            </td>
            <td class="style1">
                <asp:GridView ID="GridView1" runat="server">
                </asp:GridView>
            </td>
            <td class="style1">
            </td>
        </tr>
        <tr>
            <td>
                Nombre</td>
            <td style="margin-left: 80px">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                Apellido</td>
            <td style="margin-left: 80px">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                Correo</td>
            <td style="margin-left: 120px">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                Clave</td>
            <td style="margin-left: 120px">
                <asp:TextBox ID="TextBox4" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td style="margin-left: 120px">
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Grabar" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
