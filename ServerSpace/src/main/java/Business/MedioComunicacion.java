package Business;

import DataLayer.MedioComunicacionDB;
import EntityLayer.MedioComunicacionEntity;
import java.util.ArrayList;

public class MedioComunicacion {

    public ArrayList<MedioComunicacionEntity> GetAllItems() {
        MedioComunicacionDB BD = new MedioComunicacionDB();
        return BD.GetAllItems();
    }

    public ArrayList<MedioComunicacionEntity> GetAllItem(int Id) {
        MedioComunicacionDB BD = new MedioComunicacionDB();
        return BD.GetAllItem(Id);
    }

    public MedioComunicacionEntity Save(MedioComunicacionEntity Item) {
        MedioComunicacionDB BD = new MedioComunicacionDB();
        return BD.Save(Item);
    }

    public Boolean Delete(int Id) {
        MedioComunicacionDB BD = new MedioComunicacionDB();
        return BD.Delete(Id);
    }
}
