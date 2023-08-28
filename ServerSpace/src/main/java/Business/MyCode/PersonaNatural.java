/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Business.MyCode;

import DataLayer.PersonaNaturalDB;
import EntityLayer.PersonaNaturalEntity;
import java.util.ArrayList;

/**
 *
 * @author DAVID
 */
public class PersonaNatural {
  
     public ArrayList<PersonaNaturalEntity> GetPersonaNaturalMainItems() {
        PersonaNaturalDB BD = new PersonaNaturalDB();
        return BD.GetPersonaNaturalMainItems();
    }
}
