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
import { EmpresaService } from './services/empresa.service';
import { CargoService } from './services/cargo.service';
import { TipoInfraestructuraMainComponent } from './components/tipo-infraestructura-main/tipo-infraestructura-main.component';
import { SidebarMenuComponent } from './components/Menu/sidebar-menu/sidebar-menu.component';
import { NavigationComponent } from './components/Menu/navigation/navigation.component';
import { PersonaNaturalMainComponent } from './components/persona-natural-main/persona-natural-main.component';
import { EmpresaMainComponent } from './components/empresa-main/empresa-main.component';
import { CargoMainComponent } from './components/cargo-main/cargo-main.component';
import { InfraestructuraMainComponent } from './components/Infraestructura/infraestructura-main/infraestructura-main.component';
import { InfraestructuraSaveComponent } from './components/Infraestructura/infraestructura-save/infraestructura-save.component';

@NgModule({
  declarations: [
    AppComponent,
    TipoElementoMainComponent,
    TipoInfraestructuraMainComponent,
    SidebarMenuComponent,
    NavigationComponent,
    PersonaNaturalMainComponent,
    EmpresaMainComponent,
    CargoMainComponent,
    InfraestructuraMainComponent,
    InfraestructuraSaveComponent
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
