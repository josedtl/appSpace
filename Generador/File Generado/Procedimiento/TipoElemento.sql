CREATE PROCEDURE sp_TipoElementoAllItem(IN v_TipoElemento INT)
BEGIN
  SELECT
    TipoElementoId,
    Nombre,
    FechaRegistro,
    CodUsuario,
    EstadoRegistro,
  FROM catalogo_TipoElemento WHERE  TipoElementoId = v_TipoElementoId;
END;

CREATE PROCEDURE sp_TipoElemento_Save(
    IN v_TipoElementoId int,
    IN v_Nombre varchar,
    IN v_FechaRegistro datetime,
    IN v_CodUsuario varchar,
    IN v_EstadoRegistro bit,
)
BEGIN
    INSERT INTO catalogo_TipoElemento (
        v_TipoElementoId,
        v_Nombre,
        v_FechaRegistro,
        v_CodUsuario,
        v_EstadoRegistro,
) VALUES (
        v_TipoElementoId,
        v_Nombre,
        v_FechaRegistro,
        v_CodUsuario,
        v_EstadoRegistro,
    );

  SET v_TipoElementoId = LAST_INSERT_ID();

END;

CREATE PROCEDURE sp_TipoElemento_Update(
    IN v_TipoElementoId int,
    IN v_Nombre varchar,
    IN v_FechaRegistro datetime,
    IN v_CodUsuario varchar,
    IN v_EstadoRegistro bit,
)
BEGIN
    UPDATE catalogo_TipoElemento
    SET
        TipoElementoId = v_TipoElementoId,
        Nombre = v_Nombre,
        FechaRegistro = v_FechaRegistro,
        CodUsuario = v_CodUsuario,
        EstadoRegistro = v_EstadoRegistro,
    WHERE
        TipoElementoId = v_TipoElementoId;
END;

CREATE  PROCEDURE `sp_TipoElementoDelete`(IN v_TipoElementoId int)
BEGIN
  DELETE
    FROM catalogo_TipoElemento
  WHERE TipoElementoId = v_TipoElementoId;
  END;
