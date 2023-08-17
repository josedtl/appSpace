package Business;

import DataLayer.UnidadMedidaDB;
import EntityLayer.UnidadMedidaEntity;
import java.util.ArrayList;

public class UnidadMedida {

    public ArrayList<UnidadMedidaEntity> GetAllItems() {
        UnidadMedidaDB BD = new UnidadMedidaDB();
        return BD.GetAllItems();
    }

    public ArrayList<UnidadMedidaEntity> GetAllItem(int Id) {
        UnidadMedidaDB BD = new UnidadMedidaDB();
        return BD.GetAllItem(Id);
    }

    public UnidadMedidaEntity Save(UnidadMedidaEntity Item) {
        UnidadMedidaDB BD = new UnidadMedidaDB();
        return BD.Save(Item);
    }

    public Boolean Delete(int Id) {
        UnidadMedidaDB BD = new UnidadMedidaDB();
        return BD.Delete(Id);
    }
}
