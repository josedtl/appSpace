import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { CargoEntity } from '../models/CargoEntity'

@Injectable({
  providedIn: 'root'
})
export class CargoService {

  API_URI = 'http://localhost:8080';

  constructor(private http: HttpClient) { }
  
  getCargo() {
    return this.http.get(`${this.API_URI}/api/Cargo/GetAllItems`);
  }
  save(item: CargoEntity) {
    return this.http.post(`${this.API_URI}/api/Cargo/Save`, item);
  }
  delete(id: number) {
    return this.http.delete(`${this.API_URI}/api/Cargo/Delete/${id}`);
  }
}
