package DataLayer;

import EntityLayer.MonedaEntity;
import Framework.BaseDB;
import Framework.injector;

import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;

public class MonedaDB extends BaseDB {

    injector InjDB = new injector();

    public ArrayList<MonedaEntity> ObtenerMonedaItems() {
        ArrayList<MonedaEntity> DatoMemoria = new ArrayList<>();
        MonedaEntity en;
        try {
            InjDB.Sp("sp_MonedaObtenerItems");
            ResultSet rs = InjDB.RunSelect();
            fillSchemeTable(rs);
            while (rs.next()) {
                en = new MonedaEntity();
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

    public ArrayList<MonedaEntity> ObtenerMonedaItem(int MonedaId) {

        ArrayList<MonedaEntity> DatoMemoria = new ArrayList<>();
        MonedaEntity en;
        try {
            InjDB.Sp("sp_MonedaObtenerItem");
            InjDB.Pmt_Integer("@MonedaId", MonedaId, false);
            ResultSet rs = InjDB.RunSelect();
            fillSchemeTable(rs);
            while (rs.next()) {
                en = new MonedaEntity();
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
