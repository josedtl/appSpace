package com.api.server;

import Business.ServLista;
import EntityLayer.ServListaEntity;
import Models.ItemLikeModel;
import Models.ResponseAPI;
import Models.ServLista.*;
import java.util.ArrayList;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.bind.annotation.RequestMapping;
import Framework.Utilidades;

@RestController
@RequestMapping("/api/ServLista")
public class ServListaController extends Configuracion {

    @GetMapping("/ObtenerCodigo/{codigo}")
    public ResponseAPI<ArrayList<ServListaModel>> ObtenerCodigo(@PathVariable String codigo) {
        DataConfi();
        ServLista BS = new ServLista();
        ArrayList<ServListaModel> Items = new ArrayList<>();
        ArrayList<ServListaEntity> Data = BS.ObtenerCodigo(codigo);

        for (ServListaEntity Item : Data) {
            Items.add(new ServListaModel(Item));
        }

        return new ResponseAPI<ArrayList<ServListaModel>>(Items, true, "");
    }

    @PostMapping("/Buscar")
    public ResponseAPI<ArrayList<ServListaModel>> GetUbigeoLikeItem(@RequestBody ItemLikeModel ItemLike) {
        ArrayList<ServListaModel> Items = new ArrayList<>();
        ServLista BS = new ServLista();
        ArrayList<ServListaEntity> Data = BS.Buscar(ItemLike.getSrtValor1(), ItemLike.getSrtValor2());

        for (ServListaEntity Item : Data) {
            Items.add(new ServListaModel(Item));
        }

        return new ResponseAPI<ArrayList<ServListaModel>>(Items, true, "");
    }

    @GetMapping("/ObtenerMain/{codigo}")
    public ResponseAPI<ArrayList<ServListaMainModel>> ObtenerMain(@PathVariable String codigo) {
        DataConfi();
        ServLista BS = new ServLista();
        ArrayList<ServListaMainModel> Items = new ArrayList<>();
        ArrayList<ServListaEntity> Data = BS.ObtenerMain(codigo);

        for (ServListaEntity Item : Data) {
            Items.add(new ServListaMainModel(Item));
        }

        return new ResponseAPI<ArrayList<ServListaMainModel>>(Items, true, "");
    }

    @PostMapping("/Registrar")
    public ResponseAPI<ServListaSaveModel> Registrar(@RequestBody ServListaSaveModel ItemModel) {
        DataConfi();
        ServLista BS = new ServLista();
        ServListaEntity Ent = new ServListaEntity();

        Ent.setListaId(ItemModel.getListaId());
        Ent.setCodigoCampo(ItemModel.getCodigoCampo());
        Ent.setCodigo(ItemModel.getCodigo());
        Ent.setNombre(ItemModel.getNombre());
        Ent.setDescripcion(ItemModel.getDescripcion());
        Ent.setFechaRegistro(ItemModel.getFechaRegistro());
        Ent.setCodUsuario(ItemModel.getCodUsuario());
        Ent.setEstadoRegistro(ItemModel.getEstadoRegistro());
        Ent.setAction(Utilidades.ConvetEnumAction(ItemModel.getAction()));

        Ent = BS.Registrar(Ent);
        ItemModel.setListaId(Ent.getListaId());
        return new ResponseAPI<ServListaSaveModel>(ItemModel, true, "");
    }

    @GetMapping("/ObtenerItem/{ListaId}")
    public ResponseAPI<ArrayList<ServListaSaveModel>> ObtenerItem(@PathVariable int ListaId) {
        DataConfi();
        ServLista BS = new ServLista();
        ArrayList<ServListaSaveModel> Items = new ArrayList<>();
        ArrayList<ServListaEntity> Data = BS.ObtenerItem(ListaId);

        for (ServListaEntity Item : Data) {
            Items.add(new ServListaSaveModel(Item));
        }
        return new ResponseAPI<ArrayList<ServListaSaveModel>>(Items,true, "");
    }

}
