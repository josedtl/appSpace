import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms'; // Importa FormsModule
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { InputNumberModule } from 'primeng/inputnumber';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { TipoElementoMainComponent } from './components/tipo-elemento-main/tipo-elemento-main.component';

import { SidebarMenuComponent } from './components/Menu/sidebar-menu/sidebar-menu.component';
import { NavigationComponent } from './components/Menu/navigation/navigation.component';
import { CargoMainComponent } from './components/cargo-main/cargo-main.component';
import { ButtonModule } from 'primeng/button';
import { TableModule } from 'primeng/table';
import { DialogModule } from 'primeng/dialog';


import { InputTextModule } from 'primeng/inputtext';
import { StyleClassModule } from 'primeng/styleclass';
import { CardModule } from 'primeng/card';
import { PanelModule } from 'primeng/panel';
import { ConfirmDialogModule } from 'primeng/confirmdialog';
import { ConfirmPopupModule } from 'primeng/confirmpopup';
import { ToolbarModule } from 'primeng/toolbar';
import { ToastModule } from 'primeng/toast';
import { ConfirmationService, MessageService } from 'primeng/api';
import { PanelMenuModule } from 'primeng/panelmenu';
import { SidebarModule } from 'primeng/sidebar';
import { PisoMainComponent } from './components/piso-main/piso-main.component';

import { InputSwitchModule } from 'primeng/inputswitch';
import { ServicioBasicoMainComponent } from './components/servicio-basico-main/servicio-basico-main.component';
import { InfraestructuraMainComponent } from './components/infraestructura-main/infraestructura-main.component';
import { TabViewModule } from 'primeng/tabview';
import { PersonaNaturalSaveComponent } from './components/PersonaNatural/persona-natural-save/persona-natural-save.component';
import { PersonaNaturalMainComponent } from './components/PersonaNatural/persona-natural-main/persona-natural-main.component';

@NgModule({
  declarations: [
    AppComponent,
    TipoElementoMainComponent,
    SidebarMenuComponent,
    NavigationComponent,
    CargoMainComponent,
    PisoMainComponent,
    ServicioBasicoMainComponent,
    InfraestructuraMainComponent,
    PersonaNaturalSaveComponent,
    PersonaNaturalMainComponent
  ],
  imports: [
    InputNumberModule,
    TabViewModule,
    BrowserModule,
    BrowserAnimationsModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ButtonModule,
    TableModule,
    DialogModule,
    InputTextModule,
    StyleClassModule,
    CardModule,
    PanelModule,
    ConfirmDialogModule, ConfirmPopupModule,ToolbarModule,ToastModule,PanelMenuModule,SidebarModule,InputSwitchModule],
  providers: [ConfirmationService, MessageService],
  bootstrap: [AppComponent]
})
export class AppModule { }
