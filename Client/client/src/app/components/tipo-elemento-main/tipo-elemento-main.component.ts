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
    tipoElementoId: 0,
    nombre: '',
    fechaRegistro: new Date(),
    codUsuario: 'adm ',
    estadoRegistro: true
  };

  TipoElementoItems: any = [];;

  constructor(private tipoelementoserviceservice: TipoElementoServiceService) {

    // this.getGames();
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
    this.saveModal.nativeElement.style.display = 'block';
  }
  closeModal() {
    this.saveModal.nativeElement.style.display = 'none';
  }
 

  saveItem() {
    delete this.newItem.fechaRegistro;
    delete this.newItem.tipoElementoId;
    this.tipoelementoserviceservice.saveTipoElemento(this.newItem)
      .subscribe(
        res => {
          this.getGames();
          // console.log(res);
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

}
