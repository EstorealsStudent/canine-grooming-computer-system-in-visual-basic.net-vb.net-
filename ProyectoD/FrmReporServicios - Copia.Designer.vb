<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReporServicios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportVentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MejoresServiciosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.ButtonAplicar = New System.Windows.Forms.Button()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Button30dias = New System.Windows.Forms.Button()
        Me.ButtonElAño = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonMes = New System.Windows.Forms.Button()
        Me.Personalizado = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button7Dias = New System.Windows.Forms.Button()
        Me.ButtonHoy = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.ReportVentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MejoresServiciosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ReportVentasBindingSource
        '
        Me.ReportVentasBindingSource.DataSource = GetType(Dominio.ReportVentas)
        '
        'MejoresServiciosBindingSource
        '
        Me.MejoresServiciosBindingSource.DataSource = GetType(Dominio.MejoresServicios)
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Right
        ReportDataSource1.Name = "ReporteventasDT"
        ReportDataSource1.Value = Me.ReportVentasBindingSource
        ReportDataSource2.Name = "MejoresServiciosDT"
        ReportDataSource2.Value = Me.MejoresServiciosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoD.MejoresServiciosrdlc.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(206, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(661, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Panel1.Controls.Add(Me.IconButton1)
        Me.Panel1.Controls.Add(Me.ButtonAplicar)
        Me.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.Panel1.Controls.Add(Me.Button30dias)
        Me.Panel1.Controls.Add(Me.ButtonElAño)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.ButtonMes)
        Me.Panel1.Controls.Add(Me.Personalizado)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.Button7Dias)
        Me.Panel1.Controls.Add(Me.ButtonHoy)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 450)
        Me.Panel1.TabIndex = 1
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.IconButton1.ForeColor = System.Drawing.SystemColors.Control
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.MailReply
        Me.IconButton1.IconColor = System.Drawing.Color.Gold
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.Location = New System.Drawing.Point(3, 3)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(95, 66)
        Me.IconButton1.TabIndex = 12
        Me.IconButton1.Text = "Regresar"
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'ButtonAplicar
        '
        Me.ButtonAplicar.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonAplicar.Location = New System.Drawing.Point(22, 378)
        Me.ButtonAplicar.Name = "ButtonAplicar"
        Me.ButtonAplicar.Size = New System.Drawing.Size(148, 23)
        Me.ButtonAplicar.TabIndex = 11
        Me.ButtonAplicar.Text = "Aplicar"
        Me.ButtonAplicar.UseVisualStyleBackColor = False
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(58, 352)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(83, 20)
        Me.DateTimePicker2.TabIndex = 10
        '
        'Button30dias
        '
        Me.Button30dias.BackColor = System.Drawing.SystemColors.Control
        Me.Button30dias.Location = New System.Drawing.Point(22, 135)
        Me.Button30dias.Name = "Button30dias"
        Me.Button30dias.Size = New System.Drawing.Size(148, 23)
        Me.Button30dias.TabIndex = 3
        Me.Button30dias.Text = "Ultimos 30 dias"
        Me.Button30dias.UseVisualStyleBackColor = False
        '
        'ButtonElAño
        '
        Me.ButtonElAño.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonElAño.Location = New System.Drawing.Point(22, 164)
        Me.ButtonElAño.Name = "ButtonElAño"
        Me.ButtonElAño.Size = New System.Drawing.Size(148, 23)
        Me.ButtonElAño.TabIndex = 4
        Me.ButtonElAño.Text = "Año"
        Me.ButtonElAño.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(18, 352)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "A:"
        '
        'ButtonMes
        '
        Me.ButtonMes.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonMes.Location = New System.Drawing.Point(22, 106)
        Me.ButtonMes.Name = "ButtonMes"
        Me.ButtonMes.Size = New System.Drawing.Size(148, 23)
        Me.ButtonMes.TabIndex = 2
        Me.ButtonMes.Text = "Mes"
        Me.ButtonMes.UseVisualStyleBackColor = False
        '
        'Personalizado
        '
        Me.Personalizado.BackColor = System.Drawing.SystemColors.Control
        Me.Personalizado.Location = New System.Drawing.Point(22, 273)
        Me.Personalizado.Name = "Personalizado"
        Me.Personalizado.Size = New System.Drawing.Size(148, 23)
        Me.Personalizado.TabIndex = 5
        Me.Personalizado.Text = "Personalizado"
        Me.Personalizado.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(58, 315)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(83, 20)
        Me.DateTimePicker1.TabIndex = 8
        '
        'Button7Dias
        '
        Me.Button7Dias.BackColor = System.Drawing.SystemColors.Control
        Me.Button7Dias.Location = New System.Drawing.Point(22, 193)
        Me.Button7Dias.Name = "Button7Dias"
        Me.Button7Dias.Size = New System.Drawing.Size(148, 23)
        Me.Button7Dias.TabIndex = 1
        Me.Button7Dias.Text = "Ultimos 7 dias"
        Me.Button7Dias.UseVisualStyleBackColor = False
        '
        'ButtonHoy
        '
        Me.ButtonHoy.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonHoy.Location = New System.Drawing.Point(22, 77)
        Me.ButtonHoy.Name = "ButtonHoy"
        Me.ButtonHoy.Size = New System.Drawing.Size(148, 23)
        Me.ButtonHoy.TabIndex = 0
        Me.ButtonHoy.Text = "Hoy"
        Me.ButtonHoy.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(18, 316)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "De:"
        '
        'FrmReporServicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmReporServicios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmReporServicios"
        CType(Me.ReportVentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MejoresServiciosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReportVentasBindingSource As BindingSource
    Friend WithEvents MejoresServiciosBindingSource As BindingSource
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ButtonAplicar As Button
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Personalizado As Button
    Friend WithEvents ButtonElAño As Button
    Friend WithEvents Button30dias As Button
    Friend WithEvents ButtonMes As Button
    Friend WithEvents Button7Dias As Button
    Friend WithEvents ButtonHoy As Button
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
End Class
