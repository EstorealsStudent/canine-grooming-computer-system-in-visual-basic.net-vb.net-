
Imports System.Data.SqlClient
Imports Común
Public Class UsuarioDAO
    Inherits Conexionsql2

    Public Sub EditProfile(id, user, pass, name, lastName, mail)
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "update Trabajador set Usuario=@user, Clave=EncryptByPassPhrase('petpalace', CONVERT(varbinary, @pass)), PrimerNombre=@name, ApellidoPaterno=@lastName, Email=@mail where IDTrabajador=@id"
                command.Parameters.AddWithValue("@user", user)
                command.Parameters.AddWithValue("@pass", pass)
                command.Parameters.AddWithValue("@name", name)
                command.Parameters.AddWithValue("@lastName", lastName)
                command.Parameters.AddWithValue("@mail", mail)
                command.Parameters.AddWithValue("@id", id)
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    'Conexion
    Public Function RequestUserPassword(ByVal requestingUser As String) As String
        Using connection = GetConnection()
            connection.Open()

            Using command = New SqlCommand()

                command.Connection = connection
                command.CommandText = "SELECT IDTrabajador, PrimerNombre, SegundoNombre, ApellidoPaterno, ApellidoMaterno, Email, Usuario,CONVERT(NVARCHAR(MAX), DecryptByPassPhrase('petpalace', Clave)) AS Contraseña, IDRol FROM Trabajador
where (Usuario=@Usuario or Email=@Email) and Estatus=1"
                command.Parameters.AddWithValue("@Usuario", requestingUser)
                command.Parameters.AddWithValue("@Email", requestingUser)
                command.CommandType = CommandType.Text
                Dim reader As SqlDataReader = command.ExecuteReader()

                If reader.Read() = True Then
                    Dim userName As String = reader.GetString(1) & " " + reader.GetString(3)
                    Dim userMail As String = reader.GetString(5)
                    Dim accountPassword As String = reader.GetString(7)

                    Dim systemSupport = New SupportDeEmail()
                    systemSupport.sendMail(
          subject:="SISTEMA: Recuperar Contraseña.",
          body:="¡Hola," & userName & "!" & vbLf & "Solicitaste a medio de esta petición la recuperación de tu contraseña." & vbLf &
          "Tu contraseña es: " & accountPassword & "." & vbLf &
          "Sin embargo, entrando nuevamente al sistema puedes cambiar tu clave de usuario.",
          receiverMail:=New List(Of String) From {userMail}
          )

                    Return "Hola! " & userName & vbLf & "Solicitaste Recuperar tu contraseña." & vbLf &
          "Porfavor, Revisa tu Correo: " & vbLf & userMail & vbLf


                Else
                    Return "Losiento, No existe una cuenta con este" & vbLf & " Nombre de usuario O Correo Electronico."
                End If

            End Using
        End Using
    End Function













    Public Function Login(user As String, pass As String) As Boolean
        Try
            Using connection = GetConnection()
                connection.Open()
                Using command = New SqlCommand()
                    command.Connection = connection
                    command.CommandText = "SELECT IDTrabajador, PrimerNombre, SegundoNombre, ApellidoPaterno, ApellidoMaterno, Email, Usuario, CONVERT(NVARCHAR(MAX), DecryptByPassPhrase('petpalace', Clave)) AS Contraseña, IDRol FROM Trabajador WHERE 
(Usuario= @Usuario and CONVERT(varchar(MAX), DECRYPTBYPASSPHRASE('petpalace', Clave))= @Contraseña) and Estatus=1"
                    command.Parameters.AddWithValue("@Usuario", user)
                    command.Parameters.AddWithValue("@Contraseña", pass)
                    command.CommandType = CommandType.Text
                    Using reader = command.ExecuteReader()
                        If reader.HasRows Then
                            While reader.Read()
                                UsuarioActivo.idUser = reader.GetInt32(0)
                                UsuarioActivo.Usuario = reader.GetString(6)
                                UsuarioActivo.Contraseña = reader.GetString(7)
                                UsuarioActivo.PrimerNombre = reader.GetString(1)
                                UsuarioActivo.ApellidoP = reader.GetString(3)
                                UsuarioActivo.Rol = reader.GetInt32(8)
                                UsuarioActivo.email = reader.GetString(5)
                            End While
                            Return True
                        Else
                            Return False
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function


    Public Function ExistsUser(id As Integer, loginName As String, pass As String) As Boolean
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "select *from Trabajador where (IDTrabajador=@Usuario) and Estatus=1"
                command.Parameters.AddWithValue("@Usuario", id)
                command.CommandType = CommandType.Text
                Dim reader = command.ExecuteReader()
                If reader.HasRows Then

                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
    End Function


    Public Function Buscarclientes() As List(Of Clientes)
        Dim clientes As New List(Of Clientes)

        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "SELECT IDCliente, CONCAT(PrimerNombre, ' ', ISNULL(SegundoNombre, ''), ' ', ApellidoPaterno, ' ', ISNULL(ApellidoMaterno, '')) AS Nombre, Celular
FROM Cliente"
                Dim reader = command.ExecuteReader()

                If reader.HasRows Then
                    While reader.Read()
                        Dim cliente As New Clientes()
                        cliente.IDCliente = reader("IDCliente")
                        cliente.Nombre = reader("Nombre")
                        cliente.Celular = reader("Celular")
                        clientes.Add(cliente)
                    End While
                End If
            End Using
        End Using

        Return clientes
    End Function


    Public Function MostrarClientes(idclientes) As Clientes
        Dim cliente As New Clientes()

        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "SELECT
    c.IDCliente,
	c.IDGenero,
    c.PrimerNombre,
    c.SegundoNombre,
    c.ApellidoPaterno,
    c.ApellidoMaterno,
    c.RFC,
    c.CURP,
    c.Celular,
    c.TelCasa,
    c.TelTrabajo,
    c.TelExterno,
    c.Email,
    c.Calle,
    c.NumeroExt,
    c.Colonia,
    c.Municipio,
    c.CodigoPostal,
    c.Estado,
    c.Descripcion,
	g.NombreGenero
FROM
    Cliente c
