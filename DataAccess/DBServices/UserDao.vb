Imports System.Data.SqlClient
Imports Common

Public Class UserDao
    Inherits ConnectionToSql

    ''' <summary>
    ''' Esta clase hereda de clase ConnectionToSql.
    ''' Aquí se realiza las diferentes transacciones y consultas a la base de datos de la entidad
    ''' usuario.
    ''' </summary>
    ''' 

    Public Function Login(ByVal username As String, ByVal password As String) As User
        'Validar el usuario y contraseña del usuario para el inicio de sesion.

        Using connection = GetConnection() 'Obtener la conexion.
            connection.Open() 'Abrir la conexion.

            Using command = New SqlCommand() 'Crear objeto SqlCommand.
                command.Connection = connection 'Establecer la conexión.
                'Establecer el comando de texto.
                command.CommandText = "select *from Users where (userName=@username and password=@pass) or (Email=@username and password=@pass)"
                'Establecer los parametros.
                command.Parameters.AddWithValue("@username", username)
                command.Parameters.AddWithValue("@pass", password)
                command.CommandType = CommandType.Text 'Establecer el tipo de comando.
                Dim reader As SqlDataReader = command.ExecuteReader() 'Ejecutar y establecer el lector.

                If reader.Read() Then 'Si el lector tiene filas que leer//Crear objeto y asignar los datos del resultado.
                    Dim userObj = New User With {
                        .Id = CInt(reader(0)),
                        .Username = reader(1).ToString(),
                        .FirstName = reader(3).ToString(),
                        .LastName = reader(4).ToString(),
                        .Position = reader(5).ToString(),
                        .Email = reader(6).ToString(),
                        .Photo = If(reader(7) IsNot DBNull.Value, CType(reader(7), Byte()), Nothing)
                    } 'En el caso de la propiedad Photo, establecer el valor si el valor de celda es diferente a DBNull, caso contrario establecer Nothing (Esto es importante, ya que se produce Null exception ).
                    '(Por seguridad, no almacenar la contraseña del usuario en el objeto.)

                    'Asignar los datos del usuario conectado actualmente en la aplicacion.
                    ActiveUser.Id = userObj.Id
                    ActiveUser.Position = userObj.Position
                    ActiveUser.Username = username

                    Return userObj 'Retornar el objeto usuario (Resultado)
                Else 'Si la consulta no fue exitosa, retornar nulo.
                    Return Nothing
                End If
            End Using
        End Using
    End Function

    Public Function ValidateActiveUser() As Boolean
        'Seguridad de la aplicacion, utiliza este metodo para verificar que el usuario conectado sea valido.

        Dim validUser As Boolean = False 'Obtiene o establece si el usuario conectado es valido (Valor por defecto =falso).
        Dim activeUserPass As String = "" 'Obtiene o establece la contraseña del usuario conectado.

        If String.IsNullOrWhiteSpace(ActiveUser.Username) = False Then 'Ejecutar este fragmento de codigo siempre en cuando que el nombre usuario NO sea nulo o espacios en blanco.

            Using connection = GetConnection() 'Obtener conexion
                connection.Open()

                Using command = New SqlCommand()
                    command.Connection = connection

                    'Obtener la contraseña del usuario conectado.
                    command.CommandText = "select password from Users where id=@id" 'Establecer el comando de texto
                    command.Parameters.AddWithValue("@id", ActiveUser.Id)

                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.Read() Then activeUserPass = reader(0).ToString() 'Si el lector tiene filas que leer, almacenar el resultado (Contraseña) en el campo activeUserPass.
                        command.Parameters.Clear() 'Limpiar los parametros para la siguiente consulta.
                    End Using

                    'Validar usuario conectado.
                    command.CommandText = "select *from Users where userName=@username or Email=@username and Password=@pass and Id=@id"
                    command.Parameters.AddWithValue("@username", ActiveUser.Username)
                    command.Parameters.AddWithValue("@pass", activeUserPass)
                    command.Parameters.AddWithValue("@id", ActiveUser.Id)
                    command.CommandType = CommandType.Text

                    Using reader As SqlDataReader = command.ExecuteReader()

                        If reader.HasRows Then 'Si el lector tiene filas, establecer validUser en verdadero.
                            validUser = True
                        Else 'Caso contrario, establecer validUser en falso.
                            validUser = False
                        End If
                    End Using
                End Using
            End Using
        End If

        Return validUser 'Retornar el resultado.
    End Function

    Public Function CreateUser(ByVal user As User) As Integer
        'Insertar nuevo usuario.

        Dim result As Integer = -1

        Using connection = GetConnection()
            connection.Open()

            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "insert into Users " &
                                            "values (@userName,@password, @firstName, @lastName,@position,@email,@photo)"
                command.Parameters.AddWithValue("@userName", user.Username)
                command.Parameters.AddWithValue("@password", user.Password)
                command.Parameters.AddWithValue("@firstName", user.FirstName)
                command.Parameters.AddWithValue("@lastName", user.LastName)
                command.Parameters.AddWithValue("@position", user.Position)
                command.Parameters.AddWithValue("@email", user.Email)

                If user.Photo IsNot Nothing Then 'Si la propiedad Foto es diferente a nulo, asignar el valor de la propiedad.
                    command.Parameters.Add(New SqlParameter("@photo", user.Photo) With {
                        .SqlDbType = SqlDbType.VarBinary})
                Else 'Caso contrario asignar un valor nulo de SQL.
                    command.Parameters.Add(New SqlParameter("@photo", DBNull.Value) With {
                        .SqlDbType = SqlDbType.VarBinary}) 'En este caso del campo Foto, es importante especificar explícitamente el tipo de dato de SQL.
                    'Puedes hacer lo mismo con los otros parámetros, sin embargo es opcional, El tipo de datos será derivará del tipo de dato de su valor.
                End If

                command.CommandType = CommandType.Text
                result = command.ExecuteNonQuery() 'Ejecutar el comando de texto y asignar el resultado al campo result.
            End Using
        End Using

        Return result 'retornar el numero de filas afectadas de la transaccion. 
    End Function

    Public Function ModifyUser(ByVal user As User) As Integer
        'Actualizar usuario.

        Dim result As Integer = -1

        Using connection = GetConnection()
            connection.Open()

            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "update  Users set " &
                                        "userName=@userName,password=@password,firstName=@firstName,lastName= @lastName, " &
                                        "position= @position,email=@email, profilePicture=@photo " &
                                        "where id=@id"
                command.Parameters.AddWithValue("@id", user.Id)
                command.Parameters.AddWithValue("@userName", user.Username)
                command.Parameters.AddWithValue("@password", user.Password)
                command.Parameters.AddWithValue("@firstName", user.FirstName)
                command.Parameters.AddWithValue("@lastName", user.LastName)
                command.Parameters.AddWithValue("@position", user.Position)
                command.Parameters.AddWithValue("@email", user.Email)

                If user.Photo IsNot Nothing Then
                    command.Parameters.Add(New SqlParameter("@photo", user.Photo) With {
                       .SqlDbType = SqlDbType.VarBinary})
                Else
                    command.Parameters.Add(New SqlParameter("@photo", DBNull.Value) With {
                        .SqlDbType = SqlDbType.VarBinary
                    })
                End If

                command.CommandType = CommandType.Text
                result = command.ExecuteNonQuery()
            End Using
        End Using

        Return result
    End Function

    Public Function RemoveUser(ByVal id As Integer) As Integer
        'Eliminar usuario.
        Dim result As Integer = -1

        Using connection = GetConnection()
            connection.Open()

            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "delete from Users where id=@id "
                command.Parameters.AddWithValue("@id", id)
                command.CommandType = CommandType.Text
                result = command.ExecuteNonQuery()
            End Using
        End Using

        Return result
    End Function

    Public Function GetUserById(ByVal id As Integer) As User
        'Obtener usuario por id.

        Using connection = GetConnection()
            connection.Open()

            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "select *from Users where id=@id"
                command.Parameters.AddWithValue("@id", id)
                command.CommandType = CommandType.Text
                Dim reader As SqlDataReader = command.ExecuteReader()

                If reader.Read() Then
                    Dim userObj = New User With {
                        .Id = CInt(reader(0)),
                        .Username = reader(1).ToString(),
                        .Password = reader(2).ToString(),
                        .FirstName = reader(3).ToString(),
                        .LastName = reader(4).ToString(),
                        .Position = reader(5).ToString(),
                        .Email = reader(6).ToString(),
                        .Photo = If(reader(7) IsNot DBNull.Value, CType(reader(7), Byte()), Nothing)
                    }
                    Return userObj 'Retornar resultado (objeto).
                Else
                    Return Nothing 'Retornar NULL si no hay resultado.
                End If
            End Using
        End Using
    End Function

    Public Function GetUserByUsername(ByVal user As String) As User
        'Obtener usuario por nombre de usuario o email.

        Using connection = GetConnection()
            connection.Open()

            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "select *from Users where username=@user or email=@user"
                command.Parameters.AddWithValue("@user", user)
                command.CommandType = CommandType.Text
                Dim reader As SqlDataReader = command.ExecuteReader()

                If reader.Read() Then
                    Dim userObj = New User With {
                        .Id = CInt(reader(0)),
                        .Username = reader(1).ToString(),
                        .Password = reader(2).ToString(),
                        .FirstName = reader(3).ToString(),
                        .LastName = reader(4).ToString(),
                        .Position = reader(5).ToString(),
                        .Email = reader(6).ToString(),
                        .Photo = If(reader(7) IsNot DBNull.Value, CType(reader(7), Byte()), Nothing)
                    }
                    Return userObj
                Else
                    Return Nothing
                End If
            End Using
        End Using
    End Function

    Public Function GetAllUsers() As IEnumerable(Of User)
        'Listar usuarios.

        Dim userList = New List(Of User)() 'Crear lista generica de usuarios.

        Using connection = GetConnection()
            connection.Open()

            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "select *from Users "
                command.CommandType = CommandType.Text
                Dim reader As SqlDataReader = command.ExecuteReader()

                If reader.HasRows Then

                    While reader.Read() 'Agregar los resultados en la lista mientras el lector siga leyendo las filas.
                        Dim userObj = New User With {
                            .Id = CInt(reader(0)),
                            .Username = reader(1).ToString(),
                            .Password = reader(2).ToString(),
                            .FirstName = reader(3).ToString(),
                            .LastName = reader(4).ToString(),
                            .Position = reader(5).ToString(),
                            .Email = reader(6).ToString(),
                            .Photo = If(reader(7) IsNot DBNull.Value, CType(reader(7), Byte()), Nothing)
                        }
                        userList.Add(userObj)
                    End While
                End If
            End Using
        End Using

        Return userList 'Retornar lista.
    End Function

End Class
