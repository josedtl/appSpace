/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Business.MyCode;

import DataLayer.CargoDB;
import EntityLayer.CargoEntity;
import java.util.ArrayList;

/**
 *
 * @author DAVID
 */
public class Cargo {

    public ArrayList<CargoEntity> GetCargoLikeItem(String Nombre) {
        CargoDB BD = new CargoDB();
        return BD.GetCargoLikeItem(Nombre);
    }

}