JOIN
    Genero g ON c.IDGenero = g.IDGenero
	where c.IDCliente = @idcliente"
                command.Parameters.AddWithValue("@idcliente", idclientes)
                command.CommandType = CommandType.Text

                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read()
                            ' Asignamos los valores al objeto Cliente
                            cliente.IDClientes = reader.GetInt32(0)
                            If Not reader.IsDBNull(1) Then
                                cliente.IDGenero = reader.GetInt32(1)
                            End If
                            cliente.PrimerNombre = reader.GetString(2)
                            cliente.SegundoNombre = If(reader.IsDBNull(3), String.Empty, reader.GetString(3))
                            cliente.ApellidoPaterno = reader.GetString(4)
                            cliente.ApellidoMaterno = If(reader.IsDBNull(5), String.Empty, reader.GetString(5))
                            cliente.RFC = reader.GetString(6)
                            cliente.CURP = reader.GetString(7)
                            cliente.Celularc = If(reader.IsDBNull(8), String.Empty, reader.GetString(8))
                            cliente.TelCasa = If(reader.IsDBNull(9), String.Empty, reader.GetString(9))
                            cliente.TelTrabajo = If(reader.IsDBNull(10), String.Empty, reader.GetString(10))
                            cliente.TelExterno = If(reader.IsDBNull(11), String.Empty, reader.GetString(11))
                            cliente.Email = If(reader.IsDBNull(12), String.Empty, reader.GetString(12))
                            cliente.Calle = If(reader.IsDBNull(13), String.Empty, reader.GetString(13))
                            cliente.NumeroExt = If(reader.IsDBNull(14), String.Empty, reader.GetString(14))
                            cliente.Colonia = If(reader.IsDBNull(15), String.Empty, reader.GetString(15))
                            cliente.Municipio = If(reader.IsDBNull(16), String.Empty, reader.GetString(16))
                            cliente.CodigoPostal = If(reader.IsDBNull(17), String.Empty, reader.GetString(17))
                            cliente.Estado = If(reader.IsDBNull(18), String.Empty, reader.GetString(18))
                            cliente.Descripcion = If(reader.IsDBNull(19), String.Empty, reader.GetString(19))
                            cliente.NombreGenero = reader.GetString(20)


                            ' Asigna otros valores según las columnas correspondientes

                        End While
                    Else
                        ' No se encontraron resultados
                        Return Nothing
                    End If
                End Using
            End Using
        End Using

        Return cliente
    End Function


    Public Function ObtenerListaGeneros() As List(Of Clientes)
        Dim listaGeneros As New List(Of Clientes)()

        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "SELECT * FROM Genero where Estatus=1"
                command.CommandType = CommandType.Text

                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim genero As New Clientes()
                        genero.IDGenero = reader.GetInt32(0)
                        genero.NombreGenero = reader.GetString(1)
                        ' Puedes agregar más propiedades según la estructura real de tu tabla de géneros
                        listaGeneros.Add(genero)
                    End While
                End Using
            End Using
        End Using

        Return listaGeneros
    End Function

    Public Sub InsertarCliente(IDGenero, PrimerNombre, SegundoNombre, ApellidoPaterno, ApellidoMaterno, RFC, CURP, Celular, TelCasa, TelTrabajo, TelExterno, Email, Calle, NumeroExt, Colonia, Municipio, CodigoPostal, Estado, Descripcion, idusuario)

        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "INSERT INTO Cliente (IDGenero,PrimerNombre, segundonombre, ApellidoPaterno, ApellidoMaterno, RFC, CURP, Celular, TelCasa, TelTrabajo, TelExterno, Email, Calle, NumeroExt, Colonia, Municipio, CodigoPostal, Estado, Descripcion, IdUsuarioCrea) 
 VALUES (@IDGenero,@PrimerNombre, @SegundoNombre, @ApellidoPaterno, @ApellidoMaterno, @RFC, @CURP, @Celular, @TelCasa, @TelTrabajo, @TelExterno, @Email, @Calle, @NumeroExt, @Colonia, @Municipio, @CodigoPostal, @Estado, @Descripcion, @idusuario)"
                ' Asegúrate de configurar los parámetros correspondientes
                command.Parameters.AddWithValue("@IDGenero", IDGenero)
                command.Parameters.AddWithValue("@PrimerNombre", PrimerNombre)
                command.Parameters.AddWithValue("@SegundoNombre", SegundoNombre)
                command.Parameters.AddWithValue("@ApellidoPaterno", ApellidoPaterno)
                command.Parameters.AddWithValue("@ApellidoMaterno", ApellidoMaterno)
                command.Parameters.AddWithValue("@RFC", RFC)
                command.Parameters.AddWithValue("@CURP", CURP)
                command.Parameters.AddWithValue("@Celular", Celular)
                command.Parameters.AddWithValue("@TelCasa", TelCasa)
                command.Parameters.AddWithValue("@TelTrabajo", TelTrabajo)
                command.Parameters.AddWithValue("@TelExterno", TelExterno)
                command.Parameters.AddWithValue("@Email", Email)
                command.Parameters.AddWithValue("@Calle", Calle)
                command.Parameters.AddWithValue("@NumeroExt", NumeroExt)
                command.Parameters.AddWithValue("@Colonia", Colonia)
                command.Parameters.AddWithValue("@Municipio", Municipio)
                command.Parameters.AddWithValue("@CodigoPostal", CodigoPostal)
                command.Parameters.AddWithValue("@Estado", Estado)
                command.Parameters.AddWithValue("@Descripcion", Descripcion)
                command.Parameters.AddWithValue("@idusuario", idusuario)
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()
            End Using
        End Using


    End Sub


    Public Sub EditarClientes(id, IDGenero, PrimerNombre, SegundoNombre, ApellidoPaterno, ApellidoMaterno, RFC, CURP, Celular, TelCasa, TelTrabajo, TelExterno, Email, Calle, NumeroExt, Colonia, Municipio, CodigoPostal, Estado, Descripcion, IdUsuarioModifica)

        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "UPDATE Cliente SET IDGenero = @genero, PrimerNombre = @primerNombre,SegundoNombre = @segundoNombre,ApellidoPaterno = @ApellidoPaterno,ApellidoMaterno = @ApellidoMaterno,
