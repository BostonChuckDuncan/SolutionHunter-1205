import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { OverviewUsingHunterRoutingModule } from './overview-using-hunter-routing.module';
import { OverviewUsingHunterComponent } from './overview-using-hunter.component';


@NgModule({
  declarations: [
    OverviewUsingHunterComponent
  ],
  imports: [
    CommonModule,
    OverviewUsingHunterRoutingModule
  ]
})
export class OverviewUsingHunterModule { }
