package com.api.server;

import Business.UnidadMedida;
import EntityLayer.UnidadMedidaEntity;
import java.util.ArrayList;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.bind.annotation.RequestMapping;

@RestController
@RequestMapping("/api/UnidadMedida")
public class UnidadMedidaController {

    @GetMapping("/GetAllItems")
    public ArrayList<UnidadMedidaEntity> GetAllItems() {
        UnidadMedida BS = new UnidadMedida();
        return BS.GetAllItems();
    }

    @GetMapping("/GetAllItem/{Id}")
    public ArrayList<UnidadMedidaEntity> GetAllItem(@PathVariable int Id) {
        UnidadMedida BS = new UnidadMedida();
        return BS.GetAllItem(Id);
    }

    @PostMapping("/Save")
    public UnidadMedidaEntity Save(@RequestBody UnidadMedidaEntity Ent) {
        UnidadMedida BS = new UnidadMedida();
        BS.Save(Ent);
        return Ent;
    }

    @DeleteMapping("/Delete/{Id}")
    public Boolean Delete(@PathVariable int Id) {
        UnidadMedida BS = new UnidadMedida();
        return BS.Delete(Id);
    }
}
