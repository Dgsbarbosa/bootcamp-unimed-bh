import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';

//Importe Formulario
import { FormsModule } from '@angular/forms';

//Importando um componente
import { CourseListComponent } from './courses/course-list.component';

@NgModule({
  declarations: [
    AppComponent,
    CourseListComponent    
    
  ],
  imports: [
    BrowserModule,
    FormsModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
