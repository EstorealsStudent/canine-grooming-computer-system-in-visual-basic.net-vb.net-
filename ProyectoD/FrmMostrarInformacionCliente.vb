Imports Dominio
Imports Común
Imports MaterialSkin
Public Class FrmMostrarInformacionCliente

    Inherits Form

    Private ReadOnly idCliente As Integer

    Public Sub New(idCliente As Integer)
        InitializeComponent()
        Me.idCliente = idCliente
        CargarInformacionCliente()
    End Sub


    Dim userDao As New ModeloUsuario()
    Dim userDaomasc As New ModelosMascotas()

    Private Sub FrmMostrarInformacionCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepPurple700, TextShade.WHITE)

        ButtonguardarInformacion.Visible = False
        Buttoncancelar.Visible = False
        ButtonVermascotas.Enabled = False
        ButtonEditar.Enabled = False
        ButtonHistorai.Enabled = False
        DataGridView1.AllowUserToAddRows = False


        bloquearcajas()
        Cargardatagrid()
        DataGridView1.ClearSelection()





    End Sub


    Private Sub Cargardatagrid()
        Try
            ' Obtener datos desde la capa de lógica de negocio
            Dim dataTable As DataTable = userDaomasc.modelousuariomostrarmascotas(idCliente) ' 1 es un ejemplo de ID de cliente, debes proporcionar el ID real.
            If dataTable.Rows.Count <> 0 Then
                DataGridView1.DataSource = dataTable
            Else
                DataGridView1.DataSource = Nothing
            End If
        Catch
        End Try
    End Sub


    Private Sub CargarInformacionCliente()
        ' Utiliza la función ObtenerCliente para obtener la información del cliente
        Dim cliente As Clientes = userDao.ObtenerCliente(idCliente)

        ' Llena los controles del formulario con la información del cliente
        ' Por ejemplo:
        Try
            TextBox1.Text = cliente.IDClientes
            MaterialTextBoxPrimerNombre.Text = cliente.PrimerNombre
            MaterialTextBoxSegundoNombre.Text = cliente.SegundoNombre
            MaterialTextBoxApellidoPaterno.Text = cliente.ApellidoPaterno
            MaterialTextBoxApellidoMaterno.Text = cliente.ApellidoMaterno
            MaterialComboBox1.ValueMember = cliente.IDGenero

            MaterialTextBoxCalle.Text = cliente.Calle
            MaterialTextBoxNumero.Text = cliente.NumeroExt
            MaterialTextBoxColonia.Text = cliente.Colonia
            MaterialTextBoxMunicipio.Text = cliente.Municipio
            MaterialTextBoxCodigoPostal.Text = cliente.CodigoPostal
            MaterialTextBoxEstado.Text = cliente.Estado
            MaterialTextBoxRFC.Text = cliente.RFC
            MaterialTextBoxCURP.Text = cliente.CURP
            MaterialTextBoxCasa.Text = cliente.TelCasa
            MaterialTextBoxCelular.Text = cliente.Celularc
            MaterialTextBoxTrabajo.Text = cliente.TelTrabajo
            MaterialTextBoxExterno.Text = cliente.TelExterno
            MaterialTextBoxEmail.Text = cliente.Email
            MaterialMultiLineTextBoxDescripcion.Text = cliente.Descripcion

            ' Implementa la función ObtenerListaGeneros para obtener la lista desde la base de datos
            MaterialComboBox1.DataSource = userDao.modelousuariomostrargeneros()
            MaterialComboBox1.DisplayMember = "NombreGenero"
            MaterialComboBox1.ValueMember = "IDGenero"

            ' Selecciona el género correspondiente al cliente

            ' Selecciona el género correspondiente al cliente

            Dim generoCliente As Integer = cliente.IDGenero

            If MaterialComboBox1.Items.Cast(Of Clientes)().Any(Function(g) g.IDGenero = generoCliente) Then
                MaterialComboBox1.SelectedValue = generoCliente
            Else
                MaterialComboBox1.SelectedIndex = -1 ' O seleccionar un valor predeterminado 
            End If
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub






    Private Sub ButtonAceptar_Click(sender As Object, e As EventArgs) Handles ButtonAceptar.Click

        TextBox1.Enabled = True
        MaterialTextBoxPrimerNombre.Enabled = True
        MaterialTextBoxSegundoNombre.Enabled = True
        MaterialTextBoxApellidoPaterno.Enabled = True
        MaterialTextBoxApellidoMaterno.Enabled = True
        MaterialComboBox1.Enabled = True
        MaterialTextBoxCalle.Enabled = True
        MaterialTextBoxNumero.Enabled = True
        MaterialTextBoxColonia.Enabled = True
        MaterialTextBoxMunicipio.Enabled = True
        MaterialTextBoxCodigoPostal.Enabled = True
        MaterialTextBoxEstado.Enabled = True
        MaterialTextBoxRFC.Enabled = True
        MaterialTextBoxCURP.Enabled = True
        MaterialTextBoxCasa.Enabled = True

        MaterialTextBoxCelular.Enabled = True
        MaterialTextBoxTrabajo.Enabled = True
        MaterialTextBoxExterno.Enabled = True
        MaterialTextBoxEmail.Enabled = True
        MaterialMultiLineTextBoxDescripcion.Enabled = True

        ButtonguardarInformacion.Visible = True
        Buttoncancelar.Visible = True
    End Sub

    Private Sub ButtonguardarInformacion_Click(sender As Object, e As EventArgs) Handles ButtonguardarInformacion.Click


        Try

            Dim userModel As New ModeloClientes(iDCliente:=TextBox1.Text,
            iDGenero:=MaterialComboBox1.SelectedValue,
            primerNombre:=MaterialTextBoxPrimerNombre.Text,
            segundoNombre:=MaterialTextBoxSegundoNombre.Text,
            apellidoPaterno:=MaterialTextBoxApellidoPaterno.Text,
            apellidoMaterno:=MaterialTextBoxApellidoMaterno.Text,
            rFC:=MaterialTextBoxRFC.Text,
            cURP:=MaterialTextBoxCURP.Text,
            celular:=MaterialTextBoxCelular.Text,
            telCasa:=MaterialTextBoxCasa.Text,
            telTrabajo:=MaterialTextBoxTrabajo.Text,
            telExterno:=MaterialTextBoxExterno.Text,
            email:=MaterialTextBoxEmail.Text,
            calle:=MaterialTextBoxCalle.Text,
            numeroExt:=MaterialTextBoxNumero.Text,
            colonia:=MaterialTextBoxColonia.Text,
            municipio:=MaterialTextBoxMunicipio.Text,
            codigoPostal:=MaterialTextBoxCodigoPostal.Text,
            estado:=MaterialTextBoxEstado.Text,
            descripcion:=MaterialMultiLineTextBoxDescripcion.Text, IDUsuarioActualiza:=UsuarioActivo.idUser)

            Dim result = userModel.EditarClientesModelo()
            MessageBox.Show(result)
            bloquearcajas()
            ButtonguardarInformacion.Visible = False
            Buttoncancelar.Visible = False
        Catch
        End Try


    End Sub


    Private Sub Bloquearcajas()
        TextBox1.Enabled = False
        MaterialTextBoxPrimerNombre.Enabled = False
        MaterialTextBoxSegundoNombre.Enabled = False
        MaterialTextBoxApellidoPaterno.Enabled = False
        MaterialTextBoxApellidoMaterno.Enabled = False
        MaterialComboBox1.Enabled = False
        MaterialTextBoxCalle.Enabled = False
        MaterialTextBoxNumero.Enabled = False
        MaterialTextBoxColonia.Enabled = False
        MaterialTextBoxMunicipio.Enabled = False
        MaterialTextBoxCodigoPostal.Enabled = False
        MaterialTextBoxEstado.Enabled = False
        MaterialTextBoxRFC.Enabled = False
        MaterialTextBoxCURP.Enabled = False
        MaterialTextBoxCasa.Enabled = False

        MaterialTextBoxCelular.Enabled = False
        MaterialTextBoxTrabajo.Enabled = False
        MaterialTextBoxExterno.Enabled = False
        MaterialTextBoxEmail.Enabled = False
        MaterialMultiLineTextBoxDescripcion.Enabled = False


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Buttoncancelar.Click
        bloquearcajas()
        Buttoncancelar.Visible = False
        ButtonguardarInformacion.Visible = False
    End Sub
    'al darle click a una celda
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            ' Habilitar el botón al hacer clic en una fila
            ButtonVermascotas.Enabled = True
            ButtonEditar.Enabled = True
            ButtonHistorai.Enabled = True
        End If
    End Sub


    Private Sub ButtonVermascotas_Click(sender As Object, e As EventArgs) Handles ButtonVermascotas.Click


        ' Verificamos si hay al menos una fila seleccionada en el DataGridView
        If DataGridView1.SelectedRows.Count > 0 Then
            ' Obtenemos el valor de la celda en la columna que contiene el ID de la mascota
            Dim idMascota As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("IDMascota").Value)

            ' Creamos una instancia del formulario Form2 y le pasamos el ID de la mascota
            Dim form2 As New FrmVerinfoMascotas(idMascota)
            form2.Show()
        Else
            MessageBox.Show("Selecciona una Mascota antes de hacer clic en el botón.")
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click



        Dim IdClienteparamascota As Integer = TextBox1.Text

        ' Creamos una instancia del formulario Form2 y le pasamos el ID de la mascota
        Dim FrmInsertarMascotas As New FrmAgregarMascota(IdClienteparamascota)
        FrmInsertarMascotas.Show()


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        cargardatagrid()
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Me.Close()
        FrmBuscarClientes.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonEditar.Click


        ' Verificamos si hay al menos una fila seleccionada en el DataGridView
        If DataGridView1.SelectedRows.Count > 0 Then
            ' Obtenemos el valor de la celda en la columna que contiene el ID de la mascota
            Dim idMascota As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("IDMascota").Value)
            Dim idcliente As Integer = TextBox1.Text

            ' Creamos una instancia del formulario Form2 y le pasamos el ID de la mascota
            Dim form2 As New FrmEditarMascotas(idcliente, idMascota)
            form2.Show()
        Else
            MessageBox.Show("Selecciona una Mascota antes de hacer clic en el botón.")
        End If

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub ButtonAgendar_Click(sender As Object, e As EventArgs) Handles ButtonAgendar.Click


        ' Obtener el ID del cliente
        Dim idClientse As Integer = TextBox1.Text

        ' Abrir el formulario hijo y pasar el ID del cliente
        Dim formularioHijo As New FrmBuscarMascotaCitas(idClientse)

        formularioHijo.Show()



    End Sub

    Private Sub ButtonHistorai_Click(sender As Object, e As EventArgs) Handles ButtonHistorai.Click
        ' Verificamos si hay al menos una fila seleccionada en el DataGridView
        If DataGridView1.SelectedRows.Count > 0 Then
            ' Obtenemos el valor de la celda en la columna que contiene el ID de la mascota
            Dim idMascota As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("IDMascota").Value)
            ' Creamos una instancia del formulario Form2 y le pasamos el ID de la mascota
            Dim form2 As New FrmHistorialCitas(idMascota)
            form2.Show()
        Else
            MessageBox.Show("Selecciona una Mascota antes de hacer clic en el botón.")
        End If

    End Sub
End Class



