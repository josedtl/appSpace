import { Component, OnInit, HostBinding, ViewChild, ElementRef } from '@angular/core';
import { PersonanaturalService } from '../../services/personanatural.service';
import { personanaturalEntity } from '../../models/personanaturalEntity';

@Component({
  selector: 'app-persona-natural-main',
  templateUrl: './persona-natural-main.component.html',
  styleUrls: ['./persona-natural-main.component.css']
})
export class PersonaNaturalMainComponent implements OnInit {

  personanaturalItems: any = [];;
  constructor(private service:PersonanaturalService) {
  }

  ngOnInit() {
    this.Getpersonanatural();
  }

  Getpersonanatural() {
    this.service.Getpersonanatural().subscribe(
      respuesta =>{

        this.personanaturalItems=respuesta;
        console.log(respuesta);
      }
    )

  }
}
