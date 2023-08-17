import { Component, OnInit, HostBinding, ViewChild, ElementRef } from '@angular/core';
import { PersonanaturalService } from '../../services/personanatural.service';
import { PersonaNaturalEntity } from '../../models/PersonaNaturalEntity';

@Component({
  selector: 'app-persona-natural-main',
  templateUrl: './persona-natural-main.component.html',
  styleUrls: ['./persona-natural-main.component.css']
})
export class PersonaNaturalMainComponent implements OnInit {


  newItem: PersonaNaturalEntity = {

    PersonaNaturalId: 0,
    TipoDocumentoIdentidadId: 2,
    NumDocumento: "46519359",
    Nombres: "RUTH SAYURI",
    ApellidoPaterno: "CARRASCO",
    ApellidoMaterno: "RAMIREZ",
    FechaNacimiento: new Date(),
    UbigeoId: 1259,
    Direccion: "NA",
    Telefono: "56456",
    Correo: "NA",
    Genero: 0,
    EstadoCivil: 0,
    Action: 1
  };

  personanaturalItems: any = [];;
  constructor(private service: PersonanaturalService) {
  }

  ngOnInit() {
    this.Getpersonanatural();
    this.saveItem();
  }

  Getpersonanatural() {
    this.service.Getpersonanatural().subscribe(
      respuesta => {

        this.personanaturalItems = respuesta;
        console.log(respuesta);
      }
    )

  }


  saveItem() {
    console.log(this.newItem);
    this.service.Save(this.newItem)
      .subscribe(
        res => {

          console.log(res);
        },
        err => console.error(err)
      )

  }
}
