Imports System.Net.Mail
Imports System.Net

Public Class EmailService

    ''' <summary>
    ''' Esta clase implementa la interfaz IEmailService junto a sus métodos para enviar 
    ''' mensajes de correo electrónico, para ello se inicializa el objeto SmtpClient.
    ''' No olvides de configurar la conexión al servidor de correo remitente (MailServer), 
    ''' con tus datos de correo electrónico (El que se encargará de enviar los mensajes de correo).
    ''' En caso que uses Gmail como email remitente, debes de activar la opcion Permitir el acceso de aplicaciones
    ''' poco seguras para que tu aplicación pueda enviar correos electrónicos.
    ''' Leer la guía rápida para mas información.
    ''' </summary>

#Region "-> Campos"
    Private smtpClient As SmtpClient 'Obtiene o establece el cliente SMTP
    '->Parámetros del correo servidor remitente:
    Private ReadOnly Address As String = "VitalClinicSystem@gmail.com" 'Establece la dirección del correo servidor remitente(Aquí coloque el correo electrónico responsable de enviar los correos electrónicos).
    Private ReadOnly Password As String = "@admin123" 'Establece la contraseña del correo servidor remitente(Aquí coloque la contraseña del correo que estableciste en la linea anterior).
    Private ReadOnly DisplayName As String = "Vital Clinic" 'Establece el nombre para mostrar cuando se envia un mensaje de correo.
    Private ReadOnly Host As String = "smtp.gmail.com" 'Establece el nombre o la dirección IP del host para las transacciones SMTP.
    Private ReadOnly Port As Integer = 587 'Establece el puerto utilizado para las transacciones SMTP.
    Private ReadOnly SSL As Boolean = True 'Establece si el cliente SMTP utiliza Secure Sockets Layer (SSL) para cifrar la conexión.
#End Region

#Region "-> Constructor"
    Public Sub New()
        smtpClient = New SmtpClient() 'Inicializar cliente SMTP.
        smtpClient.Credentials = New NetworkCredential(Address, Password) 'Establecer las credenciales (Usuario y contraseña).
        smtpClient.Host = Host 'Establecer el host.
        smtpClient.Port = Port 'Establecer el puerto.
        smtpClient.EnableSsl = SSL 'Establecir el cifrado SSL.
    End Sub
#End Region

#Region "-> Metodos"
    Public Sub Send(recipient As String, subject As String, body As String)
        'Este método es responsable de enviar un mensaje de correo a un solo destinatario.

        Dim mailMessage = New MailMessage() 'Inicializar el objeto mensaje de correo.
        Dim mailSender = New MailAddress(Address, DisplayName) 'Inicializar el objeto dirección de correo electrónico remitente.
        Try
            mailMessage.From = mailSender 'Establecer la dirección de correo remitente.
            mailMessage.To.Add(recipient) 'Establecer y agregar la dirección de correo destinatario.
            mailMessage.Subject = subject 'Establecer el asunto del mensaje de correo.
            mailMessage.Body = body 'Establecer el contenido del mensaje de correo.
            mailMessage.Priority = MailPriority.Normal 'Establecer la prioridad del mensaje de correo.
            smtpClient.Send(mailMessage) 'Enviar el mensaje de correo mediante el cliente SMTP(Protocolo simple de transferencia de correo)
        Catch ex As SmtpException
            Throw New ArgumentException(ex.Message)
        Finally
            mailMessage.Dispose()
        End Try
    End Sub

    Public Sub Send(recipients As List(Of String), subject As String, body As String)
        'Este método es responsable de enviar un mensaje de correo a varios destinatarios.

        Dim mailMessage = New MailMessage() 'Inicializar el objeto mensaje de correo.
        Dim mailSender = New MailAddress(Address, DisplayName) 'Inicializar el objeto dirección de correo electrónico remitente.
        Try
            mailMessage.From = mailSender 'Establecer la dirección de correo remitente.
            For Each recipientMail In recipients 'Recorrer la lista de destinatarios para obtener cada dirección de correo.
                mailMessage.To.Add(recipientMail) 'Agregar la dirección de correo destinatario a la colección de direcciones de correo.
            Next
            mailMessage.Subject = subject 'Establecer el asunto del mensaje de correo.
            mailMessage.Body = body 'Establecer el contenido del mensaje de correo.
            mailMessage.Priority = MailPriority.Normal 'Establecer la prioridad del mensaje de correo.
            smtpClient.Send(mailMessage) 'Enviar el mensaje de correo mediante el cliente SMTP(Protocolo simple de transferencia de correo)
        Catch ex As SmtpException
            Throw New ArgumentException(ex.Message)
        Finally
            mailMessage.Dispose()
        End Try
    End Sub
#End Region
End Class
