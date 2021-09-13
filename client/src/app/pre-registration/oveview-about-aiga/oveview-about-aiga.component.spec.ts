import { ComponentFixture, TestBed } from '@angular/core/testing';

import { OveviewAboutAigaComponent } from './oveview-about-aiga.component';

describe('OveviewAboutAigaComponent', () => {
  let component: OveviewAboutAigaComponent;
  let fixture: ComponentFixture<OveviewAboutAigaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ OveviewAboutAigaComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(OveviewAboutAigaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
