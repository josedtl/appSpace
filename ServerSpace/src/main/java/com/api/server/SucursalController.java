package com.api.server;

import Business.Sucursal;
import EntityLayer.SucursalEntity;
import java.util.ArrayList;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.bind.annotation.RequestMapping;

@RestController
@RequestMapping("/api/Sucursal")
public class SucursalController {

    @GetMapping("/GetAllItems")
    public ArrayList<SucursalEntity> GetAllItems() {
        Sucursal BS = new Sucursal();
        return BS.GetAllItems();
    }

    @GetMapping("/GetAllItem/{Id}")
    public ArrayList<SucursalEntity> GetAllItem(@PathVariable int Id) {
        Sucursal BS = new Sucursal();
        return BS.GetAllItem(Id);
    }

    @PostMapping("/Save")
    public SucursalEntity Save(@RequestBody SucursalEntity Ent) {
        Sucursal BS = new Sucursal();
        BS.Save(Ent);
        return Ent;
    }

    @DeleteMapping("/Delete/{Id}")
    public Boolean Delete(@PathVariable int Id) {
        Sucursal BS = new Sucursal();
        return BS.Delete(Id);
    }
}
