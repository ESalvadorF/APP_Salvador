Imports CapaDatos
Imports CapaEntidad
Public Class EmpleadoCN
    Public Sub New()
    End Sub
    Private Shared ReadOnly _instancia As New EmpleadoCN
    Public Shared ReadOnly Property Instancia() As EmpleadoCN
        Get
            Return _instancia
        End Get
    End Property
    ' Public Function ListarTodos() As List(Of Usuarios)
    'Return UsuariosDA.Instancia.
    'End Function
    Public Function ListaTodos() As List(Of Empleado)
        Return EmpleadoDA.Instancia.ListarTodos()
    End Function
End Class
