import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-sign-up',
  templateUrl: './sign-up.component.html',
  styleUrls: ['./sign-up.component.css'],
})
export class SignUpComponent implements OnInit {
  username: string = '';
  password: string = '';

  constructor()  {
    console.log("sign up page constructed")
  }
  
  onSubmit(): void  {
    console.log(this.username, this.password);
  }

  ngOnInit(): void  {
    console.log("sign up component initialized");
  }
}