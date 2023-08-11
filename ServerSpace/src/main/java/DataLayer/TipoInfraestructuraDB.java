/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package DataLayer;

import EntityLayer.*;
import Framework.injector;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;

/**
 *
 * @author DAVID
 */
public class TipoInfraestructuraDB {
    
  injector Inj = new injector();   

  public ArrayList<TipoInfraestructuraEntity> GetTipoInfraestructuraItems() {

        ArrayList<TipoInfraestructuraEntity> DatoMemoria = new ArrayList<>();
        TipoInfraestructuraEntity en;
        try {

            Inj.Sp("sp_TipoElementoItems");
            ResultSet rs = Inj.RunSelect();
            while (rs.next()) {

                en = new TipoInfraestructuraEntity();
                en.setTipoInfraestructuraId(rs.getInt("TipoInfraestructuraId"));
                en.setNombre(rs.getString("Nombre"));
                DatoMemoria.add(en);

            }

        } catch (SQLException e) {
            System.out.println("ERROR" + e);
            throw new UnsupportedOperationException("Datalater :" + e);
        }
        return DatoMemoria;
    }
  
    public ArrayList<TipoInfraestructuraEntity> GetTipoInfraestructuraItem(int TipoInfraestructuraId) {

        ArrayList<TipoInfraestructuraEntity> DatoMemoria = new ArrayList<>();
        TipoInfraestructuraEntity en;
        try {

            Inj.Sp("sp_TipoElementoItem");
            Inj.Pmt_Integer("v_TipoElementoId", TipoInfraestructuraId, false);
            ResultSet rs = Inj.RunSelect();
            while (rs.next()) {

                en = new TipoInfraestructuraEntity();
                en.setTipoInfraestructuraId(rs.getInt("TipoInfraestructuraId"));
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
