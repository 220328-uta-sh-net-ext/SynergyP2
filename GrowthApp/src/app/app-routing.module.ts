import { NgModule } from '@angular/core';
import { RouterModule, ROUTES } from '@angular/router';
// { CommonModule } from "@angular/common";
import { GoalOptionsComponent } from './goal-options/goal-options.component';
import { LoginFeatureComponent } from './login-feature/login-feature.component';

const routes = [
   //{ path: 'src/app/login-feature', redirectTo: '/login-feature', pathMatch: 'full' },
{path: 'login', component: LoginFeatureComponent}
//{path :}
];

@NgModule({
  //declarations: [],
  //imports: [CommonModule, RouterModule.forRoot(routes)],
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
