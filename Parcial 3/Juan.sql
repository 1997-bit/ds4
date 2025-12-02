CREATE DATABASE Juan;
GO

USE Juan;
GO

CREATE TABLE JG_Casos (
    Id INT PRIMARY KEY IDENTITY(1,1),
    NumeroCaso VARCHAR(20) NOT NULL,
    ClienteNombre NVARCHAR(100) NOT NULL,
    Descripcion NVARCHAR(500),
    AbogadoAsignado NVARCHAR(100),
    FechaInicio DATE DEFAULT GETDATE(),
    FechaVencimiento DATE,
    Estado VARCHAR(50) DEFAULT 'Activo',
    Observaciones NVARCHAR(1000)
);

select * from JG_Casos;