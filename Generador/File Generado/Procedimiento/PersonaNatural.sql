CREATE PROCEDURE sp_PersonaNaturalAllItem(IN v_PersonaNatural INT)
BEGIN
  SELECT
    PersonaNaturalId,
    TipoDocumentoIdentidadId,
    NumDocumento,
    Nombres,
    ApellidoPaterno,
    ApellidoMaterno,
    FechaNacimiento,
    UbigeoId,
    Direccion,
    Telefono,
    Correo,
    Genero,
    EstadoCivil,
  FROM catalogo_personanatural WHERE  PersonaNaturalId = v_PersonaNaturalId;
END;

CREATE PROCEDURE sp_PersonaNatural_Save(
    IN v_PersonaNaturalId int,
    IN v_TipoDocumentoIdentidadId int,
    IN v_NumDocumento varchar,
    IN v_Nombres varchar,
    IN v_ApellidoPaterno varchar,
    IN v_ApellidoMaterno varchar,
    IN v_FechaNacimiento datetime,
    IN v_UbigeoId int,
    IN v_Direccion varchar,
    IN v_Telefono varchar,
    IN v_Correo varchar,
    IN v_Genero smallint,
    IN v_EstadoCivil smallint,
)
BEGIN
    INSERT INTO catalogo_personanatural (
        v_PersonaNaturalId,
        v_TipoDocumentoIdentidadId,
        v_NumDocumento,
        v_Nombres,
        v_ApellidoPaterno,
        v_ApellidoMaterno,
        v_FechaNacimiento,
        v_UbigeoId,
        v_Direccion,
        v_Telefono,
        v_Correo,
        v_Genero,
        v_EstadoCivil,
) VALUES (
        v_PersonaNaturalId,
        v_TipoDocumentoIdentidadId,
        v_NumDocumento,
        v_Nombres,
        v_ApellidoPaterno,
        v_ApellidoMaterno,
        v_FechaNacimiento,
        v_UbigeoId,
        v_Direccion,
        v_Telefono,
        v_Correo,
        v_Genero,
        v_EstadoCivil,
    );

  SET v_PersonaNaturalId = LAST_INSERT_ID();

END;

CREATE PROCEDURE sp_PersonaNatural_Update(
    IN v_PersonaNaturalId int,
    IN v_TipoDocumentoIdentidadId int,
    IN v_NumDocumento varchar,
    IN v_Nombres varchar,
    IN v_ApellidoPaterno varchar,
    IN v_ApellidoMaterno varchar,
    IN v_FechaNacimiento datetime,
    IN v_UbigeoId int,
    IN v_Direccion varchar,
    IN v_Telefono varchar,
    IN v_Correo varchar,
    IN v_Genero smallint,
    IN v_EstadoCivil smallint,
)
BEGIN
    UPDATE catalogo_personanatural
    SET
        PersonaNaturalId = v_PersonaNaturalId,
        TipoDocumentoIdentidadId = v_TipoDocumentoIdentidadId,
        NumDocumento = v_NumDocumento,
        Nombres = v_Nombres,
        ApellidoPaterno = v_ApellidoPaterno,
        ApellidoMaterno = v_ApellidoMaterno,
        FechaNacimiento = v_FechaNacimiento,
        UbigeoId = v_UbigeoId,
        Direccion = v_Direccion,
        Telefono = v_Telefono,
        Correo = v_Correo,
        Genero = v_Genero,
        EstadoCivil = v_EstadoCivil,
    WHERE
        PersonaNaturalId = v_PersonaNaturalId;
END;

CREATE  PROCEDURE `sp_PersonaNaturalDelete`(IN v_PersonaNaturalId int)
BEGIN
  DELETE
    FROM catalogo_personanatural
  WHERE PersonaNaturalId = v_PersonaNaturalId;
  END;
