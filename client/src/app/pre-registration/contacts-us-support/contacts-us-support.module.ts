import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ContactsUsSupportRoutingModule } from './contacts-us-support-routing.module';
import { ContactsUsSupportComponent } from './contacts-us-support.component';


@NgModule({
  declarations: [
    ContactsUsSupportComponent
  ],
  imports: [
    CommonModule,
    ContactsUsSupportRoutingModule
  ]
})
export class ContactsUsSupportModule { }
