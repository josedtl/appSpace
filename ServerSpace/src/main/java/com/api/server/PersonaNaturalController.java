package com.api.server;

import Business.PersonaNatural;
import EntityLayer.PersonaNaturalEntity;
import Enumerados.ProcessActionEnum;
import Framework.Utilidades;
import Models.PersonaNaturalMainModel;
import Models.PersonaNaturalSaveModel;
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
    public PersonaNaturalSaveModel Save(@RequestBody PersonaNaturalSaveModel ItemModel) {
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
        Ent.setGeneroId(ItemModel.getGeneroId());
        Ent.setEstadoCivilId(ItemModel.getEstadoCivilId());
        Ent.setFechaRegistro(ItemModel.getFechaRegistro());
        Ent.setCodUsuario(ItemModel.getCodUsuario());
        Ent.setEstadoRegistro(ItemModel.getEstadoRegistro());
        Ent.setAction(Utilidades.ConvetEnumAction(ItemModel.getAction()));

        Ent = BS.Save(Ent);
        ItemModel.setPersonaNaturalId(Ent.getPersonaNaturalId());
        return ItemModel;
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
