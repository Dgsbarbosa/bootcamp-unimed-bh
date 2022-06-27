import { Component, OnInit, NgModule } from '@angular/core';

@Component({
  selector: 'app-data-binding',
  templateUrl: './data-binding.component.html',
  styleUrls: ['./data-binding.component.css']
})
export class DataBindingComponent implements OnInit {
  
  //criando variavel nome
  nome = 'Douglas';
  sobrenome = 'Barbosa'
  imageUrl = 'http://picsum.photos/300/300'
  familia = ['Douglas' , 'Sabrina', 'Duda', 'Leo', 'Vic' ]
  buttonText = 'Clique aqui';
  textRed = false;
  bgColor ='green'
  fontSize='20px'
  textColor='white'
  widthImg = 600;
  textInput = '';


  constructor() { }

  ngOnInit(): void {
  }


  // metodo retorna nome

  retornaSobrenome(){
    return this.sobrenome
  }

  clicou(){
    this.nome = this.familia[1]
    console.log('clicou aqui');
    this.textRed = true;  
     
                                     
  }
  digitouAqui(value:any){
    console.log(value);
  }

}
