import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'goal-options',
  templateUrl: './goal-options.component.html',
  styleUrls: ['./goal-options.component.css']
})
export class GoalOptionsComponent implements OnInit {
  title: string = "Growth";
  

  constructor() { }

  ngOnInit(): void {
  }
  signUp() {
 
    console.log('signing up');
    
  }
  logIn() {
    console.log('logging in');

  }

}
