CREATE DATABASE Basenotas

USE Basenotas  -- Reemplaza con el nombre de tu BD
GO

CREATE TABLE Notes (
    Id BIGINT PRIMARY KEY IDENTITY(1,1),
    Title NVARCHAR(200) NOT NULL,
    Content NVARCHAR(MAX),
    CreatedAt DATETIME NOT NULL DEFAULT GETDATE(),
    UpdatedAt DATETIME NULL,
    IsArchived BIT NOT NULL DEFAULT 0
);
GO

-- Datos de ejemplo
INSERT INTO Notes (Title, Content) VALUES
('Recordatorio importante', 'Comprar regalo para cumpleaños'),
('Ideas de proyecto', 'Investigar sobre APIs REST, crear documentación'),
('Lista de compras', 'Leche, huevos, pan, frutas, verduras');
GO

drop table Notes


IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'Basenotas')
BEGIN
    CREATE DATABASE Basenotas;
END
GO

USE Basenotas;
GO

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Notas')
BEGIN
    CREATE TABLE Notas (
        Id INT PRIMARY KEY IDENTITY(1,1),
        Titulo NVARCHAR(100) NOT NULL,
        Contenido NVARCHAR(MAX),
        FechaCreacion DATETIME DEFAULT GETDATE(),
        UltimaModificacion DATETIME DEFAULT GETDATE()
    );
    
    INSERT INTO Notas (Titulo, Contenido) 
    VALUES ('Mi primera nota', 'Este es el contenido de prueba.'),
           ('Recordatorio', 'Comprar leche y pan.');
END
GO


Select * from  Notas