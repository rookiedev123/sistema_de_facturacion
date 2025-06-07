
-- Crear la tabla de usuarios si aún no existe
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usuarios]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[usuarios](
        [id_usuario] [INT] IDENTITY(1,1) NOT NULL,
        [nombre] [NVARCHAR](100) NOT NULL,
        [fecha_creacion] [DATETIME] NOT NULL,
        [perfil] [NVARCHAR](50) NOT NULL,
        [contraseña] [NVARCHAR](100) NOT NULL,
        PRIMARY KEY CLUSTERED ([id_usuario] ASC)
    );
END 
    
-- Insertar un usuario para cada perfil con nombres y apellidos ficticios y contraseñas hasheadas
INSERT INTO [dbo].[usuarios] ([nombre], [apellido], [fecha_creacion], [perfil], [contraseña])
VALUES 
('Juan', 'Pérez', GETDATE(), 'Admin', HASHBYTES('SHA2_256', 'Admin01')),
('María', 'Gómez', GETDATE(), 'Jefe', HASHBYTES('SHA2_256', 'Admin01')),
('José', 'Martínez', GETDATE(), 'Supervisor', HASHBYTES('SHA2_256', 'Admin01')),
('Luis', 'García', GETDATE(), 'Vendedor', HASHBYTES('SHA2_256', 'Admin01'));


--Se valida la tabla usuarios este creada y con los registros agregados 
Select * from users


--creamos la tabla clientes si aún no existe
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[clientes]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[clientes](
        [clienteId] [INT] IDENTITY(1,1) NOT NULL,
        [document] [INT] NOT NULL,
        [creado_en] [DATETIME] NOT NULL,
        [nombres] [NVARCHAR](100) NOT NULL,
        [apellidos] [VARCHAR](100) NOT NULL,
        PRIMARY KEY CLUSTERED ([clienteId] ASC)
    );
END

-- Crear tabla reporte_pagos_deudas si aún no existe
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[reporte_pagos_deudas]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[reporte_pagos_deudas](
        [clienteId] [INT] NOT NULL,
        [fecha_pago] [DATE] NOT NULL,
        [pago] [DECIMAL](10, 2) NOT NULL,
        [deuda] [DECIMAL](10, 2) NOT NULL,
        PRIMARY KEY CLUSTERED ([clienteId] ASC, [fecha_pago] ASC),
        FOREIGN KEY ([clienteId]) REFERENCES [dbo].[clientes]([clienteId])
    );
END

-- Insertar 100 clientes ficticios
DECLARE @i INT = 1;
WHILE @i <= 100
BEGIN
    INSERT INTO [dbo].[clientes] ([document], [creado_en], [nombres], [apellidos])
    VALUES (CAST(FLOOR(RAND() * 99999999) AS INT), GETDATE(), 'Nombre ' + CAST(@i AS NVARCHAR(10)), 'Apellido ' + CAST(@i AS NVARCHAR(10)));

    INSERT INTO [dbo].[reporte_pagos_deudas] ([clienteId], [fecha_pago], [pago], [deuda])
    VALUES (@i, DATEADD(DAY, -CAST(FLOOR(RAND() * 365) AS INT), GETDATE()), CAST(FLOOR(RAND() * 1000) AS DECIMAL(10, 2)), CAST(FLOOR(RAND() * 1000) AS DECIMAL(10, 2)));

    SET @i = @i + 1;
END

--Actualizamos la tabla clientes con nombres ficticios
IF NOT EXISTS (SELECT * FROM sys.columns WHERE Name = N'apellidos' AND Object_ID = Object_ID(N'[dbo].[clientes]'))
BEGIN
    ALTER TABLE [dbo].[clientes] ADD [apellidos] [NVARCHAR](100) NOT NULL;
END

-- Actualizar nombres y apellidos de los clientes existentes
DECLARE @i INT = 1;
DECLARE @max INT = (SELECT COUNT(*) FROM [dbo].[clientes]);
DECLARE @nombres TABLE (nombre NVARCHAR(100));
DECLARE @apellidos TABLE (apellido NVARCHAR(100));

-- Insertar nombres y apellidos ficticios
INSERT INTO @nombres VALUES ('Juan'), ('María'), ('José'), ('Luis'), ('Fernando'), ('Carlos'), ('Isabel');
INSERT INTO @apellidos VALUES ('Pérez'), ('Gómez'), ('Martínez'), ('García'), ('Ramos'), ('Díaz');

WHILE @i <= @max
BEGIN
    DECLARE @nombre NVARCHAR(100);
    DECLARE @apellido NVARCHAR(100);

    -- Seleccionar nombre y apellido aleatorios
    SELECT TOP 1 @nombre = nombre FROM @nombres ORDER BY NEWID();
    SELECT TOP 1 @apellido = apellido FROM @apellidos ORDER BY NEWID();

    -- Actualizar en la tabla clientes
    UPDATE [dbo].[clientes]
    SET [nombres] = @nombre, [apellidos] = @apellido
    WHERE [clienteId] = @i;

    SET @i = @i + 1;
END

-- validamos la tabla clientes
select * from clientes;





-- Insertar pagos y deudas para cada cliente existente
DECLARE @i INT = 1;
WHILE @i <= (SELECT COUNT(*) FROM [dbo].[clientes])
BEGIN
    DECLARE @clienteId INT = (SELECT TOP 1 clienteId FROM [dbo].[clientes] WHERE clienteId > 0 ORDER BY NEWID());
    DECLARE @fechaPago DATE = DATEADD(DAY, -CAST(FLOOR(RAND() * 365) AS INT), GETDATE());
    DECLARE @pago DECIMAL(10, 2) = CAST(FLOOR(RAND() * 1000) AS DECIMAL(10, 2));
    DECLARE @deuda DECIMAL(10, 2) = CAST(FLOOR(RAND() * 1000) AS DECIMAL(10, 2));
    DECLARE @fechaUltimoPago DATE = DATEADD(MONTH, -1, GETDATE());
    DECLARE @fechaProximoPago DATE = DATEADD(MONTH, 1, @fechaUltimoPago);
    DECLARE @montoPago DECIMAL(10, 2) = @pago + @deuda;
    DECLARE @nombres NVARCHAR(100);
    DECLARE @apellidos NVARCHAR(100);

    SELECT TOP 1 @nombres = nombres FROM [dbo].[clientes] WHERE clienteId = @clienteId;
    SELECT TOP 1 @apellidos = apellidos FROM [dbo].[clientes] WHERE clienteId = @clienteId;

    INSERT INTO [dbo].[reporte_pagos_deudas] ([clienteId], [fecha_pago], [pago], [deuda], [nombres], [apellidos], [fecha_ultimo_pago], [fecha_proximo_pago], [monto_pago])
    VALUES (@clienteId, @fechaPago, @pago, @deuda, @nombres, @apellidos, @fechaUltimoPago, @fechaProximoPago, @montoPago);

    SET @i = @i + 1;
END

-- validamos la tabla reporte pagos_deudas
select  * from reporte_pagos_deudas;
DELETE FROM [dbo].[reporte_pagos_deudas];
DROP TABLE [dbo].[reporte_pagos_deudas];
EXEC sp_help 'reporte_pagos_deudas';