package DataLayer;

import EntityLayer.UnidadMedidaEntity;
import Enumerados.ProcessActionEnum;
import Framework.BaseDB;
import Framework.Inj;
import Framework.Utilidades;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;

public class UnidadMedidaDB extends BaseDB {

    public ArrayList<UnidadMedidaEntity> GetUnidadMedidaItems() {

        ArrayList<UnidadMedidaEntity> DatoMemoria = new ArrayList<>();
        UnidadMedidaEntity en;
        try {
            Inj.Sp("sp_UnidadMedidaItems");
            ResultSet rs = Inj.RunSelect();
            fillSchemeTable(rs);
            while (rs.next()) {
                en = new UnidadMedidaEntity();
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

    public ArrayList<UnidadMedidaEntity> GetUnidadMedida_Item(int UnidadMedidaId) {

        ArrayList<UnidadMedidaEntity> DatoMemoria = new ArrayList<>();
        UnidadMedidaEntity en;
        try {
            Inj.Sp("sp_UnidadMedida_Item");
            Inj.Pmt_Integer("@UnidadMedidaId", UnidadMedidaId, false);
            ResultSet rs = Inj.RunSelect();
            fillSchemeTable(rs);
            while (rs.next()) {
                en = new UnidadMedidaEntity();
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
