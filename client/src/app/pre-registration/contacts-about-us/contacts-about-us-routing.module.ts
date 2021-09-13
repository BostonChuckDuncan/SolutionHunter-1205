import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ContactsAboutUsComponent } from './contacts-about-us.component';

const routes: Routes = [{ path: '', component: ContactsAboutUsComponent }];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ContactsAboutUsRoutingModule { }
