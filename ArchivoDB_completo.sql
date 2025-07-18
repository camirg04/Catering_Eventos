USE MASTER
GO
CREATE DATABASE CATERINGDB
GO
USE [CATERINGDB]
GO
/****** Object:  StoredProcedure [dbo].[UpdatePedidosDeInsumos]    Script Date: 2/7/2025 16:05:58 ******/
DROP PROCEDURE [dbo].[UpdatePedidosDeInsumos]
GO
/****** Object:  StoredProcedure [dbo].[sp_updateEvento]    Script Date: 2/7/2025 16:05:58 ******/
DROP PROCEDURE [dbo].[sp_updateEvento]
GO
/****** Object:  StoredProcedure [dbo].[sp_updateCliente]    Script Date: 2/7/2025 16:05:58 ******/
DROP PROCEDURE [dbo].[sp_updateCliente]
GO
/****** Object:  StoredProcedure [dbo].[sp_todoUsuarios]    Script Date: 2/7/2025 16:05:58 ******/
DROP PROCEDURE [dbo].[sp_todoUsuarios]
GO
/****** Object:  StoredProcedure [dbo].[sp_todoEventos]    Script Date: 2/7/2025 16:05:58 ******/
DROP PROCEDURE [dbo].[sp_todoEventos]
GO
/****** Object:  StoredProcedure [dbo].[sp_onlyEvento]    Script Date: 2/7/2025 16:05:58 ******/
DROP PROCEDURE [dbo].[sp_onlyEvento]
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerPlatosPorMenu]    Script Date: 2/7/2025 16:05:58 ******/
DROP PROCEDURE [dbo].[sp_ObtenerPlatosPorMenu]
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerPlatosMenu]    Script Date: 2/7/2025 16:05:58 ******/
DROP PROCEDURE [dbo].[sp_ObtenerPlatosMenu]
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerMenusFiltrados]    Script Date: 2/7/2025 16:05:58 ******/
DROP PROCEDURE [dbo].[sp_ObtenerMenusFiltrados]
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerMailsLogisticaChefs]    Script Date: 2/7/2025 16:05:58 ******/
DROP PROCEDURE [dbo].[sp_ObtenerMailsLogisticaChefs]
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerLotesInsumoVigentes]    Script Date: 2/7/2025 16:05:58 ******/
DROP PROCEDURE [dbo].[sp_ObtenerLotesInsumoVigentes]
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerIngredientesPlatoPorPlato]    Script Date: 2/7/2025 16:05:58 ******/
DROP PROCEDURE [dbo].[sp_ObtenerIngredientesPlatoPorPlato]
GO
/****** Object:  StoredProcedure [dbo].[sp_menusDisponibles]    Script Date: 2/7/2025 16:05:58 ******/
DROP PROCEDURE [dbo].[sp_menusDisponibles]
GO
/****** Object:  StoredProcedure [dbo].[sp_listar_insumos]    Script Date: 2/7/2025 16:05:58 ******/
DROP PROCEDURE [dbo].[sp_listar_insumos]
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertarAlertaStock]    Script Date: 2/7/2025 16:05:58 ******/
DROP PROCEDURE [dbo].[sp_InsertarAlertaStock]
GO
/****** Object:  StoredProcedure [dbo].[sp_getEventoByCliente]    Script Date: 2/7/2025 16:05:58 ******/
DROP PROCEDURE [dbo].[sp_getEventoByCliente]
GO
/****** Object:  StoredProcedure [dbo].[sp_filtrar_alertas_stock]    Script Date: 2/7/2025 16:05:58 ******/
DROP PROCEDURE [dbo].[sp_filtrar_alertas_stock]
GO
/****** Object:  StoredProcedure [dbo].[sp_editarUsuario]    Script Date: 2/7/2025 16:05:58 ******/
DROP PROCEDURE [dbo].[sp_editarUsuario]
GO
/****** Object:  StoredProcedure [dbo].[sp_EditarEstadoAlerta]    Script Date: 2/7/2025 16:05:58 ******/
DROP PROCEDURE [dbo].[sp_EditarEstadoAlerta]
GO
/****** Object:  StoredProcedure [dbo].[sp_editar_insumo]    Script Date: 2/7/2025 16:05:58 ******/
DROP PROCEDURE [dbo].[sp_editar_insumo]
GO
/****** Object:  StoredProcedure [dbo].[sp_bajaUsuario]    Script Date: 2/7/2025 16:05:58 ******/
DROP PROCEDURE [dbo].[sp_bajaUsuario]
GO
/****** Object:  StoredProcedure [dbo].[sp_allInsumo]    Script Date: 2/7/2025 16:05:58 ******/
DROP PROCEDURE [dbo].[sp_allInsumo]
GO
/****** Object:  StoredProcedure [dbo].[sp_allCliente]    Script Date: 2/7/2025 16:05:58 ******/
DROP PROCEDURE [dbo].[sp_allCliente]
GO
/****** Object:  StoredProcedure [dbo].[sp_agregarUsuario]    Script Date: 2/7/2025 16:05:58 ******/
DROP PROCEDURE [dbo].[sp_agregarUsuario]
GO
/****** Object:  StoredProcedure [dbo].[sp_agregar_insumo]    Script Date: 2/7/2025 16:05:58 ******/
DROP PROCEDURE [dbo].[sp_agregar_insumo]
GO
/****** Object:  StoredProcedure [dbo].[sp_addEvento]    Script Date: 2/7/2025 16:05:58 ******/
DROP PROCEDURE [dbo].[sp_addEvento]
GO
/****** Object:  StoredProcedure [dbo].[sp_addCliente]    Script Date: 2/7/2025 16:05:58 ******/
DROP PROCEDURE [dbo].[sp_addCliente]
GO
/****** Object:  StoredProcedure [dbo].[sp_ActualizarEstadoEvento]    Script Date: 2/7/2025 16:05:58 ******/
DROP PROCEDURE [dbo].[sp_ActualizarEstadoEvento]
GO
/****** Object:  StoredProcedure [dbo].[ObtenerPedidosDeInsumos]    Script Date: 2/7/2025 16:05:58 ******/
DROP PROCEDURE [dbo].[ObtenerPedidosDeInsumos]
GO
/****** Object:  StoredProcedure [dbo].[ObtenerLotesDeInsumosxId]    Script Date: 2/7/2025 16:05:58 ******/
DROP PROCEDURE [dbo].[ObtenerLotesDeInsumosxId]
GO
/****** Object:  StoredProcedure [dbo].[ObtenerLotesDeInsumosPerecederos]    Script Date: 2/7/2025 16:05:58 ******/
DROP PROCEDURE [dbo].[ObtenerLotesDeInsumosPerecederos]
GO
/****** Object:  StoredProcedure [dbo].[ObtenerLotesDeInsumos]    Script Date: 2/7/2025 16:05:58 ******/
DROP PROCEDURE [dbo].[ObtenerLotesDeInsumos]
GO
/****** Object:  StoredProcedure [dbo].[ObtenerEventosPorEstadoYFechas]    Script Date: 2/7/2025 16:05:58 ******/
DROP PROCEDURE [dbo].[ObtenerEventosPorEstadoYFechas]
GO
/****** Object:  StoredProcedure [dbo].[ListarPlatosPorMenu]    Script Date: 2/7/2025 16:05:58 ******/
DROP PROCEDURE [dbo].[ListarPlatosPorMenu]
GO
/****** Object:  StoredProcedure [dbo].[EliminarPlatoMenu]    Script Date: 2/7/2025 16:05:58 ******/
DROP PROCEDURE [dbo].[EliminarPlatoMenu]
GO
/****** Object:  StoredProcedure [dbo].[EditarMenu]    Script Date: 2/7/2025 16:05:58 ******/
DROP PROCEDURE [dbo].[EditarMenu]
GO
/****** Object:  StoredProcedure [dbo].[CrearMenu]    Script Date: 2/7/2025 16:05:58 ******/
DROP PROCEDURE [dbo].[CrearMenu]
GO
/****** Object:  StoredProcedure [dbo].[BuscarMenu]    Script Date: 2/7/2025 16:05:58 ******/
DROP PROCEDURE [dbo].[BuscarMenu]
GO
/****** Object:  StoredProcedure [dbo].[AgregarPlatoMenu]    Script Date: 2/7/2025 16:05:58 ******/
DROP PROCEDURE [dbo].[AgregarPlatoMenu]
GO
/****** Object:  StoredProcedure [dbo].[addPedidoInsumo]    Script Date: 2/7/2025 16:05:58 ******/
DROP PROCEDURE [dbo].[addPedidoInsumo]
GO
/****** Object:  StoredProcedure [dbo].[ActualizarStockLote]    Script Date: 2/7/2025 16:05:58 ******/
DROP PROCEDURE [dbo].[ActualizarStockLote]
GO
/****** Object:  StoredProcedure [dbo].[ActualizarCostoyFechaLote]    Script Date: 2/7/2025 16:05:58 ******/
DROP PROCEDURE [dbo].[ActualizarCostoyFechaLote]
GO
ALTER TABLE [dbo].[plato_insumo] DROP CONSTRAINT [fk_plato_insumo_plato]
GO
ALTER TABLE [dbo].[plato_insumo] DROP CONSTRAINT [fk_plato_insumo_insumo]
GO
ALTER TABLE [dbo].[pedido_insumo] DROP CONSTRAINT [fk_pedido_usuario]
GO
ALTER TABLE [dbo].[pedido_insumo] DROP CONSTRAINT [fk_pedido_insumo]
GO
ALTER TABLE [dbo].[menu_plato] DROP CONSTRAINT [fk_menu_plato_plato]
GO
ALTER TABLE [dbo].[menu_plato] DROP CONSTRAINT [fk_menu_plato_menu]
GO
ALTER TABLE [dbo].[lotes_insumo] DROP CONSTRAINT [fk_lotes_insumo]
GO
ALTER TABLE [dbo].[lotes_insumo] DROP CONSTRAINT [fk_lote_pedido]
GO
ALTER TABLE [dbo].[evento] DROP CONSTRAINT [fk_evento_usuario]
GO
ALTER TABLE [dbo].[evento] DROP CONSTRAINT [fk_evento_menu]
GO
ALTER TABLE [dbo].[evento] DROP CONSTRAINT [fk_evento_cliente]
GO
ALTER TABLE [dbo].[alerta_stock] DROP CONSTRAINT [fk_alerta_insumo]
GO
ALTER TABLE [dbo].[usuarios] DROP CONSTRAINT [DF__usuarios__fecha___4AB81AF0]
GO
ALTER TABLE [dbo].[alerta_stock] DROP CONSTRAINT [DF__alerta_st__fecha__49C3F6B7]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 2/7/2025 16:05:58 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usuarios]') AND type in (N'U'))
DROP TABLE [dbo].[usuarios]
GO
/****** Object:  Table [dbo].[plato_insumo]    Script Date: 2/7/2025 16:05:58 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[plato_insumo]') AND type in (N'U'))
DROP TABLE [dbo].[plato_insumo]
GO
/****** Object:  Table [dbo].[plato]    Script Date: 2/7/2025 16:05:58 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[plato]') AND type in (N'U'))
DROP TABLE [dbo].[plato]
GO
/****** Object:  Table [dbo].[pedido_insumo]    Script Date: 2/7/2025 16:05:58 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pedido_insumo]') AND type in (N'U'))
DROP TABLE [dbo].[pedido_insumo]
GO
/****** Object:  Table [dbo].[menu_plato]    Script Date: 2/7/2025 16:05:58 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[menu_plato]') AND type in (N'U'))
DROP TABLE [dbo].[menu_plato]
GO
/****** Object:  Table [dbo].[menu]    Script Date: 2/7/2025 16:05:58 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[menu]') AND type in (N'U'))
DROP TABLE [dbo].[menu]
GO
/****** Object:  Table [dbo].[lotes_insumo]    Script Date: 2/7/2025 16:05:58 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[lotes_insumo]') AND type in (N'U'))
DROP TABLE [dbo].[lotes_insumo]
GO
/****** Object:  Table [dbo].[insumo]    Script Date: 2/7/2025 16:05:58 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[insumo]') AND type in (N'U'))
DROP TABLE [dbo].[insumo]
GO
/****** Object:  Table [dbo].[evento]    Script Date: 2/7/2025 16:05:58 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[evento]') AND type in (N'U'))
DROP TABLE [dbo].[evento]
GO
/****** Object:  Table [dbo].[clientes]    Script Date: 2/7/2025 16:05:58 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[clientes]') AND type in (N'U'))
DROP TABLE [dbo].[clientes]
GO
/****** Object:  Table [dbo].[alerta_stock]    Script Date: 2/7/2025 16:05:58 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[alerta_stock]') AND type in (N'U'))
DROP TABLE [dbo].[alerta_stock]
GO
/****** Object:  Table [dbo].[alerta_stock]    Script Date: 2/7/2025 16:05:58 ******/
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
/****** Object:  Table [dbo].[clientes]    Script Date: 2/7/2025 16:05:58 ******/
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
/****** Object:  Table [dbo].[evento]    Script Date: 2/7/2025 16:05:58 ******/
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
/****** Object:  Table [dbo].[insumo]    Script Date: 2/7/2025 16:05:58 ******/
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
/****** Object:  Table [dbo].[lotes_insumo]    Script Date: 2/7/2025 16:05:58 ******/
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
/****** Object:  Table [dbo].[menu]    Script Date: 2/7/2025 16:05:58 ******/
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
/****** Object:  Table [dbo].[menu_plato]    Script Date: 2/7/2025 16:05:58 ******/
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
/****** Object:  Table [dbo].[pedido_insumo]    Script Date: 2/7/2025 16:05:58 ******/
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
/****** Object:  Table [dbo].[plato]    Script Date: 2/7/2025 16:05:58 ******/
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
/****** Object:  Table [dbo].[plato_insumo]    Script Date: 2/7/2025 16:05:58 ******/
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
/****** Object:  Table [dbo].[usuarios]    Script Date: 2/7/2025 16:05:58 ******/
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
	[dni_empleado] [varchar](8) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[domicilio] [varchar](50) NOT NULL,
	[telefono] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[alerta_stock] ON 

