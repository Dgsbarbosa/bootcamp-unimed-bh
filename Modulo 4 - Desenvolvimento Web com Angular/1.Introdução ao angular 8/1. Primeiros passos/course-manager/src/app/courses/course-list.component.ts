// Informando que a classe sera um componente

import { Component, OnInit } from "@angular/core";
import { Course } from "./course";
import { CourseService } from "./course.service";

//Caracteristicas do componente

@Component({
    template:'<h2> Course List</h2>', // template estatico
    templateUrl:'./course-list.component.html' // template fora do componente
})

//usando CamelCase na estrutura do nome
export class CourseListComponent implements OnInit{

    

    //quando se usa _ na frente da variavel significa que ela será apenas deste componente

    filteredCourses: Course[] = []
    _courses: Course[] =  [];

    _filterBy!: string; //criando a variavel para o filtro

    //injeção do service
    constructor(private courseService : CourseService){

    }

    ngOnInit(): void{
        this.retrieveAll();
        
                
}

// trabalhando com http
    retrieveAll(): void{
        this.courseService.retrieveAll().subscribe({
           next: courses =>{
            this._courses = courses;
            this.filteredCourses = this._courses
           },
           error: err => console.log('Error', err)
            
        })
        
    }


    //criando o input filter
    set filter(value: string){
        this._filterBy = value;
        this.filteredCourses = this._courses.filter((course: Course) => course.name.toLocaleLowerCase().indexOf(this._filterBy.toLocaleLowerCase()) > -1)
        this.filteredCourses = this._courses.filter((course: Course) => course.code.toLocaleLowerCase().indexOf(this._filterBy.toLocaleLowerCase()) > -1)
    }
    get filter(){
        return this._filterBy;
    }


}