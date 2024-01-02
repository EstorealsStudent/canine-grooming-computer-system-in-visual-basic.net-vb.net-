
Imports System.Data.SqlClient
Imports Común
Public Class UsuarioDAO
    Inherits Conexionsql2

    Public Sub EditProfile(id, user, pass, name, lastName, mail)
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "update Trabajador set Usuario=@user, Contraseña=@pass, PrimerNombre=@name, ApellidoPaterno=@lastName, Email=@mail where IDTrabajador=@id"
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
                command.CommandText = "  select *from Trabajador where Usuario=@Usuario or Email=@Email"
                command.Parameters.AddWithValue("@Usuario", requestingUser)
                command.Parameters.AddWithValue("@Email", requestingUser)
                command.CommandType = CommandType.Text
                Dim reader As SqlDataReader = command.ExecuteReader()

                If reader.Read() = True Then
                    Dim userName As String = reader.GetString(6) & ", " + reader.GetString(3)
                    Dim userMail As String = reader.GetString(5)
                    Dim accountPassword As String = reader.GetString(7)

                    Dim systemSupport = New SupportDeEmail()
                    systemSupport.sendMail(
          subject:="SISTEMA: Recupar Contraseña.",
          body:="Hola " & userName & vbLf & "Solicitaste Recupar tú contraseña." & vbLf &
          "Tú contraseña es: " & accountPassword & vbLf &
          "Sin embargo, Entrando nuevamente al sistema, puedes cambiar tu contraseña.",
          receiverMail:=New List(Of String) From {userMail}
          )

                    Return "Hola! " & userName & vbLf & "Solicitaste Recuperar tu contraseña." & vbLf &
          "Porfavor, Revisa tu Correo: " & vbLf & userMail & vbLf


                Else
                    Return "Losiento, No existe una cuenta con este Nombre de usuario O Correo Electronico."
                End If

            End Using
        End Using
    End Function













    Public Function Login(user As String, pass As String) As Boolean
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "select *from Trabajador where Usuario=@Usuario and Contraseña= @Contraseña"
                command.Parameters.AddWithValue("@Usuario", user)
                command.Parameters.AddWithValue("@Contraseña", pass)
                command.CommandType = CommandType.Text
                Dim reader = command.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read() 'Obtenemos los datos de la columna y asignamos a los campos de usuario activo en cache'
                        UsuarioActivo.idUser = reader.GetInt32(0)
                        UsuarioActivo.Usuario = reader.GetString(6)
                        UsuarioActivo.Contraseña = reader.GetString(7)
                        UsuarioActivo.PrimerNombre = reader.GetString(1)
                        UsuarioActivo.ApellidoP = reader.GetString(3)
                        UsuarioActivo.Rol = reader.GetString(8)
                        UsuarioActivo.email = reader.GetString(5)
                    End While
                    reader.Dispose()
                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
    End Function

    Public Function ExistsUser(id As Integer, loginName As String, pass As String) As Boolean
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "select *from Trabajador where IDTrabajador=@Usuario"
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
FROM Clientes;"
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
                command.CommandText = "
SELECT
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
    c.Descripción,
    c.FCreacion,
	g.NombreGenero
FROM
    Clientes c
JOIN
    Genero g ON c.IDGenero = g.IDGenero
	where c.IDCliente = @idclientes
