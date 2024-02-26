Imports Común
Public Class FrmBienvenida
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        CircularProgressBar2.Value += 1
        CircularProgressBar2.Text = CircularProgressBar2.Value.ToString()
        If Me.Opacity < 1 Then
            Me.Opacity += 0.05
        End If
        If CircularProgressBar2.Value = 100 Then
            Timer1.Stop()
            Timer2.Start()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.Opacity -= 0.1
        If Me.Opacity = 0 Then
            Timer2.Stop()
            Me.Close()
        End If
    End Sub

    Private Sub FrmBienvenida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelUsuario.Text = UsuarioActivo.PrimerNombre & ", " & UsuarioActivo.ApellidoP 'Mostramos los datos del usuario'
        CircularProgressBar2.Value = 0
        Me.Opacity = 0 'Iniciamos la opacidad en 0'
        Timer1.Start() 'Iniciamos el temporizador 1'

    End Sub

End Class