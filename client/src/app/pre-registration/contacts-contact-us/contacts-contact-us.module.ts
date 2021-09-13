import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ContactsContactUsRoutingModule } from './contacts-contact-us-routing.module';
import { ContactsContactUsComponent } from './contacts-contact-us.component';


@NgModule({
  declarations: [
    ContactsContactUsComponent
  ],
  imports: [
    CommonModule,
    ContactsContactUsRoutingModule
  ]
})
export class ContactsContactUsModule { }
