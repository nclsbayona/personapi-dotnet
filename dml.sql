-- Seleccionamos la base de datos persona_db
USE [persona_db]
GO
-- Table persona
INSERT INTO [dbo].[persona]
           ([cc]
           ,[nombre]
           ,[apellido]
           ,[genero]
           ,[edad])
     VALUES
           (1001109876
           ,'Juan'
           ,'Casas'
           ,'M'
           ,28)
GO
INSERT INTO [dbo].[persona]
           ([cc]
           ,[nombre]
           ,[apellido]
           ,[genero]
           ,[edad])
     VALUES
           (1011109876
           ,'Emma'
           ,'Lopez'
           ,'F'
           ,23)
GO
INSERT INTO [dbo].[persona]
           ([cc]
           ,[nombre]
           ,[apellido]
           ,[genero]
           ,[edad])
     VALUES
           (1001179876
           ,'John'
           ,'Torres'
           ,'M'
           ,33)
GO

-- Table profesion
INSERT INTO [dbo].[profesion]
           ([id]
           ,[nom]
           ,[des])
     VALUES
           (1
           ,'Medico'
           ,'Soy medico')
GO
INSERT INTO [dbo].[profesion]
           ([id]
           ,[nom]
           ,[des])
     VALUES
           (2
           ,'Economista'
           ,'Soy economista')
GO
INSERT INTO [dbo].[profesion]
           ([id]
           ,[nom]
           ,[des])
     VALUES
           (3
           ,'Psicologo'
           ,'Soy psicologo')
GO


-- Table telefono
INSERT INTO [dbo].[telefono]
           ([num]
           ,[oper]
           ,[duenio])
     VALUES
           ('5765249182'
           ,'Claro'
           ,1001109876)
GO
INSERT INTO [dbo].[telefono]
           ([num]
           ,[oper]
           ,[duenio])
     VALUES
           ('2765249182'
           ,'Tigo'
           ,1011109876)
GO
INSERT INTO [dbo].[telefono]
           ([num]
           ,[oper]
           ,[duenio])
     VALUES
           ('5768149182'
           ,'Wom'
           ,1001179876)
GO


-- Table estudios
INSERT INTO [dbo].[estudios]
           ([id_prof]
           ,[cc_per]
           ,[fecha]
           ,[univer])
     VALUES
           (1
           ,1001179876
           ,'1912-10-25'
           ,'Universidad A')
GO