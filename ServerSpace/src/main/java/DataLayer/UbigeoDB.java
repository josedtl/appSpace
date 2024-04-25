package DataLayer;

import EntityLayer.UbigeoEntity;
import Framework.BaseDB;
import Framework.Inj;
import Framework.injector;

import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;

public class UbigeoDB extends BaseDB {

    public ArrayList<UbigeoEntity> GetUbigeoLikeItem(String Nombre) {
        injector InjDB = new injector();
        ArrayList<UbigeoEntity> DatoMemoria = new ArrayList<>();
        UbigeoEntity en;
        try {
            InjDB.Sp("sp_UbigeoBuscarLike");
            InjDB.Pmt_String("@DesUbigeo", Nombre, false);
            ResultSet rs = InjDB.RunSelect();
            fillSchemeTable(rs);
            while (rs.next()) {
                en = new UbigeoEntity();
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

    public ArrayList<UbigeoEntity> GetAllItem(int UbigeoId) {
        injector InjDB = new injector();
        ArrayList<UbigeoEntity> DatoMemoria = new ArrayList<>();
        UbigeoEntity en;
        try {
            InjDB.Sp("sp_UbigeoItem");
            InjDB.Pmt_Integer("@UbigeoId", UbigeoId, false);
            ResultSet rs = InjDB.RunSelect();
            fillSchemeTable(rs);
            while (rs.next()) {
                en = new UbigeoEntity();
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
