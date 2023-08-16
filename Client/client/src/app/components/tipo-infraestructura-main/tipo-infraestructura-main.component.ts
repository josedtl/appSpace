import { Component, OnInit, HostBinding, ViewChild, ElementRef } from '@angular/core';
import { TipoInfraestructuraService } from '../../services/tipo-infraestructura.service';
import {  TipoInfraestructuraEntity} from '../../models/TipoInfraestructuraEntity';

@Component({
  selector: 'app-tipo-infraestructura-main',
  templateUrl: './tipo-infraestructura-main.component.html',
  styleUrls: ['./tipo-infraestructura-main.component.css']
})
export class TipoInfraestructuraMainComponent implements OnInit{

  TipoinfraestructuraItems: any = [];;

  @ViewChild('saveModal') saveModal!: ElementRef; // Referencia a la ventana emergente

  constructor(private service:TipoInfraestructuraService) {
  }

  newItem: TipoInfraestructuraEntity = {
    tipoInfraestructuraId: 0,
    nombre: '',
    fechaRegistro: new Date(),
    codUsuario: 'adm ',
    estadoRegistro: true,
    action: 0,
  };

  ngOnInit() {
    this.getInfraestructuras();
  }

  openModal() {
    this.newItem.action = 1;
    this.saveModal.nativeElement.style.display = 'block';
  }
  closeModal() {
    this.saveModal.nativeElement.style.display = 'none';
  }


  getInfraestructuras() {
    this.service.getTipoInfraestructura().subscribe(
      respuesta =>{

        this.TipoinfraestructuraItems=respuesta;
        console.log(respuesta);
      }
    )

  }


  saveItem() {
    this.service.save(this.newItem)
      .subscribe(
        res => {
          this.getInfraestructuras();
        },
        err => console.error(err)
      )
    this.closeModal();

  }
  Delete_Metho(Id: number) {
    this.service.delete(Id)
      .subscribe(
        res => {
          this.getInfraestructuras();
        },
        err => console.error(err)
      );
  }
  Update_Metho(data: TipoInfraestructuraEntity) {
    this.openModal();
    data.action = 3
    this.newItem = data;

  }


}
