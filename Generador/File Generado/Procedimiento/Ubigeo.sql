CREATE PROCEDURE sp_UbigeoAllItem(IN v_Ubigeo INT)
BEGIN
  SELECT
    UbigeoId,
    CodUbigeo,
    DesUbigeo,
    DepartamentoId,
    ProvinciaId,
    DistritoId,
  FROM catalogo_ubigeo WHERE  UbigeoId = v_UbigeoId;
END;

CREATE PROCEDURE sp_Ubigeo_Save(
    IN v_UbigeoId int,
    IN v_CodUbigeo int,
    IN v_DesUbigeo varchar,
    IN v_DepartamentoId int,
    IN v_ProvinciaId int,
    IN v_DistritoId int,
)
BEGIN
    INSERT INTO catalogo_ubigeo (
        v_UbigeoId,
        v_CodUbigeo,
        v_DesUbigeo,
        v_DepartamentoId,
        v_ProvinciaId,
        v_DistritoId,
) VALUES (
        v_UbigeoId,
        v_CodUbigeo,
        v_DesUbigeo,
        v_DepartamentoId,
        v_ProvinciaId,
        v_DistritoId,
    );

  SET v_UbigeoId = LAST_INSERT_ID();

END;

CREATE PROCEDURE sp_Ubigeo_Update(
    IN v_UbigeoId int,
    IN v_CodUbigeo int,
    IN v_DesUbigeo varchar,
    IN v_DepartamentoId int,
    IN v_ProvinciaId int,
    IN v_DistritoId int,
)
BEGIN
    UPDATE catalogo_ubigeo
    SET
        UbigeoId = v_UbigeoId,
        CodUbigeo = v_CodUbigeo,
        DesUbigeo = v_DesUbigeo,
        DepartamentoId = v_DepartamentoId,
        ProvinciaId = v_ProvinciaId,
        DistritoId = v_DistritoId,
    WHERE
        UbigeoId = v_UbigeoId;
END;

CREATE  PROCEDURE `sp_UbigeoDelete`(IN v_UbigeoId int)
BEGIN
  DELETE
    FROM catalogo_ubigeo
  WHERE UbigeoId = v_UbigeoId;
  END;
