drop table if exists cervezas_backup
EXEC sp_rename 'cerveza', 'cervezas_backup';

-- 2. Crear una nueva tabla con la columna Id como IDENTITY
CREATE TABLE cerveza (
    Id INT IDENTITY(1,1) NOT NULL,
    nombre NVARCHAR(100),
    marca NVARCHAR(100),
    alcohol INT,
    cantidad INT
);

-- 3. Transferir los datos de la tabla original a la nueva tabla
INSERT INTO cerveza (nombre, marca, alcohol, cantidad)
SELECT nombre, marca, alcohol, cantidad
FROM cervezas_backup;

-- 4. (Opcional) Verificar los datos en la nueva tabla
SELECT * FROM cerveza;