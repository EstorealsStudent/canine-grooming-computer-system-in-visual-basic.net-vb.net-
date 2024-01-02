Public Class Conectionsql
    'La variable conexion es la que permite conectarnos a nuestro SQL
    'data source= donde esta conectada nuestra base de datos
    Public conexion As New SqlClient.SqlConnection("data source=DESKTOP-6KRE00N\SQLEXPRESS; initial catalog= EsteticaCanina; integrated security= SSPI; persist security info= false; trusted_connection = yes;")
    'Nos permite ejecutar los comandos que  tienen que ver con los procedimientos
    'almacenados de sql
    Public cmd As SqlClient.SqlCommand
    'permite leer los datos
    Public sqlread As SqlClient.SqlDataReader
    Public Query As String

End Class
