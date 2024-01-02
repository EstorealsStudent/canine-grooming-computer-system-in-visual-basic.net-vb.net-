<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRecuperarContraseña
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRecuperarContraseña))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelResultado = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextboxMail = New MaterialSkin.Controls.MaterialTextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MaterialCheckbox1 = New MaterialSkin.Controls.MaterialCheckbox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Quicksand", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(338, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Introduce tu Email O Nombre de usuario."
        '
        'LabelResultado
        '
        Me.LabelResultado.AutoSize = True
        Me.LabelResultado.Font = New System.Drawing.Font("Quicksand", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelResultado.Location = New System.Drawing.Point(12, 221)
        Me.LabelResultado.Name = "LabelResultado"
        Me.LabelResultado.Size = New System.Drawing.Size(21, 19)
        Me.LabelResultado.TabIndex = 3
        Me.LabelResultado.Text = "..."
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(376, 56)
        Me.Panel1.TabIndex = 4
        '
        'TextboxMail
        '
        Me.TextboxMail.AnimateReadOnly = True
        Me.TextboxMail.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.TextboxMail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextboxMail.Depth = 0
        Me.TextboxMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TextboxMail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.TextboxMail.Hint = "Usuario o Correo"
        Me.TextboxMail.LeadingIcon = CType(resources.GetObject("TextboxMail.LeadingIcon"), System.Drawing.Image)
        Me.TextboxMail.LeaveOnEnterKey = True
        Me.TextboxMail.Location = New System.Drawing.Point(17, 83)
        Me.TextboxMail.MaxLength = 50
        Me.TextboxMail.MouseState = MaterialSkin.MouseState.OUT
        Me.TextboxMail.Multiline = False
        Me.TextboxMail.Name = "TextboxMail"
        Me.TextboxMail.Size = New System.Drawing.Size(347, 50)
        Me.TextboxMail.TabIndex = 5
        Me.TextboxMail.Text = ""
        Me.TextboxMail.TrailingIcon = Nothing
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.ForestGreen
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.Button2.FlatAppearance.BorderSize = 2
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(247, 157)
        Me.Button2.Margin = New System.Windows.Forms.Padding(50, 3, 50, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 42)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Enviar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkGray
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(43, 157)
        Me.Button1.Margin = New System.Windows.Forms.Padding(50, 3, 50, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 42)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'MaterialCheckbox1
        '
        Me.MaterialCheckbox1.AutoSize = True
        Me.MaterialCheckbox1.Depth = 0
        Me.MaterialCheckbox1.Location = New System.Drawing.Point(368, 285)
        Me.MaterialCheckbox1.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialCheckbox1.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCheckbox1.Name = "MaterialCheckbox1"
        Me.MaterialCheckbox1.ReadOnly = False
        Me.MaterialCheckbox1.Ripple = True
        Me.MaterialCheckbox1.Size = New System.Drawing.Size(171, 37)
        Me.MaterialCheckbox1.TabIndex = 8
        Me.MaterialCheckbox1.Text = "MaterialCheckbox1"
        Me.MaterialCheckbox1.UseVisualStyleBackColor = True
        '
        'FrmRecuperarContraseña
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 310)
        Me.Controls.Add(Me.MaterialCheckbox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextboxMail)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LabelResultado)
        Me.Name = "FrmRecuperarContraseña"
        Me.Text = "FrmRecuperarContraseña"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelResultado As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextboxMail As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents MaterialCheckbox1 As MaterialSkin.Controls.MaterialCheckbox
End Class
