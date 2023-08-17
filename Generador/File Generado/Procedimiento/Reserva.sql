CREATE PROCEDURE sp_ReservaAllItem(IN v_Reserva INT)
BEGIN
  SELECT
    ReservaId,
    FechaRegistro,
    CodUsuario,
    EstadoRegistro,
  FROM catalogo_Reserva WHERE  ReservaId = v_ReservaId;
END;

CREATE PROCEDURE sp_Reserva_Save(
    IN v_ReservaId int,
    IN v_FechaRegistro datetime,
    IN v_CodUsuario varchar,
    IN v_EstadoRegistro bit,
)
BEGIN
    INSERT INTO catalogo_Reserva (
        v_ReservaId,
        v_FechaRegistro,
        v_CodUsuario,
        v_EstadoRegistro,
) VALUES (
        v_ReservaId,
        v_FechaRegistro,
        v_CodUsuario,
        v_EstadoRegistro,
    );

  SET v_ReservaId = LAST_INSERT_ID();

END;

CREATE PROCEDURE sp_Reserva_Update(
    IN v_ReservaId int,
    IN v_FechaRegistro datetime,
    IN v_CodUsuario varchar,
    IN v_EstadoRegistro bit,
)
BEGIN
    UPDATE catalogo_Reserva
    SET
        ReservaId = v_ReservaId,
        FechaRegistro = v_FechaRegistro,
        CodUsuario = v_CodUsuario,
        EstadoRegistro = v_EstadoRegistro,
    WHERE
        ReservaId = v_ReservaId;
END;

CREATE  PROCEDURE `sp_ReservaDelete`(IN v_ReservaId int)
BEGIN
  DELETE
    FROM catalogo_Reserva
  WHERE ReservaId = v_ReservaId;
  END;
