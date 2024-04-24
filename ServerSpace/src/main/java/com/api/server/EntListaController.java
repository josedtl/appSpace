package com.api.server;

import Business.EntLista;
import EntityLayer.EntListaEntity;
import Framework.Utilidades;
import Models.ResponseAPI;
import Models.EntLista.EntListaModel;
import Models.PersonaNatural.PersonaNaturalSaveModel;

import java.util.ArrayList;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.bind.annotation.RequestMapping;

@RestController
@RequestMapping("/api/EntLista")
public class EntListaController extends Configuracion {

    @GetMapping("/ObtenerItemsCodigo/{codigo}")
    public ResponseAPI<ArrayList<EntListaModel>> ObtenerItemsCodigo(@PathVariable String codigo) {
        DataConfi();
        EntLista BS = new EntLista();
        ArrayList<EntListaModel> Items = new ArrayList<>();
        ArrayList<EntListaEntity> Data = BS.ObtenerCodigo(codigo);

        for (EntListaEntity Item : Data) {
            Items.add(new EntListaModel(Item));
        }

        return new ResponseAPI<ArrayList<EntListaModel>>(Items, true, "");
    }

}
