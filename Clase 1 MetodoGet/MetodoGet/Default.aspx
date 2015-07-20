<%@ Page Title="Página principal" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="MetodoGet._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .style1
        {
            width: 252px;
        }
        .style2
        {
            width: 252px;
            height: 26px;
        }
        .style3
        {
            height: 26px;
        }
    </style>
    <script src="Scripts/jquery-1.4.1.min.js"></script>
    <script src="Scripts/jquery.validate.js"></script>
     <script src="Scripts/additional-methods.js"></script>

     <script type="text/javascript">
         $(document).ready(function () {
             $("#form1").validate({

               rules: {
                        <%=txtNombre.UniqueID %>: 
                        {
                            required: true,
                             lettersonly: true 
                            
                          
                       },
                       <%=txtCedula.UniqueID %>: 
                        {
                            required: true,
                             maxlength: 10,
                            number: true
                         }   
                          
                       

                       },messages: {
                       <%=txtNombre.UniqueID %>: "Nombre Error"
                       }
         });
     });
           </script>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <table style="width: 100%;">
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Reserva entrada al cine"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
            </td>
            <td class="style3">
                <asp:TextBox ID="txtNombre" runat="server" Height="22px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="txtNombre" ErrorMessage="No ingreso nombre" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
            <td class="style3">
            </td>
        </tr>
        <tr>
            <td class="style1">
                <asp:Label ID="lblApellido" runat="server" Text="Apellido"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtApeliido" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="txtApeliido" ErrorMessage="No ingreso Apellido">*</asp:RequiredFieldValidator>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                Cedula</td>
            <td class="style3">
                <asp:TextBox ID="txtCedula" runat="server"></asp:TextBox>
            </td>
            <td class="style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                Sexo</td>
            <td class="style3">
                <asp:DropDownList ID="ddlSexo" runat="server">
                    <asp:ListItem>Hombre</asp:ListItem>
                    <asp:ListItem>Mujer</asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                    ErrorMessage="Requiere Sexo" ControlToValidate="ddlSexo">*</asp:RequiredFieldValidator>
            </td>
            <td class="style3">
            </td>
        </tr>
        <tr>
            <td class="style2">
                Pelicula</td>
            <td class="style3">
                <asp:RadioButtonList ID="rblPelicula" runat="server">
                    <asp:ListItem>Terremoto</asp:ListItem>
                    <asp:ListItem>Avengers</asp:ListItem>
                    <asp:ListItem>Mas negro que la noche</asp:ListItem>
                </asp:RadioButtonList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="rblPelicula" ErrorMessage="Debe seleccionar una película" 
                    ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
            <td class="style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="Label2" runat="server" Text="Snacks"></asp:Label>
            </td>
            <td class="style3">
                <asp:CheckBoxList ID="cblSnack" runat="server">
                    <asp:ListItem>Canguil</asp:ListItem>
                    <asp:ListItem>Cola</asp:ListItem>
                    <asp:ListItem>Hot-Dog</asp:ListItem>
                </asp:CheckBoxList>
            </td>
            <td class="style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style3">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
            </td>
            <td class="style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style3">
                <asp:Button ID="btnEnviar" runat="server" onclick="btnEnviar_Click" 
                    Text="Enviar" />
                <asp:Button ID="btnLimpiar"  class="cancel"  runat="server" onclick="btnLimpiar_Click" 
                    Text="Limpiar" />
            </td>
            <td class="style3">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
