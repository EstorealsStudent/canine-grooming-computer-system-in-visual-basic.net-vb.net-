Imports Común
Imports Dominio

Public Class FrmAgregarServiciovb

    Dim userDaoservicio As New ModeloServicio()



    Private Sub MaterialTextBox21_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MaterialTextBox21.KeyPress
        ' Verificar si la tecla presionada es un número, un punto decimal o la tecla de retroceso
        If (Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso (e.KeyChar <> "."c)) Then
            e.Handled = True ' Ignorar la tecla presionada si no es un número o un punto decimal
        End If

        ' Permitir solo un punto decimal y hasta dos dígitos después del punto
        If (e.KeyChar = "."c AndAlso MaterialTextBox21.Text.Contains("."c)) Then
            Dim decimalPart As String = MaterialTextBox21.Text.Substring(MaterialTextBox21.Text.IndexOf("."c) + 1)
            If decimalPart.Length >= 2 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub MaterialTextBox21_Click(sender As Object, e As EventArgs) Handles MaterialTextBox21.Click

    End Sub

    Private Sub ButtonCerrar_Click(sender As Object, e As EventArgs) Handles ButtonCerrar.Click
        Me.Close()
    End Sub

    Private Sub InitializeComponentmascotas()
        Try
            MaterialComboBoxTServicio.DataSource = userDaoservicio.modelomostrarTIPOservicio()
            MaterialComboBoxTServicio.DisplayMember = "NombreTIPOServicio"
            MaterialComboBoxTServicio.ValueMember = "IdTipoServicio"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FrmAgregarServiciovb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeComponentmascotas()
    End Sub

    Private Sub ButtonAceptar_Click(sender As Object, e As EventArgs) Handles ButtonAceptar.Click

        Try
            Dim costo As Decimal
            costo = MaterialTextBox21.Text
            If MaterialTextBoxPrimerNombre.Text <> "" AndAlso MaterialTextBox21.Text <> "" Then

                Dim usermodeloservicios As New ModeloServicio(tipoServicio:=MaterialComboBoxTServicio.SelectedValue,
                                                              nombre:=MaterialTextBoxPrimerNombre.Text,
                                                              costo:=costo)






                Dim result = usermodeloservicios.modeloinsertarServicio()
                MessageBox.Show(result)

                reseterarcajas()
            Else
                MsgBox("verifica los datos")

            End If
        Catch
            MsgBox("Debes rellenar Nombre y costo")
        End Try





    End Sub

    Private Sub Reseterarcajas()
        MaterialTextBox21.Clear()
        MaterialTextBoxPrimerNombre.Clear()
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Me.Close()
    End Sub
End Class