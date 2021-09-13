import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { OverviewFeaturesComponent } from './overview-features.component';

const routes: Routes = [{ path: '', component: OverviewFeaturesComponent }];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class OverviewFeaturesRoutingModule { }
