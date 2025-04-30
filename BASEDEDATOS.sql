USE [master]
GO
/****** Object:  Database [CATERINGDB]    Script Date: 29/4/2025 23:48:47 ******/
CREATE DATABASE [CATERINGDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CATERINGDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\CATERINGDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CATERINGDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\CATERINGDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [CATERINGDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CATERINGDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CATERINGDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CATERINGDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CATERINGDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CATERINGDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CATERINGDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [CATERINGDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CATERINGDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CATERINGDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CATERINGDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CATERINGDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CATERINGDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CATERINGDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CATERINGDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CATERINGDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CATERINGDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CATERINGDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CATERINGDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CATERINGDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CATERINGDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CATERINGDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CATERINGDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CATERINGDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CATERINGDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CATERINGDB] SET  MULTI_USER 
GO
ALTER DATABASE [CATERINGDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CATERINGDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CATERINGDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CATERINGDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CATERINGDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CATERINGDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [CATERINGDB] SET QUERY_STORE = OFF
GO
USE [CATERINGDB]
GO
/****** Object:  Table [dbo].[alerta_stock]    Script Date: 29/4/2025 23:48:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[alerta_stock](
	[id_alerta] [bigint] IDENTITY(1,1) NOT NULL,
	[id_insumo] [bigint] NOT NULL,
	[fecha_alerta] [datetime] NULL,
	[estado_alerta] [varchar](45) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_alerta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[clientes]    Script Date: 29/4/2025 23:48:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clientes](
	[id_cliente] [bigint] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[apellido] [varchar](100) NOT NULL,
	[email] [varchar](100) NULL,
	[telefono] [varchar](20) NULL,
	[domicilio] [varchar](100) NULL,
	[dni] [varchar](45) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[empleado]    Script Date: 29/4/2025 23:48:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[empleado](
	[id_empleado] [int] NOT NULL,
	[dni_empleado] [varchar](8) NOT NULL,
	[nombre] [varchar](45) NOT NULL,
	[apellido] [varchar](45) NOT NULL,
	[domicilio] [varchar](45) NULL,
	[telefono] [varchar](45) NULL,
	[fecha_baja] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[evento]    Script Date: 29/4/2025 23:48:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[evento](
	[id_evento] [bigint] IDENTITY(1,1) NOT NULL,
	[id_cliente] [bigint] NOT NULL,
	[id_menu] [bigint] NOT NULL,
	[fecha_evento] [date] NOT NULL,
	[descuento_aplicado] [decimal](10, 2) NULL,
	[direccion] [varchar](200) NULL,
	[localidad] [varchar](100) NULL,
	[estado_evento] [varchar](45) NULL,
	[cantidad_personas] [bigint] NULL,
	[total_estimado] [decimal](10, 2) NULL,
	[evento_pago] [bit] NULL,
	[id_usuario_venta] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_evento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[insumo]    Script Date: 29/4/2025 23:48:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[insumo](
	[id_insumo] [bigint] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[unidad_medida] [varchar](20) NOT NULL,
	[perecedero] [bit] NOT NULL,
	[stock_minimo] [decimal](10, 2) NOT NULL,
	[fecha_baja] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_insumo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[lotes_insumo]    Script Date: 29/4/2025 23:48:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lotes_insumo](
	[id_lote] [bigint] IDENTITY(1,1) NOT NULL,
	[id_insumo] [bigint] NOT NULL,
	[cantidad] [decimal](10, 2) NOT NULL,
	[fecha_ingreso] [date] NOT NULL,
	[fecha_vencimiento] [date] NULL,
	[costo_unitario] [decimal](10, 2) NOT NULL,
	[id_pedido] [bigint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_lote] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[menu]    Script Date: 29/4/2025 23:48:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[menu](
	[id_menu] [bigint] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[precio_x_persona] [decimal](10, 2) NOT NULL,
	[fecha_baja] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_menu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[menu_plato]    Script Date: 29/4/2025 23:48:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[menu_plato](
	[id_menu] [bigint] NOT NULL,
	[id_plato] [bigint] NOT NULL,
	[id_menu_plato] [bigint] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_menu_plato] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pedido_insumo]    Script Date: 29/4/2025 23:48:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pedido_insumo](
	[id_pedido_insumo] [bigint] NOT NULL,
	[id_insumo] [bigint] NULL,
	[cantidad] [decimal](10, 2) NULL,
	[fecha_pedido] [date] NULL,
	[estado_pedido] [varchar](45) NULL,
	[id_usuario_pedido] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_pedido_insumo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[plato]    Script Date: 29/4/2025 23:48:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[plato](
	[id_plato] [bigint] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[tipo_plato] [varchar](45) NOT NULL,
	[fecha_baja] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_plato] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[plato_insumo]    Script Date: 29/4/2025 23:48:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[plato_insumo](
	[id_plato] [bigint] NOT NULL,
	[id_insumo] [bigint] NOT NULL,
	[cantidad_necesaria] [decimal](10, 2) NOT NULL,
	[id_plato_insumo] [bigint] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_plato_insumo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 29/4/2025 23:48:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[id_usuario] [bigint] IDENTITY(1,1) NOT NULL,
	[email] [varchar](100) NOT NULL,
	[clave] [varchar](50) NOT NULL,
	[perfil] [varchar](50) NOT NULL,
	[fecha_creacion] [date] NULL,
	[fecha_baja] [date] NULL,
	[id_empleado] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[alerta_stock] ON 

INSERT [dbo].[alerta_stock] ([id_alerta], [id_insumo], [fecha_alerta], [estado_alerta]) VALUES (1, 2, CAST(N'2025-04-29T23:33:58.630' AS DateTime), N'PENDIENTE')
INSERT [dbo].[alerta_stock] ([id_alerta], [id_insumo], [fecha_alerta], [estado_alerta]) VALUES (2, 5, CAST(N'2025-04-29T23:33:58.630' AS DateTime), N'RESUELTO')
INSERT [dbo].[alerta_stock] ([id_alerta], [id_insumo], [fecha_alerta], [estado_alerta]) VALUES (3, 6, CAST(N'2025-04-27T23:33:58.630' AS DateTime), N'PENDIENTE')
SET IDENTITY_INSERT [dbo].[alerta_stock] OFF
GO
SET IDENTITY_INSERT [dbo].[clientes] ON 

INSERT [dbo].[clientes] ([id_cliente], [nombre], [apellido], [email], [telefono], [domicilio], [dni]) VALUES (1, N'Roberto', N'García', N'roberto.garcia@mail.com', N'1167890123', N'Av. Rivadavia 1234', N'20123456')
INSERT [dbo].[clientes] ([id_cliente], [nombre], [apellido], [email], [telefono], [domicilio], [dni]) VALUES (2, N'Laura', N'Fernández', N'laura.fernandez@mail.com', N'1167890124', N'Calle 10 N° 567', N'22123456')
INSERT [dbo].[clientes] ([id_cliente], [nombre], [apellido], [email], [telefono], [domicilio], [dni]) VALUES (3, N'Miguel', N'Díaz', N'miguel.diaz@mail.com', N'1167890125', N'Av. Santa Fe 789', N'24123456')
SET IDENTITY_INSERT [dbo].[clientes] OFF
GO
INSERT [dbo].[empleado] ([id_empleado], [dni_empleado], [nombre], [apellido], [domicilio], [telefono], [fecha_baja]) VALUES (1, N'30123456', N'Juan', N'Pérez', N'Av. Siempreviva 742', N'1156789012', NULL)
INSERT [dbo].[empleado] ([id_empleado], [dni_empleado], [nombre], [apellido], [domicilio], [telefono], [fecha_baja]) VALUES (2, N'32123456', N'María', N'Gómez', N'Calle Falsa 123', N'1156789013', NULL)
INSERT [dbo].[empleado] ([id_empleado], [dni_empleado], [nombre], [apellido], [domicilio], [telefono], [fecha_baja]) VALUES (3, N'34123456', N'Carlos', N'López', N'Av. Libertador 456', N'1156789014', NULL)
INSERT [dbo].[empleado] ([id_empleado], [dni_empleado], [nombre], [apellido], [domicilio], [telefono], [fecha_baja]) VALUES (4, N'36123456', N'Ana', N'Martínez', N'Calle 5 N° 789', N'1156789015', NULL)
INSERT [dbo].[empleado] ([id_empleado], [dni_empleado], [nombre], [apellido], [domicilio], [telefono], [fecha_baja]) VALUES (5, N'38123456', N'Pedro', N'Rodríguez', N'Av. Corrientes 321', N'1156789016', NULL)
GO
SET IDENTITY_INSERT [dbo].[evento] ON 

INSERT [dbo].[evento] ([id_evento], [id_cliente], [id_menu], [fecha_evento], [descuento_aplicado], [direccion], [localidad], [estado_evento], [cantidad_personas], [total_estimado], [evento_pago], [id_usuario_venta]) VALUES (1, 1, 2, CAST(N'2025-05-06' AS Date), CAST(0.00 AS Decimal(10, 2)), N'Av. Libertador 1234', N'CABA', N'CONFIRMADO', 50, CAST(175000.00 AS Decimal(10, 2)), 1, 3)
INSERT [dbo].[evento] ([id_evento], [id_cliente], [id_menu], [fecha_evento], [descuento_aplicado], [direccion], [localidad], [estado_evento], [cantidad_personas], [total_estimado], [evento_pago], [id_usuario_venta]) VALUES (2, 2, 1, CAST(N'2025-05-13' AS Date), CAST(10.00 AS Decimal(10, 2)), N'Calle 10 N° 567', N'CABA', N'PENDIENTE', 30, CAST(67500.00 AS Decimal(10, 2)), 0, 3)
INSERT [dbo].[evento] ([id_evento], [id_cliente], [id_menu], [fecha_evento], [descuento_aplicado], [direccion], [localidad], [estado_evento], [cantidad_personas], [total_estimado], [evento_pago], [id_usuario_venta]) VALUES (3, 3, 3, CAST(N'2025-05-20' AS Date), CAST(0.00 AS Decimal(10, 2)), N'Av. Santa Fe 789', N'CABA', N'CONFIRMADO', 20, CAST(56000.00 AS Decimal(10, 2)), 1, 3)
SET IDENTITY_INSERT [dbo].[evento] OFF
GO
SET IDENTITY_INSERT [dbo].[insumo] ON 

INSERT [dbo].[insumo] ([id_insumo], [nombre], [unidad_medida], [perecedero], [stock_minimo], [fecha_baja]) VALUES (1, N'Harina', N'kg', 0, CAST(50.00 AS Decimal(10, 2)), NULL)
INSERT [dbo].[insumo] ([id_insumo], [nombre], [unidad_medida], [perecedero], [stock_minimo], [fecha_baja]) VALUES (2, N'Pollo', N'kg', 1, CAST(20.00 AS Decimal(10, 2)), NULL)
INSERT [dbo].[insumo] ([id_insumo], [nombre], [unidad_medida], [perecedero], [stock_minimo], [fecha_baja]) VALUES (3, N'Carne vacuna', N'kg', 1, CAST(25.00 AS Decimal(10, 2)), NULL)
INSERT [dbo].[insumo] ([id_insumo], [nombre], [unidad_medida], [perecedero], [stock_minimo], [fecha_baja]) VALUES (4, N'Arroz', N'kg', 0, CAST(30.00 AS Decimal(10, 2)), NULL)
INSERT [dbo].[insumo] ([id_insumo], [nombre], [unidad_medida], [perecedero], [stock_minimo], [fecha_baja]) VALUES (5, N'Tomate', N'kg', 1, CAST(15.00 AS Decimal(10, 2)), NULL)
INSERT [dbo].[insumo] ([id_insumo], [nombre], [unidad_medida], [perecedero], [stock_minimo], [fecha_baja]) VALUES (6, N'Lechuga', N'kg', 1, CAST(10.00 AS Decimal(10, 2)), NULL)
INSERT [dbo].[insumo] ([id_insumo], [nombre], [unidad_medida], [perecedero], [stock_minimo], [fecha_baja]) VALUES (7, N'Queso', N'kg', 1, CAST(12.00 AS Decimal(10, 2)), NULL)
INSERT [dbo].[insumo] ([id_insumo], [nombre], [unidad_medida], [perecedero], [stock_minimo], [fecha_baja]) VALUES (8, N'Vino tinto', N'lt', 0, CAST(20.00 AS Decimal(10, 2)), NULL)
INSERT [dbo].[insumo] ([id_insumo], [nombre], [unidad_medida], [perecedero], [stock_minimo], [fecha_baja]) VALUES (9, N'Pan', N'kg', 1, CAST(100.00 AS Decimal(10, 2)), NULL)
INSERT [dbo].[insumo] ([id_insumo], [nombre], [unidad_medida], [perecedero], [stock_minimo], [fecha_baja]) VALUES (10, N'Sal', N'kg', 0, CAST(5.00 AS Decimal(10, 2)), NULL)
SET IDENTITY_INSERT [dbo].[insumo] OFF
GO
SET IDENTITY_INSERT [dbo].[lotes_insumo] ON 

INSERT [dbo].[lotes_insumo] ([id_lote], [id_insumo], [cantidad], [fecha_ingreso], [fecha_vencimiento], [costo_unitario], [id_pedido]) VALUES (1, 5, CAST(20.00 AS Decimal(10, 2)), CAST(N'2025-04-29' AS Date), CAST(N'2025-05-06' AS Date), CAST(150.00 AS Decimal(10, 2)), 2)
INSERT [dbo].[lotes_insumo] ([id_lote], [id_insumo], [cantidad], [fecha_ingreso], [fecha_vencimiento], [costo_unitario], [id_pedido]) VALUES (2, 3, CAST(40.00 AS Decimal(10, 2)), CAST(N'2025-04-26' AS Date), CAST(N'2025-05-09' AS Date), CAST(450.00 AS Decimal(10, 2)), 3)
SET IDENTITY_INSERT [dbo].[lotes_insumo] OFF
GO
SET IDENTITY_INSERT [dbo].[menu] ON 

INSERT [dbo].[menu] ([id_menu], [nombre], [precio_x_persona], [fecha_baja]) VALUES (1, N'Menú Ejecutivo', CAST(2500.00 AS Decimal(10, 2)), NULL)
INSERT [dbo].[menu] ([id_menu], [nombre], [precio_x_persona], [fecha_baja]) VALUES (2, N'Menú Premium', CAST(3500.00 AS Decimal(10, 2)), NULL)
INSERT [dbo].[menu] ([id_menu], [nombre], [precio_x_persona], [fecha_baja]) VALUES (3, N'Menú Vegetariano', CAST(2800.00 AS Decimal(10, 2)), NULL)
INSERT [dbo].[menu] ([id_menu], [nombre], [precio_x_persona], [fecha_baja]) VALUES (4, N'Menú Infantil', CAST(1800.00 AS Decimal(10, 2)), NULL)
SET IDENTITY_INSERT [dbo].[menu] OFF
GO
SET IDENTITY_INSERT [dbo].[menu_plato] ON 

INSERT [dbo].[menu_plato] ([id_menu], [id_plato], [id_menu_plato]) VALUES (1, 1, 1)
INSERT [dbo].[menu_plato] ([id_menu], [id_plato], [id_menu_plato]) VALUES (1, 2, 2)
INSERT [dbo].[menu_plato] ([id_menu], [id_plato], [id_menu_plato]) VALUES (1, 4, 3)
INSERT [dbo].[menu_plato] ([id_menu], [id_plato], [id_menu_plato]) VALUES (2, 3, 4)
INSERT [dbo].[menu_plato] ([id_menu], [id_plato], [id_menu_plato]) VALUES (2, 2, 5)
INSERT [dbo].[menu_plato] ([id_menu], [id_plato], [id_menu_plato]) VALUES (2, 4, 6)
INSERT [dbo].[menu_plato] ([id_menu], [id_plato], [id_menu_plato]) VALUES (3, 3, 7)
INSERT [dbo].[menu_plato] ([id_menu], [id_plato], [id_menu_plato]) VALUES (3, 2, 8)
INSERT [dbo].[menu_plato] ([id_menu], [id_plato], [id_menu_plato]) VALUES (3, 4, 9)
INSERT [dbo].[menu_plato] ([id_menu], [id_plato], [id_menu_plato]) VALUES (4, 5, 10)
INSERT [dbo].[menu_plato] ([id_menu], [id_plato], [id_menu_plato]) VALUES (4, 1, 11)
INSERT [dbo].[menu_plato] ([id_menu], [id_plato], [id_menu_plato]) VALUES (4, 4, 12)
SET IDENTITY_INSERT [dbo].[menu_plato] OFF
GO
INSERT [dbo].[pedido_insumo] ([id_pedido_insumo], [id_insumo], [cantidad], [fecha_pedido], [estado_pedido], [id_usuario_pedido]) VALUES (1, 2, CAST(30.00 AS Decimal(10, 2)), CAST(N'2025-04-29' AS Date), N'PENDIENTE', 4)
INSERT [dbo].[pedido_insumo] ([id_pedido_insumo], [id_insumo], [cantidad], [fecha_pedido], [estado_pedido], [id_usuario_pedido]) VALUES (2, 5, CAST(20.00 AS Decimal(10, 2)), CAST(N'2025-04-29' AS Date), N'ENTREGADO', 4)
INSERT [dbo].[pedido_insumo] ([id_pedido_insumo], [id_insumo], [cantidad], [fecha_pedido], [estado_pedido], [id_usuario_pedido]) VALUES (3, 3, CAST(40.00 AS Decimal(10, 2)), CAST(N'2025-04-26' AS Date), N'ENTREGADO', 4)
GO

SET IDENTITY_INSERT [dbo].[plato] ON 

INSERT [dbo].[plato] ([id_plato], [nombre], [tipo_plato], [fecha_baja]) VALUES (1, N'Milanesa con puré', N'PRINCIPAL', NULL)
INSERT [dbo].[plato] ([id_plato], [nombre], [tipo_plato], [fecha_baja]) VALUES (2, N'Ensalada César', N'ENTRADA', NULL)
INSERT [dbo].[plato] ([id_plato], [nombre], [tipo_plato], [fecha_baja]) VALUES (3, N'Risotto de hongos', N'PRINCIPAL', NULL)
INSERT [dbo].[plato] ([id_plato], [nombre], [tipo_plato], [fecha_baja]) VALUES (4, N'Tiramisú', N'POSTRE', NULL)
INSERT [dbo].[plato] ([id_plato], [nombre], [tipo_plato], [fecha_baja]) VALUES (5, N'Empanadas de carne', N'ENTRADA', NULL)
SET IDENTITY_INSERT [dbo].[plato] OFF
GO
SET IDENTITY_INSERT [dbo].[plato_insumo] ON 

INSERT [dbo].[plato_insumo] ([id_plato], [id_insumo], [cantidad_necesaria], [id_plato_insumo]) VALUES (1, 3, CAST(0.30 AS Decimal(10, 2)), 1)
INSERT [dbo].[plato_insumo] ([id_plato], [id_insumo], [cantidad_necesaria], [id_plato_insumo]) VALUES (1, 1, CAST(0.10 AS Decimal(10, 2)), 2)
INSERT [dbo].[plato_insumo] ([id_plato], [id_insumo], [cantidad_necesaria], [id_plato_insumo]) VALUES (1, 10, CAST(0.01 AS Decimal(10, 2)), 3)
INSERT [dbo].[plato_insumo] ([id_plato], [id_insumo], [cantidad_necesaria], [id_plato_insumo]) VALUES (2, 6, CAST(0.20 AS Decimal(10, 2)), 4)
INSERT [dbo].[plato_insumo] ([id_plato], [id_insumo], [cantidad_necesaria], [id_plato_insumo]) VALUES (2, 5, CAST(0.15 AS Decimal(10, 2)), 5)
INSERT [dbo].[plato_insumo] ([id_plato], [id_insumo], [cantidad_necesaria], [id_plato_insumo]) VALUES (3, 4, CAST(0.20 AS Decimal(10, 2)), 6)
INSERT [dbo].[plato_insumo] ([id_plato], [id_insumo], [cantidad_necesaria], [id_plato_insumo]) VALUES (5, 3, CAST(0.15 AS Decimal(10, 2)), 7)
INSERT [dbo].[plato_insumo] ([id_plato], [id_insumo], [cantidad_necesaria], [id_plato_insumo]) VALUES (5, 1, CAST(0.10 AS Decimal(10, 2)), 8)
SET IDENTITY_INSERT [dbo].[plato_insumo] OFF
GO
SET IDENTITY_INSERT [dbo].[usuarios] ON 

INSERT [dbo].[usuarios] ([id_usuario], [email], [clave], [perfil], [fecha_creacion], [fecha_baja], [id_empleado]) VALUES (1, N'admin@catering.com', N'Admin123', 'ADMINISTRADOR', CAST(N'2025-04-29' AS Date), NULL, 1)
INSERT [dbo].[usuarios] ([id_usuario], [email], [clave], [perfil], [fecha_creacion], [fecha_baja], [id_empleado]) VALUES (2, N'gerente@catering.com', N'Gerente123', 'GERENTE', CAST(N'2025-04-29' AS Date), NULL, 2)
INSERT [dbo].[usuarios] ([id_usuario], [email], [clave], [perfil], [fecha_creacion], [fecha_baja], [id_empleado]) VALUES (3, N'vendedor@catering.com', N'Vendedor123', 'VENDEDOR', CAST(N'2025-04-29' AS Date), NULL, 3)
INSERT [dbo].[usuarios] ([id_usuario], [email], [clave], [perfil], [fecha_creacion], [fecha_baja], [id_empleado]) VALUES (4, N'logistica@catering.com', N'Logistica123', 'LOGISTICA', CAST(N'2025-04-29' AS Date), NULL, 4)
INSERT [dbo].[usuarios] ([id_usuario], [email], [clave], [perfil], [fecha_creacion], [fecha_baja], [id_empleado]) VALUES (5, N'chef@catering.com', N'Chef123', 'CHEF', CAST(N'2025-04-29' AS Date), NULL, 5)
SET IDENTITY_INSERT [dbo].[usuarios] OFF
GO
/****** Object:  Index [id_insumo_idx]    Script Date: 29/4/2025 23:48:47 ******/
CREATE NONCLUSTERED INDEX [id_insumo_idx] ON [dbo].[alerta_stock]
(
	[id_insumo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [dni_empleado_UNIQUE]    Script Date: 29/4/2025 23:48:47 ******/
CREATE UNIQUE NONCLUSTERED INDEX [dni_empleado_UNIQUE] ON [dbo].[empleado]
(
	[dni_empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [id_cliente_idx]    Script Date: 29/4/2025 23:48:47 ******/
CREATE NONCLUSTERED INDEX [id_cliente_idx] ON [dbo].[evento]
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [id_menu_idx]    Script Date: 29/4/2025 23:48:47 ******/
CREATE NONCLUSTERED INDEX [id_menu_idx] ON [dbo].[evento]
(
	[id_menu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [usuario_evento_idx]    Script Date: 29/4/2025 23:48:47 ******/
CREATE NONCLUSTERED INDEX [usuario_evento_idx] ON [dbo].[evento]
(
	[id_usuario_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [id_insumo_idx]    Script Date: 29/4/2025 23:48:47 ******/
CREATE NONCLUSTERED INDEX [id_insumo_idx] ON [dbo].[lotes_insumo]
(
	[id_insumo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [lote_pedido_idx]    Script Date: 29/4/2025 23:48:47 ******/
CREATE NONCLUSTERED INDEX [lote_pedido_idx] ON [dbo].[lotes_insumo]
(
	[id_pedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [id_plato_idx]    Script Date: 29/4/2025 23:48:47 ******/
CREATE NONCLUSTERED INDEX [id_plato_idx] ON [dbo].[menu_plato]
(
	[id_plato] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [insumo_pedido_idx]    Script Date: 29/4/2025 23:48:47 ******/
CREATE NONCLUSTERED INDEX [insumo_pedido_idx] ON [dbo].[pedido_insumo]
(
	[id_insumo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [usuario_pedido_idx]    Script Date: 29/4/2025 23:48:47 ******/
CREATE NONCLUSTERED INDEX [usuario_pedido_idx] ON [dbo].[pedido_insumo]
(
	[id_usuario_pedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [id_insumo_idx]    Script Date: 29/4/2025 23:48:47 ******/
CREATE NONCLUSTERED INDEX [id_insumo_idx] ON [dbo].[plato_insumo]
(
	[id_insumo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [email_idx]    Script Date: 29/4/2025 23:48:47 ******/
CREATE UNIQUE NONCLUSTERED INDEX [email_idx] ON [dbo].[usuarios]
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [EMPLEADO_USUARIO_idx]    Script Date: 29/4/2025 23:48:47 ******/
CREATE NONCLUSTERED INDEX [EMPLEADO_USUARIO_idx] ON [dbo].[usuarios]
(
	[id_empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[alerta_stock] ADD  DEFAULT (getdate()) FOR [fecha_alerta]
GO
ALTER TABLE [dbo].[usuarios] ADD  DEFAULT (CONVERT([date],getdate())) FOR [fecha_creacion]
GO
ALTER TABLE [dbo].[alerta_stock]  WITH CHECK ADD  CONSTRAINT [fk_alerta_insumo] FOREIGN KEY([id_insumo])
REFERENCES [dbo].[insumo] ([id_insumo])
GO
ALTER TABLE [dbo].[alerta_stock] CHECK CONSTRAINT [fk_alerta_insumo]
GO
ALTER TABLE [dbo].[evento]  WITH CHECK ADD  CONSTRAINT [fk_evento_cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[clientes] ([id_cliente])
GO
ALTER TABLE [dbo].[evento] CHECK CONSTRAINT [fk_evento_cliente]
GO
ALTER TABLE [dbo].[evento]  WITH CHECK ADD  CONSTRAINT [fk_evento_menu] FOREIGN KEY([id_menu])
REFERENCES [dbo].[menu] ([id_menu])
GO
ALTER TABLE [dbo].[evento] CHECK CONSTRAINT [fk_evento_menu]
GO
ALTER TABLE [dbo].[evento]  WITH CHECK ADD  CONSTRAINT [fk_evento_usuario] FOREIGN KEY([id_usuario_venta])
REFERENCES [dbo].[usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[evento] CHECK CONSTRAINT [fk_evento_usuario]
GO
ALTER TABLE [dbo].[lotes_insumo]  WITH CHECK ADD  CONSTRAINT [fk_lote_pedido] FOREIGN KEY([id_pedido])
REFERENCES [dbo].[pedido_insumo] ([id_pedido_insumo])
GO
ALTER TABLE [dbo].[lotes_insumo] CHECK CONSTRAINT [fk_lote_pedido]
GO
ALTER TABLE [dbo].[lotes_insumo]  WITH CHECK ADD  CONSTRAINT [fk_lotes_insumo] FOREIGN KEY([id_insumo])
REFERENCES [dbo].[insumo] ([id_insumo])
GO
ALTER TABLE [dbo].[lotes_insumo] CHECK CONSTRAINT [fk_lotes_insumo]
GO
ALTER TABLE [dbo].[menu_plato]  WITH CHECK ADD  CONSTRAINT [fk_menu_plato_menu] FOREIGN KEY([id_menu])
REFERENCES [dbo].[menu] ([id_menu])
GO
ALTER TABLE [dbo].[menu_plato] CHECK CONSTRAINT [fk_menu_plato_menu]
GO
ALTER TABLE [dbo].[menu_plato]  WITH CHECK ADD  CONSTRAINT [fk_menu_plato_plato] FOREIGN KEY([id_plato])
REFERENCES [dbo].[plato] ([id_plato])
GO
ALTER TABLE [dbo].[menu_plato] CHECK CONSTRAINT [fk_menu_plato_plato]
GO
ALTER TABLE [dbo].[pedido_insumo]  WITH CHECK ADD  CONSTRAINT [fk_pedido_insumo] FOREIGN KEY([id_insumo])
REFERENCES [dbo].[insumo] ([id_insumo])
GO
ALTER TABLE [dbo].[pedido_insumo] CHECK CONSTRAINT [fk_pedido_insumo]
GO
ALTER TABLE [dbo].[pedido_insumo]  WITH CHECK ADD  CONSTRAINT [fk_pedido_usuario] FOREIGN KEY([id_usuario_pedido])
REFERENCES [dbo].[usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[pedido_insumo] CHECK CONSTRAINT [fk_pedido_usuario]
GO
ALTER TABLE [dbo].[plato_insumo]  WITH CHECK ADD  CONSTRAINT [fk_plato_insumo_insumo] FOREIGN KEY([id_insumo])
REFERENCES [dbo].[insumo] ([id_insumo])
GO
ALTER TABLE [dbo].[plato_insumo] CHECK CONSTRAINT [fk_plato_insumo_insumo]
GO
ALTER TABLE [dbo].[plato_insumo]  WITH CHECK ADD  CONSTRAINT [fk_plato_insumo_plato] FOREIGN KEY([id_plato])
REFERENCES [dbo].[plato] ([id_plato])
GO
ALTER TABLE [dbo].[plato_insumo] CHECK CONSTRAINT [fk_plato_insumo_plato]
GO
ALTER TABLE [dbo].[usuarios]  WITH CHECK ADD  CONSTRAINT [fk_usuarios_empleado] FOREIGN KEY([id_empleado])
REFERENCES [dbo].[empleado] ([id_empleado])
GO
ALTER TABLE [dbo].[usuarios] CHECK CONSTRAINT [fk_usuarios_empleado]
GO
USE [master]
GO
ALTER DATABASE [CATERINGDB] SET  READ_WRITE 
GO

