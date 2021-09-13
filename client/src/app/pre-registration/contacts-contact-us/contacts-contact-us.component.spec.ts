import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ContactsContactUsComponent } from './contacts-contact-us.component';

describe('ContactsContactUsComponent', () => {
  let component: ContactsContactUsComponent;
  let fixture: ComponentFixture<ContactsContactUsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ContactsContactUsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ContactsContactUsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
