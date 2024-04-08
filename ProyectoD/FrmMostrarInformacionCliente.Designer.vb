<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMostrarInformacionCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMostrarInformacionCliente))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.labelDatosgenerales = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MaterialComboBox1 = New MaterialSkin.Controls.MaterialComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MaterialTextBoxApellidoPaterno = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialTextBoxApellidoMaterno = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialTextBoxSegundoNombre = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialTextBoxPrimerNombre = New MaterialSkin.Controls.MaterialTextBox2()
        Me.Label5 = New System.Windows.Forms.Label()
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
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.MaterialTextBoxCasa = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialMultiLineTextBoxDescripcion = New MaterialSkin.Controls.MaterialMultiLineTextBox2()
        Me.MaterialTextBoxEmail = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialTextBoxExterno = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialTextBoxTrabajo = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialTextBoxCelular = New MaterialSkin.Controls.MaterialTextBox2()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ButtonAceptar = New System.Windows.Forms.Button()
        Me.ButtonguardarInformacion = New System.Windows.Forms.Button()
        Me.Buttoncancelar = New System.Windows.Forms.Button()
        Me.ButtonVermascotas = New System.Windows.Forms.Button()
        Me.ButtonEditar = New System.Windows.Forms.Button()
        Me.ButtonAgendar = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ButtonHistorai = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel1.Controls.Add(Me.IconButton1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1231, 56)
        Me.Panel1.TabIndex = 0
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
        Me.IconButton1.Size = New System.Drawing.Size(95, 56)
        Me.IconButton1.TabIndex = 3
        Me.IconButton1.Text = "Regresar"
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(101, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(359, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Información del cliente"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlowLayoutPanel1.Controls.Add(Me.labelDatosgenerales)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(21, 61)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(0, 0)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'labelDatosgenerales
        '
        Me.labelDatosgenerales.AutoSize = True
        Me.labelDatosgenerales.Font = New System.Drawing.Font("Quicksand", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelDatosgenerales.Location = New System.Drawing.Point(3, 0)
        Me.labelDatosgenerales.Name = "labelDatosgenerales"
        Me.labelDatosgenerales.Size = New System.Drawing.Size(171, 22)
        Me.labelDatosgenerales.TabIndex = 0
        Me.labelDatosgenerales.Text = "Datos generales:"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.MaterialComboBox1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.MaterialTextBoxApellidoPaterno)
        Me.Panel2.Controls.Add(Me.MaterialTextBoxApellidoMaterno)
        Me.Panel2.Controls.Add(Me.MaterialTextBoxSegundoNombre)
        Me.Panel2.Controls.Add(Me.MaterialTextBoxPrimerNombre)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(14, 62)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(340, 479)
        Me.Panel2.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Quicksand", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 19)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "IDPalace:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(100, 40)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(202, 20)
        Me.TextBox1.TabIndex = 18
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
        Me.MaterialComboBox1.Hint = "Genero"
        Me.MaterialComboBox1.IntegralHeight = False
        Me.MaterialComboBox1.ItemHeight = 43
        Me.MaterialComboBox1.Location = New System.Drawing.Point(16, 348)
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
        Me.MaterialTextBoxApellidoPaterno.Hint = "Apellido paterno"
        Me.MaterialTextBoxApellidoPaterno.LeadingIcon = Nothing
        Me.MaterialTextBoxApellidoPaterno.Location = New System.Drawing.Point(16, 214)
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
        Me.MaterialTextBoxApellidoMaterno.Location = New System.Drawing.Point(16, 281)
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
        Me.MaterialTextBoxSegundoNombre.Location = New System.Drawing.Point(16, 160)
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
        Me.MaterialTextBoxPrimerNombre.Hint = "Primer nombre"
        Me.MaterialTextBoxPrimerNombre.LeadingIcon = Nothing
        Me.MaterialTextBoxPrimerNombre.LeaveOnEnterKey = True
        Me.MaterialTextBoxPrimerNombre.Location = New System.Drawing.Point(16, 80)
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
        Me.Panel3.Location = New System.Drawing.Point(360, 62)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(340, 479)
        Me.Panel3.TabIndex = 3
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
        Me.Panel4.Location = New System.Drawing.Point(706, 62)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(340, 479)
        Me.Panel4.TabIndex = 3
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
        Me.MaterialTextBoxCasa.Location = New System.Drawing.Point(7, 48)
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
        Me.MaterialTextBoxCasa.TabIndex = 33
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
        Me.MaterialMultiLineTextBoxDescripcion.Location = New System.Drawing.Point(7, 316)
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
        Me.MaterialMultiLineTextBoxDescripcion.TabIndex = 32
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
        Me.MaterialTextBoxEmail.Location = New System.Drawing.Point(7, 262)
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
        Me.MaterialTextBoxEmail.TabIndex = 30
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
        Me.MaterialTextBoxExterno.Location = New System.Drawing.Point(7, 208)
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
        Me.MaterialTextBoxExterno.TabIndex = 29
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
        Me.MaterialTextBoxTrabajo.Location = New System.Drawing.Point(7, 156)
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
        Me.MaterialTextBoxTrabajo.TabIndex = 28
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
        Me.MaterialTextBoxCelular.Location = New System.Drawing.Point(7, 102)
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
        Me.MaterialTextBoxCelular.TabIndex = 27
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
        Me.Label6.Location = New System.Drawing.Point(-1, 1)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 22)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Datos:"
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightYellow
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeight = 30
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.SteelBlue
        Me.DataGridView1.Location = New System.Drawing.Point(22, 573)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(820, 161)
        Me.DataGridView1.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Quicksand", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(18, 548)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(206, 22)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Mascotas del cliente"
        '
        'ButtonAceptar
        '
        Me.ButtonAceptar.BackColor = System.Drawing.Color.SteelBlue
        Me.ButtonAceptar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.ButtonAceptar.FlatAppearance.BorderSize = 2
        Me.ButtonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAceptar.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAceptar.ForeColor = System.Drawing.Color.White
        Me.ButtonAceptar.Location = New System.Drawing.Point(1055, 66)
        Me.ButtonAceptar.Margin = New System.Windows.Forms.Padding(50, 3, 50, 3)
        Me.ButtonAceptar.Name = "ButtonAceptar"
        Me.ButtonAceptar.Size = New System.Drawing.Size(94, 42)
        Me.ButtonAceptar.TabIndex = 25
        Me.ButtonAceptar.Text = "Editar"
        Me.ButtonAceptar.UseVisualStyleBackColor = False
        '
        'ButtonguardarInformacion
        '
        Me.ButtonguardarInformacion.BackColor = System.Drawing.Color.ForestGreen
        Me.ButtonguardarInformacion.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.ButtonguardarInformacion.FlatAppearance.BorderSize = 2
        Me.ButtonguardarInformacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonguardarInformacion.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonguardarInformacion.ForeColor = System.Drawing.Color.White
        Me.ButtonguardarInformacion.Location = New System.Drawing.Point(1055, 117)
        Me.ButtonguardarInformacion.Margin = New System.Windows.Forms.Padding(50, 3, 50, 3)
        Me.ButtonguardarInformacion.Name = "ButtonguardarInformacion"
        Me.ButtonguardarInformacion.Size = New System.Drawing.Size(94, 42)
        Me.ButtonguardarInformacion.TabIndex = 26
        Me.ButtonguardarInformacion.Text = "Guardar"
        Me.ButtonguardarInformacion.UseVisualStyleBackColor = False
        '
        'Buttoncancelar
        '
        Me.Buttoncancelar.BackColor = System.Drawing.Color.Crimson
        Me.Buttoncancelar.FlatAppearance.BorderColor = System.Drawing.Color.Crimson
        Me.Buttoncancelar.FlatAppearance.BorderSize = 2
        Me.Buttoncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Buttoncancelar.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttoncancelar.ForeColor = System.Drawing.Color.White
        Me.Buttoncancelar.Location = New System.Drawing.Point(1055, 165)
        Me.Buttoncancelar.Margin = New System.Windows.Forms.Padding(50, 3, 50, 3)
        Me.Buttoncancelar.Name = "Buttoncancelar"
        Me.Buttoncancelar.Size = New System.Drawing.Size(94, 42)
        Me.Buttoncancelar.TabIndex = 27
        Me.Buttoncancelar.Text = "Cancelar"
        Me.Buttoncancelar.UseVisualStyleBackColor = False
        '
        'ButtonVermascotas
        '
        Me.ButtonVermascotas.BackColor = System.Drawing.Color.SteelBlue
        Me.ButtonVermascotas.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.ButtonVermascotas.FlatAppearance.BorderSize = 2
        Me.ButtonVermascotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonVermascotas.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonVermascotas.ForeColor = System.Drawing.Color.White
        Me.ButtonVermascotas.Location = New System.Drawing.Point(880, 573)
        Me.ButtonVermascotas.Margin = New System.Windows.Forms.Padding(50, 3, 50, 3)
        Me.ButtonVermascotas.Name = "ButtonVermascotas"
        Me.ButtonVermascotas.Size = New System.Drawing.Size(85, 42)
        Me.ButtonVermascotas.TabIndex = 29
        Me.ButtonVermascotas.Text = "Ver"
        Me.ButtonVermascotas.UseVisualStyleBackColor = False
        '
        'ButtonEditar
        '
        Me.ButtonEditar.BackColor = System.Drawing.Color.SteelBlue
        Me.ButtonEditar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.ButtonEditar.FlatAppearance.BorderSize = 2
        Me.ButtonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEditar.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEditar.ForeColor = System.Drawing.Color.White
        Me.ButtonEditar.Location = New System.Drawing.Point(880, 621)
        Me.ButtonEditar.Margin = New System.Windows.Forms.Padding(50, 3, 50, 3)
        Me.ButtonEditar.Name = "ButtonEditar"
        Me.ButtonEditar.Size = New System.Drawing.Size(85, 42)
        Me.ButtonEditar.TabIndex = 32
        Me.ButtonEditar.Text = "Editar"
        Me.ButtonEditar.UseVisualStyleBackColor = False
        '
        'ButtonAgendar
        '
        Me.ButtonAgendar.BackColor = System.Drawing.Color.ForestGreen
        Me.ButtonAgendar.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.ButtonAgendar.FlatAppearance.BorderSize = 2
        Me.ButtonAgendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAgendar.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAgendar.ForeColor = System.Drawing.Color.White
        Me.ButtonAgendar.Location = New System.Drawing.Point(1099, 673)
        Me.ButtonAgendar.Margin = New System.Windows.Forms.Padding(50, 3, 50, 3)
        Me.ButtonAgendar.Name = "ButtonAgendar"
        Me.ButtonAgendar.Size = New System.Drawing.Size(123, 42)
        Me.ButtonAgendar.TabIndex = 33
        Me.ButtonAgendar.Text = "Agendar Cita"
        Me.ButtonAgendar.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = Global.Petpalace.My.Resources.Resources.AddItem_16x16
        Me.Button3.Location = New System.Drawing.Point(220, 551)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(22, 22)
        Me.Button3.TabIndex = 28
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Image = Global.Petpalace.My.Resources.Resources.RefreshPivotTable_16x16
        Me.Button5.Location = New System.Drawing.Point(248, 551)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(22, 22)
        Me.Button5.TabIndex = 31
        Me.Button5.UseVisualStyleBackColor = True
        '
        'ButtonHistorai
        '
        Me.ButtonHistorai.BackColor = System.Drawing.Color.SteelBlue
        Me.ButtonHistorai.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.ButtonHistorai.FlatAppearance.BorderSize = 2
        Me.ButtonHistorai.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonHistorai.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonHistorai.ForeColor = System.Drawing.Color.White
        Me.ButtonHistorai.Location = New System.Drawing.Point(880, 669)
        Me.ButtonHistorai.Margin = New System.Windows.Forms.Padding(50, 3, 50, 3)
        Me.ButtonHistorai.Name = "ButtonHistorai"
        Me.ButtonHistorai.Size = New System.Drawing.Size(85, 42)
        Me.ButtonHistorai.TabIndex = 34
        Me.ButtonHistorai.Text = "Historial"
        Me.ButtonHistorai.UseVisualStyleBackColor = False
        '
        'FrmMostrarInformacionCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1248, 727)
        Me.Controls.Add(Me.ButtonHistorai)
        Me.Controls.Add(Me.ButtonAgendar)
        Me.Controls.Add(Me.ButtonEditar)
        Me.Controls.Add(Me.ButtonVermascotas)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Buttoncancelar)
        Me.Controls.Add(Me.ButtonguardarInformacion)
        Me.Controls.Add(Me.ButtonAceptar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMostrarInformacionCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informacion Cliente"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents labelDatosgenerales As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents MaterialTextBoxApellidoPaterno As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialTextBoxApellidoMaterno As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialTextBoxSegundoNombre As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialTextBoxPrimerNombre As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents Label5 As Label
    Friend WithEvents MaterialTextBoxCURP As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialTextBoxRFC As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialTextBoxEstado As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialTextBoxCodigoPostal As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialTextBoxColonia As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents Label4 As Label
    Friend WithEvents MaterialTextBoxMunicipio As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialTextBoxCalle As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialTextBoxNumero As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialTextBoxEmail As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialTextBoxExterno As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialTextBoxTrabajo As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialTextBoxCelular As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents MaterialComboBox1 As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents MaterialMultiLineTextBoxDescripcion As MaterialSkin.Controls.MaterialMultiLineTextBox2
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents MaterialTextBoxCasa As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents ButtonAceptar As Button
    Friend WithEvents ButtonguardarInformacion As Button
    Friend WithEvents Buttoncancelar As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ButtonVermascotas As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents ButtonEditar As Button
    Friend WithEvents ButtonAgendar As Button
    Friend WithEvents ButtonHistorai As Button
End Class
