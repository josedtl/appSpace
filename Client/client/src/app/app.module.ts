import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms'; // Importa FormsModule

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { TipoElementoMainComponent } from './components/tipo-elemento-main/tipo-elemento-main.component';

import { TipoElementoServiceService } from './services/tipo-elemento-service.service';
import { TipoInfraestructuraService }from './services/tipo-infraestructura.service';
import {PersonanaturalService} from './services/personanatural.service';
import { TipoInfraestructuraMainComponent } from './components/tipo-infraestructura-main/tipo-infraestructura-main.component';
import { SidebarMenuComponent } from './components/Menu/sidebar-menu/sidebar-menu.component';
import { NavigationComponent } from './components/Menu/navigation/navigation.component';
import { PersonaNaturalMainComponent } from './components/persona-natural-main/persona-natural-main.component';

@NgModule({
  declarations: [
    AppComponent,
    TipoElementoMainComponent,
    TipoInfraestructuraMainComponent,
    SidebarMenuComponent,
    NavigationComponent,
    PersonaNaturalMainComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule 
  ],
  providers: [TipoElementoServiceService,TipoInfraestructuraService],
  bootstrap: [AppComponent]
})
export class AppModule { }
