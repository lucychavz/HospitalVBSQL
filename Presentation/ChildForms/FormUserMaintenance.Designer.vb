<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUserMaintenance
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
        Me.btnDeletePhoto = New System.Windows.Forms.Button()
        Me.btnAddPhoto = New System.Windows.Forms.Button()
        Me.label3 = New System.Windows.Forms.Label()
        Me.PictureBoxPhoto = New System.Windows.Forms.PictureBox()
        Me.txtConfirmPass = New System.Windows.Forms.TextBox()
        Me.lblConfirmPass = New System.Windows.Forms.Label()
        Me.cmbPosition = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblMaintenanceTitle = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        CType(Me.PictureBoxPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDeletePhoto
        '
        Me.btnDeletePhoto.BackColor = System.Drawing.Color.IndianRed
        Me.btnDeletePhoto.FlatAppearance.BorderSize = 0
        Me.btnDeletePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeletePhoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeletePhoto.ForeColor = System.Drawing.Color.White
        Me.btnDeletePhoto.Location = New System.Drawing.Point(168, 247)
        Me.btnDeletePhoto.Name = "btnDeletePhoto"
        Me.btnDeletePhoto.Size = New System.Drawing.Size(25, 25)
        Me.btnDeletePhoto.TabIndex = 145
        Me.btnDeletePhoto.Text = "-"
        Me.btnDeletePhoto.UseVisualStyleBackColor = False
        '
        'btnAddPhoto
        '
        Me.btnAddPhoto.BackColor = System.Drawing.Color.SeaGreen
        Me.btnAddPhoto.FlatAppearance.BorderSize = 0
        Me.btnAddPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddPhoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPhoto.ForeColor = System.Drawing.Color.White
        Me.btnAddPhoto.Location = New System.Drawing.Point(137, 247)
        Me.btnAddPhoto.Name = "btnAddPhoto"
        Me.btnAddPhoto.Size = New System.Drawing.Size(25, 25)
        Me.btnAddPhoto.TabIndex = 144
        Me.btnAddPhoto.Text = "+"
        Me.btnAddPhoto.UseVisualStyleBackColor = False
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.BackColor = System.Drawing.Color.Transparent
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.DarkGray
        Me.label3.Location = New System.Drawing.Point(46, 251)
        Me.label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(87, 16)
        Me.label3.TabIndex = 147
        Me.label3.Text = "Cambiar foto:"
        '
        'PictureBoxPhoto
        '
        Me.PictureBoxPhoto.Image = Global.Presentation.My.Resources.Resources.DefaultUserProfile
        Me.PictureBoxPhoto.Location = New System.Drawing.Point(43, 93)
        Me.PictureBoxPhoto.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBoxPhoto.Name = "PictureBoxPhoto"
        Me.PictureBoxPhoto.Size = New System.Drawing.Size(150, 150)
        Me.PictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxPhoto.TabIndex = 146
        Me.PictureBoxPhoto.TabStop = False
        '
        'txtConfirmPass
        '
        Me.txtConfirmPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.txtConfirmPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConfirmPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPass.ForeColor = System.Drawing.Color.LightGray
        Me.txtConfirmPass.Location = New System.Drawing.Point(481, 207)
        Me.txtConfirmPass.Name = "txtConfirmPass"
        Me.txtConfirmPass.Size = New System.Drawing.Size(230, 22)
        Me.txtConfirmPass.TabIndex = 134
        Me.txtConfirmPass.UseSystemPasswordChar = True
        '
        'lblConfirmPass
        '
        Me.lblConfirmPass.AutoSize = True
        Me.lblConfirmPass.BackColor = System.Drawing.Color.Transparent
        Me.lblConfirmPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmPass.ForeColor = System.Drawing.Color.DarkGray
        Me.lblConfirmPass.Location = New System.Drawing.Point(478, 188)
        Me.lblConfirmPass.Name = "lblConfirmPass"
        Me.lblConfirmPass.Size = New System.Drawing.Size(138, 16)
        Me.lblConfirmPass.TabIndex = 142
        Me.lblConfirmPass.Text = "Confirmar contraseña:"
        '
        'cmbPosition
        '
        Me.cmbPosition.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.cmbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPosition.ForeColor = System.Drawing.Color.Silver
        Me.cmbPosition.FormattingEnabled = True
        Me.cmbPosition.Location = New System.Drawing.Point(223, 258)
        Me.cmbPosition.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbPosition.Name = "cmbPosition"
        Me.cmbPosition.Size = New System.Drawing.Size(230, 24)
        Me.cmbPosition.TabIndex = 131
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkGray
        Me.Label6.Location = New System.Drawing.Point(220, 238)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 16)
        Me.Label6.TabIndex = 141
        Me.Label6.Text = "Cargo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(478, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 16)
        Me.Label1.TabIndex = 136
        Me.Label1.Text = "Nombre de usuario:"
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.LightGray
        Me.txtUsername.Location = New System.Drawing.Point(481, 107)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(230, 22)
        Me.txtUsername.TabIndex = 132
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.LightGray
        Me.txtPassword.Location = New System.Drawing.Point(481, 157)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(230, 22)
        Me.txtPassword.TabIndex = 133
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.BackColor = System.Drawing.Color.Transparent
        Me.lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.Color.DarkGray
        Me.lbl2.Location = New System.Drawing.Point(220, 188)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(45, 16)
        Me.lbl2.TabIndex = 140
        Me.lbl2.Text = "Email:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.DarkGray
        Me.lblPassword.Location = New System.Drawing.Point(478, 138)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(80, 16)
        Me.lblPassword.TabIndex = 137
        Me.lblPassword.Text = "Contraseña:"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.LightGray
        Me.txtEmail.Location = New System.Drawing.Point(223, 207)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(230, 22)
        Me.txtEmail.TabIndex = 130
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkGray
        Me.Label5.Location = New System.Drawing.Point(220, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 16)
        Me.Label5.TabIndex = 139
        Me.Label5.Text = "Apellido:"
        '
        'txtLastName
        '
        Me.txtLastName.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.ForeColor = System.Drawing.Color.LightGray
        Me.txtLastName.Location = New System.Drawing.Point(223, 157)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(230, 22)
        Me.txtLastName.TabIndex = 129
        '
        'txtFirstName
        '
        Me.txtFirstName.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.ForeColor = System.Drawing.Color.LightGray
        Me.txtFirstName.Location = New System.Drawing.Point(223, 107)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(230, 22)
        Me.txtFirstName.TabIndex = 128
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGray
        Me.Label4.Location = New System.Drawing.Point(220, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 16)
        Me.Label4.TabIndex = 138
        Me.Label4.Text = "Nombre:"
        '
        'lblMaintenanceTitle
        '
        Me.lblMaintenanceTitle.AutoSize = True
        Me.lblMaintenanceTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblMaintenanceTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaintenanceTitle.ForeColor = System.Drawing.Color.LightGray
        Me.lblMaintenanceTitle.Location = New System.Drawing.Point(25, 54)
        Me.lblMaintenanceTitle.Name = "lblMaintenanceTitle"
        Me.lblMaintenanceTitle.Size = New System.Drawing.Size(155, 26)
        Me.lblMaintenanceTitle.TabIndex = 148
        Me.lblMaintenanceTitle.Text = "Mantenimiento"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(406, 305)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(150, 40)
        Me.btnSave.TabIndex = 149
        Me.btnSave.Text = "Guardar"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(230, 305)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(150, 40)
        Me.btnCancel.TabIndex = 150
        Me.btnCancel.Text = "X  Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'FormUserMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(754, 370)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblMaintenanceTitle)
        Me.Controls.Add(Me.btnDeletePhoto)
        Me.Controls.Add(Me.btnAddPhoto)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.PictureBoxPhoto)
        Me.Controls.Add(Me.txtConfirmPass)
        Me.Controls.Add(Me.lblConfirmPass)
        Me.Controls.Add(Me.cmbPosition)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.Label4)
        Me.Name = "FormUserMaintenance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Formulario mantenimiento"
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.txtFirstName, 0)
        Me.Controls.SetChildIndex(Me.txtLastName, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.txtEmail, 0)
        Me.Controls.SetChildIndex(Me.lblPassword, 0)
        Me.Controls.SetChildIndex(Me.lbl2, 0)
        Me.Controls.SetChildIndex(Me.txtPassword, 0)
        Me.Controls.SetChildIndex(Me.txtUsername, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.cmbPosition, 0)
        Me.Controls.SetChildIndex(Me.lblConfirmPass, 0)
        Me.Controls.SetChildIndex(Me.txtConfirmPass, 0)
        Me.Controls.SetChildIndex(Me.PictureBoxPhoto, 0)
        Me.Controls.SetChildIndex(Me.label3, 0)
        Me.Controls.SetChildIndex(Me.btnAddPhoto, 0)
        Me.Controls.SetChildIndex(Me.btnDeletePhoto, 0)
        Me.Controls.SetChildIndex(Me.lblMaintenanceTitle, 0)
        Me.Controls.SetChildIndex(Me.btnCancel, 0)
        Me.Controls.SetChildIndex(Me.btnSave, 0)
        CType(Me.PictureBoxPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDeletePhoto As System.Windows.Forms.Button
    Friend WithEvents btnAddPhoto As System.Windows.Forms.Button
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBoxPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents txtConfirmPass As System.Windows.Forms.TextBox
    Friend WithEvents lblConfirmPass As System.Windows.Forms.Label
    Friend WithEvents cmbPosition As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblMaintenanceTitle As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
