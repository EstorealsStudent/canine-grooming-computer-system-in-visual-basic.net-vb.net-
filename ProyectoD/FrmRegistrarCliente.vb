Imports Común
Imports Dominio

Public Class FrmRegistrarCliente
    Dim userDao As New ModeloUsuario()
    Private Sub FrmRegistrarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RoundButton(ButtonAceptar)
        RoundButton2(ButtonCancelar)
        MaterialComboBox1.DataSource = userDao.modelousuariomostrargeneros()
        MaterialComboBox1.DisplayMember = "NombreGenero"
        MaterialComboBox1.ValueMember = "IDGenero"
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

    Private Sub ButtonAceptar_Click(sender As Object, e As EventArgs) Handles ButtonAceptar.Click

        Try
            If MaterialTextBoxPrimerNombre.Text <> "" AndAlso MaterialTextBoxApellidoPaterno.Text <> "" Then

                Dim userModel As New ModeloClientes(iDGenero:=MaterialComboBox1.SelectedValue,
            primerNombre:=MaterialTextBoxPrimerNombre.Text,
            segundoNombre:=MaterialTextBoxSegundoNombre.Text,
            apellidoPaterno:=MaterialTextBoxApellidoPaterno.Text,
            apellidoMaterno:=MaterialTextBoxApellidoMaterno.Text,
            rFC:=MaterialTextBoxRFC.Text,
            cURP:=MaterialTextBoxCURP.Text,
            celular:=MaterialTextBoxCelular.Text,
            telCasa:=MaterialTextBoxCasa.Text,
            telTrabajo:=MaterialTextBoxTrabajo.Text,
            telExterno:=MaterialTextBoxExterno.Text,
            email:=MaterialTextBoxEmail.Text,
            calle:=MaterialTextBoxCalle.Text,
            numeroExt:=MaterialTextBoxNumero.Text,
            colonia:=MaterialTextBoxColonia.Text,
            municipio:=MaterialTextBoxMunicipio.Text,
            codigoPostal:=MaterialTextBoxCodigoPostal.Text,
            estado:=MaterialTextBoxEstado.Text,
            descripcion:=MaterialMultiLineTextBoxDescripcion.Text)
                Dim result = userModel.insertarclientesmodelo()
                MessageBox.Show(result)

                limpiar()

            Else
                MessageBox.Show("Debes rellenar Nombre y apellido paterno")
            End If
        Catch
        End Try



    End Sub

    Private Sub limpiar()
        MaterialTextBoxPrimerNombre.Clear()
        MaterialTextBoxSegundoNombre.Clear()
        MaterialTextBoxApellidoPaterno.Clear()
        MaterialTextBoxApellidoMaterno.Clear()

        MaterialTextBoxCalle.Clear()
        MaterialTextBoxNumero.Clear()
        MaterialTextBoxColonia.Clear()
        MaterialTextBoxMunicipio.Clear()
        MaterialTextBoxCodigoPostal.Clear()
        MaterialTextBoxEstado.Clear()
        MaterialTextBoxRFC.Clear()
        MaterialTextBoxCURP.Clear()
        MaterialTextBoxCasa.Clear()

        MaterialTextBoxCelular.Clear()
        MaterialTextBoxTrabajo.Clear()
        MaterialTextBoxExterno.Clear()
        MaterialTextBoxEmail.Clear()
        MaterialMultiLineTextBoxDescripcion.Clear()




    End Sub

    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
        Me.Close()
    End Sub
End Class