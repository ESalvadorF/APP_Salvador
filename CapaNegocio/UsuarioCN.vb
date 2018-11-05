Imports CapaDatos

Public Class UsuarioCN
    Public Sub New()
    End Sub
    Private Shared ReadOnly _instancia As New UsuarioCN
    Public Shared ReadOnly Property Instancia() As UsuarioCN
        Get
            Return _instancia
        End Get
    End Property
    Public Function BuscarporUsuarioClave(ByVal Usuario As String, ByVal Clave As String) As Boolean
        Return UsuariosDA.Instancia.BuscarporUsuarioClave(Usuario, Clave)
    End Function

    Public Function loginUsuario(ByVal Usuario As String, ByVal Clave As String) As Integer
        Return UsuariosDA.Instancia.loginUsuario(Usuario, Clave)
    End Function
End Class
