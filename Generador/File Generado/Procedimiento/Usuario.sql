CREATE PROCEDURE sp_UsuarioAllItems()
BEGIN
  SELECT
    UsuarioId,
    EmpleadoId,
    CodUsuario,
    Contrasena,
    FechaRegistro,
    RegistroCodUsuario,
    Estado
  FROM catalogo_usuario;
END;

CREATE PROCEDURE sp_UsuarioAllItem(IN v_Usuario INT)
BEGIN
  SELECT
    UsuarioId,
    EmpleadoId,
    CodUsuario,
    Contrasena,
    FechaRegistro,
    RegistroCodUsuario,
    Estado
  FROM catalogo_usuario WHERE  UsuarioId = v_UsuarioId;
END;

CREATE PROCEDURE sp_Usuario_Save(
    OUT v_UsuarioId int,
    IN v_EmpleadoId int,
    IN v_CodUsuario varchar(20),
    IN v_Contrasena varchar(100),
    IN v_FechaRegistro datetime,
    IN v_RegistroCodUsuario varchar(20),
    IN v_Estado bit(1)
)
BEGIN
    INSERT INTO catalogo_usuario (
        v_UsuarioId,
        v_EmpleadoId,
        v_CodUsuario,
        v_Contrasena,
        v_FechaRegistro,
        v_RegistroCodUsuario,
        v_Estado
) VALUES (
        v_UsuarioId,
        v_EmpleadoId,
        v_CodUsuario,
        v_Contrasena,
        v_FechaRegistro,
        v_RegistroCodUsuario,
        v_Estado
    );

  SET v_UsuarioId = LAST_INSERT_ID();

END;

CREATE PROCEDURE sp_Usuario_Update(
    IN v_UsuarioId int,
    IN v_EmpleadoId int,
    IN v_CodUsuario varchar(20),
    IN v_Contrasena varchar(100),
    IN v_FechaRegistro datetime,
    IN v_RegistroCodUsuario varchar(20),
    IN v_Estado bit(1)
)
BEGIN
    UPDATE catalogo_usuario
    SET
        UsuarioId = v_UsuarioId,
        EmpleadoId = v_EmpleadoId,
        CodUsuario = v_CodUsuario,
        Contrasena = v_Contrasena,
        FechaRegistro = v_FechaRegistro,
        RegistroCodUsuario = v_RegistroCodUsuario,
        Estado = v_Estado
    WHERE
        UsuarioId = v_UsuarioId;
END;

CREATE  PROCEDURE `sp_UsuarioDelete`(IN v_UsuarioId int)
BEGIN
  DELETE
    FROM catalogo_usuario
  WHERE UsuarioId = v_UsuarioId;
  END;
