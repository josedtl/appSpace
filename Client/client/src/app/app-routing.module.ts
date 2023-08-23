import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { TipoElementoMainComponent } from './components/tipo-elemento-main/tipo-elemento-main.component';
import { CargoMainComponent } from './components/cargo-main/cargo-main.component'
import { ServicioBasicoComponent} from './components/servicio-basico/servicio-basico.component' 
import { PisoMainComponent} from './components/piso-main/piso-main.component'
const routes: Routes = [
  {
    path: '',
    redirectTo: '/home',
    pathMatch: 'full'
  },
  {
    path: 'TipoElementoMain',
    component: TipoElementoMainComponent
  },
 
  {
    path: 'cargoMain',
    component: CargoMainComponent
  }, {
    path: 'PisoMain',
    component: CargoMainComponent
  }


];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
