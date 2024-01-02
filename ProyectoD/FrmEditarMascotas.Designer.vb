<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEditarMascotas
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
        Me.Fallecido = New System.Windows.Forms.Label()
        Me.MaterialCheckboxVACUNADONO = New MaterialSkin.Controls.MaterialCheckbox()
        Me.MaterialCheckboxFALLECIDONO = New MaterialSkin.Controls.MaterialCheckbox()
        Me.MaterialCheckboxVACUNADOSI = New MaterialSkin.Controls.MaterialCheckbox()
        Me.MaterialCheckboxFALLECIDOSI = New MaterialSkin.Controls.MaterialCheckbox()
        Me.ButtonAceptar = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ButtonCambiar = New System.Windows.Forms.Button()
        Me.DateTimePickerFin = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePickerInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MaterialTextBoxColor = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialComboBoxPesos = New MaterialSkin.Controls.MaterialComboBox()
        Me.MaterialTextBoxNombreMascota = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialComboboxTipo = New MaterialSkin.Controls.MaterialComboBox()
        Me.MaterialComboBoxRAZA = New MaterialSkin.Controls.MaterialComboBox()
        Me.MaterialComboBoxSexo = New MaterialSkin.Controls.MaterialComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelVerInformacionMacot = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Fallecido
        '
        Me.Fallecido.AutoSize = True
        Me.Fallecido.Font = New System.Drawing.Font("Quicksand", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fallecido.Location = New System.Drawing.Point(430, 243)
        Me.Fallecido.Name = "Fallecido"
        Me.Fallecido.Size = New System.Drawing.Size(81, 19)
        Me.Fallecido.TabIndex = 58
        Me.Fallecido.Text = "Fallecido"
        '
        'MaterialCheckboxVACUNADONO
        '
        Me.MaterialCheckboxVACUNADONO.AutoSize = True
        Me.MaterialCheckboxVACUNADONO.Depth = 0
        Me.MaterialCheckboxVACUNADONO.Location = New System.Drawing.Point(505, 212)
        Me.MaterialCheckboxVACUNADONO.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialCheckboxVACUNADONO.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialCheckboxVACUNADONO.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCheckboxVACUNADONO.Name = "MaterialCheckboxVACUNADONO"
        Me.MaterialCheckboxVACUNADONO.ReadOnly = False
        Me.MaterialCheckboxVACUNADONO.Ripple = True
        Me.MaterialCheckboxVACUNADONO.Size = New System.Drawing.Size(55, 37)
        Me.MaterialCheckboxVACUNADONO.TabIndex = 64
        Me.MaterialCheckboxVACUNADONO.Text = "No"
        Me.MaterialCheckboxVACUNADONO.UseVisualStyleBackColor = True
        '
        'MaterialCheckboxFALLECIDONO
        '
        Me.MaterialCheckboxFALLECIDONO.AutoSize = True
        Me.MaterialCheckboxFALLECIDONO.Depth = 0
        Me.MaterialCheckboxFALLECIDONO.Location = New System.Drawing.Point(505, 262)
        Me.MaterialCheckboxFALLECIDONO.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialCheckboxFALLECIDONO.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialCheckboxFALLECIDONO.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCheckboxFALLECIDONO.Name = "MaterialCheckboxFALLECIDONO"
        Me.MaterialCheckboxFALLECIDONO.ReadOnly = False
        Me.MaterialCheckboxFALLECIDONO.Ripple = True
        Me.MaterialCheckboxFALLECIDONO.Size = New System.Drawing.Size(55, 37)
        Me.MaterialCheckboxFALLECIDONO.TabIndex = 63
        Me.MaterialCheckboxFALLECIDONO.Text = "No"
        Me.MaterialCheckboxFALLECIDONO.UseVisualStyleBackColor = True
        '
        'MaterialCheckboxVACUNADOSI
        '
        Me.MaterialCheckboxVACUNADOSI.AutoSize = True
        Me.MaterialCheckboxVACUNADOSI.Depth = 0
        Me.MaterialCheckboxVACUNADOSI.Location = New System.Drawing.Point(391, 212)
        Me.MaterialCheckboxVACUNADOSI.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialCheckboxVACUNADOSI.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialCheckboxVACUNADOSI.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCheckboxVACUNADOSI.Name = "MaterialCheckboxVACUNADOSI"
        Me.MaterialCheckboxVACUNADOSI.ReadOnly = False
        Me.MaterialCheckboxVACUNADOSI.Ripple = True
        Me.MaterialCheckboxVACUNADOSI.Size = New System.Drawing.Size(49, 37)
        Me.MaterialCheckboxVACUNADOSI.TabIndex = 62
        Me.MaterialCheckboxVACUNADOSI.Text = "Si"
        Me.MaterialCheckboxVACUNADOSI.UseVisualStyleBackColor = True
        '
        'MaterialCheckboxFALLECIDOSI
        '
        Me.MaterialCheckboxFALLECIDOSI.AutoSize = True
        Me.MaterialCheckboxFALLECIDOSI.Depth = 0
        Me.MaterialCheckboxFALLECIDOSI.Location = New System.Drawing.Point(391, 262)
        Me.MaterialCheckboxFALLECIDOSI.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialCheckboxFALLECIDOSI.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialCheckboxFALLECIDOSI.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCheckboxFALLECIDOSI.Name = "MaterialCheckboxFALLECIDOSI"
        Me.MaterialCheckboxFALLECIDOSI.ReadOnly = False
        Me.MaterialCheckboxFALLECIDOSI.Ripple = True
        Me.MaterialCheckboxFALLECIDOSI.Size = New System.Drawing.Size(49, 37)
        Me.MaterialCheckboxFALLECIDOSI.TabIndex = 61
        Me.MaterialCheckboxFALLECIDOSI.Text = "Si"
        Me.MaterialCheckboxFALLECIDOSI.UseVisualStyleBackColor = True
        '
        'ButtonAceptar
        '
        Me.ButtonAceptar.BackColor = System.Drawing.Color.ForestGreen
        Me.ButtonAceptar.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.ButtonAceptar.FlatAppearance.BorderSize = 2
        Me.ButtonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAceptar.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAceptar.ForeColor = System.Drawing.Color.White
        Me.ButtonAceptar.Location = New System.Drawing.Point(698, 396)
        Me.ButtonAceptar.Margin = New System.Windows.Forms.Padding(50, 3, 50, 3)
        Me.ButtonAceptar.Name = "ButtonAceptar"
        Me.ButtonAceptar.Size = New System.Drawing.Size(85, 42)
        Me.ButtonAceptar.TabIndex = 59
        Me.ButtonAceptar.Text = "Guardar"
        Me.ButtonAceptar.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gray
        Me.Panel3.Location = New System.Drawing.Point(747, 157)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(20, 20)
        Me.Panel3.TabIndex = 45
        '
        'ButtonCambiar
        '
        Me.ButtonCambiar.BackColor = System.Drawing.Color.SteelBlue
        Me.ButtonCambiar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.ButtonCambiar.FlatAppearance.BorderSize = 2
        Me.ButtonCambiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCambiar.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCambiar.ForeColor = System.Drawing.Color.White
        Me.ButtonCambiar.Location = New System.Drawing.Point(42, 220)
        Me.ButtonCambiar.Margin = New System.Windows.Forms.Padding(50, 3, 50, 3)
        Me.ButtonCambiar.Name = "ButtonCambiar"
        Me.ButtonCambiar.Size = New System.Drawing.Size(85, 42)
        Me.ButtonCambiar.TabIndex = 57
        Me.ButtonCambiar.Text = "Cambiar"
        Me.ButtonCambiar.UseVisualStyleBackColor = False
        '
        'DateTimePickerFin
        '
        Me.DateTimePickerFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerFin.Location = New System.Drawing.Point(595, 157)
        Me.DateTimePickerFin.Name = "DateTimePickerFin"
        Me.DateTimePickerFin.Size = New System.Drawing.Size(146, 20)
        Me.DateTimePickerFin.TabIndex = 56
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Quicksand", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(591, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 19)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Vigencia vacuna"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Quicksand", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(591, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 19)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Ultima Vacuna"
        '
        'DateTimePickerInicio
        '
        Me.DateTimePickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerInicio.Location = New System.Drawing.Point(595, 100)
        Me.DateTimePickerInicio.Name = "DateTimePickerInicio"
        Me.DateTimePickerInicio.Size = New System.Drawing.Size(146, 20)
        Me.DateTimePickerInicio.TabIndex = 53
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Quicksand", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(430, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 19)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Vacunado"
        '
        'MaterialTextBoxColor
        '
        Me.MaterialTextBoxColor.AnimateReadOnly = False
        Me.MaterialTextBoxColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MaterialTextBoxColor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.MaterialTextBoxColor.Depth = 0
        Me.MaterialTextBoxColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBoxColor.HideSelection = True
        Me.MaterialTextBoxColor.Hint = "Color"
        Me.MaterialTextBoxColor.LeadingIcon = Nothing
        Me.MaterialTextBoxColor.Location = New System.Drawing.Point(372, 128)
        Me.MaterialTextBoxColor.MaxLength = 32767
        Me.MaterialTextBoxColor.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextBoxColor.Name = "MaterialTextBoxColor"
        Me.MaterialTextBoxColor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialTextBoxColor.PrefixSuffixText = Nothing
        Me.MaterialTextBoxColor.ReadOnly = False
        Me.MaterialTextBoxColor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MaterialTextBoxColor.SelectedText = ""
        Me.MaterialTextBoxColor.SelectionLength = 0
        Me.MaterialTextBoxColor.SelectionStart = 0
        Me.MaterialTextBoxColor.ShortcutsEnabled = True
        Me.MaterialTextBoxColor.Size = New System.Drawing.Size(188, 48)
        Me.MaterialTextBoxColor.TabIndex = 51
        Me.MaterialTextBoxColor.TabStop = False
        Me.MaterialTextBoxColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.MaterialTextBoxColor.TrailingIcon = Nothing
        Me.MaterialTextBoxColor.UseSystemPasswordChar = False
        '
        'MaterialComboBoxPesos
        '
        Me.MaterialComboBoxPesos.AutoResize = False
        Me.MaterialComboBoxPesos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialComboBoxPesos.Depth = 0
        Me.MaterialComboBoxPesos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.MaterialComboBoxPesos.DropDownHeight = 174
        Me.MaterialComboBoxPesos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MaterialComboBoxPesos.DropDownWidth = 121
        Me.MaterialComboBoxPesos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialComboBoxPesos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialComboBoxPesos.FormattingEnabled = True
        Me.MaterialComboBoxPesos.Hint = "Peso"
        Me.MaterialComboBoxPesos.IntegralHeight = False
        Me.MaterialComboBoxPesos.ItemHeight = 43
        Me.MaterialComboBoxPesos.Location = New System.Drawing.Point(372, 71)
        Me.MaterialComboBoxPesos.MaxDropDownItems = 4
        Me.MaterialComboBoxPesos.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialComboBoxPesos.Name = "MaterialComboBoxPesos"
        Me.MaterialComboBoxPesos.Size = New System.Drawing.Size(188, 49)
        Me.MaterialComboBoxPesos.StartIndex = 0
        Me.MaterialComboBoxPesos.TabIndex = 50
        '
        'MaterialTextBoxNombreMascota
        '
        Me.MaterialTextBoxNombreMascota.AnimateReadOnly = False
        Me.MaterialTextBoxNombreMascota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MaterialTextBoxNombreMascota.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.MaterialTextBoxNombreMascota.Depth = 0
        Me.MaterialTextBoxNombreMascota.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBoxNombreMascota.HideSelection = True
        Me.MaterialTextBoxNombreMascota.Hint = "Nombre de la mascota"
        Me.MaterialTextBoxNombreMascota.LeadingIcon = Nothing
        Me.MaterialTextBoxNombreMascota.Location = New System.Drawing.Point(169, 72)
        Me.MaterialTextBoxNombreMascota.MaxLength = 32767
        Me.MaterialTextBoxNombreMascota.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextBoxNombreMascota.Name = "MaterialTextBoxNombreMascota"
        Me.MaterialTextBoxNombreMascota.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialTextBoxNombreMascota.PrefixSuffixText = Nothing
        Me.MaterialTextBoxNombreMascota.ReadOnly = False
        Me.MaterialTextBoxNombreMascota.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MaterialTextBoxNombreMascota.SelectedText = ""
        Me.MaterialTextBoxNombreMascota.SelectionLength = 0
        Me.MaterialTextBoxNombreMascota.SelectionStart = 0
        Me.MaterialTextBoxNombreMascota.ShortcutsEnabled = True
        Me.MaterialTextBoxNombreMascota.Size = New System.Drawing.Size(188, 48)
        Me.MaterialTextBoxNombreMascota.TabIndex = 49
        Me.MaterialTextBoxNombreMascota.TabStop = False
        Me.MaterialTextBoxNombreMascota.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.MaterialTextBoxNombreMascota.TrailingIcon = Nothing
        Me.MaterialTextBoxNombreMascota.UseSystemPasswordChar = False
        '
        'MaterialComboboxTipo
        '
        Me.MaterialComboboxTipo.AutoResize = False
        Me.MaterialComboboxTipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialComboboxTipo.Depth = 0
        Me.MaterialComboboxTipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.MaterialComboboxTipo.DropDownHeight = 174
        Me.MaterialComboboxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MaterialComboboxTipo.DropDownWidth = 121
        Me.MaterialComboboxTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialComboboxTipo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialComboboxTipo.FormattingEnabled = True
        Me.MaterialComboboxTipo.Hint = "TipoMascota"
        Me.MaterialComboboxTipo.IntegralHeight = False
        Me.MaterialComboboxTipo.ItemHeight = 43
        Me.MaterialComboboxTipo.Location = New System.Drawing.Point(169, 128)
        Me.MaterialComboboxTipo.MaxDropDownItems = 4
        Me.MaterialComboboxTipo.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialComboboxTipo.Name = "MaterialComboboxTipo"
        Me.MaterialComboboxTipo.Size = New System.Drawing.Size(188, 49)
        Me.MaterialComboboxTipo.StartIndex = 0
        Me.MaterialComboboxTipo.TabIndex = 48
        '
        'MaterialComboBoxRAZA
        '
        Me.MaterialComboBoxRAZA.AutoResize = False
        Me.MaterialComboBoxRAZA.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialComboBoxRAZA.Depth = 0
        Me.MaterialComboBoxRAZA.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.MaterialComboBoxRAZA.DropDownHeight = 174
        Me.MaterialComboBoxRAZA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MaterialComboBoxRAZA.DropDownWidth = 121
        Me.MaterialComboBoxRAZA.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialComboBoxRAZA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialComboBoxRAZA.FormattingEnabled = True
        Me.MaterialComboBoxRAZA.Hint = "Raza"
        Me.MaterialComboBoxRAZA.IntegralHeight = False
        Me.MaterialComboBoxRAZA.ItemHeight = 43
        Me.MaterialComboBoxRAZA.Location = New System.Drawing.Point(169, 192)
        Me.MaterialComboBoxRAZA.MaxDropDownItems = 4
        Me.MaterialComboBoxRAZA.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialComboBoxRAZA.Name = "MaterialComboBoxRAZA"
        Me.MaterialComboBoxRAZA.Size = New System.Drawing.Size(188, 49)
        Me.MaterialComboBoxRAZA.StartIndex = 0
        Me.MaterialComboBoxRAZA.TabIndex = 47
        '
        'MaterialComboBoxSexo
        '
        Me.MaterialComboBoxSexo.AutoResize = False
        Me.MaterialComboBoxSexo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialComboBoxSexo.Depth = 0
        Me.MaterialComboBoxSexo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.MaterialComboBoxSexo.DropDownHeight = 174
        Me.MaterialComboBoxSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MaterialComboBoxSexo.DropDownWidth = 121
        Me.MaterialComboBoxSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialComboBoxSexo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialComboBoxSexo.FormattingEnabled = True
        Me.MaterialComboBoxSexo.Hint = "Sexo"
        Me.MaterialComboBoxSexo.IntegralHeight = False
        Me.MaterialComboBoxSexo.ItemHeight = 43
        Me.MaterialComboBoxSexo.Location = New System.Drawing.Point(169, 258)
        Me.MaterialComboBoxSexo.MaxDropDownItems = 4
        Me.MaterialComboBoxSexo.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialComboBoxSexo.Name = "MaterialComboBoxSexo"
        Me.MaterialComboBoxSexo.Size = New System.Drawing.Size(188, 49)
        Me.MaterialComboBoxSexo.StartIndex = 0
        Me.MaterialComboBoxSexo.TabIndex = 46
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(13, 64)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(150, 150)
        Me.Panel2.TabIndex = 44
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Panel1.Controls.Add(Me.LabelVerInformacionMacot)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 52)
        Me.Panel1.TabIndex = 65
        '
        'LabelVerInformacionMacot
        '
        Me.LabelVerInformacionMacot.AutoSize = True
        Me.LabelVerInformacionMacot.Font = New System.Drawing.Font("Quicksand", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVerInformacionMacot.ForeColor = System.Drawing.Color.White
        Me.LabelVerInformacionMacot.Location = New System.Drawing.Point(12, 18)
        Me.LabelVerInformacionMacot.Name = "LabelVerInformacionMacot"
        Me.LabelVerInformacionMacot.Size = New System.Drawing.Size(165, 24)
        Me.LabelVerInformacionMacot.TabIndex = 0
        Me.LabelVerInformacionMacot.Text = "Editar Mascota"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Crimson
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Crimson
        Me.Button2.FlatAppearance.BorderSize = 2
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(584, 396)
        Me.Button2.Margin = New System.Windows.Forms.Padding(50, 3, 50, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 42)
        Me.Button2.TabIndex = 66
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FrmEditarMascotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Fallecido)
        Me.Controls.Add(Me.MaterialCheckboxVACUNADONO)
        Me.Controls.Add(Me.MaterialCheckboxFALLECIDONO)
        Me.Controls.Add(Me.MaterialCheckboxVACUNADOSI)
        Me.Controls.Add(Me.MaterialCheckboxFALLECIDOSI)
        Me.Controls.Add(Me.ButtonAceptar)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.ButtonCambiar)
        Me.Controls.Add(Me.DateTimePickerFin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePickerInicio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MaterialTextBoxColor)
        Me.Controls.Add(Me.MaterialComboBoxPesos)
        Me.Controls.Add(Me.MaterialTextBoxNombreMascota)
        Me.Controls.Add(Me.MaterialComboboxTipo)
        Me.Controls.Add(Me.MaterialComboBoxRAZA)
        Me.Controls.Add(Me.MaterialComboBoxSexo)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmEditarMascotas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmEditarMascotas"
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Fallecido As Label
    Friend WithEvents MaterialCheckboxVACUNADONO As MaterialSkin.Controls.MaterialCheckbox
    Friend WithEvents MaterialCheckboxFALLECIDONO As MaterialSkin.Controls.MaterialCheckbox
    Friend WithEvents MaterialCheckboxVACUNADOSI As MaterialSkin.Controls.MaterialCheckbox
    Friend WithEvents MaterialCheckboxFALLECIDOSI As MaterialSkin.Controls.MaterialCheckbox
    Friend WithEvents ButtonAceptar As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ButtonCambiar As Button
    Friend WithEvents DateTimePickerFin As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePickerInicio As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents MaterialTextBoxColor As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialComboBoxPesos As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents MaterialTextBoxNombreMascota As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialComboboxTipo As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents MaterialComboBoxRAZA As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents MaterialComboBoxSexo As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelVerInformacionMacot As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
