package DataLayer;

import EntityLayer.ReservaEntity;;
import Enumerados.ProcessActionEnum;
import Framework.injector;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;

public class ReservaDB {

    injector Inj = new injector();

    public ArrayList<ReservaEntity> GetAllItems() { 

        ArrayList<ReservaEntity> DatoMemoria = new ArrayList<>();
        ReservaEntity en;
        try {
            Inj.Sp("sp_ReservaAllItems");
            ResultSet rs = Inj.RunSelect();
            while (rs.next()) {

                en = new ReservaEntity();
                en.setReservaId(rs.getInt("ReservaId"));
                en.setFechaRegistro(rs.getInt("FechaRegistro"));
                en.setCodUsuario(rs.getString("CodUsuario"));
                en.setEstadoRegistro(rs.getInt("EstadoRegistro"));
            }

        } catch (SQLException e) {
            System.out.println("ERROR "e);
            throw new UnsupportedOperationException("Datalater :" + e);
        }
        return DatoMemoria;
    }

    public ArrayList<ReservaEntity> GetAllItem(int ReservaId) { 

        ArrayList<ReservaEntity> DatoMemoria = new ArrayList<>();
        ReservaEntity en;
        try {
            Inj.Sp("sp_ReservaAllItem");
            Inj.Pmt_Integer("v_ReservaId", ReservaId, false);
            ResultSet rs = Inj.RunSelect();
            while (rs.next()) {

                en = new ReservaEntity();
                en.setReservaId(rs.getInt("ReservaId"));
                en.setFechaRegistro(rs.getInt("FechaRegistro"));
                en.setCodUsuario(rs.getString("CodUsuario"));
                en.setEstadoRegistro(rs.getInt("EstadoRegistro"));
            }

        } catch (SQLException e) {
            System.out.println("ERROR "e);
            throw new UnsupportedOperationException("Datalater :" + e);
        }
        return DatoMemoria;
    }

    public ReservaEntity Save(ReservaEntity entity) {
        Boolean State = null;
        try {
            String Store = "sp_Reserva_Save";
            if (entity.getAction() == ProcessActionEnum.Update.getValor()) {
                Store = "sp_Reserva_Update";
            }
            Inj.Sp(Store);
            Inj.Pmt_Integer("v_ReservaId", entity.getReservaId(), true);
            Inj.Pmt_Date("v_FechaRegistro", new java.sql.Date(entity.getFechaRegistro().getTime()), false);
            Inj.Pmt_String("v_CodUsuario", entity.getCodUsuario(), false);
            Inj.Pmt_Boolean("v_EstadoRegistro", entity.getEstadoRegistro(), false);
            if (entity.getAction() == ProcessActionEnum.Add.getValor()) {
                int Id = Inj.RunInsert();
                State = Id > 0;
                if (State) {
                    entity.setReservaId(Id);
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
            Inj.Sp("sp_ReservaDelete");
            Inj.Pmt_Integer("v_ReservaId", Id, false);
            State = Inj.RunDelete() > 0;
        } catch (Exception ex) {
            throw new UnsupportedOperationException("Datalater : " + ex);
        }
        return State;
    }

}
