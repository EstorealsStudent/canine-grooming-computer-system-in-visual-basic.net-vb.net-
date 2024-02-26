<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistrarte
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRegistrarte))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MaterialTextBoxContraseña = New MaterialSkin.Controls.MaterialTextBox()
        Me.MaterialTextBoxEmail = New MaterialSkin.Controls.MaterialTextBox()
        Me.MaterialTextBoxPrimerNombre = New MaterialSkin.Controls.MaterialTextBox()
        Me.MaterialTextBoxApellidoPaterno = New MaterialSkin.Controls.MaterialTextBox()
        Me.MaterialTextBoxConfirmarContraseña = New MaterialSkin.Controls.MaterialTextBox()
        Me.MaterialTextBoxUsuario = New MaterialSkin.Controls.MaterialTextBox()
        Me.MaterialTextBoxSegundoNombre = New MaterialSkin.Controls.MaterialTextBox()
        Me.MaterialTextBoxApellidoMaterno = New MaterialSkin.Controls.MaterialTextBox()
        Me.MaterialComboBoxRol = New MaterialSkin.Controls.MaterialComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Quicksand", 47.99999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Indigo
        Me.Label1.Location = New System.Drawing.Point(17, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(594, 75)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Registra Usuarios"
        '
        'MaterialTextBoxContraseña
        '
        Me.MaterialTextBoxContraseña.AnimateReadOnly = True
        Me.MaterialTextBoxContraseña.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.MaterialTextBoxContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MaterialTextBoxContraseña.Depth = 0
        Me.MaterialTextBoxContraseña.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBoxContraseña.ForeColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.MaterialTextBoxContraseña.Hint = "Contraseña"
        Me.MaterialTextBoxContraseña.LeadingIcon = CType(resources.GetObject("MaterialTextBoxContraseña.LeadingIcon"), System.Drawing.Image)
        Me.MaterialTextBoxContraseña.LeaveOnEnterKey = True
        Me.MaterialTextBoxContraseña.Location = New System.Drawing.Point(396, 240)
        Me.MaterialTextBoxContraseña.MaxLength = 50
        Me.MaterialTextBoxContraseña.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextBoxContraseña.Multiline = False
        Me.MaterialTextBoxContraseña.Name = "MaterialTextBoxContraseña"
        Me.MaterialTextBoxContraseña.Password = True
        Me.MaterialTextBoxContraseña.Size = New System.Drawing.Size(280, 50)
        Me.MaterialTextBoxContraseña.TabIndex = 13
        Me.MaterialTextBoxContraseña.Text = ""
        Me.MaterialTextBoxContraseña.TrailingIcon = Nothing
        '
        'MaterialTextBoxEmail
        '
        Me.MaterialTextBoxEmail.AnimateReadOnly = True
        Me.MaterialTextBoxEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialTextBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MaterialTextBoxEmail.Depth = 0
        Me.MaterialTextBoxEmail.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBoxEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.MaterialTextBoxEmail.Hint = "Email"
        Me.MaterialTextBoxEmail.LeadingIcon = CType(resources.GetObject("MaterialTextBoxEmail.LeadingIcon"), System.Drawing.Image)
        Me.MaterialTextBoxEmail.LeaveOnEnterKey = True
        Me.MaterialTextBoxEmail.Location = New System.Drawing.Point(396, 126)
        Me.MaterialTextBoxEmail.MaxLength = 50
        Me.MaterialTextBoxEmail.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextBoxEmail.Multiline = False
        Me.MaterialTextBoxEmail.Name = "MaterialTextBoxEmail"
        Me.MaterialTextBoxEmail.Size = New System.Drawing.Size(280, 50)
        Me.MaterialTextBoxEmail.TabIndex = 12
        Me.MaterialTextBoxEmail.Text = ""
        Me.MaterialTextBoxEmail.TrailingIcon = Nothing
        '
        'MaterialTextBoxPrimerNombre
        '
        Me.MaterialTextBoxPrimerNombre.AnimateReadOnly = True
        Me.MaterialTextBoxPrimerNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialTextBoxPrimerNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MaterialTextBoxPrimerNombre.Depth = 0
        Me.MaterialTextBoxPrimerNombre.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBoxPrimerNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.MaterialTextBoxPrimerNombre.Hint = "Primer Nombre*"
        Me.MaterialTextBoxPrimerNombre.LeadingIcon = CType(resources.GetObject("MaterialTextBoxPrimerNombre.LeadingIcon"), System.Drawing.Image)
        Me.MaterialTextBoxPrimerNombre.LeaveOnEnterKey = True
        Me.MaterialTextBoxPrimerNombre.Location = New System.Drawing.Point(25, 128)
        Me.MaterialTextBoxPrimerNombre.MaxLength = 50
        Me.MaterialTextBoxPrimerNombre.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextBoxPrimerNombre.Multiline = False
        Me.MaterialTextBoxPrimerNombre.Name = "MaterialTextBoxPrimerNombre"
        Me.MaterialTextBoxPrimerNombre.Size = New System.Drawing.Size(280, 50)
        Me.MaterialTextBoxPrimerNombre.TabIndex = 14
        Me.MaterialTextBoxPrimerNombre.Text = ""
        Me.MaterialTextBoxPrimerNombre.TrailingIcon = Nothing
        '
        'MaterialTextBoxApellidoPaterno
        '
        Me.MaterialTextBoxApellidoPaterno.AnimateReadOnly = True
        Me.MaterialTextBoxApellidoPaterno.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialTextBoxApellidoPaterno.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MaterialTextBoxApellidoPaterno.Depth = 0
        Me.MaterialTextBoxApellidoPaterno.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBoxApellidoPaterno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.MaterialTextBoxApellidoPaterno.Hint = "Apellido Paterno*"
        Me.MaterialTextBoxApellidoPaterno.LeadingIcon = CType(resources.GetObject("MaterialTextBoxApellidoPaterno.LeadingIcon"), System.Drawing.Image)
        Me.MaterialTextBoxApellidoPaterno.LeaveOnEnterKey = True
        Me.MaterialTextBoxApellidoPaterno.Location = New System.Drawing.Point(25, 240)
        Me.MaterialTextBoxApellidoPaterno.MaxLength = 50
        Me.MaterialTextBoxApellidoPaterno.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextBoxApellidoPaterno.Multiline = False
        Me.MaterialTextBoxApellidoPaterno.Name = "MaterialTextBoxApellidoPaterno"
        Me.MaterialTextBoxApellidoPaterno.Size = New System.Drawing.Size(280, 50)
        Me.MaterialTextBoxApellidoPaterno.TabIndex = 16
        Me.MaterialTextBoxApellidoPaterno.Text = ""
        Me.MaterialTextBoxApellidoPaterno.TrailingIcon = Nothing
        '
        'MaterialTextBoxConfirmarContraseña
        '
        Me.MaterialTextBoxConfirmarContraseña.AnimateReadOnly = True
        Me.MaterialTextBoxConfirmarContraseña.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.MaterialTextBoxConfirmarContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MaterialTextBoxConfirmarContraseña.Depth = 0
        Me.MaterialTextBoxConfirmarContraseña.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBoxConfirmarContraseña.ForeColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.MaterialTextBoxConfirmarContraseña.Hint = "Confirmar Contraseña"
        Me.MaterialTextBoxConfirmarContraseña.LeadingIcon = CType(resources.GetObject("MaterialTextBoxConfirmarContraseña.LeadingIcon"), System.Drawing.Image)
        Me.MaterialTextBoxConfirmarContraseña.LeaveOnEnterKey = True
        Me.MaterialTextBoxConfirmarContraseña.Location = New System.Drawing.Point(396, 296)
        Me.MaterialTextBoxConfirmarContraseña.MaxLength = 50
        Me.MaterialTextBoxConfirmarContraseña.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextBoxConfirmarContraseña.Multiline = False
        Me.MaterialTextBoxConfirmarContraseña.Name = "MaterialTextBoxConfirmarContraseña"
        Me.MaterialTextBoxConfirmarContraseña.Password = True
        Me.MaterialTextBoxConfirmarContraseña.Size = New System.Drawing.Size(280, 50)
        Me.MaterialTextBoxConfirmarContraseña.TabIndex = 19
        Me.MaterialTextBoxConfirmarContraseña.Text = ""
        Me.MaterialTextBoxConfirmarContraseña.TrailingIcon = Nothing
        '
        'MaterialTextBoxUsuario
        '
        Me.MaterialTextBoxUsuario.AnimateReadOnly = True
        Me.MaterialTextBoxUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialTextBoxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MaterialTextBoxUsuario.Depth = 0
        Me.MaterialTextBoxUsuario.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBoxUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.MaterialTextBoxUsuario.Hint = "Usuario"
        Me.MaterialTextBoxUsuario.LeadingIcon = CType(resources.GetObject("MaterialTextBoxUsuario.LeadingIcon"), System.Drawing.Image)
        Me.MaterialTextBoxUsuario.LeaveOnEnterKey = True
        Me.MaterialTextBoxUsuario.Location = New System.Drawing.Point(396, 184)
        Me.MaterialTextBoxUsuario.MaxLength = 50
        Me.MaterialTextBoxUsuario.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextBoxUsuario.Multiline = False
        Me.MaterialTextBoxUsuario.Name = "MaterialTextBoxUsuario"
        Me.MaterialTextBoxUsuario.Size = New System.Drawing.Size(280, 50)
        Me.MaterialTextBoxUsuario.TabIndex = 18
        Me.MaterialTextBoxUsuario.Text = ""
        Me.MaterialTextBoxUsuario.TrailingIcon = Nothing
        '
        'MaterialTextBoxSegundoNombre
        '
        Me.MaterialTextBoxSegundoNombre.AnimateReadOnly = True
        Me.MaterialTextBoxSegundoNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialTextBoxSegundoNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MaterialTextBoxSegundoNombre.Depth = 0
        Me.MaterialTextBoxSegundoNombre.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBoxSegundoNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.MaterialTextBoxSegundoNombre.Hint = "Segundo Nombre"
        Me.MaterialTextBoxSegundoNombre.LeadingIcon = CType(resources.GetObject("MaterialTextBoxSegundoNombre.LeadingIcon"), System.Drawing.Image)
        Me.MaterialTextBoxSegundoNombre.LeaveOnEnterKey = True
        Me.MaterialTextBoxSegundoNombre.Location = New System.Drawing.Point(25, 184)
        Me.MaterialTextBoxSegundoNombre.MaxLength = 50
        Me.MaterialTextBoxSegundoNombre.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextBoxSegundoNombre.Multiline = False
        Me.MaterialTextBoxSegundoNombre.Name = "MaterialTextBoxSegundoNombre"
        Me.MaterialTextBoxSegundoNombre.Size = New System.Drawing.Size(280, 50)
        Me.MaterialTextBoxSegundoNombre.TabIndex = 22
        Me.MaterialTextBoxSegundoNombre.Text = ""
        Me.MaterialTextBoxSegundoNombre.TrailingIcon = Nothing
        '
        'MaterialTextBoxApellidoMaterno
        '
        Me.MaterialTextBoxApellidoMaterno.AnimateReadOnly = True
        Me.MaterialTextBoxApellidoMaterno.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialTextBoxApellidoMaterno.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MaterialTextBoxApellidoMaterno.Depth = 0
        Me.MaterialTextBoxApellidoMaterno.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBoxApellidoMaterno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.MaterialTextBoxApellidoMaterno.Hint = "Apellido Materno"
        Me.MaterialTextBoxApellidoMaterno.LeadingIcon = CType(resources.GetObject("MaterialTextBoxApellidoMaterno.LeadingIcon"), System.Drawing.Image)
        Me.MaterialTextBoxApellidoMaterno.LeaveOnEnterKey = True
        Me.MaterialTextBoxApellidoMaterno.Location = New System.Drawing.Point(25, 296)
        Me.MaterialTextBoxApellidoMaterno.MaxLength = 50
        Me.MaterialTextBoxApellidoMaterno.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextBoxApellidoMaterno.Multiline = False
        Me.MaterialTextBoxApellidoMaterno.Name = "MaterialTextBoxApellidoMaterno"
        Me.MaterialTextBoxApellidoMaterno.Size = New System.Drawing.Size(280, 50)
        Me.MaterialTextBoxApellidoMaterno.TabIndex = 23
        Me.MaterialTextBoxApellidoMaterno.Text = ""
        Me.MaterialTextBoxApellidoMaterno.TrailingIcon = Nothing
        '
        'MaterialComboBoxRol
        '
        Me.MaterialComboBoxRol.AutoResize = False
        Me.MaterialComboBoxRol.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialComboBoxRol.Depth = 0
        Me.MaterialComboBoxRol.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.MaterialComboBoxRol.DropDownHeight = 174
        Me.MaterialComboBoxRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MaterialComboBoxRol.DropDownWidth = 121
        Me.MaterialComboBoxRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialComboBoxRol.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialComboBoxRol.FormattingEnabled = True
        Me.MaterialComboBoxRol.Hint = "Rol"
        Me.MaterialComboBoxRol.IntegralHeight = False
        Me.MaterialComboBoxRol.ItemHeight = 43
        Me.MaterialComboBoxRol.Location = New System.Drawing.Point(29, 398)
        Me.MaterialComboBoxRol.MaxDropDownItems = 4
        Me.MaterialComboBoxRol.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialComboBoxRol.Name = "MaterialComboBoxRol"
        Me.MaterialComboBoxRol.Size = New System.Drawing.Size(243, 49)
        Me.MaterialComboBoxRol.StartIndex = 0
        Me.MaterialComboBoxRol.TabIndex = 73
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkGray
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(432, 405)
        Me.Button1.Margin = New System.Windows.Forms.Padding(50, 3, 50, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 42)
        Me.Button1.TabIndex = 75
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.ForestGreen
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.Button2.FlatAppearance.BorderSize = 2
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(571, 405)
        Me.Button2.Margin = New System.Windows.Forms.Padding(50, 3, 50, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 42)
        Me.Button2.TabIndex = 74
        Me.Button2.Text = "Enviar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'FrmRegistrarte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(746, 474)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.MaterialComboBoxRol)
        Me.Controls.Add(Me.MaterialTextBoxApellidoMaterno)
        Me.Controls.Add(Me.MaterialTextBoxSegundoNombre)
        Me.Controls.Add(Me.MaterialTextBoxConfirmarContraseña)
        Me.Controls.Add(Me.MaterialTextBoxUsuario)
        Me.Controls.Add(Me.MaterialTextBoxApellidoPaterno)
        Me.Controls.Add(Me.MaterialTextBoxPrimerNombre)
        Me.Controls.Add(Me.MaterialTextBoxContraseña)
        Me.Controls.Add(Me.MaterialTextBoxEmail)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmRegistrarte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmRegistrarte"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MaterialTextBoxContraseña As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialTextBoxEmail As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialTextBoxPrimerNombre As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialTextBoxApellidoPaterno As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialTextBoxConfirmarContraseña As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialTextBoxUsuario As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialTextBoxSegundoNombre As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialTextBoxApellidoMaterno As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialComboBoxRol As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
