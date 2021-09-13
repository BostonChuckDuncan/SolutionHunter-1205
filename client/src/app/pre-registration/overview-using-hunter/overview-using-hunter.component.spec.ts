import { ComponentFixture, TestBed } from '@angular/core/testing';

import { OverviewUsingHunterComponent } from './overview-using-hunter.component';

describe('OverviewUsingHunterComponent', () => {
  let component: OverviewUsingHunterComponent;
  let fixture: ComponentFixture<OverviewUsingHunterComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ OverviewUsingHunterComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(OverviewUsingHunterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
