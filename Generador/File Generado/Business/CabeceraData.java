package Business;

import DataLayer.CabeceraDataDB;
import EntityLayer.CabeceraDataEntity;
import java.util.ArrayList;

public class CabeceraData {

    public ArrayList<CabeceraDataEntity> GetAllItems() {
        CabeceraDataDB BD = new CabeceraDataDB();
        return BD.GetAllItems();
    }

    public ArrayList<CabeceraDataEntity> GetAllItem(int Id) {
        CabeceraDataDB BD = new CabeceraDataDB();
        return BD.GetAllItem(Id);
    }

    public CabeceraDataEntity Save(CabeceraDataEntity Item) {
        CabeceraDataDB BD = new CabeceraDataDB();
        return BD.Save(Item);
    }

    public Boolean Delete(int Id) {
        CabeceraDataDB BD = new CabeceraDataDB();
        return BD.Delete(Id);
    }
}
