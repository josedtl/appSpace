package DataLayer;

import EntityLayer.PersonaNaturalEntity;
import EntityLayer.TipoElementoEntity;
import Enumerados.ProcessActionEnum;
import Framework.injector;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;

/**
 *
 * @author RUTH
 */
public class PersonaNaturalDB {

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
                en.setFechaNacimiento(rs.getDate("FechaNacimiento"));
                en.setUbigeoId(rs.getInt("UbigeoId"));
                en.setDireccion(rs.getString("Direccion"));
                en.setTelefono(rs.getString("Telefono"));
                en.setCorreo(rs.getString("Correo"));
                en.setGenero(rs.getInt("Genero"));
                en.setEstadoCivil(rs.getInt("EstadoCivil"));
                DatoMemoria.add(en);

            }

        } catch (SQLException e) {
            System.out.println("ERROR" + e);
            throw new UnsupportedOperationException("Datalater :" + e);
        }
        return DatoMemoria;
    }

    public ArrayList<PersonaNaturalEntity> GetAllItem(int PersonaNaturalId) {

        ArrayList<PersonaNaturalEntity> DatoMemoria = new ArrayList<>();
        PersonaNaturalEntity en;
        try {

            Inj.Sp("sp_PersonaNaturalAllItem");
            ResultSet rs = Inj.RunSelect();
            while (rs.next()) {

                en = new PersonaNaturalEntity();
                en.setPersonaNaturalId(rs.getInt("PersonaNaturalId"));
                en.setTipoDocumentoIdentidadId(rs.getInt("TipoDocumentoIdentidadId"));
                en.setNumDocumento(rs.getString("NumDocumento"));
                en.setNombres(rs.getString("Nombres"));
                en.setApellidoPaterno(rs.getString("ApellidoPaterno"));
                en.setApellidoMaterno(rs.getString("ApellidoMaterno"));
                en.setFechaNacimiento(rs.getDate("FechaNacimiento"));
                en.setUbigeoId(rs.getInt("UbigeoId"));
                en.setDireccion(rs.getString("Direccion"));
                en.setTelefono(rs.getString("Telefono"));
                en.setCorreo(rs.getString("Correo"));
                en.setGenero(rs.getInt("Genero"));
                en.setEstadoCivil(rs.getInt("EstadoCivil"));
                DatoMemoria.add(en);

            }

        } catch (SQLException e) {
            System.out.println("ERROR" + e);
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
            Inj.Pmt_Integer("v_Genero", entity.getGenero(), false);
            Inj.Pmt_Integer("v_EstadoCivil", entity.getEstadoCivil(), false);
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
