package Business;

import DataLayer.UnidadMedidaDB;
import EntityLayer.UnidadMedidaEntity;
import java.util.ArrayList;


public class UnidadMedida {
    
    public ArrayList<UnidadMedidaEntity> GetUnidadMedidaItems() {
        try {
            UnidadMedidaDB BD = new UnidadMedidaDB();
            return BD.GetUnidadMedidaItems();
        } catch (Exception ex) {
            System.out.println("ERROR " + ex);
            throw new UnsupportedOperationException("MENSAJE :" + ex);
        }
    }

    public ArrayList<UnidadMedidaEntity> GetUnidadMedida_Item(int Id) {
        try {
            UnidadMedidaDB BD = new UnidadMedidaDB();
            return BD.GetUnidadMedida_Item(Id);
        } catch (Exception ex) {
            System.out.println("ERROR " + ex);
            throw new UnsupportedOperationException("MENSAJE :" + ex);
        }
    }
}
