import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { PersonaNaturalSaveModel } from '../../models/PersonaNatural/PersonaNaturalSaveModel'
import { PersonaNaturalMainModel } from '../../models/PersonaNatural/PersonaNaturalMainModel'

import { Observable } from 'rxjs/internal/Observable';
import { PersonaNaturalMedioComunicacionSaveModel } from '../../models/PersonaNatural/PersonaNaturalMedioComunicacionSaveModel';
@Injectable({
  providedIn: 'root'
})
export class PersonaNaturalService {

  API_URI = 'http://localhost:8080';


  constructor(private http: HttpClient) { }

  GetAllItems(): Observable<PersonaNaturalSaveModel[]> {
    return this.http.get<PersonaNaturalSaveModel[]>(`${this.API_URI}/api/PersonaNatural/GetAllItems`);
  }

  GetAllItem(id: number): Observable<PersonaNaturalSaveModel[]> {
    return this.http.get<PersonaNaturalSaveModel[]>(`${this.API_URI}/api/PersonaNatural/GetAllItem/${id}`);
  }


  save(item: PersonaNaturalSaveModel): Observable<PersonaNaturalSaveModel> {
    return this.http.post<PersonaNaturalSaveModel>(`${this.API_URI}/api/PersonaNatural/Save`, item);
  }
  delete(id: number): Observable<boolean> {
    return this.http.delete<boolean>(`${this.API_URI}/api/PersonaNatural/Delete/${id}`);
  }

  GetPersonaNaturalMainItems(): Observable<PersonaNaturalMainModel[]> {
    return this.http.get<PersonaNaturalMainModel[]>(`${this.API_URI}/api/PersonaNatural/GetPersonaNaturalMainItems`);
  }

  GetMedioComunicacionDetalle(id: number): Observable<PersonaNaturalMedioComunicacionSaveModel[]> {
    return this.http.get<PersonaNaturalMedioComunicacionSaveModel[]>(`${this.API_URI}/api/PersonaNatural/GetMedioComunicacionDetalle/${id}`);
  }


}
