import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { GuidesExamplesComponent } from './guides-examples.component';

const routes: Routes = [{ path: '', component: GuidesExamplesComponent }];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class GuidesExamplesRoutingModule { }
