Imports System.Data.SqlClient
Imports CapaEntidad

Public Class EmpleadoDA
    Public Sub New()
    End Sub
    Private Shared ReadOnly _instancia As New EmpleadoDA
    Public Shared ReadOnly Property Instancia() As EmpleadoDA
        Get
            Return _instancia
        End Get
    End Property
    Public Function ListarTodos() As List(Of Empleado)
        Dim cnn As New SqlConnection(Conexion.Instancia.cadenaconexion)
        cnn.Open()
        Dim Sqlcmd As New SqlCommand()
        Sqlcmd.Connection = cnn
        Sqlcmd.CommandText = "SELECT * FROM Empleado"
        Sqlcmd.CommandType = CommandType.Text
        Dim dataReader As SqlDataReader

        dataReader = Sqlcmd.ExecuteReader
        Dim empleados = New List(Of Empleado)
        While dataReader.Read
            Dim empleado As New Empleado()

            empleado.CodEmpleado = dataReader(0)
            empleado.NomEmpleado = dataReader(1)
            empleado.ApeEmpleado = dataReader(2)
            empleado.CodEmpleado = dataReader(3)
            empleado.DirEmpleado = dataReader(4)
            empleado.FotoEmpleado = dataReader(5)
            empleado.CodUsuario = dataReader(6)

            empleados.Add(empleado)
        End While


        cnn.Close()
        cnn.Dispose()

        Return empleados
    End Function
End Class
