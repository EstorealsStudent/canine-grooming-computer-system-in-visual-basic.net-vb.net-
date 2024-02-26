Imports Común
Imports Dominio
Public Class FrmAgregarRazaMascota

    Dim userDaomasc As New ModelosMascotas()

    Private Sub FrmAgregarRazaMascota_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        MaterialComboBoxTMascota.DataSource = userDaomasc.modelousuariomostrarTIPOSMASCOTAS()
        MaterialComboBoxTMascota.DisplayMember = "NombreTIPO"
        MaterialComboBoxTMascota.ValueMember = "IDTMascotaTIPO"

    End Sub

    Private Sub ButtonAceptar_Click(sender As Object, e As EventArgs) Handles ButtonAceptar.Click
        Try
            If MaterialTextBoxNombreDeRaza.Text <> "" AndAlso MaterialComboBoxTMascota.SelectedValue IsNot Nothing Then
                Dim usermodeloservicios As New ModelosMascotas(idTMascota:=MaterialComboBoxTMascota.SelectedValue,
                                                      nombreraza:=MaterialTextBoxNombreDeRaza.Text, IDUsuarioCrea:=UsuarioActivo.idUser)

                Dim result = usermodeloservicios.modeloinsertarrazamascotas()
                MessageBox.Show(result)

                Reseterarcajas()
            Else
                MsgBox("Verifica los datos")
            End If
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
            MsgBox("Ocurrió un error al procesar la solicitud.")
        End Try





    End Sub

    Private Sub Reseterarcajas()
        MaterialTextBoxNombreDeRaza.Clear()
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Me.Close()
    End Sub

    Private Sub ButtonCerrar_Click(sender As Object, e As EventArgs) Handles ButtonCerrar.Click
        Me.Close()
    End Sub
End Class