Imports System.Data.SqlClient

Public MustInherit Class ConnectionToSql
    ''' <summary>
    ''' Esta clase abstracta es responsable de establecer la cadena de conexion
    ''' y obtener la conexion a SQL.
    ''' </summary>
    ''' 

    Private ReadOnly connectionString As String 'Obtiene o establece la cadena de conexión.

    Public Sub New()
        'Establecer la cadena de conexión.
        connectionString = "Server=(local); DataBase= ClinicaSaludBienestar; Integrated Security= true"
    End Sub

    Protected Function GetConnection() As SqlConnection
        'Este métedo se encarga de establecer y devolver el objeto de conexión a SQL Server.
        Return New SqlConnection(connectionString)
    End Function
End Class
