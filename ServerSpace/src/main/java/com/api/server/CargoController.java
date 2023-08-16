package com.api.server;

import Business.Cargo;
import EntityLayer.CargoEntity;
import java.util.ArrayList;
import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.bind.annotation.RequestMapping;

/**
 *
 * @author DAVID
 */
@RestController
@RequestMapping("/api/Cargo")
public class CargoController {

    @GetMapping("/GetCargoItems")
    public ArrayList<CargoEntity> GetCargoItems() {

        Cargo BS = new Cargo();
        return BS.GetCargoItems();

    }

    @GetMapping("/GetCargoItem/{CargoId}")
    public ArrayList<CargoEntity> GetCargoItem(@PathVariable int CargoId) {

        Cargo BS = new Cargo();
        return BS.GetCargoItem(CargoId);

    }

    @PostMapping("/Save")
    public CargoEntity Save(@RequestBody CargoEntity Ent) {

        Cargo BS = new Cargo();
        BS.Save(Ent);
        return Ent;

    }

    @DeleteMapping("Delete/{Id}")
    public Boolean deteteUser(@PathVariable int Id) {

        Cargo BS = new Cargo();
        return BS.Delete(Id);
    }

}
