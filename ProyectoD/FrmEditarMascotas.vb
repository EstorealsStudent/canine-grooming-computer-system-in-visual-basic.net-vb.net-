Imports Dominio
Imports Común
Imports System.IO
Imports System.Drawing.Imaging
Public Class FrmEditarMascotas
    Inherits Form

    Dim userDaomasc As New ModelosMascotas()

    Private ReadOnly idCliente As Integer
    Private ReadOnly idMascota As Integer

    Public Sub New(idCliente As Integer, ByVal idMascota As Integer)
        InitializeComponent()
        Me.idCliente = idCliente
        Me.idMascota = idMascota

    End Sub




    Private Sub FrmEditarMascotas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarInformacionMascnte()
        pesoscombobox()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub



    Private Sub pesoscombobox()
        Dim listaPesos As New List(Of Decimal)()
        Dim paso As Decimal = 0.1

        While paso <= 20
            listaPesos.Add(paso)
            paso += 0.1
        End While
        ' Asignar la lista de decimales a la ComboBox
        MaterialComboBoxPesos.DataSource = listaPesos
        ' Opcional: Puedes manejar el evento SelectedIndexChanged para obtener el valor seleccionado

    End Sub



    Dim bytesDeLaImagen As Byte()

    Private Sub CargarInformacionMascnte()
        ' Utiliza la función ObtenerCliente para obtener la información del cliente
        DateTimePickerFin.Enabled = False
        DateTimePickerInicio.Enabled = False
        Dim mascoas As Mascotas = userDaomasc.ModelomostrarMascotasFRM(idMascota)
        Try

            ' Supongamos que obtienes los bytes de la imagen desde algún lugar
            bytesDeLaImagen = mascoas.Foto

            ' Llamada a la subrutina para mostrar la imagen

            ' Llena los controles del formulario con la información del cliente
            ' Por ejemplo:
            MaterialTextBoxNombreMascota.Text = mascoas.Nombre
            MaterialComboboxTipo.ValueMember = mascoas.IDTMascotaRAZA
            MaterialTextBoxColor.Text = mascoas.Color
            MaterialTextBoxColor.Text = mascoas.Color
            MaterialComboBoxRAZA.ValueMember = mascoas.IDRMascota

            Using m As New MemoryStream(mascoas.Foto)
                PictureBox1.Image = Image.FromStream(m)
            End Using


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
            DateTimePickerInicio.Enabled = False
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub




    Private Sub ButtonAceptar_Click(sender As Object, e As EventArgs) Handles ButtonAceptar.Click

        Dim valorVacunado As Integer
        Dim valorFalleció As Integer
        Dim eleccion As Byte()
        Dim ms As New MemoryStream()


        Try
            Using ms
                PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
                eleccion = ms.ToArray()
            End Using
        Catch
            eleccion = bytesDeLaImagen
        End Try
        ' Agrega el parámetro de imagen al comando

        ' Obtener el valor para la columna Vacunado
        If MaterialCheckboxVACUNADOSI.Checked Then
            valorVacunado = 1
        ElseIf MaterialCheckboxVACUNADONO.Checked Then
            valorVacunado = 0
        Else
            ' Manejar el caso en que ninguna opción esté seleccionada
            MessageBox.Show("Por favor, seleccione si la mascota está vacunada.")
            Return
        End If




        ' Obtener el valor para la columna falleció
        If MaterialCheckboxFALLECIDOSI.Checked Then
                valorFalleció = 1
            ElseIf MaterialCheckboxFALLECIDONO.Checked Then
                valorFalleció = 0
            Else
                ' Manejar el caso en que ninguna opción esté seleccionada
                MessageBox.Show("Por favor, seleccionar el partado de falleció.")
                Return
            End If


            Dim pesoSeleccionado As Decimal = Convert.ToDecimal(MaterialComboBoxPesos.SelectedItem)

            If MaterialTextBoxNombreMascota.Text <> "" Then

            Dim userModeldasc As New ModelosMascotas(iDMascota:=idMascota, IDCliente:=idCliente,
                                                 iDRMascota:=MaterialComboBoxRAZA.SelectedValue,
                                                 iDSeMascota:=MaterialComboBoxSexo.SelectedValue,
                                                 nombre:=MaterialTextBoxNombreMascota.Text,
                                                 peso:=pesoSeleccionado,
                                                 color:=MaterialTextBoxColor.Text,
                                                 esvacunado:=valorVacunado,
                                                 vacuna:=DateTimePickerInicio.Value,
                                                 vigVacuna:=DateTimePickerFin.Value,
                                                 foto:=eleccion, falleció:=valorFalleció)




            Dim result = userModeldasc.EditarMascotasModelo()
                MessageBox.Show(result)
            Else
                MsgBox("verifica los datos")

            End If





    End Sub

    Private Sub ButtonCambiar_Click(sender As Object, e As EventArgs) Handles ButtonCambiar.Click
        Dim openFileDialog As New OpenFileDialog()
        OpenFileDialog1.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png"
        OpenFileDialog1.Title = "Seleccione una imagen"


        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim selectedImagePath As String = openFileDialog.FileName
            Me.PictureBox1.Image = Image.FromFile(Me.OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub MaterialComboboxTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MaterialComboboxTipo.SelectedIndexChanged
        Dim userDaomasc As New ModelosMascotas()
        If MaterialComboboxTipo.SelectedIndex <> -1 Then
            ' Obtener el ID del Tipo de Mascota seleccionado
            Dim idTipoMascota As Integer = DirectCast(MaterialComboboxTipo.SelectedItem, Mascotas).IDTMascotaTIPO

            ' Llenar ComboBox de RazaMascota según el ID del Tipo de Mascota

            MaterialComboBoxRAZA.DataSource = userDaomasc.modelousuariomostrarEDITARMASCOTAS(idTipoMascota)
            MaterialComboBoxRAZA.DisplayMember = "NombreRAZA"
            MaterialComboBoxRAZA.ValueMember = "IDRMascotaRAZA"
        End If
    End Sub

End Class