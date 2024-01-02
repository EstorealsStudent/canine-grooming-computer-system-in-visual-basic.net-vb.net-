Imports System.Data.SqlClient

Public Class Conexionsql2

    Private ConnectionString As String
    Protected Sub New()
        ConnectionString = "Server=DESKTOP-6KRE00N\SQLEXPRESS;DataBase=EsteticaCanina; integrated security= true"
    End Sub
    Protected Function GetConnection() As SqlConnection
        Return New SqlConnection(connectionString)
    End Function

End Class
