import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { LoginFeatureComponent } from './login-feature/login-feature.component';
import { GoalOptionsComponent } from './goal-options/goal-options.component';
import { SignUpComponent } from './sign-up/sign-up.component';
import { UserDashboardComponent } from './user-dashboard/user-dashboard.component';
import { LandingPageComponent } from './landing-page/landing-page.component';
import { ColorpaletteComponent } from './colorpalette/colorpalette.component';
import { NgChartsModule } from 'ng2-charts';

@NgModule({
  declarations: [
    AppComponent,
    LoginFeatureComponent,
    GoalOptionsComponent,
    SignUpComponent,
    UserDashboardComponent,
    LandingPageComponent,
    ColorpaletteComponent,
  ],
<<<<<<< HEAD
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
    NgChartsModule,
  ],
=======
  
  imports: [BrowserModule, AppRoutingModule, FormsModule, HttpClientModule],
>>>>>>> ab54d5c195bf854938c591851644b8ece62a4336
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
