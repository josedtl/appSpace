import { Component, OnInit } from '@angular/core';
import { ButtonStyles, DropdownStyles } from '../../../models/StylesPrime';
import { TipoDocumentoIdentidadItemModel } from '../..//../models/General/TipoDocumentoIdentidadItemModel'
import { UbigeoItemModel } from '../..//../models/General/UbigeoItemModel'
import { GeneroItemModel } from '../..//../models/General/GeneroItemModel'
import { EstadoCivilItemModel } from '../..//../models/General/EstadoCivilItemModel'
import { GeneralService } from '../..//../services/General/general.service'
import { PersonaNaturalService } from '../..//../services/PersonaNatural/persona-natural.service'
import { PersonaNaturalSaveModel } from '../../../models/PersonaNatural/PersonaNaturalSaveModel';
import { ActivatedRoute } from '@angular/router';
interface AutoCompleteCompleteEvent {
  originalEvent: Event;
  query: string;
}

@Component({
  selector: 'app-persona-natural-save',
  templateUrl: './persona-natural-save.component.html',
  styleUrls: ['./persona-natural-save.component.css']
})
export class PersonaNaturalSaveComponent implements OnInit {

  TipoDocumentoIdentidadItems: TipoDocumentoIdentidadItemModel[] = [];
  SelectTipoDocumentoIdentidadItem: TipoDocumentoIdentidadItemModel = new TipoDocumentoIdentidadItemModel;

  UbigeoItems: UbigeoItemModel[] = [];
  SelectUbigeoItem: UbigeoItemModel = new UbigeoItemModel;

  GeneroItems: GeneroItemModel[] = [];
  SelectGeneroItem: GeneroItemModel = new GeneroItemModel;

  EstadoCivilItems: EstadoCivilItemModel[] = [];
  SelectEstadoCivilItem: EstadoCivilItemModel = new EstadoCivilItemModel;



  RutaImagen: string = 'https://as1.ftcdn.net/v2/jpg/04/56/58/14/1000_F_456581427_5XpGqNqCwLAGwaFFvxVGvnW2teOfJ0ZL.jpg';



  buttonStyle = ButtonStyles.primary;
  DropdownStyle = DropdownStyles.Data;


  constructor(private route: ActivatedRoute, private serviceGeneral: GeneralService, private personanaturalService: PersonaNaturalService) {

    
  }
  newItem: PersonaNaturalSaveModel = new PersonaNaturalSaveModel; 

  id: number = 0;
  ngOnInit() {

    this.GetTipoDocuemntoIdentidadPersonaItems();
    this.GetGeneroItems();
    this.GetEstadoCivilItems();
    
    this.route.params.subscribe(params => {
      this.id = +params['id']; // Convierte el valor a número
      
    });
    
    this.getPersonaNatural(this.id);

  }

  getPersonaNatural(Id: number) {
    this.personanaturalService.GetAllItem(Id).subscribe(
      respuesta => {
        this.newItem = respuesta[0];

      }
    )
  }

  GetTipoDocuemntoIdentidadPersonaItems() {
    this.serviceGeneral.GetTipoDocuemntoIdentidadPersonaItems().subscribe(
      respuesta => {
        this.TipoDocumentoIdentidadItems = respuesta;
      }
    )
  }
  GetGeneroItems() {
    this.serviceGeneral.GetGeneroItems().subscribe(
      respuesta => {
        this.GeneroItems = respuesta;
      }
    )
  }

  GetEstadoCivilItems() {
    this.serviceGeneral.GetEstadoCivilItems().subscribe(
      respuesta => {
        this.EstadoCivilItems = respuesta;
      }
    )
  }


  GetUbigeoLikeItemEvent(event: AutoCompleteCompleteEvent) {
    let query = event.query;
    this.serviceGeneral.GetUbigeoLikeItem(query.toLowerCase()).subscribe(
      respuesta => {
        this.UbigeoItems = respuesta;
      }
    )
  }


  saveItem() {

    this.newItem.UbigeoId = this.SelectUbigeoItem.UbigeoId;
    this.newItem.TipoDocumentoIdentidadId = this.SelectTipoDocumentoIdentidadItem.TipoDocumentoIdentidadId;
    this.newItem.GeneroId = this.SelectGeneroItem.GeneroId;
    this.newItem.EstadoCivilId = this.SelectEstadoCivilItem.EstadoCivilId;
    this.newItem.Action = 1;
    this.personanaturalService.save(this.newItem)
      .subscribe(
        res => {
          if (res.PersonaNaturalId != 0) {
            console.log(res);
          }
        },
        err => console.error(err)
      )
  }

}
