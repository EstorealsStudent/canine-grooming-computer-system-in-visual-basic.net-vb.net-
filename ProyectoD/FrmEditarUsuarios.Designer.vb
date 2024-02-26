<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEditarUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEditarUsuarios))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LinkLabel12 = New System.Windows.Forms.LinkLabel()
        Me.ButtonAceptar = New System.Windows.Forms.Button()
        Me.ButtonCancelar = New System.Windows.Forms.Button()
        Me.LabelEditarInfo = New System.Windows.Forms.Label()
        Me.Labelmiperfil = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabelUsuario = New System.Windows.Forms.Label()
        Me.LabelPrimerNombre = New System.Windows.Forms.Label()
        Me.LabelApellido = New System.Windows.Forms.Label()
        Me.LabelEmail = New System.Windows.Forms.Label()
        Me.LabelRol = New System.Windows.Forms.Label()
        Me.LinkLabelEditar = New System.Windows.Forms.LinkLabel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MaterialTextContraseñaA = New MaterialSkin.Controls.MaterialTextBox()
        Me.MaterialTextBoxConfirmarC = New MaterialSkin.Controls.MaterialTextBox()
        Me.MaterialTextBoxprimernombre = New MaterialSkin.Controls.MaterialTextBox()
        Me.MaterialTextBoxApellido = New MaterialSkin.Controls.MaterialTextBox()
        Me.MaterialTextBoxNuevaC = New MaterialSkin.Controls.MaterialTextBox()
        Me.MaterialTextBoxEmail = New MaterialSkin.Controls.MaterialTextBox()
        Me.TextBoxUsuario = New MaterialSkin.Controls.MaterialTextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.LinkLabel12)
        Me.Panel1.Controls.Add(Me.ButtonAceptar)
        Me.Panel1.Controls.Add(Me.ButtonCancelar)
        Me.Panel1.Controls.Add(Me.MaterialTextContraseñaA)
        Me.Panel1.Controls.Add(Me.MaterialTextBoxConfirmarC)
        Me.Panel1.Controls.Add(Me.MaterialTextBoxprimernombre)
        Me.Panel1.Controls.Add(Me.MaterialTextBoxApellido)
        Me.Panel1.Controls.Add(Me.MaterialTextBoxNuevaC)
        Me.Panel1.Controls.Add(Me.MaterialTextBoxEmail)
        Me.Panel1.Controls.Add(Me.TextBoxUsuario)
        Me.Panel1.Controls.Add(Me.LabelEditarInfo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(451, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(423, 579)
        Me.Panel1.TabIndex = 0
        Me.Panel1.Visible = False
        '
        'LinkLabel12
        '
        Me.LinkLabel12.AutoSize = True
        Me.LinkLabel12.Font = New System.Drawing.Font("Quicksand", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel12.LinkColor = System.Drawing.Color.SteelBlue
        Me.LinkLabel12.Location = New System.Drawing.Point(19, 297)
        Me.LinkLabel12.Name = "LinkLabel12"
        Me.LinkLabel12.Size = New System.Drawing.Size(73, 22)
        Me.LinkLabel12.TabIndex = 14
        Me.LinkLabel12.TabStop = True
        Me.LinkLabel12.Text = "Editar "
        '
        'ButtonAceptar
        '
        Me.ButtonAceptar.BackColor = System.Drawing.Color.ForestGreen
        Me.ButtonAceptar.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.ButtonAceptar.FlatAppearance.BorderSize = 2
        Me.ButtonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAceptar.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAceptar.ForeColor = System.Drawing.Color.White
        Me.ButtonAceptar.Location = New System.Drawing.Point(258, 490)
        Me.ButtonAceptar.Margin = New System.Windows.Forms.Padding(50, 3, 50, 3)
        Me.ButtonAceptar.Name = "ButtonAceptar"
        Me.ButtonAceptar.Size = New System.Drawing.Size(104, 42)
        Me.ButtonAceptar.TabIndex = 24
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
        Me.ButtonCancelar.Location = New System.Drawing.Point(70, 490)
        Me.ButtonCancelar.Margin = New System.Windows.Forms.Padding(50, 3, 50, 3)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(104, 42)
        Me.ButtonCancelar.TabIndex = 23
        Me.ButtonCancelar.Text = "Cancelar"
        Me.ButtonCancelar.UseVisualStyleBackColor = False
        '
        'LabelEditarInfo
        '
        Me.LabelEditarInfo.AutoSize = True
        Me.LabelEditarInfo.Font = New System.Drawing.Font("Quicksand", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEditarInfo.ForeColor = System.Drawing.Color.Black
        Me.LabelEditarInfo.Location = New System.Drawing.Point(13, 21)
        Me.LabelEditarInfo.Name = "LabelEditarInfo"
        Me.LabelEditarInfo.Size = New System.Drawing.Size(417, 43)
        Me.LabelEditarInfo.TabIndex = 14
        Me.LabelEditarInfo.Text = "Editar mi información"
        '
        'Labelmiperfil
        '
        Me.Labelmiperfil.AutoSize = True
        Me.Labelmiperfil.Font = New System.Drawing.Font("Quicksand", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelmiperfil.ForeColor = System.Drawing.Color.White
        Me.Labelmiperfil.Location = New System.Drawing.Point(12, 21)
        Me.Labelmiperfil.Name = "Labelmiperfil"
        Me.Labelmiperfil.Size = New System.Drawing.Size(166, 43)
        Me.Labelmiperfil.TabIndex = 2
        Me.Labelmiperfil.Text = "Mi perfil"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Quicksand", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(16, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 34)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Usuario:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Quicksand", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(14, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(242, 34)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Primer nombre:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Quicksand", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(16, 244)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 34)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Apellido:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Quicksand", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(16, 297)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 34)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Email:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Quicksand", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(18, 350)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 34)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Rol:"
        '
        'LabelUsuario
        '
        Me.LabelUsuario.AutoSize = True
        Me.LabelUsuario.Font = New System.Drawing.Font("Quicksand", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUsuario.ForeColor = System.Drawing.Color.White
        Me.LabelUsuario.Location = New System.Drawing.Point(18, 172)
        Me.LabelUsuario.Name = "LabelUsuario"
        Me.LabelUsuario.Size = New System.Drawing.Size(133, 19)
        Me.LabelUsuario.TabIndex = 8
        Me.LabelUsuario.Text = "Primer nombre:"
        '
        'LabelPrimerNombre
        '
        Me.LabelPrimerNombre.AutoSize = True
        Me.LabelPrimerNombre.Font = New System.Drawing.Font("Quicksand", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPrimerNombre.ForeColor = System.Drawing.Color.White
        Me.LabelPrimerNombre.Location = New System.Drawing.Point(18, 225)
        Me.LabelPrimerNombre.Name = "LabelPrimerNombre"
        Me.LabelPrimerNombre.Size = New System.Drawing.Size(133, 19)
        Me.LabelPrimerNombre.TabIndex = 9
        Me.LabelPrimerNombre.Text = "Primer nombre:"
        '
        'LabelApellido
        '
        Me.LabelApellido.AutoSize = True
        Me.LabelApellido.Font = New System.Drawing.Font("Quicksand", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelApellido.ForeColor = System.Drawing.Color.White
        Me.LabelApellido.Location = New System.Drawing.Point(18, 278)
        Me.LabelApellido.Name = "LabelApellido"
        Me.LabelApellido.Size = New System.Drawing.Size(133, 19)
        Me.LabelApellido.TabIndex = 10
        Me.LabelApellido.Text = "Primer nombre:"
        '
        'LabelEmail
        '
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.Font = New System.Drawing.Font("Quicksand", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEmail.ForeColor = System.Drawing.Color.White
        Me.LabelEmail.Location = New System.Drawing.Point(18, 331)
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.Size = New System.Drawing.Size(133, 19)
        Me.LabelEmail.TabIndex = 11
        Me.LabelEmail.Text = "Primer nombre:"
        '
        'LabelRol
        '
        Me.LabelRol.AutoSize = True
        Me.LabelRol.Font = New System.Drawing.Font("Quicksand", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRol.ForeColor = System.Drawing.Color.White
        Me.LabelRol.Location = New System.Drawing.Point(18, 384)
        Me.LabelRol.Name = "LabelRol"
        Me.LabelRol.Size = New System.Drawing.Size(133, 19)
        Me.LabelRol.TabIndex = 12
        Me.LabelRol.Text = "Primer nombre:"
        '
        'LinkLabelEditar
        '
        Me.LinkLabelEditar.AutoSize = True
        Me.LinkLabelEditar.Font = New System.Drawing.Font("Quicksand", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabelEditar.LinkColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.LinkLabelEditar.Location = New System.Drawing.Point(123, 459)
        Me.LinkLabelEditar.Name = "LinkLabelEditar"
        Me.LinkLabelEditar.Size = New System.Drawing.Size(206, 37)
        Me.LinkLabelEditar.TabIndex = 13
        Me.LinkLabelEditar.TabStop = True
        Me.LinkLabelEditar.Text = "Editar perfil"
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.ProyectoD.My.Resources.Resources.edit_info
        Me.PictureBox2.Location = New System.Drawing.Point(57, 443)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(70, 70)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(209, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(120, 120)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'MaterialTextContraseñaA
        '
        Me.MaterialTextContraseñaA.AnimateReadOnly = True
        Me.MaterialTextContraseñaA.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialTextContraseñaA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MaterialTextContraseñaA.Depth = 0
        Me.MaterialTextContraseñaA.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextContraseñaA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.MaterialTextContraseñaA.Hint = "Contraseña Actual"
        Me.MaterialTextContraseñaA.LeadingIcon = CType(resources.GetObject("MaterialTextContraseñaA.LeadingIcon"), System.Drawing.Image)
        Me.MaterialTextContraseñaA.LeaveOnEnterKey = True
        Me.MaterialTextContraseñaA.Location = New System.Drawing.Point(21, 434)
        Me.MaterialTextContraseñaA.MaxLength = 50
        Me.MaterialTextContraseñaA.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextContraseñaA.Multiline = False
        Me.MaterialTextContraseñaA.Name = "MaterialTextContraseñaA"
        Me.MaterialTextContraseñaA.Size = New System.Drawing.Size(390, 50)
        Me.MaterialTextContraseñaA.TabIndex = 22
        Me.MaterialTextContraseñaA.Text = ""
        Me.MaterialTextContraseñaA.TrailingIcon = Nothing
        '
        'MaterialTextBoxConfirmarC
        '
        Me.MaterialTextBoxConfirmarC.AnimateReadOnly = True
        Me.MaterialTextBoxConfirmarC.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialTextBoxConfirmarC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MaterialTextBoxConfirmarC.Depth = 0
        Me.MaterialTextBoxConfirmarC.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBoxConfirmarC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.MaterialTextBoxConfirmarC.Hint = "Confirmar Contraseña"
        Me.MaterialTextBoxConfirmarC.LeadingIcon = CType(resources.GetObject("MaterialTextBoxConfirmarC.LeadingIcon"), System.Drawing.Image)
        Me.MaterialTextBoxConfirmarC.LeaveOnEnterKey = True
        Me.MaterialTextBoxConfirmarC.Location = New System.Drawing.Point(21, 378)
        Me.MaterialTextBoxConfirmarC.MaxLength = 50
        Me.MaterialTextBoxConfirmarC.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextBoxConfirmarC.Multiline = False
        Me.MaterialTextBoxConfirmarC.Name = "MaterialTextBoxConfirmarC"
        Me.MaterialTextBoxConfirmarC.Password = True
        Me.MaterialTextBoxConfirmarC.Size = New System.Drawing.Size(390, 50)
        Me.MaterialTextBoxConfirmarC.TabIndex = 21
        Me.MaterialTextBoxConfirmarC.Text = ""
        Me.MaterialTextBoxConfirmarC.TrailingIcon = Nothing
        '
        'MaterialTextBoxprimernombre
        '
        Me.MaterialTextBoxprimernombre.AnimateReadOnly = True
        Me.MaterialTextBoxprimernombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialTextBoxprimernombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MaterialTextBoxprimernombre.Depth = 0
        Me.MaterialTextBoxprimernombre.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBoxprimernombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.MaterialTextBoxprimernombre.Hint = "Primer Nombre"
        Me.MaterialTextBoxprimernombre.LeadingIcon = CType(resources.GetObject("MaterialTextBoxprimernombre.LeadingIcon"), System.Drawing.Image)
        Me.MaterialTextBoxprimernombre.LeaveOnEnterKey = True
        Me.MaterialTextBoxprimernombre.Location = New System.Drawing.Point(21, 134)
        Me.MaterialTextBoxprimernombre.MaxLength = 50
        Me.MaterialTextBoxprimernombre.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextBoxprimernombre.Multiline = False
        Me.MaterialTextBoxprimernombre.Name = "MaterialTextBoxprimernombre"
        Me.MaterialTextBoxprimernombre.Size = New System.Drawing.Size(390, 50)
        Me.MaterialTextBoxprimernombre.TabIndex = 20
        Me.MaterialTextBoxprimernombre.Text = ""
        Me.MaterialTextBoxprimernombre.TrailingIcon = Nothing
        '
        'MaterialTextBoxApellido
        '
        Me.MaterialTextBoxApellido.AnimateReadOnly = True
        Me.MaterialTextBoxApellido.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialTextBoxApellido.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MaterialTextBoxApellido.Depth = 0
        Me.MaterialTextBoxApellido.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBoxApellido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.MaterialTextBoxApellido.Hint = "Apellido"
        Me.MaterialTextBoxApellido.LeadingIcon = CType(resources.GetObject("MaterialTextBoxApellido.LeadingIcon"), System.Drawing.Image)
        Me.MaterialTextBoxApellido.LeaveOnEnterKey = True
        Me.MaterialTextBoxApellido.Location = New System.Drawing.Point(23, 190)
        Me.MaterialTextBoxApellido.MaxLength = 50
        Me.MaterialTextBoxApellido.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextBoxApellido.Multiline = False
        Me.MaterialTextBoxApellido.Name = "MaterialTextBoxApellido"
        Me.MaterialTextBoxApellido.Size = New System.Drawing.Size(390, 50)
        Me.MaterialTextBoxApellido.TabIndex = 19
        Me.MaterialTextBoxApellido.Text = ""
        Me.MaterialTextBoxApellido.TrailingIcon = Nothing
        '
        'MaterialTextBoxNuevaC
        '
        Me.MaterialTextBoxNuevaC.AnimateReadOnly = True
        Me.MaterialTextBoxNuevaC.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialTextBoxNuevaC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MaterialTextBoxNuevaC.Depth = 0
        Me.MaterialTextBoxNuevaC.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBoxNuevaC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.MaterialTextBoxNuevaC.Hint = "Nueva Contraseña"
        Me.MaterialTextBoxNuevaC.LeadingIcon = CType(resources.GetObject("MaterialTextBoxNuevaC.LeadingIcon"), System.Drawing.Image)
        Me.MaterialTextBoxNuevaC.LeaveOnEnterKey = True
        Me.MaterialTextBoxNuevaC.Location = New System.Drawing.Point(21, 322)
        Me.MaterialTextBoxNuevaC.MaxLength = 50
        Me.MaterialTextBoxNuevaC.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextBoxNuevaC.Multiline = False
        Me.MaterialTextBoxNuevaC.Name = "MaterialTextBoxNuevaC"
        Me.MaterialTextBoxNuevaC.Password = True
        Me.MaterialTextBoxNuevaC.Size = New System.Drawing.Size(390, 50)
        Me.MaterialTextBoxNuevaC.TabIndex = 18
        Me.MaterialTextBoxNuevaC.Text = ""
        Me.MaterialTextBoxNuevaC.TrailingIcon = Nothing
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
        Me.MaterialTextBoxEmail.Location = New System.Drawing.Point(23, 246)
        Me.MaterialTextBoxEmail.MaxLength = 50
        Me.MaterialTextBoxEmail.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextBoxEmail.Multiline = False
        Me.MaterialTextBoxEmail.Name = "MaterialTextBoxEmail"
        Me.MaterialTextBoxEmail.Size = New System.Drawing.Size(390, 50)
        Me.MaterialTextBoxEmail.TabIndex = 17
        Me.MaterialTextBoxEmail.Text = ""
        Me.MaterialTextBoxEmail.TrailingIcon = Nothing
        '
        'TextBoxUsuario
        '
        Me.TextBoxUsuario.AnimateReadOnly = True
        Me.TextBoxUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBoxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxUsuario.Depth = 0
        Me.TextBoxUsuario.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TextBoxUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.TextBoxUsuario.Hint = "Usuario"
        Me.TextBoxUsuario.LeadingIcon = CType(resources.GetObject("TextBoxUsuario.LeadingIcon"), System.Drawing.Image)
        Me.TextBoxUsuario.LeaveOnEnterKey = True
        Me.TextBoxUsuario.Location = New System.Drawing.Point(23, 78)
        Me.TextBoxUsuario.MaxLength = 50
        Me.TextBoxUsuario.MouseState = MaterialSkin.MouseState.OUT
        Me.TextBoxUsuario.Multiline = False
        Me.TextBoxUsuario.Name = "TextBoxUsuario"
        Me.TextBoxUsuario.Size = New System.Drawing.Size(390, 50)
        Me.TextBoxUsuario.TabIndex = 16
        Me.TextBoxUsuario.Text = ""
        Me.TextBoxUsuario.TrailingIcon = Nothing
        '
        'FrmEditarUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(874, 579)
        Me.Controls.Add(Me.LinkLabelEditar)
        Me.Controls.Add(Me.LabelRol)
        Me.Controls.Add(Me.LabelEmail)
        Me.Controls.Add(Me.LabelApellido)
        Me.Controls.Add(Me.LabelPrimerNombre)
        Me.Controls.Add(Me.LabelUsuario)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Labelmiperfil)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "FrmEditarUsuarios"
        Me.Text = "FrmEditarUsuarios"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Labelmiperfil As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LabelUsuario As Label
    Friend WithEvents LabelPrimerNombre As Label
    Friend WithEvents LabelApellido As Label
    Friend WithEvents LabelEmail As Label
    Friend WithEvents LabelRol As Label
    Friend WithEvents LinkLabelEditar As LinkLabel
    Friend WithEvents LabelEditarInfo As Label
    Friend WithEvents TextBoxUsuario As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialTextContraseñaA As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialTextBoxConfirmarC As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialTextBoxprimernombre As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialTextBoxApellido As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialTextBoxNuevaC As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialTextBoxEmail As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents ButtonAceptar As Button
    Friend WithEvents ButtonCancelar As Button
    Friend WithEvents LinkLabel12 As LinkLabel
    Friend WithEvents PictureBox2 As PictureBox
End Class
