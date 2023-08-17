import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { PersonaNaturalEntity } from '../models/PersonaNaturalEntity'

@Injectable({
  providedIn: 'root'
})
export class PersonanaturalService {

  API_URI = 'http://localhost:8080';
  
  constructor(private http: HttpClient) { }

  Getpersonanatural() {
    return this.http.get(`${this.API_URI}/api/PersonaNatural/GetAllItems`);
  }
  Save(item: PersonaNaturalEntity) {
    return this.http.post(`${this.API_URI}/api/PersonaNatural/Save`, item);
  }
  
}
