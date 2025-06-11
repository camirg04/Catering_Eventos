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