/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Business;

import DataLayer.TipoElementoDB;
import EntityLayer.TipoElementoEntity;
import java.util.ArrayList;

/**
 *
 * @author DAVID
 */
public class TipoElemento {

    public ArrayList<TipoElementoEntity> GetTipoElementoItems() {
        
        TipoElementoDB BD = new TipoElementoDB();
        return BD.GetTipoElementoItems();
        
    }
    
       public ArrayList<TipoElementoEntity> GetTipoElementoItem(int TipoElementoId) {
        
        TipoElementoDB BD = new TipoElementoDB();
        return BD.GetTipoElementoItem(TipoElementoId);
        
    }
}
