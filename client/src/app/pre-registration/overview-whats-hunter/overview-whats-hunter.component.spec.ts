import { ComponentFixture, TestBed } from '@angular/core/testing';

import { OverviewWhatsHunterComponent } from './overview-whats-hunter.component';

describe('OverviewWhatsHunterComponent', () => {
  let component: OverviewWhatsHunterComponent;
  let fixture: ComponentFixture<OverviewWhatsHunterComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ OverviewWhatsHunterComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(OverviewWhatsHunterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
