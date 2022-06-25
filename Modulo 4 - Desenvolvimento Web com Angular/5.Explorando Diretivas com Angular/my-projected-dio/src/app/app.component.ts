import { Component, OnInit } from '@angular/core';
import { PeopleService } from './shared/services/people.service';

@Component({
  selector: 'spa-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  count = 0;
  nome = "Douglas Alexandre Barbosa"
  text = '';


  pessoas = [
    {
      nome: 'Douglas',
      sobrenome:'Barbosa'
    },
    {
      nome: 'Sabrina',
      sobrenome:'Barbosa'
    },
    {
      nome: 'Maria',
      sobrenome:'Eduarda'
    },
    {
      nome: 'Maria',
      sobrenome:'Victória'
    },
    {
      nome: 'Leonardo',
      sobrenome:'Barbosa'
    }
  ]

  pessoas2 = [
    {
      firstName: '',
      lastName: '',
      age: 0
    },
  ]
  
  constructor(private peopleSevice: PeopleService){

  }

  ngOnInit(): void {
    let interval = setInterval(()=> {
      this.count++;
      if(this.count === 10){
        clearInterval(interval);
      }
      

    },1000)


    this.getPeople();
  }

  clicou(nome: string): void{
    console.log('Você clicou em mim', nome);
    
  }
  
  getPeople(){
    this.peopleSevice.getPeople().subscribe(people => {
      this.pessoas2 = people;
    })
  }

}
