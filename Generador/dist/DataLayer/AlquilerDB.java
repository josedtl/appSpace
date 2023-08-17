package DataLayer;

import EntityLayer.AlquilerEntity;;
import Enumerados.ProcessActionEnum;
import Framework.injector;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;

public class AlquilerDB {

    injector Inj = new injector();

    public ArrayList<AlquilerEntity> GetAllItems() { 

        ArrayList<AlquilerEntity> DatoMemoria = new ArrayList<>();
        AlquilerEntity en;
        try {
            Inj.Sp("sp_AlquilerAllItems");
            ResultSet rs = Inj.RunSelect();
            while (rs.next()) {

                en = new AlquilerEntity();
                en.setAlquilerId(rs.getInt("AlquilerId"));
                en.setFecharAlquiler(rs.getInt("FecharAlquiler"));
                en.setCodUsuario(rs.getString("CodUsuario"));
                en.setEstadoAlquiler(rs.getString("EstadoAlquiler"));
            }

        } catch (SQLException e) {
            System.out.println("ERROR "e);
            throw new UnsupportedOperationException("Datalater :" + e);
        }
        return DatoMemoria;
    }

    public ArrayList<AlquilerEntity> GetAllItem(int AlquilerId) { 

        ArrayList<AlquilerEntity> DatoMemoria = new ArrayList<>();
        AlquilerEntity en;
        try {
            Inj.Sp("sp_AlquilerAllItem");
            Inj.Pmt_Integer("v_AlquilerId", AlquilerId, false);
            ResultSet rs = Inj.RunSelect();
            while (rs.next()) {

                en = new AlquilerEntity();
                en.setAlquilerId(rs.getInt("AlquilerId"));
                en.setFecharAlquiler(rs.getInt("FecharAlquiler"));
                en.setCodUsuario(rs.getString("CodUsuario"));
                en.setEstadoAlquiler(rs.getString("EstadoAlquiler"));
            }

        } catch (SQLException e) {
            System.out.println("ERROR "e);
            throw new UnsupportedOperationException("Datalater :" + e);
        }
        return DatoMemoria;
    }

    public AlquilerEntity Save(AlquilerEntity entity) {
        Boolean State = null;
        try {
            String Store = "sp_Alquiler_Save";
            if (entity.getAction() == ProcessActionEnum.Update.getValor()) {
                Store = "sp_Alquiler_Update";
            }
            Inj.Sp(Store);
            Inj.Pmt_Integer("v_AlquilerId", entity.getAlquilerId(), true);
            Inj.Pmt_Date("v_FecharAlquiler", new java.sql.Date(entity.getFecharAlquiler().getTime()), false);
            Inj.Pmt_String("v_CodUsuario", entity.getCodUsuario(), false);
            Inj.Pmt_String("v_EstadoAlquiler", entity.getEstadoAlquiler(), false);
            if (entity.getAction() == ProcessActionEnum.Add.getValor()) {
                int Id = Inj.RunInsert();
                State = Id > 0;
                if (State) {
                    entity.setAlquilerId(Id);
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
            Inj.Sp("sp_AlquilerDelete");
            Inj.Pmt_Integer("v_AlquilerId", Id, false);
            State = Inj.RunDelete() > 0;
        } catch (Exception ex) {
            throw new UnsupportedOperationException("Datalater : " + ex);
        }
        return State;
    }

}
