Imports Dominio
Public Class FrmRecuperarContraseña


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim userModel As New ModeloUsuario()
        Dim result = userModel.recoverPassword(TextboxMail.Text)
        LabelResultado.Text = result
    End Sub
End Class