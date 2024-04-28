package Business;

import java.util.ArrayList;

import DataLayer.GeneralDB;
import EntityLayer.EntidadEntity;

public class General {
    
     public ArrayList<EntidadEntity> GetEntidadBuscarItem(String NombreCompleto) {
        try {
            GeneralDB BD = new GeneralDB();
            return BD.GetEntidadBuscarItem(NombreCompleto);
        } catch (Exception ex) {
            System.out.println("ERROR " + ex);
            throw new UnsupportedOperationException("MENSAJE :" + ex);
        }
    }
}
