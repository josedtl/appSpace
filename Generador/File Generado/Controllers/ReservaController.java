package com.api.server;

import Business.Reserva;
import EntityLayer.ReservaEntity;
import java.util.ArrayList;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.bind.annotation.RequestMapping;

@RestController
@RequestMapping("/api/Reserva")
public class ReservaController {

    @GetMapping("/GetAllItems")
    public ArrayList<ReservaEntity> GetAllItems() {
        Reserva BS = new Reserva();
        return BS.GetAllItems();
    }

    @GetMapping("/GetAllItem/{Id}")
    public ArrayList<ReservaEntity> GetAllItem(@PathVariable int Id) {
        Reserva BS = new Reserva();
        return BS.GetAllItem(Id);
    }

    @PostMapping("/Save")
    public ReservaEntity Save(@RequestBody ReservaEntity Ent) {
        Reserva BS = new Reserva();
        BS.Save(Ent);
        return Ent;
    }

    @DeleteMapping("/Delete/{Id}")
    public Boolean Delete(@PathVariable int Id) {
        Reserva BS = new Reserva();
        return BS.Delete(Id);
    }
}
