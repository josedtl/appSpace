
package com.api.server;

import Business.Infraestructura;
import EntityLayer.InfraestructuraEntity;
import java.util.ArrayList;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.bind.annotation.RequestMapping;

/**
 *
 * @author RUTH
 */
@RestController
@RequestMapping("/api/Infraestructura")
public class InfraestructuraController {

//http://localhost:8080/api/TipoElemento/GetTipoElementoItems
//    @CrossOrigin(origins = "http://localhost:4200/")
    @GetMapping("/GetInfraestructuraItems")
    public ArrayList<InfraestructuraEntity> GetInfraestructuraItems() {

        Infraestructura BS = new Infraestructura();
        return BS.GetInfraestructuraItems();

    }

    @GetMapping("/GetInfraestructuraItem/{InfraestructuraId}")
    public ArrayList<InfraestructuraEntity> GetInfraestructuraItem(@PathVariable int InfraestructuraId) {

        Infraestructura BS = new Infraestructura();
        return BS.GetInfraestructuraItem(InfraestructuraId);

    }

    @PostMapping("/Save")
    public Boolean Save(@RequestBody InfraestructuraEntity Ent) {

        Infraestructura BS = new Infraestructura();
        return BS.Save(Ent);

    }

    @DeleteMapping("Delete/{Id}")
    public Boolean deteteUser(@PathVariable int Id) {

        Infraestructura BS = new Infraestructura();
        return BS.Delete(Id);
    }   
}
