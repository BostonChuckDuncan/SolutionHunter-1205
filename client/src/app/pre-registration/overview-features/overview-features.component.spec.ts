import { ComponentFixture, TestBed } from '@angular/core/testing';

import { OverviewFeaturesComponent } from './overview-features.component';

describe('OverviewFeaturesComponent', () => {
  let component: OverviewFeaturesComponent;
  let fixture: ComponentFixture<OverviewFeaturesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ OverviewFeaturesComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(OverviewFeaturesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
