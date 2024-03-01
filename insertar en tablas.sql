
INSERT INTO rol (Nombre, FCreacion)
VALUES
    ('Administrador', GETDATE()),  -- 1
    ('Recepcionista', GETDATE()),--2
    ('Estilista', GETDATE());--3
GO
  -- Insertar informacion
  
INSERT INTO Trabajador (PrimerNombre, ApellidoPaterno, Email, Usuario, Clave, IDRol, FCreacion)
VALUES
    ('Nombre1', 'Apellido1', 'email1@example.com', 'Administrador', EncryptByPassPhrase('petpalace', CONVERT(nvarchar, 'admin')), 1, GETDATE());
GO

INSERT INTO Genero (NombreGenero, activo, IdUsuarioCrea) VALUES
('Masculino', 1, 1),
('Femenino', 1, 1),
('No Binario', 1, 1),
('Prefiero no decir', 1, 1),
('Otro', 1, 1);
GO

INSERT INTO TipoMascota (Nombre, IdUsuarioCrea) VALUES
('Perro', 1),--1
('Gato', 1)--2
GO
-- Insertar datos en la tabla RazaMascota
INSERT INTO RazaMascota (IDTMascota, Nombre, IdUsuarioCrea) VALUES
(2, 'Siames', 1)
GO
INSERT INTO RazaMascota (IDTMascota, Nombre, IdUsuarioCrea) VALUES
(1, 'Labrador', 1),
(1, 'Bulldog',1),
(1, 'Poodle', 1),
(1, 'Husky', 1),
(1, 'Golden Retriever', 1);
GO
-- Insertar datos en la tabla SexoMascota
INSERT INTO SexoMascota (Nombre, IdUsuarioCrea) VALUES
('Macho', 1),
('Hembra', 1);
GO
-- Insertar datos en la tabla Mascota
INSERT INTO Estadocita (Estado, IdUsuarioCrea) VALUES ('Pendiente', 1);
INSERT INTO Estadocita (Estado, IdUsuarioCrea) VALUES ('Confirmada',1);
INSERT INTO Estadocita (Estado, IdUsuarioCrea) VALUES ('Cancelada',1);
INSERT INTO Estadocita (Estado, IdUsuarioCrea) VALUES ('Completada',1);

GO

INSERT INTO tipoServicio (Nombre, IdUsuarioCrea) VALUES 
('Adicional', 1),
('Express', 1),
('Premium',1),
('VIP', 1);
GO
--llenar la tabla de horario
DECLARE @HoraInicio time = '10:00:00';
DECLARE @HoraFin time = '21:00:00';
DECLARE @Intervalo int = 1;

-- Usar un bucle WHILE para generar intervalos de 1 hora
WHILE @HoraInicio <= @HoraFin
BEGIN
    INSERT INTO Horario (HoraInicio, HoraFin, IdUsuarioCrea)
    VALUES (@HoraInicio, DATEADD(HOUR, @Intervalo, @HoraInicio), 1);

    -- Añadir 1 hora al inicio para el próximo intervalo
    SET @HoraInicio = DATEADD(HOUR, @Intervalo, @HoraInicio);
END;
GO
--TRIGGER

CREATE TRIGGER Trigger_ValidarCita
ON Cita
INSTEAD OF INSERT
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM inserted i
        JOIN Cita c ON i.IDHorario = c.IDHorario AND i.Fechacita = c.Fechacita
        WHERE i.IDECita IN (1, 2)
    )
    BEGIN
        RAISERROR ('No se puede insertar la cita porque ya existe otra cita en el mismo horario y fecha con IDECita igual a 1 o 2.', 16, 1)
    END
    ELSE
    BEGIN
        INSERT INTO Cita (IDMascota, IDHorario, IDECita, Fechacita, Descripcion, IdUsuarioCrea)
        SELECT IDMascota, IDHorario, IDECita, Fechacita, Descripcion, IdUsuarioCrea
        FROM inserted;
    END
END;
GO

GO

