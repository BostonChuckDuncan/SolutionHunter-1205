import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ContactsUsSupportComponent } from './contacts-us-support.component';

describe('ContactsUsSupportComponent', () => {
  let component: ContactsUsSupportComponent;
  let fixture: ComponentFixture<ContactsUsSupportComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ContactsUsSupportComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ContactsUsSupportComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
