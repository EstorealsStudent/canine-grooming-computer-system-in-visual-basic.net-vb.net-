Imports Dominio
Imports Común
Imports MaterialSkin
Public Class FrmCitasPrincipal


    Dim userdaocitas As New ModeloCitas()

    Private Sub FrmCitasPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.Cyan500, Primary.BlueGrey500, Accent.Cyan700, TextShade.WHITE)


        DataGridView1.AllowUserToAddRows = False
        DataGridView1.ReadOnly = True
        MonthCalendar1.SelectionStart = Date.Now
        MaterialRadioButton1.Checked = True

        Try
            ' Obtener datos desde la capa de lógica de negocio
            Dim dataTable As DataTable = userdaocitas.modelousuariotraercitasdelprincipio(Date.Today)
            If dataTable.Rows.Count <> 0 Then
                DataGridView1.DataSource = dataTable
            Else
                DataGridView1.DataSource = Nothing
            End If
        Catch
        End Try

    End Sub



    Private Sub MonthCalendar1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateSelected

        ' Obtener la fecha seleccionada
        Dim fechaSeleccionada As DateTime = e.Start

        ' Verificar qué radio button está seleccionado
        'radio button1= TODAS
        If MaterialRadioButton1.Checked Then
            Try
                ' Obtener datos desde la capa de lógica de negocio
                Dim dataTable As DataTable = userdaocitas.modelousuariotraercitasdelprincipio(fechaSeleccionada)
                If dataTable.Rows.Count <> 0 Then
                    DataGridView1.DataSource = dataTable
                Else
                    DataGridView1.DataSource = Nothing
                End If
            Catch
            End Try
            'completadas
        ElseIf MaterialRadioButton2.Checked Then
            Try
                ' Obtener datos desde la capa de lógica de negocio
                Dim dataTable As DataTable = userdaocitas.modelocitascompletadas(fechaSeleccionada)
                If dataTable.Rows.Count <> 0 Then
                    DataGridView1.DataSource = dataTable
                Else
                    DataGridView1.DataSource = Nothing
                End If
            Catch
            End Try
            'confirmadas
        ElseIf MaterialRadioButton3.Checked Then

            Try
                ' Obtener datos desde la capa de lógica de negocio
                Dim dataTable As DataTable = userdaocitas.modelocitasconfirmadas(fechaSeleccionada)
                If dataTable.Rows.Count <> 0 Then
                    DataGridView1.DataSource = dataTable
                Else
                    DataGridView1.DataSource = Nothing
                End If
            Catch
            End Try

            'canceladas
        ElseIf MaterialRadioButton4.Checked Then

            Try
                ' Obtener datos desde la capa de lógica de negocio
                Dim dataTable As DataTable = userdaocitas.modelocitascanceladas(fechaSeleccionada)
                If dataTable.Rows.Count <> 0 Then
                    DataGridView1.DataSource = dataTable
                Else
                    DataGridView1.DataSource = Nothing
                End If
            Catch
            End Try

            'citas pendientes
        ElseIf MaterialRadioButton5.Checked Then
            Try
                ' Obtener datos desde la capa de lógica de negocio
                Dim dataTable As DataTable = userdaocitas.modelocitaspendientes(fechaSeleccionada)
                If dataTable.Rows.Count <> 0 Then
                    DataGridView1.DataSource = dataTable
                Else
                    DataGridView1.DataSource = Nothing
                End If
            Catch
            End Try
        End If

        DateTimePicker1.Value = fechaSeleccionada
    End Sub

    'todos
    Private Sub MaterialRadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialRadioButton1.CheckedChanged
        If MaterialRadioButton1.Checked Then
            Try
                ' Obtener datos desde la capa de lógica de negocio
                Dim dataTable As DataTable = userdaocitas.modelousuariotraercitasdelprincipio(DateTimePicker1.Value)
                If dataTable.Rows.Count <> 0 Then
                    DataGridView1.DataSource = dataTable
                Else
                    DataGridView1.DataSource = Nothing
                End If
            Catch
            End Try
        End If
    End Sub

    'pendientes
    Private Sub MaterialRadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialRadioButton5.CheckedChanged
        Try
            ' Obtener datos desde la capa de lógica de negocio
            Dim dataTable As DataTable = userdaocitas.modelocitaspendientes(DateTimePicker1.Value)
            If dataTable.Rows.Count <> 0 Then
                DataGridView1.DataSource = dataTable
            Else
                DataGridView1.DataSource = Nothing
            End If
        Catch
        End Try
    End Sub

    'confirmadas
    Private Sub MaterialRadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialRadioButton3.CheckedChanged
        Try
            ' Obtener datos desde la capa de lógica de negocio
            Dim dataTable As DataTable = userdaocitas.modelocitasconfirmadas(DateTimePicker1.Value)
            If dataTable.Rows.Count <> 0 Then
                DataGridView1.DataSource = dataTable
            Else
                DataGridView1.DataSource = Nothing
            End If
        Catch
        End Try
    End Sub

    'completada
    Private Sub MaterialRadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialRadioButton2.CheckedChanged
        Try
            ' Obtener datos desde la capa de lógica de negocio
            Dim dataTable As DataTable = userdaocitas.modelocitascompletadas(DateTimePicker1.Value)
            If dataTable.Rows.Count <> 0 Then
                DataGridView1.DataSource = dataTable
            Else
                DataGridView1.DataSource = Nothing
            End If
        Catch
        End Try
    End Sub
    'cancelada
    Private Sub MaterialRadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialRadioButton4.CheckedChanged

        Try
            ' Obtener datos desde la capa de lógica de negocio
            Dim dataTable As DataTable = userdaocitas.modelocitascanceladas(DateTimePicker1.Value)
            If dataTable.Rows.Count <> 0 Then
                DataGridView1.DataSource = dataTable
            Else
                DataGridView1.DataSource = Nothing
            End If
        Catch
        End Try
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

    Private Sub Buttonrefescar_Click(sender As Object, e As EventArgs) Handles Buttonrefescar.Click
        Try
            ' Obtener datos desde la capa de lógica de negocio
            Dim dataTable As DataTable = userdaocitas.modelousuariotraercitasdelprincipio(DateTimePicker1.Value)
            If dataTable.Rows.Count <> 0 Then
                DataGridView1.DataSource = dataTable
            Else
                DataGridView1.DataSource = Nothing
            End If
        Catch
        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class