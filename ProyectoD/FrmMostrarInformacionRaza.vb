Imports Dominio
Imports Común
Public Class FrmMostrarInformacionRaza

    Inherits Form

    Dim userdaoserv As New ModelosMascotas()


    Private ReadOnly idrazaobtenida As Integer

    Public Sub New(idrazaobtenida As Integer)
        InitializeComponent()
        Me.idrazaobtenida = idrazaobtenida
    End Sub


    Private Sub FrmMostrarInformacionRaza_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ButtonAceptar.Visible = False
        ButtonCerrar.Visible = False
        Bloquearcajas()
        Cargarservicioinfo()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MaterialTextBoxPrimerNombre.Enabled = True
        MaterialComboBoxTServicio.Enabled = True
        Button1.Visible = False

        ButtonAceptar.Visible = True
        ButtonCerrar.Visible = True
    End Sub


    Private Sub Bloquearcajas()
        MaterialTextBoxPrimerNombre.Enabled = False
        MaterialComboBoxTServicio.Enabled = False
    End Sub

    Private Sub ButtonCerrar_Click(sender As Object, e As EventArgs) Handles ButtonCerrar.Click
        Bloquearcajas()
        ButtonCerrar.Visible = False
        ButtonAceptar.Visible = False
        Button1.Visible = True
    End Sub



    Private Sub Cargarservicioinfo()
        Dim servicio As Mascotas = userdaoserv.ModelomostrarRazayTipodeMascotasFRM(idrazaobtenida)
        Try


            MaterialTextBoxPrimerNombre.Text = servicio.nombreraza2
            MaterialComboBoxTServicio.SelectedValue = servicio.idtmascota2

            MaterialComboBoxTServicio.DataSource = userdaoserv.modelousuariomostrarTIPOSMASCOTAS()
            MaterialComboBoxTServicio.DisplayMember = "NombreTIPO"
            MaterialComboBoxTServicio.ValueMember = "IDTMascotaTIPO"

            Dim tiposervicios As Integer = servicio.idtmascota2

            If MaterialComboBoxTServicio.Items.Cast(Of Mascotas)().Any(Function(g) g.IDTMascotaTIPO = tiposervicios) Then
                MaterialComboBoxTServicio.SelectedValue = tiposervicios
            Else
                ' Puedes manejar el caso donde el género del cliente no está en la lista (por ejemplo, cargar el ComboBox con un valor predeterminado).
                MaterialComboBoxTServicio.SelectedIndex = -1 ' O seleccionar un valor predeterminado 
            End If

            Bloquearcajas()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonAceptar_Click(sender As Object, e As EventArgs) Handles ButtonAceptar.Click

        If MaterialTextBoxPrimerNombre.Text <> "" Then

            Dim userModelservicioseditados As New ModelosMascotas(idRmascotas:=idrazaobtenida,
                                            idTMascota:=MaterialComboBoxTServicio.SelectedValue,
                                            nombreraza:=MaterialTextBoxPrimerNombre.Text, IDUsuarioModifica:=UsuarioActivo.idUser)

            Dim result = userModelservicioseditados.ModeloEditarRazayTipoMascota()
            MessageBox.Show(result)
            Bloquearcajas()
            ButtonAceptar.Visible = False
            ButtonCerrar.Visible = False
            Button1.Visible = True
        Else
            MsgBox("Dbes rellnar el nombre de la raza")
        End If
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Me.Close()
        FrmBuscarRazaMascota.Show()
    End Sub
End Class