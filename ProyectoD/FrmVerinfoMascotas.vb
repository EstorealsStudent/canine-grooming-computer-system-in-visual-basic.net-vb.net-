Imports System.IO
Imports Común
Imports Dominio



Public Class FrmVerinfoMascotas
    Inherits Form
    Dim userDaomasc As New ModelosMascotas()
    Dim banderacomboboxraza = 0
    Private ReadOnly idMascota As Integer

    ' Constructor que acepta el ID de la mascota como parámetro
    Public Sub New(ByVal idMascota As Integer)
        InitializeComponent()
        Me.idMascota = idMascota

        CargarInformacionMascnte()
    End Sub





    Private Sub FrmVerinfoMascotas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxIdmascotasinfo.Visible = False

    End Sub








    Public Sub MostrarImagenDesdeBytes(imagenBytes As Byte())
        Try
            ' Verificar si se obtuvieron datos
            If imagenBytes IsNot Nothing Then
                ' Convertir los datos en un objeto Image
                Using ms As New MemoryStream(imagenBytes)
                    PictureBox1.Image = Image.FromStream(ms)
                End Using
            Else
                ' No hay datos para mostrar, establecer el color de fondo en gris
                PictureBox1.Visible = False
            End If
        Catch ex As Exception
            ' Manejar la excepción según tus necesidades
            MessageBox.Show("Error al convertir los datos de imagen.")
        End Try
    End Sub


    Private Sub CargarInformacionMascnte()
        ' Utiliza la función ObtenerCliente para obtener la información del cliente

        Dim mascoas As Mascotas = userDaomasc.ModelomostrarMascotasFRM(idMascota)
        Try

            ' Supongamos que obtienes los bytes de la imagen desde algún lugar
            Dim bytesDeLaImagen As Byte() = mascoas.Foto

            ' Llamada a la subrutina para mostrar la imagen
            MostrarImagenDesdeBytes(bytesDeLaImagen)

            ' Llena los controles del formulario con la información del cliente
            ' Por ejemplo:
            TextBoxIdmascotasinfo.Text = mascoas.IDMascota
            MaterialTextBoxNombreMascota.Text = mascoas.Nombre
            MaterialComboboxTipo.ValueMember = mascoas.IDTMascotaRAZA
            MaterialTextBoxColor.Text = mascoas.Color
            MaterialTextBoxpeso.Text = mascoas.Peso
            MaterialTextBoxColor.Text = mascoas.Color
            MaterialComboBoxRAZA.ValueMember = mascoas.IDRMascota



            DateTimePickerInicio.Value = mascoas.Vacuna
            DateTimePickerFin.Value = mascoas.VigVacuna

            'para activar "esvacunado"
            If mascoas.Esvacunado.HasValue Then
                ' If Esvacunado has a value
                MaterialCheckboxVACUNADOSI.Checked = (mascoas.Esvacunado = True)
                MaterialCheckboxVACUNADONO.Checked = Not (mascoas.Esvacunado = True)
            Else
                ' If Esvacunado is null, deactivate both radio buttons
                MaterialCheckboxVACUNADOSI.Checked = False
                MaterialCheckboxVACUNADOSI.Checked = False
            End If



            'para activar es fallecido
            If mascoas.Fallecido.HasValue Then
                ' If Esvacunado has a value
                MaterialCheckboxFALLECIDOSI.Checked = (mascoas.Fallecido = True)
                MaterialCheckboxFALLECIDONO.Checked = Not (mascoas.Fallecido = True)
            Else
                ' If Esvacunado is null, deactivate both radio buttons
                MaterialCheckboxFALLECIDOSI.Checked = False
                MaterialCheckboxFALLECIDONO.Checked = False
            End If
            'cargarCOMBOBOX
            'Tipo

            MaterialComboboxTipo.DataSource = userDaomasc.modelousuariomostrarTIPOSMASCOTAS()
            MaterialComboboxTipo.DisplayMember = "NombreTIPO"
            MaterialComboboxTipo.ValueMember = "IDTMascotaTIPO"

            Dim IDTMascotaSeleccionado As Integer = mascoas.IDTMascotaTIPOact

            If MaterialComboboxTipo.Items.Cast(Of Mascotas)().Any(Function(t) t.IDTMascotaTIPO = IDTMascotaSeleccionado) Then
                MaterialComboboxTipo.SelectedValue = IDTMascotaSeleccionado
            Else
                MaterialComboboxTipo.SelectedIndex = -1 ' O selecciona un valor predeterminado 
            End If

            'Sexomascotas
            MaterialComboBoxSexo.DataSource = userDaomasc.modelousuariomostrarSEXOSMASCOTAS()
            MaterialComboBoxSexo.DisplayMember = "NombreSEX"
            MaterialComboBoxSexo.ValueMember = "IDSeMascotaSEX"

            Dim idtsexoseleccionado As Integer = mascoas.IDSeMascota ' Cambia esto con el valor que necesites

            If MaterialComboBoxSexo.Items.Cast(Of Mascotas)().Any(Function(t) t.IDSeMascotaSEX = idtsexoseleccionado) Then
                MaterialComboBoxSexo.SelectedValue = idtsexoseleccionado
            Else
                MaterialComboBoxSexo.SelectedIndex = -1 ' O selecciona un valor predeterminado 
            End If

            'raza

            MaterialComboBoxRAZA.DataSource = userDaomasc.modelousuariomostrarRAZAMASCOTAS(mascoas.IDRMascota)
            MaterialComboBoxRAZA.DisplayMember = "NombreRAZA"
            MaterialComboBoxRAZA.ValueMember = "IDRMascotaRAZA"

            Dim idtrazaseleccionado As Integer = mascoas.IDRMascota
            If MaterialComboBoxRAZA.Items.Cast(Of Mascotas)().Any(Function(t) t.IDRMascotaRAZA = idtrazaseleccionado) Then
                MaterialComboBoxRAZA.SelectedValue = idtrazaseleccionado
            Else
                MaterialComboBoxRAZA.SelectedIndex = -1 ' O selecciona un valor predeterminado 
            End If

        Catch
            MsgBox("Error")
        End Try

        desactivartextos()


    End Sub
    'si cambian en combobox TIPO

    Private Sub MaterialComboboxTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MaterialComboboxTipo.SelectedIndexChanged

    End Sub


    Private Sub desactivartextos()
        TextBoxIdmascotasinfo.Enabled = False
        MaterialTextBoxNombreMascota.Enabled = False
        MaterialComboboxTipo.Enabled = False
        MaterialTextBoxColor.Enabled = False
        MaterialTextBoxpeso.Enabled = False
        MaterialTextBoxColor.Enabled = False
        MaterialComboBoxRAZA.Enabled = False
        MaterialComboBoxSexo.Enabled = False


        DateTimePickerInicio.Enabled = False
        DateTimePickerFin.Enabled = False

        MaterialCheckboxVACUNADOSI.Enabled = False
        MaterialCheckboxVACUNADONO.Enabled = False




        'para activar es fallecido

        ' If Esvacunado has a value
        MaterialCheckboxFALLECIDOSI.Enabled = False
        MaterialCheckboxFALLECIDONO.Enabled = False

    End Sub

    Private Sub MaterialCheckboxVACUNADOSI_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialCheckboxVACUNADOSI.CheckedChanged
        If MaterialCheckboxVACUNADOSI.Checked Then
            MaterialCheckboxVACUNADONO.Checked = False
            ActualizarColorDateTimePickerFin()
        End If
    End Sub

    Private Sub MaterialCheckboxVACUNADONO_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialCheckboxVACUNADONO.CheckedChanged
        If MaterialCheckboxVACUNADONO.Checked Then
            MaterialCheckboxVACUNADOSI.Checked = False
            Panel3.BackColor = Color.Gray
        End If
    End Sub

    Private Sub MaterialCheckboxFALLECIDOSI_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialCheckboxFALLECIDOSI.CheckedChanged
        If MaterialCheckboxFALLECIDOSI.Checked Then
            MaterialCheckboxFALLECIDONO.Checked = False
        End If
    End Sub

    Private Sub MaterialCheckboxFALLECIDONO_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialCheckboxFALLECIDONO.CheckedChanged
        If MaterialCheckboxFALLECIDONO.Checked Then
            MaterialCheckboxFALLECIDOSI.Checked = False
        End If
    End Sub

    Private Sub ButtonAceptar_Click(sender As Object, e As EventArgs) Handles ButtonAceptar.Click
        Me.Close()
    End Sub

    Private Sub DateTimePickerInicio_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerInicio.ValueChanged
        ActualizarColorDateTimePickerFin()
    End Sub


    Private Sub ActualizarColorDateTimePickerFin()
        Dim fechaFin As DateTime = DateTimePickerFin.Value
        Dim fechaHoy As DateTime = DateTime.Today

        ' Verificar si el CheckBox está activado y la fecha de fin ha pasado
        If MaterialCheckboxVACUNADOSI.Checked AndAlso fechaFin < fechaHoy Then
            ' Cambiar el color a rojo
            Panel3.BackColor = Color.Red
        Else
            ' Cambiar el color a verde
            Panel3.BackColor = Color.ForestGreen
        End If
    End Sub

End Class