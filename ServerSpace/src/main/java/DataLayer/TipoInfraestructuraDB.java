
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

            Inj.Sp("sp_TipoInfraestructuraItems");
            ResultSet rs = Inj.RunSelect();
            while (rs.next()) {

                en = new TipoInfraestructuraEntity();
                en.setTipoInfraestructuraId(rs.getInt("TipoInfraestructuraId"));
                en.setNombre(rs.getString("Nombre"));
                en.setFechaRegistro(rs.getDate("FechaRegistro"));
                en.setCodUsuario(rs.getString("CodUsuario"));
                en.setEstadoRegistro(rs.getBoolean("EstadoRegistro"));
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

            Inj.Sp("sp_TipoInfraestructuraItem");
            Inj.Pmt_Integer("v_TipoInfraestructuraeId", TipoInfraestructuraId, false);
            ResultSet rs = Inj.RunSelect();
            while (rs.next()) {

        en = new TipoInfraestructuraEntity();
                en.setTipoInfraestructuraId(rs.getInt("TipoInfraestructuraId"));
                en.setNombre(rs.getString("Nombre"));
                en.setFechaRegistro(rs.getDate("FechaRegistro"));
                en.setCodUsuario(rs.getString("CodUsuario"));
                en.setEstadoRegistro(rs.getBoolean("EstadoRegistro"));
                DatoMemoria.add(en);
            }

        } catch (SQLException e) {
            System.out.println("ERROR" + e);
            throw new UnsupportedOperationException("Datalater :" + e);
        }
        return DatoMemoria;
    }
    
    public Boolean Save(TipoInfraestructuraEntity entity) {
        Boolean State = null;
        try {

            if (entity.getTipoInfraestructuraId() == 0) {
                Inj.Sp("sp_TipoInfraestructuraSave");
            } else {
                Inj.Sp("sp_TipoInfraestructuraUpdate");
            }

            Inj.Pmt_Integer("v_TipoInfraestructuraId", entity.getTipoInfraestructuraId(), false);
            Inj.Pmt_String("v_Nombre", entity.getNombre(), false);
            Inj.Pmt_String("v_CodUsuario", entity.getCodUsuario(), false);
            Inj.Pmt_Boolean("v_EstadoRegistro", entity.getEstadoRegistro(), false);
            State = Inj.RunInsert() > 0;

        } catch (Exception ex) {
            throw new UnsupportedOperationException("Datalater :" + ex);
        }
        return State;
    }


}
