
package com.api.server;

import Business.Cargo;
import Business.Piso;
import Business.ServicioBasico;
import EntityLayer.CargoEntity;
import EntityLayer.PisoEntity;
import EntityLayer.ServicioBasicoEntity;
import Models.CargoItemModel;
import Models.PisoItemModel;
import Models.ServicioBasicoItemModel;
import java.util.ArrayList;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.bind.annotation.RequestMapping;

@RestController
@RequestMapping("/api/General")
public class GeneralController {

    @GetMapping("/GetPisoItems")
    public ArrayList<PisoItemModel> GetPisoItems() {

        ArrayList<PisoItemModel> Items = new ArrayList<>();
        Piso BS = new Piso();

        ArrayList<PisoEntity> Data = BS.GetAllItems();

        for (PisoEntity Item : Data) {
            PisoItemModel ItemParametro = new PisoItemModel(Item);
            Items.add(ItemParametro);
//            Items.add(new PisoItemModel(Item));
        }

        return Items;
    }
    
    @GetMapping("/GetPisoItem/{Id}")
    public ArrayList<PisoItemModel> GetPisoItem(@PathVariable int Id) {
        ArrayList<PisoItemModel> Items = new ArrayList<>();
        Piso BS = new Piso();
        ArrayList<PisoEntity> Data = BS.GetAllItem(Id);

        for (PisoEntity Item : Data) {
            Items.add(new PisoItemModel(Item));
        }

        return Items;
    }
    
    @GetMapping("/GetPisoLikeItem/{Codigo}")
    public ArrayList<PisoItemModel> GetPisoLikeItem(@PathVariable String Codigo) {
        ArrayList<PisoItemModel> Items = new ArrayList<>();
        Piso BS = new Piso();
        ArrayList<PisoEntity> Data = BS.GetPisoLikeItem(Codigo);

        for (PisoEntity Item : Data) {
            Items.add(new PisoItemModel(Item));
        }

        return Items;
    }

    @GetMapping("/GetCargoItems")
    public ArrayList<CargoItemModel> GetCargoItems() {
        ArrayList<CargoItemModel> Items = new ArrayList<>();
        Cargo BS = new Cargo();

        ArrayList<CargoEntity> Data = BS.GetAllItems();

        for (CargoEntity Item : Data) {
            Items.add(new CargoItemModel(Item));
        }

        return Items;
    }

    @GetMapping("/GetCargoItem/{Id}")
    public ArrayList<CargoItemModel> GetCargoItem(@PathVariable int Id) {
        ArrayList<CargoItemModel> Items = new ArrayList<>();
        Cargo BS = new Cargo();
        ArrayList<CargoEntity> Data = BS.GetAllItem(Id);

        for (CargoEntity Item : Data) {
            Items.add(new CargoItemModel(Item));
        }

        return Items;
    }

    @GetMapping("/GetCargoLikeItem/{Nombre}")
    public ArrayList<CargoItemModel> GetCargoLikeItem(@PathVariable String Nombre) {
        ArrayList<CargoItemModel> Items = new ArrayList<>();
        Cargo BS = new Cargo();
        ArrayList<CargoEntity> Data = BS.GetCargoLikeItem(Nombre);

        for (CargoEntity Item : Data) {
            Items.add(new CargoItemModel(Item));
        }

        return Items;
    }

    @GetMapping("/GetServicioBasicoItems")
    public ArrayList<ServicioBasicoItemModel> GetServicioBasicoItems() {

        ArrayList<ServicioBasicoItemModel> Items = new ArrayList<>();
        ServicioBasico BS = new ServicioBasico();

        ArrayList<ServicioBasicoEntity> Data = BS.GetAllItems();

        for (ServicioBasicoEntity Item : Data) {
            ServicioBasicoItemModel ItemParametro = new ServicioBasicoItemModel(Item);
            Items.add(ItemParametro);
        }

        return Items;
    }

    @GetMapping("/GetServicioBasicoItem/{Id}")
    public ArrayList<ServicioBasicoItemModel> GetServicioBasicoItem(@PathVariable int Id) {
        ArrayList<ServicioBasicoItemModel> Items = new ArrayList<>();
        ServicioBasico BS = new ServicioBasico();
        ArrayList<ServicioBasicoEntity> Data = BS.GetAllItem(Id);

        for (ServicioBasicoEntity Item : Data) {
            Items.add(new ServicioBasicoItemModel(Item));
        }

        return Items;
    }
    
     @GetMapping("/GetServicioBasicoLikeItem/{Codigo}")
    public ArrayList<ServicioBasicoItemModel> GetServicioBasicoLikeItem(@PathVariable String Codigo) {
        ArrayList<ServicioBasicoItemModel> Items = new ArrayList<>();
        ServicioBasico BS = new ServicioBasico();
        ArrayList<ServicioBasicoEntity> Data = BS.GetServicioBasicoLikeItem(Codigo);

        for (ServicioBasicoEntity Item : Data) {
            Items.add(new ServicioBasicoItemModel(Item));
        }

        return Items;
    }
    
}