RFC = @RFC,
CURP = @Curp,
Celular = @celular,
TelCasa = @telCasa,
TelTrabajo = @telTrabajo,
TelExterno = @telexterno,
Email = @Email,
Calle = @Calle,
NumeroExt = @NumeroExt,
Colonia = @colonia,
Municipio = @municipio,
CodigoPostal = @Codigopostal,
Estado = @estado,
IdUsuarioModifica=@IDUsuarioModifica,
FechaModifica=GETDATE(),
Descripcion = @Descripcion WHERE IDCliente = @IdCliente"
                ' Asegúrate de configurar los parámetros correspondientes
                command.Parameters.AddWithValue("@genero", IDGenero)
                command.Parameters.AddWithValue("@primerNombre", PrimerNombre)
                command.Parameters.AddWithValue("@segundoNombre", SegundoNombre)
                command.Parameters.AddWithValue("@ApellidoPaterno", ApellidoPaterno)
                command.Parameters.AddWithValue("@ApellidoMaterno", ApellidoMaterno)
                command.Parameters.AddWithValue("@RFC", RFC)
                command.Parameters.AddWithValue("@Curp", CURP)
                command.Parameters.AddWithValue("@celular", Celular)
                command.Parameters.AddWithValue("@telCasa", TelCasa)
                command.Parameters.AddWithValue("@TelTrabajo", TelTrabajo)
                command.Parameters.AddWithValue("@telexterno", TelExterno)
                command.Parameters.AddWithValue("@Email", Email)
                command.Parameters.AddWithValue("@Calle", Calle)
                command.Parameters.AddWithValue("@NumeroExt", NumeroExt)
                command.Parameters.AddWithValue("@colonia", Colonia)
                command.Parameters.AddWithValue("@municipio", Municipio)
                command.Parameters.AddWithValue("@Codigopostal", CodigoPostal)
                command.Parameters.AddWithValue("@estado", Estado)
                command.Parameters.AddWithValue("@Descripcion", Descripcion)
                command.Parameters.AddWithValue("@IdCliente", id)
                command.Parameters.AddWithValue("@IDUsuarioModifica", IdUsuarioModifica)
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()
            End Using
        End Using


    End Sub



    Public Function CargarMascotasClientes(id) As DataTable
        Dim cliente As New Clientes()

        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "
SELECT
M.IDMascota,
M.Nombre AS NombreMascota,
T.Nombre AS TipoMascota,
RM.Nombre AS Raza,
M.Peso,
SM.Nombre AS Sexo,
M.Color,
M.Fallecido
FROM
Mascota M
JOIN
SexoMascota SM ON M.IDSeMascota=SM.IDSeMascota
JOIN
RazaMascota RM ON M.IDRMascota = RM.IDRMascota
JOIN
TipoMascota T ON RM.IDTMascota = T.IDTMascota
WHERE
IDCliente = @idcliente"
                command.Parameters.AddWithValue("@idcliente", id)
                command.CommandType = CommandType.Text

                Dim dataTable As New DataTable()
                Using adapter As New SqlDataAdapter(command)
                    adapter.Fill(dataTable)
                End Using

                Return dataTable
            End Using
        End Using
    End Function



    Public Function MostrarMascotas(idmascotas) As Mascotas
        Dim mascota As New Mascotas()

        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "
SELECT
M.IDMascota,
M.IDCliente,
M.IDRMascota,
M.IDSeMascota,
M.Nombre AS NombreMascota,
M.Peso,
M.Color,
M.Esvacunado,
M.Vacuna,
m.VigVacuna,
m.foto,
m.fallecido,
T.IDTMascota
FROM
Mascota M
JOIN
    RazaMascota RM ON M.IDRMascota = RM.IDRMascota
JOIN
    TipoMascota T ON RM.IDTMascota = T.IDTMascota
WHERE
IDMascota = @idmascota"
                command.Parameters.AddWithValue("@idmascota", idmascotas)
                command.CommandType = CommandType.Text

                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read()
                            ' Asignamos los valores al objeto Cliente
                            mascota.IDMascota = reader.GetInt32(0)
                            mascota.IDCliente = reader.GetInt32(1)
                            mascota.IDRMascota = reader.GetInt32(2)
                            mascota.IDSeMascota = reader.GetInt32(3)
                            mascota.Nombre = reader.GetString(4)
                            mascota.Peso = If(reader.IsDBNull(5), Nothing, reader.GetDecimal(5))
                            mascota.Color = reader.GetString(6)
                            mascota.Esvacunado = If(reader.IsDBNull(7), Nothing, reader.GetBoolean(7))
                            mascota.Vacuna = If(reader.IsDBNull(8), Nothing, reader.GetDateTime(8))
                            mascota.VigVacuna = If(reader.IsDBNull(9), Nothing, reader.GetDateTime(9))
                            mascota.Foto = DirectCast(reader("Foto"), Byte())
                            mascota.Fallecido = If(reader.IsDBNull(11), Nothing, reader.GetBoolean(11))
                            mascota.IDTMascotaTIPOact = reader.GetInt32(12)


                            ' Asigna otros valores según las columnas correspondientes

                        End While
                    Else
                        ' No se encontraron resultados
                        Return Nothing
                    End If
                End Using
            End Using
        End Using

        Return mascota
    End Function




    Public Function Obtenerlistsexomascota() As List(Of Mascotas)
        Dim LISTASEXOMASCOTAS As New List(Of Mascotas)()

        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "SELECT * FROM SexoMascota where Estatus=1"
                command.CommandType = CommandType.Text

                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim sexomascotas As New Mascotas()
                        sexomascotas.IDSeMascotaSEX = reader.GetInt32(0)
                        sexomascotas.NombreSEX = reader.GetString(1)
                        ' Puedes agregar más propiedades según la estructura real de tu tabla de géneros
                        LISTASEXOMASCOTAS.Add(sexomascotas)
                    End While
                End Using
            End Using
        End Using

        Return LISTASEXOMASCOTAS
    End Function





    Public Function Obtenerlistipomascota() As List(Of Mascotas)
        Dim LISTATIPOMASCOTAS As New List(Of Mascotas)()

        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "SELECT * FROM TipoMascota where Estatus=1 order by Nombre asc "
                command.CommandType = CommandType.Text

                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim Tipomascotas As New Mascotas()
                        Tipomascotas.IDTMascotaTIPO = reader.GetInt32(0)
                        Tipomascotas.NombreTIPO = reader.GetString(1)
                        ' Puedes agregar más propiedades según la estructura real de tu tabla de géneros
                        LISTATIPOMASCOTAS.Add(Tipomascotas)
                    End While
                End Using
            End Using
        End Using

        Return LISTATIPOMASCOTAS
    End Function


    Public Function Obtenerrazamascotas(razamascota) As List(Of Mascotas)
        Dim LISTARAZAMASCOTAS As New List(Of Mascotas)()

        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "select * from RazaMascota
