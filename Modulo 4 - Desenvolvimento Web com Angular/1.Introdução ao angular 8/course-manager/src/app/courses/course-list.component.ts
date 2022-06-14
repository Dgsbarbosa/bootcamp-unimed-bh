// Informando que a classe sera um componente

import { Component, OnInit } from "@angular/core";
import { Course } from "./course";

//Caracteristicas do componente

@Component({
    selector: 'app-course-list',
    template:'<h2> Course List</h2>', // template estatico
    templateUrl:'./course-list.component.html' // template fora do componente
})

//usando CamelCase na estrutura do nome
export class CourseListComponent implements OnInit{

    courses: Course[] =  [];

    ngOnInit(): void{
        this.courses = [
        {
            id: 1,
            name: 'Angular Forms',
            imageUrl: './assets/images/forms.png',
            price: 99.99,
            code: 'xps-8796',
            duration: 120,
            rating: 4.5,
            releaseDate: 'December, 2, 2019',
    },
    {
            id: 2,
            name: 'Angular HTTP',
            imageUrl: './assets/images/http.png',
            price: 99.99,
            code: 'xps-8796',
            duration: 120,
            rating: 4,
            releaseDate: 'November, 3 , 2019',    

    }
    ]
}
}