package DataLayer;

import EntityLayer.AreaEntity;;
import Enumerados.ProcessActionEnum;
import Framework.injector;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;

public class AreaDB {

    injector Inj = new injector();

    public ArrayList<AreaEntity> GetAllItems() { 

        ArrayList<AreaEntity> DatoMemoria = new ArrayList<>();
        AreaEntity en;
        try {
            Inj.Sp("sp_AreaAllItems");
            ResultSet rs = Inj.RunSelect();
            while (rs.next()) {

                en = new AreaEntity();
                en.setAreaId(rs.getInt("AreaId"));
                en.setNombre(rs.getString("Nombre"));
                en.setFechaRegistro(rs.getInt("FechaRegistro"));
                en.setCodUsuario(rs.getString("CodUsuario"));
                en.setEstado(rs.getInt("Estado"));
            }

        } catch (SQLException e) {
            System.out.println("ERROR "e);
            throw new UnsupportedOperationException("Datalater :" + e);
        }
        return DatoMemoria;
    }

    public ArrayList<AreaEntity> GetAllItem(int AreaId) { 

        ArrayList<AreaEntity> DatoMemoria = new ArrayList<>();
        AreaEntity en;
        try {
            Inj.Sp("sp_AreaAllItem");
            Inj.Pmt_Integer("v_AreaId", AreaId, false);
            ResultSet rs = Inj.RunSelect();
            while (rs.next()) {

                en = new AreaEntity();
                en.setAreaId(rs.getInt("AreaId"));
                en.setNombre(rs.getString("Nombre"));
                en.setFechaRegistro(rs.getInt("FechaRegistro"));
                en.setCodUsuario(rs.getString("CodUsuario"));
                en.setEstado(rs.getInt("Estado"));
            }

        } catch (SQLException e) {
            System.out.println("ERROR "e);
            throw new UnsupportedOperationException("Datalater :" + e);
        }
        return DatoMemoria;
    }

    public AreaEntity Save(AreaEntity entity) {
        Boolean State = null;
        try {
            String Store = "sp_Area_Save";
            if (entity.getAction() == ProcessActionEnum.Update.getValor()) {
                Store = "sp_Area_Update";
            }
            Inj.Sp(Store);
            Inj.Pmt_Integer("v_AreaId", entity.getAreaId(), true);
            Inj.Pmt_String("v_Nombre", entity.getNombre(), false);
            Inj.Pmt_Date("v_FechaRegistro", new java.sql.Date(entity.getFechaRegistro().getTime()), false);
            Inj.Pmt_String("v_CodUsuario", entity.getCodUsuario(), false);
            Inj.Pmt_Boolean("v_Estado", entity.getEstado(), false);
            if (entity.getAction() == ProcessActionEnum.Add.getValor()) {
                int Id = Inj.RunInsert();
                State = Id > 0;
                if (State) {
                    entity.setAreaId(Id);
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
            Inj.Sp("sp_AreaDelete");
            Inj.Pmt_Integer("v_AreaId", Id, false);
            State = Inj.RunDelete() > 0;
        } catch (Exception ex) {
            throw new UnsupportedOperationException("Datalater : " + ex);
        }
        return State;
    }

}
