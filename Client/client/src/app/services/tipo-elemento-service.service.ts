import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { TipoElementoEntity } from '../models/TipoElementoEntity'

@Injectable({
  providedIn: 'root'
})
export class TipoElementoServiceService {


  API_URI = 'http://localhost:8080';

  constructor(private http: HttpClient) { }

  getTipoElemento() {
    return this.http.get(`${this.API_URI}/api/TipoElemento/GetAllItems`);
  }

  saveTipoElemento(item: TipoElementoEntity) {
    return this.http.post(`${this.API_URI}/api/TipoElemento/Save`, item);
  }
  deleteTipoElemento(id: number) {
    return this.http.delete(`${this.API_URI}/api/TipoElemento/Delete/${id}`);
  }

}
