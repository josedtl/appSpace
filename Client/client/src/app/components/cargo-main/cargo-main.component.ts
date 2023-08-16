import { Component , OnInit, HostBinding, ViewChild, ElementRef} from '@angular/core';
import { CargoService } from '../../services/cargo.service';
import {  CargoEntity } from '../../models/CargoEntity';

@Component({
  selector: 'app-cargo-main',
  templateUrl: './cargo-main.component.html',
  styleUrls: ['./cargo-main.component.css']
})
export class CargoMainComponent {
  
  CargoItems: any = [];;
  @ViewChild('saveModal') saveModal!: ElementRef; // Referencia a la ventana emergente
  constructor(private service:CargoService) {
  }
  newItem: CargoEntity = {
    tipoInfraestructuraId: 0,
    nombre: '',
    fechaRegistro: new Date(),
    codUsuario: 'adm ',
    estadoRegistro: true,
  //  action: 0,
  };
  

  ngOnInit() {
    this.getCargo();
  }
  openModal() {
   // this.newItem.action = 1;
    this.saveModal.nativeElement.style.display = 'block';
  }
  closeModal() {
    this.saveModal.nativeElement.style.display = 'none';
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
