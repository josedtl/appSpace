CREATE PROCEDURE sp_DepartamentoAllItem(IN v_Departamento INT)
BEGIN
  SELECT
    DepartamentoId,
    CodDepartamento,
    NomDepartamento,
  FROM catalogo_departamento WHERE  DepartamentoId = v_DepartamentoId;
END;

CREATE PROCEDURE sp_Departamento_Save(
    IN v_DepartamentoId int,
    IN v_CodDepartamento int,
    IN v_NomDepartamento varchar,
)
BEGIN
    INSERT INTO catalogo_departamento (
        v_DepartamentoId,
        v_CodDepartamento,
        v_NomDepartamento,
) VALUES (
        v_DepartamentoId,
        v_CodDepartamento,
        v_NomDepartamento,
    );

  SET v_DepartamentoId = LAST_INSERT_ID();

END;

CREATE PROCEDURE sp_Departamento_Update(
    IN v_DepartamentoId int,
    IN v_CodDepartamento int,
    IN v_NomDepartamento varchar,
)
BEGIN
    UPDATE catalogo_departamento
    SET
        DepartamentoId = v_DepartamentoId,
        CodDepartamento = v_CodDepartamento,
        NomDepartamento = v_NomDepartamento,
    WHERE
        DepartamentoId = v_DepartamentoId;
END;

CREATE  PROCEDURE `sp_DepartamentoDelete`(IN v_DepartamentoId int)
BEGIN
  DELETE
    FROM catalogo_departamento
  WHERE DepartamentoId = v_DepartamentoId;
  END;
