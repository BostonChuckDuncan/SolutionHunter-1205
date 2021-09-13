import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { GuidesResearchComponent } from './guides-research.component';

const routes: Routes = [{ path: '', component: GuidesResearchComponent }];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class GuidesResearchRoutingModule { }
