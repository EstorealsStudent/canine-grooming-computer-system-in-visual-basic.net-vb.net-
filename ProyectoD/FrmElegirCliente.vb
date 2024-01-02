Public Class FrmElegirCliente
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        FrmBuscarClientes.Show()

    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        Panel1.BackColor = Color.Gainsboro
        Label1.BackColor = Color.Gainsboro
        PictureBox1.BackColor = Color.Gainsboro

    End Sub

    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove
        Panel2.BackColor = Color.Gainsboro
        Label2.BackColor = Color.Gainsboro
        PictureBox2.BackColor = Color.Gainsboro
    End Sub

    Private Sub FrmElegirCliente_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        Panel2.BackColor = Color.White
        Label2.BackColor = Color.White
        PictureBox2.BackColor = Color.White
        Panel1.BackColor = Color.White
        Label1.BackColor = Color.White
        PictureBox1.BackColor = Color.White

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        FrmRegistrarCliente.Show()
    End Sub

    Private Sub FrmElegirCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class