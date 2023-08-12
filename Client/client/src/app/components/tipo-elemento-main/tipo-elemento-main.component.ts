import { Component, OnInit, HostBinding } from '@angular/core';

import { TipoElementoServiceService } from '../../services/tipo-elemento-service.service';
@Component({
  selector: 'app-tipo-elemento-main',
  templateUrl: './tipo-elemento-main.component.html',
  styleUrls: ['./tipo-elemento-main.component.css']
})
export class TipoElementoMainComponent implements OnInit {
  @HostBinding('class') classes = 'row';
  TipoElementoItems: any = [];

  constructor(private tipoelementoserviceservice: TipoElementoServiceService) { }


  ngOnInit() {
    this.getGames();
  }
  getGames() {
    this.tipoelementoserviceservice.getTipoElemento()
      .subscribe(
        res => {
          this.TipoElementoItems = res;
          console.log(this.TipoElementoItems)
        },
        err => console.error(err)
      );
  }

}
