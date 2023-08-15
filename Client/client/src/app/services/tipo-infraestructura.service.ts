import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { TipoInfraestructuraEntity } from '../models/TipoInfraestructuraEntity'

@Injectable({
  providedIn: 'root'
})
export class TipoInfraestructuraService {

  API_URI = 'http://localhost:8080';

  constructor(private http: HttpClient) { }
  
  getTipoInfraestructura() {
    return this.http.get(`${this.API_URI}/api/TipoInfraestructura/GetTipoInfraestructuraItems`);
  }


}
