<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
    Inherits Presentation.BaseFixedForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblForgotPass = New System.Windows.Forms.Label()
        Me.lblErrorMessage = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(1, 715)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(398, 10)
        Me.Panel1.TabIndex = 32
        '
        'lblForgotPass
        '
        Me.lblForgotPass.AutoSize = True
        Me.lblForgotPass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblForgotPass.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForgotPass.ForeColor = System.Drawing.Color.DarkGray
        Me.lblForgotPass.Location = New System.Drawing.Point(83, 553)
        Me.lblForgotPass.Name = "lblForgotPass"
        Me.lblForgotPass.Size = New System.Drawing.Size(216, 17)
        Me.lblForgotPass.TabIndex = 30
        Me.lblForgotPass.Text = "¿Has olvidado tu contraseña?"
        '
        'lblErrorMessage
        '
        Me.lblErrorMessage.AutoSize = True
        Me.lblErrorMessage.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorMessage.ForeColor = System.Drawing.Color.IndianRed
        Me.lblErrorMessage.Image = CType(resources.GetObject("lblErrorMessage.Image"), System.Drawing.Image)
        Me.lblErrorMessage.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblErrorMessage.Location = New System.Drawing.Point(52, 414)
        Me.lblErrorMessage.MaximumSize = New System.Drawing.Size(290, 0)
        Me.lblErrorMessage.Name = "lblErrorMessage"
        Me.lblErrorMessage.Size = New System.Drawing.Size(88, 18)
        Me.lblErrorMessage.TabIndex = 31
        Me.lblErrorMessage.Text = "    Message"
        Me.lblErrorMessage.Visible = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnLogin.Location = New System.Drawing.Point(54, 467)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(285, 40)
        Me.btnLogin.TabIndex = 29
        Me.btnLogin.Text = "Acceder"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.Silver
        Me.txtPassword.Location = New System.Drawing.Point(55, 372)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(284, 26)
        Me.txtPassword.TabIndex = 11
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsername.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.Silver
        Me.txtUsername.Location = New System.Drawing.Point(55, 314)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(284, 26)
        Me.txtUsername.TabIndex = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(115, 68)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(183, 210)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(51, 348)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 21)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Contraseña"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(51, 290)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 21)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Nombre de usuario o Email"
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 726)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblForgotPass)
        Me.Controls.Add(Me.lblErrorMessage)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Controls.SetChildIndex(Me.txtUsername, 0)
        Me.Controls.SetChildIndex(Me.txtPassword, 0)
        Me.Controls.SetChildIndex(Me.btnLogin, 0)
        Me.Controls.SetChildIndex(Me.lblErrorMessage, 0)
        Me.Controls.SetChildIndex(Me.lblForgotPass, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents lblForgotPass As System.Windows.Forms.Label
    Private WithEvents lblErrorMessage As System.Windows.Forms.Label
    Private WithEvents btnLogin As System.Windows.Forms.Button
    Private WithEvents txtPassword As System.Windows.Forms.TextBox
    Private WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
