<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUserProfile
    Inherits System.Windows.Forms.Form

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
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.lblFullname = New System.Windows.Forms.Label()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblMail = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pictureBoxPhoto = New System.Windows.Forms.PictureBox()
        CType(Me.pictureBoxPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(216, 400)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(183, 38)
        Me.btnEdit.TabIndex = 100
        Me.btnEdit.Text = "Editar"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.Color.DarkGray
        Me.label4.Location = New System.Drawing.Point(213, 364)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(156, 17)
        Me.label4.TabIndex = 99
        Me.label4.Text = "Av. Los Morales Nº 127"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.ForeColor = System.Drawing.Color.LightGray
        Me.label5.Location = New System.Drawing.Point(212, 344)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(79, 20)
        Me.label5.TabIndex = 98
        Me.label5.Text = "Dirección:"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.DarkGray
        Me.label2.Location = New System.Drawing.Point(213, 318)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(158, 17)
        Me.label2.TabIndex = 97
        Me.label2.Text = "02 de Octubre del 2000"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.LightGray
        Me.label3.Location = New System.Drawing.Point(212, 298)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(161, 20)
        Me.label3.TabIndex = 96
        Me.label3.Text = "Fecha de nacimiento:"
        '
        'lblFullname
        '
        Me.lblFullname.AutoSize = True
        Me.lblFullname.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullname.ForeColor = System.Drawing.Color.LightGray
        Me.lblFullname.Location = New System.Drawing.Point(199, 26)
        Me.lblFullname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFullname.Name = "lblFullname"
        Me.lblFullname.Size = New System.Drawing.Size(108, 26)
        Me.lblFullname.TabIndex = 95
        Me.lblFullname.Text = "Full name"
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosition.ForeColor = System.Drawing.Color.DarkGray
        Me.lblPosition.Location = New System.Drawing.Point(213, 271)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(57, 17)
        Me.lblPosition.TabIndex = 94
        Me.lblPosition.Text = "position"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.LightGray
        Me.Label12.Location = New System.Drawing.Point(212, 251)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 20)
        Me.Label12.TabIndex = 93
        Me.Label12.Text = "Position:"
        '
        'lblMail
        '
        Me.lblMail.AutoSize = True
        Me.lblMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMail.ForeColor = System.Drawing.Color.DarkGray
        Me.lblMail.Location = New System.Drawing.Point(213, 225)
        Me.lblMail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(33, 17)
        Me.lblMail.TabIndex = 92
        Me.lblMail.Text = "mail"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.ForeColor = System.Drawing.Color.DarkGray
        Me.lblLastName.Location = New System.Drawing.Point(213, 175)
        Me.lblLastName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(67, 17)
        Me.lblLastName.TabIndex = 91
        Me.lblLastName.Text = "lastName"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.DarkGray
        Me.lblName.Location = New System.Drawing.Point(213, 129)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(43, 17)
        Me.lblName.TabIndex = 90
        Me.lblName.Text = "name"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.DarkGray
        Me.lblUsername.Location = New System.Drawing.Point(213, 83)
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(36, 17)
        Me.lblUsername.TabIndex = 89
        Me.lblUsername.Text = "user"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LightGray
        Me.Label6.Location = New System.Drawing.Point(212, 63)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 20)
        Me.Label6.TabIndex = 85
        Me.Label6.Text = "Username:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LightGray
        Me.Label8.Location = New System.Drawing.Point(212, 205)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 20)
        Me.Label8.TabIndex = 88
        Me.Label8.Text = "Email:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.LightGray
        Me.Label9.Location = New System.Drawing.Point(212, 155)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 20)
        Me.Label9.TabIndex = 87
        Me.Label9.Text = "Last name:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.LightGray
        Me.Label10.Location = New System.Drawing.Point(211, 109)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 20)
        Me.Label10.TabIndex = 86
        Me.Label10.Text = "First name:"
        '
        'pictureBoxPhoto
        '
        Me.pictureBoxPhoto.Image = Global.Presentation.My.Resources.Resources.DefaultUserProfile
        Me.pictureBoxPhoto.Location = New System.Drawing.Point(27, 26)
        Me.pictureBoxPhoto.Margin = New System.Windows.Forms.Padding(4)
        Me.pictureBoxPhoto.Name = "pictureBoxPhoto"
        Me.pictureBoxPhoto.Size = New System.Drawing.Size(164, 162)
        Me.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBoxPhoto.TabIndex = 84
        Me.pictureBoxPhoto.TabStop = False
        '
        'FormUserProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(968, 528)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.lblFullname)
        Me.Controls.Add(Me.lblPosition)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblMail)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.pictureBoxPhoto)
        Me.Name = "FormUserProfile"
        Me.Text = "Mi perfil de usuario"
        CType(Me.pictureBoxPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents label4 As System.Windows.Forms.Label
    Friend WithEvents label5 As System.Windows.Forms.Label
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents lblFullname As System.Windows.Forms.Label
    Friend WithEvents lblPosition As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblMail As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents pictureBoxPhoto As System.Windows.Forms.PictureBox
End Class
