<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAgregarRazaMascota
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAgregarRazaMascota))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.ButtonCerrar = New System.Windows.Forms.Button()
        Me.ButtonAceptar = New System.Windows.Forms.Button()
        Me.MaterialComboBoxTMascota = New MaterialSkin.Controls.MaterialComboBox()
        Me.MaterialTextBoxNombreDeRaza = New MaterialSkin.Controls.MaterialTextBox2()
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
        Me.Panel1.Size = New System.Drawing.Size(595, 57)
        Me.Panel1.TabIndex = 70
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Quicksand", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(90, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Agregar raza:"
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
        'ButtonCerrar
        '
        Me.ButtonCerrar.BackColor = System.Drawing.Color.Crimson
        Me.ButtonCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Crimson
        Me.ButtonCerrar.FlatAppearance.BorderSize = 2
        Me.ButtonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCerrar.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCerrar.ForeColor = System.Drawing.Color.White
        Me.ButtonCerrar.Location = New System.Drawing.Point(339, 221)
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
        Me.ButtonAceptar.Location = New System.Drawing.Point(501, 221)
        Me.ButtonAceptar.Margin = New System.Windows.Forms.Padding(50, 3, 50, 3)
        Me.ButtonAceptar.Name = "ButtonAceptar"
        Me.ButtonAceptar.Size = New System.Drawing.Size(85, 42)
        Me.ButtonAceptar.TabIndex = 74
        Me.ButtonAceptar.Text = "Guardar"
        Me.ButtonAceptar.UseVisualStyleBackColor = False
        '
        'MaterialComboBoxTMascota
        '
        Me.MaterialComboBoxTMascota.AutoResize = False
        Me.MaterialComboBoxTMascota.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialComboBoxTMascota.Depth = 0
        Me.MaterialComboBoxTMascota.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.MaterialComboBoxTMascota.DropDownHeight = 174
        Me.MaterialComboBoxTMascota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MaterialComboBoxTMascota.DropDownWidth = 121
        Me.MaterialComboBoxTMascota.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialComboBoxTMascota.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialComboBoxTMascota.FormattingEnabled = True
        Me.MaterialComboBoxTMascota.Hint = "Tipo de Mascota"
        Me.MaterialComboBoxTMascota.IntegralHeight = False
        Me.MaterialComboBoxTMascota.ItemHeight = 43
        Me.MaterialComboBoxTMascota.Location = New System.Drawing.Point(28, 72)
        Me.MaterialComboBoxTMascota.MaxDropDownItems = 4
        Me.MaterialComboBoxTMascota.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialComboBoxTMascota.Name = "MaterialComboBoxTMascota"
        Me.MaterialComboBoxTMascota.Size = New System.Drawing.Size(308, 49)
        Me.MaterialComboBoxTMascota.StartIndex = 0
        Me.MaterialComboBoxTMascota.TabIndex = 72
        '
        'MaterialTextBoxNombreDeRaza
        '
        Me.MaterialTextBoxNombreDeRaza.AnimateReadOnly = True
        Me.MaterialTextBoxNombreDeRaza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MaterialTextBoxNombreDeRaza.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.MaterialTextBoxNombreDeRaza.Depth = 0
        Me.MaterialTextBoxNombreDeRaza.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBoxNombreDeRaza.HideSelection = True
        Me.MaterialTextBoxNombreDeRaza.Hint = "Nombre de la raza"
        Me.MaterialTextBoxNombreDeRaza.LeadingIcon = Nothing
        Me.MaterialTextBoxNombreDeRaza.LeaveOnEnterKey = True
        Me.MaterialTextBoxNombreDeRaza.Location = New System.Drawing.Point(28, 168)
        Me.MaterialTextBoxNombreDeRaza.MaxLength = 32767
        Me.MaterialTextBoxNombreDeRaza.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextBoxNombreDeRaza.Name = "MaterialTextBoxNombreDeRaza"
        Me.MaterialTextBoxNombreDeRaza.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialTextBoxNombreDeRaza.PrefixSuffixText = Nothing
        Me.MaterialTextBoxNombreDeRaza.ReadOnly = False
        Me.MaterialTextBoxNombreDeRaza.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MaterialTextBoxNombreDeRaza.SelectedText = ""
        Me.MaterialTextBoxNombreDeRaza.SelectionLength = 0
        Me.MaterialTextBoxNombreDeRaza.SelectionStart = 0
        Me.MaterialTextBoxNombreDeRaza.ShortcutsEnabled = True
        Me.MaterialTextBoxNombreDeRaza.Size = New System.Drawing.Size(308, 48)
        Me.MaterialTextBoxNombreDeRaza.TabIndex = 71
        Me.MaterialTextBoxNombreDeRaza.TabStop = False
        Me.MaterialTextBoxNombreDeRaza.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.MaterialTextBoxNombreDeRaza.TrailingIcon = Nothing
        Me.MaterialTextBoxNombreDeRaza.UseSystemPasswordChar = False
        '
        'FrmAgregarRazaMascota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(595, 275)
        Me.Controls.Add(Me.ButtonCerrar)
        Me.Controls.Add(Me.ButtonAceptar)
        Me.Controls.Add(Me.MaterialComboBoxTMascota)
        Me.Controls.Add(Me.MaterialTextBoxNombreDeRaza)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAgregarRazaMascota"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Raza"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents ButtonCerrar As Button
    Friend WithEvents ButtonAceptar As Button
    Friend WithEvents MaterialComboBoxTMascota As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents MaterialTextBoxNombreDeRaza As MaterialSkin.Controls.MaterialTextBox2
End Class
