CREATE PROCEDURE sp_CabeceraDataAllItem(IN v_CabeceraData INT)
BEGIN
  SELECT
    CabeceraDataId,
    CantidadEntera,
    CantidadDecimal,
    CantidadNumerico,
    CantidadEnteraSmall,
    LetrasGrande,
    LetrasMedia,
    LetrasPequena,
    LetrasPequenaSmall,
    LetrasPequenaSmallUno,
    Fecha,
    FechaSola,
    Estado,
  FROM catalogo_cabeceradata WHERE  CabeceraDataId = v_CabeceraDataId;
END;

CREATE PROCEDURE sp_CabeceraData_Save(
    IN v_CabeceraDataId int,
    IN v_CantidadEntera int,
    IN v_CantidadDecimal decimal,
    IN v_CantidadNumerico decimal,
    IN v_CantidadEnteraSmall smallint,
    IN v_LetrasGrande varchar,
    IN v_LetrasMedia varchar,
    IN v_LetrasPequena varchar,
    IN v_LetrasPequenaSmall char,
    IN v_LetrasPequenaSmallUno char,
    IN v_Fecha datetime,
    IN v_FechaSola date,
    IN v_Estado bit,
)
BEGIN
    INSERT INTO catalogo_cabeceradata (
        v_CabeceraDataId,
        v_CantidadEntera,
        v_CantidadDecimal,
        v_CantidadNumerico,
        v_CantidadEnteraSmall,
        v_LetrasGrande,
        v_LetrasMedia,
        v_LetrasPequena,
        v_LetrasPequenaSmall,
        v_LetrasPequenaSmallUno,
        v_Fecha,
        v_FechaSola,
        v_Estado,
) VALUES (
        v_CabeceraDataId,
        v_CantidadEntera,
        v_CantidadDecimal,
        v_CantidadNumerico,
        v_CantidadEnteraSmall,
        v_LetrasGrande,
        v_LetrasMedia,
        v_LetrasPequena,
        v_LetrasPequenaSmall,
        v_LetrasPequenaSmallUno,
        v_Fecha,
        v_FechaSola,
        v_Estado,
    );

  SET v_CabeceraDataId = LAST_INSERT_ID();

END;

CREATE PROCEDURE sp_CabeceraData_Update(
    IN v_CabeceraDataId int,
    IN v_CantidadEntera int,
    IN v_CantidadDecimal decimal,
    IN v_CantidadNumerico decimal,
    IN v_CantidadEnteraSmall smallint,
    IN v_LetrasGrande varchar,
    IN v_LetrasMedia varchar,
    IN v_LetrasPequena varchar,
    IN v_LetrasPequenaSmall char,
    IN v_LetrasPequenaSmallUno char,
    IN v_Fecha datetime,
    IN v_FechaSola date,
    IN v_Estado bit,
)
BEGIN
    UPDATE catalogo_cabeceradata
    SET
        CabeceraDataId = v_CabeceraDataId,
        CantidadEntera = v_CantidadEntera,
        CantidadDecimal = v_CantidadDecimal,
        CantidadNumerico = v_CantidadNumerico,
        CantidadEnteraSmall = v_CantidadEnteraSmall,
        LetrasGrande = v_LetrasGrande,
        LetrasMedia = v_LetrasMedia,
        LetrasPequena = v_LetrasPequena,
        LetrasPequenaSmall = v_LetrasPequenaSmall,
        LetrasPequenaSmallUno = v_LetrasPequenaSmallUno,
        Fecha = v_Fecha,
        FechaSola = v_FechaSola,
        Estado = v_Estado,
    WHERE
        CabeceraDataId = v_CabeceraDataId;
END;

CREATE  PROCEDURE `sp_CabeceraDataDelete`(IN v_CabeceraDataId int)
BEGIN
  DELETE
    FROM catalogo_cabeceradata
  WHERE CabeceraDataId = v_CabeceraDataId;
  END;
