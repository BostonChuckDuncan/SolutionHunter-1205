import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { OverviewHardProblemComponent } from './overview-hard-problem.component';

const routes: Routes = [{ path: '', component: OverviewHardProblemComponent }];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class OverviewHardProblemRoutingModule { }
