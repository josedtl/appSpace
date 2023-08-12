import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class TipoElementoServiceService {


  API_URI = 'http://localhost:8080';

  constructor(private http: HttpClient) { }

  getTipoElemento() {
    return this.http.get(`${this.API_URI}/api/TipoElemento/GetTipoElementoItems`);
  }


 
}
