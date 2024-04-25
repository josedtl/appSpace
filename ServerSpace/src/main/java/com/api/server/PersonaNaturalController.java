package com.api.server;

import Business.PersonaNatural;
import EntityLayer.PersonaNaturalEntity;
import Framework.Utilidades;
import Models.ResponseAPI;
import Models.PersonaNatural.PersonaNaturalMainModel;
import Models.PersonaNatural.PersonaNaturalSaveModel;

import java.util.ArrayList;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.bind.annotation.RequestMapping;

@RestController
@RequestMapping("/api/PersonaNatural")
public class PersonaNaturalController extends Configuracion {

    @GetMapping("/ObtenerMain")
    public ResponseAPI<ArrayList<PersonaNaturalMainModel>> ObtenerMain() {
        DataConfi();
        PersonaNatural BS = new PersonaNatural();
        ArrayList<PersonaNaturalMainModel> Items = new ArrayList<>();
        ArrayList<PersonaNaturalEntity> Data = BS.ObtenerMain();

        for (PersonaNaturalEntity Item : Data) {
            Items.add(new PersonaNaturalMainModel(Item));
        }

        return new ResponseAPI<ArrayList<PersonaNaturalMainModel>>(Items, true, "");
    }

    @GetMapping("/ObtenerItem/{Id}")
    public ResponseAPI<ArrayList<PersonaNaturalSaveModel>> ObtenerItem(@PathVariable int Id) {
        DataConfi();
        PersonaNatural BS = new PersonaNatural();

        ArrayList<PersonaNaturalSaveModel> Items = new ArrayList<>();
        ArrayList<PersonaNaturalEntity> Data = BS.ObtenerItem(Id);

        for (PersonaNaturalEntity Item : Data) {
            Items.add(new PersonaNaturalSaveModel(Item));
        }
        return new ResponseAPI<ArrayList<PersonaNaturalSaveModel>>(Items, true, "");
    }

    @PostMapping("/Registrar")
    public PersonaNaturalSaveModel Registrar(@RequestBody PersonaNaturalSaveModel ItemModel) {
        DataConfi();
        PersonaNatural BS = new PersonaNatural();
        PersonaNaturalEntity Ent = new PersonaNaturalEntity();

        Ent.setPersonaNaturalId(ItemModel.getPersonaNaturalId());
        Ent.setTipoDocumentoIdentidadId(ItemModel.getTipoDocumentoIdentidadId());
        Ent.setNumDocumento(ItemModel.getNumDocumento());
        Ent.setNombres(ItemModel.getNombres());
        Ent.setApellidoPaterno(ItemModel.getApellidoPaterno());
        Ent.setApellidoMaterno(ItemModel.getApellidoMaterno());
        Ent.setFechaNacimiento(ItemModel.getFechaNacimiento());
        Ent.setUbigeoId(ItemModel.getUbigeoId());
        Ent.setDireccion(ItemModel.getDireccion());
        Ent.setTelefono(ItemModel.getTelefono());
        Ent.setCorreo(ItemModel.getCorreo());
        Ent.setSexoId(ItemModel.getSexoId());
        Ent.setEstadoCivilId(ItemModel.getEstadoCivilId());
        Ent.setFechaRegistro(ItemModel.getFechaRegistro());
        Ent.setCodUsuario(ItemModel.getCodUsuario());
        Ent.setAction(Utilidades.ConvetEnumAction(ItemModel.getAction()));

        Ent = BS.Registrar(Ent);
        ItemModel.setPersonaNaturalId(Ent.getPersonaNaturalId());
        return ItemModel;
    }

}
