Imports Dominio
Imports Común
Imports MaterialSkin
Public Class FrmMostrarInformacionCita
    Inherits Form
    Dim userDaocitas As New ModeloCitas()
    Dim userdaoservicios As New ModeloServicio()
    Private ReadOnly idcita As Integer

    ' Constructor que acepta el ID de la mascota como parámetro
    Public Sub New(ByVal idcita As Integer)
        InitializeComponent()
        Me.idcita = idcita
    End Sub



    Private Sub FrmMostrarInformacionCita_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cargarinformacioncita()
        bloquearcajasparacitas()
        Cargardatagrid()
        Dim Costototalserviciosactualizado As Servicios = userdaoservicios.ObtenerCostoTotal(idcita)
        LabelCostototal.Text = Costototalserviciosactualizado.CostoTOTAL
    End Sub


    Private Sub cargarinformacioncita()
        ' Utiliza la función ObtenerCliente para obtener la información del cliente

        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.Cyan500, Primary.BlueGrey500, Accent.DeepPurple700, TextShade.WHITE)



        Dim citass As Citas = userDaocitas.obtenercita(idcita)
        Try

            'datosgeneralesclientes
            MaterialTextBoxPrimerNombre.Text = citass.primernombre
            MaterialTextBoxSegundoNombre.Text = citass.segundonombre
            MaterialTextBoxApellidoPaterno.Text = citass.apellidopatern
            MaterialTextBoxApellidoMaterno.Text = citass.apellidomatern
            MaterialTextBoxEmail.Text = citass.email


            'mascota
            MaterialTextBoxNombreMascota.Text = citass.nombremascota
            MaterialTextBoxpeso.Text = citass.mascotapeso
            MaterialTextBoxTipoMascota.Text = citass.tipomascota
            MaterialTextBox2RAZA.Text = citass.razamascota
            MaterialTextBoSexo.Text = citass.sexomascota
            'telefono
            MaterialTextBoxCasa.Text = citass.telcasa
            MaterialTextBoxCelular.Text = citass.celular
            MaterialTextBoxTrabajo.Text = citass.teltrabajo
            MaterialTextBoxExterno.Text = citass.telexterno
            MaterialMultiLineTextBoxDescripcion.Text = citass.descripcioncliente


            DateTimePickerInicio.Value = citass.iniciovacuna
            DateTimePickerFin.Value = citass.vigvacuna

            'para activar "esvacunado"
            If citass.esvacunado.HasValue Then
                ' If Esvacunado has a value
                MaterialCheckboxVACUNADOSI.Checked = (citass.esvacunado = True)
                MaterialCheckboxVACUNADONO.Checked = Not (citass.esvacunado = True)
            Else
                ' If Esvacunado is null, deactivate both radio buttons
                MaterialCheckboxVACUNADOSI.Checked = False
                MaterialCheckboxVACUNADOSI.Checked = False
            End If



            'citas
            DateTimePickercitas.Value = citass.fechacita
            MaterialComboBoxHORARIO.ValueMember = citass.idhorariocita
            MaterialMultiLineTextBox21.Text = citass.descripcioncita
            MaterialComboBoxHORARIO.DataSource = userDaocitas.modelomosostrarHorariocompleto()
            MaterialComboBoxHORARIO.DisplayMember = "HORARIOCOMPLETO"
            MaterialComboBoxHORARIO.ValueMember = "idHORARIO"


            Dim IDTMascotaSeleccionado As Integer = citass.idhorariocita

            If MaterialComboBoxHORARIO.Items.Cast(Of Citas)().Any(Function(t) t.idHORARIO = IDTMascotaSeleccionado) Then
                MaterialComboBoxHORARIO.SelectedValue = IDTMascotaSeleccionado
            Else
                MaterialComboBoxHORARIO.SelectedIndex = -1 ' O selecciona un valor predeterminado 
            End If


            MaterialComboBoxEstadoCita.ValueMember = citass.idecita

            MaterialComboBoxEstadoCita.DataSource = userDaocitas.ModeloMostrarEstadoCitaCompleto()

            MaterialComboBoxEstadoCita.DisplayMember = "ESTADOSCITASCOMPLETO"
            MaterialComboBoxEstadoCita.ValueMember = "idESTADOCITA"


            Dim IDEcita As Integer = citass.idecita

            If MaterialComboBoxEstadoCita.Items.Cast(Of Citas)().Any(Function(t) t.idESTADOCITA = IDEcita) Then
                MaterialComboBoxEstadoCita.SelectedValue = IDEcita
            Else
                MaterialComboBoxEstadoCita.SelectedIndex = -1 ' O selecciona un valor predeterminado 
            End If

            MaterialComboBoxTServicio.DataSource = userdaoservicios.ModelomostrarTIPOservicio()
            MaterialComboBoxTServicio.DisplayMember = "NombreTIPOServicio"
            MaterialComboBoxTServicio.ValueMember = "IdTipoServicio"

        Catch


        End Try



    End Sub

    Private Sub ButtonAceptar_Click(sender As Object, e As EventArgs) Handles ButtonAceptar.Click


        Try
            Dim userModeldasc As New ModeloCitas(idcita:=idcita, idecita:=MaterialComboBoxEstadoCita.SelectedValue, IDUsuarioModifica:=UsuarioActivo.idUser)
            Dim result = userModeldasc.EditarEstadoCita()

        Catch
        End Try

        Try
            ' Obtener datos desde la capa de lógica de negocio
            Dim dataTable As DataTable = userDaocitas.modelousuariotraercitasdelprincipio(FrmCitasPrincipal.DateTimePicker1.Value)
            If dataTable.Rows.Count <> 0 Then
                FrmCitasPrincipal.DataGridView1.DataSource = dataTable
            Else
                FrmCitasPrincipal.DataGridView1.DataSource = Nothing
            End If
        Catch
        End Try

        Me.Close()

    End Sub

    Private Sub MaterialCheckboxVACUNADONO_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialCheckboxVACUNADONO.CheckedChanged
        If MaterialCheckboxVACUNADONO.Checked Then
            MaterialCheckboxVACUNADOSI.Checked = False
            Panel4.BackColor = Color.Gray
        End If
    End Sub

    Private Sub MaterialCheckboxVACUNADOSI_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialCheckboxVACUNADOSI.CheckedChanged
        If MaterialCheckboxVACUNADOSI.Checked Then
            MaterialCheckboxVACUNADONO.Checked = False
            ActualizarColorDateTimePickerFin()
        End If
    End Sub


    Private Sub ActualizarColorDateTimePickerFin()
        Dim fechaFin As DateTime = DateTimePickerFin.Value
        Dim fechaHoy As DateTime = DateTime.Today

        ' Verificar si el CheckBox está activado y la fecha de fin ha pasado
        If MaterialCheckboxVACUNADOSI.Checked AndAlso fechaFin <= fechaHoy Then
            ' Cambiar el color a rojo
            Panel4.BackColor = Color.Red
        Else
            ' Cambiar el color a verde
            Panel4.BackColor = Color.ForestGreen
        End If
    End Sub

    Private Sub DateTimePickerInicio_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerInicio.ValueChanged
        ActualizarColorDateTimePickerFin()

    End Sub

    Private Sub bloquearcajasparacitas()
        DateTimePickercitas.Enabled = False
        MaterialComboBoxHORARIO.Enabled = False
        MaterialMultiLineTextBox21.Enabled = False
        MaterialTextBoxCosto.Enabled = False

    End Sub

    Private Sub desbloquearcajasparacitas()
        DateTimePickercitas.Enabled = True
        MaterialComboBoxHORARIO.Enabled = True
        MaterialMultiLineTextBox21.Enabled = True
        DataGridView1.Enabled = True

    End Sub

    Private Sub ButtonEditar_Click(sender As Object, e As EventArgs) Handles ButtonEditar.Click



        desbloquearcajasparacitas()
        ButtonEditar.Visible = False
        ButtonAceptar.Visible = False
        Buttoncancelar.Visible = True
        ButtonGuardar.Visible = True


    End Sub

    Private Sub Buttoncancelar_Click(sender As Object, e As EventArgs) Handles Buttoncancelar.Click

        bloquearcajasparacitas()
        Buttoncancelar.Visible = False
        ButtonEditar.Visible = True
        ButtonGuardar.Visible = False
        ButtonAceptar.Visible = True
    End Sub

    Private Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles ButtonGuardar.Click

        Try
            Dim userModeldasc As New ModeloCitas(idcita:=idcita, idhorario:=MaterialComboBoxHORARIO.SelectedValue, fechacita:=DateTimePickercitas.Value, descripcion:=MaterialMultiLineTextBox21.Text, IDUsuarioModifica:=UsuarioActivo.idUser)
            Dim result = userModeldasc.EditarCitas()
            MessageBox.Show(result)
        Catch
        End Try



        bloquearcajasparacitas()
        Buttoncancelar.Visible = False
        ButtonEditar.Visible = True
        ButtonGuardar.Visible = False
        ButtonAceptar.Visible = True
    End Sub
    'cuando cambie el combobox de TIPO de servicio
    Private Sub MaterialComboBoxTServicio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MaterialComboBoxTServicio.SelectedIndexChanged
        Try
            If MaterialComboBoxTServicio.SelectedIndex <> -1 Then
                ' Obtener el ID del Tipo de Mascota seleccionado
                Dim IdTipoServicio As Integer = DirectCast(MaterialComboBoxTServicio.SelectedItem, Servicios).IdTipoServicio

                ' Llenar ComboBox de RazaMascota según el ID del Tipo de Mascota

                MaterialComboBoxServicios.DataSource = userdaoservicios.ModeloUsuariomostrarServiciodependiendoDeTipoCitas(IdTipoServicio)
                MaterialComboBoxServicios.DisplayMember = "NombreServicio"
                MaterialComboBoxServicios.ValueMember = "IDServicioTIPO"
            End If
        Catch
        End Try

    End Sub


    Private Sub MaterialComboBoxServicios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MaterialComboBoxServicios.SelectedIndexChanged
        Try
            If MaterialComboBoxServicios.SelectedIndex <> -1 Then
                ' Obtener el ID del Tipo de Mascota seleccionado
                Dim IdServicio As Integer = DirectCast(MaterialComboBoxServicios.SelectedItem, Servicios).IDServicioTIPO

                ' Llenar ComboBox de RazaMascota según el ID del Tipo de Mascota
                Dim ServicioParaCosto As Servicios = userdaoservicios.ObtenerCostoServicioCita(IdServicio)
                MaterialTextBoxCosto.Text = ServicioParaCosto.CostoServicio

            End If
        Catch
        End Try
    End Sub

    Private Sub ButtonAgregar_Click(sender As Object, e As EventArgs) Handles ButtonAgregar.Click
        Try
            Dim usermodeloservicios As New ModeloServicio(idservicio:=MaterialComboBoxServicios.SelectedValue, idCitaParaServicios:=idcita, IDUsuarioCrea:=UsuarioActivo.idUser)






            Dim result = usermodeloservicios.ModeloInsertarServiciosParaCitas()
            MessageBox.Show(result)

            Cargardatagrid()
            Dim Costototalserviciosactualizado As Servicios = userdaoservicios.ObtenerCostoTotal(idcita)
            LabelCostototal.Text = Costototalserviciosactualizado.CostoTOTAL.ToString


        Catch
        End Try
    End Sub



    Private Sub Cargardatagrid()
        Try
            ' Obtener datos desde la capa de lógica de negocio
            Dim dataTable As DataTable = userdaoservicios.ModeloMostrarServiciosDetallesCitas(idcita) ' 1 es un ejemplo de ID de cliente, debes proporcionar el ID real.
            If dataTable.Rows.Count <> 0 Then
                DataGridView1.DataSource = dataTable
            Else
                DataGridView1.DataSource = Nothing
            End If
        Catch
        End Try
    End Sub

    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click


        Try


            ' Verificamos si hay al menos una fila seleccionada en el DataGridView
            If DataGridView1.SelectedRows.Count > 0 Then
                ' Obtenemos el valor de la celda en la columna que contiene el ID de la mascota
                Dim idservicioseleccionado As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("Codigo").Value)
                Dim usermodeloservicios As New ModeloServicio(idDetallesServicios:=idservicioseleccionado)

                Dim result = usermodeloservicios.ModeloEliminarDetalleCita()
                MessageBox.Show(result)

                Cargardatagrid()
                Dim Costototalserviciosactualizado As Servicios = userdaoservicios.ObtenerCostoTotal(idcita)
                LabelCostototal.Text = Costototalserviciosactualizado.CostoTOTAL

            Else
                MessageBox.Show("Selecciona un servicio antes de hacer clic en el botón eliminar.")
            End If

        Catch
        End Try
    End Sub
End Class