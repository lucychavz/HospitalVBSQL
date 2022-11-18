Imports DataAccess
Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.Security.Cryptography

Public Class MedicoModel
#Region "-> Atributos"
    Private _nombre As Integer
    Private _apellido As String
    Private _especialidad As String
    Private _direccion As String
    Private _celular As Integer
    Private _userDao As UserDao
#End Region


#Region "-> Constructores"
    Public Sub New()
        _userDao = New UserDao()
    End Sub

    Public Sub New(ByVal Nombre As Integer, ByVal Apellido As String, ByVal Direccion As String, ByVal Especialidad As String, ByVal Celular As String)

        Nombre = Nombre
        Apellido = Apellido
        Direccion = Direccion
        Especialidad = Especialidad
        Celular = Celular

        _userDao = New UserDao()
    End Sub
#End Region


#Region "-> Propiedades + Validacíon y Visualización de Datos"

    'Posición 0 
    'Nombre a visualizar (Por ejemplo en la columna del datagridview se mostrará como Num).
    <DisplayName("Num")>
    Public Property Nombre As Integer
        Get
            Return _nombre
        End Get
        Set(ByVal value As Integer)
            _nombre = value
        End Set
    End Property


    'Posición 2 
    <DisplayName("Apellido")>
    <Browsable(False)>
    <Required(ErrorMessage:="Por favor ingrese apellido.")>
    <RegularExpression("^[a-zA-Z ]+$", ErrorMessage:="El apellido debe ser solo letras")>
    <StringLength(100, MinimumLength:=3, ErrorMessage:="El apellido debe contener un mínimo de 3 caracteres.")>
    Public Property Apellido As String
        Get
            Return _apellido
        End Get
        Set(ByVal value As String)
            _apellido = value
        End Set
    End Property

    'Posición 3 
    <DisplayName("Especialiad")>
    <Browsable(False)>
    <Required(ErrorMessage:="Por favor ingrese la especialiad.")>
    <RegularExpression("^[a-zA-Z ]+$", ErrorMessage:="La especialiad debe ser solo letras")>
    <StringLength(100, MinimumLength:=3, ErrorMessage:="La especialiaddebe contener un mínimo de 3 caracteres.")>
    Public Property Especialiad As String
        Get
            Return _especialidad
        End Get
        Set(ByVal value As String)
            _especialidad = value
        End Set
    End Property

    'Posición 4 
    <DisplayName("Direccion")>
    <Browsable(False)>
    <Required(ErrorMessage:="Por favor ingrese la direccion.")>
    <RegularExpression("^[a-zA-Z ]+$", ErrorMessage:="La direccion debe ser solo letras")>
    <StringLength(100, MinimumLength:=3, ErrorMessage:="La direccion contener un mínimo de 3 caracteres.")>
    Public Property Direccion As String
        Get
            Return _direccion
        End Get
        Set(ByVal value As String)
            _direccion = value
        End Set
    End Property

    'Posición 5 
    <DisplayName("Celular")>
    <Browsable(False)>
    <Required(ErrorMessage:="Por favor ingrese el  número celular.")>
    <RegularExpression("^[0-9 ]+$", ErrorMessage:="El número debe ser solo números")>
    <StringLength(100, MinimumLength:=3, ErrorMessage:="El número contener un mínimo de 3 caracteres.")>
    Public Property Celular As String
        Get
            Return _celular
        End Get
        Set(ByVal value As String)
            _celular = value
        End Set
    End Property


#End Region
End Class
