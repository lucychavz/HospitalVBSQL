Imports Domain
Imports Common

Public Class FormUserMaintenance
    Inherits BaseFixedForm

    ''' <summary>
    ''' Esta clase hereda de la clase BaseFixedForm.
    ''' </summary>
    ''' 

#Region "-> Campos"
    Private userModel As UserModel 'Obtiene o establece el modelo de dominio de usuario.
    Private userModify As Boolean 'Obtiene o establece un usuario será editado.
    Private userId As Integer 'Obtiene o establece el id del usuario a editar.
    Private defaultPhoto As Image = My.Resources.DefaultUserProfile 'Foto predeterminada para usuarios que no tienen una foto agregada.
#End Region

#Region "-> Constructores"
    Public Sub New()
        'Utilice este constructor cuando desee agregar un nuevo usuario.
        InitializeComponent()
        lblMaintenanceTitle.Text = "Agregar nuevo usuario"
        userModel = New UserModel() 'Inicializar modelo de dominio de usuario.
        userModify = False 'Establecer userModify en falso.
        PictureBoxPhoto.Image = defaultPhoto 'Establecer la foto predeterminada para los usuarios sin foto.
        cmbPosition.DataSource = Positions.GetPositions() 'Establecer lista de cargos.
        cmbPosition.SelectedIndex = -1 'Sin seleccion de indice.
    End Sub

    Public Sub New(ByVal _userModel As UserModel, ByVal isUserProfile As Boolean)
        'Utilice este constructor cuando desee editar un usuario o actualizar el perfil de usuario.
        InitializeComponent()
        Me.TitleBarColor = Color.MediumSeaGreen
        btnSave.BackColor = Color.MediumSeaGreen
        cmbPosition.DataSource = Positions.GetPositions()

        userModel = _userModel 'Establecer modelo de dominio de usuario.
        userModify = True 'Establecer userModify en verdadero.
        FillFields() 'LLenar los campos del formulario con el modelo de usuario (Ver metodo).

        If isUserProfile Then 'Si la edicion es del perfil de usuario, cambiar titulo y desactivar los cargos.
            lblMaintenanceTitle.Text = "Actualizar mi perfil de usuario"
            cmbPosition.Visible = False
            Label6.Visible = False
        Else 'Caso contrario mostrar titulo  modificar usuario.
            lblMaintenanceTitle.Text = "Modificar usuario"
        End If
    End Sub
#End Region

#Region "-> Metodos"
    Private Sub FillFields()
        'Cargar los datos del modelo  en los campos del formulario.
        userId = userModel.Id
        txtUsername.Text = userModel.Username
        txtPassword.Text = userModel.Password
        txtConfirmPass.Text = userModel.Password
        txtFirstName.Text = userModel.FirstName
        txtLastName.Text = userModel.LastName
        cmbPosition.Text = userModel.Position
        txtEmail.Text = userModel.Email

        If userModel.Photo IsNot Nothing Then
            PictureBoxPhoto.Image = ItemConverter.BinaryToImage(userModel.Photo)
        Else
            PictureBoxPhoto.Image = defaultPhoto
        End If
    End Sub

    Private Sub FillUserModel()
        'LLenar modelo
        userModel.Id = userId
        userModel.Username = txtUsername.Text
        userModel.Password = txtPassword.Text
        userModel.FirstName = txtFirstName.Text
        userModel.LastName = txtLastName.Text
        userModel.Position = cmbPosition.Text
        userModel.Email = txtEmail.Text

        If PictureBoxPhoto.Image Is defaultPhoto Then
            userModel.Photo = Nothing
        Else
            userModel.Photo = ItemConverter.ImageToBinary(PictureBoxPhoto.Image)
        End If
    End Sub

    Private Sub Save()
        'Guardar cambios.

        Dim result As Integer = -1

        Try
            FillUserModel() 'Obtener modelo de vista.
            Dim validateData = New DataValidation(userModel) 'Validar campos del objeto.
            Dim validatePassword = txtPassword.Text = txtConfirmPass.Text 'Validar contraseñas.

            If validateData.Result = True AndAlso validatePassword = True Then 'Si el objeto y contraseña es válido.

                'EDITAR USUARIO
                If userModify = True Then
                    result = userModel.ModifyUser() 'Invocar metodo ModifyUser del modelo de usuario.

                    If result > 0 Then
                        MessageBox.Show("Usuario actualizado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.DialogResult = System.Windows.Forms.DialogResult.OK ' Establecer Ok como resultado de dialogo del formulario.
                        Me.Close() 'Cerrar formulario
                    Else
                        MessageBox.Show("No se realizó la operación, intente nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If

                    'AGREGAR USUARIO
                Else
                    result = userModel.CreateUser() 'Invocar metodo CreateUser del modelo de usuario.

                    If result > 0 Then
                        MessageBox.Show("Usuario agregado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.DialogResult = System.Windows.Forms.DialogResult.OK 'Establecer Ok como resultado de dialogo del formulario.
                        Me.Close() 'Cerrar formulario.
                    Else
                        MessageBox.Show("No se realizó la operación, intente nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                End If

            Else 'Si el objeto o contraseña NO es válido, mostrar mensaje segun el caso.

                If validateData.Result = False Then
                    MessageBox.Show(validateData.ErrorMessage, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    MessageBox.Show("Las contraseñas no coinciden", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If

        Catch ex As Exception
            Dim message = ExceptionManager.GetMessage(ex) 'Obtener mensaje de excepción.
            MessageBox.Show(message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error) 'Mostrar mensaje.
        End Try
    End Sub
#End Region

#Region "-> Metodos de evento"
    Private Sub FormUserMaintenance_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        Save() 'Guardar cambios.
    End Sub

    Private Sub btnAddPhoto_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddPhoto.Click
        'Agregar una imagen al cuadro de imagen para la foto del usuario.
        Dim openFile As OpenFileDialog = New OpenFileDialog()
        openFile.Filter = "Images(.jpg,.png)|*.png;*.jpg"

        If openFile.ShowDialog() = DialogResult.OK Then
            PictureBoxPhoto.Image = New Bitmap(openFile.FileName)
        End If
    End Sub

    Private Sub btnDeletePhoto_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDeletePhoto.Click
        'Borrar foto del usuario
        PictureBoxPhoto.Image = defaultPhoto
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        Me.Close() 'Cerrar formulario
    End Sub
#End Region
End Class