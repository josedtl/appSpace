package Business;

import DataLayer.PersonaNaturalDB;
import EntityLayer.PersonaNaturalEntity;
import Framework.Inj;
import java.util.ArrayList;

public class PersonaNatural {

    public ArrayList<PersonaNaturalEntity> ObtenerMain() {
        try {
            PersonaNaturalDB BD = new PersonaNaturalDB();
            return BD.ObtenerMain();
        } catch (Exception ex) {
            System.out.println("ERROR " + ex);
            throw new UnsupportedOperationException("MENSAJE :" + ex);
        }
    }

    public ArrayList<PersonaNaturalEntity> ObtenerItem(int Id) {
        try {
            PersonaNaturalDB BD = new PersonaNaturalDB();
            return BD.ObtenerItem(Id);
        } catch (Exception ex) {
            System.out.println("ERROR " + ex);
            throw new UnsupportedOperationException("MENSAJE :" + ex);
        }
    }

    public PersonaNaturalEntity Registrar(PersonaNaturalEntity Item) {
        try {
            Inj.IniciarTranssaccion(true);
            PersonaNaturalDB BD = new PersonaNaturalDB();
            BD.Registrar(Item);
            Inj.FinalizarTranssaccion();
            return Item;
        } catch (Exception ex) {
            System.out.println("ERROR " + ex);
            throw new UnsupportedOperationException("MENSAJE :" + ex);
        }
    }

}
