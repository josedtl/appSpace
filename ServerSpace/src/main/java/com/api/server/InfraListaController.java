package com.api.server;

import Business.InfraLista;
import EntityLayer.InfraListaEntity;
import Models.ItemLikeModel;
import Models.ResponseAPI;
import Models.InfraLista.InfraListaMainModel;
import Models.InfraLista.InfraListaModel;
import Models.InfraLista.InfraListaSaveModel;
import java.util.ArrayList;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.bind.annotation.RequestMapping;
import Framework.Utilidades;

@RestController
@RequestMapping("/api/InfraLista")
public class InfraListaController extends Configuracion {

    @GetMapping("/ObtenerCodigo/{codigo}")
    public ResponseAPI<ArrayList<InfraListaModel>> ObtenerCodigo(@PathVariable String codigo) {
        DataConfi();
        InfraLista BS = new InfraLista();
        ArrayList<InfraListaModel> Items = new ArrayList<>();
        ArrayList<InfraListaEntity> Data = BS.ObtenerCodigo(codigo);

        for (InfraListaEntity Item : Data) {
            Items.add(new InfraListaModel(Item));
        }

        return new ResponseAPI<ArrayList<InfraListaModel>>(Items, true, "");
    }

    @PostMapping("/Buscar")
    public ResponseAPI<ArrayList<InfraListaModel>> Buscar(@RequestBody ItemLikeModel ItemLike) {
        ArrayList<InfraListaModel> Items = new ArrayList<>();
        InfraLista BS = new InfraLista();
        ArrayList<InfraListaEntity> Data = BS.Buscar(ItemLike.getSrtValor1(), ItemLike.getSrtValor2());

        for (InfraListaEntity Item : Data) {
            Items.add(new InfraListaModel(Item));
        }

        return new ResponseAPI<ArrayList<InfraListaModel>>(Items, true, "");
    }

    @GetMapping("/ObtenerMain/{codigo}")
    public ResponseAPI<ArrayList<InfraListaMainModel>> ObtenerMain(@PathVariable String codigo) {
        DataConfi();
        InfraLista BS = new InfraLista();
        ArrayList<InfraListaMainModel> Items = new ArrayList<>();
        ArrayList<InfraListaEntity> Data = BS.ObtenerMain(codigo);

        for (InfraListaEntity Item : Data) {
            Items.add(new InfraListaMainModel(Item));
        }

        return new ResponseAPI<ArrayList<InfraListaMainModel>>(Items, true, "");
    }

    @PostMapping("/Registrar")
    public ResponseAPI<InfraListaSaveModel> Registrar(@RequestBody InfraListaSaveModel ItemModel) {
        DataConfi();
        InfraLista BS = new InfraLista();
        InfraListaEntity Ent = new InfraListaEntity();

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
        return new ResponseAPI<InfraListaSaveModel>(ItemModel, true, "");
    }

    @GetMapping("/ObtenerItem/{ListaId}")
    public ResponseAPI<ArrayList<InfraListaSaveModel>> ObtenerItem(@PathVariable int ListaId) {
        DataConfi();
        InfraLista BS = new InfraLista();
        ArrayList<InfraListaSaveModel> Items = new ArrayList<>();
        ArrayList<InfraListaEntity> Data = BS.ObtenerItem(ListaId);

        for (InfraListaEntity Item : Data) {
            Items.add(new InfraListaSaveModel(Item));
        }
        return new ResponseAPI<ArrayList<InfraListaSaveModel>>(Items, true, "");
    }

}
