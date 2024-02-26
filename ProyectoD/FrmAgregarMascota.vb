Imports System.IO
Imports Común
Imports Dominio


Public Class FrmAgregarMascota
    Dim userDaomasc As New ModelosMascotas()


    Private ReadOnly IdClienteparamascota As Integer

    Public Sub New(IdClienteparamascota As Integer)
        InitializeComponent()

        Me.IdClienteparamascota = IdClienteparamascota
        InitializeComponentmascotas()
    End Sub






    Private Sub ButtonCerrar_Click(sender As Object, e As EventArgs) Handles ButtonCerrar.Click
        Me.Close()
    End Sub

    Private Sub FrmAgregarMascota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Pesoscombobox()
        actualizardatetimepicker()

        DateTimePickerInicio.MaxDate = DateTime.Today

    End Sub

    Private Sub InitializeComponentmascotas()
        DateTimePickerFin.Enabled = False
        DateTimePickerInicio.Enabled = False

        Try
            MaterialComboboxTipo.DataSource = userDaomasc.modelousuariomostrarTIPOSMASCOTAS()
            MaterialComboboxTipo.DisplayMember = "NombreTIPO"
            MaterialComboboxTipo.ValueMember = "IDTMascotaTIPO"

            'SexoMascotas
            MaterialComboBoxSexo.DataSource = userDaomasc.modelousuariomostrarSEXOSMASCOTAS()
            MaterialComboBoxSexo.DisplayMember = "NombreSEX"
            MaterialComboBoxSexo.ValueMember = "IDSeMascotaSEX"

            'raza




        Catch
            MsgBox("Error")
        End Try
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

    Private Sub ButtonCambiar_Click(sender As Object, e As EventArgs) Handles ButtonCambiar.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png"
        openFileDialog.Title = "Seleccione una imagen"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim selectedImagePath As String = openFileDialog.FileName
            PictureBox1.ImageLocation = selectedImagePath
        End If
    End Sub

    Private Sub ButtonAceptar_Click(sender As Object, e As EventArgs) Handles ButtonAceptar.Click
        Try

            Dim valorVacunado As Integer
            Dim valorFalleció As Integer
            Dim imagenBytes As Byte()

            ' Convertir la imagen a un array de bytes
            Dim ms As New MemoryStream()
            PictureBox1.Image.Save(ms, Me.PictureBox1.Image.RawFormat)
            imagenBytes = ms.GetBuffer




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


            valorFalleció = 0



            Dim pesoSeleccionado As Decimal = Convert.ToDecimal(MaterialComboBoxPesos.SelectedItem)

            If MaterialTextBoxNombreMascota.Text <> "" AndAlso imagenBytes IsNot Nothing Then

                Dim userModeldasc As New ModelosMascotas(iDCliente:=IdClienteparamascota,
                                                 iDRMascota:=MaterialComboBoxRAZA.SelectedValue,
                                                 iDSeMascota:=MaterialComboBoxSexo.SelectedValue,
                                                 nombre:=MaterialTextBoxNombreMascota.Text,
                                                 peso:=pesoSeleccionado,
                                                 color:=MaterialTextBoxColor.Text,
                                                 esvacunado:=valorVacunado,
                                                 vacuna:=DateTimePickerInicio.Value,
                                                 vigVacuna:=DateTimePickerFin.Value,
                                                 foto:=imagenBytes, falleció:=valorFalleció, IDUsuarioCrea:=UsuarioActivo.idUser)




                Dim result = userModeldasc.modeloinsertarMascotas()
                MessageBox.Show(result)

                Reseterarcajas()
            Else
                MsgBox("verifica los datos")
            End If
        Catch
            MsgBox("debes ingresar una foto para la mascota")

        End Try




    End Sub

    Private Sub Pesoscombobox()
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



    Private Sub MaterialCheckboxVACUNADOSI_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialCheckboxVACUNADOSI.CheckedChanged
        If MaterialCheckboxVACUNADOSI.Checked Then
            MaterialCheckboxVACUNADONO.Checked = False
            DateTimePickerInicio.Enabled = True
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


    Private Sub DateTimePickerInicio_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerInicio.ValueChanged
        actualizardatetimepicker()
        ActualizarColorDateTimePickerFin()

    End Sub

    Private Sub actualizardatetimepicker()
        Try
            Dim fechaInicio As DateTime = DateTimePickerInicio.Value

            ' Agregar un año a la fecha seleccionada
            Dim fechaFin As DateTime = fechaInicio.AddYears(1)

            ' Establecer la nueva fecha en el dateTimePickerFin
            DateTimePickerFin.Value = fechaFin

        Catch
        End Try
        ActualizarColorDateTimePickerFin()

    End Sub



    Private Sub ActualizarColorDateTimePickerFin()
        Dim fechaFin As DateTime = DateTimePickerFin.Value
        Dim fechaHoy As DateTime = DateTime.Today

        ' Verificar si el CheckBox está activado y la fecha de fin ha pasado
        If MaterialCheckboxVACUNADOSI.Checked AndAlso fechaFin <= fechaHoy Then
            ' Cambiar el color a rojo
            Panel3.BackColor = Color.Red
        Else
            ' Cambiar el color a verde
            Panel3.BackColor = Color.ForestGreen
        End If
    End Sub



    Public Sub Reseterarcajas()
        MaterialTextBoxNombreMascota.Clear()
        MaterialComboboxTipo.Refresh()
        MaterialComboBoxSexo.Refresh()
        MaterialComboBoxRAZA.Refresh()
        MaterialComboBoxPesos.Refresh()
        MaterialTextBoxColor.Clear()
        MaterialCheckboxVACUNADONO.Checked = False
        MaterialCheckboxVACUNADOSI.Checked = False
        DateTimePickerInicio.Value = DateTime.Today
        DateTimePickerFin.Value = DateTime.Today
        PictureBox1.Image = Nothing

    End Sub


End Class