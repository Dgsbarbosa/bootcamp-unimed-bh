import { Directive, ElementRef, Input, OnInit } from '@angular/core';

@Directive({
  selector: '[spaMarcaTexto]'
})
export class MarcaTextoDirective implements OnInit{
  @Input() corDeFundo : string = 'yellow';
  @Input() corDoTexto: string = 'black';

  constructor(private elemento: ElementRef) { }

  ngOnInit(){
    this.mudarFundo();
  }

  private mudarFundo(cor: string = 'yellow'){
    this.elemento.nativeElement.style.backgroundColor = this.corDeFundo || cor;
    this.elemento.nativeElement.style.color = this.corDoTexto;
    this.elemento.nativeElement.style.fontWeight = 'bold'
  }
}
