<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLog

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLog))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelRecuperarContraseña = New System.Windows.Forms.Label()
        Me.TextboxContraseña = New MaterialSkin.Controls.MaterialTextBox()
        Me.TextBoxUsuario = New MaterialSkin.Controls.MaterialTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(964, 317)
        Me.Button1.Margin = New System.Windows.Forms.Padding(50, 3, 50, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 42)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 2
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(794, 317)
        Me.Button2.Margin = New System.Windows.Forms.Padding(50, 3, 50, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 42)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Quicksand", 47.99999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(749, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(381, 75)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Bienvenido"
        '
        'LabelRecuperarContraseña
        '
        Me.LabelRecuperarContraseña.AutoSize = True
        Me.LabelRecuperarContraseña.BackColor = System.Drawing.Color.Transparent
        Me.LabelRecuperarContraseña.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRecuperarContraseña.ForeColor = System.Drawing.Color.Black
        Me.LabelRecuperarContraseña.Location = New System.Drawing.Point(816, 428)
        Me.LabelRecuperarContraseña.Name = "LabelRecuperarContraseña"
        Me.LabelRecuperarContraseña.Size = New System.Drawing.Size(246, 24)
        Me.LabelRecuperarContraseña.TabIndex = 5
        Me.LabelRecuperarContraseña.Text = "¿Olvidaste tu contraseña?"
        '
        'TextboxContraseña
        '
        Me.TextboxContraseña.AnimateReadOnly = True
        Me.TextboxContraseña.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.TextboxContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextboxContraseña.Depth = 0
        Me.TextboxContraseña.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TextboxContraseña.ForeColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.TextboxContraseña.Hint = "Contraseña"
        Me.TextboxContraseña.LeadingIcon = CType(resources.GetObject("TextboxContraseña.LeadingIcon"), System.Drawing.Image)
        Me.TextboxContraseña.LeaveOnEnterKey = True
        Me.TextboxContraseña.Location = New System.Drawing.Point(794, 217)
        Me.TextboxContraseña.MaxLength = 50
        Me.TextboxContraseña.MouseState = MaterialSkin.MouseState.OUT
        Me.TextboxContraseña.Multiline = False
        Me.TextboxContraseña.Name = "TextboxContraseña"
        Me.TextboxContraseña.Password = True
        Me.TextboxContraseña.Size = New System.Drawing.Size(274, 50)
        Me.TextboxContraseña.TabIndex = 2
        Me.TextboxContraseña.Text = ""
        Me.TextboxContraseña.TrailingIcon = Nothing
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
        Me.TextBoxUsuario.Location = New System.Drawing.Point(794, 133)
        Me.TextBoxUsuario.MaxLength = 50
        Me.TextBoxUsuario.MouseState = MaterialSkin.MouseState.OUT
        Me.TextBoxUsuario.Multiline = False
        Me.TextBoxUsuario.Name = "TextBoxUsuario"
        Me.TextBoxUsuario.Size = New System.Drawing.Size(274, 50)
        Me.TextBoxUsuario.TabIndex = 1
        Me.TextBoxUsuario.Text = ""
        Me.TextBoxUsuario.TrailingIcon = Nothing
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(665, 461)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(192, 72)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(300, 195)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Quicksand", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(210, 325)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(256, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Alta Estética Canina"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Quicksand", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(183, 273)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(307, 56)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PET PALACE"
        '
        'FrmLog
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1206, 461)
        Me.Controls.Add(Me.LabelRecuperarContraseña)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextboxContraseña)
        Me.Controls.Add(Me.TextBoxUsuario)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Quicksand", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmLog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBoxUsuario As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents TextboxContraseña As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelRecuperarContraseña As Label
End Class
