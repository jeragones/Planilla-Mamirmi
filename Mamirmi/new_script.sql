USE [master]
GO

select * from Persona

select * from Empleado


-- DROP DATABASE [Mamirmi] 
CREATE DATABASE [Mamirmi]
GO

USE [Mamirmi]
GO

-- drop TABLE [dbo].[Persona]
CREATE TABLE [dbo].[Persona]
(
	[ID] [varchar](30) primary key NOT NULL,
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

CREATE TABLE [dbo].[Empleado](
	--[id] [tinyint] NOT NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Personaid] [varchar](30) NOT NULL,
	[cuenta_BN] [varchar](15) NOT NULL,
	[cuenta_BP] [varchar](15) NOT NULL,
	[Profesion] [varchar] (20) not null,
	[Estudios] [varchar] (11) not null,
	[Manipulacion_Alimentos] [varchar] (100) not null,
	[Enfermedades] [varchar] (150) not null,
	[carne] [varchar] (10) not null,
	[experiencia] [varchar] (10) not null,
	[fecha_Ingreso] [varchar] (11) not null,
	[departamento][varchar](20) not null,
	[descripcion_Salida][varchar](100) null,
	[fecha_Salida][varchar](11) null,
	[estado] [varchar](10) not null default 'Activo'
 CONSTRAINT [pk_ID_Empleado] PRIMARY KEY CLUSTERED 
(
	[id] ASC,
	[Personaid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Empleado]
	ADD CONSTRAINT FK_Empleado_Personaid
	FOREIGN KEY (Personaid) 
	REFERENCES Persona(ID)
	ON DELETE CASCADE
GO

-- Nueva tabla usuario 
CREATE TABLE [dbo].[Usuario](
	[IdPersona] [varchar](30) NOT NULL,	
	[Usuario] [varchar](250) NOT NULL,
	[Contraseña] [varchar](100) NOT NULL,
	[TipoUsuario] [int] NOT NULL
	)
GO

ALTER TABLE [dbo].[Usuario]
ADD CONSTRAINT PK_IdPersona_Usuario
	PRIMARY KEY (IdPersona) 
GO
		
ALTER TABLE [dbo].[Usuario]
	ADD CONSTRAINT FK_Usuario_Persona
	FOREIGN KEY (IdPersona) 
	REFERENCES Persona (id)
	ON DELETE CASCADE

--///////////////////////////////////////////procedure//////////////////
--///////////////////////////////////////////procedure//////////////////
--///////////////////////////////////////////procedure//////////////////
Go

CREATE PROCEDURE [dbo].[InsertarEmpleado]
	@idper [char](12),
	@cuentabn [varchar](15),
	@cuentabp [varchar](15),
	@profesion [varchar] (20),
	@estudios [varchar] (11),
	@manipulacionesA [varchar] (100),
	@enfermedades [varchar] (150),
	@carne [varchar] (10),
	@experiencia [varchar] (10),
	@f_ingreso [varchar] (11),
	@departamento [varchar](20),
	@des_salida [varchar](100),
	@fecha_salida [varchar](11),
	@estado [varchar](10)
AS
BEGIN
	insert into 
	Empleado(Personaid, cuenta_BN, cuenta_BP, Profesion, Estudios,
					Manipulacion_Alimentos, Enfermedades, carne, experiencia,
					fecha_Ingreso,departamento,descripcion_Salida,fecha_Salida,estado) 
		values (@idper , @cuentabn, @cuentabp, @profesion, @estudios, @manipulacionesA, 
				@enfermedades, @carne, @experiencia, @f_ingreso, @departamento, 
				@des_salida,@fecha_salida,@estado)
END


--///////////////////////////////////////////TEST//////////////////
--///////////////////////////////////////////TEST//////////////////
--///////////////////////////////////////////TEST//////////////////
GO


INSERT Persona ([id],[nombre],[apellidos],[edad],[nacionalidad],[EstadoCivil],[direccion],[sexo],[Hijos],[fecha_de_ingreso])
VALUES ('1', 'Randall','Jimenez','20','Costarricense','Soltero','En la casa de el','M',0,(select GETDATE()))
go
INSERT Persona ([id],[nombre],[apellidos],[edad],[nacionalidad],[EstadoCivil],[direccion],[sexo],[Hijos],[fecha_de_ingreso])
VALUES ('2', 'Randall','Gonzales','20','Costarricense','Soltero','En la casa de el','M',0,(select GETDATE()))
go

INSERT Empleado ([Personaid],[cuenta_BN],[cuenta_BP],[Profesion],[Estudios],[Manipulacion_Alimentos],[Enfermedades],
      [carne],[experiencia],[fecha_Ingreso],[departamento],[descripcion_Salida],[fecha_Salida],[estado]) 
VALUES ('1','bncuenta','bpcuenta', 'Gerente', 'Universidad','Curso general','Ninguna','123456',
  '4 años','daddadsa','Administrativo',null,null,'Activo')
go


insert Usuario(IdPersona,Usuario,Contraseña,TipoUsuario) values('1','randall','123',2)
GO
