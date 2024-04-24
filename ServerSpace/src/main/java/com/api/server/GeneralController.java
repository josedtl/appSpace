package com.api.server;

import Business.*;
import EntityLayer.*;
import Models.*;
import Models.General.MonedaModel;
import Models.General.UnidadMedidaModel;

import java.util.ArrayList;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.bind.annotation.RequestMapping;

@RestController
@RequestMapping("/api/General")
public class GeneralController extends Configuracion {

    @GetMapping("/ObtenerMonedaItems")
    public ResponseAPI<ArrayList<MonedaModel>> ObtenerMonedaItems() {
        DataConfi();
        Moneda BS = new Moneda();
        ArrayList<MonedaModel> Items = new ArrayList<>();
        ArrayList<MonedaEntity> Data = BS.ObtenerMonedaItems();

        for (MonedaEntity Item : Data) {
            Items.add(new MonedaModel(Item));
        }

        return new ResponseAPI<ArrayList<MonedaModel>>(Items, true, "");
    }

    @GetMapping("/ObtenerMonedaItem/{Id}")
    public ResponseAPI<ArrayList<MonedaModel>> ObtenerMonedaItem(@PathVariable int Id) {
        DataConfi();
        Moneda BS = new Moneda();
        ArrayList<MonedaModel> Items = new ArrayList<>();
        ArrayList<MonedaEntity> Data = BS.ObtenerMonedaItem(Id);

        for (MonedaEntity Item : Data) {
            Items.add(new MonedaModel(Item));
        }

        return new ResponseAPI<ArrayList<MonedaModel>>(Items, true, "");
    }

    @GetMapping("/ObtenerUnidadMedidaItems")
    public ResponseAPI<ArrayList<UnidadMedidaModel>> ObtenerUnidadMedidaItems() {
        DataConfi();
        UnidadMedida BS = new UnidadMedida();
        ArrayList<UnidadMedidaModel> Items = new ArrayList<>();
        ArrayList<UnidadMedidaEntity> Data = BS.GetUnidadMedidaItems();

        for (UnidadMedidaEntity Item : Data) {
            Items.add(new UnidadMedidaModel(Item));
        }

        return new ResponseAPI<ArrayList<UnidadMedidaModel>>(Items, true, "");
    }

    @GetMapping("/GetUnidadMedida_Item/{Id}")
    public ResponseAPI<ArrayList<UnidadMedidaModel>> GetUnidadMedida_Item(@PathVariable int Id) {
        DataConfi();
        UnidadMedida BS = new UnidadMedida();
        ArrayList<UnidadMedidaModel> Items = new ArrayList<>();
        ArrayList<UnidadMedidaEntity> Data = BS.GetUnidadMedida_Item(Id);

        for (UnidadMedidaEntity Item : Data) {
            Items.add(new UnidadMedidaModel(Item));
        }

        return new ResponseAPI<ArrayList<UnidadMedidaModel>>(Items, true, "");
    }

    @PostMapping("/BuscarUbigeoItem")
    public ResponseAPI<ArrayList<UbigeoItemModel>> GetUbigeoLikeItem(@RequestBody ItemLikeModel ItemLike) {
        ArrayList<UbigeoItemModel> Items = new ArrayList<>();
        Ubigeo BS = new Ubigeo();
        ArrayList<UbigeoEntity> Data = BS.GetUbigeoBuscarLike(ItemLike.getSrtValor1());

        for (UbigeoEntity Item : Data) {
            Items.add(new UbigeoItemModel(Item));
        }

        return new ResponseAPI<ArrayList<UbigeoItemModel>>(Items, true, "");
    }

    @GetMapping("/ObtenerUbigeoItem/{UbigeoId}")
    public ResponseAPI<ArrayList<UbigeoItemModel>> ObtenerUbigeoItem(@PathVariable int UbigeoId) {
        ArrayList<UbigeoItemModel> Items = new ArrayList<>();
        Ubigeo BS = new Ubigeo();
        ArrayList<UbigeoEntity> Data = BS.GetUbigeoItem(UbigeoId);

        for (UbigeoEntity Item : Data) {
            Items.add(new UbigeoItemModel(Item));
        }

        return new ResponseAPI<ArrayList<UbigeoItemModel>>(Items, true, "");
    }

}
