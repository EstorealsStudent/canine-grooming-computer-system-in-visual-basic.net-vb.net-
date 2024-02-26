Imports Dominio
Imports Común
Public Class FrmBuscarMascotaCitas
    Inherits Form

    Private ReadOnly idCliente As Integer

    Public Sub New(idCliente As Integer)
        InitializeComponent()
        Me.idCliente = idCliente

    End Sub

    Dim userDaomasc As New ModelosMascotas()





    Private Sub mostrarmascotas()
        Dim mascotas As List(Of Mascotas) = userDaomasc.Modelouusuariocargarmascotasparacitasclientes(idCliente)

        If mascotas IsNot Nothing AndAlso mascotas.Count > 0 Then
            MaterialListView1.Items.Clear()

            For Each mascota In mascotas
                Dim item As New ListViewItem(mascota.idmascotalista.ToString())

                ' Manejar valores nulos en el cliente
                Dim subItems() As String = {
                If(mascota.nombrelista IsNot Nothing, mascota.nombrelista.ToString(), String.Empty),
                If(mascota.colorlista IsNot Nothing, mascota.colorlista.ToString(), String.Empty)
            }

                item.SubItems.AddRange(subItems)

                MaterialListView1.Items.Add(item)
            Next
        Else
            ' Manejar el caso en que no hay clientes
            MessageBox.Show("No se encontraron Mascotas para citas.")
        End If
    End Sub

    Private Sub FrmBuscarMascotaCitas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        mostrarmascotas()
        Me.DoubleBuffered = True

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Me.Close()
    End Sub


    Private Sub MaterialListView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles MaterialListView1.MouseDoubleClick
        ' Obtener el ítem seleccionado
        Dim itemSeleccionado As ListViewItem = MaterialListView1.SelectedItems(0)

        ' Obtener el ID del cliente
        Dim idmascota As Integer = CInt(itemSeleccionado.SubItems(0).Text)
        Dim nombremascota As String = itemSeleccionado.SubItems(1).Text
        ' Abrir el formulario hijo y pasar el ID del cliente
        Dim formularioHijo As New FrmAgendarCita(idmascota, nombremascota)

        formularioHijo.Show()

        Me.Close()
    End Sub


End Class