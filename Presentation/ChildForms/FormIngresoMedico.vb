Imports Domain
Imports Common

Public Class FormIngresoMedico
    Inherits BaseFixedForm

#Region "-> Constructores"
    ' Esta clase hereda de la clase BaseFixedForm.
    Public Sub New()
        'Utilice este constructor cuando desee agregar un nuevo usuario.
        InitializeComponent()
        lblMaintenanceTitle.Text = "Agregar nuevo medico"
        MedicoModel = New MedicoModel() 'Inicializar modelo de dominio de usuario.
        userModify = False 'Establecer userModify en falso.
        PictureBoxPhoto.Image = defaultPhoto 'Establecer la foto predeterminada para los usuarios sin foto.

    End Sub

#End Region
End Class