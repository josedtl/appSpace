package Business;

import DataLayer.ProductoDB;
import EntityLayer.ProductoEntity;
import java.util.ArrayList;

public class Producto {

    public ArrayList<ProductoEntity> GetAllItems() {
        ProductoDB BD = new ProductoDB();
        return BD.GetAllItems();
    }

    public ArrayList<ProductoEntity> GetAllItem(int Id) {
        ProductoDB BD = new ProductoDB();
        return BD.GetAllItem(Id);
    }

    public ProductoEntity Save(ProductoEntity Item) {
        ProductoDB BD = new ProductoDB();
        return BD.Save(Item);
    }

    public Boolean Delete(int Id) {
        ProductoDB BD = new ProductoDB();
        return BD.Delete(Id);
    }
}
