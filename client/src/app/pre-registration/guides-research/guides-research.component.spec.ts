import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GuidesResearchComponent } from './guides-research.component';

describe('GuidesResearchComponent', () => {
  let component: GuidesResearchComponent;
  let fixture: ComponentFixture<GuidesResearchComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GuidesResearchComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GuidesResearchComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