INSERT [dbo].[alerta_stock] ([id_alerta], [id_insumo], [fecha_alerta], [estado_alerta]) VALUES (1, 2, CAST(N'2025-06-09T23:33:58.630' AS DateTime), N'PENDIENTE')
INSERT [dbo].[alerta_stock] ([id_alerta], [id_insumo], [fecha_alerta], [estado_alerta]) VALUES (2, 5, CAST(N'2025-06-07T23:33:58.630' AS DateTime), N'RESUELTO')
INSERT [dbo].[alerta_stock] ([id_alerta], [id_insumo], [fecha_alerta], [estado_alerta]) VALUES (3, 6, CAST(N'2025-06-02T23:33:58.630' AS DateTime), N'PENDIENTE')
INSERT [dbo].[alerta_stock] ([id_alerta], [id_insumo], [fecha_alerta], [estado_alerta]) VALUES (4, 4, CAST(N'2025-06-13T00:24:51.527' AS DateTime), N'PENDIENTE')
INSERT [dbo].[alerta_stock] ([id_alerta], [id_insumo], [fecha_alerta], [estado_alerta]) VALUES (9, 4, CAST(N'2025-06-13T18:05:05.127' AS DateTime), N'PENDIENTE')
INSERT [dbo].[alerta_stock] ([id_alerta], [id_insumo], [fecha_alerta], [estado_alerta]) VALUES (10, 3, CAST(N'2025-06-27T20:15:09.560' AS DateTime), N'RESUELTO')
INSERT [dbo].[alerta_stock] ([id_alerta], [id_insumo], [fecha_alerta], [estado_alerta]) VALUES (11, 3, CAST(N'2025-06-27T20:22:18.157' AS DateTime), N'PENDIENTE')
INSERT [dbo].[alerta_stock] ([id_alerta], [id_insumo], [fecha_alerta], [estado_alerta]) VALUES (12, 3, CAST(N'2025-07-02T15:18:26.597' AS DateTime), N'PENDIENTE')
INSERT [dbo].[alerta_stock] ([id_alerta], [id_insumo], [fecha_alerta], [estado_alerta]) VALUES (13, 6, CAST(N'2025-07-02T15:31:59.853' AS DateTime), N'PENDIENTE')
INSERT [dbo].[alerta_stock] ([id_alerta], [id_insumo], [fecha_alerta], [estado_alerta]) VALUES (14, 3, CAST(N'2025-07-02T15:32:09.697' AS DateTime), N'PENDIENTE')
SET IDENTITY_INSERT [dbo].[alerta_stock] OFF
GO
SET IDENTITY_INSERT [dbo].[clientes] ON 

