Imports Común
Imports Dominio
Public Class FrmBuscarRazaMascota

    Dim userDaomascota As New ModelosMascotas()


    Private Sub MostrarrazaytipoEnListView()
        Dim servicio As List(Of Mascotas) = userDaomascota.ModelousuariomostrarRazaytipoMascotas()

        If servicio IsNot Nothing AndAlso servicio.Count > 0 Then
            MaterialListView1.Items.Clear()

            For Each Servicios In servicio
                Dim item As New ListViewItem(Servicios.IDRMascotalista.ToString())

                ' Manejar valores nulos en el cliente
                Dim subItems() As String = {
                If(Servicios.NombretipoMascotalista IsNot Nothing, Servicios.NombretipoMascotalista.ToString(), String.Empty),
                 If(Servicios.NombreRazaMascotalista IsNot Nothing, Servicios.NombreRazaMascotalista.ToString(), String.Empty)
                 }

                item.SubItems.AddRange(subItems)

                MaterialListView1.Items.Add(item)
            Next
        Else
            ' Manejar el caso en que no hay clientes
            MessageBox.Show("No se encontraron Servicios.")
        End If
    End Sub


    Private Sub MaterialListView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles MaterialListView1.MouseDoubleClick
        ' Obtener el ítem seleccionado
        Dim itemSeleccionado As ListViewItem = MaterialListView1.SelectedItems(0)

        ' Obtener el ID del cliente
        Dim idraza As Integer = CInt(itemSeleccionado.SubItems(0).Text)

        'Abrir el formulario hijo y pasar el ID del cliente
        Dim formularioHijo As New FrmMostrarInformacionRaza(idraza)

        formularioHijo.Show()

        Me.Close()
    End Sub

    Private Sub FrmBuscarRazaMascota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarrazaytipoEnListView()
        Me.DoubleBuffered = True
        Me.Visible = True
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class