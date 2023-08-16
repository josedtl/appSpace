/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Business;

import DataLayer.CargoDB;
import EntityLayer.CargoEntity;
import java.util.ArrayList;

/**
 *
 * @author DAVID
 */
public class Cargo {

    public ArrayList<CargoEntity> GetCargoItems() {

        CargoDB BD = new CargoDB();
        return BD.GetCargoItems();

    }

    public ArrayList<CargoEntity> GetCargoItem(int CargoId) {

        CargoDB BD = new CargoDB();
        return BD.GetCargoItem(CargoId);

    }

    public Boolean Save(CargoEntity Ent) {

        CargoDB BD = new CargoDB();
        return BD.Save(Ent);

    }

    public Boolean Delete(int Id) {

        CargoDB BD = new CargoDB();
        return BD.Delete(Id);

    }
}
