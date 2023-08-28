package com.api.server;

import Business.PersonaNatural;
import EntityLayer.PersonaNaturalEntity;
import Models.PersonaNaturalMainModel;
import java.util.ArrayList;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.bind.annotation.RequestMapping;

@RestController
@RequestMapping("/api/PersonaNatural")
public class PersonaNaturalController {

    @GetMapping("/GetAllItems")
    public ArrayList<PersonaNaturalEntity> GetAllItems() {
        PersonaNatural BS = new PersonaNatural();
        return BS.GetAllItems();
    }

    @GetMapping("/GetAllItem/{Id}")
    public ArrayList<PersonaNaturalEntity> GetAllItem(@PathVariable int Id) {
        PersonaNatural BS = new PersonaNatural();
        return BS.GetAllItem(Id);
    }

    @PostMapping("/Save")
    public PersonaNaturalEntity Save(@RequestBody PersonaNaturalEntity Ent) {
        PersonaNatural BS = new PersonaNatural();
        BS.Save(Ent);
        return Ent;
    }

    @DeleteMapping("/Delete/{Id}")
    public Boolean Delete(@PathVariable int Id) {
        PersonaNatural BS = new PersonaNatural();
        return BS.Delete(Id);
    }

    @GetMapping("/GetPersonaNaturalMainItems")
    public ArrayList<PersonaNaturalMainModel> GetPersonaNaturalMainItems() {
        PersonaNatural BS = new PersonaNatural();
        ArrayList<PersonaNaturalMainModel> Items = new ArrayList<>();
        ArrayList<PersonaNaturalEntity> Data = BS.GetPersonaNaturalMainItems();

        for (PersonaNaturalEntity Item : Data) {
            Items.add(new PersonaNaturalMainModel(Item));
        }

        return Items;
    }
}
