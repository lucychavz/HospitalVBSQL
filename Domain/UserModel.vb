Imports DataAccess
Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations

Public Class UserModel

#Region "-> Atributos"
    Private _id As Integer
    Private _username As String
    Private _password As String
    Private _firstName As String
    Private _lastName As String
    Private _position As String
    Private _email As String
    Private _photo As Byte()
    Private _userDao As UserDao
#End Region

#Region "-> Constructores"
    Public Sub New()
        _userDao = New UserDao()
    End Sub

    Public Sub New(ByVal id As Integer, ByVal userName As String, ByVal password As String, ByVal firstName As String, ByVal lastName As String, ByVal position As String, ByVal email As String, ByVal photo As Byte())
        id = id
        userName = userName
        password = password
        firstName = firstName
        lastName = lastName
        position = position
        email = email
        photo = photo
        _userDao = New UserDao()
    End Sub
#End Region

#Region "-> Propiedades + Validacíon y Visualización de Datos"

    'Posición 0 
    'Nombre a visualizar (Por ejemplo en la columna del datagridview se mostrará como Num).
    <DisplayName("Num")>
    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    'Posición 1
    'Nombre a visualizar
    'Validaciones
    <DisplayName("Usuario")>
    <Required(ErrorMessage:="El nombre de usuario es requerido.")>
    <StringLength(100, MinimumLength:=5, ErrorMessage:="El nombre de usuario debe contener un mínimo de 5 caracteres.")>
    Public Property Username As String
        Get
            Return _username
        End Get
        Set(ByVal value As String)
            _username = value
        End Set
    End Property

    'Posición 2
    'Nombre a visualizar.
    'Ocultar visualización (Por ejemplo no mostrar en el datagridview).
    'Validaciones
    <DisplayName("Contraseña")>
    <Browsable(False)>
    <Required(ErrorMessage:="Por favor ingrese una contraseña.")>
    <StringLength(100, MinimumLength:=5, ErrorMessage:="La contraseña debe contener un mínimo de 5 caracteres.")>
    Public Property Password As String
        Get
            Return _password
        End Get
        Set(ByVal value As String)
            _password = value
        End Set
    End Property

    'Posición 3
    <DisplayName("Nombre")>
    <Browsable(False)>
    <Required(ErrorMessage:="Por favor ingrese nombre")>
    <RegularExpression("^[a-zA-Z ]+$", ErrorMessage:="El nombre debe ser solo letras")>
    <StringLength(100, MinimumLength:=3, ErrorMessage:="El nombre debe contener un mínimo de 3 caracteres.")>
    Public Property FirstName As String
        Get
            Return _firstName
        End Get
        Set(ByVal value As String)
            _firstName = value
        End Set
    End Property

    'Posición 4
    <DisplayName("Apellido")>
    <Browsable(False)>
    <Required(ErrorMessage:="Por favor ingrese apellido.")>
    <RegularExpression("^[a-zA-Z ]+$", ErrorMessage:="El apellido debe ser solo letras")>
    <StringLength(100, MinimumLength:=3, ErrorMessage:="El apellido debe contener un mínimo de 3 caracteres.")>
    Public Property LastName As String
        Get
            Return _lastName
        End Get
        Set(ByVal value As String)
            _lastName = value
        End Set
    End Property

    ' 'Posición 5
    <[ReadOnly](True)>
    <DisplayName("Nombre completo")>
    Public ReadOnly Property FullName As String
        Get
            Return _firstName & ", " & _lastName
        End Get
    End Property

    'Posición 6
    <DisplayName("Cargo")>
    <Required(ErrorMessage:="Por favor ingrese un cargo.")>
    <StringLength(100, MinimumLength:=8, ErrorMessage:="Last name must contain a minimum of 8 characters.")>
    Public Property Position As String
        Get
            Return _position
        End Get
        Set(ByVal value As String)
            _position = value
        End Set
    End Property

    'Posición 7 
    <DisplayName("Email")>
    <Required(ErrorMessage:="Por favor ingrese correo electrónico.")>
    <EmailAddress(ErrorMessage:="Ingrese un correo electrónico válido: example@gmail.com")>
    Public Property Email As String
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            _email = value
        End Set
    End Property

    'Posición 8
    <DisplayName("Foto")>
    Public Property Photo As Byte()
        Get
            Return _photo
        End Get
        Set(ByVal value As Byte())
            _photo = value
        End Set
    End Property

