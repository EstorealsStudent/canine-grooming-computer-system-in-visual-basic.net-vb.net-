Public Class SupportDeEmail
    Inherits EnviadorDeCorrecoPrincipal

    Public Sub New()
        senderMail = "estoreals@gmail.com"
        password = "rkrbcbkfccphfdck"
        host = "smtp.gmail.com"
        port = 587
        ssl = True
        initializeSmptClient()
    End Sub
End Class
