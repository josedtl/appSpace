import { Component } from '@angular/core';
import { PersonaNaturalService } from '../../../services/PersonaNatural/persona-natural.service';
import { PersonaNaturalSaveModel } from '../../../models/PersonaNatural/PersonaNaturalSaveModel';
import { ConfirmationService, MessageService, ConfirmEventType } from 'primeng/api';
import { ButtonStyles } from '../../../models/StylesPrime';
import { Router } from '@angular/router';
@Component({
  selector: 'app-persona-natural-main',
  templateUrl: './persona-natural-main.component.html',
  styleUrls: ['./persona-natural-main.component.css']
})
export class PersonaNaturalMainComponent {

  buttonStyle = ButtonStyles.primary;
  visibleVentena: boolean = false;
  loading: boolean = true;
  cities: PersonaNaturalSaveModel[] | undefined;
  selectedCity: PersonaNaturalSaveModel | undefined;
  ListaMainItems: PersonaNaturalSaveModel[] = [];
  selectedItems!: PersonaNaturalSaveModel[] | null;

  constructor(private router: Router,  private personanaturalServiceService: PersonaNaturalService) {
  }
  ngOnInit() {
    this.GetAllItems();
    this.loading = false;
  }

  irADestino() {
    const id = 123; // Tu valor de parámetro
    this.router.navigate(['/PersonaNaturalMain', id]);
  }

  GetAllItems() {
    this.personanaturalServiceService.GetAllItems().subscribe(
      respuesta => {
        this.ListaMainItems = respuesta;
        this.GetlistaOrdenar();
      }
    )

  }
  GetlistaOrdenar() {
    this.ListaMainItems.sort((a, b) => b.PersonaNaturalId - a.PersonaNaturalId);

    this.ListaMainItems.forEach((cargo, index) => {
      cargo.Item = index + 1;
    });

  }

  showDialog() {
    this.visibleVentena = true;
  }

  navigateToDestino() {
    this.router.navigate(['/PersonaNaturalSave', 0]);
  }
  Delete_Metho(Id: number) {
    this.router.navigate(['/PersonaNaturalSave', Id]);
   



  }
}
