import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { TipoElementoMainComponent } from './components/tipo-elemento-main/tipo-elemento-main.component';
import { TipoElementoSaveComponent } from './components/tipo-elemento-save/tipo-elemento-save.component';

import { TipoElementoServiceService } from './services/tipo-elemento-service.service';

@NgModule({
  declarations: [
    AppComponent,
    TipoElementoMainComponent,
    TipoElementoSaveComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [TipoElementoServiceService],
  bootstrap: [AppComponent]
})
export class AppModule { }
