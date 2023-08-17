package com.api.server;

import Business.Departamento;
import EntityLayer.DepartamentoEntity;
import java.util.ArrayList;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.bind.annotation.RequestMapping;

@RestController
@RequestMapping("/api/Departamento")
public class DepartamentoController {

    @GetMapping("/GetAllItems")
    public ArrayList<DepartamentoEntity> GetAllItems() {
        Departamento BS = new Departamento();
        return BS.GetAllItems();
    }

    @GetMapping("/GetAllItem/{Id}")
    public ArrayList<DepartamentoEntity> GetAllItem(@PathVariable int Id) {
        Departamento BS = new Departamento();
        return BS.GetAllItem(Id);
    }

    @PostMapping("/Save")
    public DepartamentoEntity Save(@RequestBody DepartamentoEntity Ent) {
        Departamento BS = new Departamento();
        BS.Save(Ent);
        return Ent;
    }

    @DeleteMapping("/Delete/{Id}")
    public Boolean Delete(@PathVariable int Id) {
        Departamento BS = new Departamento();
        return BS.Delete(Id);
    }
}
