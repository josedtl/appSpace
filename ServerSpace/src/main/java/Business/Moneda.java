package Business;

import DataLayer.MonedaDB;
import EntityLayer.MonedaEntity;
import Framework.Inj;
import java.util.ArrayList;

public class Moneda {
    
    
    public ArrayList<MonedaEntity> ObtenerMonedaItems() {
        try {
            MonedaDB BD = new MonedaDB();
            return BD.ObtenerMonedaItems();
        } catch (Exception ex) {
            System.out.println("ERROR " + ex);
            throw new UnsupportedOperationException("MENSAJE :" + ex);
        }
    }

    public ArrayList<MonedaEntity> ObtenerMonedaItem(int Id) {
        try {
            MonedaDB BD = new MonedaDB();
            return BD.ObtenerMonedaItem(Id);
        } catch (Exception ex) {
            System.out.println("ERROR " + ex);
            throw new UnsupportedOperationException("MENSAJE :" + ex);
        }
    }

}
