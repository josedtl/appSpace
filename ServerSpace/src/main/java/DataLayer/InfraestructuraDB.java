
package DataLayer;

import EntityLayer.InfraestructuraEntity;
import Framework.injector;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;

/**
 *
 * @author RUTH
 */
public class InfraestructuraDB {
    injector Inj = new injector();
    
      public ArrayList<InfraestructuraEntity> GetInfraestructuraItems() {

        ArrayList<InfraestructuraEntity> DatoMemoria = new ArrayList<>();
        InfraestructuraEntity en;
        try {

            Inj.Sp("sp_TipoElementoItems");
            ResultSet rs = Inj.RunSelect();
            while (rs.next()) {

                en = new InfraestructuraEntity();
                en.setInfraestructuraId(rs.getInt("InfraestructuraId"));
                en.setTipoInfraestructuraId(rs.getInt("TipoInfraestructuraId"));
                en.setEstado(rs.getString("Estado"));
                en.setCodigo(rs.getString("Codigo"));
                en.setDescripcion(rs.getString("setDescripcion"));
                en.setAncho(rs.getDouble("Ancho"));
                en.setLargo(rs.getString("Largo"));
                en.setAltura(rs.getString("Altura"));
                en.setNivel(rs.getString("Nivel"));
                en.setAforo(rs.getInt("Aforo"));
                DatoMemoria.add(en);

            }

        } catch (SQLException e) {
            System.out.println("ERROR" + e);
            throw new UnsupportedOperationException("Datalater :" + e);
        }
        return DatoMemoria;
    }
    
    public ArrayList<InfraestructuraEntity> GetInfraestructuraItem(int InfraestructuraId) {

        ArrayList<InfraestructuraEntity> DatoMemoria = new ArrayList<>();
        InfraestructuraEntity en;
        try {

            Inj.Sp("sp_InfraestructuraItem");
            Inj.Pmt_Integer("v_InfraestructuraId", InfraestructuraId, false);
            ResultSet rs = Inj.RunSelect();
            while (rs.next()) {

                en = new InfraestructuraEntity();
                en.setInfraestructuraId(rs.getInt("InfraestructuraId"));
                en.setTipoInfraestructuraId(rs.getInt("TipoInfraestructuraId"));
                en.setEstado(rs.getString("Estado"));
                en.setCodigo(rs.getString("Codigo"));
                en.setDescripcion(rs.getString("setDescripcion"));
                en.setAncho(rs.getDouble("Ancho"));
                en.setLargo(rs.getString("Largo"));
                en.setAltura(rs.getString("Altura"));
                en.setNivel(rs.getString("Nivel"));
                en.setAforo(rs.getInt("Aforo"));
                DatoMemoria.add(en);

            }

        } catch (SQLException e) {
            System.out.println("ERROR" + e);
            throw new UnsupportedOperationException("Datalater :" + e);
        }
        return DatoMemoria;
    }
    
    
    public Boolean Save(InfraestructuraEntity entity) {
        Boolean State = null;
        try {

            if (entity.getInfraestructuraId() == 0) {
                Inj.Sp("sp_InfraestructuraSave");
            } else {
                Inj.Sp("sp_InfraestructuraUpdate");
            }
            Inj.Pmt_Integer("v_InfraestructuraId", entity.getInfraestructuraId(), false);
            Inj.Pmt_Integer("v_TipoInfraestructuraId", entity.getTipoInfraestructuraId(), false);
            Inj.Pmt_String("v_Estado", entity.getEstado(), false);
            Inj.Pmt_String("v_Codigo", entity.getCodigo(), false);
            Inj.Pmt_String("v_Descripcion", entity.getDescripcion(), false);
            Inj.Pmt_Double("v_Ancho", entity.getAncho(), false);
            Inj.Pmt_String("v_Largo", entity.getLargo(), false);
            Inj.Pmt_String("v_Altura", entity.getAltura(), false);
            Inj.Pmt_String("v_Nivel", entity.getNivel(), false);
            Inj.Pmt_Integer("v_Aforo", entity.getAforo(), false); 
            State = Inj.RunInsert() > 0;

        } catch (Exception ex) {
            throw new UnsupportedOperationException("Datalater :" + ex);
        }
        return State;
    }
       public Boolean Delete(Integer entity) {
        Boolean State = null;
        Inj.Sp("sp_InfraestructuraDelete");
        Inj.Pmt_Integer("v_InfraestructuraId", entity, false);
        State = Inj.RunDelete() > 0;
        return State;
    }
}
