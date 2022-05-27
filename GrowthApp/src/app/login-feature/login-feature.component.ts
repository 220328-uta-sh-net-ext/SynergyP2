import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-login-feature',
  templateUrl: './login-feature.component.html',
  styleUrls: ['./login-feature.component.css']
})
export class LoginFeatureComponent implements OnInit {

  username : string = "";
  password : string = "";

  //error : boolean = false;

  onSubmit() : void{
    console.log(this.username, this.password)
  }
  constructor() {
    console.log("Login page constructed");
   }

  ngOnInit(): void {
    console.log("Login Page initialized");
  }

}
