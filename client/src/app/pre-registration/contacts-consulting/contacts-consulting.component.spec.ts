import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ContactsConsultingComponent } from './contacts-consulting.component';

describe('ContactsConsultingComponent', () => {
  let component: ContactsConsultingComponent;
  let fixture: ComponentFixture<ContactsConsultingComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ContactsConsultingComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ContactsConsultingComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
