import { Component, OnInit, importProvidersFrom } from '@angular/core';
import { ButtonStyles, DropdownStyles } from '../../../models/StylesPrime';
import { TipoDocumentoIdentidadItemModel } from '../..//../models/General/TipoDocumentoIdentidadItemModel'
import { GeneralService } from '../..//../services/General/general.service'
interface City {
  name: string;
  code: string;
}

@Component({
  selector: 'app-persona-natural-save',
  templateUrl: './persona-natural-save.component.html',
  styleUrls: ['./persona-natural-save.component.css']
})
export class PersonaNaturalSaveComponent implements OnInit {

  TipoDocumentoIdentidadItems: TipoDocumentoIdentidadItemModel[] = [];

  SelectTipoDocumentoIdentidadItem: TipoDocumentoIdentidadItemModel | undefined;
  buttonStyle = ButtonStyles.primary;
  DropdownStyle = DropdownStyles.Data;

  constructor(private serviceGeneral: GeneralService) {
  }

  ngOnInit() {
    this.GetTipoDocuemntoIdentidadPersonaItems();
  }


  GetTipoDocuemntoIdentidadPersonaItems() {
    this.serviceGeneral.GetTipoDocuemntoIdentidadPersonaItems().subscribe(
      respuesta => {
        this.TipoDocumentoIdentidadItems = respuesta;
      }
    )
  }

}
