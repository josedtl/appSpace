import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms'; // Importa FormsModule
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

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
import { ServicioBasicoComponent } from './components/servicio-basico/servicio-basico.component';
@NgModule({
  declarations: [
    AppComponent,
    TipoElementoMainComponent,
    SidebarMenuComponent,
    NavigationComponent,
    CargoMainComponent,
<<<<<<< HEAD
<<<<<<< HEAD
    InfraestructuraMainComponent,
    InfraestructuraSaveComponent,
    PisoMainComponent,
    ServicioBasicoComponent
=======
>>>>>>> bbff5187de9923c35e318af09c914c183f04721a
=======
    PisoMainComponent
>>>>>>> 25c85f7ff19c903fc1a072b2adbee6ab8b872073
  ],
  imports: [
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
    ConfirmDialogModule, ConfirmPopupModule,ToolbarModule,ToastModule,PanelMenuModule,SidebarModule],
  providers: [ConfirmationService, MessageService],
  bootstrap: [AppComponent]
})
export class AppModule { }
