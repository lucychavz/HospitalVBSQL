<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVerifyUser
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
        Me.label1 = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.txtUserPass = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.Silver
        Me.label1.Location = New System.Drawing.Point(28, 53)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(238, 16)
        Me.label1.TabIndex = 134
        Me.label1.Text = "Ingrese su contraseña actual por favor:"
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.Color.IndianRed
        Me.lblMessage.Location = New System.Drawing.Point(28, 95)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(65, 16)
        Me.lblMessage.TabIndex = 133
        Me.lblMessage.Text = "Message"
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnOk.FlatAppearance.BorderSize = 0
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.Color.White
        Me.btnOk.Location = New System.Drawing.Point(156, 124)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(150, 40)
        Me.btnOk.TabIndex = 11
        Me.btnOk.Text = "Aceptar"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'txtUserPass
        '
        Me.txtUserPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.txtUserPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserPass.ForeColor = System.Drawing.Color.LightGray
        Me.txtUserPass.Location = New System.Drawing.Point(31, 72)
        Me.txtUserPass.Name = "txtUserPass"
        Me.txtUserPass.Size = New System.Drawing.Size(403, 20)
        Me.txtUserPass.TabIndex = 10
        Me.txtUserPass.UseSystemPasswordChar = True
        '
        'FormVerifyUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(471, 198)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.txtUserPass)
        Me.Name = "FormVerifyUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Control de seguridad"
        Me.Controls.SetChildIndex(Me.txtUserPass, 0)
        Me.Controls.SetChildIndex(Me.btnOk, 0)
        Me.Controls.SetChildIndex(Me.lblMessage, 0)
        Me.Controls.SetChildIndex(Me.label1, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Private WithEvents txtUserPass As System.Windows.Forms.TextBox
End Class
