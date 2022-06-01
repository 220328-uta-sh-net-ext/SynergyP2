import { Component, OnInit } from '@angular/core';

import { NgModule } from '@angular/core';

@Component({
  selector: 'app-sign-up',
  templateUrl: './sign-up.component.html',
  styleUrls: ['./sign-up.component.css'],
})
export class SignUpComponent implements OnInit {
  Username: string = "";
  Password: string = "";
  PhoneNumber: string = "";
  Email: string = "";

  constructor()  {
    console.log("sign up page constructed")
  }
  
  onSubmit(): void  {
    console.log(this.Username, this.Password);
  }

  ngOnInit(): void  {
    console.log("sign up component initialized");
  }
}