INSERT [dbo].[clientes] ([id_cliente], [nombre], [apellido], [email], [telefono], [domicilio], [dni]) VALUES (1, N'Roberto', N'García', N'roberto.garcia@mail.com', N'1167890123', N'Av. Rivadavia 1234', N'201234')
INSERT [dbo].[clientes] ([id_cliente], [nombre], [apellido], [email], [telefono], [domicilio], [dni]) VALUES (2, N'Laura', N'Fernández', N'laura.fernandez@mail.com', N'1167890124', N'Calle 10 N° 567', N'22123456')
INSERT [dbo].[clientes] ([id_cliente], [nombre], [apellido], [email], [telefono], [domicilio], [dni]) VALUES (3, N'Miguel', N'Díaz', N'miguel.diaz@mail.com', N'1167890125', N'Av. Santa Fe 789', N'24123456')
INSERT [dbo].[clientes] ([id_cliente], [nombre], [apellido], [email], [telefono], [domicilio], [dni]) VALUES (40, N'marisa', N'gonzalez', N'pepeppe', N'2332', N'boulevard bs as 15445', N'233323')
INSERT [dbo].[clientes] ([id_cliente], [nombre], [apellido], [email], [telefono], [domicilio], [dni]) VALUES (41, N'Camila', N'Gonzalez', N'dldel@kdemfke', N'eee', N'wded', N'eee')
INSERT [dbo].[clientes] ([id_cliente], [nombre], [apellido], [email], [telefono], [domicilio], [dni]) VALUES (42, N'Maria', N'Ferrarese', N'maria@gmail.com', N'2332', N'owko 33', N'3232')
INSERT [dbo].[clientes] ([id_cliente], [nombre], [apellido], [email], [telefono], [domicilio], [dni]) VALUES (43, N'Paula', N'Rodriguez', N'pau@hdhd.com', N'44444', N'wdd 44', N'4444')
INSERT [dbo].[clientes] ([id_cliente], [nombre], [apellido], [email], [telefono], [domicilio], [dni]) VALUES (44, N'Luis', N'Gomez', N'luis@noexiste.com', N'545456', N'iejdi', N'48548')
SET IDENTITY_INSERT [dbo].[clientes] OFF
GO
SET IDENTITY_INSERT [dbo].[evento] ON 

INSERT [dbo].[evento] ([id_evento], [id_cliente], [id_menu], [fecha_evento], [descuento_aplicado], [direccion], [localidad], [estado_evento], [cantidad_personas], [total_estimado], [evento_pago], [id_usuario_venta]) VALUES (1, 1, 3, CAST(N'2025-06-20' AS Date), CAST(0.00 AS Decimal(10, 2)), N'Av. Libertador 1234', N'CABA', N'PROCESO', 50, CAST(175000.00 AS Decimal(10, 2)), 0, 3)
INSERT [dbo].[evento] ([id_evento], [id_cliente], [id_menu], [fecha_evento], [descuento_aplicado], [direccion], [localidad], [estado_evento], [cantidad_personas], [total_estimado], [evento_pago], [id_usuario_venta]) VALUES (2, 2, 1, CAST(N'2025-07-13' AS Date), CAST(10.00 AS Decimal(10, 2)), N'Calle 10 N° 567', N'CABA', N'PENDIENTE', 30, CAST(67500.00 AS Decimal(10, 2)), 0, 3)
INSERT [dbo].[evento] ([id_evento], [id_cliente], [id_menu], [fecha_evento], [descuento_aplicado], [direccion], [localidad], [estado_evento], [cantidad_personas], [total_estimado], [evento_pago], [id_usuario_venta]) VALUES (3, 3, 3, CAST(N'2025-07-20' AS Date), CAST(0.00 AS Decimal(10, 2)), N'Av. Santa Fe 789', N'CABA', N'PROCESO', 20, CAST(56000.00 AS Decimal(10, 2)), 1, 3)
INSERT [dbo].[evento] ([id_evento], [id_cliente], [id_menu], [fecha_evento], [descuento_aplicado], [direccion], [localidad], [estado_evento], [cantidad_personas], [total_estimado], [evento_pago], [id_usuario_venta]) VALUES (4, 3, 2, CAST(N'2025-06-13' AS Date), CAST(5.00 AS Decimal(10, 2)), N'Av. Santa Fe 789', N'Luis Guillon', N'PENDIENTE', 101, CAST(335825.00 AS Decimal(10, 2)), 1, 3)
INSERT [dbo].[evento] ([id_evento], [id_cliente], [id_menu], [fecha_evento], [descuento_aplicado], [direccion], [localidad], [estado_evento], [cantidad_personas], [total_estimado], [evento_pago], [id_usuario_venta]) VALUES (5, 3, 2, CAST(N'2025-07-31' AS Date), CAST(10.00 AS Decimal(10, 2)), N'Av. Santa Fe 789', N'Monte Grande', N'PENDIENTE', 200, CAST(630000.00 AS Decimal(10, 2)), 1, 3)
SET IDENTITY_INSERT [dbo].[evento] OFF
GO
SET IDENTITY_INSERT [dbo].[insumo] ON 

INSERT [dbo].[insumo] ([id_insumo], [nombre], [unidad_medida], [perecedero], [stock_minimo], [fecha_baja]) VALUES (1, N'Harina', N'kg', 0, CAST(50.00 AS Decimal(10, 2)), NULL)
INSERT [dbo].[insumo] ([id_insumo], [nombre], [unidad_medida], [perecedero], [stock_minimo], [fecha_baja]) VALUES (2, N'Pollo', N'kg', 1, CAST(28.00 AS Decimal(10, 2)), CAST(N'2025-07-01' AS Date))
INSERT [dbo].[insumo] ([id_insumo], [nombre], [unidad_medida], [perecedero], [stock_minimo], [fecha_baja]) VALUES (3, N'Carne vacuna', N'kg', 1, CAST(25.00 AS Decimal(10, 2)), NULL)
INSERT [dbo].[insumo] ([id_insumo], [nombre], [unidad_medida], [perecedero], [stock_minimo], [fecha_baja]) VALUES (4, N'Arroz', N'kg', 0, CAST(30.00 AS Decimal(10, 2)), NULL)
INSERT [dbo].[insumo] ([id_insumo], [nombre], [unidad_medida], [perecedero], [stock_minimo], [fecha_baja]) VALUES (5, N'Tomate', N'kg', 1, CAST(15.00 AS Decimal(10, 2)), NULL)
INSERT [dbo].[insumo] ([id_insumo], [nombre], [unidad_medida], [perecedero], [stock_minimo], [fecha_baja]) VALUES (6, N'Lechuga', N'kg', 1, CAST(10.00 AS Decimal(10, 2)), NULL)
INSERT [dbo].[insumo] ([id_insumo], [nombre], [unidad_medida], [perecedero], [stock_minimo], [fecha_baja]) VALUES (7, N'Queso', N'kg', 1, CAST(12.00 AS Decimal(10, 2)), NULL)
INSERT [dbo].[insumo] ([id_insumo], [nombre], [unidad_medida], [perecedero], [stock_minimo], [fecha_baja]) VALUES (8, N'Vino tinto', N'lt', 0, CAST(20.00 AS Decimal(10, 2)), NULL)
INSERT [dbo].[insumo] ([id_insumo], [nombre], [unidad_medida], [perecedero], [stock_minimo], [fecha_baja]) VALUES (9, N'Pan', N'kg', 1, CAST(100.00 AS Decimal(10, 2)), NULL)
INSERT [dbo].[insumo] ([id_insumo], [nombre], [unidad_medida], [perecedero], [stock_minimo], [fecha_baja]) VALUES (10, N'Sal', N'kg', 0, CAST(5.00 AS Decimal(10, 2)), NULL)
INSERT [dbo].[insumo] ([id_insumo], [nombre], [unidad_medida], [perecedero], [stock_minimo], [fecha_baja]) VALUES (11, N'Harina de garbanzo', N'kg', 0, CAST(34.00 AS Decimal(10, 2)), NULL)
INSERT [dbo].[insumo] ([id_insumo], [nombre], [unidad_medida], [perecedero], [stock_minimo], [fecha_baja]) VALUES (12, N'Carne picada', N'kg', 1, CAST(60.00 AS Decimal(10, 2)), NULL)
SET IDENTITY_INSERT [dbo].[insumo] OFF
GO
SET IDENTITY_INSERT [dbo].[lotes_insumo] ON 

