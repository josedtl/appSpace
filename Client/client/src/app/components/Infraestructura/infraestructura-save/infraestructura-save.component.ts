import { Component, OnInit } from '@angular/core';
import { ButtonStyles, DropdownStyles } from '../../../models/StylesPrime';
import { TipoDocumentoIdentidadItemModel } from '../..//../models/General/TipoDocumentoIdentidadItemModel'
import { UbigeoItemModel } from '../..//../models/General/UbigeoItemModel'
import { GeneroItemModel } from '../..//../models/General/GeneroItemModel'
import { EstadoCivilItemModel } from '../..//../models/General/EstadoCivilItemModel'
import { GeneralService } from '../..//../services/General/general.service'
import { InfraestructuraService } from '../..//../services/Infraestructura/infraestructura.service'
import { InfraestructuraSaveModel } from '../../../models/Infraestructura/InfraestructuraSaveModel';
import { ActivatedRoute } from '@angular/router';
import { ConfirmationService, MessageService, ConfirmEventType } from 'primeng/api';
interface AutoCompleteCompleteEvent {
  originalEvent: Event;
  query: string;
}

@Component({
  selector: 'app-infraestructura-save',
  templateUrl: './infraestructura-save.component.html',
  styleUrls: ['./infraestructura-save.component.css']
})
export class InfraestructuraSaveComponent {

}
