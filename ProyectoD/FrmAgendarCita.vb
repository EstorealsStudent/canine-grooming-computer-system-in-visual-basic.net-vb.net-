Imports Común
Imports Dominio

Public Class FrmAgendarCita

    Inherits Form

    Private ReadOnly idmascota As Integer
    Private ReadOnly nombremascota As String
    Public Sub New(idmascota As Integer, nombremascota As String)
        InitializeComponent()
        Me.idmascota = idmascota
        Me.nombremascota = nombremascota
        cargarcomponentes()
    End Sub




    Dim userdaocitas As New ModeloCitas()

    Private Sub FrmAgendarCita_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaterialTextBoxPrimerNombre.Enabled = False
    End Sub


    Public Sub cargarcomponentes()

        MaterialComboBox1.DataSource = userdaocitas.modelomosostrarHorariocompleto()
            MaterialComboBox1.DisplayMember = "HORARIOCOMPLETO"
            MaterialComboBox1.ValueMember = "idHORARIO"

        MaterialTextBoxPrimerNombre.Text = nombremascota

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Me.Close()
    End Sub

    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
        Me.Close()
    End Sub

    Private Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles ButtonGuardar.Click
        Try

            Dim userModel As New ModeloCitas(idMascota:=idmascota,
            idhorario:=MaterialComboBox1.SelectedValue, idecita:=1, fechacita:=DateTimePickerInicio.Value, descripcion:=MaterialMultiLineTextBoxDescripcion.Text, IDUsuarioCrea:=UsuarioActivo.idUser)


            Dim result = userModel.insertarcitas()
            MessageBox.Show(result)

            Me.Close()




        Catch ex As Exception

        End Try


    End Sub
End Class