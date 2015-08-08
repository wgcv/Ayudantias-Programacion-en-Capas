<%@ Page Title="Página principal" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="Maestra_productos._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .style1
        {
            width: 524px;
        }
        .style2
        {
            width: 117px;
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <table style="width:100%;">
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style1">
                <asp:Label ID="lbltitulo" runat="server" Text="MAESTRA DE PRODUCTOS"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="lblbuscar" runat="server" Text="BUSCAR POR:"></asp:Label>
            </td>
            <td class="style1">
                <asp:DropDownList ID="ddlbuscar" runat="server" Height="23px" Width="103px">
                    <asp:ListItem>codigo</asp:ListItem>
                    <asp:ListItem>nombre</asp:ListItem>
                    <asp:ListItem>marca</asp:ListItem>
                </asp:DropDownList>
&nbsp;<asp:TextBox ID="txtbuscar" runat="server" Width="206px"></asp:TextBox>
&nbsp;<asp:Button ID="btnbuscar" runat="server" Text="BUSCAR" Width="73px" 
                    onclick="btnbuscar_Click" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style1">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style1">
                <asp:GridView ID="grvproductos" runat="server" AutoGenerateColumns="False" 
                    CellPadding="4" ForeColor="#333333" GridLines="None" 
                    onselectedindexchanged="grvproductos_SelectedIndexChanged" 
                    onrowcommand="grvproductos_RowCommand">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:ButtonField CommandName="modificar" Text="MODIFICAR" />
                        <asp:BoundField DataField="codigo" HeaderText="CODIGO" />
                        <asp:BoundField DataField="nombre" HeaderText="NOMBRE" />
                        <asp:BoundField DataField="unidad" HeaderText="UNIDAD" />
                        <asp:BoundField DataField="caracteristicas" HeaderText="CARACTERISTICAS" />
                        <asp:BoundField DataField="inflamable" HeaderText="INFLAMABLE" />
                        <asp:BoundField DataField="cantidad" HeaderText="CANTIDAD" 
                            SortExpression="cantidad" />
                        <asp:BoundField DataField="marca" HeaderText="MARCA" />
                        <asp:ButtonField CommandName="eliminar" Text="ELIMINAR" />
                    </Columns>
                    <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                    <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                    <SortedAscendingCellStyle BackColor="#FDF5AC" />
                    <SortedAscendingHeaderStyle BackColor="#4D0000" />
                    <SortedDescendingCellStyle BackColor="#FCF6C0" />
                    <SortedDescendingHeaderStyle BackColor="#820000" />
                </asp:GridView>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style1">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style1">
                <asp:Button ID="btnnuevo" runat="server" Text="NUEVO" Width="104px" 
                    onclick="btnnuevo_Click" />
&nbsp;<asp:Button ID="btnactualizar" runat="server" Text="ACTUALIZAR" Width="104px" 
                    onclick="btnactualizar_Click" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style1">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="lblcodigo" runat="server" Text="CODIGO"></asp:Label>
            </td>
            <td class="style1">
                <asp:TextBox ID="txtcodigo" runat="server" Width="54px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="lblnombre" runat="server" Text="NOMBRE"></asp:Label>
            </td>
            <td class="style1">
                <asp:TextBox ID="txtnombre" runat="server" Width="170px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="lblunidad" runat="server" Text="UNIDAD"></asp:Label>
            </td>
            <td class="style1">
                <asp:DropDownList ID="ddlunidad" runat="server">
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="lblcaracteristicas" runat="server" Text="CARACTERISTICAS"></asp:Label>
            </td>
            <td class="style1">
                <asp:CheckBoxList ID="cblcaracteristicas" runat="server" Width="171px">
                    <asp:ListItem Value="1">CADUCA</asp:ListItem>
                    <asp:ListItem Value="2">TOXICO</asp:ListItem>
                    <asp:ListItem Value="3">DILUIBLE</asp:ListItem>
                    <asp:ListItem Value="4">FRAGIL</asp:ListItem>
                </asp:CheckBoxList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="lblinflamable" runat="server" Text="INFLAMABLE"></asp:Label>
            </td>
            <td class="style1">
                <asp:RadioButtonList ID="rblinflamable" runat="server">
                    <asp:ListItem Value="S">SI</asp:ListItem>
                    <asp:ListItem Selected="True" Value="N">NO</asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="lblcantidad" runat="server" Text="CANTIDAD"></asp:Label>
            </td>
            <td class="style1">
                <asp:TextBox ID="txtcantidad" runat="server" Width="66px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="lblmarca" runat="server" Text="MARCA"></asp:Label>
            </td>
            <td class="style1">
                <asp:DropDownList ID="ddlmarca" runat="server" Width="124px">
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style1">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style1">
                <asp:Label ID="lblmensaje" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style1">
                <asp:Button ID="btngrabar" runat="server" Text="GRABAR" Width="96px" 
                    onclick="btngrabar_Click" />
&nbsp;<asp:Button ID="btnlimpiar" runat="server" Text="LIMPIAR" Width="96px" 
                    onclick="btnlimpiar_Click" />
&nbsp;<asp:Button ID="btnsalir" runat="server" Text="SALIR" Width="96px" 
                    onclick="btnsalir_Click" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style1">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
