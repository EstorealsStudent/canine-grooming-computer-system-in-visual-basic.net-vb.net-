Imports AccesoDatos
Imports Común



Public Class ModeloClientes
    Dim userDao As New UsuarioDAO

    Private IDUsuarioCrea
    Private IDCliente
    Private IDGenero
    Private PrimerNombre
    Private SegundoNombre
    Private ApellidoPaterno
    Private ApellidoMaterno
    Private RFC
    Private CURP
    Private Celular
    Private TelCasa
    Private TelTrabajo
    Private TelExterno
    Private Email
    Private Calle
    Private NumeroExt
    Private Colonia
    Private Municipio
    Private CodigoPostal
    Private Estado
    Private Descripcion
    Private IDUsuarioActualiza

    Public Property IDGenero1 As Object
        Get
            Return IDGenero
        End Get
        Set(value As Object)
            IDGenero = value
        End Set
    End Property

    Public Property PrimerNombre1 As Object
        Get
            Return PrimerNombre
        End Get
        Set(value As Object)
            PrimerNombre = value
        End Set
    End Property

    Public Property SegundoNombre1 As Object
        Get
            Return SegundoNombre
        End Get
        Set(value As Object)
            SegundoNombre = value
        End Set
    End Property

    Public Property ApellidoPaterno1 As Object
        Get
            Return ApellidoPaterno
        End Get
        Set(value As Object)
            ApellidoPaterno = value
        End Set
    End Property

    Public Property ApellidoMaterno1 As Object
        Get
            Return ApellidoMaterno
        End Get
        Set(value As Object)
            ApellidoMaterno = value
        End Set
    End Property

    Public Property RFC1 As Object
        Get
            Return RFC
        End Get
        Set(value As Object)
            RFC = value
        End Set
    End Property

    Public Property CURP1 As Object
        Get
            Return CURP
        End Get
        Set(value As Object)
            CURP = value
        End Set
    End Property

    Public Property Celular1 As Object
        Get
            Return Celular
        End Get
        Set(value As Object)
            Celular = value
        End Set
    End Property

    Public Property TelCasa1 As Object
        Get
            Return TelCasa
        End Get
        Set(value As Object)
            TelCasa = value
        End Set
    End Property

    Public Property TelTrabajo1 As Object
        Get
            Return TelTrabajo
        End Get
        Set(value As Object)
            TelTrabajo = value
        End Set
    End Property

    Public Property TelExterno1 As Object
        Get
            Return TelExterno
        End Get
        Set(value As Object)
            TelExterno = value
        End Set
    End Property

    Public Property Email1 As Object
        Get
            Return Email
        End Get
        Set(value As Object)
            Email = value
        End Set
    End Property

    Public Property Calle1 As Object
        Get
            Return Calle
        End Get
        Set(value As Object)
            Calle = value
        End Set
    End Property

    Public Property NumeroExt1 As Object
        Get
            Return NumeroExt
        End Get
        Set(value As Object)
            NumeroExt = value
        End Set
    End Property

    Public Property Colonia1 As Object
        Get
            Return Colonia
        End Get
        Set(value As Object)
            Colonia = value
        End Set
    End Property

    Public Property Municipio1 As Object
        Get
            Return Municipio
        End Get
        Set(value As Object)
            Municipio = value
        End Set
    End Property

    Public Property CodigoPostal1 As Object
        Get
            Return CodigoPostal
        End Get
        Set(value As Object)
            CodigoPostal = value
        End Set
    End Property

    Public Property Estado1 As Object
        Get
            Return Estado
        End Get
        Set(value As Object)
            Estado = value
        End Set
    End Property

    Public Property Descripcion1 As Object
        Get
            Return Descripcion
        End Get
        Set(value As Object)
            Descripcion = value
        End Set
    End Property

    Public Property IDCliente1 As Object
        Get
            Return IDCliente
        End Get
        Set(value As Object)
            IDCliente = value
        End Set
    End Property

    Public Property IDUsuarioCrea1 As Object
        Get
            Return IDUsuarioCrea
        End Get
        Set(value As Object)
            IDUsuarioCrea = value
        End Set
    End Property

    Public Property IDUsuarioActualiza1 As Object
        Get
            Return IDUsuarioActualiza
        End Get
        Set(value As Object)
            IDUsuarioActualiza = value
        End Set
    End Property

    Public Sub New(iDGenero As Object, primerNombre As Object, segundoNombre As Object, apellidoPaterno As Object, apellidoMaterno As Object, rFC As Object, cURP As Object, celular As Object, telCasa As Object, telTrabajo As Object, telExterno As Object, email As Object, calle As Object, numeroExt As Object, colonia As Object, municipio As Object, codigoPostal As Object, estado As Object, descripcion As Object, IDUsuarioCrea As Object)

        Me.IDGenero1 = iDGenero
        Me.PrimerNombre1 = primerNombre
        Me.SegundoNombre1 = segundoNombre
        Me.ApellidoPaterno1 = apellidoPaterno
        Me.ApellidoMaterno1 = apellidoMaterno
        Me.RFC1 = rFC
        Me.CURP1 = cURP
        Me.Celular1 = celular
        Me.TelCasa1 = telCasa
        Me.TelTrabajo1 = telTrabajo
        Me.TelExterno1 = telExterno
        Me.Email1 = email
        Me.Calle1 = calle
        Me.NumeroExt1 = numeroExt
        Me.Colonia1 = colonia
        Me.Municipio1 = municipio
        Me.CodigoPostal1 = codigoPostal
        Me.Estado1 = estado
        Me.Descripcion1 = descripcion
        Me.IDUsuarioCrea1 = IDUsuarioCrea
    End Sub


    Public Sub New()
    End Sub

    Public Sub New(iDCliente As Object, iDGenero As Object, primerNombre As Object, segundoNombre As Object, apellidoPaterno As Object, apellidoMaterno As Object, rFC As Object, cURP As Object, celular As Object, telCasa As Object, telTrabajo As Object, telExterno As Object, email As Object, calle As Object, numeroExt As Object, colonia As Object, municipio As Object, codigoPostal As Object, estado As Object, descripcion As Object, IDUsuarioActualiza As Object)
        Me.IDCliente = iDCliente
        Me.IDGenero = iDGenero
        Me.PrimerNombre = primerNombre
        Me.SegundoNombre = segundoNombre
        Me.ApellidoPaterno = apellidoPaterno
        Me.ApellidoMaterno = apellidoMaterno
        Me.RFC = rFC
        Me.CURP = cURP
        Me.Celular = celular
        Me.TelCasa = telCasa
        Me.TelTrabajo = telTrabajo
        Me.TelExterno = telExterno
        Me.Email = email
        Me.Calle = calle
        Me.NumeroExt = numeroExt
        Me.Colonia = colonia
        Me.Municipio = municipio
        Me.CodigoPostal = codigoPostal
        Me.Estado = estado
        Me.Descripcion = descripcion
        Me.IDUsuarioActualiza = IDUsuarioActualiza
    End Sub

    Public Function Insertarclientesmodelo() As String
        Try
            userDao.InsertarCliente(IDGenero, PrimerNombre, SegundoNombre, ApellidoPaterno, ApellidoMaterno, RFC, CURP, Celular, TelCasa, TelTrabajo, TelExterno, Email, Calle, NumeroExt, Colonia, Municipio, CodigoPostal, Estado, Descripcion, IDUsuarioCrea)
            Return "Cliente Registrado Corrrectamente."
        Catch ex As Exception

            Return "No se Registró Corrrectamente."
        End Try
    End Function

    Public Function EditarClientesModelo() As String
        Try
            userDao.EditarClientes(IDCliente, IDGenero, PrimerNombre, SegundoNombre, ApellidoPaterno, ApellidoMaterno, RFC, CURP, Celular, TelCasa, TelTrabajo, TelExterno, Email, Calle, NumeroExt, Colonia, Municipio, CodigoPostal, Estado, Descripcion, IDUsuarioActualiza)
            Return "Cliente Editado Corrrectamente."
        Catch ex As Exception

            Return "error"
        End Try
    End Function

End Class
