USE [master]
GO
/****** Object:  Database [Mamirmi]    Script Date: 11/03/2014 16:59:57 ******/
CREATE DATABASE [Mamirmi]
GO

USE [Mamirmi]
GO
/****** Object:  Default [dbo].[DGenero]    Script Date: 11/03/2014 16:59:58 ******/
CREATE DEFAULT [dbo].[DGenero] 
AS
'F'

GO
/****** Object:  Default [dbo].[Djornada]    Script Date: 11/03/2014 16:59:58 ******/
CREATE DEFAULT [dbo].[Djornada] 
AS
'diurnal'
GO
/****** Object:  Rule [dbo].[RGenero]    Script Date: 11/03/2014 16:59:58 ******/
CREATE RULE [dbo].[RGenero] 
AS
(@Genero in ('F','M'))
GO
/****** Object:  Rule [dbo].[RID_Persona]    Script Date: 11/03/2014 16:59:58 ******/
CREATE RULE [dbo].[RID_Persona] 
AS
(@Persona like '[0-9]-[0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]'
					or
					@Persona like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
GO
/****** Object:  Rule [dbo].[Rjornada]    Script Date: 11/03/2014 16:59:58 ******/
CREATE RULE [dbo].[Rjornada] 
AS
(@jornada in ('diurnal', 'nocturnal', 'mixed'))
GO

/****** Object:  Rule [dbo].[RTelefono]    Script Date: 11/03/2014 16:59:58 ******/
CREATE RULE [dbo].[RTelefono] 
AS
(@telephone like '[0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]')
	or
	(@telephone like '([0-9][0-9][0-9]) [0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]')
GO

/****** Object:  UserDefinedDataType [dbo].[TGenero]    Script Date: 11/03/2014 16:59:58 ******/
CREATE TYPE [dbo].[TGenero] FROM [char](1) NOT NULL
GO

/****** Object:  UserDefinedDataType [dbo].[TId]    Script Date: 11/03/2014 16:59:58 ******/
CREATE TYPE [dbo].[TId] FROM [char](12) NOT NULL
GO

/****** Object:  UserDefinedDataType [dbo].[Tjornada]    Script Date: 11/03/2014 16:59:58 ******/
CREATE TYPE [dbo].[Tjornada] FROM [varchar](9) NOT NULL
GO

/****** Object:  UserDefinedDataType [dbo].[TTelefono]    Script Date: 11/03/2014 16:59:58 ******/
CREATE TYPE [dbo].[TTelefono] FROM [varchar](17) NOT NULL
GO

/****** Object:  Table [dbo].[Aguinaldo]    Script Date: 11/03/2014 16:59:58 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Aguinaldo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Personaid] [char](12) NOT NULL,
	[Monto] [money] NOT NULL,
	[Fecha] [date] NOT NULL,
 CONSTRAINT [pk_ID_Aguinaldo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_PADDING OFF
GO

/****** Object:  Table [dbo].[Empleado]    Script Date: 11/03/2014 16:59:58 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Empleado](
	[id] [tinyint] NOT NULL,
	[Personaid] [char](12) NOT NULL,
	[cuenta_BN] [varchar](15) NOT NULL,
	[cuenta_BP] [varchar](15) NOT NULL,
 CONSTRAINT [pk_ID_Empleado] PRIMARY KEY CLUSTERED 
(
	[id] ASC,
	[Personaid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_PADDING OFF
GO

/****** Object:  Table [dbo].[Hora]    Script Date: 11/03/2014 16:59:58 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Hora](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Personaid] [char](12) NOT NULL,
	[fecha_Inicial] [date] NULL,
	[fecha_Final] [date] NULL,
	[horas_Ordinarias] [decimal](10, 5) NULL,
	[horas_Extra] [decimal](10, 5) NULL,
 CONSTRAINT [pk_ID_Hora] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_PADDING OFF
GO

/****** Object:  Table [dbo].[Incapacidad]    Script Date: 11/03/2014 16:59:58 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Incapacidad](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Personaid] [char](12) NOT NULL,
	[fecha_Salida] [date] NOT NULL,
	[fecha_Entrada] [date] NOT NULL,
	[informacion] [varchar](200) NULL,
 CONSTRAINT [pk_ID_incapacidad] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_PADDING OFF
GO

/****** Object:  Table [dbo].[Persona]    Script Date: 11/03/2014 16:59:58 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Persona](
	[id] [dbo].[TId] NOT NULL,
	[nombre] [varchar](30) NOT NULL,
	[apellidos] [varchar](30) NOT NULL,
	[edad] [tinyint] NOT NULL,
	[nacionalidad][varchar](30) NOT NULL,
	[EstadoCivil][varchar](30) not null default 'Soltero',
	[direccion] [varchar](200) NOT NULL,
	[sexo] [dbo].[TGenero] NOT NULL,
	[Hijos] [tinyint],
	[fecha_de_ingreso] [varchar](20) NULL,
 CONSTRAINT [pk_id_persona] PRIMARY KEY CLUSTERED(
 	[id] ASC
 	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
 	) ON [PRIMARY]
GO

SET ANSI_PADDING OFF
GO

/****** Object:  Table [dbo].[Salario]    Script Date: 11/03/2014 16:59:58 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Salario](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Personaid] [char](12) NOT NULL,
	[salario_Bruto] [decimal](20, 8) NOT NULL,
	[salario_Neto] [decimal](20, 8) NOT NULL,
	[Jornada] [dbo].[Tjornada] NOT NULL,
	[CCSS] [decimal](20, 8) NOT NULL,
	[ahorro_Navidad] [decimal](16, 6) NULL,
	[ahorro_Escolar] [decimal](16, 6) NULL,
	[fecha_Salario] [date] NULL,
	[Otros] [decimal](16, 6) NULL,
 CONSTRAINT [pk_ID_Salario] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_PADDING OFF
GO

/****** Object:  Table [dbo].[Telefono]    Script Date: 11/03/2014 16:59:58 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Telefono](
	[id] [char](12) NOT NULL,
	[telefono] [dbo].[TTelefono] NOT NULL,
 CONSTRAINT [pk_idTelefono_Telefono] PRIMARY KEY CLUSTERED 
(
	[id] ASC,
	[telefono] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_PADDING OFF
GO

/****** Object:  Table [dbo].[Vacaciones]    Script Date: 11/03/2014 16:59:58 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Vacaciones](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Personaid] [char](12) NOT NULL,
	[fecha_Entrada] [date] NOT NULL,
	[fecha_Salida] [date] NOT NULL,
	[dias] [int] NOT NULL,
 CONSTRAINT [pk_ID_Vacaciones] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Aguinaldo]  WITH CHECK ADD  CONSTRAINT [fk_ID_Empleado_Aguinaldo] FOREIGN KEY([Personaid])
REFERENCES [dbo].[Persona] ([id])
GO

ALTER TABLE [dbo].[Aguinaldo] CHECK CONSTRAINT [fk_ID_Empleado_Aguinaldo]
GO

ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [fk_ID_Empleado] FOREIGN KEY([Personaid])
REFERENCES [dbo].[Persona] ([id])
GO

ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [fk_ID_Empleado]
GO

ALTER TABLE [dbo].[Hora]  WITH CHECK ADD  CONSTRAINT [fk_ID_Empleado_Hora] FOREIGN KEY([Personaid])
REFERENCES [dbo].[Persona] ([id])
GO

ALTER TABLE [dbo].[Hora] CHECK CONSTRAINT [fk_ID_Empleado_Hora]
GO

ALTER TABLE [dbo].[Incapacidad]  WITH CHECK ADD  CONSTRAINT [fk_ID_Person_Incapacidad] FOREIGN KEY([Personaid])
REFERENCES [dbo].[Persona] ([id])
GO

ALTER TABLE [dbo].[Incapacidad] CHECK CONSTRAINT [fk_ID_Person_Incapacidad]
GO

ALTER TABLE [dbo].[Salario]  WITH CHECK ADD  CONSTRAINT [fk_ID_Empleado_Salario] FOREIGN KEY([Personaid])
REFERENCES [dbo].[Persona] ([id])
GO

ALTER TABLE [dbo].[Salario] CHECK CONSTRAINT [fk_ID_Empleado_Salario]
GO

ALTER TABLE [dbo].[Telefono]  WITH CHECK ADD  CONSTRAINT [fk_id_telefono] FOREIGN KEY([id])
REFERENCES [dbo].[Persona] ([id])
GO

ALTER TABLE [dbo].[Telefono] CHECK CONSTRAINT [fk_id_telefono]
GO

ALTER TABLE [dbo].[Vacaciones]  WITH CHECK ADD  CONSTRAINT [fk_ID_Empleado_Vacaciones] FOREIGN KEY([Personaid])
REFERENCES [dbo].[Persona] ([id])
GO

ALTER TABLE [dbo].[Vacaciones] CHECK CONSTRAINT [fk_ID_Empleado_Vacaciones]
GO

-- Nueva tabla usuario 
CREATE TABLE [dbo].[Usuario](
	[IdPersona] [dbo].[TId] NOT NULL,	
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





USE [master]
GO

ALTER DATABASE [Mamirmi] SET  READ_WRITE 
GO
