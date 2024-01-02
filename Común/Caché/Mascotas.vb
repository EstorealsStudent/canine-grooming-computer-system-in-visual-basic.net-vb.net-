Public Class Mascotas


    Public Property IDMascota As Integer
    Public Property IDCliente As Integer
    Public Property IDRMascota As Integer
    Public Property IDSeMascota As Integer?
    Public Property Nombre As String
    Public Property Peso As Decimal?
    Public Property Color As String
    Public Property Esvacunado As Boolean?
    Public Property Vacuna As DateTime?
    Public Property VigVacuna As DateTime?
    Public Property Foto As Byte()
    Public Property Fallecido As Boolean?
    Public Property FCreacion As DateTime?

    Public Property IDTMascotaTIPOact

    'TIPOMASCOTA
    Public Property IDTMascotaTIPO
    Public Property NombreTIPO

    'SexoMascota
    Public Property IDSeMascotaSEX
    Public Property NombreSEX

    'Razamascota
    Public Property IDRMascotaRAZA
    Public Property IDTMascotaRAZA
    Public Property NombreRAZA


End Class
