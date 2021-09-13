import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ContactsContactUsComponent } from './contacts-contact-us.component';

const routes: Routes = [{ path: '', component: ContactsContactUsComponent }];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ContactsContactUsRoutingModule { }
