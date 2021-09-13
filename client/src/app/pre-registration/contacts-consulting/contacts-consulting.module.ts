import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ContactsConsultingRoutingModule } from './contacts-consulting-routing.module';
import { ContactsConsultingComponent } from './contacts-consulting.component';


@NgModule({
  declarations: [
    ContactsConsultingComponent
  ],
  imports: [
    CommonModule,
    ContactsConsultingRoutingModule
  ]
})
export class ContactsConsultingModule { }
