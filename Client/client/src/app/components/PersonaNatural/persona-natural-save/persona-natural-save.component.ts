import { Component, OnInit } from '@angular/core';
import { ButtonStyles, DropdownStyles } from '../../../models/StylesPrime';
import { TipoDocumentoIdentidadItemModel } from '../..//../models/General/TipoDocumentoIdentidadItemModel'
import { UbigeoItemModel } from '../..//../models/General/UbigeoItemModel'
import { GeneroItemModel } from '../..//../models/General/GeneroItemModel'
import { EstadoCivilItemModel } from '../..//../models/General/EstadoCivilItemModel'
import { MedioComunicacionItemModel } from '../..//../models/General/MedioComunicacionItemModel'
import { GeneralService } from '../..//../services/General/general.service'
import { PersonaNaturalService } from '../..//../services/PersonaNatural/persona-natural.service'
import { PersonaNaturalSaveModel } from '../../../models/PersonaNatural/PersonaNaturalSaveModel';
import { PersonaNaturalMedioComunicacionSaveModel } from '../../../models/PersonaNatural/PersonaNaturalMedioComunicacionSaveModel'
import { ActivatedRoute } from '@angular/router';
import { ConfirmationService, MessageService, ConfirmEventType } from 'primeng/api';
import { ThisReceiver } from '@angular/compiler';
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



  visibleVentena: boolean = false;
  TipoDocumentoIdentidadItems: TipoDocumentoIdentidadItemModel[] = [];
  SelectTipoDocumentoIdentidadItem: TipoDocumentoIdentidadItemModel = new TipoDocumentoIdentidadItemModel;

  UbigeoItems: UbigeoItemModel[] = [];
  SelectUbigeoItem: UbigeoItemModel = new UbigeoItemModel;

  GeneroItems: GeneroItemModel[] = [];
  SelectGeneroItem: GeneroItemModel = new GeneroItemModel;

  EstadoCivilItems: EstadoCivilItemModel[] = [];
  SelectEstadoCivilItem: EstadoCivilItemModel = new EstadoCivilItemModel;

  MedioComunicacionItems: MedioComunicacionItemModel[] = [];
  SelectMedioComunicacionItem: MedioComunicacionItemModel = new MedioComunicacionItemModel;


  date: Date = new Date;


  RutaImagen: string = 'https://as1.ftcdn.net/v2/jpg/04/56/58/14/1000_F_456581427_5XpGqNqCwLAGwaFFvxVGvnW2teOfJ0ZL.jpg';



  buttonStyle = ButtonStyles.primary;
  DropdownStyle = DropdownStyles.Data;


  constructor(private messageService: MessageService, private confirmationService: ConfirmationService, private route: ActivatedRoute, private serviceGeneral: GeneralService, private personanaturalService: PersonaNaturalService) {


  }
  newItem: PersonaNaturalSaveModel = new PersonaNaturalSaveModel;
  activeIndex: number = 0;
  id: number = 0;
  ngOnInit() {

    this.GetTipoDocuemntoIdentidadPersonaItems();
    this.GetGeneroItems();
    this.GetEstadoCivilItems();
    this.GetMedioComunicacionItems();
    this.route.params.subscribe(params => {
      this.id = +params['id']; // Convierte el valor a número

    });


    if (this.id > 0) {

      this.getPersonaNatural(this.id);
    }


  }

  getUbigeoItem(Id: number) {
    this.serviceGeneral.GetUbigeoItem(Id).subscribe(
      respuesta => {
        this.SelectUbigeoItem = respuesta[0];
      }
    )
  }

  GetGeneroItem(Id: number) {
    this.serviceGeneral.GetGeneroItem(Id).subscribe(
      respuesta => {
        this.SelectGeneroItem = respuesta[0];
      }
    )
  }

  GetEstadoCivilItem(Id: number) {
    this.serviceGeneral.GetEstadoCivilItem(Id).subscribe(
      respuesta => {
        this.SelectEstadoCivilItem = respuesta[0];
      }
    )
  }

  getPersonaNatural(Id: number) {
    this.personanaturalService.GetAllItem(Id).subscribe(
      respuesta => {
        this.newItem = respuesta[0];
        this.getUbigeoItem(this.newItem.UbigeoId)
        this.GetGeneroItem(this.newItem.GeneroId)
        this.GetEstadoCivilItem(this.newItem.EstadoCivilId)
        this.date = new Date(this.newItem.FechaNacimiento);
        console.log(this.newItem.FechaNacimiento);
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

  GetMedioComunicacionItems() {
    this.serviceGeneral.GetMedioComunicacionItems().subscribe(
      respuesta => {
        this.MedioComunicacionItems = respuesta;
        console.log(respuesta);
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

    this.confirmationService.confirm({
      message: '¿Deseas guardar el registro?',
      icon: 'pi pi-exclamation-triangle',
      acceptLabel: 'Sí',
      rejectLabel: 'No',
      accept: () => {
        this.messageService.add({ severity: 'info', summary: 'Confirmed', detail: 'You have accepted' });

        this.newItem.Action = this.newItem.PersonaNaturalId > 0 ? 3 : 1;
        this.newItem.UbigeoId = this.SelectUbigeoItem.UbigeoId;
        this.newItem.TipoDocumentoIdentidadId = this.SelectTipoDocumentoIdentidadItem.TipoDocumentoIdentidadId;
        this.newItem.GeneroId = this.SelectGeneroItem.GeneroId;
        this.newItem.EstadoCivilId = this.SelectEstadoCivilItem.EstadoCivilId;
        this.newItem.FechaNacimiento = this.date;

        console.log(this.newItem);

        this.personanaturalService.save(this.newItem)
          .subscribe(
            res => {
              if (res.PersonaNaturalId != 0) {
                console.log(res);
              }
            },
            err => console.error(err)
          )

      },

    });
  }

  productDialog: boolean = false;
  submitted: boolean = false;
  hideDialog() {
    this.productDialog = false;
    this.submitted = false;
    this.visibleVentena = false;
  }

  newItemDetalle: PersonaNaturalMedioComunicacionSaveModel = new PersonaNaturalMedioComunicacionSaveModel();

  showDialog() {
    this.newItemDetalle = new PersonaNaturalMedioComunicacionSaveModel();
    this.newItem.Action = 1;
    this.visibleVentena = true;
  }



  saveItemDetalle() {

    this.newItemDetalle.Action = 1;
    this.newItemDetalle.NomMedioComunicacion = this.SelectMedioComunicacionItem.Nombre;
    this.newItemDetalle.MedioComunicacionId = this.SelectMedioComunicacionItem.MedioComunicacionId;
    if (this.newItem.DetalleMedioComunicacion == null) this.newItem.DetalleMedioComunicacion = [];
    this.newItem.DetalleMedioComunicacion.push(this.newItemDetalle);

    this.newItem.DetalleMedioComunicacion.forEach((Item, index) => {
      Item.Item = index + 1;
    });
    this.hideDialog();
  }
}
