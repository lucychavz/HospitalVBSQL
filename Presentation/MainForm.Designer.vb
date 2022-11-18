<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits Presentation.BaseMainForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.panelDesktop = New System.Windows.Forms.Panel()
        Me.panelDesktopHeader = New System.Windows.Forms.Panel()
        Me.lblCaption = New System.Windows.Forms.Label()
        Me.btnChildFormClose = New System.Windows.Forms.Button()
        Me.panelSideMenu = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnCalendar = New System.Windows.Forms.Button()
        Me.btnHistory = New System.Windows.Forms.Button()
        Me.btnPacients = New System.Windows.Forms.Button()
        Me.btnUsers = New System.Windows.Forms.Button()
        Me.panelMenuHeader = New System.Windows.Forms.Panel()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.linkProfile = New System.Windows.Forms.LinkLabel()
        Me.pictureBoxPhoto = New System.Windows.Forms.PictureBox()
        Me.btnSideMenu = New System.Windows.Forms.PictureBox()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.panelTitleBar = New System.Windows.Forms.Panel()
        Me.label1 = New System.Windows.Forms.Label()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnMaximize = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelClientArea.SuspendLayout()
        Me.panelDesktop.SuspendLayout()
        Me.panelDesktopHeader.SuspendLayout()
        Me.panelSideMenu.SuspendLayout()
        Me.panelMenuHeader.SuspendLayout()
        CType(Me.pictureBoxPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSideMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelTitleBar.SuspendLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelClientArea
        '
        Me.PanelClientArea.Controls.Add(Me.panelDesktop)
        Me.PanelClientArea.Controls.Add(Me.panelDesktopHeader)
        Me.PanelClientArea.Controls.Add(Me.panelSideMenu)
        Me.PanelClientArea.Controls.Add(Me.panelTitleBar)
        Me.PanelClientArea.Size = New System.Drawing.Size(1198, 598)
        '
        'panelDesktop
        '
        Me.panelDesktop.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.panelDesktop.Controls.Add(Me.PictureBox1)
        Me.panelDesktop.Controls.Add(Me.label2)
        Me.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelDesktop.Location = New System.Drawing.Point(230, 70)
        Me.panelDesktop.Name = "panelDesktop"
        Me.panelDesktop.Size = New System.Drawing.Size(968, 528)
        Me.panelDesktop.TabIndex = 11
        '
        'panelDesktopHeader
        '
        Me.panelDesktopHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.panelDesktopHeader.Controls.Add(Me.lblCaption)
        Me.panelDesktopHeader.Controls.Add(Me.btnChildFormClose)
        Me.panelDesktopHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelDesktopHeader.Location = New System.Drawing.Point(230, 40)
        Me.panelDesktopHeader.Name = "panelDesktopHeader"
        Me.panelDesktopHeader.Size = New System.Drawing.Size(968, 30)
        Me.panelDesktopHeader.TabIndex = 10
        '
        'lblCaption
        '
        Me.lblCaption.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblCaption.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaption.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblCaption.Location = New System.Drawing.Point(30, 0)
        Me.lblCaption.Name = "lblCaption"
        Me.lblCaption.Size = New System.Drawing.Size(424, 30)
        Me.lblCaption.TabIndex = 18
        Me.lblCaption.Text = "Child Form Title"
        Me.lblCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnChildFormClose
        '
        Me.btnChildFormClose.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnChildFormClose.FlatAppearance.BorderSize = 0
        Me.btnChildFormClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.btnChildFormClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChildFormClose.Image = Global.Presentation.My.Resources.Resources.btnClose
        Me.btnChildFormClose.Location = New System.Drawing.Point(0, 0)
        Me.btnChildFormClose.Name = "btnChildFormClose"
        Me.btnChildFormClose.Size = New System.Drawing.Size(30, 30)
        Me.btnChildFormClose.TabIndex = 19
        Me.btnChildFormClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnChildFormClose.UseVisualStyleBackColor = True
        '
        'panelSideMenu
        '
        Me.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.panelSideMenu.Controls.Add(Me.btnLogout)
        Me.panelSideMenu.Controls.Add(Me.btnReports)
        Me.panelSideMenu.Controls.Add(Me.btnCalendar)
        Me.panelSideMenu.Controls.Add(Me.btnHistory)
        Me.panelSideMenu.Controls.Add(Me.btnPacients)
        Me.panelSideMenu.Controls.Add(Me.btnUsers)
        Me.panelSideMenu.Controls.Add(Me.panelMenuHeader)
        Me.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelSideMenu.Location = New System.Drawing.Point(0, 40)
        Me.panelSideMenu.Name = "panelSideMenu"
        Me.panelSideMenu.Size = New System.Drawing.Size(230, 558)
        Me.panelSideMenu.TabIndex = 9
        '
        'btnLogout
        '
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.SlateGray
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(0, 370)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnLogout.Size = New System.Drawing.Size(230, 45)
        Me.btnLogout.TabIndex = 25
        Me.btnLogout.Text = "  Cerrar sesión"
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnReports
        '
        Me.btnReports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReports.FlatAppearance.BorderSize = 0
        Me.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReports.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReports.ForeColor = System.Drawing.Color.SlateGray
        Me.btnReports.Image = CType(resources.GetObject("btnReports.Image"), System.Drawing.Image)
        Me.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReports.Location = New System.Drawing.Point(0, 325)
        Me.btnReports.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnReports.Size = New System.Drawing.Size(230, 45)
        Me.btnReports.TabIndex = 24
        Me.btnReports.Text = "  Reportes"
        Me.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReports.UseVisualStyleBackColor = True
        '
        'btnCalendar
        '
        Me.btnCalendar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalendar.FlatAppearance.BorderSize = 0
        Me.btnCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalendar.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalendar.ForeColor = System.Drawing.Color.SlateGray
        Me.btnCalendar.Image = CType(resources.GetObject("btnCalendar.Image"), System.Drawing.Image)
        Me.btnCalendar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCalendar.Location = New System.Drawing.Point(0, 280)
        Me.btnCalendar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCalendar.Name = "btnCalendar"
        Me.btnCalendar.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnCalendar.Size = New System.Drawing.Size(230, 45)
        Me.btnCalendar.TabIndex = 23
        Me.btnCalendar.Text = "  Calendario"
        Me.btnCalendar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCalendar.UseVisualStyleBackColor = True
        '
        'btnHistory
        '
        Me.btnHistory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHistory.FlatAppearance.BorderSize = 0
        Me.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHistory.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistory.ForeColor = System.Drawing.Color.SlateGray
        Me.btnHistory.Image = CType(resources.GetObject("btnHistory.Image"), System.Drawing.Image)
        Me.btnHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHistory.Location = New System.Drawing.Point(0, 235)
        Me.btnHistory.Margin = New System.Windows.Forms.Padding(2)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnHistory.Size = New System.Drawing.Size(230, 45)
        Me.btnHistory.TabIndex = 22
        Me.btnHistory.Text = "  Medico"
        Me.btnHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHistory.UseVisualStyleBackColor = True
        '
        'btnPacients
        '
        Me.btnPacients.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPacients.FlatAppearance.BorderSize = 0
        Me.btnPacients.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPacients.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPacients.ForeColor = System.Drawing.Color.SlateGray
        Me.btnPacients.Image = CType(resources.GetObject("btnPacients.Image"), System.Drawing.Image)
        Me.btnPacients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPacients.Location = New System.Drawing.Point(0, 190)
        Me.btnPacients.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPacients.Name = "btnPacients"
        Me.btnPacients.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnPacients.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnPacients.Size = New System.Drawing.Size(230, 45)
        Me.btnPacients.TabIndex = 21
        Me.btnPacients.Text = "  Pacientes"
        Me.btnPacients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPacients.UseVisualStyleBackColor = True
        '
        'btnUsers
        '
        Me.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUsers.FlatAppearance.BorderSize = 0
        Me.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsers.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsers.ForeColor = System.Drawing.Color.SlateGray
        Me.btnUsers.Image = CType(resources.GetObject("btnUsers.Image"), System.Drawing.Image)
        Me.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsers.Location = New System.Drawing.Point(0, 145)
        Me.btnUsers.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnUsers.Size = New System.Drawing.Size(230, 45)
        Me.btnUsers.TabIndex = 20
        Me.btnUsers.Text = "  Usuarios"
        Me.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUsers.UseVisualStyleBackColor = True
        '
        'panelMenuHeader
        '
        Me.panelMenuHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.panelMenuHeader.Controls.Add(Me.lblLastName)
        Me.panelMenuHeader.Controls.Add(Me.linkProfile)
        Me.panelMenuHeader.Controls.Add(Me.pictureBoxPhoto)
        Me.panelMenuHeader.Controls.Add(Me.btnSideMenu)
        Me.panelMenuHeader.Controls.Add(Me.lblPosition)
        Me.panelMenuHeader.Controls.Add(Me.lblName)
        Me.panelMenuHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelMenuHeader.Location = New System.Drawing.Point(0, 0)
        Me.panelMenuHeader.Name = "panelMenuHeader"
        Me.panelMenuHeader.Size = New System.Drawing.Size(230, 115)
        Me.panelMenuHeader.TabIndex = 0
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.ForeColor = System.Drawing.Color.DarkGray
        Me.lblLastName.Location = New System.Drawing.Point(72, 36)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(57, 16)
        Me.lblLastName.TabIndex = 17
        Me.lblLastName.Text = "Apellido"
        '
        'linkProfile
        '
        Me.linkProfile.ActiveLinkColor = System.Drawing.SystemColors.Highlight
        Me.linkProfile.AutoSize = True
        Me.linkProfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.linkProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkProfile.LinkColor = System.Drawing.Color.CornflowerBlue
        Me.linkProfile.Location = New System.Drawing.Point(6, 78)
        Me.linkProfile.Name = "linkProfile"
        Me.linkProfile.Size = New System.Drawing.Size(58, 17)
        Me.linkProfile.TabIndex = 16
        Me.linkProfile.TabStop = True
        Me.linkProfile.Text = "Mi Perfil"
        '
        'pictureBoxPhoto
        '
        Me.pictureBoxPhoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureBoxPhoto.Image = Global.Presentation.My.Resources.Resources.DefaultUserProfile
        Me.pictureBoxPhoto.Location = New System.Drawing.Point(6, 11)
        Me.pictureBoxPhoto.Name = "pictureBoxPhoto"
        Me.pictureBoxPhoto.Size = New System.Drawing.Size(64, 64)
        Me.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBoxPhoto.TabIndex = 13
        Me.pictureBoxPhoto.TabStop = False
        '
        'btnSideMenu
        '
        Me.btnSideMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSideMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSideMenu.Image = CType(resources.GetObject("btnSideMenu.Image"), System.Drawing.Image)
        Me.btnSideMenu.Location = New System.Drawing.Point(189, 5)
        Me.btnSideMenu.Name = "btnSideMenu"
        Me.btnSideMenu.Size = New System.Drawing.Size(32, 32)
        Me.btnSideMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnSideMenu.TabIndex = 12
        Me.btnSideMenu.TabStop = False
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosition.ForeColor = System.Drawing.Color.DarkGray
        Me.lblPosition.Location = New System.Drawing.Point(72, 52)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(44, 16)
        Me.lblPosition.TabIndex = 15
        Me.lblPosition.Text = "Cargo"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblName.Location = New System.Drawing.Point(72, 19)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(58, 17)
        Me.lblName.TabIndex = 14
        Me.lblName.Text = "Nombre"
        '
        'panelTitleBar
        '
        Me.panelTitleBar.BackColor = System.Drawing.Color.RoyalBlue
        Me.panelTitleBar.Controls.Add(Me.label1)
        Me.panelTitleBar.Controls.Add(Me.pictureBox2)
        Me.panelTitleBar.Controls.Add(Me.btnMinimize)
        Me.panelTitleBar.Controls.Add(Me.btnMaximize)
        Me.panelTitleBar.Controls.Add(Me.btnClose)
        Me.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTitleBar.Location = New System.Drawing.Point(0, 0)
        Me.panelTitleBar.Name = "panelTitleBar"
        Me.panelTitleBar.Size = New System.Drawing.Size(1198, 40)
        Me.panelTitleBar.TabIndex = 8
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.label1.Location = New System.Drawing.Point(35, 11)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(164, 17)
        Me.label1.TabIndex = 15
        Me.label1.Text = "Clinica Salud y Bienestar"
        '
        'pictureBox2
        '
        Me.pictureBox2.Image = CType(resources.GetObject("pictureBox2.Image"), System.Drawing.Image)
        Me.pictureBox2.Location = New System.Drawing.Point(8, 8)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(25, 25)
        Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox2.TabIndex = 6
        Me.pictureBox2.TabStop = False
        '
        'btnMinimize
        '
        Me.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Image = Global.Presentation.My.Resources.Resources.btnMinimize
        Me.btnMinimize.Location = New System.Drawing.Point(1093, 0)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(35, 40)
        Me.btnMinimize.TabIndex = 2
        Me.btnMinimize.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'btnMaximize
        '
        Me.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnMaximize.FlatAppearance.BorderSize = 0
        Me.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue
        Me.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximize.Image = Global.Presentation.My.Resources.Resources.btnMaximize
        Me.btnMaximize.Location = New System.Drawing.Point(1128, 0)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Size = New System.Drawing.Size(35, 40)
        Me.btnMaximize.TabIndex = 1
        Me.btnMaximize.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnMaximize.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Image = Global.Presentation.My.Resources.Resources.btnClose
        Me.btnClose.Location = New System.Drawing.Point(1163, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(35, 40)
        Me.btnClose.TabIndex = 0
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'label2
        '
        Me.label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Verdana", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.LightGray
        Me.label2.Location = New System.Drawing.Point(291, 346)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(345, 26)
        Me.label2.TabIndex = 15
        Me.label2.Text = "CLINICA SALUD Y BIENESTAR"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(331, 83)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(248, 248)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 600)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu principal"
        Me.PanelClientArea.ResumeLayout(False)
        Me.panelDesktop.ResumeLayout(False)
        Me.panelDesktop.PerformLayout()
        Me.panelDesktopHeader.ResumeLayout(False)
        Me.panelSideMenu.ResumeLayout(False)
        Me.panelMenuHeader.ResumeLayout(False)
        Me.panelMenuHeader.PerformLayout()
        CType(Me.pictureBoxPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSideMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelTitleBar.ResumeLayout(False)
        Me.panelTitleBar.PerformLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents panelDesktop As System.Windows.Forms.Panel
    Private WithEvents panelDesktopHeader As System.Windows.Forms.Panel
    Friend WithEvents lblCaption As System.Windows.Forms.Label
    Private WithEvents btnChildFormClose As System.Windows.Forms.Button
    Private WithEvents panelSideMenu As System.Windows.Forms.Panel
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnReports As System.Windows.Forms.Button
    Friend WithEvents btnCalendar As System.Windows.Forms.Button
    Friend WithEvents btnHistory As System.Windows.Forms.Button
    Friend WithEvents btnPacients As System.Windows.Forms.Button
    Friend WithEvents btnUsers As System.Windows.Forms.Button
    Private WithEvents panelMenuHeader As System.Windows.Forms.Panel
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Private WithEvents linkProfile As System.Windows.Forms.LinkLabel
    Friend WithEvents pictureBoxPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents btnSideMenu As System.Windows.Forms.PictureBox
    Friend WithEvents lblPosition As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Private WithEvents panelTitleBar As System.Windows.Forms.Panel
    Friend WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents pictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents btnMinimize As System.Windows.Forms.Button
    Private WithEvents btnMaximize As System.Windows.Forms.Button
    Private WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As PictureBox
    Private WithEvents label2 As Label
End Class