#End Region

#Region "-> Metodos públicos"
    Public Function Login(ByVal username As String, ByVal password As String) As UserModel
        'Iniciar sesion.
        Dim result = _userDao.Login(username, password)

        If result IsNot Nothing Then
            Return MapUserModel(result)
        Else
            Return Nothing
        End If
    End Function

    Public Function ValidateActiveUser() As Boolean
        'Seguridad
        Return _userDao.ValidateActiveUser()
    End Function

    Public Function CreateUser() As Integer
        'Agregar nuevo usuario.
        '...
        'Aqui podría colocar su logica y reglas de negocio si es el caso.
        '..
        Dim userEntity As User = MapUserEntity(Me)
        Return _userDao.CreateUser(userEntity)
    End Function

    Public Function ModifyUser() As Integer
        'Editar usuario.
        '...
        'Aqui podría colocar su logica y reglas de negocio si es el caso.
        '..
        Dim userEntity As User = MapUserEntity(Me)
        Return _userDao.ModifyUser(userEntity)
    End Function

    Public Function RemoveUser(ByVal id As Integer) As Integer
        'Eliminar usuario.
        '...
        'Aqui podría colocar su logica y reglas de negocio si es el caso.
        '..
        Return _userDao.RemoveUser(id)
    End Function

    Public Function GetUserById(ByVal id As Integer) As UserModel
        'Obtener usuario por ID.
        Dim result = _userDao.GetUserById(id)

        If result IsNot Nothing Then
            Return MapUserModel(result)
        Else
            Return Nothing
        End If
    End Function

    Public Function GetAllUsers() As IEnumerable(Of UserModel)
        'Listar todos los usuarios.
        Dim result = _userDao.GetAllUsers()
        '...
        'Aqui podría colocar su logica y reglas de negocio si es el caso.
        '..
        Return MapUserModel(result)
    End Function

    Public Function RecoverPassword(ByVal requestingUser As String) As UserModel
        'Método para recuperar la contraseña del usuario y enviarlo a su dirección de correo.
        Dim result = _userDao.GetUserByUsername(requestingUser)

        If result IsNot Nothing Then
            Dim userModel = MapUserModel(result)
            Dim mailService = New EmailService()
            mailService.Send(recipient:=userModel.Email, subject:="Solicitud de recuperación de contraseña", body:="Hola " & userModel.FirstName & "," & vbLf & "Solicitó recuperar su contraseña." & vbLf & "Tu contraseña actual es: " + userModel.Password & vbLf & "Sin embargo, le pedimos que cambie" & "su contraseña inmediatamente una vez ingrese a la aplicacíon")
            Return userModel
        Else
            Return Nothing
        End If
        '* Nota: Eso es simplemente un ejemplo para enviar correos electrónicos,
        '* no es buena idea enviar directamente la contraseña del usuario,
        '* en su lugar, es mejor enviar una contraseña temporal.*/
    End Function
#End Region

#Region "-> Metodos privados (Mapear Datos)"

    'Mapear modelo de dominio a modelo de entidad.
    Private Function MapUserEntity(ByVal userModel As UserModel) As User
        Dim userEntity = New User With {
            .Id = userModel.Id,
            .Username = userModel.Username,
            .Password = userModel.Password,
            .FirstName = userModel.FirstName,
            .LastName = userModel.LastName,
            .Position = userModel.Position,
            .Email = userModel.Email,
            .Photo = userModel.Photo
        }
        Return userEntity
    End Function

    'Mapear modelo entidad a modelo de dominio.
    Private Function MapUserModel(ByVal userEntity As User) As UserModel
        'Mapear un solo objeto.
        Dim userModel = New UserModel() With {
            .Id = userEntity.Id,
            .Username = userEntity.Username,
            .Password = userEntity.Password,
            .FirstName = userEntity.FirstName,
            .LastName = userEntity.LastName,
            .Position = userEntity.Position,
            .Email = userEntity.Email,
            .Photo = userEntity.Photo
        }
        Return userModel
    End Function

    Private Function MapUserModel(ByVal userEntities As IEnumerable(Of User)) As IEnumerable(Of UserModel)
        'Mapear colección de objetos.
        Dim userModels = New List(Of UserModel)()

        For Each user In userEntities
            userModels.Add(MapUserModel(user))
        Next

        Return userModels
    End Function
#End Region

End Class


