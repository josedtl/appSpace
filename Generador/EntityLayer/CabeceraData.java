package com.api.server;

import Business.CabeceraData;
import EntityLayer.CabeceraDataEntity;
import java.util.ArrayList;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.bind.annotation.RequestMapping;

@RestController
@RequestMapping("/api/CabeceraData")
public class CabeceraDataController {

    @GetMapping("/GetAllItems")
    public ArrayList<CabeceraDataEntity> GetAllItems() {
        CabeceraData BS = new CabeceraData();
        return BS.GetAllItems();
    }

    @GetMapping("/GetAllItem/{Id}")
    public ArrayList<CabeceraDataEntity> GetAllItem(@PathVariable int Id) {
        CabeceraData BS = new CabeceraData();
        return BS.GetAllItem(Id);
    }

    @PostMapping("/Save")
    public CabeceraDataEntity Save(@RequestBody CabeceraDataEntity Ent) {
        CabeceraData BS = new CabeceraData();
        BS.Save(Ent);
        return Ent;
    }

    @DeleteMapping("/Delete/{Id}")
    public Boolean Delete(@PathVariable int Id) {
        CabeceraData BS = new CabeceraData();
        return BS.Delete(Id);
    }
}
