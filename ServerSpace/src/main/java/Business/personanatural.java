package Business;

import DataLayer.PersonaNaturalDB;
import EntityLayer.PersonaNaturalEntity;
import java.util.ArrayList;

public class PersonaNatural {

    public ArrayList<PersonaNaturalEntity> GetAllItems() {

        PersonaNaturalDB BD = new PersonaNaturalDB();
        return BD.GetAllItems();
    }

    public ArrayList<PersonaNaturalEntity> GetAllItem(int Id) {

        PersonaNaturalDB BD = new PersonaNaturalDB();
        return BD.GetAllItem(Id);
    }

    public PersonaNaturalEntity Save(PersonaNaturalEntity Item) {

        PersonaNaturalDB BD = new PersonaNaturalDB();
        return BD.Save(Item);
    }

    public Boolean Delete(int Id) {

        PersonaNaturalDB BD = new PersonaNaturalDB();
        return BD.Delete(Id);
    }
}
