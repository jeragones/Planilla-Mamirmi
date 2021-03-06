Use master
GO
-- DROP DATABASE [Mamirmi] 
CREATE DATABASE [Mamirmi]
GO

USE [Mamirmi]
GO


--////////////////////////	EMPLEADOS	//////////////////
-- select * from [Empleado]
CREATE TABLE [dbo].[Empleado]
(
	[ID] [varchar](30) primary key NOT NULL,
	[nombre][varchar](30) NOT NULL,
	[apellidos] [varchar](30) NOT NULL,
	[carne] [varchar] (10)  not null,
	[fecha_Ingreso] [date] not null,
	[fecha_Salida] [date] null,
	[departamento] [varchar] (20),
	[estado] [bit] not null,
	[cuenta_BN] [varchar](15),
	[cuenta_BP] [varchar](15),
	[numeroComprobante][int]
)
GO

/*
ALTER TABLE [dbo].[Empleado]
	ADD CONSTRAINT FK_Usuario_Empleado
	FOREIGN KEY (ID) 
	REFERENCES Usuario(IdPersona)
	ON DELETE CASCADE
	
*/
	--////////////////////////	USUARIOS	//////////////////
-- select * from [Usuario]
CREATE TABLE [dbo].[Usuario](
	[IdPersona] [varchar](30) NOT NULL,	
	[Usuario] [varchar](250) NOT NULL,
	[Contraseña] [varchar](100) NOT NULL,
	[TipoUsuario] [int] NOT NULL,
	)
GO

ALTER TABLE [dbo].[Usuario]
ADD CONSTRAINT PK_IdPersona_Usuario
	PRIMARY KEY (IdPersona) 
GO

--///////////////////////////////////////////procedure//////////////////
--///////////////////////////////////////////procedure//////////////////
--///////////////////////////////////////////procedure//////////////////
Go
 --drop procedure [dbo].[InsertarEmpleado]
CREATE PROCEDURE [dbo].[InsertarEmpleado]
	@ID [varchar](30),
	@nombre[varchar](30), 
	@apellidos [varchar](30),
	@carne [varchar] (10),
	@fecha_Ingreso date, 
	@fecha_Salida date, 
	@departamento [varchar], 
	@estado [bit],
	@cuenta_BN [varchar](15), 
	@cuenta_BP [varchar](15),
	@numeroComprobante[int]
AS
BEGIN
	insert into 
	Empleado(ID,nombre,apellidos,carne,fecha_Ingreso,fecha_Salida,departamento,estado,cuenta_BN,cuenta_BP,numeroComprobante) 
		values (@ID,@nombre, @apellidos,@carne, @fecha_Ingreso, @fecha_Salida, @departamento, @estado,@cuenta_BN, @cuenta_BP,@numeroComprobante)
END
GO
--///////////////////////////////////////////TEST//////////////////
--///////////////////////////////////////////TEST//////////////////
--///////////////////////////////////////////TEST//////////////////

insert Usuario(IdPersona,Usuario,Contraseña,TipoUsuario) values('1','randall','123',2)
GO

