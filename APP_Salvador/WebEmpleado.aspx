<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebEmpleado.aspx.vb" Inherits="APP_Salvador.WebEmpleado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <script src="/Scripts/jquery-1.10.2.js"></script>
    <script src="/Scripts/bootstrap.js"></script>
    <link href="/Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        
        <div class="container">
            
            <h3>Lista de Empleados</h3>

            <asp:GridView ID="table" runat="server" AutoGenerateColumns="False" CssClass="table table-hover" style="margin-top: 0px">
                <Columns>
                    <asp:BoundField DataField="CodEmpleado" HeaderText="Codigo" />
                    <asp:BoundField DataField="NomEmpleado" HeaderText="Nombre" />
                    <asp:BoundField DataField="ApeEmpleado" HeaderText="Apellidos" />
                    <asp:BoundField DataField="DirEmpleado" HeaderText="Direccion" />
                    <asp:BoundField />
                </Columns>
            </asp:GridView>
        </div>

        <script>
            $(document).ready( function () {
                $("#table").prepend( $("<thead></thead>").append( $(this).find("tr:first") ) ).dataTable();
            } );
        </script>

        <p>
            <asp:Image ID="Image1" runat="server" ImageUrl="images/descarga.jpg" />
        </p>

    </form>
</body>
</html>
