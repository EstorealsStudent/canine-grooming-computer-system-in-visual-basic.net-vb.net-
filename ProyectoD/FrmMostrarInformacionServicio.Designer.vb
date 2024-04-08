<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMostrarInformacionServicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMostrarInformacionServicio))
        Me.ButtonCerrar = New System.Windows.Forms.Button()
        Me.ButtonAceptar = New System.Windows.Forms.Button()
        Me.MaterialTextBox21 = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialComboBoxTServicio = New MaterialSkin.Controls.MaterialComboBox()
        Me.MaterialTextBoxPrimerNombre = New MaterialSkin.Controls.MaterialTextBox2()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonCerrar
        '
        Me.ButtonCerrar.BackColor = System.Drawing.Color.Crimson
        Me.ButtonCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Crimson
        Me.ButtonCerrar.FlatAppearance.BorderSize = 2
        Me.ButtonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCerrar.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCerrar.ForeColor = System.Drawing.Color.White
        Me.ButtonCerrar.Location = New System.Drawing.Point(586, 192)
        Me.ButtonCerrar.Margin = New System.Windows.Forms.Padding(50, 3, 50, 3)
        Me.ButtonCerrar.Name = "ButtonCerrar"
        Me.ButtonCerrar.Size = New System.Drawing.Size(90, 42)
        Me.ButtonCerrar.TabIndex = 75
        Me.ButtonCerrar.Text = "Cancelar"
        Me.ButtonCerrar.UseVisualStyleBackColor = False
        '
        'ButtonAceptar
        '
        Me.ButtonAceptar.BackColor = System.Drawing.Color.ForestGreen
        Me.ButtonAceptar.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.ButtonAceptar.FlatAppearance.BorderSize = 2
        Me.ButtonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAceptar.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAceptar.ForeColor = System.Drawing.Color.White
        Me.ButtonAceptar.Location = New System.Drawing.Point(685, 192)
        Me.ButtonAceptar.Margin = New System.Windows.Forms.Padding(50, 3, 50, 3)
        Me.ButtonAceptar.Name = "ButtonAceptar"
        Me.ButtonAceptar.Size = New System.Drawing.Size(90, 42)
        Me.ButtonAceptar.TabIndex = 74
        Me.ButtonAceptar.Text = "Guardar"
        Me.ButtonAceptar.UseVisualStyleBackColor = False
        '
        'MaterialTextBox21
        '
        Me.MaterialTextBox21.AnimateReadOnly = True
        Me.MaterialTextBox21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MaterialTextBox21.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.MaterialTextBox21.Depth = 0
        Me.MaterialTextBox21.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBox21.HideSelection = True
        Me.MaterialTextBox21.Hint = "Costo"
        Me.MaterialTextBox21.LeadingIcon = Nothing
        Me.MaterialTextBox21.LeaveOnEnterKey = True
        Me.MaterialTextBox21.Location = New System.Drawing.Point(21, 172)
        Me.MaterialTextBox21.MaxLength = 32767
        Me.MaterialTextBox21.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextBox21.Name = "MaterialTextBox21"
        Me.MaterialTextBox21.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialTextBox21.PrefixSuffixText = Nothing
        Me.MaterialTextBox21.ReadOnly = False
        Me.MaterialTextBox21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MaterialTextBox21.SelectedText = ""
        Me.MaterialTextBox21.SelectionLength = 0
        Me.MaterialTextBox21.SelectionStart = 0
        Me.MaterialTextBox21.ShortcutsEnabled = True
        Me.MaterialTextBox21.Size = New System.Drawing.Size(308, 48)
        Me.MaterialTextBox21.TabIndex = 73
        Me.MaterialTextBox21.TabStop = False
        Me.MaterialTextBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.MaterialTextBox21.TrailingIcon = Nothing
        Me.MaterialTextBox21.UseSystemPasswordChar = False
        '
        'MaterialComboBoxTServicio
        '
        Me.MaterialComboBoxTServicio.AutoResize = False
        Me.MaterialComboBoxTServicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialComboBoxTServicio.Depth = 0
        Me.MaterialComboBoxTServicio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.MaterialComboBoxTServicio.DropDownHeight = 174
        Me.MaterialComboBoxTServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MaterialComboBoxTServicio.DropDownWidth = 121
        Me.MaterialComboBoxTServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialComboBoxTServicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialComboBoxTServicio.FormattingEnabled = True
        Me.MaterialComboBoxTServicio.Hint = "Tipo de Servicio"
        Me.MaterialComboBoxTServicio.IntegralHeight = False
        Me.MaterialComboBoxTServicio.ItemHeight = 43
        Me.MaterialComboBoxTServicio.Location = New System.Drawing.Point(21, 63)
        Me.MaterialComboBoxTServicio.MaxDropDownItems = 4
        Me.MaterialComboBoxTServicio.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialComboBoxTServicio.Name = "MaterialComboBoxTServicio"
        Me.MaterialComboBoxTServicio.Size = New System.Drawing.Size(308, 49)
        Me.MaterialComboBoxTServicio.StartIndex = 0
        Me.MaterialComboBoxTServicio.TabIndex = 72
        '
        'MaterialTextBoxPrimerNombre
        '
        Me.MaterialTextBoxPrimerNombre.AnimateReadOnly = True
        Me.MaterialTextBoxPrimerNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MaterialTextBoxPrimerNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.MaterialTextBoxPrimerNombre.Depth = 0
        Me.MaterialTextBoxPrimerNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBoxPrimerNombre.HideSelection = True
        Me.MaterialTextBoxPrimerNombre.Hint = "Nombre del servicio"
        Me.MaterialTextBoxPrimerNombre.LeadingIcon = Nothing
        Me.MaterialTextBoxPrimerNombre.LeaveOnEnterKey = True
        Me.MaterialTextBoxPrimerNombre.Location = New System.Drawing.Point(21, 118)
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
        Me.MaterialTextBoxPrimerNombre.TabIndex = 71
        Me.MaterialTextBoxPrimerNombre.TabStop = False
        Me.MaterialTextBoxPrimerNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.MaterialTextBoxPrimerNombre.TrailingIcon = Nothing
        Me.MaterialTextBoxPrimerNombre.UseSystemPasswordChar = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.IconButton1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 57)
        Me.Panel1.TabIndex = 70
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Quicksand", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(90, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Editar Servicio:"
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
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SteelBlue
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(443, 120)
        Me.Button1.Margin = New System.Windows.Forms.Padding(50, 3, 50, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 42)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Editar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FrmMostrarInformacionServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 236)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonCerrar)
        Me.Controls.Add(Me.ButtonAceptar)
        Me.Controls.Add(Me.MaterialTextBox21)
        Me.Controls.Add(Me.MaterialComboBoxTServicio)
        Me.Controls.Add(Me.MaterialTextBoxPrimerNombre)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMostrarInformacionServicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Servicio"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonCerrar As Button
    Friend WithEvents ButtonAceptar As Button
    Friend WithEvents MaterialTextBox21 As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialComboBoxTServicio As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents MaterialTextBoxPrimerNombre As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Button1 As Button
End Class
