Imports CapaNegocio

Public Class Login1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub BtnIniciar_Click(sender As Object, e As EventArgs) Handles BtnIniciar.Click
        Dim oUsuario As New UsuarioCN
        Dim new2 As Integer
        new2 = oUsuario.loginUsuario(TxtUsuario.Text, TxtClave.Text)

        If new2 = 1 Then
            Session("Username") = TxtUsuario.Text
            Response.Redirect("WebAdministracion.aspx")
        Else
            If new2 = 2 Then
                LblError.Text = "¡ Contraseña incorrecta !"
                Dim ejecutar = "activamensajeerror();"
                ScriptManager.RegisterStartupScript(Me, GetType(Page), "anioactual", ejecutar, True)
            Else
                LblError.Text = "¡ Usuario no registrado !"
                Dim ejecutar = "activamensajeerror();"
                ScriptManager.RegisterStartupScript(Me, GetType(Page), "anioactual", ejecutar, True)
            End If
        End If
        'resultado = oUsuario.BuscarporUsuarioClave(TxtUsuario.Text, TxtClave.Text)


        'If resultado = True Then
        '    Session("Username") = TxtUsuario.Text

        '    Response.Redirect("WebAdministracion.aspx")
        'Else
        '    LblError.Text = "Usuario o Clave no valido"
        '    Dim ejecutar = "activamensajeerror();"
        '    ScriptManager.RegisterStartupScript(Me, GetType(Page), "anioactual", ejecutar, True)
        'End If
    End Sub
End Class