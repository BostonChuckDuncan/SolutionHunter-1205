import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ContactsAboutUsRoutingModule } from './contacts-about-us-routing.module';
import { ContactsAboutUsComponent } from './contacts-about-us.component';


@NgModule({
  declarations: [
    ContactsAboutUsComponent
  ],
  imports: [
    CommonModule,
    ContactsAboutUsRoutingModule
  ]
})
export class ContactsAboutUsModule { }
