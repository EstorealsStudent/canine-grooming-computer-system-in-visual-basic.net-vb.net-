Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp
Imports Común
Imports Dominio
Public Class Pantalla_Principal
    'Fields'
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentChildForm As Form
    'Constructor'
    Public Sub New()
        ' This call is required by the designer.'
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.'
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 60)
        PanelIzquierdo.Controls.Add(leftBorderBtn)
        'Form'
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
    End Sub

    'Methods'
    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            'Button'
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(37, 36, 81)
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
            'Left Border'
            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()
            'current Form icon'
            IconPictureBoxICONOS.IconChar = currentBtn.IconChar
            IconPictureBoxICONOS.IconColor = customColor
        End If
    End Sub

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(39, 20, 49)
            currentBtn.ForeColor = Color.White
            currentBtn.IconColor = Color.White
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If





    End Sub


    Private Sub OpenChildForm(childForm As Form)
        'Open only form'
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        'end'
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelEscritorios.Controls.Add(childForm)
        PanelEscritorios.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        LabelTitulos.Text = childForm.Text
    End Sub
    Private Sub Reset()
        DisableButton()
        leftBorderBtn.Visible = False
        IconPictureBoxICONOS.IconChar = IconChar.Home
        IconPictureBoxICONOS.IconColor = Color.White
        LabelTitulos.Text = "Inicio"
    End Sub






    'BotonClientes
    Private Sub IconButtonClientes_Click(sender As Object, e As EventArgs) Handles IconButtonClientes.Click
        ActivateButton(sender, RGBColores.color1)
        OpenChildForm(New FrmElegirCliente)
    End Sub
    'Servicios
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButtonServicios.Click
        ActivateButton(sender, RGBColores.color1)

        OpenChildForm(New FrmElejirServicio)
    End Sub

    Private Sub IconButtonCitas_Click(sender As Object, e As EventArgs) Handles IconButtonCitas.Click
        ActivateButton(sender, RGBColores.color1)
        OpenChildForm(New FrmElejirCita)
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        ActivateButton(sender, RGBColores.color1)
        OpenChildForm(New FrmElegirMascota)

    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs)
        ActivateButton(sender, RGBColores.color1)
    End Sub

    Private Sub PictureBoxImagen_Click(sender As Object, e As EventArgs) Handles PictureBoxImagen.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        Reset()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub PanelTitulor_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelTitulo.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Pantalla_Principal_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If WindowState = FormWindowState.Maximized Then
            FormBorderStyle = FormBorderStyle.None
        Else
            FormBorderStyle = FormBorderStyle.Sizable
        End If
    End Sub

    Private Sub IconButtonCerrarSesion_Click(sender As Object, e As EventArgs) Handles IconButtonCerrarSesion.Click
        If MessageBox.Show("¿Seguro que quieres cerrar sesión?", "ADVERTENCIA",
       MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Pantalla_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUser()
        Seguridad()
        Permisos()
    End Sub
    'CargarUsuarios
    Private Sub LoadUser()
        ' '  LabelUsuario.Text = UsuarioActivo.Usuario
        '  LabelEmail.Text = UsuarioActivo.email
        ' LabelRol.Text = UsuarioActivo.Rol
    End Sub
    'Seguridad
    Private Sub Seguridad()
        Dim user As New ModeloUsuario()
        If user.SecurityLogin() = False Then
            'Codes
            MessageBox.Show("Error")
            Application.Exit()
        End If
    End Sub
    'Permisos
    Private Sub Permisos()
        If UsuarioActivo.Rol = Roles.Administrador Then
            IconButtonClientes.Enabled = True
            IconButtonClientes.IconColor = Color.White
            IconButtonServicios.Enabled = True
            IconButtonClientes.IconColor = Color.White
        End If
        If UsuarioActivo.Rol = Roles.Recepcionista Then
            IconButton2.Enabled = False
        End If
        If UsuarioActivo.Rol = Roles.Estilista Then
            IconButton2.Enabled = False
        End If
        'más
    End Sub



    Private Sub IconButton1_Click_1(sender As Object, e As EventArgs) Handles IconButtonperfil.Click
        ActivateButton(sender, RGBColores.color1)
        OpenChildForm(New FrmEditarUsuarios)
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        ActivateButton(sender, RGBColores.color1)
        OpenChildForm(New FrmAdm)
    End Sub


End Class