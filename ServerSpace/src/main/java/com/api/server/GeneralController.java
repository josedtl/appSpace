/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/springframework/RestController.java to edit this template
 */
package com.api.server;

import Business.Piso;
import EntityLayer.PisoEntity;
import Models.PisoItemModel;
import java.util.ArrayList;
import org.springframework.web.bind.annotation.GetMapping;
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
            Items.add(new PisoItemModel(Item));
        }

        return Items;
    }

    
    
}
