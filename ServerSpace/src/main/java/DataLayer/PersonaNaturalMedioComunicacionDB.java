package DataLayer;

import EntityLayer.PersonaNaturalMedioComunicacionEntity;
import Enumerados.ProcessActionEnum;
import Framework.Utilidades;
import Framework.injector;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;

public class PersonaNaturalMedioComunicacionDB {

    injector Inj = new injector();

    public ArrayList<PersonaNaturalMedioComunicacionEntity> GetAllItems() {

        ArrayList<PersonaNaturalMedioComunicacionEntity> DatoMemoria = new ArrayList<>();
        PersonaNaturalMedioComunicacionEntity en;
        try {
            Inj.Sp("sp_PersonaNaturalMedioComunicacionAllItems");
            ResultSet rs = Inj.RunSelect();
            while (rs.next()) {

                en = new PersonaNaturalMedioComunicacionEntity();
                en.setPersonaNaturalMedioComunicacionId(rs.getInt("PersonaNaturalMedioComunicacionId"));
                en.setPersonaNaturalId(rs.getInt("PersonaNaturalId"));
                en.setMedioComunicacionId(rs.getInt("MedioComunicacionId"));
                en.setDato(rs.getString("Dato"));
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

    public ArrayList<PersonaNaturalMedioComunicacionEntity> GetAllItem(int PersonaNaturalMedioComunicacionId) {

        ArrayList<PersonaNaturalMedioComunicacionEntity> DatoMemoria = new ArrayList<>();
        PersonaNaturalMedioComunicacionEntity en;
        try {
            Inj.Sp("sp_PersonaNaturalMedioComunicacionAllItem");
            Inj.Pmt_Integer("v_PersonaNaturalMedioComunicacionId", PersonaNaturalMedioComunicacionId, false);
            ResultSet rs = Inj.RunSelect();
            while (rs.next()) {

                en = new PersonaNaturalMedioComunicacionEntity();
                en.setPersonaNaturalMedioComunicacionId(rs.getInt("PersonaNaturalMedioComunicacionId"));
                en.setPersonaNaturalId(rs.getInt("PersonaNaturalId"));
                en.setMedioComunicacionId(rs.getInt("MedioComunicacionId"));
                en.setDato(rs.getString("Dato"));
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

    public PersonaNaturalMedioComunicacionEntity Save(PersonaNaturalMedioComunicacionEntity entity) {
        Boolean State = null;
        try {
            String Store = "sp_PersonaNaturalMedioComunicacion_Save";
            if (entity.getAction() == ProcessActionEnum.Update.getValor()) {
                Store = "sp_PersonaNaturalMedioComunicacion_Update";
            }
            Inj.Sp(Store);
            Inj.Pmt_Integer("v_PersonaNaturalMedioComunicacionId", entity.getPersonaNaturalMedioComunicacionId(), true);
            Inj.Pmt_Integer("v_PersonaNaturalId", entity.getPersonaNaturalId(), false);
            Inj.Pmt_Integer("v_MedioComunicacionId", entity.getMedioComunicacionId(), false);
            Inj.Pmt_String("v_Dato", entity.getDato(), false);
            Inj.Pmt_String("v_FechaRegistro", Utilidades.getFechaRegistro(), false);
            Inj.Pmt_String("v_CodUsuario", entity.getCodUsuario(), false);
            Inj.Pmt_Boolean("v_EstadoRegistro", entity.getEstadoRegistro(), false);
            if (entity.getAction() == ProcessActionEnum.Add.getValor()) {
                int Id = Inj.RunInsert();
                State = Id > 0;
                if (State) {
                    entity.setPersonaNaturalMedioComunicacionId(Id);
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
            Inj.Sp("sp_PersonaNaturalMedioComunicacionDelete");
            Inj.Pmt_Integer("v_PersonaNaturalMedioComunicacionId", Id, false);
            State = Inj.RunDelete() > 0;
        } catch (Exception ex) {
            throw new UnsupportedOperationException("Datalater : " + ex);
        }
        return State;
    }

}
