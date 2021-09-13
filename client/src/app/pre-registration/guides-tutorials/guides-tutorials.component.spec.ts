import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GuidesTutorialsComponent } from './guides-tutorials.component';

describe('GuidesTutorialsComponent', () => {
  let component: GuidesTutorialsComponent;
  let fixture: ComponentFixture<GuidesTutorialsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GuidesTutorialsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GuidesTutorialsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
