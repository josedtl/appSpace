package Business;

import DataLayer.UbigeoDB;
import EntityLayer.UbigeoEntity;
import Framework.Inj;
import java.util.ArrayList;

public class Ubigeo {

 
    public ArrayList<UbigeoEntity> GetUbigeoBuscarLike(String Nombre) {
        try {
            UbigeoDB BD = new UbigeoDB();
            return BD.GetUbigeoLikeItem(Nombre);
        } catch (Exception ex) {
            System.out.println("ERROR " + ex);
            throw new UnsupportedOperationException("MENSAJE :" + ex);
        }
    }

    public ArrayList<UbigeoEntity> GetUbigeoItem(int Id) {
        try {
            UbigeoDB BD = new UbigeoDB();
            return BD.GetAllItem(Id);
        } catch (Exception ex) {
            System.out.println("ERROR " + ex);
            throw new UnsupportedOperationException("MENSAJE :" + ex);
        }
    }


}
