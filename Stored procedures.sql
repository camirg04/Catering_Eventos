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

USE [CATERINGDB]
GO
/****** Object:  StoredProcedure [dbo].[sp_getEventoByCliente]    Script Date: 13/06/2025 1:01:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[sp_getEventoByCliente] 
@id_cliente bigint

as 

select * from evento where id_cliente = @id_cliente

return




