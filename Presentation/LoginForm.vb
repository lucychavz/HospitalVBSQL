Imports Domain
Imports Common

Public Class LoginForm
    Inherits BaseFixedForm
    ''' <summary>
    ''' Esta clase hereda de la clase BaseFixedForm.
    ''' </summary>
    ''' 


#Region "-> Constructor"
    Public Sub New()
        InitializeComponent()
        txtUsername.Select()
        Me.MinimizeButton = True 'Mostrar boton de minimizar
    End Sub
#End Region

#Region "-> Métodos"

    Private Sub Login()

        'Validar campos
        If String.IsNullOrWhiteSpace(txtUsername.Text) Then
            ShowMessage("Ingrese nombre de usuario o correo electrónico")
            Return
        End If

        If String.IsNullOrWhiteSpace(txtPassword.Text) Then
            ShowMessage("Ingrese contraseña")
            Return
        End If
        'Fin Validar campos

        'Ejecutar el metodo de inicio de sesión del modelo de dominio.
        Dim userModel = New UserModel().Login(txtUsername.Text, txtPassword.Text) 'Devuelve un objeto UserModel como resultado.

        If userModel IsNot Nothing Then 'Si el inicio de sesión fue exitosa.            

            'Nota: Esto es solamente un ejemplo de demostración, ya que si el sistema es demasiado grande, 
            'se suele mostrar un formulario de menu principal diferente para cada area o cargo.
            'Puedes eliminar las condicionales y mostrar un formulario único*/

            Dim mainForm As Form 'Definir el campo para el formulario principal.

            If ActiveUser.Position = Positions.GeneralManager OrElse ActiveUser.Position = Positions.Accountant OrElse ActiveUser.Position = Positions.AdministrativeAssistant OrElse ActiveUser.Position = Positions.SystemAdministrator Then
                mainForm = New MainForm(userModel) 'Enviar el modelo de vista del usuario conectado, para mostrar sus datos en el formulario principal. 
            ElseIf ActiveUser.Position = Positions.HMR Then
                mainForm = New FormUsers()
            ElseIf ActiveUser.Position = Positions.Receptionist Then
                mainForm = New FormPacients()
            ElseIf ActiveUser.Position = Positions.MarketingGuru Then
                mainForm = New FormReports()
            Else
                mainForm = Nothing
                MessageBox.Show("Usted no tiene un cargo asignado, no puede iniciar sesión.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                Return
            End If

            Me.Hide() 'Ocultar el formualario login.
            Dim welcomeForm = New WelcomeForm(userModel.FullName) 'Mostrar el formulario de bienvenida.
            welcomeForm.ShowDialog()
            AddHandler mainForm.FormClosed, AddressOf MainForm_SessionClosed 'Asociar el evento cerrado, para limpiar el formulario login cuando se cierre sesion desde el formulario principal.
            mainForm.Show() 'Mostrar el formulario principal.

        Else 'Si el inicio de sesión NO fue exitosa, mostrar mensaje.
            ShowMessage("Usuario o contraseña incorrecto")
        End If
    End Sub

    Private Sub Logout()
        'Limpiar campos cuando se cierre sesión, este metodo se invoca en el metodo de evento MainForm_SessionClosed(..).
        Me.Show() 'Volver a mostrar el formulario login. 
        lblErrorMessage.Visible = False
        txtPassword.Clear()
        txtUsername.Clear()
        txtUsername.Focus()
    End Sub

    Private Sub ShowMessage(message As String)
        lblErrorMessage.Text = "    " & message
        lblErrorMessage.Visible = True
    End Sub
#End Region

#Region "-> Métodos de Evento"
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Login() 'Invocar el método Iniciar sesión.
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        'Invocar el método Iniciar sesión, si preciona enter en el cuadro de texto contraseña.
        If e.KeyCode = Keys.Enter Then Login()
    End Sub

    Private Sub MainForm_SessionClosed(sender As Object, e As FormClosedEventArgs)
        Logout() 'Invocar el método Cerrar sesión cuando en el formulario principal se haya cerrado sesión.
    End Sub


    Private Sub lblForgotPass_Click(sender As Object, e As EventArgs) Handles lblForgotPass.Click
        'Recuperar contraseña.
        Dim frm = New FormRecoverPassword()
        frm.ShowDialog()
    End Sub
#End Region

#Region "-> Anulaciones"
    Protected Overrides Sub CloseForm()
        Application.Exit() 'Anular el metodo cerrar formulario y cerrar la aplicación.
    End Sub

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        'Anular los parámetros de creación de formularios
        Get
            Dim param As CreateParams = MyBase.CreateParams
            param.Style = param.Style Or &H20000  'Establece un cuadro de minimizar en el estilo de la ventana / Permitirá minimizar el formulario desde el icono de la barra de tareas.
            Return param
        End Get
    End Property
#End Region

    Private Sub btnLogin_Paint(sender As Object, e As PaintEventArgs) Handles btnLogin.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = btnLogin.ClientRectangle
        myRectangle.Inflate(0, 30)
        buttonPath.AddEllipse(myRectangle)
        btnLogin.Region = New Region(buttonPath)
    End Sub
End Class
