


import { User } from 'src/app/models/user';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  apiUrl = 'https://sheet.best/api/sheets/658fffc8-d0a8-4cc6-8d48-c7ab047325ec'

  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json',
      
    })
  }

  constructor(private httpClient: HttpClient) { }

  // C.R.U.D - CREATE, READ, UPDATE, DELETE

  // Retorna a lista de usuarios READ
  getUsers():Observable <User[]> {
    return this.httpClient.get <User[]>(this.apiUrl)
  }

  //Salva usuario no banco de dados CREATE

  postUser(user: User):Observable<User>{
    return this.httpClient.post<User>(this.apiUrl, user, this.httpOptions)
  }

  // Deleta o usuario do banco DELETE
  deleteUser(id: number): Observable <User>{
    return this.httpClient.delete<User>(`${this.apiUrl}/id/${id}`)

  }

  //Edita usuario UPDATE

  updateUser(id: string, user:User):Observable <User>{
    return this.httpClient.put<User>(`${this.apiUrl}/id/${id}`, user, this.httpOptions)
  }

  //Lista Usuario unico

  getUser(id: string):Observable <User[]>{
    return this.httpClient.get<User[]>(`${this.apiUrl}/id/${id}`)

  }
}
