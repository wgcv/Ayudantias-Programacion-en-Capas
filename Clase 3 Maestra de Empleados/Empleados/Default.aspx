<%@ Page Title="Página principal" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="Empleados._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .style1
        {
            width: 156px;
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <table style="width:100%;">
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td>
                Nómina de Empleados</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                Buscar:</td>
            <td>
                <asp:DropDownList ID="ddlBuscar" runat="server">
                    <asp:ListItem Value="codigo">Codigo</asp:ListItem>
                    <asp:ListItem Value="nombre">Nombre</asp:ListItem>
                    <asp:ListItem Value="apellido">Apellido</asp:ListItem>
                </asp:DropDownList>
                <asp:TextBox ID="txtBuscar" runat="server"></asp:TextBox>
                <asp:Button ID="btnBuscar" runat="server" onclick="btnBuscar_Click" 
                    Text="Buscar" />
                <asp:Label ID="lblBuscarError" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td>
                <asp:GridView ID="grvEmpleados" runat="server" AutoGenerateColumns="False">
                    <Columns>
                        <asp:ButtonField CommandName="modifcar" HeaderText="Modificar" 
                            Text="Modificar" />
                        <asp:BoundField DataField="codigo" HeaderText="Codigo" />
                        <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                        <asp:BoundField DataField="apellido" HeaderText="Apellido" />
                        <asp:BoundField DataField="telefono" HeaderText="Teléfono" />
                        <asp:BoundField DataField="sexo" HeaderText="Sexo" />
                        <asp:BoundField DataField="sueldo" HeaderText="Sueldo" />
                        <asp:BoundField DataField="edad" HeaderText="Edad" />
                        <asp:BoundField DataField="estado" HeaderText="Estado" />
                        <asp:ButtonField CommandName="eliminar" HeaderText="Eliminar" Text="Eliminar" />
                    </Columns>
                </asp:GridView>
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
    </table>
</asp:Content>
