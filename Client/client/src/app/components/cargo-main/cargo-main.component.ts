import { Component , OnInit, HostBinding, ViewChild, ElementRef} from '@angular/core';
import { CargoService } from '../../services/cargo.service';
import {  CargoEntity} from '../../models/CargoEntity';

@Component({
  selector: 'app-cargo-main',
  templateUrl: './cargo-main.component.html',
  styleUrls: ['./cargo-main.component.css']
})
export class CargoMainComponent {
  
  CargoItems: any = [];;
  constructor(private service:CargoService) {
  }

  ngOnInit() {
    this.getCargo();
  }

  getCargo() {
    this.service.getCargo().subscribe(
      respuesta =>{
        this.CargoItems=respuesta;
        console.log(respuesta);
      }
    )

  }
}
