import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ContactsConsultingComponent } from './contacts-consulting.component';

const routes: Routes = [{ path: '', component: ContactsConsultingComponent }];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ContactsConsultingRoutingModule { }
