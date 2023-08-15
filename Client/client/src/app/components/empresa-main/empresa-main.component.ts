import { Component, OnInit, HostBinding, ViewChild, ElementRef } from '@angular/core';
import { EmpresaService } from '../../services/empresa.service';
import {EmpresaEntity } from '../../models/EmpresaEntity';

@Component({
  selector: 'app-empresa-main',
  templateUrl: './empresa-main.component.html',
  styleUrls: ['./empresa-main.component.css']
})
export class EmpresaMainComponent {

  EmpresaItems: any = [];;
  constructor(private service:EmpresaService) {
  }
  ngOnInit() {
    this.getEmpresa();
  }
  
  getEmpresa() {
    this.service.getEmpresa().subscribe(
      respuesta =>{

        this.EmpresaItems=respuesta;
        console.log(respuesta);
      }
    )

  }
}
