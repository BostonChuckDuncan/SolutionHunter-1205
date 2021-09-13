import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ContactsAboutUsComponent } from './contacts-about-us.component';

describe('ContactsAboutUsComponent', () => {
  let component: ContactsAboutUsComponent;
  let fixture: ComponentFixture<ContactsAboutUsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ContactsAboutUsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ContactsAboutUsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
