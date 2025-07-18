USE MASTER
GO
CREATE DATABASE CATERINGDB
GO
USE [CATERINGDB]
GO
/****** Object:  StoredProcedure [dbo].[UpdatePedidosDeInsumos]    Script Date: 30/6/2025 19:51:58 ******/
DROP PROCEDURE [dbo].[UpdatePedidosDeInsumos]
GO
/****** Object:  StoredProcedure [dbo].[sp_updateEvento]    Script Date: 30/6/2025 19:51:58 ******/
DROP PROCEDURE [dbo].[sp_updateEvento]
GO
/****** Object:  StoredProcedure [dbo].[sp_updateCliente]    Script Date: 30/6/2025 19:51:58 ******/
DROP PROCEDURE [dbo].[sp_updateCliente]
GO
/****** Object:  StoredProcedure [dbo].[sp_todoUsuarios]    Script Date: 30/6/2025 19:51:58 ******/
DROP PROCEDURE [dbo].[sp_todoUsuarios]
GO
/****** Object:  StoredProcedure [dbo].[sp_todoEventos]    Script Date: 30/6/2025 19:51:58 ******/
DROP PROCEDURE [dbo].[sp_todoEventos]
GO
/****** Object:  StoredProcedure [dbo].[sp_onlyEvento]    Script Date: 30/6/2025 19:51:58 ******/
DROP PROCEDURE [dbo].[sp_onlyEvento]
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerPlatosPorMenu]    Script Date: 30/6/2025 19:51:58 ******/
DROP PROCEDURE [dbo].[sp_ObtenerPlatosPorMenu]
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerPlatosMenu]    Script Date: 30/6/2025 19:51:58 ******/
DROP PROCEDURE [dbo].[sp_ObtenerPlatosMenu]
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerMenusFiltrados]    Script Date: 30/6/2025 19:51:58 ******/
DROP PROCEDURE [dbo].[sp_ObtenerMenusFiltrados]
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerMailsLogisticaChefs]    Script Date: 30/6/2025 19:51:58 ******/
DROP PROCEDURE [dbo].[sp_ObtenerMailsLogisticaChefs]
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerLotesInsumoVigentes]    Script Date: 30/6/2025 19:51:58 ******/
DROP PROCEDURE [dbo].[sp_ObtenerLotesInsumoVigentes]
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerIngredientesPlatoPorPlato]    Script Date: 30/6/2025 19:51:58 ******/
DROP PROCEDURE [dbo].[sp_ObtenerIngredientesPlatoPorPlato]
GO
/****** Object:  StoredProcedure [dbo].[sp_menusDisponibles]    Script Date: 30/6/2025 19:51:58 ******/
DROP PROCEDURE [dbo].[sp_menusDisponibles]
GO
/****** Object:  StoredProcedure [dbo].[sp_listar_insumos]    Script Date: 30/6/2025 19:51:58 ******/
DROP PROCEDURE [dbo].[sp_listar_insumos]
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertarAlertaStock]    Script Date: 30/6/2025 19:51:58 ******/
DROP PROCEDURE [dbo].[sp_InsertarAlertaStock]
GO
/****** Object:  StoredProcedure [dbo].[sp_getEventoByCliente]    Script Date: 30/6/2025 19:51:58 ******/
DROP PROCEDURE [dbo].[sp_getEventoByCliente]
GO
/****** Object:  StoredProcedure [dbo].[sp_filtrar_alertas_stock]    Script Date: 30/6/2025 19:51:58 ******/
DROP PROCEDURE [dbo].[sp_filtrar_alertas_stock]
GO
/****** Object:  StoredProcedure [dbo].[sp_editarUsuario]    Script Date: 30/6/2025 19:51:58 ******/
DROP PROCEDURE [dbo].[sp_editarUsuario]
GO
/****** Object:  StoredProcedure [dbo].[sp_EditarEstadoAlerta]    Script Date: 30/6/2025 19:51:58 ******/
DROP PROCEDURE [dbo].[sp_EditarEstadoAlerta]
GO
/****** Object:  StoredProcedure [dbo].[sp_editar_insumo]    Script Date: 30/6/2025 19:51:58 ******/
DROP PROCEDURE [dbo].[sp_editar_insumo]
GO
/****** Object:  StoredProcedure [dbo].[sp_bajaUsuario]    Script Date: 30/6/2025 19:51:58 ******/
DROP PROCEDURE [dbo].[sp_bajaUsuario]
GO
/****** Object:  StoredProcedure [dbo].[sp_allInsumo]    Script Date: 30/6/2025 19:51:58 ******/
DROP PROCEDURE [dbo].[sp_allInsumo]
GO
/****** Object:  StoredProcedure [dbo].[sp_allCliente]    Script Date: 30/6/2025 19:51:58 ******/
DROP PROCEDURE [dbo].[sp_allCliente]
GO
/****** Object:  StoredProcedure [dbo].[sp_agregarUsuario]    Script Date: 30/6/2025 19:51:58 ******/
DROP PROCEDURE [dbo].[sp_agregarUsuario]
GO
/****** Object:  StoredProcedure [dbo].[sp_agregar_insumo]    Script Date: 30/6/2025 19:51:58 ******/
DROP PROCEDURE [dbo].[sp_agregar_insumo]
GO
/****** Object:  StoredProcedure [dbo].[sp_addEvento]    Script Date: 30/6/2025 19:51:58 ******/
DROP PROCEDURE [dbo].[sp_addEvento]
GO
/****** Object:  StoredProcedure [dbo].[sp_addCliente]    Script Date: 30/6/2025 19:51:58 ******/
DROP PROCEDURE [dbo].[sp_addCliente]
GO
/****** Object:  StoredProcedure [dbo].[sp_ActualizarEstadoEvento]    Script Date: 30/6/2025 19:51:58 ******/
DROP PROCEDURE [dbo].[sp_ActualizarEstadoEvento]
GO
/****** Object:  StoredProcedure [dbo].[ObtenerPedidosDeInsumos]    Script Date: 30/6/2025 19:51:58 ******/
DROP PROCEDURE [dbo].[ObtenerPedidosDeInsumos]
GO
/****** Object:  StoredProcedure [dbo].[ObtenerLotesDeInsumosxId]    Script Date: 30/6/2025 19:51:58 ******/
DROP PROCEDURE [dbo].[ObtenerLotesDeInsumosxId]
GO
/****** Object:  StoredProcedure [dbo].[ObtenerLotesDeInsumosPerecederos]    Script Date: 30/6/2025 19:51:58 ******/
DROP PROCEDURE [dbo].[ObtenerLotesDeInsumosPerecederos]
GO
/****** Object:  StoredProcedure [dbo].[ObtenerLotesDeInsumos]    Script Date: 30/6/2025 19:51:58 ******/
DROP PROCEDURE [dbo].[ObtenerLotesDeInsumos]
GO
/****** Object:  StoredProcedure [dbo].[ObtenerEventosPorEstadoYFechas]    Script Date: 30/6/2025 19:51:58 ******/
DROP PROCEDURE [dbo].[ObtenerEventosPorEstadoYFechas]
GO
/****** Object:  StoredProcedure [dbo].[ListarPlatosPorMenu]    Script Date: 30/6/2025 19:51:58 ******/
DROP PROCEDURE [dbo].[ListarPlatosPorMenu]
GO
/****** Object:  StoredProcedure [dbo].[EliminarPlatoMenu]    Script Date: 30/6/2025 19:51:58 ******/
DROP PROCEDURE [dbo].[EliminarPlatoMenu]
GO
/****** Object:  StoredProcedure [dbo].[EditarMenu]    Script Date: 30/6/2025 19:51:58 ******/
DROP PROCEDURE [dbo].[EditarMenu]
GO
/****** Object:  StoredProcedure [dbo].[CrearMenu]    Script Date: 30/6/2025 19:51:58 ******/
DROP PROCEDURE [dbo].[CrearMenu]
GO
/****** Object:  StoredProcedure [dbo].[BuscarMenu]    Script Date: 30/6/2025 19:51:58 ******/
DROP PROCEDURE [dbo].[BuscarMenu]
GO
/****** Object:  StoredProcedure [dbo].[AgregarPlatoMenu]    Script Date: 30/6/2025 19:51:58 ******/
DROP PROCEDURE [dbo].[AgregarPlatoMenu]
GO
/****** Object:  StoredProcedure [dbo].[addPedidoInsumo]    Script Date: 30/6/2025 19:51:58 ******/
DROP PROCEDURE [dbo].[addPedidoInsumo]
GO
/****** Object:  StoredProcedure [dbo].[ActualizarStockLote]    Script Date: 30/6/2025 19:51:58 ******/
DROP PROCEDURE [dbo].[ActualizarStockLote]
GO
/****** Object:  StoredProcedure [dbo].[ActualizarCostoyFechaLote]    Script Date: 30/6/2025 19:51:58 ******/
DROP PROCEDURE [dbo].[ActualizarCostoyFechaLote]
GO
/****** Object:  StoredProcedure [dbo].[ActualizarCostoyFechaLote]    Script Date: 30/6/2025 19:51:58 ******/
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
/****** Object:  StoredProcedure [dbo].[ActualizarStockLote]    Script Date: 30/6/2025 19:51:58 ******/
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
/****** Object:  StoredProcedure [dbo].[addPedidoInsumo]    Script Date: 30/6/2025 19:51:58 ******/
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
/****** Object:  StoredProcedure [dbo].[AgregarPlatoMenu]    Script Date: 30/6/2025 19:51:58 ******/
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
/****** Object:  StoredProcedure [dbo].[BuscarMenu]    Script Date: 30/6/2025 19:51:58 ******/
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
/****** Object:  StoredProcedure [dbo].[CrearMenu]    Script Date: 30/6/2025 19:51:58 ******/
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
/****** Object:  StoredProcedure [dbo].[EditarMenu]    Script Date: 30/6/2025 19:51:58 ******/
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
/****** Object:  StoredProcedure [dbo].[EliminarPlatoMenu]    Script Date: 30/6/2025 19:51:58 ******/
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
/****** Object:  StoredProcedure [dbo].[ListarPlatosPorMenu]    Script Date: 30/6/2025 19:51:58 ******/
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
/****** Object:  StoredProcedure [dbo].[ObtenerEventosPorEstadoYFechas]    Script Date: 30/6/2025 19:51:58 ******/
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
/****** Object:  StoredProcedure [dbo].[ObtenerLotesDeInsumos]    Script Date: 30/6/2025 19:51:58 ******/
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
/****** Object:  StoredProcedure [dbo].[ObtenerLotesDeInsumosPerecederos]    Script Date: 30/6/2025 19:51:58 ******/
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
/****** Object:  StoredProcedure [dbo].[ObtenerLotesDeInsumosxId]    Script Date: 30/6/2025 19:51:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ObtenerLotesDeInsumosxId]
@id_insumo bigint,
@fecha_ingreso_inicio date,
@fecha_ingreso_fin date
AS
BEGIN
  select li.id_lote, li.id_insumo, i.nombre, i.unidad_medida, li.id_pedido, li.cantidad, li.costo_unitario,li.fecha_ingreso,li.fecha_vencimiento 
  from lotes_insumo li 
  inner join insumo i on i.id_insumo = li.id_insumo
   where li.id_insumo = @id_insumo and li.fecha_ingreso >= @fecha_ingreso_inicio and li.fecha_ingreso <= @fecha_ingreso_fin
END;
GO
/****** Object:  StoredProcedure [dbo].[ObtenerPedidosDeInsumos]    Script Date: 30/6/2025 19:51:58 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_ActualizarEstadoEvento]    Script Date: 30/6/2025 19:51:58 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_addCliente]    Script Date: 30/6/2025 19:51:58 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_addEvento]    Script Date: 30/6/2025 19:51:58 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_agregar_insumo]    Script Date: 30/6/2025 19:51:58 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_agregarUsuario]    Script Date: 30/6/2025 19:51:58 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_allCliente]    Script Date: 30/6/2025 19:51:58 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_allInsumo]    Script Date: 30/6/2025 19:51:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[sp_allInsumo] as 

SELECT *
	   
FROM insumo 


return
GO
/****** Object:  StoredProcedure [dbo].[sp_bajaUsuario]    Script Date: 30/6/2025 19:51:58 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_editar_insumo]    Script Date: 30/6/2025 19:51:58 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_EditarEstadoAlerta]    Script Date: 30/6/2025 19:51:58 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_editarUsuario]    Script Date: 30/6/2025 19:51:58 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_filtrar_alertas_stock]    Script Date: 30/6/2025 19:51:58 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_getEventoByCliente]    Script Date: 30/6/2025 19:51:58 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_InsertarAlertaStock]    Script Date: 30/6/2025 19:51:58 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_listar_insumos]    Script Date: 30/6/2025 19:51:58 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_menusDisponibles]    Script Date: 30/6/2025 19:51:58 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_ObtenerIngredientesPlatoPorPlato]    Script Date: 30/6/2025 19:51:58 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_ObtenerLotesInsumoVigentes]    Script Date: 30/6/2025 19:51:58 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_ObtenerMailsLogisticaChefs]    Script Date: 30/6/2025 19:51:58 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_ObtenerMenusFiltrados]    Script Date: 30/6/2025 19:51:58 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_ObtenerPlatosMenu]    Script Date: 30/6/2025 19:51:58 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_ObtenerPlatosPorMenu]    Script Date: 30/6/2025 19:51:58 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_onlyEvento]    Script Date: 30/6/2025 19:51:58 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_todoEventos]    Script Date: 30/6/2025 19:51:58 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_todoUsuarios]    Script Date: 30/6/2025 19:51:58 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_updateCliente]    Script Date: 30/6/2025 19:51:58 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_updateEvento]    Script Date: 30/6/2025 19:51:58 ******/
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
/****** Object:  StoredProcedure [dbo].[UpdatePedidosDeInsumos]    Script Date: 30/6/2025 19:51:58 ******/
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
