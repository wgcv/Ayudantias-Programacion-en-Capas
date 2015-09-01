<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MaestraUsuario.aspx.cs" Inherits="Control_de_usaurios.MaestraUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            width: 196px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%;">
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td>
                Maestra de Usuarios</td>
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
            <td class="style1">
                &nbsp;</td>
            <td>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    DataSourceID="SqlDataSource1">
                    <Columns>
                        <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" 
                            ReadOnly="True" SortExpression="id" />
                        <asp:BoundField DataField="nombre" HeaderText="nombre" 
                            SortExpression="nombre" />
                        <asp:BoundField DataField="correo" HeaderText="correo" 
                            SortExpression="correo" />
                        <asp:BoundField DataField="apellido" HeaderText="apellido" 
                            SortExpression="apellido" />
                        <asp:BoundField DataField="estado" HeaderText="estado" 
                            SortExpression="estado" />
                        <asp:BoundField DataField="confirmacion" HeaderText="confirmacion" 
                            SortExpression="confirmacion" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:ApplicationServices %>" 
                    SelectCommand="SELECT [id], [nombre], [correo], [apellido], [estado], [confirmacion] FROM [Usuario]">
                </asp:SqlDataSource>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                    Text="Exportar a pdf" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
