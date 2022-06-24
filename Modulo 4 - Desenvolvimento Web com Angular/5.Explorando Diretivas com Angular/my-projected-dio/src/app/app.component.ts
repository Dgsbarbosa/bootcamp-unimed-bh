import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'spa-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  count = 0;

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
  
  constructor(){

  }

  ngOnInit(): void {
    let interval = setInterval(()=> {
      this.count++;
      if(this.count === 10){
        clearInterval(interval);
      }
      

    },1000)
    console.log(this.pessoas);
  }
  
  

}
