package Business;

import DataLayer.DepartamentoDB;
import EntityLayer.DepartamentoEntity;
import java.util.ArrayList;

public class Departamento {

    public ArrayList<DepartamentoEntity> GetAllItems() {
        DepartamentoDB BD = new DepartamentoDB();
        return BD.GetAllItems();
    }

    public ArrayList<DepartamentoEntity> GetAllItem(int Id) {
        DepartamentoDB BD = new DepartamentoDB();
        return BD.GetAllItem(Id);
    }

    public DepartamentoEntity Save(DepartamentoEntity Item) {
        DepartamentoDB BD = new DepartamentoDB();
        return BD.Save(Item);
    }

    public Boolean Delete(int Id) {
        DepartamentoDB BD = new DepartamentoDB();
        return BD.Delete(Id);
    }
}
