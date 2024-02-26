Imports Común
Imports Dominio


Public Class FrmBuscarServicio

    Dim userDaoservicio As New ModeloServicio()



    Private Sub MostrarServiciosEnListView()
        Dim servicios As List(Of Servicios) = userDaoservicio.Modelousuariomostrarservicios

        If servicios IsNot Nothing AndAlso servicios.Count > 0 Then
            ' Desactivar repintado del control
            MaterialListView1.BeginUpdate()

            ' Limpiar elementos existentes
            MaterialListView1.Items.Clear()

            For Each servicio In servicios
                Dim nombreTipoServicio As String = If(servicio.NombreTIPOServicio, String.Empty)
                Dim nombreServicio As String = If(servicio.Nombre, String.Empty)
                Dim costoServicio As String = If(servicio.Costo, String.Empty)

                Dim item As New ListViewItem(servicio.IDServicio.ToString())
                item.SubItems.AddRange({nombreTipoServicio, nombreServicio, costoServicio})

                MaterialListView1.Items.Add(item)
            Next

            ' Reactivar repintado del control
            MaterialListView1.EndUpdate()
        Else
            ' En caso de que no haya servicios
            MessageBox.Show("No se encontraron Servicios.")
        End If
    End Sub




    Private Sub FrmBuscarServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarServiciosEnListView()
        Me.DoubleBuffered = True
        Me.Visible = True

        MaterialListView1.MultiSelect = False
        MaterialListView1.FullRowSelect = True
        MaterialListView1.GridLines = False
        MaterialListView1.View = View.Details

    End Sub

    Private Sub MaterialListView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles MaterialListView1.MouseDoubleClick
        ' Obtener el ítem seleccionado
        Dim itemSeleccionado As ListViewItem = MaterialListView1.SelectedItems(0)

        ' Obtener el ID del cliente
        Dim idServicio As Integer = CInt(itemSeleccionado.SubItems(0).Text)

        'Abrir el formulario hijo y pasar el ID del cliente
        Dim formularioHijo As New FrmMostrarInformacionServicio(idServicio)

        formularioHijo.Show()

        Me.Close()
    End Sub




    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Me.Close()
    End Sub


End Class