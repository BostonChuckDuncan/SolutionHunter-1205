import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GuidesExamplesComponent } from './guides-examples.component';

describe('GuidesExamplesComponent', () => {
  let component: GuidesExamplesComponent;
  let fixture: ComponentFixture<GuidesExamplesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GuidesExamplesComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GuidesExamplesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
