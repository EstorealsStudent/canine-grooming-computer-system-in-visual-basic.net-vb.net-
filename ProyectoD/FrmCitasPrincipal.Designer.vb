<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCitasPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCitasPrincipal))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MaterialRadioButton5 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.MaterialRadioButton4 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.MaterialRadioButton3 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.MaterialRadioButton2 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.MaterialRadioButton1 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Buttonrefescar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.MaterialRadioButton5)
        Me.Panel1.Controls.Add(Me.MaterialRadioButton4)
        Me.Panel1.Controls.Add(Me.MaterialRadioButton3)
        Me.Panel1.Controls.Add(Me.MaterialRadioButton2)
        Me.Panel1.Controls.Add(Me.MaterialRadioButton1)
        Me.Panel1.Controls.Add(Me.IconButton1)
        Me.Panel1.Controls.Add(Me.MonthCalendar1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(261, 550)
        Me.Panel1.TabIndex = 0
        '
        'MaterialRadioButton5
        '
        Me.MaterialRadioButton5.AutoSize = True
        Me.MaterialRadioButton5.Depth = 0
        Me.MaterialRadioButton5.Location = New System.Drawing.Point(49, 328)
        Me.MaterialRadioButton5.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialRadioButton5.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialRadioButton5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRadioButton5.Name = "MaterialRadioButton5"
        Me.MaterialRadioButton5.Ripple = True
        Me.MaterialRadioButton5.Size = New System.Drawing.Size(113, 37)
        Me.MaterialRadioButton5.TabIndex = 12
        Me.MaterialRadioButton5.TabStop = True
        Me.MaterialRadioButton5.Text = "Pendientes"
        Me.MaterialRadioButton5.UseVisualStyleBackColor = True
        '
        'MaterialRadioButton4
        '
        Me.MaterialRadioButton4.AutoSize = True
        Me.MaterialRadioButton4.Depth = 0
        Me.MaterialRadioButton4.Location = New System.Drawing.Point(49, 472)
        Me.MaterialRadioButton4.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialRadioButton4.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialRadioButton4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRadioButton4.Name = "MaterialRadioButton4"
        Me.MaterialRadioButton4.Ripple = True
        Me.MaterialRadioButton4.Size = New System.Drawing.Size(118, 37)
        Me.MaterialRadioButton4.TabIndex = 11
        Me.MaterialRadioButton4.TabStop = True
        Me.MaterialRadioButton4.Text = "Canceladas"
        Me.MaterialRadioButton4.UseVisualStyleBackColor = True
        '
        'MaterialRadioButton3
        '
        Me.MaterialRadioButton3.AutoSize = True
        Me.MaterialRadioButton3.Depth = 0
        Me.MaterialRadioButton3.Location = New System.Drawing.Point(49, 374)
        Me.MaterialRadioButton3.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialRadioButton3.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialRadioButton3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRadioButton3.Name = "MaterialRadioButton3"
        Me.MaterialRadioButton3.Ripple = True
        Me.MaterialRadioButton3.Size = New System.Drawing.Size(127, 37)
        Me.MaterialRadioButton3.TabIndex = 10
        Me.MaterialRadioButton3.TabStop = True
        Me.MaterialRadioButton3.Text = "Confirmadas"
        Me.MaterialRadioButton3.UseVisualStyleBackColor = True
        '
        'MaterialRadioButton2
        '
        Me.MaterialRadioButton2.AutoSize = True
        Me.MaterialRadioButton2.Depth = 0
        Me.MaterialRadioButton2.Location = New System.Drawing.Point(49, 421)
        Me.MaterialRadioButton2.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialRadioButton2.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialRadioButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRadioButton2.Name = "MaterialRadioButton2"
        Me.MaterialRadioButton2.Ripple = True
        Me.MaterialRadioButton2.Size = New System.Drawing.Size(129, 37)
        Me.MaterialRadioButton2.TabIndex = 9
        Me.MaterialRadioButton2.TabStop = True
        Me.MaterialRadioButton2.Text = "Completadas"
        Me.MaterialRadioButton2.UseVisualStyleBackColor = True
        '
        'MaterialRadioButton1
        '
        Me.MaterialRadioButton1.AutoSize = True
        Me.MaterialRadioButton1.Depth = 0
        Me.MaterialRadioButton1.Location = New System.Drawing.Point(49, 282)
        Me.MaterialRadioButton1.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialRadioButton1.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialRadioButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRadioButton1.Name = "MaterialRadioButton1"
        Me.MaterialRadioButton1.Ripple = True
        Me.MaterialRadioButton1.Size = New System.Drawing.Size(80, 37)
        Me.MaterialRadioButton1.TabIndex = 8
        Me.MaterialRadioButton1.TabStop = True
        Me.MaterialRadioButton1.Text = "Todas"
        Me.MaterialRadioButton1.UseVisualStyleBackColor = True
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.White
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.IconButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.MailReply
        Me.IconButton1.IconColor = System.Drawing.Color.Gold
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.Location = New System.Drawing.Point(-1, -1)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(95, 66)
        Me.IconButton1.TabIndex = 7
        Me.IconButton1.Text = "Regresar"
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.BackColor = System.Drawing.Color.White
        Me.MonthCalendar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthCalendar1.ForeColor = System.Drawing.Color.Black
        Me.MonthCalendar1.Location = New System.Drawing.Point(2, 67)
        Me.MonthCalendar1.MaxSelectionCount = 1
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.ShowToday = False
        Me.MonthCalendar1.ShowTodayCircle = False
        Me.MonthCalendar1.TabIndex = 0
        Me.MonthCalendar1.TitleBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MonthCalendar1.TitleForeColor = System.Drawing.Color.Black
        Me.MonthCalendar1.TrailingForeColor = System.Drawing.Color.Khaki
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(259, 65)
        Me.Panel2.TabIndex = 13
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeight = 30
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.SteelBlue
        Me.DataGridView1.Location = New System.Drawing.Point(267, 68)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(562, 470)
        Me.DataGridView1.TabIndex = 13
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(267, 42)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(85, 20)
        Me.DateTimePicker1.TabIndex = 14
        '
        'Buttonrefescar
        '
        Me.Buttonrefescar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Buttonrefescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Buttonrefescar.Image = Global.Petpalace.My.Resources.Resources.RefreshPivotTable_16x16
        Me.Buttonrefescar.Location = New System.Drawing.Point(358, 40)
        Me.Buttonrefescar.Name = "Buttonrefescar"
        Me.Buttonrefescar.Size = New System.Drawing.Size(22, 22)
        Me.Buttonrefescar.TabIndex = 32
        Me.Buttonrefescar.UseVisualStyleBackColor = False
        '
        'FrmCitasPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(841, 550)
        Me.Controls.Add(Me.Buttonrefescar)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCitasPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Citas Principal"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents MaterialRadioButton1 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents MaterialRadioButton5 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents MaterialRadioButton4 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents MaterialRadioButton3 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents MaterialRadioButton2 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Buttonrefescar As Button
    Friend WithEvents Panel2 As Panel
End Class
