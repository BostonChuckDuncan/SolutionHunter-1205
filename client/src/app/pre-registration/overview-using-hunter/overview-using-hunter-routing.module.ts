import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { OverviewUsingHunterComponent } from './overview-using-hunter.component';

const routes: Routes = [{ path: '', component: OverviewUsingHunterComponent }];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class OverviewUsingHunterRoutingModule { }
