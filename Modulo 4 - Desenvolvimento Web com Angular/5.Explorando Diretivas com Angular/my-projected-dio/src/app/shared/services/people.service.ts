import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class PeopleService {

  constructor() { }

  getPeople(): Observable<any>{
    let peopleArray = [
      {
        firstName: 'Douglas',
        lastName: 'Barbosa',
        age: 34

      },
      {
      firstName: 'Sabrina',
      lastName: 'Barbosa',
      age: 29
    },
      {
      firstName: 'Maria Eduarda',
      lastName: 'Barbosa',
      age: 11
      },
    
      {
        firstName: 'Leonardo',
        lastName: 'Barbosa',
        age: 10
      },
      {
        firstName: 'Maria Victória',
        lastName: 'Barbosa',
        age: 7
      },
    ]
    return of(peopleArray)
  }
}
