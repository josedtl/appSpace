-- DROP PROCEDURE sp_InfraestructuraAllItem;
-- DROP PROCEDURE sp_InfraestructuraAllItems;
-- DROP PROCEDURE sp_InfraestructuraDelete;
-- DROP PROCEDURE sp_Infraestructura_Save;
-- DROP PROCEDURE sp_Infraestructura_Update;

CREATE PROCEDURE sp_InfraestructuraAllItems()
BEGIN
  SELECT
    InfraestructuraId,
    TipoInfraestructuraId,
    Estado,
    Codigo,
    Descripcion,
    Ancho,
    Largo,
    Altura,
    Nivel,
    Aforo
  FROM catalogo_Infraestructura;
END;

CREATE PROCEDURE sp_InfraestructuraAllItem(IN v_InfraestructuraId INT)
BEGIN
  SELECT
    InfraestructuraId,
    TipoInfraestructuraId,
    Estado,
    Codigo,
    Descripcion,
    Ancho,
    Largo,
    Altura,
    Nivel,
    Aforo
  FROM catalogo_Infraestructura WHERE  InfraestructuraId = v_InfraestructuraId;
END;

CREATE PROCEDURE sp_Infraestructura_Save(
    OUT v_InfraestructuraId int,
    IN v_TipoInfraestructuraId int,
    IN v_Estado varchar(255),
    IN v_Codigo varchar(50),
    IN v_Descripcion varchar(255),
    IN v_Ancho decimal(12,2),
    IN v_Largo varchar(50),
    IN v_Altura varchar(255),
    IN v_Nivel varchar(50),
    IN v_Aforo int
)
BEGIN
    INSERT INTO catalogo_Infraestructura (
        InfraestructuraId,
        TipoInfraestructuraId,
        Estado,
        Codigo,
        Descripcion,
        Ancho,
        Largo,
        Altura,
        Nivel,
        Aforo
) VALUES (
        v_InfraestructuraId,
        v_TipoInfraestructuraId,
        v_Estado,
        v_Codigo,
        v_Descripcion,
        v_Ancho,
        v_Largo,
        v_Altura,
        v_Nivel,
        v_Aforo
    );

  SET v_InfraestructuraId = LAST_INSERT_ID();

END;

CREATE PROCEDURE sp_Infraestructura_Update(
    IN v_InfraestructuraId int,
    IN v_TipoInfraestructuraId int,
    IN v_Estado varchar(255),
    IN v_Codigo varchar(50),
    IN v_Descripcion varchar(255),
    IN v_Ancho decimal(12,2),
    IN v_Largo varchar(50),
    IN v_Altura varchar(255),
    IN v_Nivel varchar(50),
    IN v_Aforo int
)
BEGIN
    UPDATE catalogo_Infraestructura
    SET
        InfraestructuraId = v_InfraestructuraId,
        TipoInfraestructuraId = v_TipoInfraestructuraId,
        Estado = v_Estado,
        Codigo = v_Codigo,
        Descripcion = v_Descripcion,
        Ancho = v_Ancho,
        Largo = v_Largo,
        Altura = v_Altura,
        Nivel = v_Nivel,
        Aforo = v_Aforo
    WHERE
        InfraestructuraId = v_InfraestructuraId;
END;

CREATE  PROCEDURE `sp_InfraestructuraDelete`(IN v_InfraestructuraId int)
BEGIN
  DELETE
    FROM catalogo_Infraestructura
  WHERE InfraestructuraId = v_InfraestructuraId;
  END;
