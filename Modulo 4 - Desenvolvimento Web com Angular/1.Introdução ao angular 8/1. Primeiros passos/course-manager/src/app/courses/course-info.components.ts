import { Component, OnInit } from "@angular/core";
import { ActivatedRoute } from "@angular/router";
import { Course } from "./course";
import { CourseService } from "./course.service";

@Component({
    templateUrl: './course-info.components.html'
})

export class CourseInfoComponent implements OnInit{
    course!: Course;

    constructor(private activatedRoute: ActivatedRoute, private courseService: CourseService) { }

    ngOnInit(): void {
        this.courseService.retrieveById(+this.activatedRoute.snapshot.paramMap.get('id')!).subscribe({
            next: course => this.course = course,
            error: err => console.log('Error', err)
            
        });
        
    }
}