where IDRMascota=@idRmascota and Estatus=1
order by Nombre asc"
                command.Parameters.AddWithValue("@idRmascota", razamascota)
                command.CommandType = CommandType.Text

                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim Razamascotas As New Mascotas()
                        Razamascotas.IDRMascotaRAZA = reader.GetInt32(0)
                        Razamascotas.IDTMascotaRAZA = reader.GetInt32(1)
                        Razamascotas.NombreRAZA = reader.GetString(2)
                        ' Puedes agregar más propiedades según la estructura real de tu tabla de géneros
                        LISTARAZAMASCOTAS.Add(Razamascotas)
                    End While
                End Using
            End Using
        End Using

        Return LISTARAZAMASCOTAS


    End Function

    Public Function ObtenerrazaEDITARmascotas(razamascota) As List(Of Mascotas)
        Dim LISTARAZAMASCOTAS As New List(Of Mascotas)()

        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "select * from RazaMascota
where IDTMascota=@idTmascota and Estatus=1
order by Nombre asc"
                command.Parameters.AddWithValue("@idTmascota", razamascota)
                command.CommandType = CommandType.Text

                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim Razamascotas As New Mascotas()
                        Razamascotas.IDRMascotaRAZA = reader.GetInt32(0)
                        Razamascotas.IDTMascotaRAZA = reader.GetInt32(1)
                        Razamascotas.NombreRAZA = reader.GetString(2)
                        ' Puedes agregar más propiedades según la estructura real de tu tabla de géneros
                        LISTARAZAMASCOTAS.Add(Razamascotas)
                    End While
                End Using
            End Using
        End Using

        Return LISTARAZAMASCOTAS


    End Function

    Public Sub Insertarmascotas(idcliente, idrazamascota, sexomascota, nombre, peso, color, esvacunado, vacunainicio, vigvacuna, foto, IDUsuariocrea)

        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "INSERT INTO Mascota (IDCliente, IDRMascota, IDSeMascota, Nombre, Peso, Color, Esvacunado, Vacuna, VigVacuna, Foto, IdUsuarioCrea)
VALUES (@IDCliente, @IDRMascota, @IDSeMascota, @Nombre, @Peso, @Color, @Esvacunado, @Vacuna, @VigVacuna, @Foto, @idusuariocrea)"
                ' Asegúrate de configurar los parámetros correspondientes
                command.Parameters.AddWithValue("@IDCliente", idcliente)
                command.Parameters.AddWithValue("@IDRMascota", idrazamascota)
                command.Parameters.AddWithValue("@IDSeMascota", sexomascota)
                command.Parameters.AddWithValue("@Nombre", nombre)
                command.Parameters.AddWithValue("@Peso", peso)
                command.Parameters.AddWithValue("@Color", color)
                command.Parameters.AddWithValue("@Esvacunado", esvacunado)
                command.Parameters.AddWithValue("@Vacuna", vacunainicio)
                command.Parameters.AddWithValue("@VigVacuna", vigvacuna)
                command.Parameters.AddWithValue("@Foto", foto)
                command.Parameters.AddWithValue("@idusuariocrea", IDUsuariocrea)
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub




    Public Sub Editarrmascotas(idmascota, idcliente, idrazamascota, sexomascota, nombre, peso, color, esvacunado, vacunainicio, vigvacuna, foto, falleció, IDUsuarioModifica)

        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "UPDATE Mascota
SET 
IDCliente = @IDCliente,
IDRMascota = @IDRMascota,
IDSeMascota = @IDSeMascota,
Nombre = @Nombre,
Peso = @Peso,
Color = @Color,
Esvacunado = @Esvacunado,
Vacuna = @Vacuna,
VigVacuna = @VigVacuna,
Foto = @Foto,
Fallecido = @Fallecido,
IdUsuarioModifica=@idusuariomodifica,
FechaModifica=GETDATE()
WHERE IDMascota = @IDMascota"
                ' Asegúrate de configurar los parámetros correspondientes
                command.Parameters.AddWithValue("@IDMascota", idmascota)
                command.Parameters.AddWithValue("@IDCliente", idcliente)
                command.Parameters.AddWithValue("@IDRMascota", idrazamascota)
                command.Parameters.AddWithValue("@IDSeMascota", sexomascota)
                command.Parameters.AddWithValue("@Nombre", nombre)
                command.Parameters.AddWithValue("@Peso", peso)
                command.Parameters.AddWithValue("@Color", color)
                command.Parameters.AddWithValue("@Esvacunado", esvacunado)
                command.Parameters.AddWithValue("@Vacuna", vacunainicio)
                command.Parameters.AddWithValue("@VigVacuna", vigvacuna)
                command.Parameters.AddWithValue("@Foto", foto)
                command.Parameters.AddWithValue("@Fallecido", falleció)
                command.Parameters.AddWithValue("@idusuariomodifica", IDUsuarioModifica)
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub



    Public Function LlenarTipoServicio() As List(Of Servicios)
        Dim listtipodeServicio As New List(Of Servicios)()

        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "select*from tipoServicio where Estatus=1"
                command.CommandType = CommandType.Text

                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim tipoServicio As New Servicios()
                        tipoServicio.IdTipoServicio = reader.GetInt32(0)
                        tipoServicio.NombreTIPOServicio = reader.GetString(1)
                        ' Puedes agregar más propiedades según la estructura real de tu tabla de géneros
                        listtipodeServicio.Add(tipoServicio)
                    End While
                End Using
            End Using
        End Using

        Return listtipodeServicio


    End Function



    Public Sub InsertarServicio(TipoServicio, Nombre, Costo, idusuariocrea)

        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "INSERT INTO Servicio (TipoServicio, Nombre, Costo, IdUsuarioCrea)
VALUES (@TipoServicioID, @NombreServicio, @CostoServicio, @idusuariocrea)"
                ' Asegúrate de configurar los parámetros correspondientes
                command.Parameters.AddWithValue("@TipoServicioID", TipoServicio)
                command.Parameters.AddWithValue("@NombreServicio", Nombre)
                command.Parameters.AddWithValue("@CostoServicio", Costo)
                command.Parameters.AddWithValue("@idusuariocrea", idusuariocrea)
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub


    Public Function Buscarservicios() As List(Of Servicios)
        Dim servicioss As New List(Of Servicios)

        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "select
s.IDServicio,
t.Nombre as 'tipo de servicio',
s.Nombre,
s.Costo
from Servicio s
join
tipoServicio T on t.TipoServicio=s.TipoServicio
order by t.Nombre"
                Dim reader = command.ExecuteReader()

                If reader.HasRows Then
                    While reader.Read()
                        Dim servicios As New Servicios()
                        servicios.IDServicio = reader("IDServicio")
                        servicios.NombreTIPOServicio = reader("tipo de servicio")
                        servicios.Nombre = reader("Nombre")
                        servicios.Costo = reader("Costo")
                        servicioss.Add(servicios)
                    End While
                End If
            End Using
        End Using

        Return servicioss
    End Function


    Public Function MostrarServicio(idServicio) As Servicios
        Dim servicio As New Servicios()

        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = " select *from servicio