INSERT [dbo].[lotes_insumo] ([id_lote], [id_insumo], [cantidad], [fecha_ingreso], [fecha_vencimiento], [costo_unitario], [id_pedido]) VALUES (1, 5, CAST(1000.00 AS Decimal(10, 2)), CAST(N'2025-04-29' AS Date), CAST(N'2025-06-12' AS Date), CAST(150.00 AS Decimal(10, 2)), 2)
INSERT [dbo].[lotes_insumo] ([id_lote], [id_insumo], [cantidad], [fecha_ingreso], [fecha_vencimiento], [costo_unitario], [id_pedido]) VALUES (2, 3, CAST(1000.00 AS Decimal(10, 2)), CAST(N'2025-04-26' AS Date), CAST(N'2025-06-20' AS Date), CAST(450.00 AS Decimal(10, 2)), 3)
INSERT [dbo].[lotes_insumo] ([id_lote], [id_insumo], [cantidad], [fecha_ingreso], [fecha_vencimiento], [costo_unitario], [id_pedido]) VALUES (3, 7, CAST(1000.00 AS Decimal(10, 2)), CAST(N'2025-05-11' AS Date), CAST(N'2025-06-11' AS Date), CAST(320.00 AS Decimal(10, 2)), 4)
INSERT [dbo].[lotes_insumo] ([id_lote], [id_insumo], [cantidad], [fecha_ingreso], [fecha_vencimiento], [costo_unitario], [id_pedido]) VALUES (4, 2, CAST(1000.00 AS Decimal(10, 2)), CAST(N'2025-05-13' AS Date), CAST(N'2025-05-13' AS Date), CAST(280.00 AS Decimal(10, 2)), 5)
INSERT [dbo].[lotes_insumo] ([id_lote], [id_insumo], [cantidad], [fecha_ingreso], [fecha_vencimiento], [costo_unitario], [id_pedido]) VALUES (5, 8, CAST(1000.00 AS Decimal(10, 2)), CAST(N'2025-05-19' AS Date), NULL, CAST(450.00 AS Decimal(10, 2)), 7)
INSERT [dbo].[lotes_insumo] ([id_lote], [id_insumo], [cantidad], [fecha_ingreso], [fecha_vencimiento], [costo_unitario], [id_pedido]) VALUES (6, 1, CAST(1000.00 AS Decimal(10, 2)), CAST(N'2025-05-21' AS Date), NULL, CAST(85.00 AS Decimal(10, 2)), 8)
INSERT [dbo].[lotes_insumo] ([id_lote], [id_insumo], [cantidad], [fecha_ingreso], [fecha_vencimiento], [costo_unitario], [id_pedido]) VALUES (7, 4, CAST(640.00 AS Decimal(10, 2)), CAST(N'2025-05-23' AS Date), NULL, CAST(120.00 AS Decimal(10, 2)), 9)
INSERT [dbo].[lotes_insumo] ([id_lote], [id_insumo], [cantidad], [fecha_ingreso], [fecha_vencimiento], [costo_unitario], [id_pedido]) VALUES (8, 3, CAST(1000.00 AS Decimal(10, 2)), CAST(N'2025-05-29' AS Date), CAST(N'2025-06-14' AS Date), CAST(480.00 AS Decimal(10, 2)), 11)
INSERT [dbo].[lotes_insumo] ([id_lote], [id_insumo], [cantidad], [fecha_ingreso], [fecha_vencimiento], [costo_unitario], [id_pedido]) VALUES (9, 5, CAST(1000.00 AS Decimal(10, 2)), CAST(N'2025-05-29' AS Date), CAST(N'2025-07-05' AS Date), CAST(160.00 AS Decimal(10, 2)), 12)
INSERT [dbo].[lotes_insumo] ([id_lote], [id_insumo], [cantidad], [fecha_ingreso], [fecha_vencimiento], [costo_unitario], [id_pedido]) VALUES (10, 7, CAST(1000.00 AS Decimal(10, 2)), CAST(N'2025-05-29' AS Date), CAST(N'2025-05-29' AS Date), CAST(320.00 AS Decimal(10, 2)), 13)
INSERT [dbo].[lotes_insumo] ([id_lote], [id_insumo], [cantidad], [fecha_ingreso], [fecha_vencimiento], [costo_unitario], [id_pedido]) VALUES (11, 9, CAST(121.00 AS Decimal(10, 2)), CAST(N'2025-06-30' AS Date), CAST(N'2025-06-23' AS Date), CAST(1000.00 AS Decimal(10, 2)), 10)
INSERT [dbo].[lotes_insumo] ([id_lote], [id_insumo], [cantidad], [fecha_ingreso], [fecha_vencimiento], [costo_unitario], [id_pedido]) VALUES (12, 7, CAST(6.00 AS Decimal(10, 2)), CAST(N'2025-06-30' AS Date), CAST(N'2025-06-30' AS Date), CAST(30000.00 AS Decimal(10, 2)), 14)
INSERT [dbo].[lotes_insumo] ([id_lote], [id_insumo], [cantidad], [fecha_ingreso], [fecha_vencimiento], [costo_unitario], [id_pedido]) VALUES (13, 1, CAST(30.00 AS Decimal(10, 2)), CAST(N'2025-07-01' AS Date), CAST(N'2025-07-01' AS Date), CAST(3000.00 AS Decimal(10, 2)), 16)
SET IDENTITY_INSERT [dbo].[lotes_insumo] OFF
GO
SET IDENTITY_INSERT [dbo].[menu] ON 

INSERT [dbo].[menu] ([id_menu], [nombre], [precio_x_persona], [fecha_baja]) VALUES (1, N'Menú Ejecutivo', CAST(2580.90 AS Decimal(10, 2)), NULL)
INSERT [dbo].[menu] ([id_menu], [nombre], [precio_x_persona], [fecha_baja]) VALUES (2, N'Menú Premium', CAST(3500.00 AS Decimal(10, 2)), NULL)
INSERT [dbo].[menu] ([id_menu], [nombre], [precio_x_persona], [fecha_baja]) VALUES (3, N'Menú Vegetariano', CAST(2800.00 AS Decimal(10, 2)), NULL)
INSERT [dbo].[menu] ([id_menu], [nombre], [precio_x_persona], [fecha_baja]) VALUES (4, N'Menú Infantil', CAST(1800.00 AS Decimal(10, 2)), NULL)
INSERT [dbo].[menu] ([id_menu], [nombre], [precio_x_persona], [fecha_baja]) VALUES (5, N'Menú x', CAST(100.00 AS Decimal(10, 2)), CAST(N'2025-06-20' AS Date))
INSERT [dbo].[menu] ([id_menu], [nombre], [precio_x_persona], [fecha_baja]) VALUES (6, N'Menú y', CAST(500.00 AS Decimal(10, 2)), NULL)
INSERT [dbo].[menu] ([id_menu], [nombre], [precio_x_persona], [fecha_baja]) VALUES (7, N'Menu h', CAST(234.00 AS Decimal(10, 2)), NULL)
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
INSERT [dbo].[menu_plato] ([id_menu], [id_plato], [id_menu_plato]) VALUES (7, 2, 13)
INSERT [dbo].[menu_plato] ([id_menu], [id_plato], [id_menu_plato]) VALUES (6, 2, 15)
INSERT [dbo].[menu_plato] ([id_menu], [id_plato], [id_menu_plato]) VALUES (6, 4, 16)
INSERT [dbo].[menu_plato] ([id_menu], [id_plato], [id_menu_plato]) VALUES (5, 4, 18)
INSERT [dbo].[menu_plato] ([id_menu], [id_plato], [id_menu_plato]) VALUES (7, 4, 20)
INSERT [dbo].[menu_plato] ([id_menu], [id_plato], [id_menu_plato]) VALUES (7, 3, 21)
SET IDENTITY_INSERT [dbo].[menu_plato] OFF
GO
INSERT [dbo].[pedido_insumo] ([id_pedido_insumo], [id_insumo], [cantidad], [fecha_pedido], [estado_pedido], [id_usuario_pedido]) VALUES (1, 2, CAST(30.00 AS Decimal(10, 2)), CAST(N'2025-06-29' AS Date), N'PENDIENTE', 4)
INSERT [dbo].[pedido_insumo] ([id_pedido_insumo], [id_insumo], [cantidad], [fecha_pedido], [estado_pedido], [id_usuario_pedido]) VALUES (2, 5, CAST(20.00 AS Decimal(10, 2)), CAST(N'2025-06-29' AS Date), N'CANCELADO', 4)
INSERT [dbo].[pedido_insumo] ([id_pedido_insumo], [id_insumo], [cantidad], [fecha_pedido], [estado_pedido], [id_usuario_pedido]) VALUES (3, 3, CAST(40.00 AS Decimal(10, 2)), CAST(N'2025-06-26' AS Date), N'CANCELADO', 4)
INSERT [dbo].[pedido_insumo] ([id_pedido_insumo], [id_insumo], [cantidad], [fecha_pedido], [estado_pedido], [id_usuario_pedido]) VALUES (4, 7, CAST(15.00 AS Decimal(10, 2)), CAST(N'2025-07-10' AS Date), N'ENTREGADO', 4)
INSERT [dbo].[pedido_insumo] ([id_pedido_insumo], [id_insumo], [cantidad], [fecha_pedido], [estado_pedido], [id_usuario_pedido]) VALUES (5, 2, CAST(25.00 AS Decimal(10, 2)), CAST(N'2025-07-12' AS Date), N'ENTREGADO', 4)
INSERT [dbo].[pedido_insumo] ([id_pedido_insumo], [id_insumo], [cantidad], [fecha_pedido], [estado_pedido], [id_usuario_pedido]) VALUES (6, 6, CAST(13.00 AS Decimal(10, 2)), CAST(N'2025-07-15' AS Date), N'PENDIENTE', 4)
INSERT [dbo].[pedido_insumo] ([id_pedido_insumo], [id_insumo], [cantidad], [fecha_pedido], [estado_pedido], [id_usuario_pedido]) VALUES (7, 8, CAST(30.00 AS Decimal(10, 2)), CAST(N'2025-07-18' AS Date), N'ENTREGADO', 4)
INSERT [dbo].[pedido_insumo] ([id_pedido_insumo], [id_insumo], [cantidad], [fecha_pedido], [estado_pedido], [id_usuario_pedido]) VALUES (8, 1, CAST(100.00 AS Decimal(10, 2)), CAST(N'2025-06-20' AS Date), N'ENTREGADO', 4)
INSERT [dbo].[pedido_insumo] ([id_pedido_insumo], [id_insumo], [cantidad], [fecha_pedido], [estado_pedido], [id_usuario_pedido]) VALUES (9, 4, CAST(50.00 AS Decimal(10, 2)), CAST(N'2025-06-22' AS Date), N'ENTREGADO', 4)
INSERT [dbo].[pedido_insumo] ([id_pedido_insumo], [id_insumo], [cantidad], [fecha_pedido], [estado_pedido], [id_usuario_pedido]) VALUES (10, 9, CAST(121.00 AS Decimal(10, 2)), CAST(N'2025-06-25' AS Date), N'ENTREGADO', 4)
INSERT [dbo].[pedido_insumo] ([id_pedido_insumo], [id_insumo], [cantidad], [fecha_pedido], [estado_pedido], [id_usuario_pedido]) VALUES (11, 3, CAST(60.00 AS Decimal(10, 2)), CAST(N'2025-05-28' AS Date), N'ENTREGADO', 4)
INSERT [dbo].[pedido_insumo] ([id_pedido_insumo], [id_insumo], [cantidad], [fecha_pedido], [estado_pedido], [id_usuario_pedido]) VALUES (12, 5, CAST(40.00 AS Decimal(10, 2)), CAST(N'2025-05-28' AS Date), N'ENTREGADO', 4)
INSERT [dbo].[pedido_insumo] ([id_pedido_insumo], [id_insumo], [cantidad], [fecha_pedido], [estado_pedido], [id_usuario_pedido]) VALUES (13, 7, CAST(25.00 AS Decimal(10, 2)), CAST(N'2025-05-28' AS Date), N'ENTREGADO', 4)
INSERT [dbo].[pedido_insumo] ([id_pedido_insumo], [id_insumo], [cantidad], [fecha_pedido], [estado_pedido], [id_usuario_pedido]) VALUES (14, 7, CAST(6.00 AS Decimal(10, 2)), CAST(N'2025-06-30' AS Date), N'ENTREGADO', 4)
INSERT [dbo].[pedido_insumo] ([id_pedido_insumo], [id_insumo], [cantidad], [fecha_pedido], [estado_pedido], [id_usuario_pedido]) VALUES (15, 7, CAST(6.00 AS Decimal(10, 2)), CAST(N'2025-06-30' AS Date), N'PENDIENTE', 4)
INSERT [dbo].[pedido_insumo] ([id_pedido_insumo], [id_insumo], [cantidad], [fecha_pedido], [estado_pedido], [id_usuario_pedido]) VALUES (16, 1, CAST(30.00 AS Decimal(10, 2)), CAST(N'2025-07-01' AS Date), N'ENTREGADO', 4)
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

