package DataLayer;

import EntityLayer.PersonaNaturalEntity;
import Enumerados.ProcessActionEnum;
import Framework.BaseDB;
import Framework.Inj;
import Framework.Utilidades;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;

public class PersonaNaturalDB extends BaseDB {

    public ArrayList<PersonaNaturalEntity> ObtenerItem(int PersonaNaturalId) {

        ArrayList<PersonaNaturalEntity> DatoMemoria = new ArrayList<>();
        PersonaNaturalEntity en;
        try {
            Inj.Sp("sp_PersonaObtenerItem");
            Inj.Pmt_Integer("@PersonaNaturalId", PersonaNaturalId, false);
            ResultSet rs = Inj.RunSelect();
            fillSchemeTable(rs);
            while (rs.next()) {
                en = new PersonaNaturalEntity();
                if (fillFrom(rs, en)) {
                    DatoMemoria.add(en);
                }
            }

        } catch (SQLException e) {
            throw new UnsupportedOperationException("Datalater :" + e);
        }
        return DatoMemoria;
    }

    public PersonaNaturalEntity Registrar(PersonaNaturalEntity entity) {
        Boolean State = null;
        try {
            Inj.IniciarTranssaccion(false);
            String Store = "sp_PersonaRegistar";
            if (entity.getAction() == ProcessActionEnum.Update.getValor()) {
                Store = "sp_PersonaActualizar";
            }
            Inj.Sp(Store);
            Inj.Pmt_Integer("@PersonaNaturalId", entity.getPersonaNaturalId(), true);
            Inj.Pmt_Integer("@TipoDocumentoIdentidadId", entity.getTipoDocumentoIdentidadId(), false);
            Inj.Pmt_String("@NumDocumento", entity.getNumDocumento(), false);
            Inj.Pmt_String("@Nombres", entity.getNombres(), false);
            Inj.Pmt_String("@ApellidoPaterno", entity.getApellidoPaterno(), false);
            Inj.Pmt_String("@ApellidoMaterno", entity.getApellidoMaterno(), false);
            Inj.Pmt_String("@FechaNacimiento", entity.getFechaNacimiento().toString(), false);
            Inj.Pmt_String("@Direccion", entity.getDireccion(), false);
            Inj.Pmt_String("@Telefono", entity.getTelefono(), false);
            Inj.Pmt_String("@Correo", entity.getCorreo(), false);
            Inj.Pmt_Integer("@SexoId", entity.getSexoId(), false);
            Inj.Pmt_Integer("@EstadoCivilId", entity.getEstadoCivilId(), false);
            Inj.Pmt_Integer("@UbigeoId", entity.getUbigeoId(), false);
            Inj.Pmt_String("@CodUsuario", entity.getCodUsuario(), false);
            Inj.Pmt_String("@FechaRegistro", Utilidades.getFechaRegistro(), false);
            if (entity.getAction() == ProcessActionEnum.Add.getValor()) {
                int Id = Inj.RunInsert();
                State = Id > 0;
                if (State) {
                    entity.setPersonaNaturalId(Id);
                }
            }
            if (entity.getAction() == ProcessActionEnum.Update.getValor()) {
                Inj.RunUpdate();
            }

        } catch (Exception ex) {
            throw new UnsupportedOperationException("Datalater : " + ex);
        }
        return entity;
    }

    public ArrayList<PersonaNaturalEntity> ObtenerMain() {

        ArrayList<PersonaNaturalEntity> DatoMemoria = new ArrayList<>();
        PersonaNaturalEntity en;
        try {
            Inj.Sp("sp_PersonaObtenerMain");
            ResultSet rs = Inj.RunSelect();
            fillSchemeTable(rs);
            while (rs.next()) {
                en = new PersonaNaturalEntity();
                if (fillFrom(rs, en)) {
                    DatoMemoria.add(en);
                }
            }

        } catch (SQLException e) {
            System.out.println("ERROR " + e);
            throw new UnsupportedOperationException("Datalater :" + e);
        }
        return DatoMemoria;
    }


}
