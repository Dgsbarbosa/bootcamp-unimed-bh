import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';

//Importe Formulario
import { FormsModule } from '@angular/forms';

//Importando um componente
import { CourseListComponent } from './courses/course-list.component';
import { StarComponent } from './star/star.component';
import { ReplacePipe } from './pipe/replace.pipe';
import { NavBarComponent } from './nav-bar/nav-bar.components';

//modulo de rotas do angular
import { RouterModule } from '@angular/router';
import { Error404Component } from './error-404/error-404.component';
import { CourseInfoComponent } from './courses/course-info.components';

// modulo Http

import {HttpClientModule} from '@angular/common/http' 


@NgModule({
  declarations: [
    AppComponent,
    CourseListComponent,
    StarComponent,
    ReplacePipe,
    NavBarComponent,
    Error404Component,
    CourseInfoComponent   
    
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,

    //rotas
    RouterModule.forRoot([
      
      {
        path: 'courses' , component: CourseListComponent
      },
      {
        path: 'courses/info/:id', component: CourseInfoComponent
      },
      {
        path: '', redirectTo: 'courses', pathMatch: 'full'
      },

      {
        path: '**', component: Error404Component

      }
    ])
  ],

  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
