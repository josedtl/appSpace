package com.api.server;

import Business.*;
import EntityLayer.*;
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
 * @author DAVID
 */
@RestController
@RequestMapping("/api/TipoInfraestructura")
public class TipoInfraestructuraController {
    
    @GetMapping("/GetTipoInfraestructuraItems")
    public ArrayList<TipoInfraestructuraEntity> GetTipoInfraestructuraItems() {

        TipoInfraestructura BS = new TipoInfraestructura();
        return BS.GetTipoInfraestructuraItems();

    }
    
 @GetMapping("/GetTipoInfraestructuraItem/{TipoInfraestructuraId}")
    public ArrayList<TipoInfraestructuraEntity> GetTipoInfraestructuraItem(@PathVariable int TipoInfraestructuraId) {

        TipoInfraestructura BS = new TipoInfraestructura();
        return BS.GetTipoInfraestructuraItem(TipoInfraestructuraId);

    }
    @PostMapping("/Save")
    public Boolean Save(@RequestBody TipoInfraestructuraEntity Ent) {

        TipoInfraestructura BS = new TipoInfraestructura();
        return BS.Save(Ent);

    }
    @DeleteMapping("Delete/{Id}")
    public Boolean deteteUser(@PathVariable int Id) {

        TipoInfraestructura BS = new TipoInfraestructura();
        return BS.Delete(Id);
    }

}
