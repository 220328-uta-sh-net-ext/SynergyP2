import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'goal-options',
  templateUrl: './goal-options.component.html',
  styleUrls: ['./goal-options.component.css']
})
export class GoalOptionsComponent implements OnInit {
  title: string = "Goal Options";
  

  constructor() { }

  ngOnInit(): void {
  }
  onClick() {
 
    console.log('Add custom goal');
    
  }

}
