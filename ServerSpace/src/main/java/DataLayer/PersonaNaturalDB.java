package DataLayer;

import EntityLayer.PersonaNaturalEntity;
import Enumerados.ProcessActionEnum;
import Framework.Utilidades;
import Framework.injector;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;

public class PersonaNaturalDB extends DataLayer.MyCode.PersonaNaturalDB {

    injector Inj = new injector();

    public ArrayList<PersonaNaturalEntity> GetAllItems() {

        ArrayList<PersonaNaturalEntity> DatoMemoria = new ArrayList<>();
        PersonaNaturalEntity en;
        try {
            Inj.Sp("sp_PersonaNaturalAllItems");
            ResultSet rs = Inj.RunSelect();
            while (rs.next()) {

                en = new PersonaNaturalEntity();
                en.setPersonaNaturalId(rs.getInt("PersonaNaturalId"));
                en.setTipoDocumentoIdentidadId(rs.getInt("TipoDocumentoIdentidadId"));
                en.setNumDocumento(rs.getString("NumDocumento"));
                en.setNombres(rs.getString("Nombres"));
                en.setApellidoPaterno(rs.getString("ApellidoPaterno"));
                en.setApellidoMaterno(rs.getString("ApellidoMaterno"));
                en.setFechaNacimiento(rs.getTimestamp("FechaNacimiento"));
                en.setUbigeoId(rs.getInt("UbigeoId"));
                en.setDireccion(rs.getString("Direccion"));
                en.setTelefono(rs.getString("Telefono"));
                en.setCorreo(rs.getString("Correo"));
                en.setGeneroId(rs.getInt("GeneroId"));
                en.setEstadoCivilId(rs.getInt("EstadoCivilId"));
                en.setFechaRegistro(rs.getTimestamp("FechaRegistro"));
                en.setCodUsuario(rs.getString("CodUsuario"));
                en.setEstadoRegistro(rs.getBoolean("EstadoRegistro"));
                DatoMemoria.add(en);

            }

        } catch (SQLException e) {
            System.out.println("ERROR " + e);
            throw new UnsupportedOperationException("Datalater :" + e);
        }
        return DatoMemoria;
    }

    public ArrayList<PersonaNaturalEntity> GetAllItem(int PersonaNaturalId) {

        ArrayList<PersonaNaturalEntity> DatoMemoria = new ArrayList<>();
        PersonaNaturalEntity en;
        try {
            Inj.Sp("sp_PersonaNaturalAllItem");
            Inj.Pmt_Integer("v_PersonaNaturalId", PersonaNaturalId, false);
            ResultSet rs = Inj.RunSelect();
            while (rs.next()) {

                en = new PersonaNaturalEntity();
                en.setPersonaNaturalId(rs.getInt("PersonaNaturalId"));
                en.setTipoDocumentoIdentidadId(rs.getInt("TipoDocumentoIdentidadId"));
                en.setNumDocumento(rs.getString("NumDocumento"));
                en.setNombres(rs.getString("Nombres"));
                en.setApellidoPaterno(rs.getString("ApellidoPaterno"));
                en.setApellidoMaterno(rs.getString("ApellidoMaterno"));
                en.setFechaNacimiento(rs.getTimestamp("FechaNacimiento"));
                en.setUbigeoId(rs.getInt("UbigeoId"));
                en.setDireccion(rs.getString("Direccion"));
                en.setTelefono(rs.getString("Telefono"));
                en.setCorreo(rs.getString("Correo"));
                en.setGeneroId(rs.getInt("GeneroId"));
                en.setEstadoCivilId(rs.getInt("EstadoCivilId"));
                en.setFechaRegistro(rs.getTimestamp("FechaRegistro"));
                en.setCodUsuario(rs.getString("CodUsuario"));
                en.setEstadoRegistro(rs.getBoolean("EstadoRegistro"));
                DatoMemoria.add(en);

            }

        } catch (SQLException e) {
            System.out.println("ERROR " + e);
            throw new UnsupportedOperationException("Datalater :" + e);
        }
        return DatoMemoria;
    }

    public PersonaNaturalEntity Save(PersonaNaturalEntity entity) {
        Boolean State = null;
        try {
            String Store = "sp_PersonaNatural_Save";
            if (entity.getAction() == ProcessActionEnum.Update.getValor()) {
                Store = "sp_PersonaNatural_Update";
            }
            Inj.Sp(Store);
            Inj.Pmt_Integer("v_PersonaNaturalId", entity.getPersonaNaturalId(), true);
            Inj.Pmt_Integer("v_TipoDocumentoIdentidadId", entity.getTipoDocumentoIdentidadId(), false);
            Inj.Pmt_String("v_NumDocumento", entity.getNumDocumento(), false);
            Inj.Pmt_String("v_Nombres", entity.getNombres(), false);
            Inj.Pmt_String("v_ApellidoPaterno", entity.getApellidoPaterno(), false);
            Inj.Pmt_String("v_ApellidoMaterno", entity.getApellidoMaterno(), false);
            Inj.Pmt_String("v_FechaNacimiento", entity.getFechaNacimiento().toString(), false);
            Inj.Pmt_Integer("v_UbigeoId", entity.getUbigeoId(), false);
            Inj.Pmt_String("v_Direccion", entity.getDireccion(), false);
            Inj.Pmt_String("v_Telefono", entity.getTelefono(), false);
            Inj.Pmt_String("v_Correo", entity.getCorreo(), false);
            Inj.Pmt_Integer("v_GeneroId", entity.getGeneroId(), false);
            Inj.Pmt_Integer("v_EstadoCivilId", entity.getEstadoCivilId(), false);
            Inj.Pmt_String("v_FechaRegistro", Utilidades.getFechaRegistro(), false);
            Inj.Pmt_String("v_CodUsuario", entity.getCodUsuario(), false);
            Inj.Pmt_Boolean("v_EstadoRegistro", entity.getEstadoRegistro(), false);
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

            if (entity.getDetalleMedioComunicacion() != null && entity.getDetalleMedioComunicacion().size() > 0) {
                for (var detalle : entity.getDetalleMedioComunicacion()) {
                    PersonaNaturalMedioComunicacionDB DB_Detalle = new PersonaNaturalMedioComunicacionDB();
                    if (detalle.getAction() == ProcessActionEnum.Delete.getValor()) {
                        DB_Detalle.Delete(detalle.getPersonaNaturalMedioComunicacionId());
                    } else {
                        DB_Detalle.Save(detalle);
                    }
                }
            }

        } catch (Exception ex) {
            throw new UnsupportedOperationException("Datalater : " + ex);
        }
        return entity;
    }

    public Boolean Delete(Integer Id) {

        Boolean State = false;
        try {
            Inj.Sp("sp_PersonaNaturalDelete");
            Inj.Pmt_Integer("v_PersonaNaturalId", Id, false);
            State = Inj.RunDelete() > 0;
        } catch (Exception ex) {
            throw new UnsupportedOperationException("Datalater : " + ex);
        }
        return State;
    }

}
