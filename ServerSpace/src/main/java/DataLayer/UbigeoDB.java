package DataLayer;

import EntityLayer.UbigeoEntity;
import Framework.BaseDB;
import Framework.Inj;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;

public class UbigeoDB extends BaseDB {

    public ArrayList<UbigeoEntity> GetUbigeoLikeItem(String Nombre) {

        ArrayList<UbigeoEntity> DatoMemoria = new ArrayList<>();
        UbigeoEntity en;
        try {
            Inj.Sp("sp_UbigeoBuscarLike");
            Inj.Pmt_String("@DesUbigeo", Nombre, false);
            ResultSet rs = Inj.RunSelect();
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

        ArrayList<UbigeoEntity> DatoMemoria = new ArrayList<>();
        UbigeoEntity en;
        try {
            Inj.Sp("sp_UbigeoItem");
            Inj.Pmt_Integer("@UbigeoId", UbigeoId, false);
            ResultSet rs = Inj.RunSelect();
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