where IDServicio=@idservicio  and Estatus=1 "
                command.Parameters.AddWithValue("@idservicio", idServicio)
                command.CommandType = CommandType.Text

                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read()
                            ' Asignamos los valores al objeto Cliente
                            servicio.IDServicio = reader.GetInt32(0)
                            If Not reader.IsDBNull(1) Then
                                servicio.TipoServicio = reader.GetInt32(1)
                            End If
                            servicio.Nombre = reader.GetString(2)
                            servicio.Costo = If(reader.IsDBNull(3), String.Empty, reader.GetDecimal(3))
                            ' Asigna otros valores según las columnas correspondientes
                        End While
                    Else
                        ' No se encontraron resultados
                        Return Nothing
                    End If
                End Using
            End Using
        End Using

        Return servicio
    End Function



    Public Sub Editarservicio(idservicio, idtiposervicio, nombre, costo, IDUsuarioModifica)

        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "update Servicio
set
TipoServicio= @idtiposervicio,
Nombre= @nombre,
Costo=@costo,
IdUsuarioModifica=@idusuariomodifica,
FechaModifica=GETDATE()
where IDServicio=@idservicio"
                ' Asegúrate de configurar los parámetros correspondientes
                command.Parameters.AddWithValue("@idservicio", idservicio)
                command.Parameters.AddWithValue("@idtiposervicio", idtiposervicio)
                command.Parameters.AddWithValue("@nombre", nombre)
                command.Parameters.AddWithValue("@costo", costo)
                command.Parameters.AddWithValue("@idusuariomodifica", IDUsuarioModifica)
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()
            End Using
        End Using


    End Sub



    Public Function Mascotasparacitasdeclientes(idcliente) As List(Of Mascotas)
        Dim mascotass As New List(Of Mascotas)

        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "SELECT
IDMascota,
IDCliente,
Nombre AS NombreMascota,
Color
FROM
Mascota M
WHERE
IDCliente = @idcliente 
and fallecido=0"
                command.Parameters.AddWithValue("@idcliente", idcliente)
                command.CommandType = CommandType.Text
                Dim reader = command.ExecuteReader()

                If reader.HasRows Then
                    While reader.Read()
                        Dim cliente As New Mascotas()
                        cliente.idmascotalista = reader("IDMascota")
                        cliente.nombrelista = reader("NombreMascota")
                        cliente.colorlista = reader("Color")
                        mascotass.Add(cliente)
                    End While
                End If
            End Using
        End Using

        Return mascotass
    End Function


    Public Sub InsertarCita(idMascota, idhorario, idecita, fechacita, descripcion, IdUsuarioCrea)
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "INSERT INTO Cita (IDMascota, IDHorario, IDECita, Fechacita, Descripcion, IdUsuarioCrea)
VALUES (@IDMascota, @IDHorario, @IDECita, @Fechacita, @Descripcion, @idusuariocrea)"
                ' Asegúrate de configurar los parámetros correspondientes
                command.Parameters.AddWithValue("@IDMascota", idMascota)
                command.Parameters.AddWithValue("@IDHorario", idhorario)
                command.Parameters.AddWithValue("@IDECita", idecita)
                command.Parameters.AddWithValue("@Fechacita", fechacita)
                command.Parameters.AddWithValue("@Descripcion", descripcion)
                command.Parameters.AddWithValue("@idusuariocrea", IdUsuarioCrea)
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()
            End Using
        End Using


    End Sub


    Public Function obtenerHORARIOCITAS() As List(Of Citas)
        Dim listahorario As New List(Of Citas)()

        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "
