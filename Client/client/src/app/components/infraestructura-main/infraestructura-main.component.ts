import { Component, OnInit, HostBinding, ViewChild, ElementRef } from '@angular/core';
import { InfraestructuraService } from '../../services/Infraestructura/infraestructura.service';
import { InfraestructuraEntity  } from '../../models/Infraestructura/InfraestructuraEntity';
import { ConfirmationService, MessageService, ConfirmEventType } from 'primeng/api';
import { ButtonStyles } from '../../models/StylesPrime';

@Component({
  selector: 'app-infraestructura-main',
  templateUrl: './infraestructura-main.component.html',
  styleUrls: ['./infraestructura-main.component.css']
})
export class InfraestructuraMainComponent {

}
