Public Class User
    'Las entidades tienen los mismos campos de la tabla de la base de datos,
    'además esto te permite  cambiar facilmente a Entity Framework.
    Public Property Id As Integer
    Public Property Username As String
    Public Property Password As String
    Public Property FirstName As String
    Public Property LastName As String
    Public Property Position As String
    Public Property Email As String
    Public Property Photo As Byte()
End Class
