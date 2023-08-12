/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/springframework/RestController.java to edit this template
 */
package com.api.server;

import Business.TipoElemento;
import EntityLayer.TipoElementoEntity;
import java.util.ArrayList;
import org.springframework.web.bind.annotation.CrossOrigin;
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
@RequestMapping("/api/TipoElemento")
public class TipoElementoController {

//http://localhost:8080/api/TipoElemento/GetTipoElementoItems
//    @CrossOrigin(origins = "http://localhost:4200/")
    @GetMapping("/GetTipoElementoItems")
    public ArrayList<TipoElementoEntity> GetTipoElementoItems() {

        TipoElemento BS = new TipoElemento();
        return BS.GetTipoElementoItems();

    }

    @GetMapping("/GetTipoElementoItem/{TipoElementoId}")
    public ArrayList<TipoElementoEntity> GetTipoElementoItem(@PathVariable int TipoElementoId) {

        TipoElemento BS = new TipoElemento();
        return BS.GetTipoElementoItem(TipoElementoId);

    }

    @PostMapping("/Save")
    public Boolean Save(@RequestBody TipoElementoEntity Ent) {

        TipoElemento BS = new TipoElemento();
        return BS.Save(Ent);

    }

    @DeleteMapping("Delete/{Id}")
    public Boolean deteteUser(@PathVariable int Id) {

        TipoElemento BS = new TipoElemento();
        return BS.Delete(Id);
    }

}
