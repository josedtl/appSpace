/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package DataLayer.MyCode;

import EntityLayer.CargoEntity;
import Framework.injector;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;

/**
 *
 * @author DAVID
 */
public class CargoDB {

    injector Inj = new injector();

    public ArrayList<CargoEntity> GetCargoLikeItem(String Nombre) {

        ArrayList<CargoEntity> DatoMemoria = new ArrayList<>();
        CargoEntity en;
        try {
            Inj.Sp("sp_CargoLikeItem");
            Inj.Pmt_String("v_Nombre", Nombre, false);
            ResultSet rs = Inj.RunSelect();
            while (rs.next()) {

                en = new CargoEntity();
                en.setCargoId(rs.getInt("CargoId"));
                en.setNombre(rs.getString("Nombre"));
                DatoMemoria.add(en);

            }

        } catch (SQLException e) {
            System.out.println("ERROR " + e);
            throw new UnsupportedOperationException("Datalater :" + e);
        }
        return DatoMemoria;
    }

}
