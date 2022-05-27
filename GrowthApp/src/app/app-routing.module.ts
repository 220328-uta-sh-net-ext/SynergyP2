import { NgModule } from '@angular/core';
import { RouterModule, ROUTES } from '@angular/router';
import { CommonModule } from "@angular/common";

const routes =  [{path: 'src/app/login-feature', redirectTo : '/login-feature', pathMatch: 'full'},
//{path: 'home', component: },
//{path :}
];

@NgModule({
  declarations: [],
  imports: [CommonModule, RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
