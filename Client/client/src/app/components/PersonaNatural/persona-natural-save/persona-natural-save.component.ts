import { Component } from '@angular/core';
import { ButtonStyles } from '../../../models/StylesPrime';

@Component({
  selector: 'app-persona-natural-save',
  templateUrl: './persona-natural-save.component.html',
  styleUrls: ['./persona-natural-save.component.css']
})
export class PersonaNaturalSaveComponent {
  buttonStyle = ButtonStyles.primary;
}
