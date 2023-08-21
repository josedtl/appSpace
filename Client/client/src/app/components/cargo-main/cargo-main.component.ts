import { Component, OnInit, HostBinding, ViewChild, ElementRef } from '@angular/core';
import { CargoService } from '../../services/cargo.service';
import { CargoEntity } from '../../models/CargoEntity';

@Component({
  selector: 'app-cargo-main',
  templateUrl: './cargo-main.component.html',
  styleUrls: ['./cargo-main.component.css']
})
export class CargoMainComponent {

  cities: CargoEntity[] | undefined;
  selectedCity: CargoEntity | undefined;
  CargoItems: any = [];;
  @ViewChild('saveModal') saveModal!: ElementRef; // Referencia a la ventana emergente
  constructor(private service: CargoService) {
  }
  newItem: CargoEntity = {
    cargoId: 0,
    nombre: '',
    fechaRegistro: new Date(),
    codUsuario: 'adm ',
    estadoRegistro: true,
    action: 0,
  };


  ngOnInit() {
    this.getCargo();
  }
  openModal() {
    this.newItem.action = 1;
    this.saveModal.nativeElement.style.display = 'block';
  }
  closeModal() {
    this.saveModal.nativeElement.style.display = 'none';
  }

  getCargo() {
    this.service.getCargo().subscribe(
      respuesta => {
        this.CargoItems = respuesta;
        console.log(respuesta);
      }
    )

  }

  saveItem() {
    this.service.save(this.newItem)
      .subscribe(
        res => {
          this.getCargo();
        },
        err => console.error(err)
      )
    this.closeModal();

  }
  Delete_Metho(Id: number) {
    this.service.delete(Id)
      .subscribe(
        res => {
          this.getCargo();
        },
        err => console.error(err)
      );
  }
  Update_Metho(data: CargoEntity) {
    this.openModal();
    data.action = 3
    this.newItem = data;

  }

  first = 0;

  rows = 10;
  next() {
    this.first = this.first + this.rows;
  }

  prev() {
    this.first = this.first - this.rows;
  }

  reset() {
    this.first = 0;
  }

  isLastPage(): boolean {
    return this.CargoItems ? this.first === this.CargoItems.length - this.rows : true;
  }

  isFirstPage(): boolean {
    return this.CargoItems ? this.first === 0 : true;
  }
  visible: boolean = false;
  showDialog() {
    this.visible = true;
}

}
