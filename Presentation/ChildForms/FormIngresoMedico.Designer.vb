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
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblMaintenanceTitle = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnDeletePhoto = New System.Windows.Forms.Button()
        Me.btnAddPhoto = New System.Windows.Forms.Button()
        Me.label3 = New System.Windows.Forms.Label()
        Me.PictureBoxPhoto = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_direccion = New System.Windows.Forms.TextBox()
        Me.txt_celular = New System.Windows.Forms.TextBox()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txt_espe = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBoxPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMinimize
        '
        Me.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Image = Global.Presentation.My.Resources.Resources.btnMinimize
        Me.btnMinimize.Location = New System.Drawing.Point(684, 0)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(35, 40)
        Me.btnMinimize.TabIndex = 4
        Me.btnMinimize.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Image = Global.Presentation.My.Resources.Resources.btnClose
        Me.btnClose.Location = New System.Drawing.Point(719, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(35, 40)
        Me.btnClose.TabIndex = 3
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblMaintenanceTitle
        '
        Me.lblMaintenanceTitle.AutoSize = True
        Me.lblMaintenanceTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblMaintenanceTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaintenanceTitle.ForeColor = System.Drawing.Color.LightGray
        Me.lblMaintenanceTitle.Location = New System.Drawing.Point(12, 54)
        Me.lblMaintenanceTitle.Name = "lblMaintenanceTitle"
        Me.lblMaintenanceTitle.Size = New System.Drawing.Size(160, 26)
        Me.lblMaintenanceTitle.TabIndex = 149
        Me.lblMaintenanceTitle.Text = "Ingreso Medico"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.LightGray
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(129, 18)
        Me.lblTitle.TabIndex = 150
        Me.lblTitle.Text = "Ingreso Medicos"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(406, 309)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(150, 40)
        Me.btnSave.TabIndex = 169
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
        Me.btnCancel.Location = New System.Drawing.Point(230, 309)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(150, 40)
        Me.btnCancel.TabIndex = 170
        Me.btnCancel.Text = "X  Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnDeletePhoto
        '
        Me.btnDeletePhoto.BackColor = System.Drawing.Color.IndianRed
        Me.btnDeletePhoto.FlatAppearance.BorderSize = 0
        Me.btnDeletePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeletePhoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeletePhoto.ForeColor = System.Drawing.Color.White
        Me.btnDeletePhoto.Location = New System.Drawing.Point(168, 251)
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
        Me.btnAddPhoto.Location = New System.Drawing.Point(137, 251)
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
        Me.label3.Location = New System.Drawing.Point(46, 255)
        Me.label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(86, 16)
        Me.label3.TabIndex = 168
        Me.label3.Text = "Cambiar foto:"
        '
        'PictureBoxPhoto
        '
        Me.PictureBoxPhoto.Image = Global.Presentation.My.Resources.Resources.DefaultUserProfile
        Me.PictureBoxPhoto.Location = New System.Drawing.Point(43, 97)
        Me.PictureBoxPhoto.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBoxPhoto.Name = "PictureBoxPhoto"
        Me.PictureBoxPhoto.Size = New System.Drawing.Size(150, 150)
        Me.PictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxPhoto.TabIndex = 167
        Me.PictureBoxPhoto.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(478, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 158
        Me.Label1.Text = "Direccion"
        '
        'txt_direccion
        '
        Me.txt_direccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.txt_direccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_direccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_direccion.ForeColor = System.Drawing.Color.LightGray
        Me.txt_direccion.Location = New System.Drawing.Point(481, 111)
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(230, 22)
        Me.txt_direccion.TabIndex = 155
        '
        'txt_celular
        '
        Me.txt_celular.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.txt_celular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_celular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_celular.ForeColor = System.Drawing.Color.LightGray
        Me.txt_celular.Location = New System.Drawing.Point(481, 161)
        Me.txt_celular.Name = "txt_celular"
        Me.txt_celular.Size = New System.Drawing.Size(230, 22)
        Me.txt_celular.TabIndex = 156
        Me.txt_celular.UseSystemPasswordChar = True
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.BackColor = System.Drawing.Color.Transparent
        Me.lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.Color.DarkGray
        Me.lbl2.Location = New System.Drawing.Point(220, 192)
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
        Me.lblPassword.Location = New System.Drawing.Point(478, 142)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(49, 16)
        Me.lblPassword.TabIndex = 159
        Me.lblPassword.Text = "Celular"
        '
        'txt_espe
        '
        Me.txt_espe.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.txt_espe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_espe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_espe.ForeColor = System.Drawing.Color.LightGray
        Me.txt_espe.Location = New System.Drawing.Point(223, 211)
        Me.txt_espe.Name = "txt_espe"
        Me.txt_espe.Size = New System.Drawing.Size(230, 22)
        Me.txt_espe.TabIndex = 153
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkGray
        Me.Label5.Location = New System.Drawing.Point(220, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 16)
        Me.Label5.TabIndex = 161
        Me.Label5.Text = "Apellido:"
        '
        'txt_apellido
        '
        Me.txt_apellido.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.txt_apellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_apellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_apellido.ForeColor = System.Drawing.Color.LightGray
        Me.txt_apellido.Location = New System.Drawing.Point(223, 161)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(230, 22)
        Me.txt_apellido.TabIndex = 152
        '
        'txt_nombre
        '
        Me.txt_nombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre.ForeColor = System.Drawing.Color.LightGray
        Me.txt_nombre.Location = New System.Drawing.Point(223, 111)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(230, 22)
        Me.txt_nombre.TabIndex = 151
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGray
        Me.Label4.Location = New System.Drawing.Point(220, 92)
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
        Me.Controls.Add(Me.btnDeletePhoto)
        Me.Controls.Add(Me.btnAddPhoto)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.PictureBoxPhoto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_direccion)
        Me.Controls.Add(Me.txt_celular)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txt_espe)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_apellido)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblMaintenanceTitle)
        Me.Name = "FormIngresoMedico"
        Me.Text = "FormIngresoMedico"
        Me.Controls.SetChildIndex(Me.lblMaintenanceTitle, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.txt_nombre, 0)
        Me.Controls.SetChildIndex(Me.txt_apellido, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.txt_espe, 0)
        Me.Controls.SetChildIndex(Me.lblPassword, 0)
        Me.Controls.SetChildIndex(Me.lbl2, 0)
        Me.Controls.SetChildIndex(Me.txt_celular, 0)
        Me.Controls.SetChildIndex(Me.txt_direccion, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.PictureBoxPhoto, 0)
        Me.Controls.SetChildIndex(Me.label3, 0)
        Me.Controls.SetChildIndex(Me.btnAddPhoto, 0)
        Me.Controls.SetChildIndex(Me.btnDeletePhoto, 0)
        Me.Controls.SetChildIndex(Me.btnCancel, 0)
        Me.Controls.SetChildIndex(Me.btnSave, 0)
        CType(Me.PictureBoxPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMaintenanceTitle As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnDeletePhoto As Button
    Friend WithEvents btnAddPhoto As Button
    Friend WithEvents label3 As Label
    Friend WithEvents PictureBoxPhoto As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_direccion As TextBox
    Friend WithEvents txt_celular As TextBox
    Friend WithEvents lbl2 As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txt_espe As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_apellido As TextBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents Label4 As Label
    Private WithEvents btnMinimize As Button
    Private WithEvents btnClose As Button
    Friend WithEvents lblTitle As Label
End Class