SELECT 
IDHorario,
CONCAT(CONVERT(varchar(5), HoraInicio, 108), ' - ', CONVERT(varchar(5), HoraFin, 108)) AS HorarioCompleto
FROM 
Horario"
                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim horario As New Citas()
                        horario.idHORARIO = reader.GetInt32(0)
                        horario.HORARIOCOMPLETO = reader.GetString(1)
                        ' Puedes agregar más propiedades según la estructura real de tu tabla de géneros
                        listahorario.Add(horario)
                    End While
                End Using
            End Using
        End Using

        Return listahorario


    End Function



    'todas las citas


    Public Function cargarcitasprimerainstancia(fecha) As DataTable
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "select 
c.IDCita,
m.Nombre,
c.Fechacita,
CONCAT(CONVERT(varchar(5), h.HoraInicio, 108), ' - ', CONVERT(varchar(5), h.HoraFin, 108)) AS HorarioCompleto,
e.Estado
from Cita c
join
Mascota m on m.IDMascota=c.IDMascota
join
Horario h on h.IDHorario=c.IDHorario
join
Estadocita e on e.IDECita=c.IDECita
where c.Fechacita=@fechacita
order by Nombre asc"
                command.Parameters.AddWithValue("@fechacita", fecha)
                command.CommandType = CommandType.Text

                Dim dataTable As New DataTable()
                Using adapter As New SqlDataAdapter(command)
                    adapter.Fill(dataTable)
                End Using

                Return dataTable
            End Using
        End Using
    End Function

    'todas las citas pendientes
    Public Function cargarcitaspendientes(fecha) As DataTable
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "select 
c.IDCita,
m.Nombre,
c.Fechacita,
CONCAT(CONVERT(varchar(5), h.HoraInicio, 108), ' - ', CONVERT(varchar(5), h.HoraFin, 108)) AS HorarioCompleto,
e.Estado
from Cita c
join
Mascota m on m.IDMascota=c.IDMascota
join
Horario h on h.IDHorario=c.IDHorario
join
Estadocita e on e.IDECita=c.IDECita 
where c.Fechacita=@fechacita and e.Estado= 'Pendiente'
order by HorarioCompleto asc"
                command.Parameters.AddWithValue("@fechacita", fecha)
                command.CommandType = CommandType.Text

                Dim dataTable As New DataTable()
                Using adapter As New SqlDataAdapter(command)
                    adapter.Fill(dataTable)
                End Using

                Return dataTable
            End Using
        End Using
    End Function


    'todas las citas confirmadas
    Public Function cargarcitasconfirmadas(fecha) As DataTable
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "select 
c.IDCita,
m.Nombre,
c.Fechacita,
CONCAT(CONVERT(varchar(5), h.HoraInicio, 108), ' - ', CONVERT(varchar(5), h.HoraFin, 108)) AS HorarioCompleto,
e.Estado
from Cita c
join
Mascota m on m.IDMascota=c.IDMascota
join
Horario h on h.IDHorario=c.IDHorario
join
Estadocita e on e.IDECita=c.IDECita 
where c.Fechacita=@fechacita and e.Estado= 'Confirmada'
order by HorarioCompleto asc"
                command.Parameters.AddWithValue("@fechacita", fecha)
                command.CommandType = CommandType.Text

                Dim dataTable As New DataTable()
                Using adapter As New SqlDataAdapter(command)
                    adapter.Fill(dataTable)
                End Using

                Return dataTable
            End Using
        End Using
    End Function



    'todas las citas completadas
    Public Function cargarcitascompletadas(fecha) As DataTable
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "select 
c.IDCita,
m.Nombre,
c.Fechacita,
CONCAT(CONVERT(varchar(5), h.HoraInicio, 108), ' - ', CONVERT(varchar(5), h.HoraFin, 108)) AS HorarioCompleto,
e.Estado
from Cita c
join
Mascota m on m.IDMascota=c.IDMascota
join
Horario h on h.IDHorario=c.IDHorario
join
Estadocita e on e.IDECita=c.IDECita 
where c.Fechacita=@fechacita and e.Estado= 'Completada'
order by HorarioCompleto asc"
                command.Parameters.AddWithValue("@fechacita", fecha)
                command.CommandType = CommandType.Text

                Dim dataTable As New DataTable()
                Using adapter As New SqlDataAdapter(command)
                    adapter.Fill(dataTable)
                End Using

                Return dataTable
            End Using
        End Using
    End Function


    'todas las citas completadas
    Public Function cargarcitascanceladas(fecha) As DataTable
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "select 
c.IDCita,
m.Nombre,
c.Fechacita,
CONCAT(CONVERT(varchar(5), h.HoraInicio, 108), ' - ', CONVERT(varchar(5), h.HoraFin, 108)) AS HorarioCompleto,
e.Estado
from Cita c
join
Mascota m on m.IDMascota=c.IDMascota
join
Horario h on h.IDHorario=c.IDHorario
join
Estadocita e on e.IDECita=c.IDECita 
where c.Fechacita=@fechacita and e.Estado= 'Cancelada'
order by HorarioCompleto asc"
                command.Parameters.AddWithValue("@fechacita", fecha)
                command.CommandType = CommandType.Text

                Dim dataTable As New DataTable()
                Using adapter As New SqlDataAdapter(command)
                    adapter.Fill(dataTable)
                End Using

                Return dataTable
            End Using
        End Using
    End Function


    'mostrar al darle dobleclick al datagridview
    Public Function mostrarcita(idcita) As Citas
        Dim cliente As New Citas()

        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "select c.IDCita,
c.Fechacita,
c.IDHorario,
c.IDECita,
c.Descripcion as descripcioncita,
cl.PrimerNombre,
cl.SegundoNombre,
cl.ApellidoPaterno,
cl.ApellidoMaterno,
cl.Email,
cl.TelCasa,
cl.Celular,
cl.TelTrabajo,
cl.TelExterno,
cl.Descripcion,
m.Nombre,
m.Peso,
r.Nombre as razanombre,
t.Nombre as tiponombre,
s.Nombre as sexonombre,
m.Esvacunado,
m.Vacuna,
m.VigVacuna
from
Cita c
join
Estadocita e on  e.IDECita=c.IDECita
join
Mascota m on m.IDMascota=c.IDMascota
join
SexoMascota s on s.IDSeMascota=m.IDSeMascota
join
RazaMascota r on r.IDRMascota=m.IDRMascota
join
TipoMascota t on t.IDTMascota=r.IDTMascota
join
Cliente cl on cl.IDCliente=m.IDCliente
where c.IDCita=@idcita"
                command.Parameters.AddWithValue("@idcita", idcita)
                command.CommandType = CommandType.Text

                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read()
                            ' Asignamos los valores al objeto cita
                            cliente.idcita = reader.GetInt32(0)
                            cliente.fechacita = If(reader.IsDBNull(1), DateTime.MinValue, reader.GetDateTime(1))
                            cliente.idhorariocita = reader.GetInt32(2)
                            cliente.idecita = reader.GetInt32(3)
                            cliente.descripcioncita = If(reader.IsDBNull(4), String.Empty, reader.GetString(4))
                            cliente.primernombre = If(reader.IsDBNull(5), String.Empty, reader.GetString(5))
                            cliente.segundonombre = If(reader.IsDBNull(6), String.Empty, reader.GetString(6))
                            cliente.apellidopatern = reader.GetString(7)
                            cliente.apellidomatern = If(reader.IsDBNull(8), String.Empty, reader.GetString(8))
                            cliente.email = If(reader.IsDBNull(9), String.Empty, reader.GetString(9))
                            cliente.telcasa = If(reader.IsDBNull(10), String.Empty, reader.GetString(10))
                            cliente.celular = If(reader.IsDBNull(11), String.Empty, reader.GetString(11))
                            cliente.teltrabajo = If(reader.IsDBNull(12), String.Empty, reader.GetString(12))
                            cliente.telexterno = If(reader.IsDBNull(13), String.Empty, reader.GetString(13))
                            cliente.descripcioncliente = If(reader.IsDBNull(14), String.Empty, reader.GetString(14))

                            cliente.nombremascota = reader.GetString(15)
                            cliente.mascotapeso = If(reader.IsDBNull(16), Nothing, reader.GetDecimal(16))
                            cliente.razamascota = reader.GetString(17)
                            cliente.tipomascota = reader.GetString(18)
                            cliente.sexomascota = reader.GetString(19)

                            cliente.esvacunado = If(reader.IsDBNull(20), Nothing, reader.GetBoolean(20))
                            cliente.iniciovacuna = If(reader.IsDBNull(21), Nothing, reader.GetDateTime(21))
                            cliente.vigvacuna = If(reader.IsDBNull(22), Nothing, reader.GetDateTime(22))


                            ' Asigna otros valores según las columnas correspondientes

                        End While
                    Else
                        ' No se encontraron resultados
                        Return Nothing
                    End If
                End Using
            End Using
        End Using

        Return cliente
    End Function

    Public Function LlenarEstadoCita() As List(Of Citas)
        Dim listtipodeServicio As New List(Of Citas)()

        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "select *from Estadocita where Estatus=1"
                command.CommandType = CommandType.Text

                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim estadocitas As New Citas()
                        estadocitas.idESTADOCITA = reader.GetInt32(0)
                        estadocitas.ESTADOSCITASCOMPLETO = reader.GetString(1)
                        ' Puedes agregar más propiedades según la estructura real de tu tabla de géneros
                        listtipodeServicio.Add(estadocitas)
                    End While
                End Using
            End Using
        End Using

        Return listtipodeServicio


    End Function



    Public Sub EditarEstadoCita(idcita, idecita, IDUsuarioModifica)

        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "UPDATE Cita
