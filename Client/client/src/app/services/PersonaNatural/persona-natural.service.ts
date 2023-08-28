import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { PersonaNaturalSaveModel } from '../../models/PersonaNatural/PersonaNaturalSaveModel'
import { Observable } from 'rxjs/internal/Observable';
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
}
