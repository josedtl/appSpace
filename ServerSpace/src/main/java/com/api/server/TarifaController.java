package com.api.server;

import Framework.Utilidades;
import Business.General;
import Business.Tarifa;
import EntityLayer.EntidadEntity;
import EntityLayer.TarifaEntity;
import Models.ItemLikeModel;
import Models.ResponseAPI;
import Models.General.EntidadModel;
import Models.Tarifa.TarifaBuscarItem;
import Models.Tarifa.TarifaBuscarRecursoModel;
import Models.Tarifa.TarifaMainModel;
import Models.Tarifa.TarifaSaveModel;

import java.util.ArrayList;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.bind.annotation.RequestMapping;

@RestController
@RequestMapping("/api/Tarifa")
public class TarifaController extends Configuracion {

    @GetMapping("/ObtenerMain")
    public ResponseAPI<ArrayList<TarifaMainModel>> ObtenerMain() {
        DataConfi();
        Tarifa BS = new Tarifa();
        ArrayList<TarifaMainModel> Items = new ArrayList<>();
        ArrayList<TarifaEntity> Data = BS.ObtenerMain();

        for (TarifaEntity Item : Data) {
            Items.add(new TarifaMainModel(Item));
        }

        return new ResponseAPI<ArrayList<TarifaMainModel>>(Items, true, "");
    }

    @PostMapping("/Registrar")
    public ResponseAPI<TarifaSaveModel> Registrar(@RequestBody TarifaSaveModel ItemModel) {
        DataConfi();
        Tarifa BS = new Tarifa();
        TarifaEntity Ent = new TarifaEntity();

        Ent.setTarifaId(ItemModel.getTarifaId());
        Ent.setObjetoReferenciaId(ItemModel.getObjetoReferenciaId());
        Ent.setCorrelativo(ItemModel.getCorrelativo());
        Ent.setMonedaId(ItemModel.getMonedaId());
        Ent.setTipoTarifaEnum(ItemModel.getTipoTarifaEnum());
        Ent.setUnidadMedidaId(ItemModel.getUnidadMedidaId());
        Ent.setCostoTarifa(ItemModel.getCostoTarifa());
        Ent.setNomTarifa(ItemModel.getNomTarifa());
        Ent.setNomComercial(ItemModel.getNomComercial());
        Ent.setDescripcion(ItemModel.getDescripcion());
        Ent.setFechaRegistro(ItemModel.getFechaRegistro());
        Ent.setCodUsuario(ItemModel.getCodUsuario());
        Ent.setEstadoRegistro(ItemModel.getEstadoRegistro());
        Ent.setAction(Utilidades.ConvetEnumAction(ItemModel.getAction()));
        BS.Registrar(Ent);
        ItemModel.setTarifaId(Ent.getTarifaId());
        return new ResponseAPI<TarifaSaveModel>(ItemModel, true, "");
    }

    @GetMapping("/ObtenerItem/{Id}")
    public ResponseAPI<ArrayList<TarifaSaveModel>> ObtenerItem(@PathVariable int Id) {
        DataConfi();
        Tarifa BS = new Tarifa();
        ArrayList<TarifaSaveModel> Items = new ArrayList<>();
        ArrayList<TarifaEntity> Data = BS.ObtenerMain();

        for (TarifaEntity Item : Data) {
            Items.add(new TarifaSaveModel(Item));
        }

        return new ResponseAPI<ArrayList<TarifaSaveModel>>(Items, true, "");
    }

    
    @PostMapping("/BuscarRecurso")
    public ResponseAPI<ArrayList<TarifaBuscarRecursoModel>> BuscarRecurso(@RequestBody ItemLikeModel ItemLike) {
        ArrayList<TarifaBuscarRecursoModel> Items = new ArrayList<>();
        Tarifa BS = new Tarifa();
        ArrayList<TarifaEntity> Data = BS.BuscarRecurso(ItemLike.getSrtValor1(),ItemLike.getIntValor1());

        for (TarifaEntity Item : Data) {
            Items.add(new TarifaBuscarRecursoModel(Item));
        }

        return new ResponseAPI<ArrayList<TarifaBuscarRecursoModel>>(Items, true, "");
    }

    @PostMapping("/GetTarifaBuscarItem")
    public ResponseAPI<ArrayList<TarifaBuscarItem>> GetTarifaBuscarItem(@RequestBody ItemLikeModel ItemLike) {
        DataConfi();
        ArrayList<TarifaBuscarItem> Items = new ArrayList<>();
        Tarifa BS = new Tarifa();
        ArrayList<TarifaEntity> Data = BS.GetTarifaBuscarItem(ItemLike.getSrtValor1());

        for (TarifaEntity Item : Data) {
            Items.add(new TarifaBuscarItem(Item));
        }

        return new ResponseAPI<ArrayList<TarifaBuscarItem>>(Items, true, "");
    }
}
