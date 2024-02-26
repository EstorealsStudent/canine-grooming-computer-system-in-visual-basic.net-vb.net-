create database EsteticaCanina
GO
Use EsteticaCanina
GO

create table roles(
IDRol int identity (1,1)Primary key,
Nombre Varchar(15),
FCreacion smalldatetime
)

create table Trabajador(
IDTrabajador int identity (1,1)Primary key,
--Nombres
PrimerNombre Varchar(30),
SegundoNombre Varchar(30) NULL,
ApellidoPaterno Varchar(30),
ApellidoMaterno Varchar(30) NULL,
Email Varchar(50) ,
Usuario Varchar(15) UNIQUE,
Contrase�a varbinary(MAX),
IDRol int,
FCreacion smalldatetime

constraint fk_rol_trabajador foreign key (IDRol) references roles(IDRol)
)
create table Genero(
IDGenero int identity (1,1)Primary key,
NombreGenero Varchar(20),
activo bit,
 IdUsuarioCrea INT,
 FechaCrea DATETIME DEFAULT GETDATE(),
 IdUsuarioModifica INT NULL,
 FechaModifica DATETIME DEFAULT NULL

CONSTRAINT  FK_GeneroUsuarioCrea FOREIGN KEY  (IdUsuarioCrea) REFERENCES Trabajador(IDTrabajador),
CONSTRAINT  FK_GeneroUsuarioModifica FOREIGN KEY  (IdUsuarioModifica) REFERENCES Trabajador(IDTrabajador)
)


Create table Clientes(
IDCliente int identity (1,1)Primary key,
IDGenero int null,
--Datos generales
PrimerNombre Varchar(30),
SegundoNombre Varchar(30) null,
ApellidoPaterno Varchar(30),
ApellidoMaterno Varchar(30)null,
RFC Varchar(30) null,
CURP Varchar(30) null,
--CONTACTO
Celular Varchar(20) null,
TelCasa Varchar(20)null,
TelTrabajo Varchar(20) null ,
TelExterno Varchar(20) null,
Email Varchar(60) null,
--Direccion
Calle Varchar(50)null,
NumeroExt Varchar(50)null,
Colonia Varchar(50)null,
Municipio Varchar(30)null,
CodigoPostal Varchar(10)null,
Estado Varchar(30) null,
--
Descripci�n Varchar(Max)null ,
 IdUsuarioCrea INT,
 FechaCrea DATETIME DEFAULT GETDATE(),
 IdUsuarioModifica INT NULL,
 FechaModifica DATETIME DEFAULT NULL

constraint Fk_cliente_Genero foreign key (IDGenero) references Genero(IDGenero),
CONSTRAINT  FK_ClientesuarioCrea FOREIGN KEY  (IdUsuarioCrea) REFERENCES Trabajador(IDTrabajador),
CONSTRAINT  FK_ClienteUsuarioModifica FOREIGN KEY  (IdUsuarioModifica) REFERENCES Trabajador(IDTrabajador)
)


create table TipoMascota(
IDTMascota int identity (1,1)Primary key,
Nombre Varchar(20),
 IdUsuarioCrea INT,
 FechaCrea DATETIME DEFAULT GETDATE(),
 IdUsuarioModifica INT NULL,
 FechaModifica DATETIME DEFAULT NULL

 CONSTRAINT  FK_TipoUsuarioCrea FOREIGN KEY  (IdUsuarioCrea) REFERENCES Trabajador(IDTrabajador),
CONSTRAINT  FK_TipoUsuarioModifica FOREIGN KEY  (IdUsuarioModifica) REFERENCES Trabajador(IDTrabajador)
)

create table RazaMascota(
IDRMascota int identity (1,1)Primary key,
IDTMascota int,
Nombre Varchar(20),
 IdUsuarioCrea INT,
 FechaCrea DATETIME DEFAULT GETDATE(),
 IdUsuarioModifica INT NULL,
 FechaModifica DATETIME DEFAULT NULL

constraint Fk_raza_tipo foreign key (IDTMascota) references TipoMascota(IDTMascota),
CONSTRAINT  FK_RazaMascotaUsuarioCrea FOREIGN KEY  (IdUsuarioCrea) REFERENCES Trabajador(IDTrabajador),
CONSTRAINT  FK_RazaMascotaUsuarioModifica FOREIGN KEY  (IdUsuarioModifica) REFERENCES Trabajador(IDTrabajador)
)

create table SexoMascota(
IDSeMascota int identity (1,1)Primary key,
Nombre Varchar(20),
 IdUsuarioCrea INT,
 FechaCrea DATETIME DEFAULT GETDATE(),
 IdUsuarioModifica INT NULL,
 FechaModifica DATETIME DEFAULT NULL

 CONSTRAINT  FK_SexoMascotaUsuarioCrea FOREIGN KEY  (IdUsuarioCrea) REFERENCES Trabajador(IDTrabajador),
CONSTRAINT  FK_SexoMascotaooUsuarioModifica FOREIGN KEY  (IdUsuarioModifica) REFERENCES Trabajador(IDTrabajador)

)



