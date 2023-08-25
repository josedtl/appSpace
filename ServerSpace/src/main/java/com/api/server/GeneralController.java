/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/springframework/RestController.java to edit this template
 */
package com.api.server;

import Business.Cargo;
import Business.Piso;
import EntityLayer.CargoEntity;
import EntityLayer.PisoEntity;
import Models.CargoItemModel;
import Models.PisoItemModel;
import java.util.ArrayList;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.bind.annotation.RequestMapping;

/**
 *
 * @author DAVID
 */
@RestController
@RequestMapping("/api/General")
public class GeneralController {

    @GetMapping("/GetPisoItems")
    public ArrayList<PisoItemModel> GetPisoItems() {

        ArrayList<PisoItemModel> Items = new ArrayList<>();
        Piso BS = new Piso();

        ArrayList<PisoEntity> Data = BS.GetAllItems();

        for (PisoEntity Item : Data) {
            PisoItemModel ItemParametro = new PisoItemModel(Item);
            Items.add(ItemParametro);
//            Items.add(new PisoItemModel(Item));
        }

        return Items;
    }

    @GetMapping("/GetCargoItems")
    public ArrayList<CargoItemModel> GetCargoItems() {
        ArrayList<CargoItemModel> Items = new ArrayList<>();
        Cargo BS = new Cargo();

        ArrayList<CargoEntity> Data = BS.GetAllItems();

        for (CargoEntity Item : Data) {
            Items.add(new CargoItemModel(Item));
        }

        return Items;
    }

    @GetMapping("/GetCargoItem/{Id}")
    public ArrayList<CargoItemModel> GetCargoItem(@PathVariable int Id) {
        ArrayList<CargoItemModel> Items = new ArrayList<>();
        Cargo BS = new Cargo();
        ArrayList<CargoEntity> Data = BS.GetAllItem(Id);

        for (CargoEntity Item : Data) {
            Items.add(new CargoItemModel(Item));
        }

        return Items;
    }

    @GetMapping("/GetCargoLikeItem/{Nombre}")
    public ArrayList<CargoItemModel> GetCargoLikeItem(@PathVariable String Nombre) {
        ArrayList<CargoItemModel> Items = new ArrayList<>();
        Cargo BS = new Cargo();
        ArrayList<CargoEntity> Data = BS.GetCargoLikeItem(Nombre);

        for (CargoEntity Item : Data) {
            Items.add(new CargoItemModel(Item));
        }

        return Items;
    }
}
