import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { LoginService } from '../login.service';

@Component({
  selector: 'app-login-feature',
  templateUrl: './login-feature.component.html',
  styleUrls: ['./login-feature.component.css']
})
export class LoginFeatureComponent implements OnInit {

  Username : string = "";
  Password : string = "";
  Email: string = "test@ihatemyjob.net";
  error: boolean = false;

  onSubmit(): void {
    console.log(this.Username, this.Password)
    this.LoginService.login(this.Username, this.Password, this.Email)
      .subscribe((data) => {
        console.log(data)
        this.LoginService.token = data.token;
        console.log(this.LoginService.token)
        this.router.navigate(['dashboard']);
      },
        (error) => {
          console.log(error)
          this.error = true;
        }
     )
  }
  constructor(private LoginService: LoginService, private router: Router) {
    console.log("Login page constructed");
   }

  ngOnInit(): void {
    console.log("Login Page initialized");
  }

}
