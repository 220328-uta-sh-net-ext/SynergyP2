import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GoalsOptionsComponent } from './goals-options.component';

describe('GoalsOptionsComponent', () => {
  let component: GoalsOptionsComponent;
  let fixture: ComponentFixture<GoalsOptionsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GoalsOptionsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GoalsOptionsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
