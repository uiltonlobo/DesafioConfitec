import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class OperacoesService {
  uri = 'http://localhost:5000/api/operacoes';
  
  constructor(private http: HttpClient) { }

  somar(valor1, valor2) {
    return this.http.get(`${this.uri}/somar/${valor1}/${valor2}`);
  }

  subtrair(valor1: any, valor2: any) {
    return this.http.get(`${this.uri}/subtrair/${valor1}/${valor2}`);
  }

  multiplicar(valor1: any, valor2: any) {
    return this.http.get(`${this.uri}/multiplicar/${valor1}/${valor2}`);
  }

  dividir(valor1: any, valor2: any) {
    return this.http.get(`${this.uri}/dividir/${valor1}/${valor2}`);
  }
}
