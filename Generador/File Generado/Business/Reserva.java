package Business;

import DataLayer.ReservaDB;
import EntityLayer.ReservaEntity;
import java.util.ArrayList;

public class Reserva {

    public ArrayList<ReservaEntity> GetAllItems() {
        ReservaDB BD = new ReservaDB();
        return BD.GetAllItems();
    }

    public ArrayList<ReservaEntity> GetAllItem(int Id) {
        ReservaDB BD = new ReservaDB();
        return BD.GetAllItem(Id);
    }

    public ReservaEntity Save(ReservaEntity Item) {
        ReservaDB BD = new ReservaDB();
        return BD.Save(Item);
    }

    public Boolean Delete(int Id) {
        ReservaDB BD = new ReservaDB();
        return BD.Delete(Id);
    }
}
