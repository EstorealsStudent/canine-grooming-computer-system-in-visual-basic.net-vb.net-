<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAgendarCita
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAgendarCita))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.MaterialTextBoxPrimerNombre = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialComboBox1 = New MaterialSkin.Controls.MaterialComboBox()
        Me.MaterialMultiLineTextBoxDescripcion = New MaterialSkin.Controls.MaterialMultiLineTextBox2()
        Me.ButtonCancelar = New System.Windows.Forms.Button()
        Me.ButtonGuardar = New System.Windows.Forms.Button()
        Me.DateTimePickerInicio = New System.Windows.Forms.DateTimePicker()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.IconButton1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 57)
        Me.Panel1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(74, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Agendar Cita"
        '
        'IconButton1
        '
        Me.IconButton1.Dock = System.Windows.Forms.DockStyle.Left
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.IconButton1.ForeColor = System.Drawing.SystemColors.Control
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.MailReply
        Me.IconButton1.IconColor = System.Drawing.Color.Gold
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.Location = New System.Drawing.Point(0, 0)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(95, 57)
        Me.IconButton1.TabIndex = 2
        Me.IconButton1.Text = "Regresar"
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'MaterialTextBoxPrimerNombre
        '
        Me.MaterialTextBoxPrimerNombre.AnimateReadOnly = True
        Me.MaterialTextBoxPrimerNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MaterialTextBoxPrimerNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.MaterialTextBoxPrimerNombre.Depth = 0
        Me.MaterialTextBoxPrimerNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBoxPrimerNombre.HideSelection = True
        Me.MaterialTextBoxPrimerNombre.Hint = "Nombre de la mascota"
        Me.MaterialTextBoxPrimerNombre.LeadingIcon = Nothing
        Me.MaterialTextBoxPrimerNombre.LeaveOnEnterKey = True
        Me.MaterialTextBoxPrimerNombre.Location = New System.Drawing.Point(28, 85)
        Me.MaterialTextBoxPrimerNombre.MaxLength = 32767
        Me.MaterialTextBoxPrimerNombre.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextBoxPrimerNombre.Name = "MaterialTextBoxPrimerNombre"
        Me.MaterialTextBoxPrimerNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialTextBoxPrimerNombre.PrefixSuffixText = Nothing
        Me.MaterialTextBoxPrimerNombre.ReadOnly = False
        Me.MaterialTextBoxPrimerNombre.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MaterialTextBoxPrimerNombre.SelectedText = ""
        Me.MaterialTextBoxPrimerNombre.SelectionLength = 0
        Me.MaterialTextBoxPrimerNombre.SelectionStart = 0
        Me.MaterialTextBoxPrimerNombre.ShortcutsEnabled = True
        Me.MaterialTextBoxPrimerNombre.Size = New System.Drawing.Size(308, 48)
        Me.MaterialTextBoxPrimerNombre.TabIndex = 9
        Me.MaterialTextBoxPrimerNombre.TabStop = False
        Me.MaterialTextBoxPrimerNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.MaterialTextBoxPrimerNombre.TrailingIcon = Nothing
        Me.MaterialTextBoxPrimerNombre.UseSystemPasswordChar = False
        '
        'MaterialComboBox1
        '
        Me.MaterialComboBox1.AutoResize = False
        Me.MaterialComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialComboBox1.Depth = 0
        Me.MaterialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.MaterialComboBox1.DropDownHeight = 174
        Me.MaterialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MaterialComboBox1.DropDownWidth = 121
        Me.MaterialComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialComboBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialComboBox1.FormattingEnabled = True
        Me.MaterialComboBox1.Hint = "Horario"
        Me.MaterialComboBox1.IntegralHeight = False
        Me.MaterialComboBox1.ItemHeight = 43
        Me.MaterialComboBox1.Location = New System.Drawing.Point(28, 165)
        Me.MaterialComboBox1.MaxDropDownItems = 4
        Me.MaterialComboBox1.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialComboBox1.Name = "MaterialComboBox1"
        Me.MaterialComboBox1.Size = New System.Drawing.Size(308, 49)
        Me.MaterialComboBox1.StartIndex = 0
        Me.MaterialComboBox1.TabIndex = 18
        '
        'MaterialMultiLineTextBoxDescripcion
        '
        Me.MaterialMultiLineTextBoxDescripcion.AnimateReadOnly = True
        Me.MaterialMultiLineTextBoxDescripcion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MaterialMultiLineTextBoxDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.MaterialMultiLineTextBoxDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.MaterialMultiLineTextBoxDescripcion.Depth = 0
        Me.MaterialMultiLineTextBoxDescripcion.HideSelection = True
        Me.MaterialMultiLineTextBoxDescripcion.Hint = "Instrucciones especiales para la mascota"
        Me.MaterialMultiLineTextBoxDescripcion.Location = New System.Drawing.Point(342, 85)
        Me.MaterialMultiLineTextBoxDescripcion.MaxLength = 32767
        Me.MaterialMultiLineTextBoxDescripcion.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialMultiLineTextBoxDescripcion.Name = "MaterialMultiLineTextBoxDescripcion"
        Me.MaterialMultiLineTextBoxDescripcion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialMultiLineTextBoxDescripcion.ReadOnly = False
        Me.MaterialMultiLineTextBoxDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MaterialMultiLineTextBoxDescripcion.SelectedText = ""
        Me.MaterialMultiLineTextBoxDescripcion.SelectionLength = 0
        Me.MaterialMultiLineTextBoxDescripcion.SelectionStart = 0
        Me.MaterialMultiLineTextBoxDescripcion.ShortcutsEnabled = True
        Me.MaterialMultiLineTextBoxDescripcion.Size = New System.Drawing.Size(446, 220)
        Me.MaterialMultiLineTextBoxDescripcion.TabIndex = 33
        Me.MaterialMultiLineTextBoxDescripcion.TabStop = False
        Me.MaterialMultiLineTextBoxDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.MaterialMultiLineTextBoxDescripcion.UseSystemPasswordChar = False
        '
        'ButtonCancelar
        '
        Me.ButtonCancelar.BackColor = System.Drawing.Color.Crimson
        Me.ButtonCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Crimson
        Me.ButtonCancelar.FlatAppearance.BorderSize = 2
        Me.ButtonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCancelar.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancelar.ForeColor = System.Drawing.Color.White
        Me.ButtonCancelar.Location = New System.Drawing.Point(575, 342)
        Me.ButtonCancelar.Margin = New System.Windows.Forms.Padding(50, 3, 50, 3)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(90, 42)
        Me.ButtonCancelar.TabIndex = 69
        Me.ButtonCancelar.Text = "Cancelar"
        Me.ButtonCancelar.UseVisualStyleBackColor = False
        '
        'ButtonGuardar
        '
        Me.ButtonGuardar.BackColor = System.Drawing.Color.ForestGreen
        Me.ButtonGuardar.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.ButtonGuardar.FlatAppearance.BorderSize = 2
        Me.ButtonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonGuardar.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGuardar.ForeColor = System.Drawing.Color.White
        Me.ButtonGuardar.Location = New System.Drawing.Point(698, 342)
        Me.ButtonGuardar.Margin = New System.Windows.Forms.Padding(50, 3, 50, 3)
        Me.ButtonGuardar.Name = "ButtonGuardar"
        Me.ButtonGuardar.Size = New System.Drawing.Size(90, 42)
        Me.ButtonGuardar.TabIndex = 68
        Me.ButtonGuardar.Text = "Registrar"
        Me.ButtonGuardar.UseVisualStyleBackColor = False
        '
        'DateTimePickerInicio
        '
        Me.DateTimePickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerInicio.Location = New System.Drawing.Point(28, 139)
        Me.DateTimePickerInicio.Name = "DateTimePickerInicio"
        Me.DateTimePickerInicio.Size = New System.Drawing.Size(308, 20)
        Me.DateTimePickerInicio.TabIndex = 70
        '
        'FrmAgendarCita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 396)
        Me.Controls.Add(Me.DateTimePickerInicio)
        Me.Controls.Add(Me.ButtonCancelar)
        Me.Controls.Add(Me.ButtonGuardar)
        Me.Controls.Add(Me.MaterialMultiLineTextBoxDescripcion)
        Me.Controls.Add(Me.MaterialComboBox1)
        Me.Controls.Add(Me.MaterialTextBoxPrimerNombre)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAgendarCita"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AgendarCita"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents MaterialTextBoxPrimerNombre As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialComboBox1 As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents MaterialMultiLineTextBoxDescripcion As MaterialSkin.Controls.MaterialMultiLineTextBox2
    Friend WithEvents ButtonCancelar As Button
    Friend WithEvents ButtonGuardar As Button
    Friend WithEvents DateTimePickerInicio As DateTimePicker
End Class
