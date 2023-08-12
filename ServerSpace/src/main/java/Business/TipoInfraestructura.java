
package Business;


import DataLayer.TipoInfraestructuraDB;
import EntityLayer.TipoInfraestructuraEntity;
import java.util.ArrayList;

/**
 *
 * @author DAVID
 */
public class TipoInfraestructura {
    
    public ArrayList<TipoInfraestructuraEntity> GetTipoInfraestructuraItems() {
        
        TipoInfraestructuraDB BD = new TipoInfraestructuraDB();
        return BD.GetTipoInfraestructuraItems();
        
    }
    
       public ArrayList<TipoInfraestructuraEntity> GetTipoInfraestructuraItem(int TipoInfraestructuraId) {
        
        TipoInfraestructuraDB BD = new TipoInfraestructuraDB();
        return BD.GetTipoInfraestructuraItem(TipoInfraestructuraId);
        
    }
              
    public Boolean Save(TipoInfraestructuraEntity Ent) {

        TipoInfraestructuraDB BD = new TipoInfraestructuraDB();
        return BD.Save(Ent);

    }
}
