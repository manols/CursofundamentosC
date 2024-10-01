USE [master];
GO
--
------- Creo el login ------
CREATE LOGIN usuarioCursoFundamentos
WITH PASSWORD = 'abc123';
GO

------ Creo el usurio ------
USE CursoFundamentos;
GO

CREATE USER usuarioCursoFundamentos
FOR LOGIN usuarioCursoFundamentos;
GO

------ Asigno permisos al usurio ------
USE CursoFundamentos;
GO

GRANT CONNECT TO usuarioCursoFundamentos;
GRANT SELECT, INSERT, UPDATE, DELETE, EXECUTE TO usuarioCursoFundamentos;
GO

/********************************************************************************************/
---- Chequeo permisos ----

USE CursoFundamentos;
GO

SELECT 
    pr.name AS Usuario,
    pr.type_desc AS Tipo,
    pe.permission_name AS Permiso,
    pe.state_desc AS Estado,
    obj.name AS Objeto
FROM 
    sys.database_principals pr
LEFT JOIN 
    sys.database_permissions pe ON pe.grantee_principal_id = pr.principal_id
LEFT JOIN 
    sys.objects obj ON obj.object_id = pe.major_id
WHERE 
    pr.name = 'usuarioCursoFundamentos';


