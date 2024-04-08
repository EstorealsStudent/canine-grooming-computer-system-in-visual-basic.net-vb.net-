Public Class SupportDeEmail
    Inherits EnviadorDeCorrecoPrincipal

    Public Sub New()
        senderMail = "" 'AQUI ESCRIBE TU EMAIL
        password = "" 'Contraseña generada para la aplicacion de correo
        host = "smtp.gmail.com" 'tipo de seficio de emial que quieras, outlook,gmail, etc
        port = 587 'el puerto que soporte tu servicio de correo
        ssl = True 'si tiene ssl o no el servicio.
        initializeSmptClient()
    End Sub
End Class
