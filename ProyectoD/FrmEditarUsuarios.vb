
Imports MaterialSkin
Imports Común
Imports Dominio
Public Class FrmEditarUsuarios
    Private Sub FrmEditarUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance

        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepPurple700, TextShade.WHITE)

        RoundButton(ButtonAceptar)
        RoundButton2(ButtonCancelar)

        loadUserData()
        initializeControlsEditPass()

    End Sub

    Private Sub LoadUserData()
        'View
        LabelUsuario.Text = UsuarioActivo.Usuario
        LabelPrimerNombre.Text = UsuarioActivo.PrimerNombre
        LabelApellido.Text = UsuarioActivo.ApellidoP
        LabelEmail.Text = UsuarioActivo.email
        LabelRol.Text = UsuarioActivo.Rol
        'Edit
        TextBoxUsuario.Text = UsuarioActivo.Usuario
        MaterialTextBoxprimernombre.Text = UsuarioActivo.PrimerNombre
        MaterialTextBoxApellido.Text = UsuarioActivo.ApellidoP
        MaterialTextBoxEmail.Text = UsuarioActivo.email
        MaterialTextBoxNuevaC.Text = UsuarioActivo.Contraseña
        MaterialTextBoxConfirmarC.Text = UsuarioActivo.Contraseña
    End Sub

    Private Sub InitializeControlsEditPass()
        LinkLabel12.Text = "Editar"
        MaterialTextBoxNuevaC.Enabled = False

        MaterialTextBoxConfirmarC.Enabled = False
        MaterialTextContraseñaA.Text = ""
    End Sub

    Private Sub Reset()
        LoadUserData()
        InitializeControlsEditPass()
    End Sub




    'botones
    Private Sub RoundButton2(btn As Button)

        Dim Raduis As New Drawing2D.GraphicsPath

        Raduis.StartFigure()
        'appends an elliptical arc to the current figure
        'left corner top
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        'appends a line segment to the current figure
        Raduis.AddLine(10, 0, btn.Width - 20, 0)
        'appends an elliptical arc to the current figure
        'right corner top
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        'appends a line segment to the current figure
        Raduis.AddLine(ButtonAceptar.Width, 20, btn.Width, btn.Height - 10)
        'appends an elliptical arc to the current figure 
        'right corner buttom
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        'appends a line segment to the current figure
        'left corner bottom
        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        'appends an elliptical arc to the current figure
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        'Close the current figure and start a new one.
        Raduis.CloseFigure()
        'set the window associated with the control
        ButtonAceptar.Region = New Region(Raduis)
    End Sub

    Private Sub RoundButton(btn As Button)

        Dim Raduis As New Drawing2D.GraphicsPath

        Raduis.StartFigure()
        'appends an elliptical arc to the current figure
        'left corner top
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        'appends a line segment to the current figure
        Raduis.AddLine(10, 0, btn.Width - 20, 0)
        'appends an elliptical arc to the current figure
        'right corner top
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        'appends a line segment to the current figure
        Raduis.AddLine(ButtonCancelar.Width, 20, btn.Width, btn.Height - 10)
        'appends an elliptical arc to the current figure 
        'right corner buttom
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        'appends a line segment to the current figure
        'left corner bottom
        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        'appends an elliptical arc to the current figure
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        'Close the current figure and start a new one.
        Raduis.CloseFigure()
        'set the window associated with the control
        ButtonCancelar.Region = New Region(Raduis)
    End Sub

    Private Sub LinkLabel12_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel12.LinkClicked
        If LinkLabel12.Text = "Editar" Then
            LinkLabel12.Text = "Cancelar"
            MaterialTextBoxNuevaC.Enabled = True
            MaterialTextBoxNuevaC.Text = ""
            MaterialTextBoxConfirmarC.Enabled = True
            MaterialTextBoxConfirmarC.Text = ""
        ElseIf LinkLabel12.Text = "Cancelar" Then
            initializeControlsEditPass()
            MaterialTextBoxNuevaC.Text = UsuarioActivo.Contraseña
            MaterialTextBoxConfirmarC.Text = UsuarioActivo.Contraseña
        End If
    End Sub

    Private Sub LinkLabelEditar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelEditar.LinkClicked
        Panel1.Visible = True
        LoadUserData()
    End Sub

    Private Sub ButtonAceptar_Click(sender As Object, e As EventArgs) Handles ButtonAceptar.Click

        If MaterialTextBoxNuevaC.Text = MaterialTextBoxConfirmarC.Text Then
            If MaterialTextContraseñaA.Text = UsuarioActivo.Contraseña Then
                Dim userModel As New ModeloUsuario(idUser:=UsuarioActivo.idUser,
                                               loginName:=TextBoxUsuario.Text,
                                               password:=MaterialTextBoxNuevaC.Text,
                                               firstName:=MaterialTextBoxprimernombre.Text,
                                               lastName:=MaterialTextBoxApellido.Text,
                                               position:=Nothing,
                                               email:=MaterialTextBoxEmail.Text)
                Dim result = userModel.editUserProfile()
                MessageBox.Show(result)
                reset()
                Panel1.Visible = False
            Else
                MessageBox.Show("Contraseña actual incorrecta")
            End If
        Else
            MessageBox.Show("Las contraseñas no coinciden, inténtalo de nuevo.")
        End If


    End Sub

    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
        Panel1.Visible = False
        reset()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Panel1.Visible = True
        LoadUserData()
    End Sub
End Class