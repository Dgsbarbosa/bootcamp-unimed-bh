// Informando que a classe sera um componente

import { Component } from "@angular/core";

//Caracteristicas do componente

@Component({
    selector: 'app-course-list',
    template:'<h2> Course List</h2>', // template estatico
    templateUrl:'./course-list.component.html' // template fora do componente
})

//usando CamelCase na estrutura do nome
export class CourseListComponent{}