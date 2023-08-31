package Business;

import DataLayer.PersonaNaturalMedioComunicacionDB;
import EntityLayer.PersonaNaturalMedioComunicacionEntity;
import java.util.ArrayList;

public class PersonaNaturalMedioComunicacion {

    public ArrayList<PersonaNaturalMedioComunicacionEntity> GetAllItems() {
        PersonaNaturalMedioComunicacionDB BD = new PersonaNaturalMedioComunicacionDB();
        return BD.GetAllItems();
    }

    public ArrayList<PersonaNaturalMedioComunicacionEntity> GetAllItem(int Id) {
        PersonaNaturalMedioComunicacionDB BD = new PersonaNaturalMedioComunicacionDB();
        return BD.GetAllItem(Id);
    }

    public PersonaNaturalMedioComunicacionEntity Save(PersonaNaturalMedioComunicacionEntity Item) {
        PersonaNaturalMedioComunicacionDB BD = new PersonaNaturalMedioComunicacionDB();
        return BD.Save(Item);
    }

    public Boolean Delete(int Id) {
        PersonaNaturalMedioComunicacionDB BD = new PersonaNaturalMedioComunicacionDB();
        return BD.Delete(Id);
    }
}
