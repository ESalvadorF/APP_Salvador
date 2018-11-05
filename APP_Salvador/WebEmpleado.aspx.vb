Imports CapaNegocio

Public Class WebEmpleado
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.table.DataSource = EmpleadoCN.Instancia.ListaTodos()
        Me.table.DataBind()
    End Sub

End Class