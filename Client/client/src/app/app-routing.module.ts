import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { TipoElementoMainComponent } from './components/tipo-elemento-main/tipo-elemento-main.component';
import { TipoInfraestructuraMainComponent } from './components/tipo-infraestructura-main/tipo-infraestructura-main.component';



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
    path: 'TipoInfraestructuraMain',
    component: TipoInfraestructuraMainComponent
  },
 
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