"
                command.Parameters.AddWithValue("@idclientes", idclientes)
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
                            cliente.FCreacion = reader.GetDateTime(20)
                            cliente.NombreGenero = reader.GetString(21)


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
                command.CommandText = "SELECT * FROM Genero"
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

    Public Sub InsertarCliente(IDGenero, PrimerNombre, SegundoNombre, ApellidoPaterno, ApellidoMaterno, RFC, CURP, Celular, TelCasa, TelTrabajo, TelExterno, Email, Calle, NumeroExt, Colonia, Municipio, CodigoPostal, Estado, Descripcion)

        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = " INSERT INTO Clientes (IDGenero,PrimerNombre, segundonombre, ApellidoPaterno, ApellidoMaterno, RFC, CURP, Celular, TelCasa, TelTrabajo, TelExterno, Email, Calle, NumeroExt, Colonia, Municipio, CodigoPostal, Estado, Descripción, FCreacion) 
 VALUES (@IDGenero,@PrimerNombre, @SegundoNombre, @ApellidoPaterno, @ApellidoMaterno, @RFC, @CURP, @Celular, @TelCasa, @TelTrabajo, @TelExterno, @Email, @Calle, @NumeroExt, @Colonia, @Municipio, @CodigoPostal, @Estado, @Descripcion, GETDATE())"
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
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()
            End Using
        End Using


    End Sub


    Public Sub EditarClientes(id, IDGenero, PrimerNombre, SegundoNombre, ApellidoPaterno, ApellidoMaterno, RFC, CURP, Celular, TelCasa, TelTrabajo, TelExterno, Email, Calle, NumeroExt, Colonia, Municipio, CodigoPostal, Estado, Descripcion)

        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "UPDATE Clientes SET IDGenero = @genero, PrimerNombre = @primerNombre,SegundoNombre = @segundoNombre,ApellidoPaterno = @ApellidoPaterno,ApellidoMaterno = @ApellidoMaterno,
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
Descripción = @Descripcion WHERE IDCliente = @IdCliente"
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
                command.CommandText = "SELECT * FROM SexoMascota "
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
                command.CommandText = "SELECT * FROM TipoMascota order by Nombre asc"
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
where IDRMascota=@idRmascota
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
where IDTMascota=@idTmascota
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


    Public Sub Insertarmascotas(idcliente, idrazamascota, sexomascota, nombre, peso, color, esvacunado, vacunainicio, vigvacuna, foto, falleció)

        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "INSERT INTO Mascota (IDCliente, IDRMascota, IDSeMascota, Nombre, Peso, Color, Esvacunado, Vacuna, VigVacuna, Foto, Fallecido, FCreacion)
VALUES (@IDCliente, @IDRMascota, @IDSeMascota, @Nombre, @Peso, @Color, @Esvacunado, @Vacuna, @VigVacuna, @Foto, @Fallecido, GETDATE())"
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

                command.Parameters.AddWithValue("@Fallecido", falleció)
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub




    Public Sub Editarrmascotas(idmascota, idcliente, idrazamascota, sexomascota, nombre, peso, color, esvacunado, vacunainicio, vigvacuna, foto, falleció)

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
Fallecido = @Fallecido
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
                command.CommandText = "select*from tipoServicio"
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



    Public Sub InsertarServicio(TipoServicio, Nombre, Costo)

        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "INSERT INTO Servicios (TipoServicio, Nombre, Costo, FCreacion)
VALUES (@TipoServicioID, @NombreServicio, @CostoServicio, GETDATE())"
                ' Asegúrate de configurar los parámetros correspondientes
                command.Parameters.AddWithValue("@TipoServicioID", TipoServicio)
                command.Parameters.AddWithValue("@NombreServicio", Nombre)
                command.Parameters.AddWithValue("@CostoServicio", Costo)
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
from Servicios s
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
                command.CommandText = " select *from servicios
where IDServicio=@idservicio  "
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



    Public Sub Editarservicio(idservicio, idtiposervicio, nombre, costo)

        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "update Servicios
set
TipoServicio= @idtiposervicio,
Nombre= @nombre,
Costo=@costo
where IDServicio=@idservicio"
                ' Asegúrate de configurar los parámetros correspondientes
                command.Parameters.AddWithValue("@idservicio", idservicio)
                command.Parameters.AddWithValue("@idtiposervicio", idtiposervicio)
                command.Parameters.AddWithValue("@nombre", nombre)
                command.Parameters.AddWithValue("@costo", costo)
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()
            End Using
        End Using


    End Sub

End Class








