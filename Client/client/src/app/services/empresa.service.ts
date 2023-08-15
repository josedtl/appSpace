import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import {EmpresaEntity} from '../models/EmpresaEntity'

@Injectable({
  providedIn: 'root'
})
export class EmpresaService {

  API_URI = 'http://localhost:8080';
  constructor(private http: HttpClient) {}

    getEmpresa() {
    return this.http.get(`${this.API_URI}/api/Empresa/getEmpresaItems`);
  }
  }

