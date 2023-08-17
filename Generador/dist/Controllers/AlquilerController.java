package com.api.server;

import Business.Alquiler;
import EntityLayer.AlquilerEntity;
import java.util.ArrayList;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.bind.annotation.RequestMapping;

@RestController
@RequestMapping("/api/Alquiler")
public class AlquilerController {

    @GetMapping("/GetAllItems")
    public ArrayList<AlquilerEntity> GetAllItems() {
        Alquiler BS = new Alquiler();
        return BS.GetAllItems();
    }

    @GetMapping("/GetAllItem/{Id}")
    public ArrayList<AlquilerEntity> GetAllItem(@PathVariable int Id) {
        Alquiler BS = new Alquiler();
        return BS.GetAllItem(Id);
    }

    @PostMapping("/Save")
    public AlquilerEntity Save(@RequestBody AlquilerEntity Ent) {
        Alquiler BS = new Alquiler();
        BS.Save(Ent);
        return Ent;
    }

    @DeleteMapping("/Delete/{Id}")
    public Boolean Delete(@PathVariable int Id) {
        Alquiler BS = new Alquiler();
        return BS.Delete(Id);
    }
}
