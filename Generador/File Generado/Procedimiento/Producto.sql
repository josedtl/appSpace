CREATE PROCEDURE sp_ProductoAllItem(IN v_Producto INT)
BEGIN
  SELECT
    ProductoId,
    Codigo,
    TipoProductoId,
    MarcaId,
    ModeloId,
    UnidadMedidaId,
    PrecioCompra,
    MonedaId,
    RutaImagen,
    CantidadStock,
    CantidadReserva,
    FechaRegistro,
    CodUsuario,
    Estado,
  FROM catalogo_producto WHERE  ProductoId = v_ProductoId;
END;

CREATE PROCEDURE sp_Producto_Save(
    IN v_ProductoId int,
    IN v_Codigo varchar,
    IN v_TipoProductoId int,
    IN v_MarcaId int,
    IN v_ModeloId int,
    IN v_UnidadMedidaId int,
    IN v_PrecioCompra decimal,
    IN v_MonedaId int,
    IN v_RutaImagen varchar,
    IN v_CantidadStock decimal,
    IN v_CantidadReserva decimal,
    IN v_FechaRegistro datetime,
    IN v_CodUsuario varchar,
    IN v_Estado bit,
)
BEGIN
    INSERT INTO catalogo_producto (
        v_ProductoId,
        v_Codigo,
        v_TipoProductoId,
        v_MarcaId,
        v_ModeloId,
        v_UnidadMedidaId,
        v_PrecioCompra,
        v_MonedaId,
        v_RutaImagen,
        v_CantidadStock,
        v_CantidadReserva,
        v_FechaRegistro,
        v_CodUsuario,
        v_Estado,
) VALUES (
        v_ProductoId,
        v_Codigo,
        v_TipoProductoId,
        v_MarcaId,
        v_ModeloId,
        v_UnidadMedidaId,
        v_PrecioCompra,
        v_MonedaId,
        v_RutaImagen,
        v_CantidadStock,
        v_CantidadReserva,
        v_FechaRegistro,
        v_CodUsuario,
        v_Estado,
    );

  SET v_ProductoId = LAST_INSERT_ID();

END;

CREATE PROCEDURE sp_Producto_Update(
    IN v_ProductoId int,
    IN v_Codigo varchar,
    IN v_TipoProductoId int,
    IN v_MarcaId int,
    IN v_ModeloId int,
    IN v_UnidadMedidaId int,
    IN v_PrecioCompra decimal,
    IN v_MonedaId int,
    IN v_RutaImagen varchar,
    IN v_CantidadStock decimal,
    IN v_CantidadReserva decimal,
    IN v_FechaRegistro datetime,
    IN v_CodUsuario varchar,
    IN v_Estado bit,
)
BEGIN
    UPDATE catalogo_producto
    SET
        ProductoId = v_ProductoId,
        Codigo = v_Codigo,
        TipoProductoId = v_TipoProductoId,
        MarcaId = v_MarcaId,
        ModeloId = v_ModeloId,
        UnidadMedidaId = v_UnidadMedidaId,
        PrecioCompra = v_PrecioCompra,
        MonedaId = v_MonedaId,
        RutaImagen = v_RutaImagen,
        CantidadStock = v_CantidadStock,
        CantidadReserva = v_CantidadReserva,
        FechaRegistro = v_FechaRegistro,
        CodUsuario = v_CodUsuario,
        Estado = v_Estado,
    WHERE
        ProductoId = v_ProductoId;
END;

CREATE  PROCEDURE `sp_ProductoDelete`(IN v_ProductoId int)
BEGIN
  DELETE
    FROM catalogo_producto
  WHERE ProductoId = v_ProductoId;
  END;
