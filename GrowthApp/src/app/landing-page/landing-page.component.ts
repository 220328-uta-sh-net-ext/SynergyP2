import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-landing-page',
  templateUrl: './landing-page.component.html',
  styleUrls: ['./landing-page.component.css'],
})
export class LandingPageComponent implements OnInit {
  title: string = 'Growth';
  constructor() {}

  ngOnInit(): void {}

  signUp() {
    console.log('signing up');
  }

  logIn() {
    console.log('logging in');
  }
}
