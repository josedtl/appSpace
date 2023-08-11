/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/springframework/RestController.java to edit this template
 */
package com.api.server;

import Business.*;
import EntityLayer.*;
import java.util.ArrayList;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.bind.annotation.RequestMapping;

/**
 *
 * @author DAVID
 */
@RestController
@RequestMapping("/url")
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
   
}
