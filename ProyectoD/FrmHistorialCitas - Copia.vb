Imports Común
Imports Dominio
Imports MaterialSkin
Public Class FrmHistorialCitas

    Inherits Form
    Dim userDaocitas As New ModeloCitas()
    Private ReadOnly idMascota As Integer

    ' Constructor que acepta el ID de la mascota como parámetro
    Public Sub New(ByVal idMascota As Integer)
        InitializeComponent()
        Me.idMascota = idMascota
    End Sub


    Private Sub Cargardatagrid()
        Try
            ' Obtener datos desde la capa de lógica de negocio
            Dim dataTable As DataTable = userDaocitas.ModeloHistorialCitasMascota(idMascota)
            If dataTable.Rows.Count <> 0 Then
                DataGridView1.DataSource = dataTable
            Else
                DataGridView1.DataSource = Nothing
            End If
        Catch
        End Try
    End Sub

    Private Sub FrmHistorialCitas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.AllowUserToAddRows = False
        Cargardatagrid()
        DataGridView1.ReadOnly = True
        DataGridView1.ClearSelection()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        ' Obtenemos el valor de la celda en la columna que contiene el ID de la mascota
        Dim idcita As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("IDCita").Value)

        ' Creamos una instancia del formulario Form2 y le pasamos el ID de la mascota
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.Cyan500, Primary.BlueGrey500, Accent.DeepPurple700, TextShade.WHITE)

        Dim form2 As New FrmMostrarInformacionCita(idcita)





        form2.Show()


    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.Cyan500, Primary.BlueGrey500, Accent.DeepPurple700, TextShade.WHITE)

        Me.Close()
    End Sub
End Class