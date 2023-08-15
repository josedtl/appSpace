package Business;

import DataLayer.personanaturalDB;
import EntityLayer.personanaturalEntity;
import java.util.ArrayList;

/**
 *
 * @author RUTH
 */
public class personanatural {
    
     public ArrayList<personanaturalEntity> GetpersonanaturalItems() {

        personanaturalDB BD = new personanaturalDB();
        return BD.GetpersonanaturalItems();

    }
}
