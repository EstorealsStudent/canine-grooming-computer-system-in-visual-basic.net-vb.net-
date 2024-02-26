Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports System.Drawing
Imports MaterialSkin
'se hace referencia a dominio
Imports Dominio
Public Class FrmLog


    'Fields
    Private borderRadius As Integer = 20
    Private borderSize As Integer = 3

    'Constructor
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.FormBorderStyle = FormBorderStyle.None
        Me.Padding = New Padding(borderSize)


    End Sub

    'Drag Form
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub PanelTitleBar_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112, &HF012, 0)
    End Sub

    'Minimize borderless form from taskbar
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.Style = cp.Style Or &H20000 '<--- Minimize borderless form from taskbar
            Return cp
        End Get
    End Property

    Private Function GetRoundedPath(rect As Rectangle, radius As Single) As GraphicsPath
        Dim path As GraphicsPath = New GraphicsPath()
        Dim curveSize As Single = radius * 2.0F
        path.StartFigure()
        path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90)
        path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90)
        path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90)
        path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90)
        path.CloseFigure()
        Return path
    End Function

    Private Sub FormRegionAndBorder(form As Form, radius As Single, graph As Graphics, borderSize As Single)
        If Me.WindowState <> FormWindowState.Minimized Then
            Using roundPath As GraphicsPath = GetRoundedPath(form.ClientRectangle, radius)

                Using transform As Matrix = New Matrix()

                    graph.SmoothingMode = SmoothingMode.AntiAlias
                    form.Region = New Region(roundPath)
                    If borderSize >= 1 Then
                        Dim rect As Rectangle = form.ClientRectangle
                        Dim scaleX As Single = 1.0F - ((borderSize + 1) / rect.Width)
                        Dim scaleY As Single = 1.0F - ((borderSize + 1) / rect.Height)
                        transform.Scale(scaleX, scaleY)
                        transform.Translate(borderSize / 1.6F, borderSize / 1.6F)
                        graph.Transform = transform

                    End If


                End Using

            End Using

        End If
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        FormRegionAndBorder(Me, borderRadius, e.Graphics, borderSize)




    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.Cyan500, Primary.BlueGrey500, Accent.Red700, TextShade.WHITE)

        RoundButton(Button1)
        RoundButton2(Button2)
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Button1.BackColor = Color.FromArgb(127, 50, 54)
        Button1.ForeColor = Color.FromArgb(232, 195, 197)
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.FromArgb(188, 75, 81)
        Button1.ForeColor = Color.FromArgb(232, 195, 197)
    End Sub

    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover
        Button2.BackColor = Color.FromArgb(125, 50, 54)
        Button2.ForeColor = Color.FromArgb(232, 195, 197)
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Button2.BackColor = Color.FromArgb(188, 75, 81)
        Button2.ForeColor = Color.FromArgb(232, 195, 197)
    End Sub


    'Bordes redondos
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
        Raduis.AddLine(Button1.Width, 20, btn.Width, btn.Height - 10)
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
        Button1.Region = New Region(Raduis)
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
        Raduis.AddLine(Button2.Width, 20, btn.Width, btn.Height - 10)
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
        Button2.Region = New Region(Raduis)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    'Click del login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        Dim userModel As New ModeloUsuario()
        Dim validLogin = userModel.Login(TextBoxUsuario.Text, TextboxContraseña.Text)
        If validLogin = True Then
            '-----Agregamos estos codigos antes de mostrar el formulario principal-----'
            Me.Hide()
            Dim formwelcome As New FrmBienvenida()
            formwelcome.ShowDialog()
            '----------------------------------------------------------------'
            Dim frm As New Pantalla_Principal()
            frm.Show()
            AddHandler frm.FormClosed, AddressOf Me.Logout
        Else
            MessageBox.Show("Contraseña o Usuario incorrecto." + vbNewLine + "Intenta de nuevo.")
            TextBoxUsuario.Clear()
            TextboxContraseña.Clear()
            TextBoxUsuario.Focus()
        End If

    End Sub
    Private Sub Logout(sender As Object, e As FormClosedEventArgs)
        TextBoxUsuario.Clear()
        TextboxContraseña.Clear()
        Me.Show()
        TextBoxUsuario.Focus()
    End Sub
    'LabelRecuperarContraseña
    Private Sub LabelRecuperarContraseña_Click(sender As Object, e As EventArgs) Handles LabelRecuperarContraseña.Click
        Dim FormularioRecuperarContraseña As New FrmRecuperarContraseña()
        FormularioRecuperarContraseña.ShowDialog()
    End Sub

End Class


