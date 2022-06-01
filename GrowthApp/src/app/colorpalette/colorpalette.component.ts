import { Component, OnInit } from '@angular/core';
import { Chart, registerables } from 'chart.js';
Chart.register(...registerables);

@Component({
  selector: 'app-colorpalette',
  templateUrl: './colorpalette.component.html',
  styleUrls: ['./colorpalette.component.css'],
})
export class ColorpaletteComponent implements OnInit {
  constructor() {}

  ngOnInit(): void {}
}
