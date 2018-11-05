Public Class Usuario
    Private _codusuario As Integer
    Public Property codusuario() As Integer
        Get
            Return _codusuario
        End Get
        Set(ByVal value As Integer)
            _codusuario = value
        End Set
    End Property
    Private _nomUsuario As String
    Public Property nomUsuario() As String
        Get
            Return _nomUsuario
        End Get
        Set(ByVal value As String)
            _nomUsuario = value
        End Set
    End Property
    Private _contraseña As String
    Public Property contraseña() As String
        Get
            Return _contraseña
        End Get
        Set(ByVal value As String)
            _contraseña = value
        End Set
    End Property
    Public Sub New(ByVal ccodusuario As Integer, ByVal cnomUsuario As String,
    ByVal ccontraseña As String)
        _codusuario = ccodusuario
        _nomUsuario = cnomUsuario
        _contraseña = ccontraseña
    End Sub
    Public Sub New()
    End Sub

End Class
