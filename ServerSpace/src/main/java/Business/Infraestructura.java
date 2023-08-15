
package Business;

import DataLayer.InfraestructuraDB;
import EntityLayer.InfraestructuraEntity;
import java.util.ArrayList;

/**
 *
 * @author RUTH
 */
public class Infraestructura {
 
     public ArrayList<InfraestructuraEntity> GetInfraestructuraItems() {

        InfraestructuraDB BD = new InfraestructuraDB();
        return BD.GetInfraestructuraItems();

    }

    public ArrayList<InfraestructuraEntity> GetInfraestructuraItem(int InfraestructuraId) {

        InfraestructuraDB BD = new InfraestructuraDB();
        return BD.GetInfraestructuraItem(InfraestructuraId);

    }

    public Boolean Save(InfraestructuraEntity Ent) {

        InfraestructuraDB BD = new InfraestructuraDB();
        return BD.Save(Ent);

    }

    public Boolean Delete(int Id) {

        InfraestructuraDB BD = new InfraestructuraDB();
        return BD.Delete(Id);

    }
    
}
