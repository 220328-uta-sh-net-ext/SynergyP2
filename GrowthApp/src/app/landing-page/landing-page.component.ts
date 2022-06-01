import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-landing-page',
  templateUrl: './landing-page.component.html',
  styleUrls: ['./landing-page.component.css'],
})
export class LandingPageComponent implements OnInit {
  title: string = 'Growth';
  constructor() {}

  ngOnInit(): void {
    // fetch('https://motivational-quotes1.p.rapidapi.com/motivation', options)
    //   .then((response) => response.json())
    //   .then((response) => console.log(response))
    //   .catch((err) => console.error(err));
  }

  signUp() {
    console.log('signing up');
  }

  logIn() {
    console.log('logging in');
  }
}
