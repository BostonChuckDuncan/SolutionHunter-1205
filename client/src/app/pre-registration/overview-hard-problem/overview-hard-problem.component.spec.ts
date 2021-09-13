import { ComponentFixture, TestBed } from '@angular/core/testing';

import { OverviewHardProblemComponent } from './overview-hard-problem.component';

describe('OverviewHardProblemComponent', () => {
  let component: OverviewHardProblemComponent;
  let fixture: ComponentFixture<OverviewHardProblemComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ OverviewHardProblemComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(OverviewHardProblemComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
