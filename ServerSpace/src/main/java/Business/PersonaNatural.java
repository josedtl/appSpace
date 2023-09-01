package Business;

import DataLayer.PersonaNaturalDB;
import EntityLayer.PersonaNaturalEntity;
import Framework.Inj;
import java.sql.SQLException;
import java.util.ArrayList;

public class PersonaNatural extends Business.MyCode.PersonaNatural {

    public ArrayList<PersonaNaturalEntity> GetAllItems() {
        PersonaNaturalDB BD = new PersonaNaturalDB();
        try {
            Inj.IniciarTranssaccionConsulta();

        } catch (Exception ex) {
            System.out.println("ERROR " + ex);
            throw new UnsupportedOperationException("MENSAJE :" + ex);
        }
        return BD.GetAllItems();
    }

    public ArrayList<PersonaNaturalEntity> GetAllItem(int Id) {
        PersonaNaturalDB BD = new PersonaNaturalDB();
        return BD.GetAllItem(Id);
    }

    public PersonaNaturalEntity Save(PersonaNaturalEntity Item) {
        try {
            Inj.IniciarTranssaccion(true);
            PersonaNaturalDB BD = new PersonaNaturalDB();
            BD.Save(Item);
            Inj.FinalizarTranssaccion();
        } catch (Exception ex) {
            System.out.println("ERROR " + ex);
            throw new UnsupportedOperationException("MENSAJE :" + ex);
        }
        return Item;

    }

    public Boolean Delete(int Id) {
        PersonaNaturalDB BD = new PersonaNaturalDB();
        return BD.Delete(Id);
    }
}
