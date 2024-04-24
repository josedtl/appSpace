package DataLayer;

import EntityLayer.MonedaEntity;
import Enumerados.ProcessActionEnum;
import Framework.BaseDB;
import Framework.Inj;
import Framework.Utilidades;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;

public class MonedaDB extends BaseDB {
    

    public ArrayList<MonedaEntity> ObtenerMonedaItems () { 

        ArrayList<MonedaEntity> DatoMemoria = new ArrayList<>();
        MonedaEntity en;
        try {
            Inj.Sp("sp_MonedaObtenerItems");
            ResultSet rs = Inj.RunSelect();
            fillSchemeTable(rs);
            while (rs.next()) {
                en = new MonedaEntity();
                if (fillFrom(rs, en)) {
                    DatoMemoria.add(en);
                }
            }

        } catch (SQLException e) {
            System.out.println("ERROR "+e);
            throw new UnsupportedOperationException("Datalater :" + e);
        }
        return DatoMemoria;
    }

        public ArrayList<MonedaEntity> ObtenerMonedaItem(int MonedaId) { 

            ArrayList<MonedaEntity> DatoMemoria = new ArrayList<>();
            MonedaEntity en;
            try {
                Inj.Sp("sp_MonedaObtenerItem");
                Inj.Pmt_Integer("@MonedaId", MonedaId, false);
                ResultSet rs = Inj.RunSelect();
                fillSchemeTable(rs);
                while (rs.next()) {
                    en = new MonedaEntity();
                    if (fillFrom(rs, en)) {
                        DatoMemoria.add(en);
                    }
                }
    
            } catch (SQLException e) {
                System.out.println("ERROR "+e);
                throw new UnsupportedOperationException("Datalater :" + e);
            }
            return DatoMemoria;
        }

}
