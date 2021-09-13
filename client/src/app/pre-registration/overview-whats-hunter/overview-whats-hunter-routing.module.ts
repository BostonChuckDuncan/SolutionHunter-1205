import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { OverviewWhatsHunterComponent } from './overview-whats-hunter.component';

const routes: Routes = [{ path: '', component: OverviewWhatsHunterComponent }];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class OverviewWhatsHunterRoutingModule { }
