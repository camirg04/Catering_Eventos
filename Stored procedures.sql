CREATE PROCEDURE ObtenerLotesDeInsumos
AS
BEGIN
  select li.id_lote, li.id_insumo, i.nombre, i.unidad_medida, li.id_pedido, li.cantidad, li.costo_unitario,li.fecha_ingreso,li.fecha_vencimiento from lotes_insumo li 
  inner join insumo i on i.id_insumo = li.id_insumo
END;

CREATE PROCEDURE ObtenerLotesDeInsumosPerecederos
@fechaDesde Date,
@fechaHasta Date
AS
BEGIN
  select li.id_lote, li.id_insumo, i.nombre, i.unidad_medida, li.id_pedido, li.cantidad, li.costo_unitario,li.fecha_ingreso,li.fecha_vencimiento from lotes_insumo li 
  inner join insumo i on i.id_insumo = li.id_insumo
  where li.fecha_vencimiento is not null and li.fecha_vencimiento between @fechaDesde and @fechaHasta
END;

USE [CATERINGDB]
GO
/****** Object:  StoredProcedure [dbo].[ObtenerEventosPorEstadoYFechas]    Script Date: 13/6/2025 00:44:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[ObtenerEventosPorEstadoYFechas]
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


CREATE PROCEDURE sp_ObtenerMenusFiltrados
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


CREATE PROCEDURE sp_ObtenerPlatosMenu
    @idMenu bigint
AS
BEGIN
    SET NOCOUNT ON;

      select p.id_plato,p.nombre,p.tipo_plato,p.fecha_baja from menu_plato mp 
	  inner join plato p on p.id_plato = mp.id_plato
	  where mp.id_plato = @idMenu
END;



CREATE PROCEDURE sp_filtrar_alertas_stock
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
        (@fechaHasta IS NULL OR fecha_alerta <= @fechaHasta) AND
        (@estado IS NULL OR estado_alerta = @estado)
    ORDER BY fecha_alerta DESC;
END;


/*AGREGAR EVENTOS*/
USE [CATERINGDB]
GO
/****** Object:  StoredProcedure [dbo].[sp_addEvento]    Script Date: 11/06/2025 22:27:40 ******/
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

/*OBTENER 1 EVENTO*/
USE [CATERINGDB]
GO
/****** Object:  StoredProcedure [dbo].[sp_onlyEvento]    Script Date: 11/06/2025 22:30:46 ******/
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


/*OBTIENE TODOS LOS CLIENTES*/
USE [CATERINGDB]
GO
/****** Object:  StoredProcedure [dbo].[sp_allCliente]    Script Date: 11/06/2025 22:29:53 ******/
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

/*AGREGA CLIENTE*/
USE [CATERINGDB]
GO
/****** Object:  StoredProcedure [dbo].[sp_addCliente]    Script Date: 11/06/2025 22:33:45 ******/
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

/*ACTUALIZAMOS CLIENTE*/
USE [CATERINGDB]
GO
/****** Object:  StoredProcedure [dbo].[sp_updateCliente]    Script Date: 11/06/2025 22:36:00 ******/
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
      ,telefono = @email
      ,domicilio = @domicilio
      ,dni = @dni
where id_cliente = @id_cliente

return

/*ACTUALIZAMOS EVENTO*/
USE [CATERINGDB]
GO
/****** Object:  StoredProcedure [dbo].[sp_updateEvento]    Script Date: 11/06/2025 22:36:29 ******/
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

// 12/06
CREATE PROCEDURE ObtenerEventosPorEstadoYFechas
    @estado_evento VARCHAR(50) = NULL,
    @fecha_desde DATE = NULL,
    @fecha_hasta DATE = NULL
AS
BEGIN
    SELECT 
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

USE [CATERINGDB]
GO
/****** Object:  StoredProcedure [dbo].[sp_menusDisponibles]    Script Date: 12/06/2025 19:02:26 ******/
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
  
  
  
  USE [CATERINGDB]
GO
/****** Object:  StoredProcedure [dbo].[sp_todoEventos]    Script Date: 12/06/2025 19:05:39 ******/
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


USE [CATERINGDB]
GO
/****** Object:  StoredProcedure [dbo].[sp_updateCliente]    Script Date: 12/6/2025 19:10:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER proc [dbo].[sp_updateCliente] 
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


CREATE PROCEDURE sp_ObtenerPlatosPorMenu
    @id_menu INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT id_plato
    FROM menu_plato
    WHERE id_menu = @id_menu;
END;


CREATE PROCEDURE sp_ObtenerIngredientesPlatoPorPlato
    @id_plato INT
AS
BEGIN
    SET NOCOUNT ON;

    select id_plato_insumo,p_i.id_insumo, cantidad_necesaria,
i.nombre as nombre_insumo, unidad_medida,perecedero, i.fecha_baja as insumo_fecha_baja from plato_insumo p_i
inner join insumo i on i.id_insumo = p_i.id_insumo 
where id_plato = @id_plato
END;


CREATE PROCEDURE sp_ObtenerLotesInsumoVigentes
    @IdInsumo INT
AS
BEGIN
    SELECT *
    FROM lotes_insumo
    WHERE (fecha_vencimiento IS NULL OR fecha_vencimiento > GETDATE())
      AND id_insumo = @IdInsumo;
END;

CREATE PROCEDURE sp_ObtenerMailsLogisticaChefs
AS
BEGIN
    SET NOCOUNT ON;

select email from usuarios where perfil in ('LOGISTICA','CHEF')
END;

USE [CATERINGDB]
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerLotesInsumoVigentes]    Script Date: 12/6/2025 23:37:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  ALTER PROCEDURE [dbo].[sp_ObtenerLotesInsumoVigentes]
    @IdInsumo INT
AS
BEGIN
    SELECT *
    FROM lotes_insumo
    WHERE (fecha_vencimiento IS NULL OR fecha_vencimiento > GETDATE())
      AND id_insumo = @IdInsumo
	order by fecha_vencimiento
END;

USE [CATERINGDB]
GO
CREATE PROCEDURE ActualizarStockLote
    @idLote INT,
    @cantidad DECIMAL(18, 2)
AS
BEGIN
    UPDATE lotes_insumo
    SET cantidad = @cantidad
    WHERE id_lote = @idLote
END
GO


CREATE PROCEDURE sp_InsertarAlertaStock
    @id_insumo INT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO alerta_stock (id_insumo, fecha_alerta, estado_alerta)
    VALUES (@id_insumo, GETDATE(), 'PENDIENTE');
END;

CREATE PROCEDURE sp_ActualizarEstadoEvento
    @id_evento INT,
    @estado NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE evento
    SET estado_evento = @estado
    WHERE id_evento = @id_evento;
END;



