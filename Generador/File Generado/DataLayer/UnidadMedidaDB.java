package DataLayer;

import EntityLayer.UnidadMedidaEntity;;
import Enumerados.ProcessActionEnum;
import Framework.injector;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;

public class UnidadMedidaDB {

    injector Inj = new injector();

    public ArrayList<UnidadMedidaEntity> GetAllItems() { 

        ArrayList<UnidadMedidaEntity> DatoMemoria = new ArrayList<>();
        UnidadMedidaEntity en;
        try {
            Inj.Sp("sp_UnidadMedidaAllItems");
            ResultSet rs = Inj.RunSelect();
            while (rs.next()) {

                en = new UnidadMedidaEntity();
                en.setUnidadMedidaId(rs.getInt("UnidadMedidaId"));
                en.setCodigo(rs.getString("Codigo"));
                en.setNombre(rs.getString("Nombre"));
            }

        } catch (SQLException e) {
            System.out.println("ERROR "e);
            throw new UnsupportedOperationException("Datalater :" + e);
        }
        return DatoMemoria;
    }

    public ArrayList<UnidadMedidaEntity> GetAllItem(int UnidadMedidaId) { 

        ArrayList<UnidadMedidaEntity> DatoMemoria = new ArrayList<>();
        UnidadMedidaEntity en;
        try {
            Inj.Sp("sp_UnidadMedidaAllItem");
            Inj.Pmt_Integer("v_UnidadMedidaId", UnidadMedidaId, false);
            ResultSet rs = Inj.RunSelect();
            while (rs.next()) {

                en = new UnidadMedidaEntity();
                en.setUnidadMedidaId(rs.getInt("UnidadMedidaId"));
                en.setCodigo(rs.getString("Codigo"));
                en.setNombre(rs.getString("Nombre"));
            }

        } catch (SQLException e) {
            System.out.println("ERROR "e);
            throw new UnsupportedOperationException("Datalater :" + e);
        }
        return DatoMemoria;
    }

    public UnidadMedidaEntity Save(UnidadMedidaEntity entity) {
        Boolean State = null;
        try {
            String Store = "sp_UnidadMedida_Save";
            if (entity.getAction() == ProcessActionEnum.Update.getValor()) {
                Store = "sp_UnidadMedida_Update";
            }
            Inj.Sp(Store);
            Inj.Pmt_Integer("v_UnidadMedidaId", entity.getUnidadMedidaId(), true);
            Inj.Pmt_String("v_Codigo", entity.getCodigo(), false);
            Inj.Pmt_String("v_Nombre", entity.getNombre(), false);
            if (entity.getAction() == ProcessActionEnum.Add.getValor()) {
                int Id = Inj.RunInsert();
                State = Id > 0;
                if (State) {
                    entity.setUnidadMedidaId(Id);
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
            Inj.Sp("sp_UnidadMedidaDelete");
            Inj.Pmt_Integer("v_UnidadMedidaId", Id, false);
            State = Inj.RunDelete() > 0;
        } catch (Exception ex) {
            throw new UnsupportedOperationException("Datalater : " + ex);
        }
        return State;
    }

}
