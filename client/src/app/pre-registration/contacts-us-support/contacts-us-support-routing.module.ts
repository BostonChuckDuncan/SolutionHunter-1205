import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ContactsUsSupportComponent } from './contacts-us-support.component';

const routes: Routes = [{ path: '', component: ContactsUsSupportComponent }];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ContactsUsSupportRoutingModule { }
