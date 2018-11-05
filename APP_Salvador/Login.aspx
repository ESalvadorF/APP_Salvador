<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Login.aspx.vb" Inherits="APP_Salvador.Login1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Login</title>
    <script src="/Scripts/jquery-1.10.2.js"></script>
    <script src="/Scripts/bootstrap.js"></script>
    <script>
        function activamensajeerror() {
            $(".alert").prop('hidden', false);
            $(".alert").delay(3000).hide(200);
        }
    </script>
    <link href="/Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
        <div class="row">
            <div class="form-group" >
                <h1>Login</h1>
            </div>
            <div class="form-group" ">
                <asp:Label ID="Label4" runat="server" Text="Identificacion de Usuario"></asp:Label>
                <asp:TextBox ID="TxtUsuario" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TxtUsuario" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group" >
                <asp:Label ID="Label2" runat="server" Text="Usuario"></asp:Label>
                <asp:TextBox ID="TxtClave" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TxtClave" ErrorMessage="*" ForeColor="#FF3300"></asp:RequiredFieldValidator>
            </div>

            <div class="form-group" >

                    <div class="alert alert-danger" role="alert" id="contentAlert" hidden="hidden">
                      <asp:Label ID="LblError" runat="server"></asp:Label>
                    </div>
            </div>

            <div class="form-group">
                <asp:Button ID="BtnIniciar" runat="server" Text="Iniciar"  CssClass="btn btn-secondary"/>
            </div>
        </div>

    </div>
    </form>
</body>
</html>
