package Business;

import DataLayer.CargoDB;
import EntityLayer.CargoEntity;
import java.util.ArrayList;

public class Cargo {

    public ArrayList<CargoEntity> GetAllItems() {
        CargoDB BD = new CargoDB();
        return BD.GetAllItems();
    }

    public ArrayList<CargoEntity> GetAllItem(int Id) {
        CargoDB BD = new CargoDB();
        return BD.GetAllItem(Id);
    }

    public CargoEntity Save(CargoEntity Item) {
        CargoDB BD = new CargoDB();
        return BD.Save(Item);
    }

    public Boolean Delete(int Id) {
        CargoDB BD = new CargoDB();
        return BD.Delete(Id);
    }
}
