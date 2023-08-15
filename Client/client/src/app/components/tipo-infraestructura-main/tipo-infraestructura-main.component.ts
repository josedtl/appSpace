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
  constructor(private service:TipoInfraestructuraService) {
  }


  ngOnInit() {
    this.getInfraestructuras();
  }

  getInfraestructuras() {
    this.service.getTipoInfraestructura().subscribe(
      respuesta =>{

        this.TipoinfraestructuraItems=respuesta;
        console.log(respuesta);
      }
    )

  }

}
