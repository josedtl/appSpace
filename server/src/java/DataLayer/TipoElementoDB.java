/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package DataLayer;

import EntityLayer.TipoElementoEntity;
import Framework.injector;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;

/**
 *
 * @author DAVID
 */
public class TipoElementoDB {

    injector Inj = new injector();

    public ArrayList<TipoElementoEntity> GetTipoElementoItems() {

        ArrayList<TipoElementoEntity> DatoMemoria = new ArrayList<>();
        TipoElementoEntity en;
        try {

            Inj.Sp("sp_TipoElementoItems");
            ResultSet rs = Inj.RunSelect();
            while (rs.next()) {

                en = new TipoElementoEntity();
                en.setTipoElementoId(rs.getInt("TipoElementoId"));
                en.setNombre(rs.getString("Nombre"));
                DatoMemoria.add(en);

            }

        } catch (SQLException e) {
            System.out.println("ERROR" + e);
            throw new UnsupportedOperationException("Datalater :" + e);
        }
        return DatoMemoria;
    }
}
