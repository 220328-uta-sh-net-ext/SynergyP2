import { NgModule } from '@angular/core';
import { RouterModule, ROUTES } from '@angular/router';
// { CommonModule } from "@angular/common";
import { GoalOptionsComponent } from './goal-options/goal-options.component';
import { LoginFeatureComponent } from './login-feature/login-feature.component';
import { SignUpComponent } from './sign-up/sign-up.component';
import { LandingPageComponent } from './landing-page/landing-page.component';
import { UserDashboardComponent } from './user-dashboard/user-dashboard.component';

const routes = [
  //{ path: 'src/app/login-feature', redirectTo: '/login-feature', pathMatch: 'full' },
  {
    path: 'landingPage',
    component: LandingPageComponent,
  },
  {
    path: 'login',
    component: LoginFeatureComponent,
  },
  {
    path: 'signUp',
    component: SignUpComponent,
  },
  {
    path: 'dashboard',
    component: UserDashboardComponent,
  },
  {
    path: 'goals',
    component: GoalOptionsComponent,
  },
];

@NgModule({
  //declarations: [],
  //imports: [CommonModule, RouterModule.forRoot(routes)],
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
