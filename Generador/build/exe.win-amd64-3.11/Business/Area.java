package Business;

import DataLayer.AreaDB;
import EntityLayer.AreaEntity;
import java.util.ArrayList;

public class Area {

    public ArrayList<AreaEntity> GetAllItems() {
        AreaDB BD = new AreaDB();
        return BD.GetAllItems();
    }

    public ArrayList<AreaEntity> GetAllItem(int Id) {
        AreaDB BD = new AreaDB();
        return BD.GetAllItem(Id);
    }

    public AreaEntity Save(AreaEntity Item) {
        AreaDB BD = new AreaDB();
        return BD.Save(Item);
    }

    public Boolean Delete(int Id) {
        AreaDB BD = new AreaDB();
        return BD.Delete(Id);
    }
}
