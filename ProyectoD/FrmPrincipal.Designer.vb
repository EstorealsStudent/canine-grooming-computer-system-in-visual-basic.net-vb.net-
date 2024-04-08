<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pantalla_Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pantalla_Principal))
        Me.PanelIzquierdo = New System.Windows.Forms.Panel()
        Me.IconButtonperfil = New FontAwesome.Sharp.IconButton()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.IconButtonCitas = New FontAwesome.Sharp.IconButton()
        Me.IconButtonServicios = New FontAwesome.Sharp.IconButton()
        Me.IconButtonClientes = New FontAwesome.Sharp.IconButton()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.PictureBoxImagen = New System.Windows.Forms.PictureBox()
        Me.IconButtonCerrarSesion = New FontAwesome.Sharp.IconButton()
        Me.PanelTitulo = New System.Windows.Forms.Panel()
        Me.LabelTitulos = New System.Windows.Forms.Label()
        Me.IconPictureBoxICONOS = New FontAwesome.Sharp.IconPictureBox()
        Me.PanelEscritorios = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelIzquierdo.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.PictureBoxImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTitulo.SuspendLayout()
        CType(Me.IconPictureBoxICONOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEscritorios.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelIzquierdo
        '
        Me.PanelIzquierdo.AutoScroll = True
        Me.PanelIzquierdo.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.PanelIzquierdo.Controls.Add(Me.IconButtonperfil)
        Me.PanelIzquierdo.Controls.Add(Me.IconButton2)
        Me.PanelIzquierdo.Controls.Add(Me.LinkLabel1)
        Me.PanelIzquierdo.Controls.Add(Me.IconButton3)
        Me.PanelIzquierdo.Controls.Add(Me.IconButtonCitas)
        Me.PanelIzquierdo.Controls.Add(Me.IconButtonServicios)
        Me.PanelIzquierdo.Controls.Add(Me.IconButtonClientes)
        Me.PanelIzquierdo.Controls.Add(Me.PanelLogo)
        Me.PanelIzquierdo.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelIzquierdo.Location = New System.Drawing.Point(0, 0)
        Me.PanelIzquierdo.Name = "PanelIzquierdo"
        Me.PanelIzquierdo.Size = New System.Drawing.Size(285, 681)
        Me.PanelIzquierdo.TabIndex = 0
        '
        'IconButtonperfil
        '
        Me.IconButtonperfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.IconButtonperfil.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButtonperfil.FlatAppearance.BorderSize = 0
        Me.IconButtonperfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButtonperfil.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButtonperfil.ForeColor = System.Drawing.Color.White
        Me.IconButtonperfil.IconChar = FontAwesome.Sharp.IconChar.Play
        Me.IconButtonperfil.IconColor = System.Drawing.Color.White
        Me.IconButtonperfil.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonperfil.IconSize = 50
        Me.IconButtonperfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonperfil.Location = New System.Drawing.Point(0, 425)
        Me.IconButtonperfil.Name = "IconButtonperfil"
        Me.IconButtonperfil.Padding = New System.Windows.Forms.Padding(10, 0, 30, 0)
        Me.IconButtonperfil.Size = New System.Drawing.Size(285, 65)
        Me.IconButtonperfil.TabIndex = 10
        Me.IconButtonperfil.Text = "Perfil" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.IconButtonperfil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonperfil.UseVisualStyleBackColor = True
        '
        'IconButton2
        '
        Me.IconButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.IconButton2.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton2.FlatAppearance.BorderSize = 0
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton2.ForeColor = System.Drawing.Color.White
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.Gear
        Me.IconButton2.IconColor = System.Drawing.Color.White
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.IconSize = 50
        Me.IconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton2.Location = New System.Drawing.Point(0, 360)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Padding = New System.Windows.Forms.Padding(10, 0, 30, 0)
        Me.IconButton2.Size = New System.Drawing.Size(285, 65)
        Me.IconButton2.TabIndex = 10
        Me.IconButton2.Text = "Administrador"
        Me.IconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton2.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(191, 640)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(0, 13)
        Me.LinkLabel1.TabIndex = 8
        '
        'IconButton3
        '
        Me.IconButton3.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton3.FlatAppearance.BorderSize = 0
        Me.IconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton3.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton3.ForeColor = System.Drawing.Color.White
        Me.IconButton3.IconChar = FontAwesome.Sharp.IconChar.Dog
        Me.IconButton3.IconColor = System.Drawing.Color.White
        Me.IconButton3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton3.IconSize = 50
        Me.IconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton3.Location = New System.Drawing.Point(0, 295)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Padding = New System.Windows.Forms.Padding(10, 0, 30, 0)
        Me.IconButton3.Size = New System.Drawing.Size(285, 65)
        Me.IconButton3.TabIndex = 5
        Me.IconButton3.Text = "Mascotas"
        Me.IconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton3.UseVisualStyleBackColor = True
        '
        'IconButtonCitas
        '
        Me.IconButtonCitas.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButtonCitas.FlatAppearance.BorderSize = 0
        Me.IconButtonCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButtonCitas.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButtonCitas.ForeColor = System.Drawing.Color.White
        Me.IconButtonCitas.IconChar = FontAwesome.Sharp.IconChar.CalendarDay
        Me.IconButtonCitas.IconColor = System.Drawing.Color.White
        Me.IconButtonCitas.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonCitas.IconSize = 50
        Me.IconButtonCitas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonCitas.Location = New System.Drawing.Point(0, 230)
        Me.IconButtonCitas.Name = "IconButtonCitas"
        Me.IconButtonCitas.Padding = New System.Windows.Forms.Padding(10, 0, 30, 0)
        Me.IconButtonCitas.Size = New System.Drawing.Size(285, 65)
        Me.IconButtonCitas.TabIndex = 4
        Me.IconButtonCitas.Text = "Citas"
        Me.IconButtonCitas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonCitas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonCitas.UseVisualStyleBackColor = True
        '
        'IconButtonServicios
        '
        Me.IconButtonServicios.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButtonServicios.FlatAppearance.BorderSize = 0
        Me.IconButtonServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButtonServicios.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButtonServicios.ForeColor = System.Drawing.Color.White
        Me.IconButtonServicios.IconChar = FontAwesome.Sharp.IconChar.Scissors
        Me.IconButtonServicios.IconColor = System.Drawing.Color.White
        Me.IconButtonServicios.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonServicios.IconSize = 50
        Me.IconButtonServicios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonServicios.Location = New System.Drawing.Point(0, 165)
        Me.IconButtonServicios.Name = "IconButtonServicios"
        Me.IconButtonServicios.Padding = New System.Windows.Forms.Padding(10, 0, 30, 0)
        Me.IconButtonServicios.Size = New System.Drawing.Size(285, 65)
        Me.IconButtonServicios.TabIndex = 3
        Me.IconButtonServicios.Text = "Servicios"
        Me.IconButtonServicios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonServicios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonServicios.UseVisualStyleBackColor = True
        '
        'IconButtonClientes
        '
        Me.IconButtonClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButtonClientes.FlatAppearance.BorderSize = 0
        Me.IconButtonClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButtonClientes.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButtonClientes.ForeColor = System.Drawing.Color.White
        Me.IconButtonClientes.IconChar = FontAwesome.Sharp.IconChar.Person
        Me.IconButtonClientes.IconColor = System.Drawing.Color.White
        Me.IconButtonClientes.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonClientes.IconSize = 50
        Me.IconButtonClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonClientes.Location = New System.Drawing.Point(0, 100)
        Me.IconButtonClientes.Name = "IconButtonClientes"
        Me.IconButtonClientes.Padding = New System.Windows.Forms.Padding(10, 0, 30, 0)
        Me.IconButtonClientes.Size = New System.Drawing.Size(285, 65)
        Me.IconButtonClientes.TabIndex = 2
        Me.IconButtonClientes.Text = "Clientes"
        Me.IconButtonClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonClientes.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.PictureBoxImagen)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(285, 100)
        Me.PanelLogo.TabIndex = 1
        '
        'PictureBoxImagen
        '
        Me.PictureBoxImagen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBoxImagen.Image = CType(resources.GetObject("PictureBoxImagen.Image"), System.Drawing.Image)
        Me.PictureBoxImagen.Location = New System.Drawing.Point(0, 0)
        Me.PictureBoxImagen.Name = "PictureBoxImagen"
        Me.PictureBoxImagen.Size = New System.Drawing.Size(285, 100)
        Me.PictureBoxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxImagen.TabIndex = 1
        Me.PictureBoxImagen.TabStop = False
        '
        'IconButtonCerrarSesion
        '
        Me.IconButtonCerrarSesion.Dock = System.Windows.Forms.DockStyle.Right
        Me.IconButtonCerrarSesion.FlatAppearance.BorderSize = 0
        Me.IconButtonCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButtonCerrarSesion.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButtonCerrarSesion.ForeColor = System.Drawing.Color.White
        Me.IconButtonCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket
        Me.IconButtonCerrarSesion.IconColor = System.Drawing.Color.White
        Me.IconButtonCerrarSesion.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonCerrarSesion.IconSize = 50
        Me.IconButtonCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonCerrarSesion.Location = New System.Drawing.Point(596, 0)
        Me.IconButtonCerrarSesion.Name = "IconButtonCerrarSesion"
        Me.IconButtonCerrarSesion.Padding = New System.Windows.Forms.Padding(10, 0, 30, 0)
        Me.IconButtonCerrarSesion.Size = New System.Drawing.Size(183, 74)
        Me.IconButtonCerrarSesion.TabIndex = 7
        Me.IconButtonCerrarSesion.Text = "Cerrar Sesión"
        Me.IconButtonCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonCerrarSesion.UseVisualStyleBackColor = True
        '
        'PanelTitulo
        '
        Me.PanelTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.PanelTitulo.Controls.Add(Me.IconButtonCerrarSesion)
        Me.PanelTitulo.Controls.Add(Me.LabelTitulos)
        Me.PanelTitulo.Controls.Add(Me.IconPictureBoxICONOS)
        Me.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitulo.Location = New System.Drawing.Point(285, 0)
        Me.PanelTitulo.Name = "PanelTitulo"
        Me.PanelTitulo.Size = New System.Drawing.Size(779, 74)
        Me.PanelTitulo.TabIndex = 1
        '
        'LabelTitulos
        '
        Me.LabelTitulos.AutoSize = True
        Me.LabelTitulos.Font = New System.Drawing.Font("Quicksand", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitulos.ForeColor = System.Drawing.Color.White
        Me.LabelTitulos.Location = New System.Drawing.Point(58, 28)
        Me.LabelTitulos.Name = "LabelTitulos"
        Me.LabelTitulos.Size = New System.Drawing.Size(66, 24)
        Me.LabelTitulos.TabIndex = 1
        Me.LabelTitulos.Text = "Inicio"
        '
        'IconPictureBoxICONOS
        '
        Me.IconPictureBoxICONOS.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.IconPictureBoxICONOS.IconChar = FontAwesome.Sharp.IconChar.HomeLg
        Me.IconPictureBoxICONOS.IconColor = System.Drawing.Color.White
        Me.IconPictureBoxICONOS.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBoxICONOS.IconSize = 52
        Me.IconPictureBoxICONOS.Location = New System.Drawing.Point(3, 12)
        Me.IconPictureBoxICONOS.Name = "IconPictureBoxICONOS"
        Me.IconPictureBoxICONOS.Size = New System.Drawing.Size(52, 54)
        Me.IconPictureBoxICONOS.TabIndex = 0
        Me.IconPictureBoxICONOS.TabStop = False
        '
        'PanelEscritorios
        '
        Me.PanelEscritorios.BackColor = System.Drawing.Color.White
        Me.PanelEscritorios.Controls.Add(Me.PictureBox1)
        Me.PanelEscritorios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEscritorios.Location = New System.Drawing.Point(285, 74)
        Me.PanelEscritorios.Name = "PanelEscritorios"
        Me.PanelEscritorios.Size = New System.Drawing.Size(779, 607)
        Me.PanelEscritorios.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.Petpalace.My.Resources.Resources.petpalacelogo
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(779, 607)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Pantalla_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 681)
        Me.Controls.Add(Me.PanelEscritorios)
        Me.Controls.Add(Me.PanelTitulo)
        Me.Controls.Add(Me.PanelIzquierdo)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Pantalla_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pantalla Principal"
        Me.PanelIzquierdo.ResumeLayout(False)
        Me.PanelIzquierdo.PerformLayout()
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.PictureBoxImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTitulo.ResumeLayout(False)
        Me.PanelTitulo.PerformLayout()
        CType(Me.IconPictureBoxICONOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEscritorios.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelIzquierdo As Panel
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents PictureBoxImagen As PictureBox
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonCitas As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonServicios As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonClientes As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents IconPictureBoxICONOS As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents LabelTitulos As Label
    Friend WithEvents IconButtonCerrarSesion As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelEscritorios As Panel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonperfil As FontAwesome.Sharp.IconButton
    Friend WithEvents PictureBox1 As PictureBox
End Class
