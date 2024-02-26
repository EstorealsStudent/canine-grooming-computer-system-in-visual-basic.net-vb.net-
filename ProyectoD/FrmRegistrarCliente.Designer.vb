<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistrarCliente
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.MaterialTextBoxCasa = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialMultiLineTextBoxDescripcion = New MaterialSkin.Controls.MaterialMultiLineTextBox2()
        Me.MaterialTextBoxEmail = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialTextBoxExterno = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialTextBoxTrabajo = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialTextBoxCelular = New MaterialSkin.Controls.MaterialTextBox2()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.MaterialTextBoxCURP = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialTextBoxRFC = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialTextBoxEstado = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialTextBoxCodigoPostal = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialTextBoxColonia = New MaterialSkin.Controls.MaterialTextBox2()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MaterialTextBoxMunicipio = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialTextBoxCalle = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialTextBoxNumero = New MaterialSkin.Controls.MaterialTextBox2()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MaterialComboBox1 = New MaterialSkin.Controls.MaterialComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MaterialTextBoxApellidoPaterno = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialTextBoxApellidoMaterno = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialTextBoxSegundoNombre = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialTextBoxPrimerNombre = New MaterialSkin.Controls.MaterialTextBox2()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ButtonAceptar = New System.Windows.Forms.Button()
        Me.ButtonCancelar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1064, 56)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registar al cliente"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.MaterialTextBoxCasa)
        Me.Panel4.Controls.Add(Me.MaterialMultiLineTextBoxDescripcion)
        Me.Panel4.Controls.Add(Me.MaterialTextBoxEmail)
        Me.Panel4.Controls.Add(Me.MaterialTextBoxExterno)
        Me.Panel4.Controls.Add(Me.MaterialTextBoxTrabajo)
        Me.Panel4.Controls.Add(Me.MaterialTextBoxCelular)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Location = New System.Drawing.Point(712, 62)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(340, 479)
        Me.Panel4.TabIndex = 20
        '
        'MaterialTextBoxCasa
        '
        Me.MaterialTextBoxCasa.AnimateReadOnly = True
        Me.MaterialTextBoxCasa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MaterialTextBoxCasa.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.MaterialTextBoxCasa.Depth = 0
        Me.MaterialTextBoxCasa.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBoxCasa.HideSelection = True
        Me.MaterialTextBoxCasa.Hint = "casa"
        Me.MaterialTextBoxCasa.LeadingIcon = Nothing
        Me.MaterialTextBoxCasa.LeaveOnEnterKey = True
        Me.MaterialTextBoxCasa.Location = New System.Drawing.Point(17, 54)
        Me.MaterialTextBoxCasa.MaxLength = 32767
        Me.MaterialTextBoxCasa.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextBoxCasa.Name = "MaterialTextBoxCasa"
        Me.MaterialTextBoxCasa.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialTextBoxCasa.PrefixSuffixText = Nothing
        Me.MaterialTextBoxCasa.ReadOnly = False
        Me.MaterialTextBoxCasa.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MaterialTextBoxCasa.SelectedText = ""
        Me.MaterialTextBoxCasa.SelectionLength = 0
        Me.MaterialTextBoxCasa.SelectionStart = 0
        Me.MaterialTextBoxCasa.ShortcutsEnabled = True
        Me.MaterialTextBoxCasa.Size = New System.Drawing.Size(308, 48)
        Me.MaterialTextBoxCasa.TabIndex = 39
        Me.MaterialTextBoxCasa.TabStop = False
        Me.MaterialTextBoxCasa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.MaterialTextBoxCasa.TrailingIcon = Nothing
        Me.MaterialTextBoxCasa.UseSystemPasswordChar = False
        '
        'MaterialMultiLineTextBoxDescripcion
        '
        Me.MaterialMultiLineTextBoxDescripcion.AnimateReadOnly = True
        Me.MaterialMultiLineTextBoxDescripcion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MaterialMultiLineTextBoxDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.MaterialMultiLineTextBoxDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.MaterialMultiLineTextBoxDescripcion.Depth = 0
        Me.MaterialMultiLineTextBoxDescripcion.HideSelection = True
        Me.MaterialMultiLineTextBoxDescripcion.Hint = "Opciones especiales del cliente"
        Me.MaterialMultiLineTextBoxDescripcion.Location = New System.Drawing.Point(17, 319)
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
        Me.MaterialMultiLineTextBoxDescripcion.Size = New System.Drawing.Size(308, 143)
        Me.MaterialMultiLineTextBoxDescripcion.TabIndex = 38
        Me.MaterialMultiLineTextBoxDescripcion.TabStop = False
        Me.MaterialMultiLineTextBoxDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.MaterialMultiLineTextBoxDescripcion.UseSystemPasswordChar = False
        '
        'MaterialTextBoxEmail
        '
        Me.MaterialTextBoxEmail.AnimateReadOnly = True
        Me.MaterialTextBoxEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MaterialTextBoxEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.MaterialTextBoxEmail.Depth = 0
        Me.MaterialTextBoxEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBoxEmail.HideSelection = True
        Me.MaterialTextBoxEmail.Hint = "Email"
        Me.MaterialTextBoxEmail.LeadingIcon = Nothing
        Me.MaterialTextBoxEmail.LeaveOnEnterKey = True
        Me.MaterialTextBoxEmail.Location = New System.Drawing.Point(17, 266)
        Me.MaterialTextBoxEmail.MaxLength = 32767
        Me.MaterialTextBoxEmail.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextBoxEmail.Name = "MaterialTextBoxEmail"
        Me.MaterialTextBoxEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialTextBoxEmail.PrefixSuffixText = Nothing
        Me.MaterialTextBoxEmail.ReadOnly = False
        Me.MaterialTextBoxEmail.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MaterialTextBoxEmail.SelectedText = ""
        Me.MaterialTextBoxEmail.SelectionLength = 0
        Me.MaterialTextBoxEmail.SelectionStart = 0
        Me.MaterialTextBoxEmail.ShortcutsEnabled = True
        Me.MaterialTextBoxEmail.Size = New System.Drawing.Size(308, 48)
        Me.MaterialTextBoxEmail.TabIndex = 37
        Me.MaterialTextBoxEmail.TabStop = False
        Me.MaterialTextBoxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.MaterialTextBoxEmail.TrailingIcon = Nothing
        Me.MaterialTextBoxEmail.UseSystemPasswordChar = False
        '
        'MaterialTextBoxExterno
        '
        Me.MaterialTextBoxExterno.AnimateReadOnly = True
        Me.MaterialTextBoxExterno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MaterialTextBoxExterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.MaterialTextBoxExterno.Depth = 0
        Me.MaterialTextBoxExterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBoxExterno.HideSelection = True
        Me.MaterialTextBoxExterno.Hint = "Externo"
        Me.MaterialTextBoxExterno.LeadingIcon = Nothing
        Me.MaterialTextBoxExterno.LeaveOnEnterKey = True
        Me.MaterialTextBoxExterno.Location = New System.Drawing.Point(17, 213)
        Me.MaterialTextBoxExterno.MaxLength = 32767
        Me.MaterialTextBoxExterno.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextBoxExterno.Name = "MaterialTextBoxExterno"
        Me.MaterialTextBoxExterno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialTextBoxExterno.PrefixSuffixText = Nothing
        Me.MaterialTextBoxExterno.ReadOnly = False
        Me.MaterialTextBoxExterno.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MaterialTextBoxExterno.SelectedText = ""
        Me.MaterialTextBoxExterno.SelectionLength = 0
        Me.MaterialTextBoxExterno.SelectionStart = 0
        Me.MaterialTextBoxExterno.ShortcutsEnabled = True
        Me.MaterialTextBoxExterno.Size = New System.Drawing.Size(308, 48)
        Me.MaterialTextBoxExterno.TabIndex = 36
        Me.MaterialTextBoxExterno.TabStop = False
        Me.MaterialTextBoxExterno.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.MaterialTextBoxExterno.TrailingIcon = Nothing
        Me.MaterialTextBoxExterno.UseSystemPasswordChar = False
        '
        'MaterialTextBoxTrabajo
        '
        Me.MaterialTextBoxTrabajo.AnimateReadOnly = True
        Me.MaterialTextBoxTrabajo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MaterialTextBoxTrabajo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.MaterialTextBoxTrabajo.Depth = 0
        Me.MaterialTextBoxTrabajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBoxTrabajo.HideSelection = True
        Me.MaterialTextBoxTrabajo.Hint = "Trabajo"
        Me.MaterialTextBoxTrabajo.LeadingIcon = Nothing
        Me.MaterialTextBoxTrabajo.LeaveOnEnterKey = True
        Me.MaterialTextBoxTrabajo.Location = New System.Drawing.Point(17, 160)
        Me.MaterialTextBoxTrabajo.MaxLength = 32767
        Me.MaterialTextBoxTrabajo.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextBoxTrabajo.Name = "MaterialTextBoxTrabajo"
        Me.MaterialTextBoxTrabajo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialTextBoxTrabajo.PrefixSuffixText = Nothing
        Me.MaterialTextBoxTrabajo.ReadOnly = False
        Me.MaterialTextBoxTrabajo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MaterialTextBoxTrabajo.SelectedText = ""
        Me.MaterialTextBoxTrabajo.SelectionLength = 0
        Me.MaterialTextBoxTrabajo.SelectionStart = 0
        Me.MaterialTextBoxTrabajo.ShortcutsEnabled = True
        Me.MaterialTextBoxTrabajo.Size = New System.Drawing.Size(308, 48)
        Me.MaterialTextBoxTrabajo.TabIndex = 35
        Me.MaterialTextBoxTrabajo.TabStop = False
        Me.MaterialTextBoxTrabajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.MaterialTextBoxTrabajo.TrailingIcon = Nothing
        Me.MaterialTextBoxTrabajo.UseSystemPasswordChar = False
        '
        'MaterialTextBoxCelular
        '
        Me.MaterialTextBoxCelular.AnimateReadOnly = True
        Me.MaterialTextBoxCelular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MaterialTextBoxCelular.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.MaterialTextBoxCelular.Depth = 0
        Me.MaterialTextBoxCelular.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBoxCelular.HideSelection = True
        Me.MaterialTextBoxCelular.Hint = "Celular"
        Me.MaterialTextBoxCelular.LeadingIcon = Nothing
        Me.MaterialTextBoxCelular.LeaveOnEnterKey = True
        Me.MaterialTextBoxCelular.Location = New System.Drawing.Point(17, 107)
        Me.MaterialTextBoxCelular.MaxLength = 32767
        Me.MaterialTextBoxCelular.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextBoxCelular.Name = "MaterialTextBoxCelular"
        Me.MaterialTextBoxCelular.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialTextBoxCelular.PrefixSuffixText = Nothing
        Me.MaterialTextBoxCelular.ReadOnly = False
        Me.MaterialTextBoxCelular.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MaterialTextBoxCelular.SelectedText = ""
        Me.MaterialTextBoxCelular.SelectionLength = 0
        Me.MaterialTextBoxCelular.SelectionStart = 0
        Me.MaterialTextBoxCelular.ShortcutsEnabled = True
        Me.MaterialTextBoxCelular.Size = New System.Drawing.Size(308, 48)
        Me.MaterialTextBoxCelular.TabIndex = 34
        Me.MaterialTextBoxCelular.TabStop = False
        Me.MaterialTextBoxCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.MaterialTextBoxCelular.TrailingIcon = Nothing
        Me.MaterialTextBoxCelular.UseSystemPasswordChar = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Quicksand", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 19)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Telefonos"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Quicksand", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 1)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 22)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Datos:"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.MaterialTextBoxCURP)
        Me.Panel3.Controls.Add(Me.MaterialTextBoxRFC)
        Me.Panel3.Controls.Add(Me.MaterialTextBoxEstado)
        Me.Panel3.Controls.Add(Me.MaterialTextBoxCodigoPostal)
        Me.Panel3.Controls.Add(Me.MaterialTextBoxColonia)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.MaterialTextBoxMunicipio)
        Me.Panel3.Controls.Add(Me.MaterialTextBoxCalle)
        Me.Panel3.Controls.Add(Me.MaterialTextBoxNumero)
        Me.Panel3.Location = New System.Drawing.Point(366, 62)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(340, 479)
        Me.Panel3.TabIndex = 21
        '
        'MaterialTextBoxCURP
        '
        Me.MaterialTextBoxCURP.AnimateReadOnly = False
        Me.MaterialTextBoxCURP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MaterialTextBoxCURP.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.MaterialTextBoxCURP.Depth = 0
        Me.MaterialTextBoxCURP.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBoxCURP.HideSelection = True
        Me.MaterialTextBoxCURP.Hint = "CURP"
        Me.MaterialTextBoxCURP.LeadingIcon = Nothing
        Me.MaterialTextBoxCURP.Location = New System.Drawing.Point(16, 404)
        Me.MaterialTextBoxCURP.MaxLength = 32767
        Me.MaterialTextBoxCURP.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextBoxCURP.Name = "MaterialTextBoxCURP"
        Me.MaterialTextBoxCURP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialTextBoxCURP.PrefixSuffixText = Nothing
        Me.MaterialTextBoxCURP.ReadOnly = False
        Me.MaterialTextBoxCURP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MaterialTextBoxCURP.SelectedText = ""
        Me.MaterialTextBoxCURP.SelectionLength = 0
        Me.MaterialTextBoxCURP.SelectionStart = 0
        Me.MaterialTextBoxCURP.ShortcutsEnabled = True
        Me.MaterialTextBoxCURP.Size = New System.Drawing.Size(308, 48)
        Me.MaterialTextBoxCURP.TabIndex = 24
        Me.MaterialTextBoxCURP.TabStop = False
        Me.MaterialTextBoxCURP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.MaterialTextBoxCURP.TrailingIcon = Nothing
        Me.MaterialTextBoxCURP.UseSystemPasswordChar = False
        '
        'MaterialTextBoxRFC
        '
        Me.MaterialTextBoxRFC.AnimateReadOnly = False
        Me.MaterialTextBoxRFC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MaterialTextBoxRFC.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.MaterialTextBoxRFC.Depth = 0
        Me.MaterialTextBoxRFC.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBoxRFC.HideSelection = True
        Me.MaterialTextBoxRFC.Hint = "RFC"
        Me.MaterialTextBoxRFC.LeadingIcon = Nothing
        Me.MaterialTextBoxRFC.Location = New System.Drawing.Point(16, 350)
        Me.MaterialTextBoxRFC.MaxLength = 32767
        Me.MaterialTextBoxRFC.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextBoxRFC.Name = "MaterialTextBoxRFC"
        Me.MaterialTextBoxRFC.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialTextBoxRFC.PrefixSuffixText = Nothing
        Me.MaterialTextBoxRFC.ReadOnly = False
        Me.MaterialTextBoxRFC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MaterialTextBoxRFC.SelectedText = ""
        Me.MaterialTextBoxRFC.SelectionLength = 0
        Me.MaterialTextBoxRFC.SelectionStart = 0
        Me.MaterialTextBoxRFC.ShortcutsEnabled = True
        Me.MaterialTextBoxRFC.Size = New System.Drawing.Size(308, 48)
        Me.MaterialTextBoxRFC.TabIndex = 23
        Me.MaterialTextBoxRFC.TabStop = False
        Me.MaterialTextBoxRFC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.MaterialTextBoxRFC.TrailingIcon = Nothing
        Me.MaterialTextBoxRFC.UseSystemPasswordChar = False
        '
        'MaterialTextBoxEstado
        '
        Me.MaterialTextBoxEstado.AnimateReadOnly = False
        Me.MaterialTextBoxEstado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MaterialTextBoxEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.MaterialTextBoxEstado.Depth = 0
        Me.MaterialTextBoxEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBoxEstado.HideSelection = True
        Me.MaterialTextBoxEstado.Hint = "Estado"
        Me.MaterialTextBoxEstado.LeadingIcon = Nothing
        Me.MaterialTextBoxEstado.Location = New System.Drawing.Point(16, 296)
        Me.MaterialTextBoxEstado.MaxLength = 32767
        Me.MaterialTextBoxEstado.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextBoxEstado.Name = "MaterialTextBoxEstado"
        Me.MaterialTextBoxEstado.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialTextBoxEstado.PrefixSuffixText = Nothing
        Me.MaterialTextBoxEstado.ReadOnly = False
        Me.MaterialTextBoxEstado.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MaterialTextBoxEstado.SelectedText = ""
        Me.MaterialTextBoxEstado.SelectionLength = 0
        Me.MaterialTextBoxEstado.SelectionStart = 0
        Me.MaterialTextBoxEstado.ShortcutsEnabled = True
        Me.MaterialTextBoxEstado.Size = New System.Drawing.Size(308, 48)
        Me.MaterialTextBoxEstado.TabIndex = 22
        Me.MaterialTextBoxEstado.TabStop = False
        Me.MaterialTextBoxEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.MaterialTextBoxEstado.TrailingIcon = Nothing
        Me.MaterialTextBoxEstado.UseSystemPasswordChar = False
        '
        'MaterialTextBoxCodigoPostal
        '
        Me.MaterialTextBoxCodigoPostal.AnimateReadOnly = False
        Me.MaterialTextBoxCodigoPostal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MaterialTextBoxCodigoPostal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.MaterialTextBoxCodigoPostal.Depth = 0
        Me.MaterialTextBoxCodigoPostal.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBoxCodigoPostal.HideSelection = True
        Me.MaterialTextBoxCodigoPostal.Hint = "Codigo Postal"
        Me.MaterialTextBoxCodigoPostal.LeadingIcon = Nothing
        Me.MaterialTextBoxCodigoPostal.Location = New System.Drawing.Point(16, 242)
        Me.MaterialTextBoxCodigoPostal.MaxLength = 32767
        Me.MaterialTextBoxCodigoPostal.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextBoxCodigoPostal.Name = "MaterialTextBoxCodigoPostal"
        Me.MaterialTextBoxCodigoPostal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialTextBoxCodigoPostal.PrefixSuffixText = Nothing
        Me.MaterialTextBoxCodigoPostal.ReadOnly = False
        Me.MaterialTextBoxCodigoPostal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MaterialTextBoxCodigoPostal.SelectedText = ""
        Me.MaterialTextBoxCodigoPostal.SelectionLength = 0
        Me.MaterialTextBoxCodigoPostal.SelectionStart = 0
        Me.MaterialTextBoxCodigoPostal.ShortcutsEnabled = True
        Me.MaterialTextBoxCodigoPostal.Size = New System.Drawing.Size(308, 48)
        Me.MaterialTextBoxCodigoPostal.TabIndex = 21
        Me.MaterialTextBoxCodigoPostal.TabStop = False
        Me.MaterialTextBoxCodigoPostal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.MaterialTextBoxCodigoPostal.TrailingIcon = Nothing
        Me.MaterialTextBoxCodigoPostal.UseSystemPasswordChar = False
        '
        'MaterialTextBoxColonia
        '
        Me.MaterialTextBoxColonia.AnimateReadOnly = False
        Me.MaterialTextBoxColonia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MaterialTextBoxColonia.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.MaterialTextBoxColonia.Depth = 0
        Me.MaterialTextBoxColonia.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBoxColonia.HideSelection = True
        Me.MaterialTextBoxColonia.Hint = "Colonia"
        Me.MaterialTextBoxColonia.LeadingIcon = Nothing
        Me.MaterialTextBoxColonia.Location = New System.Drawing.Point(16, 134)
        Me.MaterialTextBoxColonia.MaxLength = 32767
        Me.MaterialTextBoxColonia.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextBoxColonia.Name = "MaterialTextBoxColonia"
        Me.MaterialTextBoxColonia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialTextBoxColonia.PrefixSuffixText = Nothing
        Me.MaterialTextBoxColonia.ReadOnly = False
        Me.MaterialTextBoxColonia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MaterialTextBoxColonia.SelectedText = ""
        Me.MaterialTextBoxColonia.SelectionLength = 0
        Me.MaterialTextBoxColonia.SelectionStart = 0
        Me.MaterialTextBoxColonia.ShortcutsEnabled = True
        Me.MaterialTextBoxColonia.Size = New System.Drawing.Size(308, 48)
        Me.MaterialTextBoxColonia.TabIndex = 18
        Me.MaterialTextBoxColonia.TabStop = False
        Me.MaterialTextBoxColonia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.MaterialTextBoxColonia.TrailingIcon = Nothing
        Me.MaterialTextBoxColonia.UseSystemPasswordChar = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Quicksand", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 1)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 22)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Dirección:"
        '
        'MaterialTextBoxMunicipio
        '
        Me.MaterialTextBoxMunicipio.AnimateReadOnly = False
        Me.MaterialTextBoxMunicipio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MaterialTextBoxMunicipio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.MaterialTextBoxMunicipio.Depth = 0
        Me.MaterialTextBoxMunicipio.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBoxMunicipio.HideSelection = True
        Me.MaterialTextBoxMunicipio.Hint = "Municipio"
        Me.MaterialTextBoxMunicipio.LeadingIcon = Nothing
        Me.MaterialTextBoxMunicipio.Location = New System.Drawing.Point(16, 188)
        Me.MaterialTextBoxMunicipio.MaxLength = 32767
        Me.MaterialTextBoxMunicipio.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextBoxMunicipio.Name = "MaterialTextBoxMunicipio"
        Me.MaterialTextBoxMunicipio.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialTextBoxMunicipio.PrefixSuffixText = Nothing
        Me.MaterialTextBoxMunicipio.ReadOnly = False
        Me.MaterialTextBoxMunicipio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MaterialTextBoxMunicipio.SelectedText = ""
        Me.MaterialTextBoxMunicipio.SelectionLength = 0
        Me.MaterialTextBoxMunicipio.SelectionStart = 0
        Me.MaterialTextBoxMunicipio.ShortcutsEnabled = True
        Me.MaterialTextBoxMunicipio.Size = New System.Drawing.Size(308, 48)
        Me.MaterialTextBoxMunicipio.TabIndex = 20
        Me.MaterialTextBoxMunicipio.TabStop = False
        Me.MaterialTextBoxMunicipio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.MaterialTextBoxMunicipio.TrailingIcon = Nothing
        Me.MaterialTextBoxMunicipio.UseSystemPasswordChar = False
        '
        'MaterialTextBoxCalle
        '
        Me.MaterialTextBoxCalle.AnimateReadOnly = True
        Me.MaterialTextBoxCalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MaterialTextBoxCalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.MaterialTextBoxCalle.Depth = 0
        Me.MaterialTextBoxCalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBoxCalle.HideSelection = True
        Me.MaterialTextBoxCalle.Hint = "Calle"
        Me.MaterialTextBoxCalle.LeadingIcon = Nothing
        Me.MaterialTextBoxCalle.LeaveOnEnterKey = True
        Me.MaterialTextBoxCalle.Location = New System.Drawing.Point(16, 26)
        Me.MaterialTextBoxCalle.MaxLength = 32767
        Me.MaterialTextBoxCalle.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextBoxCalle.Name = "MaterialTextBoxCalle"
        Me.MaterialTextBoxCalle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialTextBoxCalle.PrefixSuffixText = Nothing
        Me.MaterialTextBoxCalle.ReadOnly = False
        Me.MaterialTextBoxCalle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MaterialTextBoxCalle.SelectedText = ""
        Me.MaterialTextBoxCalle.SelectionLength = 0
        Me.MaterialTextBoxCalle.SelectionStart = 0
        Me.MaterialTextBoxCalle.ShortcutsEnabled = True
        Me.MaterialTextBoxCalle.Size = New System.Drawing.Size(308, 48)
        Me.MaterialTextBoxCalle.TabIndex = 17
        Me.MaterialTextBoxCalle.TabStop = False
        Me.MaterialTextBoxCalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.MaterialTextBoxCalle.TrailingIcon = Nothing
        Me.MaterialTextBoxCalle.UseSystemPasswordChar = False
        '
        'MaterialTextBoxNumero
        '
        Me.MaterialTextBoxNumero.AnimateReadOnly = False
        Me.MaterialTextBoxNumero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MaterialTextBoxNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.MaterialTextBoxNumero.Depth = 0
        Me.MaterialTextBoxNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBoxNumero.HideSelection = True
        Me.MaterialTextBoxNumero.Hint = "Número"
        Me.MaterialTextBoxNumero.LeadingIcon = Nothing
        Me.MaterialTextBoxNumero.Location = New System.Drawing.Point(16, 80)
        Me.MaterialTextBoxNumero.MaxLength = 32767
        Me.MaterialTextBoxNumero.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextBoxNumero.Name = "MaterialTextBoxNumero"
        Me.MaterialTextBoxNumero.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialTextBoxNumero.PrefixSuffixText = Nothing
        Me.MaterialTextBoxNumero.ReadOnly = False
        Me.MaterialTextBoxNumero.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MaterialTextBoxNumero.SelectedText = ""
        Me.MaterialTextBoxNumero.SelectionLength = 0
        Me.MaterialTextBoxNumero.SelectionStart = 0
        Me.MaterialTextBoxNumero.ShortcutsEnabled = True
        Me.MaterialTextBoxNumero.Size = New System.Drawing.Size(308, 48)
        Me.MaterialTextBoxNumero.TabIndex = 19
        Me.MaterialTextBoxNumero.TabStop = False
        Me.MaterialTextBoxNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.MaterialTextBoxNumero.TrailingIcon = Nothing
        Me.MaterialTextBoxNumero.UseSystemPasswordChar = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.MaterialComboBox1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.MaterialTextBoxApellidoPaterno)
        Me.Panel2.Controls.Add(Me.MaterialTextBoxApellidoMaterno)
        Me.Panel2.Controls.Add(Me.MaterialTextBoxSegundoNombre)
        Me.Panel2.Controls.Add(Me.MaterialTextBoxPrimerNombre)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(20, 62)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(340, 479)
        Me.Panel2.TabIndex = 19
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
        Me.MaterialComboBox1.Hint = "Genero*"
        Me.MaterialComboBox1.IntegralHeight = False
        Me.MaterialComboBox1.ItemHeight = 43
        Me.MaterialComboBox1.Location = New System.Drawing.Point(16, 295)
        Me.MaterialComboBox1.MaxDropDownItems = 4
        Me.MaterialComboBox1.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialComboBox1.Name = "MaterialComboBox1"
        Me.MaterialComboBox1.Size = New System.Drawing.Size(308, 49)
        Me.MaterialComboBox1.StartIndex = 0
        Me.MaterialComboBox1.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Quicksand", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 22)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Datos generales:"
        '
        'MaterialTextBoxApellidoPaterno
        '
        Me.MaterialTextBoxApellidoPaterno.AnimateReadOnly = False
        Me.MaterialTextBoxApellidoPaterno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MaterialTextBoxApellidoPaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.MaterialTextBoxApellidoPaterno.Depth = 0
        Me.MaterialTextBoxApellidoPaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBoxApellidoPaterno.HideSelection = True
        Me.MaterialTextBoxApellidoPaterno.Hint = "Apellido paterno*"
        Me.MaterialTextBoxApellidoPaterno.LeadingIcon = Nothing
        Me.MaterialTextBoxApellidoPaterno.Location = New System.Drawing.Point(16, 166)
        Me.MaterialTextBoxApellidoPaterno.MaxLength = 32767
        Me.MaterialTextBoxApellidoPaterno.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextBoxApellidoPaterno.Name = "MaterialTextBoxApellidoPaterno"
        Me.MaterialTextBoxApellidoPaterno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialTextBoxApellidoPaterno.PrefixSuffixText = Nothing
        Me.MaterialTextBoxApellidoPaterno.ReadOnly = False
        Me.MaterialTextBoxApellidoPaterno.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MaterialTextBoxApellidoPaterno.SelectedText = ""
        Me.MaterialTextBoxApellidoPaterno.SelectionLength = 0
        Me.MaterialTextBoxApellidoPaterno.SelectionStart = 0
        Me.MaterialTextBoxApellidoPaterno.ShortcutsEnabled = True
        Me.MaterialTextBoxApellidoPaterno.Size = New System.Drawing.Size(308, 48)
        Me.MaterialTextBoxApellidoPaterno.TabIndex = 9
        Me.MaterialTextBoxApellidoPaterno.TabStop = False
        Me.MaterialTextBoxApellidoPaterno.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.MaterialTextBoxApellidoPaterno.TrailingIcon = Nothing
        Me.MaterialTextBoxApellidoPaterno.UseSystemPasswordChar = False
        '
        'MaterialTextBoxApellidoMaterno
        '
        Me.MaterialTextBoxApellidoMaterno.AnimateReadOnly = False
        Me.MaterialTextBoxApellidoMaterno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MaterialTextBoxApellidoMaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.MaterialTextBoxApellidoMaterno.Depth = 0
        Me.MaterialTextBoxApellidoMaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBoxApellidoMaterno.HideSelection = True
        Me.MaterialTextBoxApellidoMaterno.Hint = "Apellido Materno"
        Me.MaterialTextBoxApellidoMaterno.LeadingIcon = Nothing
        Me.MaterialTextBoxApellidoMaterno.Location = New System.Drawing.Point(16, 236)
        Me.MaterialTextBoxApellidoMaterno.MaxLength = 32767
        Me.MaterialTextBoxApellidoMaterno.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextBoxApellidoMaterno.Name = "MaterialTextBoxApellidoMaterno"
        Me.MaterialTextBoxApellidoMaterno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialTextBoxApellidoMaterno.PrefixSuffixText = Nothing
        Me.MaterialTextBoxApellidoMaterno.ReadOnly = False
        Me.MaterialTextBoxApellidoMaterno.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MaterialTextBoxApellidoMaterno.SelectedText = ""
        Me.MaterialTextBoxApellidoMaterno.SelectionLength = 0
        Me.MaterialTextBoxApellidoMaterno.SelectionStart = 0
        Me.MaterialTextBoxApellidoMaterno.ShortcutsEnabled = True
        Me.MaterialTextBoxApellidoMaterno.Size = New System.Drawing.Size(308, 48)
        Me.MaterialTextBoxApellidoMaterno.TabIndex = 11
        Me.MaterialTextBoxApellidoMaterno.TabStop = False
        Me.MaterialTextBoxApellidoMaterno.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.MaterialTextBoxApellidoMaterno.TrailingIcon = Nothing
        Me.MaterialTextBoxApellidoMaterno.UseSystemPasswordChar = False
        '
        'MaterialTextBoxSegundoNombre
        '
        Me.MaterialTextBoxSegundoNombre.AnimateReadOnly = False
        Me.MaterialTextBoxSegundoNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MaterialTextBoxSegundoNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.MaterialTextBoxSegundoNombre.Depth = 0
        Me.MaterialTextBoxSegundoNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBoxSegundoNombre.HideSelection = True
        Me.MaterialTextBoxSegundoNombre.Hint = "Segundo nombre"
        Me.MaterialTextBoxSegundoNombre.LeadingIcon = Nothing
        Me.MaterialTextBoxSegundoNombre.Location = New System.Drawing.Point(16, 96)
        Me.MaterialTextBoxSegundoNombre.MaxLength = 32767
        Me.MaterialTextBoxSegundoNombre.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextBoxSegundoNombre.Name = "MaterialTextBoxSegundoNombre"
        Me.MaterialTextBoxSegundoNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialTextBoxSegundoNombre.PrefixSuffixText = Nothing
        Me.MaterialTextBoxSegundoNombre.ReadOnly = False
        Me.MaterialTextBoxSegundoNombre.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MaterialTextBoxSegundoNombre.SelectedText = ""
        Me.MaterialTextBoxSegundoNombre.SelectionLength = 0
        Me.MaterialTextBoxSegundoNombre.SelectionStart = 0
        Me.MaterialTextBoxSegundoNombre.ShortcutsEnabled = True
        Me.MaterialTextBoxSegundoNombre.Size = New System.Drawing.Size(308, 48)
        Me.MaterialTextBoxSegundoNombre.TabIndex = 10
        Me.MaterialTextBoxSegundoNombre.TabStop = False
        Me.MaterialTextBoxSegundoNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.MaterialTextBoxSegundoNombre.TrailingIcon = Nothing
        Me.MaterialTextBoxSegundoNombre.UseSystemPasswordChar = False
        '
        'MaterialTextBoxPrimerNombre
        '
        Me.MaterialTextBoxPrimerNombre.AnimateReadOnly = True
        Me.MaterialTextBoxPrimerNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MaterialTextBoxPrimerNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.MaterialTextBoxPrimerNombre.Depth = 0
        Me.MaterialTextBoxPrimerNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBoxPrimerNombre.HideSelection = True
        Me.MaterialTextBoxPrimerNombre.Hint = "Primer nombre*"
        Me.MaterialTextBoxPrimerNombre.LeadingIcon = Nothing
        Me.MaterialTextBoxPrimerNombre.LeaveOnEnterKey = True
        Me.MaterialTextBoxPrimerNombre.Location = New System.Drawing.Point(16, 26)
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
        Me.MaterialTextBoxPrimerNombre.TabIndex = 8
        Me.MaterialTextBoxPrimerNombre.TabStop = False
        Me.MaterialTextBoxPrimerNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.MaterialTextBoxPrimerNombre.TrailingIcon = Nothing
        Me.MaterialTextBoxPrimerNombre.UseSystemPasswordChar = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Quicksand", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 488)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 19)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Estado civil"
        '
        'ButtonAceptar
        '
        Me.ButtonAceptar.BackColor = System.Drawing.Color.ForestGreen
        Me.ButtonAceptar.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.ButtonAceptar.FlatAppearance.BorderSize = 2
        Me.ButtonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAceptar.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAceptar.ForeColor = System.Drawing.Color.White
        Me.ButtonAceptar.Location = New System.Drawing.Point(948, 566)
        Me.ButtonAceptar.Margin = New System.Windows.Forms.Padding(50, 3, 50, 3)
        Me.ButtonAceptar.Name = "ButtonAceptar"
        Me.ButtonAceptar.Size = New System.Drawing.Size(104, 42)
        Me.ButtonAceptar.TabIndex = 26
        Me.ButtonAceptar.Text = "Aceptar"
        Me.ButtonAceptar.UseVisualStyleBackColor = False
        '
        'ButtonCancelar
        '
        Me.ButtonCancelar.BackColor = System.Drawing.Color.Gray
        Me.ButtonCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.ButtonCancelar.FlatAppearance.BorderSize = 2
        Me.ButtonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCancelar.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancelar.ForeColor = System.Drawing.Color.White
        Me.ButtonCancelar.Location = New System.Drawing.Point(807, 566)
        Me.ButtonCancelar.Margin = New System.Windows.Forms.Padding(50, 3, 50, 3)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(104, 42)
        Me.ButtonCancelar.TabIndex = 25
        Me.ButtonCancelar.Text = "Cancelar"
        Me.ButtonCancelar.UseVisualStyleBackColor = False
        '
        'FrmRegistrarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1064, 620)
        Me.Controls.Add(Me.ButtonAceptar)
        Me.Controls.Add(Me.ButtonCancelar)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmRegistrarCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmRegistrarCliente"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents MaterialTextBoxCURP As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialTextBoxRFC As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialTextBoxEstado As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialTextBoxCodigoPostal As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialTextBoxColonia As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents Label4 As Label
    Friend WithEvents MaterialTextBoxMunicipio As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialTextBoxCalle As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialTextBoxNumero As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MaterialComboBox1 As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents MaterialTextBoxApellidoPaterno As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialTextBoxApellidoMaterno As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialTextBoxSegundoNombre As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialTextBoxPrimerNombre As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents Label5 As Label
    Friend WithEvents ButtonAceptar As Button
    Friend WithEvents ButtonCancelar As Button
    Friend WithEvents MaterialTextBoxCasa As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialMultiLineTextBoxDescripcion As MaterialSkin.Controls.MaterialMultiLineTextBox2
    Friend WithEvents MaterialTextBoxEmail As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialTextBoxExterno As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialTextBoxTrabajo As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialTextBoxCelular As MaterialSkin.Controls.MaterialTextBox2
End Class
