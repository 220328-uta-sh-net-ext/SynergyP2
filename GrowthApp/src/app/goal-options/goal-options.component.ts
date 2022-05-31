import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'goal-options',
  templateUrl: './goal-options.component.html',
  styleUrls: ['./goal-options.component.css'],
})
export class GoalOptionsComponent implements OnInit {
  title: string = 'Goals Page';

  constructor() {}
  ngOnInit(): void {}
}
