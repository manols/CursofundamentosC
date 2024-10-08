--create database CursoFundamentos
go

use CursoFundamentos
go

--drop table if exists cervezas_backup
--EXEC sp_rename 'cerveza', 'cervezas_backup';
--go

-- 2. Crear una nueva tabla con la columna Id como IDENTITY
CREATE TABLE cerveza (
    Id INT IDENTITY(1,1) NOT NULL,
    nombre NVARCHAR(100),
    marca NVARCHAR(100),
    alcohol INT,
    cantidad INT
);

go

-- 3. Transferir los datos de la tabla original a la nueva tabla
INSERT INTO cerveza (nombre, marca, alcohol, cantidad)
SELECT nombre, marca, alcohol, cantidad
FROM cerveza;

go

INSERT INTO cerveza (nombre, marca, alcohol, cantidad)
SELECT 'Stout', 'Quilmes', 4, 350	union
SELECT 'Rubia', 'Stella Artois', 6, 1000 union
SELECT 'Noir', 'Stella Artois', 4, 350 union
SELECT 'Roja', 'Andes', 5, 1000 union


-- 4. (Opcional) Verificar los datos en la nueva tabla
SELECT * FROM cerveza;
