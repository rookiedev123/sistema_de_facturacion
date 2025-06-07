Select * from Users

IF NOT EXISTS (SELECT * FROM sys.tables WHERE Name = 'Users')
BEGIN
    CREATE TABLE Users (
        User_Id INT PRIMARY KEY IDENTITY(1,1),
        Nombre VARCHAR(100) NOT NULL,
        Password VARCHAR(255) NOT NULL,
        Email VARCHAR(100)
    );
END

INSERT INTO Users (Nombre, Password, Email)
VALUES 
('Juan Pérez', 'Admin01', 'juan.perez@example.com'),
('Carlos Fuentes', 'Admin01', 'carlos.fuentes@example.com'),
('María García', 'Admin01', 'maria.garcia@example.com'),
('Luis Rodríguez', 'Admin01', 'luis.rodriguez@example.com'),
('Isabella Martínez', 'Admin01', 'isabella.martinez@example.com');

IF NOT EXISTS (SELECT * FROM sys.columns WHERE Name = 'Perfil' AND Object_ID = Object_ID('Users'))
BEGIN
    ALTER TABLE Users ADD Perfil NVARCHAR(50) DEFAULT 'Vendedor';
END;

INSERT INTO Users (Nombre, Password, Email, Perfil)
VALUES 
('Juan Pérez', 'Admin01', 'juan.perez@example.com', 'Administrador'),
('Carlos Fuentes', 'Admin01', 'carlos.fuentes@example.com', 'Supervisor'),
('María García', 'Admin01', 'maria.garcia@example.com', 'Vendedor'),
('Luis Rodríguez', 'Admin01', 'luis.rodriguez@example.com', 'Vendedor'),
('Isabella Martínez', 'Admin01', 'isabella.martinez@example.com', 'Vendedor');

DELETE FROM Users WHERE Perfil IS NULL;