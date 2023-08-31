
package Business.MyCode;

import DataLayer.PersonaNaturalDB;
import EntityLayer.PersonaNaturalEntity;
import java.util.ArrayList;

public class PersonaNatural {
  
     public ArrayList<PersonaNaturalEntity> GetPersonaNaturalMainItems() {
        PersonaNaturalDB BD = new PersonaNaturalDB();
        return BD.GetPersonaNaturalMainItems();
    }
}
