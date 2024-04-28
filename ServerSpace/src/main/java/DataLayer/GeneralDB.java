package DataLayer;

import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;

import EntityLayer.EntidadEntity;
import Framework.BaseDB;
import Framework.injector;

public class GeneralDB extends BaseDB{

   

    public ArrayList<EntidadEntity> GetEntidadBuscarItem(String NombreCompleto) {
        injector InjDB = new injector();
        ArrayList<EntidadEntity> DatoMemoria = new ArrayList<>();
        EntidadEntity en;
        try {
            InjDB.Sp("sp_EntidadBuscarItem");
            InjDB.Pmt_String("@NombreCompleto", NombreCompleto , false);
            ResultSet rs = InjDB.RunSelect();
            fillSchemeTable(rs);
            while (rs.next()) {
                en = new EntidadEntity();
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
