Public Class Empleado
    Private _Nomempleado As String
    Public Property NomEmpleado() As String
        Get
            Return _Nomempleado
        End Get
        Set(ByVal value As String)
            _Nomempleado = value
        End Set
    End Property

    Private _Apeempleado As String
    Public Property ApeEmpleado() As String
        Get
            Return _Apeempleado
        End Get
        Set(ByVal value As String)
            _Apeempleado = value
        End Set
    End Property

    Private _Dirempleado As String
    Public Property DirEmpleado() As String
        Get
            Return _Dirempleado
        End Get
        Set(ByVal value As String)
            _Dirempleado = value
        End Set
    End Property

    Private _FotoEmpleado As String
    Public Property FotoEmpleado() As String
        Get
            Return _FotoEmpleado
        End Get
        Set(ByVal value As String)
            _FotoEmpleado = value
        End Set
    End Property

    Private _CodUsuario As String
    Public Property CodUsuario() As String
        Get
            Return _CodUsuario
        End Get
        Set(ByVal value As String)
            _CodUsuario = value
        End Set
    End Property

    Private _CodEmpleado As String
    Public Property CodEmpleado() As String
        Get
            Return _CodEmpleado
        End Get
        Set(ByVal value As String)
            _CodEmpleado = value
        End Set
    End Property

End Class
