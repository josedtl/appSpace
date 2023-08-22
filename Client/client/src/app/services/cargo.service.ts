import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { CargoEntity } from '../models/CargoEntity'
import { Observable } from 'rxjs/internal/Observable';

@Injectable({
  providedIn: 'root'
})
export class CargoService {

  API_URI = 'http://localhost:8080';

  constructor(private http: HttpClient) { }

  getCargo(): Observable<CargoEntity[]> {
    return this.http.get<CargoEntity[]>(`${this.API_URI}/api/Cargo/GetAllItems`);
  }
  
  save(item: CargoEntity): Observable<CargoEntity> {
    return this.http.post<CargoEntity>(`${this.API_URI}/api/Cargo/Save`, item);
  }
  delete(id: number): Observable<boolean> {
    return this.http.delete<boolean>(`${this.API_URI}/api/Cargo/Delete/${id}`);
  }
}
