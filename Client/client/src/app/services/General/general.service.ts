import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import {  TipoDocumentoIdentidadItemModel} from '../../models/General/TipoDocumentoIdentidadItemModel'
import { Observable } from 'rxjs/internal/Observable';
@Injectable({
  providedIn: 'root'
})
export class GeneralService {

  API_URI = 'http://localhost:8080';

  constructor(private http: HttpClient) { }

  GetTipoDocuemntoIdentidadPersonaItems(): Observable<TipoDocumentoIdentidadItemModel[]> {
    return this.http.get<TipoDocumentoIdentidadItemModel[]>(`${this.API_URI}/api/General/GetTipoDocuemntoIdentidadPersonaItems`);
  }

}
