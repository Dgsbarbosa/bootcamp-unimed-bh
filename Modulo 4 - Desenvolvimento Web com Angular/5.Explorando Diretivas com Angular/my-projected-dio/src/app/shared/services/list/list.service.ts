import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

export type ApiResponse = {
  info:{},
  results:{},
}

@Injectable({
  providedIn: 'root'
})
export class ListService {

  apiUrl= 'https://rickandmortyapi.com/api/character';

  constructor(private httpCliente: HttpClient) { }

  getList():Observable<any>{

    return this.httpCliente.get<any>(this.apiUrl)

  }
}