INSERT [dbo].[plato_insumo] ([id_plato], [id_insumo], [cantidad_necesaria], [id_plato_insumo]) VALUES (1, 3, CAST(1.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[plato_insumo] ([id_plato], [id_insumo], [cantidad_necesaria], [id_plato_insumo]) VALUES (2, 6, CAST(1.00 AS Decimal(10, 2)), 4)
INSERT [dbo].[plato_insumo] ([id_plato], [id_insumo], [cantidad_necesaria], [id_plato_insumo]) VALUES (3, 4, CAST(1.00 AS Decimal(10, 2)), 6)
INSERT [dbo].[plato_insumo] ([id_plato], [id_insumo], [cantidad_necesaria], [id_plato_insumo]) VALUES (5, 1, CAST(1.00 AS Decimal(10, 2)), 8)
INSERT [dbo].[plato_insumo] ([id_plato], [id_insumo], [cantidad_necesaria], [id_plato_insumo]) VALUES (5, 12, CAST(0.10 AS Decimal(10, 2)), 31)
INSERT [dbo].[plato_insumo] ([id_plato], [id_insumo], [cantidad_necesaria], [id_plato_insumo]) VALUES (5, 10, CAST(0.01 AS Decimal(10, 2)), 32)
INSERT [dbo].[plato_insumo] ([id_plato], [id_insumo], [cantidad_necesaria], [id_plato_insumo]) VALUES (1, 4, CAST(1.00 AS Decimal(10, 2)), 33)
SET IDENTITY_INSERT [dbo].[plato_insumo] OFF
GO
SET IDENTITY_INSERT [dbo].[usuarios] ON 

INSERT [dbo].[usuarios] ([id_usuario], [email], [clave], [perfil], [fecha_creacion], [fecha_baja], [dni_empleado], [nombre], [apellido], [domicilio], [telefono]) VALUES (1, N'admi', N'admi', N'ADMINISTRADOR', CAST(N'2025-04-29' AS Date), NULL, N'12545454', N'Carlos', N'Gomez', N'calle falsa 123', N'11454844')
INSERT [dbo].[usuarios] ([id_usuario], [email], [clave], [perfil], [fecha_creacion], [fecha_baja], [dni_empleado], [nombre], [apellido], [domicilio], [telefono]) VALUES (2, N'gerente', N'gerente', N'GERENTE', CAST(N'2025-04-29' AS Date), NULL, N'40587777', N'Maria', N'Ferrarese', N'Calle falsa 568', N'11658724')
INSERT [dbo].[usuarios] ([id_usuario], [email], [clave], [perfil], [fecha_creacion], [fecha_baja], [dni_empleado], [nombre], [apellido], [domicilio], [telefono]) VALUES (3, N'vend', N'vend', N'VENDEDOR', CAST(N'2025-04-29' AS Date), NULL, N'69885555', N'Roberto', N'Bustamante', N'calle falsa 545', N'11215212')
INSERT [dbo].[usuarios] ([id_usuario], [email], [clave], [perfil], [fecha_creacion], [fecha_baja], [dni_empleado], [nombre], [apellido], [domicilio], [telefono]) VALUES (4, N'logistica', N'logistica', N'LOGISTICA', CAST(N'2025-04-29' AS Date), NULL, N'95874744', N'Ariel', N'Montes', N'otra calle  555', N'11324121')
INSERT [dbo].[usuarios] ([id_usuario], [email], [clave], [perfil], [fecha_creacion], [fecha_baja], [dni_empleado], [nombre], [apellido], [domicilio], [telefono]) VALUES (5, N'camila.gonzalez.ro.2@gmail.com', N'chef', N'CHEF', CAST(N'2025-04-29' AS Date), NULL, N'23547895', N'Gabriela', N'Franco', N'otra calle 111', N'777777')
INSERT [dbo].[usuarios] ([id_usuario], [email], [clave], [perfil], [fecha_creacion], [fecha_baja], [dni_empleado], [nombre], [apellido], [domicilio], [telefono]) VALUES (6, N'camilita.rg@hotmail.com', N'1234', N'LOGISTICA', CAST(N'2025-07-01' AS Date), NULL, N'35214788', N'Armando', N'Barreda', N'Ciudad Capitolio 451', N'14523652')
INSERT [dbo].[usuarios] ([id_usuario], [email], [clave], [perfil], [fecha_creacion], [fecha_baja], [dni_empleado], [nombre], [apellido], [domicilio], [telefono]) VALUES (7, N'camila.gonzalez.ro.2@gmail.com', N'clave714', N'CHEF', CAST(N'2025-07-02' AS Date), NULL, N'2322111', N'Maria', N'Ferrarese', N'Matienzo 7373', N'2982892')
INSERT [dbo].[usuarios] ([id_usuario], [email], [clave], [perfil], [fecha_creacion], [fecha_baja], [dni_empleado], [nombre], [apellido], [domicilio], [telefono]) VALUES (8, N'camila.gonzalez.ro.2@gmail.com', N'121531', N'CHEF', CAST(N'2025-07-02' AS Date), NULL, N'556156', N'efew', N'esfw', N'575', N'5758')
SET IDENTITY_INSERT [dbo].[usuarios] OFF
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
/****** Object:  StoredProcedure [dbo].[ActualizarCostoyFechaLote]    Script Date: 2/7/2025 16:05:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ActualizarCostoyFechaLote]
    @idLote INT,
    @costo DECIMAL(18, 2),
	@fecha_vence date
AS
BEGIN
    UPDATE lotes_insumo
    SET costo_unitario = @costo,fecha_vencimiento = @fecha_vence
    WHERE id_lote = @idLote
END
GO
/****** Object:  StoredProcedure [dbo].[ActualizarStockLote]    Script Date: 2/7/2025 16:05:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ActualizarStockLote]
    @idLote INT,
    @cantidad DECIMAL(18, 2)
AS
BEGIN
    UPDATE lotes_insumo
    SET cantidad = @cantidad
    WHERE id_lote = @idLote
END
GO
/****** Object:  StoredProcedure [dbo].[addPedidoInsumo]    Script Date: 2/7/2025 16:05:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[addPedidoInsumo]
  @id_insumo bigint,
  @cantidad decimal(10,2),
  @fecha_pedido date,
  @estado_pedido varchar(45),
  @id_usuario_pedido bigint
AS
BEGIN
  DECLARE @nuevo_id bigint;

  SELECT @nuevo_id = ISNULL(MAX(id_pedido_insumo), 0) + 1 FROM pedido_insumo;

  INSERT INTO pedido_insumo (
      id_pedido_insumo, id_insumo, cantidad, fecha_pedido, estado_pedido, id_usuario_pedido
  )
  VALUES (
      @nuevo_id, @id_insumo, @cantidad, @fecha_pedido, @estado_pedido, @id_usuario_pedido
  );

END;
GO
/****** Object:  StoredProcedure [dbo].[AgregarPlatoMenu]    Script Date: 2/7/2025 16:05:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AgregarPlatoMenu]
    @id_menu INT,
    @id_plato INT
AS
BEGIN
    -- Validar si el menú ya está en un evento
    IF EXISTS (
        SELECT 1 FROM evento WHERE id_menu = @id_menu
    )
    BEGIN
        SELECT 'El menú ya está asociado a un evento' AS mensaje;
        RETURN;
    END

    -- Validar si ya existe la relación menú-plato
    IF EXISTS (
        SELECT 1 FROM menu_plato WHERE id_menu = @id_menu AND id_plato = @id_plato
    )
    BEGIN
        SELECT 'No se puede duplicar el plato en el menú' AS mensaje;
        RETURN;
    END

    -- Insertar si pasa las validaciones
    INSERT INTO menu_plato (id_menu, id_plato)
    VALUES (@id_menu, @id_plato);

    -- Confirmación
    SELECT 'OK' AS mensaje;
END
GO
/****** Object:  StoredProcedure [dbo].[BuscarMenu]    Script Date: 2/7/2025 16:05:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BuscarMenu]
    @nombre NVARCHAR(100) = NULL,
    @activos BIT = NULL  -- 1 = solo activos (fecha_baja IS NULL), 0 = solo dados de baja, NULL = todos
AS
BEGIN
    SELECT 
        id_menu,
        nombre,
        precio_x_persona,
        fecha_baja
    FROM 
        menu m
    WHERE 
        (@nombre IS NULL OR m.nombre LIKE '%' + @nombre + '%')
        AND (
            @activos IS NULL
            OR (@activos = 1 AND m.fecha_baja IS NULL)
            OR (@activos = 0 AND m.fecha_baja IS NOT NULL)
        )
END
GO
/****** Object:  StoredProcedure [dbo].[CrearMenu]    Script Date: 2/7/2025 16:05:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CrearMenu]
    @nombre VARCHAR(100),
    @precio_x_persona DECIMAL(10, 2),
    @fecha_baja DATE = NULL  -- opcional
AS
BEGIN
    INSERT INTO menu (nombre, precio_x_persona, fecha_baja)
    VALUES (@nombre, @precio_x_persona, @fecha_baja);

    -- Opcional: devolver el ID del nuevo menú
    SELECT SCOPE_IDENTITY() AS id_menu;
END
GO
/****** Object:  StoredProcedure [dbo].[EditarMenu]    Script Date: 2/7/2025 16:05:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[EditarMenu]
    @id_menu INT,
    @nombre VARCHAR(100),
    @precio_x_persona DECIMAL(10, 2),
    @fecha_baja DATE = NULL
AS
BEGIN
    UPDATE menu
    SET nombre = @nombre,
        precio_x_persona = @precio_x_persona,
        fecha_baja = @fecha_baja
    WHERE id_menu = @id_menu;
END
GO
/****** Object:  StoredProcedure [dbo].[EliminarPlatoMenu]    Script Date: 2/7/2025 16:05:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EliminarPlatoMenu]
    @id_menu INT,
    @id_plato INT
AS
BEGIN
    -- Validar si el menú ya está en un evento
    IF EXISTS (
        SELECT 1 FROM evento WHERE id_menu = @id_menu
    )
    BEGIN
        SELECT 'El menú ya está asociado a un evento' AS mensaje;
        RETURN;
    END

    --eliminar plato del menú
    delete from menu_plato where id_menu = @id_menu and id_plato = @id_plato

    -- Confirmación
    SELECT 'OK' AS mensaje;
END
GO
/****** Object:  StoredProcedure [dbo].[ListarPlatosPorMenu]    Script Date: 2/7/2025 16:05:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListarPlatosPorMenu]
    @id_menu INT
AS
BEGIN
    SELECT 
        p.id_plato,
        p.nombre AS nombre_plato,
        p.tipo_plato,
        p.fecha_baja
    FROM 
        plato p
    INNER JOIN 
        menu_plato mp ON mp.id_plato = p.id_plato
    WHERE 
        mp.id_menu = @id_menu
END
GO
/****** Object:  StoredProcedure [dbo].[ObtenerEventosPorEstadoYFechas]    Script Date: 2/7/2025 16:05:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ObtenerEventosPorEstadoYFechas]
    @estado_evento VARCHAR(50) = NULL,
    @fecha_desde DATE = NULL,
    @fecha_hasta DATE = NULL
AS
BEGIN
    SELECT 
		e.id_evento,
        e.fecha_evento,
        e.descuento_aplicado,
        e.direccion,
        e.localidad,
        e.estado_evento,
        e.cantidad_personas,
        e.total_estimado,
        e.evento_pago,
        e.id_usuario_venta,
        u.nombre AS nombre_vendedor,
        u.apellido AS apellido_vendedor,
        e.id_cliente,
        c.nombre AS nombre_cliente,
        c.apellido AS apellido_cliente,
        e.id_menu,
        m.nombre AS nombre_menu
    FROM evento e
    INNER JOIN menu m ON m.id_menu = e.id_menu
    INNER JOIN usuarios u ON u.id_usuario = e.id_usuario_venta
    INNER JOIN clientes c ON c.id_cliente = e.id_cliente
    WHERE (@estado_evento IS NULL OR e.estado_evento = @estado_evento)
      AND (@fecha_desde IS NULL OR e.fecha_evento >= @fecha_desde)
      AND (@fecha_hasta IS NULL OR e.fecha_evento <= @fecha_hasta);
END;
GO
/****** Object:  StoredProcedure [dbo].[ObtenerLotesDeInsumos]    Script Date: 2/7/2025 16:05:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ObtenerLotesDeInsumos]
AS
BEGIN
  select li.id_lote, li.id_insumo, i.nombre, i.unidad_medida, li.id_pedido, li.cantidad, li.costo_unitario,li.fecha_ingreso,li.fecha_vencimiento from lotes_insumo li 
  inner join insumo i on i.id_insumo = li.id_insumo 
END;
GO
/****** Object:  StoredProcedure [dbo].[ObtenerLotesDeInsumosPerecederos]    Script Date: 2/7/2025 16:05:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ObtenerLotesDeInsumosPerecederos]
@fechaDesde Date,
@fechaHasta Date
AS
BEGIN
  select li.id_lote, li.id_insumo, i.nombre, i.unidad_medida, li.id_pedido, li.cantidad, li.costo_unitario,li.fecha_ingreso,li.fecha_vencimiento from lotes_insumo li 
  inner join insumo i on i.id_insumo = li.id_insumo
  where li.fecha_vencimiento is not null and li.fecha_vencimiento between @fechaDesde and @fechaHasta
END;
GO
/****** Object:  StoredProcedure [dbo].[ObtenerLotesDeInsumosxId]    Script Date: 2/7/2025 16:05:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ObtenerLotesDeInsumosxId]
  @id_insumo bigint = NULL,
  @fecha_ingreso_inicio date = NULL,
  @fecha_ingreso_fin date = NULL
AS
BEGIN
  SELECT
    li.id_lote,
    li.id_insumo,
    i.nombre,
    i.unidad_medida,
    li.id_pedido,
    li.cantidad,
    li.costo_unitario,
    li.fecha_ingreso,
    li.fecha_vencimiento
  FROM lotes_insumo li
  INNER JOIN insumo i ON i.id_insumo = li.id_insumo
  WHERE
    (@id_insumo IS NULL OR li.id_insumo = @id_insumo) AND
    (@fecha_ingreso_inicio IS NULL OR li.fecha_ingreso >= @fecha_ingreso_inicio) AND
    (@fecha_ingreso_fin IS NULL OR li.fecha_ingreso <= @fecha_ingreso_fin);
END;
GO
/****** Object:  StoredProcedure [dbo].[ObtenerPedidosDeInsumos]    Script Date: 2/7/2025 16:05:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ObtenerPedidosDeInsumos]
  @fecha_desde DATE = NULL,
  @fecha_hasta DATE = NULL,
  @id_insumo INT = NULL
AS
BEGIN
  SELECT p.*, i.*, u.*
  FROM pedido_insumo p
  INNER JOIN insumo i ON i.id_insumo = p.id_insumo
  INNER JOIN usuarios u ON u.id_usuario = p.id_usuario_pedido
  WHERE
    (@fecha_desde IS NULL OR p.fecha_pedido >= @fecha_desde) AND
    (@fecha_hasta IS NULL OR p.fecha_pedido <= @fecha_hasta) AND
    (@id_insumo IS NULL OR p.id_insumo = @id_insumo);
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ActualizarEstadoEvento]    Script Date: 2/7/2025 16:05:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_ActualizarEstadoEvento]
    @id_evento INT,
    @estado NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE evento
    SET estado_evento = @estado
    WHERE id_evento = @id_evento;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_addCliente]    Script Date: 2/7/2025 16:05:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[sp_addCliente] 
@nombre varchar(100),
@apellido varchar(100),
@email varchar(100),
@telefono varchar(20),
@domicilio varchar(100),
@dni varchar(45)

as 

INSERT INTO clientes( 
      nombre
      ,apellido
      ,email
      ,telefono
      ,domicilio
      ,dni)
       
values(@nombre,@apellido,@email,@telefono,@domicilio,@dni)

return
GO
/****** Object:  StoredProcedure [dbo].[sp_addEvento]    Script Date: 2/7/2025 16:05:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[sp_addEvento] 
@id_cliente bigint,
@id_menu bigint,
@fecha_evento date,
@descuento_aplicado decimal(10,2),
@direccion varchar(45),
@localidad varchar(100),
@estado_evento varchar(45),
@cantidad_personas bigint,
@total_estimado decimal(10,2),
@id_usuario_venta bigint,
@evento_pago bit


as 

INSERT INTO evento( 
      id_cliente
      ,id_menu
      ,fecha_evento
      ,descuento_aplicado
      ,direccion
      ,localidad
      ,estado_evento
      ,cantidad_personas
      ,total_estimado
      ,id_usuario_venta,evento_pago)
       
values(@id_cliente,@id_menu,@fecha_evento,@descuento_aplicado,@direccion,@localidad,@estado_evento,@cantidad_personas,@total_estimado,@id_usuario_venta,@evento_pago)

return
GO
/****** Object:  StoredProcedure [dbo].[sp_agregar_insumo]    Script Date: 2/7/2025 16:05:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_agregar_insumo]
    @nombre NVARCHAR(100),
    @unidad_medida NVARCHAR(50),
    @perecedero NVARCHAR(10),
    @stock_minimo DECIMAL(18, 2),
    @fecha_baja DATE = NULL  -- Puede ser NULL o una fecha específica
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @mensaje NVARCHAR(200);

    -- Verifica si ya existe un insumo activo con el mismo nombre
    IF EXISTS (
        SELECT 1
        FROM insumo
        WHERE LTRIM(RTRIM(nombre)) = LTRIM(RTRIM(@nombre))
    )
    BEGIN
        SET @mensaje = 'Ya existe un insumo activo con el nombre "' + @nombre + '".';
        SELECT @mensaje AS Mensaje;
        RETURN;
    END

    -- Inserta el nuevo insumo (activo o dado de baja según @fecha_baja)
    INSERT INTO insumo (nombre, unidad_medida, perecedero, stock_minimo, fecha_baja)
    VALUES (@nombre, @unidad_medida, @perecedero, @stock_minimo, @fecha_baja);

    SET @mensaje = 'OK';
    SELECT @mensaje AS Mensaje;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_agregarUsuario]    Script Date: 2/7/2025 16:05:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_agregarUsuario]
@inNombre varchar(50),
@inApellido varchar(50),
@inDomicilio varchar(50),
@inTelefono varchar(50),
@inDniEmpleado varchar(8),
@inFechaCreacion date,
@inPerfil varchar(50),
@inClave varchar(50),
@inEmail varchar(100)

AS
BEGIN
  INSERT INTO usuarios(email,clave,perfil,fecha_creacion,dni_empleado,nombre,apellido,domicilio,telefono,fecha_baja)
  values(@inEmail,@inClave,@inPerfil,@inFechaCreacion,@inDniEmpleado,@inNombre,@inApellido,@inDomicilio,@inTelefono,NULL)
END;


GO
/****** Object:  StoredProcedure [dbo].[sp_allCliente]    Script Date: 2/7/2025 16:05:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[sp_allCliente] as 

SELECT [id_cliente]
      ,[nombre]
      ,[apellido]
      ,[email]
      ,[telefono]
      ,[domicilio]
      ,[dni]
       
FROM clientes 


return
GO
/****** Object:  StoredProcedure [dbo].[sp_allInsumo]    Script Date: 2/7/2025 16:05:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[sp_allInsumo] as 

SELECT *
	   
FROM insumo 


return
GO
/****** Object:  StoredProcedure [dbo].[sp_bajaUsuario]    Script Date: 2/7/2025 16:05:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_bajaUsuario]
@inNombre varchar(50),
@inApellido varchar(50),
@inDomicilio varchar(50),
@inTelefono varchar(50),
@inDniEmpleado varchar(8),
@inPerfil varchar(50),
@inClave varchar(50),
@inEmail varchar(100),
@inFechaBaja date

AS
BEGIN
  UPDATE usuarios
  set fecha_baja = @inFechaBaja
  WHERE apellido = @inApellido AND dni_empleado = @inDniEmpleado;
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_editar_insumo]    Script Date: 2/7/2025 16:05:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_editar_insumo]
    @id_insumo INT,
    @nombre NVARCHAR(100),
    @unidad_medida NVARCHAR(50),
    @perecedero NVARCHAR(10),
    @stock_minimo DECIMAL(18, 2),
    @fecha_baja DATE = NULL
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @mensaje NVARCHAR(200);

    -- Validar que no exista otro insumo activo con el mismo nombre
    IF EXISTS (
        SELECT 1
        FROM insumo
        WHERE LTRIM(RTRIM(nombre)) = LTRIM(RTRIM(@nombre))
          AND id_insumo <> @id_insumo
    )
    BEGIN
        SET @mensaje = 'Ya existe otro insumo activo con el nombre "' + @nombre + '".';
        SELECT @mensaje AS Mensaje;
        RETURN;
    END

    -- Actualizar insumo
    UPDATE insumo
    SET
        nombre = @nombre,
        unidad_medida = @unidad_medida,
        perecedero = @perecedero,
        stock_minimo = @stock_minimo,
        fecha_baja = @fecha_baja
    WHERE id_insumo = @id_insumo;

    SET @mensaje = 'OK';
    SELECT @mensaje AS Mensaje;
END


GO
/****** Object:  StoredProcedure [dbo].[sp_EditarEstadoAlerta]    Script Date: 2/7/2025 16:05:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  CREATE PROCEDURE [dbo].[sp_EditarEstadoAlerta]
    @id_alerta INT,
    @nuevo_estado VARCHAR(50)
AS
BEGIN
    UPDATE alerta_stock
    SET estado_alerta = @nuevo_estado
    WHERE id_alerta = @id_alerta;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_editarUsuario]    Script Date: 2/7/2025 16:05:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_editarUsuario]
@inNombre varchar(50),
@inApellido varchar(50),
@inDomicilio varchar(50),
@inTelefono varchar(50),
@inDniEmpleado varchar(8),
@inPerfil varchar(50),
@inClave varchar(50),
@inEmail varchar(100),
@inId int

AS
BEGIN
  UPDATE usuarios
  set email = @inEmail, clave = @inClave, perfil = @inPerfil, dni_empleado = @inDniEmpleado,telefono = @inTelefono,domicilio = @inDomicilio,apellido = @inApellido,nombre = @inNombre
  WHERE id_usuario = @inId;
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_filtrar_alertas_stock]    Script Date: 2/7/2025 16:05:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_filtrar_alertas_stock]
    @fechaDesde DATE = NULL,
    @fechaHasta DATE = NULL,
    @estado NVARCHAR(50) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        id_alerta,
        sa.id_insumo,
        fecha_alerta,
        estado_alerta,
		i.nombre
    FROM alerta_stock sa
	inner join insumo i on i.id_insumo = sa.id_insumo
    WHERE
        (@fechaDesde IS NULL OR fecha_alerta >= @fechaDesde) AND
        (@fechaHasta IS NULL OR fecha_alerta < DATEADD(DAY, 1, @fechaHasta)) AND
        (@estado IS NULL OR estado_alerta = @estado)
    ORDER BY fecha_alerta DESC;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_getEventoByCliente]    Script Date: 2/7/2025 16:05:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_getEventoByCliente] 
@id_cliente bigint

as 

select * from evento where id_cliente = @id_cliente

return
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertarAlertaStock]    Script Date: 2/7/2025 16:05:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  CREATE PROCEDURE [dbo].[sp_InsertarAlertaStock]
    @id_insumo INT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO alerta_stock (id_insumo, fecha_alerta, estado_alerta)
    VALUES (@id_insumo, GETDATE(), 'PENDIENTE');
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_listar_insumos]    Script Date: 2/7/2025 16:05:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_listar_insumos]
    @nombre NVARCHAR(100) = NULL,
    @activos BIT = NULL  -- 1 = solo activos (fecha_baja IS NULL), 0 = solo dados de baja, NULL = todos
AS
BEGIN
    SELECT 
        id_insumo,
        nombre,
        unidad_medida,
		perecedero,
		stock_minimo,
        fecha_baja
    FROM 
        insumo m
    WHERE 
        (@nombre IS NULL OR m.nombre LIKE '%' + @nombre + '%')
        AND (
            @activos IS NULL
            OR (@activos = 1 AND m.fecha_baja IS NULL)
            OR (@activos = 0 AND m.fecha_baja IS NOT NULL)
        )
END
GO
/****** Object:  StoredProcedure [dbo].[sp_menusDisponibles]    Script Date: 2/7/2025 16:05:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_menusDisponibles] as

SELECT [id_menu]
      ,[nombre]
      ,[precio_x_persona]
      
  FROM [dbo].[menu]
  WHERE fecha_baja is null 
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerIngredientesPlatoPorPlato]    Script Date: 2/7/2025 16:05:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ObtenerIngredientesPlatoPorPlato]
    @id_plato INT
AS
BEGIN
    SET NOCOUNT ON;

select id_plato_insumo,p_i.id_insumo, cantidad_necesaria,
i.nombre as nombre_insumo, unidad_medida,perecedero, i.fecha_baja as insumo_fecha_baja, i.stock_minimo from plato_insumo p_i
inner join insumo i on i.id_insumo = p_i.id_insumo 
where id_plato = @id_plato
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerLotesInsumoVigentes]    Script Date: 2/7/2025 16:05:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  CREATE PROCEDURE [dbo].[sp_ObtenerLotesInsumoVigentes]
    @IdInsumo INT
AS
BEGIN
    SELECT *
    FROM lotes_insumo
    WHERE (fecha_vencimiento IS NULL OR fecha_vencimiento > GETDATE())
      AND id_insumo = @IdInsumo
	order by fecha_vencimiento
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerMailsLogisticaChefs]    Script Date: 2/7/2025 16:05:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ObtenerMailsLogisticaChefs]
AS
BEGIN
    SET NOCOUNT ON;

select email from usuarios where perfil in ('LOGISTICA','CHEF')
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerMenusFiltrados]    Script Date: 2/7/2025 16:05:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ObtenerMenusFiltrados]
    @nombre NVARCHAR(100) = NULL,
    @precio DECIMAL(10,2) = NULL,
    @comparador VARCHAR(10) = NULL,
    @soloActivos BIT = NULL 
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        id_menu,
        nombre,
        precio_x_persona,
        fecha_baja
    FROM CATERINGDB.dbo.menu
    WHERE (@nombre IS NULL OR nombre LIKE '%' + @nombre + '%')
      AND (
            @precio IS NULL OR
            (
                @comparador = '>' AND precio_x_persona > @precio OR
                @comparador = '<' AND precio_x_persona < @precio OR
                @comparador = '=' AND precio_x_persona = @precio
            )
          )
      AND (
            @soloActivos IS NULL OR
            (@soloActivos = 1 AND fecha_baja IS NULL) OR
            (@soloActivos = 0 AND fecha_baja IS NOT NULL)
          );
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerPlatosMenu]    Script Date: 2/7/2025 16:05:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ObtenerPlatosMenu]
    @idMenu bigint
AS
BEGIN
    SET NOCOUNT ON;

      select p.id_plato,p.nombre,p.tipo_plato,p.fecha_baja from menu_plato mp 
	  inner join plato p on p.id_plato = mp.id_plato
	  where mp.id_plato = @idMenu
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerPlatosPorMenu]    Script Date: 2/7/2025 16:05:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ObtenerPlatosPorMenu]
    @id_menu INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT id_plato
    FROM menu_plato
    WHERE id_menu = @id_menu;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_onlyEvento]    Script Date: 2/7/2025 16:05:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[sp_onlyEvento] 
(@id_evento bigint)
as 

SELECT 
       id_evento
      ,id_cliente
      ,id_menu
      ,fecha_evento
      ,descuento_aplicado
      ,direccion
      ,localidad
      ,estado_evento
      ,cantidad_personas
      ,total_estimado
      ,evento_pago
      ,id_usuario_venta
       
FROM evento 
where id_evento = @id_evento
ORDER BY id_evento 

return
GO
/****** Object:  StoredProcedure [dbo].[sp_todoEventos]    Script Date: 2/7/2025 16:05:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[sp_todoEventos] as 

SELECT 
	   id_evento
      ,id_cliente
      ,id_menu
      ,fecha_evento
      ,descuento_aplicado
      ,direccion
      ,localidad
      ,estado_evento
      ,cantidad_personas
      ,total_estimado
      ,evento_pago
      ,id_usuario_venta
	   
FROM evento 
ORDER BY id_evento

return 
GO
/****** Object:  StoredProcedure [dbo].[sp_todoUsuarios]    Script Date: 2/7/2025 16:05:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_todoUsuarios] as
SELECT [id_usuario]
      ,[email]
      ,[clave]
      ,[perfil]
      ,[fecha_creacion]
      ,[fecha_baja]
      ,[dni_empleado]
      ,[nombre]
      ,[apellido]
      ,[domicilio]
      ,[telefono]
  FROM [dbo].[usuarios]
  WHERE fecha_baja is null



GO
/****** Object:  StoredProcedure [dbo].[sp_updateCliente]    Script Date: 2/7/2025 16:05:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[sp_updateCliente] 
@id_cliente bigint,
@nombre varchar(100),
@apellido varchar(100),
@email varchar(100),
@telefono varchar(20),
@domicilio varchar(100),
@dni varchar(45)

as 

UPDATE clientes

set nombre = @nombre
      ,apellido = @apellido
      ,email = @email
      ,telefono = @telefono
      ,domicilio = @domicilio
      ,dni = @dni
where id_cliente = @id_cliente

return
GO
/****** Object:  StoredProcedure [dbo].[sp_updateEvento]    Script Date: 2/7/2025 16:05:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[sp_updateEvento] 
@id_cliente bigint,
@id_menu bigint,
@fecha_evento date,
@descuento_aplicado decimal(10,2),
@direccion varchar(45),
@localidad varchar(100),
@estado_evento varchar(45),
@cantidad_personas bigint,
@total_estimado decimal(10,2),
@id_usuario_venta bigint,
@evento_pago bit,
@id_evento bigint


as 

update evento
set 
      id_cliente = @id_cliente
      ,id_menu = @id_menu
      ,fecha_evento = @fecha_evento
      ,descuento_aplicado = @descuento_aplicado
      ,direccion = @direccion
      ,localidad = @localidad
      ,estado_evento = @estado_evento
      ,cantidad_personas = @cantidad_personas
      ,total_estimado = @total_estimado
      ,id_usuario_venta = @id_usuario_venta, 
      evento_pago = @evento_pago
where id_evento = @id_evento
return
GO
/****** Object:  StoredProcedure [dbo].[UpdatePedidosDeInsumos]    Script Date: 2/7/2025 16:05:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdatePedidosDeInsumos]
@id_pedidoInsumo bigint,
@id_insumo bigint,
@cantidad decimal(10,2),
@fecha_pedido date,
@estado_pedido varchar(45),
@costo_unitario decimal(10,2)
AS
BEGIN

  if exists (select * from pedido_insumo where id_pedido_insumo = @id_pedidoInsumo and estado_pedido = 'ENTREGADO')
  BEGIN
   UPDATE pedido_insumo
	  set id_insumo = @id_insumo, cantidad=@cantidad, fecha_pedido=@fecha_pedido, estado_pedido = @estado_pedido
	  where id_pedido_insumo = @id_pedidoInsumo
  END
  ELSE
  BEGIN
	UPDATE pedido_insumo
	  set id_insumo = @id_insumo, cantidad=@cantidad, fecha_pedido=@fecha_pedido, estado_pedido = @estado_pedido
	  where id_pedido_insumo = @id_pedidoInsumo
	  IF @estado_pedido = 'ENTREGADO'
	  BEGIN
		INSERT INTO lotes_insumo (id_insumo,cantidad,fecha_ingreso,fecha_vencimiento,costo_unitario,id_pedido) 
		values(@id_insumo,@cantidad,GETDATE(),DATEADD(DAY,+30,GETDATE()),@costo_unitario,@id_pedidoInsumo);
	  END
  
  END
 
END;
GO