SET
IDECita=@idecita,
IdUsuarioModifica=@idusuariomodifica,
FechaModifica=GETDATE()
where IDCita=@idcita"
                ' Asegúrate de configurar los parámetros correspondientes
                command.Parameters.AddWithValue("@idcita", idcita)
                command.Parameters.AddWithValue("@idecita", idecita)
                command.Parameters.AddWithValue("@idusuariomodifica", IDUsuarioModifica)
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub




    Public Sub EditarCita(idcita, idhorario, fechacita, descripcion, IdUsuarioModifica)

        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "UPDATE Cita
SET IDHorario = @idhorario,
    Fechacita = @fechacita,
    Descripcion = @descripcion,
	IdUsuarioModifica=@idusuariomodifica,
	FechaModifica=GETDATE()
WHERE IDCita = @idcita"
                ' Asegúrate de configurar los parámetros correspondientes
                command.Parameters.AddWithValue("@idcita", idcita)
                command.Parameters.AddWithValue("@idhorario", idhorario)
                command.Parameters.AddWithValue("@fechacita", fechacita)
                command.Parameters.AddWithValue("@descripcion", descripcion)
                command.Parameters.AddWithValue("@idusuariomodifica", IdUsuarioModifica)
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub InsertarRazaMascota(IdTipoMascota, Nombre, IdUsuarioCrea)

        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "insert into RazaMascota(IDTMascota,Nombre,IdUsuarioCrea)
values (@idtmascota,@mascota,@IDUsuarioCrea)"
                ' Asegúrate de configurar los parámetros correspondientes
                command.Parameters.AddWithValue("@idtmascota", IdTipoMascota)
                command.Parameters.AddWithValue("@mascota", Nombre)
                command.Parameters.AddWithValue("@IDUsuarioCrea", IdUsuarioCrea)
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub




    Public Function BuscarRazayTipoDeMascotas() As List(Of Mascotas)
        Dim mascotass As New List(Of Mascotas)

        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "
select
RazaMascota.IDRMascota,
TipoMascota.Nombre as NombretipoMascota,
RazaMascota.Nombre as NombreRazaMascota
from RazaMascota
join
TipoMascota on TipoMascota.IDTMascota=RazaMascota.IDTMascota
order by TipoMascota.Nombre,RazaMascota.Nombre"
                command.CommandType = CommandType.Text
                Dim reader = command.ExecuteReader()

                If reader.HasRows Then
                    While reader.Read()
                        Dim cliente As New Mascotas()
                        cliente.IDRMascotalista = reader("IDRMascota")
                        cliente.NombretipoMascotalista = reader("NombretipoMascota")
                        cliente.NombreRazaMascotalista = reader("NombreRazaMascota")
                        mascotass.Add(cliente)
                    End While
                End If
            End Using
        End Using

        Return mascotass
    End Function

    Public Function MostrarRaza(idraza) As Mascotas
        Dim servicio As New Mascotas()

        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "select*from RazaMascota where IDRMascota=@idrmascota and Estatus=1"
                command.Parameters.AddWithValue("@idrmascota", idraza)
                command.CommandType = CommandType.Text

                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read()
                            ' Asignamos los valores al objeto Cliente
                            servicio.idrmascota2 = reader.GetInt32(0)
                            If Not reader.IsDBNull(1) Then
                                servicio.idtmascota2 = reader.GetInt32(1)
                            End If
                            servicio.nombreraza2 = reader.GetString(2)
                        End While
                    Else
                        ' No se encontraron resultados
                        Return Nothing
                    End If
                End Using
            End Using
        End Using

        Return servicio
    End Function



    Public Sub EditarRaza(IdRmazcota, IdTMascota, nombre, IdUsuarioModifica)

        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "update RazaMascota
set
IDTMascota=@idtmascota,
Nombre=@nombrerazamascota,
IdUsuarioModifica=@IdUsuarioModifica,
FechaModifica=GETDATE()
where IDRMascota=@idrmascota"
                ' Asegúrate de configurar los parámetros correspondientes
                command.Parameters.AddWithValue("@idrmascota", IdRmazcota)
                command.Parameters.AddWithValue("@idtmascota", IdTMascota)
                command.Parameters.AddWithValue("@nombrerazamascota", nombre)
                command.Parameters.AddWithValue("@IdUsuarioModifica", IdUsuarioModifica)
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()
            End Using
        End Using


    End Sub


    Public Function ObtenerRolesUsuarios() As List(Of Roles)
        Dim LISTATIPOROLES As New List(Of Roles)()

        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "select*from rol"
                command.CommandType = CommandType.Text

                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim TipoRoles As New Roles()
                        TipoRoles.idroles = reader.GetInt32(0)
                        TipoRoles.NombreRoles = reader.GetString(1)
                        ' Puedes agregar más propiedades según la estructura real de tu tabla de géneros
                        LISTATIPOROLES.Add(TipoRoles)
                    End While
                End Using
            End Using
        End Using

        Return LISTATIPOROLES
    End Function
    Public Sub InsertarUsuario(PrimerNombre, SegundoNombre, ApellidoPaterno, ApellidoMaterno, Email, Usuario, contraseña, idrol)
        Try
            Using connection = GetConnection()
                connection.Open()
                Using command = New SqlCommand()
                    command.Connection = connection
                    command.CommandText = "INSERT INTO Trabajador (PrimerNombre, SegundoNombre, ApellidoPaterno, ApellidoMaterno, Email, Usuario, Contraseña, IDRol, FCreacion)
