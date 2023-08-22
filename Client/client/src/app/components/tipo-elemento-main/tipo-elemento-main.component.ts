import { Component, OnInit, HostBinding, ViewChild, ElementRef } from '@angular/core';
import { TipoElementoServiceService } from '../../services/tipo-elemento-service.service';
import { TipoElementoEntity } from '../../models/TipoElementoEntity';
// import { TipoElementoEntity } from '../models/TipoElementoEntity'

@Component({
  selector: 'app-tipo-elemento-main',
  templateUrl: './tipo-elemento-main.component.html',
  styleUrls: ['./tipo-elemento-main.component.css']
})
export class TipoElementoMainComponent implements OnInit {
  @HostBinding('class') classes = 'row';

  @ViewChild('saveModal') saveModal!: ElementRef; // Referencia a la ventana emergente

  newItem: TipoElementoEntity = {
    TipoElementoId: 0,
    Nombre: '',
    FechaRegistro: new Date(),
    CodUsuario: 'adm ',
    EstadoRegistro: true,
    Action: 0,
  };

  TipoElementoItems: any = [];;

  constructor(private tipoelementoserviceservice: TipoElementoServiceService) {


  }


  ngOnInit() {
    this.getGames();
  }


  getGames() {
    this.tipoelementoserviceservice.getTipoElemento()
      .subscribe(
        res => {
          this.TipoElementoItems = res;

        },
        err => console.error(err)
      );
  }
  openModal() {
    this.newItem.Action = 1;
    this.saveModal.nativeElement.style.display = 'block';
  }
  closeModal() {
    this.saveModal.nativeElement.style.display = 'none';
  }


  saveItem() {
    this.tipoelementoserviceservice.saveTipoElemento(this.newItem)
      .subscribe(
        res => {
          this.getGames();
        },
        err => console.error(err)
      )
    this.closeModal();

  }
  Delete_Metho(Id: number) {
    this.tipoelementoserviceservice.deleteTipoElemento(Id)
      .subscribe(
        res => {
          this.getGames();
        },
        err => console.error(err)
      );
  }
  Update_Metho(data: TipoElementoEntity) {
    this.openModal();
    data.Action = 3
    this.newItem = data;

  }
}
