Imports Común
Imports Dominio

Class FrmBuscarClientes
    Inherits Form

    Private Sub FrmBuscarClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Visible = True

        MostrarClientesEnListView()
        Me.DoubleBuffered = True

    End Sub


    Dim userDao As New ModeloUsuario()

    Private Sub MostrarClientesEnListView()
        Dim clientes As List(Of Clientes) = userDao.Modelousuariomostrarclientes

        If clientes IsNot Nothing AndAlso clientes.Count > 0 Then
            MaterialListView1.Items.Clear()

            For Each cliente In clientes
                Dim nombre As String = If(cliente.Nombre, String.Empty)
                Dim celular As String = If(cliente.Celular, String.Empty)

                Dim item As New ListViewItem(cliente.IDCliente.ToString())
                item.SubItems.AddRange({nombre, celular})

                MaterialListView1.Items.Add(item)
            Next
        Else
            MessageBox.Show("No se encontraron clientes.")
        End If
    End Sub




    Private Sub FiltrarClientes(ByVal filtro As String)
        MaterialListView1.Items.Clear()

        Dim clientesFiltrados As List(Of Clientes) = userDao.modelousuariomostrarclientes


        If clientesFiltrados IsNot Nothing AndAlso clientesFiltrados.Count > 0 Then
            ' Convertir el filtro y los valores de las columnas a minúsculas para una comparación sin distinción entre mayúsculas y minúsculas
            filtro = filtro.ToLower()

            If clientesFiltrados IsNot Nothing AndAlso clientesFiltrados.Count > 0 Then
                ' Convertir el filtro a minúsculas para una comparación sin distinción entre mayúsculas y minúsculas
                filtro = filtro.ToLower()

                clientesFiltrados = clientesFiltrados.Where(Function(cliente) _
                    cliente.IDCliente.ToString().ToLower().Contains(filtro) OrElse
                    cliente.Nombre.ToString().ToLower().Contains(filtro) OrElse
                    cliente.Celular.ToString().ToLower().Contains(filtro) OrElse
                    $"{cliente.Nombre}".ToLower().Contains(filtro)
                ).ToList()

                ' Mostrar los clientes filtrados en el ListView
                For Each cliente In clientesFiltrados
                    Dim item As New ListViewItem(cliente.IDCliente.ToString())
                    Dim subItems() As String = {
                        If(cliente.Nombre IsNot Nothing, cliente.Nombre.ToString(), String.Empty),
                        If(cliente.Celular IsNot Nothing, cliente.Celular.ToString(), String.Empty)
                    }
                    item.SubItems.AddRange(subItems)
                    MaterialListView1.Items.Add(item)
                Next
            Else
                ' Manejar el caso en que no hay clientes
                MessageBox.Show("No se encontraron clientes.")
            End If
        End If
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        FiltrarClientes(TextBox1.Text)
    End Sub

    Private Sub MaterialListView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles MaterialListView1.MouseDoubleClick
        ' Obtener el ítem seleccionado
        Dim itemSeleccionado As ListViewItem = MaterialListView1.SelectedItems(0)

        ' Obtener el ID del cliente
        Dim idClientse As Integer = CInt(itemSeleccionado.SubItems(0).Text)

        ' Abrir el formulario hijo y pasar el ID del cliente
        Dim formularioHijo As New FrmMostrarInformacionCliente(idClientse)

        formularioHijo.Show()

        Me.Close()
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Me.Close()

    End Sub

End Class