create table Mascota(
IDMascota int identity (1,1)Primary key,
IDCliente int,
IDRMascota int,
IDSeMascota int,
Nombre Varchar(50),
Peso Decimal(5,3),
Color Varchar(30),
Esvacunado bit null,
Vacuna Date,
VigVacuna Date,
foto varbinary(max) null,
fallecido bit null,
 IdUsuarioCrea INT,
 FechaCrea DATETIME DEFAULT GETDATE(),
 IdUsuarioModifica INT NULL,
 FechaModifica DATETIME DEFAULT NULL

constraint Fk_Mascota_Cliente foreign key (IDCliente) references Clientes(IDCliente),
constraint Fk_Rmascota_Mascota foreign key (IDRMascota) references RazaMascota(IDRMascota),
constraint Fk_sexmascota_Mascota foreign key (IDSeMascota) references SexoMascota(IDSeMascota),
CONSTRAINT  FK_MascotaUsuarioCrea FOREIGN KEY  (IdUsuarioCrea) REFERENCES Trabajador(IDTrabajador),
CONSTRAINT  FK_MascotaUsuarioModifica FOREIGN KEY  (IdUsuarioModifica) REFERENCES Trabajador(IDTrabajador)

)

create table Horario(
IDHorario int identity (1,1)Primary key,
HoraInicio time,
HoraFin time,
Activo bit,
 IdUsuarioCrea INT,
 FechaCrea DATETIME DEFAULT GETDATE(),
 IdUsuarioModifica INT NULL,
 FechaModifica DATETIME DEFAULT NULL

 CONSTRAINT  FK_HorarioUsuarioCrea FOREIGN KEY  (IdUsuarioCrea) REFERENCES Trabajador(IDTrabajador),
CONSTRAINT  FK_HorarioUsuarioModifica FOREIGN KEY  (IdUsuarioModifica) REFERENCES Trabajador(IDTrabajador)
)

create table Estadocita(
IDECita int identity (1,1)Primary key,
Estado varchar(20),
 IdUsuarioCrea INT,
 FechaCrea DATETIME DEFAULT GETDATE(),
 IdUsuarioModifica INT NULL,
 FechaModifica DATETIME DEFAULT NULL

 CONSTRAINT  FK_EsatadoUsuarioCrea FOREIGN KEY  (IdUsuarioCrea) REFERENCES Trabajador(IDTrabajador),
CONSTRAINT  FK_EstadoUsuarioModifica FOREIGN KEY  (IdUsuarioModifica) REFERENCES Trabajador(IDTrabajador)
)

create table Cita(
IDCita int identity (1,1)Primary key,
IDMascota int,
IDHorario int,
IDECita int,
Fechacita date,
Descripcion Varchar(MAX) null,
 IdUsuarioCrea INT,
 FechaCrea DATETIME DEFAULT GETDATE(),
 IdUsuarioModifica INT NULL,
 FechaModifica DATETIME DEFAULT NULL

constraint Fk_Cita_Mascota foreign key (IDMascota) references Mascota(IDMascota),
constraint Fk_Cita_Horario foreign key (IDHorario) references Horario(IDHorario),
constraint Fk_Cita_Estado foreign key (IDECita) references Estadocita(IDECita),
CONSTRAINT  FK_CitaUsuarioCrea FOREIGN KEY  (IdUsuarioCrea) REFERENCES Trabajador(IDTrabajador),
CONSTRAINT  FK_CitaUsuarioModifica FOREIGN KEY  (IdUsuarioModifica) REFERENCES Trabajador(IDTrabajador)
)

create table tipoServicio(
TipoServicio int identity (1,1)Primary key,
Nombre varchar(30),
 IdUsuarioCrea INT,
 FechaCrea DATETIME DEFAULT GETDATE(),
 IdUsuarioModifica INT NULL,
 FechaModifica DATETIME DEFAULT NULL

 CONSTRAINT  FK_TipoServicioUsuarioCrea FOREIGN KEY  (IdUsuarioCrea) REFERENCES Trabajador(IDTrabajador),
CONSTRAINT  FK_TipoServicioUsuarioModifica FOREIGN KEY  (IdUsuarioModifica) REFERENCES Trabajador(IDTrabajador)
)

create table Servicios(
IDServicio int identity (1,1)Primary key,
TipoServicio int,
Nombre varchar(30),
Costo Money,
 IdUsuarioCrea INT,
 FechaCrea DATETIME DEFAULT GETDATE(),
 IdUsuarioModifica INT NULL,
 FechaModifica DATETIME DEFAULT NULL

constraint Fk_servicios_Tipos foreign key (TipoServicio) references tipoServicio(TipoServicio),
CONSTRAINT  FK_ServiciosUsuarioCrea FOREIGN KEY  (IdUsuarioCrea) REFERENCES Trabajador(IDTrabajador),
CONSTRAINT  FK_ServiciosUsuarioModifica FOREIGN KEY  (IdUsuarioModifica) REFERENCES Trabajador(IDTrabajador)
)

Create table DetallesCitaServicios(
IDDetallesCS int identity (1,1)Primary key,
IDServicio int,
IDCita int,
IdUsuarioCrea INT,
FechaCrea DATETIME DEFAULT GETDATE()

constraint Fk_DetallesCitaServicios foreign key (IDServicio) references Servicios(IDServicio),
constraint Fk_DetallesCitaServicios2 foreign key (IDCita) references Cita(IDCita),
CONSTRAINT  FK_DetallesCitaServiciosuarioCrea FOREIGN KEY  (IdUsuarioCrea) REFERENCES Trabajador(IDTrabajador)
)

