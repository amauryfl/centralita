CREATE DATABASE CentralitaDB;

USE CentralitaDB;

CREATE TABLE Llamadas (
    Id INT PRIMARY KEY IDENTITY(1,1),
    NumeroOrigen VARCHAR(20) NOT NULL,
    NumeroDestino VARCHAR(20) NOT NULL,
    Duracion INT NOT NULL,
    Costo DECIMAL(10,2) NOT NULL
);

INSERT INTO Llamadas (NumeroOrigen, NumeroDestino, Duracion, Costo)
VALUES 
('809-111-1111', '809-222-2222', 60, 9.00),
('809-333-3333', '809-444-4444', 120, 24.00);