VALUES (@PrimerNombre, @SegundoNombre, @ApellidoPaterno, @ApellidoMaterno, @Email, @Usuario,EncryptByPassPhrase('petpalace', CONVERT(varbinary, @Contraseña)), @IDRol, GETDATE())"
                    command.Parameters.AddWithValue("@PrimerNombre", PrimerNombre)
                    command.Parameters.AddWithValue("@SegundoNombre", SegundoNombre)
                    command.Parameters.AddWithValue("@ApellidoPaterno", ApellidoPaterno)
                    command.Parameters.AddWithValue("@ApellidoMaterno", ApellidoMaterno)
                    command.Parameters.AddWithValue("@Email", Email)
                    command.Parameters.AddWithValue("@Usuario", Usuario)
                    command.Parameters.AddWithValue("@Contraseña", contraseña)
                    command.Parameters.AddWithValue("@IDRol", idrol)
                    command.CommandType = CommandType.Text
                    command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
        End Try
    End Sub




    Public Function ObtenerServiciosdeTIPOS(TipoServicio) As List(Of Servicios)
        Dim LISTASERVICIOS As New List(Of Servicios)()

        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "select * from Servicio
where TipoServicio=@IdTServicios and Estatus=1
order by Nombre asc"
                command.Parameters.AddWithValue("@IdTServicios", TipoServicio)
                command.CommandType = CommandType.Text

                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim Servicios As New Servicios()
                        Servicios.IDServicioTIPO = reader.GetInt32(0)
                        Servicios.IDTServicioTipo = reader.GetInt32(1)
                        Servicios.NombreServicio = reader.GetString(2)
                        ' Puedes agregar más propiedades según la estructura real de tu tabla de géneros
                        LISTASERVICIOS.Add(Servicios)
                    End While
                End Using
            End Using
        End Using

        Return LISTASERVICIOS


    End Function

    Public Function MostrarCostoServicio(IdServicio) As Servicios
        Dim cliente As New Servicios()

        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "select Costo from Servicio where IDServicio=@IdServicios"
                command.Parameters.AddWithValue("@IdServicios", IdServicio)
                command.CommandType = CommandType.Text

                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read()
                            ' Asignamos los valores al objeto Cliente
                            cliente.CostoServicio = reader.GetDecimal(0)
                        End While
                    Else
                        ' No se encontraron resultados
                        Return Nothing
                    End If
                End Using
            End Using
        End Using

        Return cliente
    End Function

    Public Sub InsertarDetallesCitasServicios(IdCita, IdServicio, IdUsuarioCrea)
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "INSERT INTO DetallesCitaServicio (IDCita,IDServicio,IdUsuarioCrea) 
VALUES (@Idcita,@IdServicio,@IdUsuarioCrea)"
                ' Asegúrate de configurar los parámetros correspondientes
                command.Parameters.AddWithValue("@Idcita", IdCita)
                command.Parameters.AddWithValue("@IdServicio", IdServicio)
                command.Parameters.AddWithValue("@IdUsuarioCrea", IdUsuarioCrea)

                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()
            End Using
        End Using


    End Sub


    Public Function ObtenerServiciosDetallesCitas(idcita As Integer) As DataTable
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "SELECT DetallesCitaServicio.IDDetallesCS AS Codigo,
tipoServicio.Nombre AS 'Tipo de Servicio',
Servicio.Nombre AS 'Nombre de Servicio',
ROUND(Servicio.Costo, 2) AS 'Precio'
FROM DetallesCitaServicio
JOIN Servicio ON Servicio.IDServicio = DetallesCitaServicio.IDServicio
JOIN tipoServicio ON tipoServicio.TipoServicio = Servicio.TipoServicio
JOIN Cita ON cita.IDCita = DetallesCitaServicio.IDCita
WHERE Cita.IDCita = @idcita and DetallesCitaServicio.Estatus=1"
                command.Parameters.AddWithValue("@idcita", idcita)
                command.CommandType = CommandType.Text

                Dim dataTable As New DataTable()
                Using adapter As New SqlDataAdapter(command)
                    adapter.Fill(dataTable)
                End Using

                ' Truncar los últimos dos dígitos decimales en la columna 'Precio'
                For Each row As DataRow In dataTable.Rows
                    Dim precio As Decimal = Convert.ToDecimal(row("Precio"))
                    row("Precio") = Math.Floor(precio * 100) / 100
                Next

                Return dataTable
            End Using
        End Using
    End Function


    Public Function CargarHistorialCitas(idmascota) As DataTable
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "select 
c.IDCita,
m.Nombre,
c.Fechacita,
CONCAT(CONVERT(varchar(5), h.HoraInicio, 108), ' - ', CONVERT(varchar(5), h.HoraFin, 108)) AS HorarioCompleto,
e.Estado
from Cita c
join
Mascota m on m.IDMascota=c.IDMascota
join
Horario h on h.IDHorario=c.IDHorario
join
Estadocita e on e.IDECita=c.IDECita
where m.IDMascota=@idmascota
order by c.Fechacita asc"
                command.Parameters.AddWithValue("@idmascota", idmascota)
                command.CommandType = CommandType.Text

                Dim dataTable As New DataTable()
                Using adapter As New SqlDataAdapter(command)
                    adapter.Fill(dataTable)
                End Using

                Return dataTable
            End Using
        End Using
    End Function

    Public Function MostrarCostototal(idcita As Integer) As Servicios
        Dim Servicio As New Servicios()

        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "SELECT ROUND(SUM(servicio.costo), 2) AS TOTAL
FROM DetallesCitaServicio
JOIN Servicio ON Servicio.IDServicio = DetallesCitaServicio.IDServicio
JOIN tipoServicio ON tipoServicio.TipoServicio = Servicio.TipoServicio
JOIN Cita ON cita.IDCita = DetallesCitaServicio.IDCita
WHERE Cita.IDCita = @idcita and DetallesCitaServicio.Estatus=1"
                command.Parameters.AddWithValue("@idcita", idcita)
                command.CommandType = CommandType.Text

                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read()
                            If Not IsDBNull(reader("TOTAL")) Then
                                Dim costoConDecimales As Decimal = reader.GetDecimal(0)
                                ' Truncar los últimos dos dígitos decimales
                                Servicio.CostoTOTAL = Math.Floor(costoConDecimales * 100) / 100
                            End If
                        End While
                    Else
                        ' No se encontraron resultados
                        Return Nothing
                    End If
                End Using
            End Using
        End Using

        Return Servicio
    End Function

    Public Sub EliminarServicio(idDetalleServicio, idusuariomodifica)
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "update DetallesCitaServicio
SET
Estatus=0,
IdUsuarioModifica=@idusuariomodifica,
FechaModifica=GETDATE()
WHERE IDDetallesCS = @iddetallescita"
                ' Asegúrate de configurar los parámetros correspondientes
                command.Parameters.AddWithValue("@iddetallescita", idDetalleServicio)
                command.Parameters.AddWithValue("@idusuariomodifica", idusuariomodifica)
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()
            End Using
        End Using


    End Sub



End Class