-- Crear servicios para cada tipo de servicio
DECLARE @AdicionalID INT, @ExpressID INT, @PremiumID INT, @VIPID INT;

-- Obtener los IDs de los tipos de servicio
SELECT @AdicionalID = TipoServicio FROM tipoServicio WHERE Nombre = 'Adicional';
SELECT @ExpressID = TipoServicio FROM tipoServicio WHERE Nombre = 'Express';
SELECT @PremiumID = TipoServicio FROM tipoServicio WHERE Nombre = 'Premium';
SELECT @VIPID = TipoServicio FROM tipoServicio WHERE Nombre = 'VIP';

-- Insertar 5 servicios adicionales
INSERT INTO Servicio (TipoServicio, Nombre, Costo, IdUsuarioCrea) 
VALUES 
(@AdicionalID, 'Servicio Adicional 1', 10.00, 1),
(@AdicionalID, 'Servicio Adicional 2', 15.00, 1),
(@AdicionalID, 'Servicio Adicional 3', 20.00, 1),
(@AdicionalID, 'Servicio Adicional 4', 12.50, 1),
(@AdicionalID, 'Servicio Adicional 5', 18.75, 1);

-- Insertar 5 servicios express
INSERT INTO Servicio (TipoServicio, Nombre, Costo, IdUsuarioCrea) 
VALUES 
(@ExpressID, 'Servicio Express 1', 25.00, 1),
(@ExpressID, 'Servicio Express 2', 30.00, 1),
(@ExpressID, 'Servicio Express 3', 35.00, 1),
(@ExpressID, 'Servicio Express 4', 28.50, 1),
(@ExpressID, 'Servicio Express 5', 32.75, 1);

-- Insertar 5 servicios premium
INSERT INTO Servicio (TipoServicio, Nombre, Costo, IdUsuarioCrea) 
VALUES 
(@PremiumID, 'Servicio Premium 1', 50.00, 1),
(@PremiumID, 'Servicio Premium 2', 55.00, 1),
(@PremiumID, 'Servicio Premium 3', 60.00, 1),
(@PremiumID, 'Servicio Premium 4', 52.50, 1),
(@PremiumID, 'Servicio Premium 5', 57.25, 1);

-- Insertar 5 servicios VIP
INSERT INTO Servicio (TipoServicio, Nombre, Costo, IdUsuarioCrea) 
VALUES 
(@VIPID, 'Servicio VIP 1', 100.00,1),
(@VIPID, 'Servicio VIP 2', 110.00, 1),
(@VIPID, 'Servicio VIP 3', 120.00, 1),
(@VIPID, 'Servicio VIP 4', 105.00, 1),
(@VIPID, 'Servicio VIP 5', 115.75, 1);
GO
--INDICES
-- Trabajador-- Trabajador
CREATE INDEX IX_Trabajador_Usuario ON Trabajador(Usuario);
CREATE INDEX IX_Trabajador_Email ON Trabajador(Email);

-- Clientes
CREATE INDEX IX_Cliente_IDGenero ON Clientes(IDGenero);

-- Mascota
CREATE INDEX IX_Mascota_IDCliente ON Mascota(IDCliente);
CREATE INDEX IX_Mascota_IDRMascota ON Mascota(IDRMascota);
CREATE INDEX IX_Mascota_IDSeMascota ON Mascota(IDSeMascota);

-- Cita
CREATE INDEX IX_Cita_IDMascota ON Cita(IDMascota);
CREATE INDEX IX_Cita_IDHorario ON Cita(IDHorario);
CREATE INDEX IX_Cita_IDECita ON Cita(IDECita);

-- DetallesCitaServicios
CREATE INDEX IX_DetallesCitaServicio_IDServicio ON DetallesCitaServicio(IDServicio);
CREATE INDEX IX_DetallesCitaServicio_IDCita ON DetallesCitaServicio(IDCita);

-- RazaMascota
CREATE INDEX IX_RazaMascota_IDTMascota ON RazaMascota(IDTMascota);
go