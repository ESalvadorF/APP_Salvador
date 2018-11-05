Imports CapaEntidad
Imports System.Data.SqlClient

Public Class UsuariosDA
    Public Sub New()
    End Sub
    Private Shared ReadOnly _instancia As New UsuariosDA
    Public Shared ReadOnly Property Instancia() As UsuariosDA
        Get
            Return _instancia
        End Get
    End Property
    Public Function BuscarporUsuarioClave(ByVal usuario As String, ByVal clave As String) As Boolean
        Dim cnn As New SqlConnection(Conexion.Instancia.cadenaconexion)
        cnn.Open()
        Dim contar As Integer
        Dim Sqlcmd As New SqlCommand("pa_usuarios_x_clave", cnn)
        Sqlcmd.CommandType = CommandType.StoredProcedure
        Sqlcmd.Parameters.Add("@usuario", SqlDbType.VarChar, 10).Value = usuario
        Sqlcmd.Parameters.Add("@clave", SqlDbType.VarChar, 6).Value = clave
        contar = Sqlcmd.ExecuteScalar()
        If contar = 0 Then
            Return False
        Else
            Return True
        End If
        cnn.Close()
        cnn.Dispose()
        Sqlcmd.Dispose()
    End Function

    Public Function loginUsuario(ByVal usuario As String, ByVal clave As String) As Integer
        Dim cnn As New SqlConnection(Conexion.Instancia.cadenaconexion)
        cnn.Open()
        Dim Sqlcmd As New SqlCommand("validar_usuario_x", cnn)
        Sqlcmd.CommandType = CommandType.StoredProcedure
        Sqlcmd.Parameters.Add("@usuario", SqlDbType.VarChar, 10).Value = usuario
        Sqlcmd.Parameters.Add("@clave", SqlDbType.VarChar, 6).Value = clave
        Sqlcmd.Parameters.Add("@valor", SqlDbType.Int)
        Sqlcmd.Parameters("@valor").Direction = ParameterDirection.Output
        Sqlcmd.ExecuteNonQuery()
        Return Sqlcmd.Parameters("@valor").Value
        cnn.Close()
        cnn.Dispose()
        Sqlcmd.Dispose()
    End Function

End Class
