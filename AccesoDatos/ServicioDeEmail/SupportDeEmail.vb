Public Class SupportDeEmail
    Inherits EnviadorDeCorrecoPrincipal

    Public Sub New()
        senderMail = "petpalacemva@gmail.com"
        password = "zhyy ayyh yejo bwyf"
        host = "smtp.gmail.com"
        port = 587
        ssl = True
        initializeSmptClient()
    End Sub
End Class
