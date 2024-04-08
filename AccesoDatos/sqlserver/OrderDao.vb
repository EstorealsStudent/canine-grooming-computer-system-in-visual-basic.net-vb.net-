Imports System.Data.SqlClient

Public Class OrderDao
    Inherits Conexionsql2
    Public Function GetBestSellingProducts(fromDate As DateTime, toDate As DateTime) As DataTable
        Dim table As New DataTable()

        Try
            Using connection = GetConnection()
                connection.Open()
                Using command = New SqlCommand()
                    command.Connection = connection
                    command.CommandText = "SELECT 
    s.IDServicio, 
    CONCAT(Ts.nombre, ' - ', s.Nombre) AS NombreServicio, 
    s.costo AS CostoUnitario,
    COUNT(*) AS TotalVendido,
    SUM(s.Costo) AS CostoTotal
FROM 
    Servicio s
INNER JOIN 
    tipoServicio Ts ON s.TipoServicio = Ts.TipoServicio
INNER JOIN 
    DetallesCitaServicio dcs ON s.IDServicio = dcs.IDServicio
INNER JOIN 
    Cita c ON dcs.IDCita = c.IDCita
INNER JOIN 
    Estadocita ec ON c.IDECita = ec.IDECita
WHERE 
    ec.Estado = 'Completada' AND dcs.estatus = 1
    AND c.Fechacita BETWEEN @FechaInicio AND @FechaFin
GROUP BY 
    s.IDServicio, Ts.nombre, s.Nombre, s.costo 
ORDER BY 
    TotalVendido DESC"
                    command.Parameters.Add("@FechaInicio", SqlDbType.Date).Value = fromDate
                    command.Parameters.Add("@FechaFin", SqlDbType.Date).Value = toDate
                    command.CommandType = CommandType.Text

                    Using reader = command.ExecuteReader()
                        table.Load(reader)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error en la conexión: " & ex.Message)
        End Try

        Return table
    End Function

End Class
