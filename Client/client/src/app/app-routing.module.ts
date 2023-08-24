import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { TipoElementoMainComponent } from './components/tipo-elemento-main/tipo-elemento-main.component';
import { CargoMainComponent } from './components/cargo-main/cargo-main.component'
import { ServicioBasicoMainComponent} from './components/servicio-basico-main/servicio-basico-main.component'
import { PisoMainComponent} from './components/piso-main/piso-main.component'
import {InfraestructuraMainComponent } from './components/infraestructura-main/infraestructura-main.component'
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
    component: PisoMainComponent
  },
  {
    path: 'ServicioBasicoMain',
    component: ServicioBasicoMainComponent
  },
  { path: 'InfraestructuraMain',
  component: InfraestructuraMainComponent
  }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
