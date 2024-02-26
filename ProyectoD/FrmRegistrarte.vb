Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports System.Drawing
Imports MaterialSkin
'se hace referencia a dominio
Imports Dominio
Public Class FrmRegistrarte

    Dim userModelo As New ModeloUsuario()
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


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub FrmRegistrarte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargarcomponentes()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim contaseñaconvertida As String = MaterialTextBoxContraseña.Text

        If MaterialTextBoxPrimerNombre.Text <> "" AndAlso MaterialTextBoxApellidoPaterno.Text <> "" AndAlso MaterialTextBoxUsuario.Text <> "" AndAlso MaterialTextBoxEmail.Text <> "" AndAlso MaterialTextBoxContraseña.Text <> "" Then
            If MaterialTextBoxContraseña.Text = MaterialTextBoxConfirmarContraseña.Text Then
                Dim userModel As New ModeloUsuario(firstName:=MaterialTextBoxPrimerNombre.Text, secondNmae:=MaterialTextBoxSegundoNombre.Text,
                                                   lastName:=MaterialTextBoxApellidoPaterno.Text, apellidoMaterno:=MaterialTextBoxApellidoMaterno.Text,
email:=MaterialTextBoxEmail.Text, loginName:=MaterialTextBoxUsuario.Text, password:=contaseñaconvertida, position:=MaterialComboBoxRol.SelectedValue)

                Dim result = userModel.InsertarUsuarios()
                MessageBox.Show(result)
                limpiarcomponentes()
            Else
                MessageBox.Show("Las contraseñas no coinciden, inténtalo de nuevo.")

            End If
        Else
            MessageBox.Show("Las debes completar los campos.")

        End If
    End Sub

    Private Sub Cargarcomponentes()


        MaterialComboBoxRol.DataSource = userModelo.ObtenerListaRolesCliente()
        MaterialComboBoxRol.DisplayMember = "NombreRoles"
        MaterialComboBoxRol.ValueMember = "idroles"

    End Sub

    Private Sub limpiarcomponentes()
        MaterialTextBoxPrimerNombre.Clear()
        MaterialTextBoxSegundoNombre.Clear()
        MaterialTextBoxApellidoPaterno.Clear()
        MaterialTextBoxApellidoMaterno.Clear()
        MaterialTextBoxEmail.Clear()
        MaterialTextBoxUsuario.Clear()
        MaterialTextBoxContraseña.Clear()
        MaterialTextBoxConfirmarContraseña.Clear()
    End Sub

End Class