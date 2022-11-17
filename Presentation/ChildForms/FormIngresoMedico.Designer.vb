<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormIngresoMedico
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.btnMinimize = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblMaintenanceTitle = New System.Windows.Forms.Label()
        Me.btnDeletePhoto = New System.Windows.Forms.Button()
        Me.btnAddPhoto = New System.Windows.Forms.Button()
        Me.label3 = New System.Windows.Forms.Label()
        Me.PictureBoxPhoto = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.btnMinimize)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(754, 40)
        Me.Panel1.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.Image = Global.Presentation.My.Resources.Resources.btnClose
        Me.btnClose.Location = New System.Drawing.Point(714, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(40, 40)
        Me.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnClose.TabIndex = 2
        Me.btnClose.TabStop = False
        '
        'btnMinimize
        '
        Me.btnMinimize.Image = Global.Presentation.My.Resources.Resources.btnMinimize
        Me.btnMinimize.Location = New System.Drawing.Point(668, 0)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(40, 40)
        Me.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnMinimize.TabIndex = 1
        Me.btnMinimize.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Formulario de ingreso Medico"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(409, 308)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(150, 40)
        Me.btnSave.TabIndex = 170
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
        Me.btnCancel.Location = New System.Drawing.Point(233, 308)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(150, 40)
        Me.btnCancel.TabIndex = 171
        Me.btnCancel.Text = "X  Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'lblMaintenanceTitle
        '
        Me.lblMaintenanceTitle.AutoSize = True
        Me.lblMaintenanceTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblMaintenanceTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaintenanceTitle.ForeColor = System.Drawing.Color.LightGray
        Me.lblMaintenanceTitle.Location = New System.Drawing.Point(28, 57)
        Me.lblMaintenanceTitle.Name = "lblMaintenanceTitle"
        Me.lblMaintenanceTitle.Size = New System.Drawing.Size(160, 26)
        Me.lblMaintenanceTitle.TabIndex = 169
        Me.lblMaintenanceTitle.Text = "Ingreso Medico"
        '
        'btnDeletePhoto
        '
        Me.btnDeletePhoto.BackColor = System.Drawing.Color.IndianRed
        Me.btnDeletePhoto.FlatAppearance.BorderSize = 0
        Me.btnDeletePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeletePhoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeletePhoto.ForeColor = System.Drawing.Color.White
        Me.btnDeletePhoto.Location = New System.Drawing.Point(171, 250)
        Me.btnDeletePhoto.Name = "btnDeletePhoto"
        Me.btnDeletePhoto.Size = New System.Drawing.Size(25, 25)
        Me.btnDeletePhoto.TabIndex = 166
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
        Me.btnAddPhoto.Location = New System.Drawing.Point(140, 250)
        Me.btnAddPhoto.Name = "btnAddPhoto"
        Me.btnAddPhoto.Size = New System.Drawing.Size(25, 25)
        Me.btnAddPhoto.TabIndex = 165
        Me.btnAddPhoto.Text = "+"
        Me.btnAddPhoto.UseVisualStyleBackColor = False
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.BackColor = System.Drawing.Color.Transparent
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.DarkGray
        Me.label3.Location = New System.Drawing.Point(49, 254)
        Me.label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(86, 16)
        Me.label3.TabIndex = 168
        Me.label3.Text = "Cambiar foto:"
        '
        'PictureBoxPhoto
        '
        Me.PictureBoxPhoto.Image = Global.Presentation.My.Resources.Resources.DefaultUserProfile
        Me.PictureBoxPhoto.Location = New System.Drawing.Point(46, 96)
        Me.PictureBoxPhoto.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBoxPhoto.Name = "PictureBoxPhoto"
        Me.PictureBoxPhoto.Size = New System.Drawing.Size(150, 150)
        Me.PictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxPhoto.TabIndex = 167
        Me.PictureBoxPhoto.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(481, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 158
        Me.Label2.Text = "Direccion"
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.LightGray
        Me.txtUsername.Location = New System.Drawing.Point(484, 110)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(230, 22)
        Me.txtUsername.TabIndex = 155
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.LightGray
        Me.txtPassword.Location = New System.Drawing.Point(484, 160)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(230, 22)
        Me.txtPassword.TabIndex = 156
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.BackColor = System.Drawing.Color.Transparent
        Me.lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.Color.DarkGray
        Me.lbl2.Location = New System.Drawing.Point(223, 191)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(87, 16)
        Me.lbl2.TabIndex = 162
        Me.lbl2.Text = "Especialidad"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.DarkGray
        Me.lblPassword.Location = New System.Drawing.Point(481, 141)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(49, 16)
        Me.lblPassword.TabIndex = 159
        Me.lblPassword.Text = "Celular"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.LightGray
        Me.txtEmail.Location = New System.Drawing.Point(226, 210)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(230, 22)
        Me.txtEmail.TabIndex = 153
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkGray
        Me.Label5.Location = New System.Drawing.Point(223, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 16)
        Me.Label5.TabIndex = 161
        Me.Label5.Text = "Apellido:"
        '
        'txtLastName
        '
        Me.txtLastName.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.ForeColor = System.Drawing.Color.LightGray
        Me.txtLastName.Location = New System.Drawing.Point(226, 160)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(230, 22)
        Me.txtLastName.TabIndex = 152
        '
        'txtFirstName
        '
        Me.txtFirstName.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.ForeColor = System.Drawing.Color.LightGray
        Me.txtFirstName.Location = New System.Drawing.Point(226, 110)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(230, 22)
        Me.txtFirstName.TabIndex = 151
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGray
        Me.Label4.Location = New System.Drawing.Point(223, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 16)
        Me.Label4.TabIndex = 160
        Me.Label4.Text = "Nombre:"
        '
        'FormIngresoMedico
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
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormIngresoMedico"
        Me.Text = "FormIngresoMedico"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnMinimize As PictureBox
    Friend WithEvents btnClose As PictureBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblMaintenanceTitle As Label
    Friend WithEvents btnDeletePhoto As Button
    Friend WithEvents btnAddPhoto As Button
    Friend WithEvents label3 As Label
    Friend WithEvents PictureBoxPhoto As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lbl2 As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label4 As Label
End Class
