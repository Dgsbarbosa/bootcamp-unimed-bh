import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './pages/home/home/home.component';
import { UserListComponent } from './pages/users/user-list/user-list.component';
import { UsersFormComponent } from './pages/users/users-form/users-form.component';

const routes: Routes = [
  {path:'list', component:UserListComponent},
  {path:'form', component: UsersFormComponent},
  {path:'home', component:HomeComponent},
  { path: 'form/:id', component: UsersFormComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
