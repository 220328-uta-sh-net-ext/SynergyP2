import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { GoalsOptionsComponent } from './goals-options/goals-options.component';
import { LoginFeatureComponent } from './login-feature/login-feature.component';

@NgModule({
  declarations: [
    AppComponent,
    GoalsOptionsComponent,
    LoginFeatureComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
