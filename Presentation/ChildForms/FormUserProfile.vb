Imports Domain
Imports Common

Public Class FormUserProfile

    Private conectedUser As UserModel 'Obtiene o establece el usuario conectado actualmente.

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub FormUserProfile_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        LoadUserData()
    End Sub

    Private Sub LoadUserData()
        'Cargar datos del usuario activo.
        Dim userModel = New UserModel().GetUserById(ActiveUser.Id) 'Obtener el usuario mediante el id del usuario activo.
        conectedUser = userModel 'Establecer el usuario conectado.

        lblFullname.Text = userModel.FullName
        lblUsername.Text = userModel.Username
        lblName.Text = userModel.FirstName
        lblLastName.Text = userModel.LastName
        lblMail.Text = userModel.Email
        lblPosition.Text = userModel.Position

        If userModel.Photo IsNot Nothing Then 'Si el usuario tiene foto, asignar al cuadro de imagen.
            pictureBoxPhoto.Image = ItemConverter.BinaryToImage(userModel.Photo)
        Else 'Si el usuario no tiene foto, mostrar imagen predeterminada de perfil.
            pictureBoxPhoto.Image = My.Resources.DefaultUserProfile
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEdit.Click
        Dim verifyForm = New FormVerifyUser(conectedUser.Password) 'Control de seguridad, autenticar usuario conectado.
        Dim resultVR As DialogResult = verifyForm.ShowDialog() 'Mostrar como ventana de dialogo y establecer el resultado.

        If resultVR = System.Windows.Forms.DialogResult.OK Then 'Si el resultado de dialogo es OK, mostrar el formulario de actualizar usuario.
            Dim userForm = New FormUserMaintenance(conectedUser, True) 'Instanciar formulario de mantenimiento y enviar parametros necesarios (modelo de usuario - SI es actualización de datos de perfil de usuario (TRUE))
            Dim resultUF As DialogResult = userForm.ShowDialog() 'Mostrar como ventana de dialogo y establecer el resultado.

            If resultUF = System.Windows.Forms.DialogResult.OK Then 'Si el resultado de dialogo es OK, actualizar vista.
                LoadUserData() 'Cargar datos de usuario.
                Dim mainForm As MainForm = CType(Application.OpenForms(1), MainForm) 'Obtener el formulario principal (El formulario login es [0], el formulario principal es [1], eso puede cambiar segun cuantos formularios se abrieron antes del formulario principal). 
                mainForm.LoadUserData(conectedUser) 'Actualizar vista del formulario principal.     
            End If
        End If
    End Sub
End Class