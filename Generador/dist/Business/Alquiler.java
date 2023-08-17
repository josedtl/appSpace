package Business;

import DataLayer.AlquilerDB;
import EntityLayer.AlquilerEntity;
import java.util.ArrayList;

public class Alquiler {

    public ArrayList<AlquilerEntity> GetAllItems() {
        AlquilerDB BD = new AlquilerDB();
        return BD.GetAllItems();
    }

    public ArrayList<AlquilerEntity> GetAllItem(int Id) {
        AlquilerDB BD = new AlquilerDB();
        return BD.GetAllItem(Id);
    }

    public AlquilerEntity Save(AlquilerEntity Item) {
        AlquilerDB BD = new AlquilerDB();
        return BD.Save(Item);
    }

    public Boolean Delete(int Id) {
        AlquilerDB BD = new AlquilerDB();
        return BD.Delete(Id);
    }
}
