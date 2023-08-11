/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Business;

import DataLayer.*;
import EntityLayer.*;
import java.util.ArrayList;

/**
 *
 * @author DAVID
 */
public class TipoInfraestructura {
    
    public ArrayList<TipoInfraestructuraEntity> GetTipoInfraestructuraItems() {
        
        TipoInfraestructuraDB BD = new TipoInfraestructuraDB();
        return BD.GetTipoInfraestructuraItems();
        
    }
    
       public ArrayList<TipoInfraestructuraEntity> GetTipoInfraestructuraItem(int TipoInfraestructuraId) {
        
        TipoInfraestructuraDB BD = new TipoInfraestructuraDB();
        return BD.GetTipoInfraestructuraItem(TipoInfraestructuraId);
        
    }
              
    public Boolean Save(TipoInfraestructuraEntity Item) {

        TipoInfraestructuraDB BD = new TipoInfraestructuraDB();
        return BD.Save(Item);

    }
}
