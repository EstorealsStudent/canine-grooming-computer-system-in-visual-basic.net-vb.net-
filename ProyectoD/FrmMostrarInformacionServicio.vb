Imports Dominio
Imports Común
Public Class FrmMostrarInformacionServicio


    Inherits Form

    Dim userdaoserv As New ModeloServicio()


    Private ReadOnly idservicioobtenido As Integer

    Public Sub New(idservicioobtenido As Integer)
        InitializeComponent()
        Me.idservicioobtenido = idservicioobtenido
        cargarservicioinfo()
    End Sub



    Private Sub Cargarservicioinfo()
        ' Utiliza la función ObtenerCliente para obtener la información del cliente
        Dim servicio As Servicios = userdaoserv.ObtenerServicio(idservicioobtenido)

        ' Llena los controles del formulario con la información del cliente
        ' Por ejemplo:
        Try


            MaterialTextBoxPrimerNombre.Text = servicio.Nombre
            MaterialTextBox21.Text = servicio.Costo
            MaterialComboBoxTServicio.SelectedValue = servicio.TipoServicio

            MaterialComboBoxTServicio.DataSource = userdaoserv.ModelomostrarTIPOservicio()
            MaterialComboBoxTServicio.DisplayMember = "NombreTIPOServicio"
            MaterialComboBoxTServicio.ValueMember = "IdTipoServicio"

            Dim tiposervicios As Integer = servicio.TipoServicio

            If MaterialComboBoxTServicio.Items.Cast(Of Servicios)().Any(Function(g) g.IdTipoServicio = tiposervicios) Then
                MaterialComboBoxTServicio.SelectedValue = tiposervicios
            Else
                ' Puedes manejar el caso donde el género del cliente no está en la lista (por ejemplo, cargar el ComboBox con un valor predeterminado).
                MaterialComboBoxTServicio.SelectedIndex = -1 ' O seleccionar un valor predeterminado 
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Me.Close()
        FrmBuscarServicio.Show()

    End Sub

    Private Sub FrmMostrarInformacionServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ButtonAceptar.Visible = False
        ButtonCerrar.Visible = False
        bloquearcajas()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MaterialTextBoxPrimerNombre.Enabled = True
        MaterialTextBox21.Enabled = True
        MaterialComboBoxTServicio.Enabled = True

        Button1.Visible = False
        ButtonAceptar.Visible = True
        ButtonCerrar.Visible = True
    End Sub


    Private Sub Bloquearcajas()
        MaterialTextBoxPrimerNombre.Enabled = False
        MaterialTextBox21.Enabled = False
        MaterialComboBoxTServicio.Enabled = False
    End Sub

    Private Sub ButtonCerrar_Click(sender As Object, e As EventArgs) Handles ButtonCerrar.Click
        Bloquearcajas()
        ButtonCerrar.Visible = False
        ButtonAceptar.Visible = False
        Button1.Visible = True
    End Sub

    Private Sub ButtonAceptar_Click(sender As Object, e As EventArgs) Handles ButtonAceptar.Click

        If MaterialTextBoxPrimerNombre.Text <> "" AndAlso MaterialTextBox21.Text <> "" Then

            Dim userModelservicioseditados As New ModeloServicio(idservicio:=idservicioobtenido,
                                            tipoServicio:=MaterialComboBoxTServicio.SelectedValue,
                                            nombre:=MaterialTextBoxPrimerNombre.Text,
                                            costo:=MaterialTextBox21.Text, IDUsuarioModifica:=UsuarioActivo.idUser)

            Dim result = userModelservicioseditados.ModeloEditarServicio()
            MessageBox.Show(result)
            Bloquearcajas()
            ButtonAceptar.Visible = False
            ButtonCerrar.Visible = False
            Button1.Visible = True
        Else
            MsgBox("Dbes rellnar el nombre y costo del servicio")
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class