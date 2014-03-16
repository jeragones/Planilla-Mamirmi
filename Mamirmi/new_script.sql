USE [master]
GO

CREATE DATABASE [Mamirmi]
GO

USE [Mamirmi]
GO


-- drop TABLE [dbo].[Persona]
CREATE TABLE [dbo].[Persona]
(
	[ID] int identity primary key,
	[nombre]	[varchar](30) NOT NULL,
	[apellidos] [varchar](30) NOT NULL,
	[edad]		int NOT NULL,
	[nacionalidad][varchar](30),
	[EstadoCivil][varchar](30) default 'Soltero',
	[direccion] [varchar](200),
	[sexo]		[varchar](30) NOT NULL,
	[Hijos]		int default 0,
	[fecha_de_ingreso] datetime not null
)
GO

USE [master]
GO

ALTER DATABASE [Mamirmi] SET  READ_WRITE 
GO
