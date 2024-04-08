<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMostrarInformacionCita
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.MaterialTextBoxCasa = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialMultiLineTextBoxDescripcion = New MaterialSkin.Controls.MaterialMultiLineTextBox2()
        Me.MaterialTextBoxExterno = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialTextBoxTrabajo = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialTextBoxCelular = New MaterialSkin.Controls.MaterialTextBox2()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MaterialTextBoxApellidoPaterno = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialTextBoxEmail = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialTextBoxApellidoMaterno = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialTextBoxSegundoNombre = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialTextBoxPrimerNombre = New MaterialSkin.Controls.MaterialTextBox2()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MaterialTextBoSexo = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialTextBox2RAZA = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialTextBoxTipoMascota = New MaterialSkin.Controls.MaterialTextBox2()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.DateTimePickerFin = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimePickerInicio = New System.Windows.Forms.DateTimePicker()
        Me.MaterialCheckboxVACUNADONO = New MaterialSkin.Controls.MaterialCheckbox()
        Me.MaterialCheckboxVACUNADOSI = New MaterialSkin.Controls.MaterialCheckbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MaterialTextBoxpeso = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialTextBoxNombreMascota = New MaterialSkin.Controls.MaterialTextBox2()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.LabelCostototal = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        Me.ButtonAgregar = New System.Windows.Forms.Button()
        Me.MaterialTextBoxCosto = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialComboBoxServicios = New MaterialSkin.Controls.MaterialComboBox()
        Me.MaterialComboBoxTServicio = New MaterialSkin.Controls.MaterialComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MaterialMultiLineTextBox21 = New MaterialSkin.Controls.MaterialMultiLineTextBox2()
        Me.MaterialComboBoxHORARIO = New MaterialSkin.Controls.MaterialComboBox()
        Me.DateTimePickercitas = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ButtonAceptar = New System.Windows.Forms.Button()
        Me.ButtonEditar = New System.Windows.Forms.Button()
        Me.ButtonGuardar = New System.Windows.Forms.Button()
        Me.Buttoncancelar = New System.Windows.Forms.Button()
        Me.MaterialComboBoxEstadoCita = New MaterialSkin.Controls.MaterialComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.MaterialTextBoxCasa)
        Me.Panel3.Controls.Add(Me.MaterialMultiLineTextBoxDescripcion)
        Me.Panel3.Controls.Add(Me.MaterialTextBoxExterno)
        Me.Panel3.Controls.Add(Me.MaterialTextBoxTrabajo)
        Me.Panel3.Controls.Add(Me.MaterialTextBoxCelular)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(360, 29)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(340, 400)
        Me.Panel3.TabIndex = 33
        '
        'MaterialTextBoxCasa
        '
        Me.MaterialTextBoxCasa.AnimateReadOnly = True
        Me.MaterialTextBoxCasa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MaterialTextBoxCasa.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.MaterialTextBoxCasa.Depth = 0
        Me.MaterialTextBoxCasa.Enabled = False
        Me.MaterialTextBoxCasa.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBoxCasa.HideSelection = True
        Me.MaterialTextBoxCasa.Hint = "casa"
        Me.MaterialTextBoxCasa.LeadingIcon = Nothing
        Me.MaterialTextBoxCasa.LeaveOnEnterKey = True
        Me.MaterialTextBoxCasa.Location = New System.Drawing.Point(15, 33)
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
        Me.MaterialMultiLineTextBoxDescripcion.Enabled = False
        Me.MaterialMultiLineTextBoxDescripcion.HideSelection = True
        Me.MaterialMultiLineTextBoxDescripcion.Hint = "Opciones especiales del cliente"
        Me.MaterialMultiLineTextBoxDescripcion.Location = New System.Drawing.Point(15, 247)
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
        'MaterialTextBoxExterno
        '
        Me.MaterialTextBoxExterno.AnimateReadOnly = True
        Me.MaterialTextBoxExterno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MaterialTextBoxExterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.MaterialTextBoxExterno.Depth = 0
        Me.MaterialTextBoxExterno.Enabled = False
        Me.MaterialTextBoxExterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBoxExterno.HideSelection = True
        Me.MaterialTextBoxExterno.Hint = "Externo"
        Me.MaterialTextBoxExterno.LeadingIcon = Nothing
        Me.MaterialTextBoxExterno.LeaveOnEnterKey = True
        Me.MaterialTextBoxExterno.Location = New System.Drawing.Point(15, 193)
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
        Me.MaterialTextBoxTrabajo.Enabled = False
        Me.MaterialTextBoxTrabajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBoxTrabajo.HideSelection = True
        Me.MaterialTextBoxTrabajo.Hint = "Trabajo"
        Me.MaterialTextBoxTrabajo.LeadingIcon = Nothing
        Me.MaterialTextBoxTrabajo.LeaveOnEnterKey = True
        Me.MaterialTextBoxTrabajo.Location = New System.Drawing.Point(15, 141)
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
        Me.MaterialTextBoxCelular.Enabled = False
        Me.MaterialTextBoxCelular.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBoxCelular.HideSelection = True
        Me.MaterialTextBoxCelular.Hint = "Celular"
        Me.MaterialTextBoxCelular.LeadingIcon = Nothing
        Me.MaterialTextBoxCelular.LeaveOnEnterKey = True
        Me.MaterialTextBoxCelular.Location = New System.Drawing.Point(15, 87)
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Quicksand", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 1)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 22)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Telefonos:"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.MaterialTextBoxApellidoPaterno)
        Me.Panel2.Controls.Add(Me.MaterialTextBoxEmail)
        Me.Panel2.Controls.Add(Me.MaterialTextBoxApellidoMaterno)
        Me.Panel2.Controls.Add(Me.MaterialTextBoxSegundoNombre)
        Me.Panel2.Controls.Add(Me.MaterialTextBoxPrimerNombre)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(14, 29)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(340, 356)
        Me.Panel2.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Quicksand", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(278, 22)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Datos generales del cliente:"
        '
        'MaterialTextBoxApellidoPaterno
        '
        Me.MaterialTextBoxApellidoPaterno.AnimateReadOnly = False
        Me.MaterialTextBoxApellidoPaterno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MaterialTextBoxApellidoPaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.MaterialTextBoxApellidoPaterno.Depth = 0
        Me.MaterialTextBoxApellidoPaterno.Enabled = False
        Me.MaterialTextBoxApellidoPaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBoxApellidoPaterno.HideSelection = True
        Me.MaterialTextBoxApellidoPaterno.Hint = "Apellido paterno"
        Me.MaterialTextBoxApellidoPaterno.LeadingIcon = Nothing
        Me.MaterialTextBoxApellidoPaterno.Location = New System.Drawing.Point(16, 141)
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
        'MaterialTextBoxEmail
        '
        Me.MaterialTextBoxEmail.AnimateReadOnly = True
        Me.MaterialTextBoxEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MaterialTextBoxEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.MaterialTextBoxEmail.Depth = 0
        Me.MaterialTextBoxEmail.Enabled = False
        Me.MaterialTextBoxEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBoxEmail.HideSelection = True
        Me.MaterialTextBoxEmail.Hint = "Email"
        Me.MaterialTextBoxEmail.LeadingIcon = Nothing
        Me.MaterialTextBoxEmail.LeaveOnEnterKey = True
        Me.MaterialTextBoxEmail.Location = New System.Drawing.Point(16, 249)
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
        'MaterialTextBoxApellidoMaterno
        '
        Me.MaterialTextBoxApellidoMaterno.AnimateReadOnly = False
        Me.MaterialTextBoxApellidoMaterno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MaterialTextBoxApellidoMaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.MaterialTextBoxApellidoMaterno.Depth = 0
        Me.MaterialTextBoxApellidoMaterno.Enabled = False
        Me.MaterialTextBoxApellidoMaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBoxApellidoMaterno.HideSelection = True
        Me.MaterialTextBoxApellidoMaterno.Hint = "Apellido Materno"
        Me.MaterialTextBoxApellidoMaterno.LeadingIcon = Nothing
        Me.MaterialTextBoxApellidoMaterno.Location = New System.Drawing.Point(16, 195)
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
        Me.MaterialTextBoxSegundoNombre.Enabled = False
        Me.MaterialTextBoxSegundoNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBoxSegundoNombre.HideSelection = True
        Me.MaterialTextBoxSegundoNombre.Hint = "Segundo nombre"
        Me.MaterialTextBoxSegundoNombre.LeadingIcon = Nothing
        Me.MaterialTextBoxSegundoNombre.Location = New System.Drawing.Point(16, 87)
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
        Me.MaterialTextBoxPrimerNombre.Enabled = False
        Me.MaterialTextBoxPrimerNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBoxPrimerNombre.HideSelection = True
        Me.MaterialTextBoxPrimerNombre.Hint = "Primer nombre"
        Me.MaterialTextBoxPrimerNombre.LeadingIcon = Nothing
        Me.MaterialTextBoxPrimerNombre.LeaveOnEnterKey = True
        Me.MaterialTextBoxPrimerNombre.Location = New System.Drawing.Point(16, 33)
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
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.MaterialTextBoSexo)
        Me.Panel1.Controls.Add(Me.MaterialTextBox2RAZA)
        Me.Panel1.Controls.Add(Me.MaterialTextBoxTipoMascota)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.DateTimePickerFin)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.DateTimePickerInicio)
        Me.Panel1.Controls.Add(Me.MaterialCheckboxVACUNADONO)
        Me.Panel1.Controls.Add(Me.MaterialCheckboxVACUNADOSI)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.MaterialTextBoxpeso)
        Me.Panel1.Controls.Add(Me.MaterialTextBoxNombreMascota)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(706, 29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(340, 356)
        Me.Panel1.TabIndex = 40
        '
        'MaterialTextBoSexo
        '
        Me.MaterialTextBoSexo.AnimateReadOnly = False
        Me.MaterialTextBoSexo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MaterialTextBoSexo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.MaterialTextBoSexo.Depth = 0
        Me.MaterialTextBoSexo.Enabled = False
        Me.MaterialTextBoSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBoSexo.HideSelection = True
        Me.MaterialTextBoSexo.Hint = "Sexo"
        Me.MaterialTextBoSexo.LeadingIcon = Nothing
        Me.MaterialTextBoSexo.Location = New System.Drawing.Point(7, 141)
        Me.MaterialTextBoSexo.MaxLength = 32767
        Me.MaterialTextBoSexo.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextBoSexo.Name = "MaterialTextBoSexo"
        Me.MaterialTextBoSexo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialTextBoSexo.PrefixSuffixText = Nothing
        Me.MaterialTextBoSexo.ReadOnly = False
        Me.MaterialTextBoSexo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MaterialTextBoSexo.SelectedText = ""
        Me.MaterialTextBoSexo.SelectionLength = 0
        Me.MaterialTextBoSexo.SelectionStart = 0
        Me.MaterialTextBoSexo.ShortcutsEnabled = True
        Me.MaterialTextBoSexo.Size = New System.Drawing.Size(157, 48)
        Me.MaterialTextBoSexo.TabIndex = 54
        Me.MaterialTextBoSexo.TabStop = False
        Me.MaterialTextBoSexo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.MaterialTextBoSexo.TrailingIcon = Nothing
        Me.MaterialTextBoSexo.UseSystemPasswordChar = False
        '
        'MaterialTextBox2RAZA
        '
        Me.MaterialTextBox2RAZA.AnimateReadOnly = False
        Me.MaterialTextBox2RAZA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MaterialTextBox2RAZA.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.MaterialTextBox2RAZA.Depth = 0
        Me.MaterialTextBox2RAZA.Enabled = False
        Me.MaterialTextBox2RAZA.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBox2RAZA.HideSelection = True
        Me.MaterialTextBox2RAZA.Hint = "Raza"
        Me.MaterialTextBox2RAZA.LeadingIcon = Nothing
        Me.MaterialTextBox2RAZA.Location = New System.Drawing.Point(178, 87)
        Me.MaterialTextBox2RAZA.MaxLength = 32767
        Me.MaterialTextBox2RAZA.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextBox2RAZA.Name = "MaterialTextBox2RAZA"
        Me.MaterialTextBox2RAZA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialTextBox2RAZA.PrefixSuffixText = Nothing
        Me.MaterialTextBox2RAZA.ReadOnly = False
        Me.MaterialTextBox2RAZA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MaterialTextBox2RAZA.SelectedText = ""
        Me.MaterialTextBox2RAZA.SelectionLength = 0
        Me.MaterialTextBox2RAZA.SelectionStart = 0
        Me.MaterialTextBox2RAZA.ShortcutsEnabled = True
        Me.MaterialTextBox2RAZA.Size = New System.Drawing.Size(157, 48)
        Me.MaterialTextBox2RAZA.TabIndex = 53
        Me.MaterialTextBox2RAZA.TabStop = False
        Me.MaterialTextBox2RAZA.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.MaterialTextBox2RAZA.TrailingIcon = Nothing
        Me.MaterialTextBox2RAZA.UseSystemPasswordChar = False
        '
        'MaterialTextBoxTipoMascota
        '
        Me.MaterialTextBoxTipoMascota.AnimateReadOnly = False
        Me.MaterialTextBoxTipoMascota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MaterialTextBoxTipoMascota.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.MaterialTextBoxTipoMascota.Depth = 0
        Me.MaterialTextBoxTipoMascota.Enabled = False
        Me.MaterialTextBoxTipoMascota.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBoxTipoMascota.HideSelection = True
        Me.MaterialTextBoxTipoMascota.Hint = "Tipo de mascota"
        Me.MaterialTextBoxTipoMascota.LeadingIcon = Nothing
        Me.MaterialTextBoxTipoMascota.Location = New System.Drawing.Point(7, 87)
        Me.MaterialTextBoxTipoMascota.MaxLength = 32767
        Me.MaterialTextBoxTipoMascota.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextBoxTipoMascota.Name = "MaterialTextBoxTipoMascota"
        Me.MaterialTextBoxTipoMascota.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialTextBoxTipoMascota.PrefixSuffixText = Nothing
        Me.MaterialTextBoxTipoMascota.ReadOnly = False
        Me.MaterialTextBoxTipoMascota.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MaterialTextBoxTipoMascota.SelectedText = ""
        Me.MaterialTextBoxTipoMascota.SelectionLength = 0
        Me.MaterialTextBoxTipoMascota.SelectionStart = 0
        Me.MaterialTextBoxTipoMascota.ShortcutsEnabled = True
        Me.MaterialTextBoxTipoMascota.Size = New System.Drawing.Size(165, 48)
        Me.MaterialTextBoxTipoMascota.TabIndex = 52
        Me.MaterialTextBoxTipoMascota.TabStop = False
        Me.MaterialTextBoxTipoMascota.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.MaterialTextBoxTipoMascota.TrailingIcon = Nothing
        Me.MaterialTextBoxTipoMascota.UseSystemPasswordChar = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Gray
        Me.Panel4.Location = New System.Drawing.Point(315, 289)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(20, 20)
        Me.Panel4.TabIndex = 47
        '
        'DateTimePickerFin
        '
        Me.DateTimePickerFin.Enabled = False
        Me.DateTimePickerFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerFin.Location = New System.Drawing.Point(161, 289)
        Me.DateTimePickerFin.Name = "DateTimePickerFin"
        Me.DateTimePickerFin.Size = New System.Drawing.Size(146, 20)
        Me.DateTimePickerFin.TabIndex = 51
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Quicksand", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(157, 267)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 19)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Vigencia vacuna"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Quicksand", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(5, 267)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 19)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Ultima Vacuna"
        '
        'DateTimePickerInicio
        '
        Me.DateTimePickerInicio.Enabled = False
        Me.DateTimePickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerInicio.Location = New System.Drawing.Point(9, 289)
        Me.DateTimePickerInicio.Name = "DateTimePickerInicio"
        Me.DateTimePickerInicio.Size = New System.Drawing.Size(146, 20)
        Me.DateTimePickerInicio.TabIndex = 48
        '
        'MaterialCheckboxVACUNADONO
        '
        Me.MaterialCheckboxVACUNADONO.AutoSize = True
        Me.MaterialCheckboxVACUNADONO.Depth = 0
        Me.MaterialCheckboxVACUNADONO.Enabled = False
        Me.MaterialCheckboxVACUNADONO.Location = New System.Drawing.Point(244, 228)
        Me.MaterialCheckboxVACUNADONO.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialCheckboxVACUNADONO.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialCheckboxVACUNADONO.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCheckboxVACUNADONO.Name = "MaterialCheckboxVACUNADONO"
        Me.MaterialCheckboxVACUNADONO.ReadOnly = False
        Me.MaterialCheckboxVACUNADONO.Ripple = True
        Me.MaterialCheckboxVACUNADONO.Size = New System.Drawing.Size(55, 37)
        Me.MaterialCheckboxVACUNADONO.TabIndex = 46
        Me.MaterialCheckboxVACUNADONO.Text = "No"
        Me.MaterialCheckboxVACUNADONO.UseVisualStyleBackColor = True
        '
        'MaterialCheckboxVACUNADOSI
        '
        Me.MaterialCheckboxVACUNADOSI.AutoSize = True
        Me.MaterialCheckboxVACUNADOSI.Depth = 0
        Me.MaterialCheckboxVACUNADOSI.Enabled = False
        Me.MaterialCheckboxVACUNADOSI.Location = New System.Drawing.Point(42, 228)
        Me.MaterialCheckboxVACUNADOSI.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialCheckboxVACUNADOSI.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialCheckboxVACUNADOSI.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCheckboxVACUNADOSI.Name = "MaterialCheckboxVACUNADOSI"
        Me.MaterialCheckboxVACUNADOSI.ReadOnly = False
        Me.MaterialCheckboxVACUNADOSI.Ripple = True
        Me.MaterialCheckboxVACUNADOSI.Size = New System.Drawing.Size(49, 37)
        Me.MaterialCheckboxVACUNADOSI.TabIndex = 45
        Me.MaterialCheckboxVACUNADOSI.Text = "Si"
        Me.MaterialCheckboxVACUNADOSI.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Quicksand", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(128, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 19)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Vacunado"
        '
        'MaterialTextBoxpeso
        '
        Me.MaterialTextBoxpeso.AnimateReadOnly = False
        Me.MaterialTextBoxpeso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MaterialTextBoxpeso.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.MaterialTextBoxpeso.Depth = 0
        Me.MaterialTextBoxpeso.Enabled = False
        Me.MaterialTextBoxpeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBoxpeso.HideSelection = True
        Me.MaterialTextBoxpeso.Hint = "peso"
        Me.MaterialTextBoxpeso.LeadingIcon = Nothing
        Me.MaterialTextBoxpeso.Location = New System.Drawing.Point(205, 33)
        Me.MaterialTextBoxpeso.MaxLength = 32767
        Me.MaterialTextBoxpeso.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextBoxpeso.Name = "MaterialTextBoxpeso"
        Me.MaterialTextBoxpeso.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialTextBoxpeso.PrefixSuffixText = Nothing
        Me.MaterialTextBoxpeso.ReadOnly = False
        Me.MaterialTextBoxpeso.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MaterialTextBoxpeso.SelectedText = ""
        Me.MaterialTextBoxpeso.SelectionLength = 0
        Me.MaterialTextBoxpeso.SelectionStart = 0
        Me.MaterialTextBoxpeso.ShortcutsEnabled = True
        Me.MaterialTextBoxpeso.Size = New System.Drawing.Size(130, 48)
        Me.MaterialTextBoxpeso.TabIndex = 40
        Me.MaterialTextBoxpeso.TabStop = False
        Me.MaterialTextBoxpeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.MaterialTextBoxpeso.TrailingIcon = Nothing
        Me.MaterialTextBoxpeso.UseSystemPasswordChar = False
        '
        'MaterialTextBoxNombreMascota
        '
        Me.MaterialTextBoxNombreMascota.AnimateReadOnly = False
        Me.MaterialTextBoxNombreMascota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MaterialTextBoxNombreMascota.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.MaterialTextBoxNombreMascota.Depth = 0
        Me.MaterialTextBoxNombreMascota.Enabled = False
        Me.MaterialTextBoxNombreMascota.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBoxNombreMascota.HideSelection = True
        Me.MaterialTextBoxNombreMascota.Hint = "Nombre de la mascota"
        Me.MaterialTextBoxNombreMascota.LeadingIcon = Nothing
        Me.MaterialTextBoxNombreMascota.Location = New System.Drawing.Point(3, 33)
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
        Me.MaterialTextBoxNombreMascota.Size = New System.Drawing.Size(196, 48)
        Me.MaterialTextBoxNombreMascota.TabIndex = 23
        Me.MaterialTextBoxNombreMascota.TabStop = False
        Me.MaterialTextBoxNombreMascota.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.MaterialTextBoxNombreMascota.TrailingIcon = Nothing
        Me.MaterialTextBoxNombreMascota.UseSystemPasswordChar = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Quicksand", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 22)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Mascota"
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Label10)
        Me.Panel5.Controls.Add(Me.LabelCostototal)
        Me.Panel5.Controls.Add(Me.DataGridView1)
        Me.Panel5.Controls.Add(Me.ButtonEliminar)
        Me.Panel5.Controls.Add(Me.ButtonAgregar)
        Me.Panel5.Controls.Add(Me.MaterialTextBoxCosto)
        Me.Panel5.Controls.Add(Me.MaterialComboBoxServicios)
        Me.Panel5.Controls.Add(Me.MaterialComboBoxTServicio)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Controls.Add(Me.MaterialMultiLineTextBox21)
        Me.Panel5.Controls.Add(Me.MaterialComboBoxHORARIO)
        Me.Panel5.Controls.Add(Me.DateTimePickercitas)
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Location = New System.Drawing.Point(14, 435)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1160, 241)
        Me.Panel5.TabIndex = 38
        '
        'LabelCostototal
        '
        Me.LabelCostototal.AutoSize = True
        Me.LabelCostototal.Font = New System.Drawing.Font("Quicksand", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCostototal.Location = New System.Drawing.Point(1001, 182)
        Me.LabelCostototal.Name = "LabelCostototal"
        Me.LabelCostototal.Size = New System.Drawing.Size(96, 31)
        Me.LabelCostototal.TabIndex = 83
        Me.LabelCostototal.Text = "00.00"
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
        Me.DataGridView1.Location = New System.Drawing.Point(629, 4)
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
        Me.DataGridView1.Size = New System.Drawing.Size(526, 161)
        Me.DataGridView1.TabIndex = 82
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.BackColor = System.Drawing.Color.Crimson
        Me.ButtonEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Crimson
        Me.ButtonEliminar.FlatAppearance.BorderSize = 2
        Me.ButtonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEliminar.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEliminar.ForeColor = System.Drawing.Color.White
        Me.ButtonEliminar.Location = New System.Drawing.Point(629, 171)
        Me.ButtonEliminar.Margin = New System.Windows.Forms.Padding(50, 3, 50, 3)
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(90, 42)
        Me.ButtonEliminar.TabIndex = 81
        Me.ButtonEliminar.Text = "Eliminar"
        Me.ButtonEliminar.UseVisualStyleBackColor = False
        '
        'ButtonAgregar
        '
        Me.ButtonAgregar.BackColor = System.Drawing.Color.ForestGreen
        Me.ButtonAgregar.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.ButtonAgregar.FlatAppearance.BorderSize = 2
        Me.ButtonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAgregar.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAgregar.ForeColor = System.Drawing.Color.White
        Me.ButtonAgregar.Location = New System.Drawing.Point(353, 171)
        Me.ButtonAgregar.Margin = New System.Windows.Forms.Padding(50, 3, 50, 3)
        Me.ButtonAgregar.Name = "ButtonAgregar"
        Me.ButtonAgregar.Size = New System.Drawing.Size(85, 42)
        Me.ButtonAgregar.TabIndex = 80
        Me.ButtonAgregar.Text = "Agregar"
        Me.ButtonAgregar.UseVisualStyleBackColor = False
        '
        'MaterialTextBoxCosto
        '
        Me.MaterialTextBoxCosto.AnimateReadOnly = True
        Me.MaterialTextBoxCosto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MaterialTextBoxCosto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.MaterialTextBoxCosto.Depth = 0
        Me.MaterialTextBoxCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBoxCosto.HideSelection = True
        Me.MaterialTextBoxCosto.Hint = "Costo"
        Me.MaterialTextBoxCosto.LeadingIcon = Nothing
        Me.MaterialTextBoxCosto.LeaveOnEnterKey = True
        Me.MaterialTextBoxCosto.Location = New System.Drawing.Point(353, 117)
        Me.MaterialTextBoxCosto.MaxLength = 32767
        Me.MaterialTextBoxCosto.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextBoxCosto.Name = "MaterialTextBoxCosto"
        Me.MaterialTextBoxCosto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialTextBoxCosto.PrefixSuffixText = Nothing
        Me.MaterialTextBoxCosto.ReadOnly = False
        Me.MaterialTextBoxCosto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MaterialTextBoxCosto.SelectedText = ""
        Me.MaterialTextBoxCosto.SelectionLength = 0
        Me.MaterialTextBoxCosto.SelectionStart = 0
        Me.MaterialTextBoxCosto.ShortcutsEnabled = True
        Me.MaterialTextBoxCosto.Size = New System.Drawing.Size(270, 48)
        Me.MaterialTextBoxCosto.TabIndex = 77
        Me.MaterialTextBoxCosto.TabStop = False
        Me.MaterialTextBoxCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.MaterialTextBoxCosto.TrailingIcon = Nothing
        Me.MaterialTextBoxCosto.UseSystemPasswordChar = False
        '
        'MaterialComboBoxServicios
        '
        Me.MaterialComboBoxServicios.AutoResize = False
        Me.MaterialComboBoxServicios.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialComboBoxServicios.Depth = 0
        Me.MaterialComboBoxServicios.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.MaterialComboBoxServicios.DropDownHeight = 174
        Me.MaterialComboBoxServicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MaterialComboBoxServicios.DropDownWidth = 121
        Me.MaterialComboBoxServicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialComboBoxServicios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialComboBoxServicios.FormattingEnabled = True
        Me.MaterialComboBoxServicios.Hint = "Servicio"
        Me.MaterialComboBoxServicios.IntegralHeight = False
        Me.MaterialComboBoxServicios.ItemHeight = 43
        Me.MaterialComboBoxServicios.Location = New System.Drawing.Point(353, 59)
        Me.MaterialComboBoxServicios.MaxDropDownItems = 4
        Me.MaterialComboBoxServicios.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialComboBoxServicios.Name = "MaterialComboBoxServicios"
        Me.MaterialComboBoxServicios.Size = New System.Drawing.Size(270, 49)
        Me.MaterialComboBoxServicios.StartIndex = 0
        Me.MaterialComboBoxServicios.TabIndex = 76
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
        Me.MaterialComboBoxTServicio.Location = New System.Drawing.Point(353, 4)
        Me.MaterialComboBoxTServicio.MaxDropDownItems = 4
        Me.MaterialComboBoxTServicio.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialComboBoxTServicio.Name = "MaterialComboBoxTServicio"
        Me.MaterialComboBoxTServicio.Size = New System.Drawing.Size(270, 49)
        Me.MaterialComboBoxTServicio.StartIndex = 0
        Me.MaterialComboBoxTServicio.TabIndex = 75
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Quicksand", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(129, 22)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Detalles cita"
        '
        'MaterialMultiLineTextBox21
        '
        Me.MaterialMultiLineTextBox21.AnimateReadOnly = True
        Me.MaterialMultiLineTextBox21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MaterialMultiLineTextBox21.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.MaterialMultiLineTextBox21.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.MaterialMultiLineTextBox21.Depth = 0
        Me.MaterialMultiLineTextBox21.HideSelection = True
        Me.MaterialMultiLineTextBox21.Hint = "Instrucciones especiales para la mascota"
        Me.MaterialMultiLineTextBox21.Location = New System.Drawing.Point(16, 114)
        Me.MaterialMultiLineTextBox21.MaxLength = 32767
        Me.MaterialMultiLineTextBox21.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialMultiLineTextBox21.Name = "MaterialMultiLineTextBox21"
        Me.MaterialMultiLineTextBox21.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialMultiLineTextBox21.ReadOnly = False
        Me.MaterialMultiLineTextBox21.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MaterialMultiLineTextBox21.SelectedText = ""
        Me.MaterialMultiLineTextBox21.SelectionLength = 0
        Me.MaterialMultiLineTextBox21.SelectionStart = 0
        Me.MaterialMultiLineTextBox21.ShortcutsEnabled = True
        Me.MaterialMultiLineTextBox21.Size = New System.Drawing.Size(330, 122)
        Me.MaterialMultiLineTextBox21.TabIndex = 73
        Me.MaterialMultiLineTextBox21.TabStop = False
        Me.MaterialMultiLineTextBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.MaterialMultiLineTextBox21.UseSystemPasswordChar = False
        '
        'MaterialComboBoxHORARIO
        '
        Me.MaterialComboBoxHORARIO.AutoResize = False
        Me.MaterialComboBoxHORARIO.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialComboBoxHORARIO.Depth = 0
        Me.MaterialComboBoxHORARIO.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.MaterialComboBoxHORARIO.DropDownHeight = 174
        Me.MaterialComboBoxHORARIO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MaterialComboBoxHORARIO.DropDownWidth = 121
        Me.MaterialComboBoxHORARIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialComboBoxHORARIO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialComboBoxHORARIO.FormattingEnabled = True
        Me.MaterialComboBoxHORARIO.Hint = "Horario"
        Me.MaterialComboBoxHORARIO.IntegralHeight = False
        Me.MaterialComboBoxHORARIO.ItemHeight = 43
        Me.MaterialComboBoxHORARIO.Location = New System.Drawing.Point(16, 59)
        Me.MaterialComboBoxHORARIO.MaxDropDownItems = 4
        Me.MaterialComboBoxHORARIO.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialComboBoxHORARIO.Name = "MaterialComboBoxHORARIO"
        Me.MaterialComboBoxHORARIO.Size = New System.Drawing.Size(330, 49)
        Me.MaterialComboBoxHORARIO.StartIndex = 0
        Me.MaterialComboBoxHORARIO.TabIndex = 72
        '
        'DateTimePickercitas
        '
        Me.DateTimePickercitas.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickercitas.Location = New System.Drawing.Point(16, 33)
        Me.DateTimePickercitas.Name = "DateTimePickercitas"
        Me.DateTimePickercitas.Size = New System.Drawing.Size(330, 20)
        Me.DateTimePickercitas.TabIndex = 71
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Quicksand", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 488)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 19)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Estado civil"
        '
        'ButtonAceptar
        '
        Me.ButtonAceptar.BackColor = System.Drawing.Color.ForestGreen
        Me.ButtonAceptar.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.ButtonAceptar.FlatAppearance.BorderSize = 2
        Me.ButtonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAceptar.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAceptar.ForeColor = System.Drawing.Color.White
        Me.ButtonAceptar.Location = New System.Drawing.Point(1273, 634)
        Me.ButtonAceptar.Margin = New System.Windows.Forms.Padding(50, 3, 50, 3)
        Me.ButtonAceptar.Name = "ButtonAceptar"
        Me.ButtonAceptar.Size = New System.Drawing.Size(85, 42)
        Me.ButtonAceptar.TabIndex = 41
        Me.ButtonAceptar.Text = "Aceptar"
        Me.ButtonAceptar.UseVisualStyleBackColor = False
        '
        'ButtonEditar
        '
        Me.ButtonEditar.BackColor = System.Drawing.Color.SteelBlue
        Me.ButtonEditar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.ButtonEditar.FlatAppearance.BorderSize = 2
        Me.ButtonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEditar.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEditar.ForeColor = System.Drawing.Color.White
        Me.ButtonEditar.Location = New System.Drawing.Point(1179, 634)
        Me.ButtonEditar.Margin = New System.Windows.Forms.Padding(50, 3, 50, 3)
        Me.ButtonEditar.Name = "ButtonEditar"
        Me.ButtonEditar.Size = New System.Drawing.Size(90, 42)
        Me.ButtonEditar.TabIndex = 42
        Me.ButtonEditar.Text = "Editar"
        Me.ButtonEditar.UseVisualStyleBackColor = False
        '
        'ButtonGuardar
        '
        Me.ButtonGuardar.BackColor = System.Drawing.Color.ForestGreen
        Me.ButtonGuardar.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.ButtonGuardar.FlatAppearance.BorderSize = 2
        Me.ButtonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonGuardar.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGuardar.ForeColor = System.Drawing.Color.White
        Me.ButtonGuardar.Location = New System.Drawing.Point(1273, 634)
        Me.ButtonGuardar.Margin = New System.Windows.Forms.Padding(50, 3, 50, 3)
        Me.ButtonGuardar.Name = "ButtonGuardar"
        Me.ButtonGuardar.Size = New System.Drawing.Size(85, 42)
        Me.ButtonGuardar.TabIndex = 43
        Me.ButtonGuardar.Text = "Guardar"
        Me.ButtonGuardar.UseVisualStyleBackColor = False
        '
        'Buttoncancelar
        '
        Me.Buttoncancelar.BackColor = System.Drawing.Color.Crimson
        Me.Buttoncancelar.FlatAppearance.BorderColor = System.Drawing.Color.Crimson
        Me.Buttoncancelar.FlatAppearance.BorderSize = 2
        Me.Buttoncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Buttoncancelar.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttoncancelar.ForeColor = System.Drawing.Color.White
        Me.Buttoncancelar.Location = New System.Drawing.Point(1179, 634)
        Me.Buttoncancelar.Margin = New System.Windows.Forms.Padding(50, 3, 50, 3)
        Me.Buttoncancelar.Name = "Buttoncancelar"
        Me.Buttoncancelar.Size = New System.Drawing.Size(90, 42)
        Me.Buttoncancelar.TabIndex = 44
        Me.Buttoncancelar.Text = "Cancelar"
        Me.Buttoncancelar.UseVisualStyleBackColor = False
        '
        'MaterialComboBoxEstadoCita
        '
        Me.MaterialComboBoxEstadoCita.AutoResize = False
        Me.MaterialComboBoxEstadoCita.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialComboBoxEstadoCita.Depth = 0
        Me.MaterialComboBoxEstadoCita.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.MaterialComboBoxEstadoCita.DropDownHeight = 174
        Me.MaterialComboBoxEstadoCita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MaterialComboBoxEstadoCita.DropDownWidth = 121
        Me.MaterialComboBoxEstadoCita.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialComboBoxEstadoCita.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialComboBoxEstadoCita.FormattingEnabled = True
        Me.MaterialComboBoxEstadoCita.Hint = "Estado de la cita"
        Me.MaterialComboBoxEstadoCita.IntegralHeight = False
        Me.MaterialComboBoxEstadoCita.ItemHeight = 43
        Me.MaterialComboBoxEstadoCita.Location = New System.Drawing.Point(1179, 575)
        Me.MaterialComboBoxEstadoCita.MaxDropDownItems = 4
        Me.MaterialComboBoxEstadoCita.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialComboBoxEstadoCita.Name = "MaterialComboBoxEstadoCita"
        Me.MaterialComboBoxEstadoCita.Size = New System.Drawing.Size(167, 49)
        Me.MaterialComboBoxEstadoCita.StartIndex = 0
        Me.MaterialComboBoxEstadoCita.TabIndex = 73
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Quicksand", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(823, 182)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(176, 31)
        Me.Label10.TabIndex = 84
        Me.Label10.Text = "Costo Total:"
        '
        'FrmMostrarInformacionCita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1365, 688)
        Me.Controls.Add(Me.MaterialComboBoxEstadoCita)
        Me.Controls.Add(Me.ButtonEditar)
        Me.Controls.Add(Me.ButtonAceptar)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Buttoncancelar)
        Me.Controls.Add(Me.ButtonGuardar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmMostrarInformacionCita"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMostrarInformacionCita"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents MaterialTextBoxApellidoPaterno As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialTextBoxApellidoMaterno As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialTextBoxSegundoNombre As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialTextBoxPrimerNombre As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents Label5 As Label
    Friend WithEvents MaterialTextBoxCasa As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialMultiLineTextBoxDescripcion As MaterialSkin.Controls.MaterialMultiLineTextBox2
    Friend WithEvents MaterialTextBoxExterno As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialTextBoxTrabajo As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialTextBoxCelular As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialTextBoxEmail As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents MaterialTextBoxNombreMascota As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialTextBoxpeso As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialCheckboxVACUNADONO As MaterialSkin.Controls.MaterialCheckbox
    Friend WithEvents MaterialCheckboxVACUNADOSI As MaterialSkin.Controls.MaterialCheckbox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents DateTimePickerFin As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DateTimePickerInicio As DateTimePicker
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents DateTimePickercitas As DateTimePicker
    Friend WithEvents MaterialComboBoxHORARIO As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents MaterialMultiLineTextBox21 As MaterialSkin.Controls.MaterialMultiLineTextBox2
    Friend WithEvents MaterialTextBoSexo As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialTextBox2RAZA As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialTextBoxTipoMascota As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents ButtonAceptar As Button
    Friend WithEvents ButtonEditar As Button
    Friend WithEvents ButtonGuardar As Button
    Friend WithEvents Buttoncancelar As Button
    Friend WithEvents MaterialComboBoxEstadoCita As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents MaterialComboBoxServicios As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents MaterialComboBoxTServicio As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents ButtonEliminar As Button
    Friend WithEvents ButtonAgregar As Button
    Friend WithEvents MaterialTextBoxCosto As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LabelCostototal As Label
    Friend WithEvents Label10 As Label
End Class
