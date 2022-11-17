Public Class FormVerifyUser
    Inherits BaseFixedForm

    Private userPass As String

    Public Sub New(ByVal _userPass As String)
        InitializeComponent()
        txtUserPass.Select()
        lblMessage.Text = ""
        userPass = _userPass
    End Sub

    Private Sub VerifyConectedUser()
        If txtUserPass.Text = userPass Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            lblMessage.Text = "Su contraseña es incorrecto, vuelva a intentarlo"
        End If
    End Sub

    Private Sub btnOk_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOk.Click
        VerifyConectedUser()
    End Sub

    Private Sub txtUserPass_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtUserPass.KeyDown
        If e.KeyCode = Keys.Enter Then VerifyConectedUser()
    End Sub

End Class