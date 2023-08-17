package com.api.server;

import Business.Area;
import EntityLayer.AreaEntity;
import java.util.ArrayList;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.bind.annotation.RequestMapping;

@RestController
@RequestMapping("/api/Area")
public class AreaController {

    @GetMapping("/GetAllItems")
    public ArrayList<AreaEntity> GetAllItems() {
        Area BS = new Area();
        return BS.GetAllItems();
    }

    @GetMapping("/GetAllItem/{Id}")
    public ArrayList<AreaEntity> GetAllItem(@PathVariable int Id) {
        Area BS = new Area();
        return BS.GetAllItem(Id);
    }

    @PostMapping("/Save")
    public AreaEntity Save(@RequestBody AreaEntity Ent) {
        Area BS = new Area();
        BS.Save(Ent);
        return Ent;
    }

    @DeleteMapping("/Delete/{Id}")
    public Boolean Delete(@PathVariable int Id) {
        Area BS = new Area();
        return BS.Delete(Id);
    }
}
