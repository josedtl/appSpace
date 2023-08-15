import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { personanaturalEntity } from '../models/personanaturalEntity'

@Injectable({
  providedIn: 'root'
})
export class PersonanaturalService {

  API_URI = 'http://localhost:8080';
  
  constructor(private http: HttpClient) { }

  Getpersonanatural() {
    return this.http.get(`${this.API_URI}/api/personanatural/GetpersonanaturalItems`);
  }

}
