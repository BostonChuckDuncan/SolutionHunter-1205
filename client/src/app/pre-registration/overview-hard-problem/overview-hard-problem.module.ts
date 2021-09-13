import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { OverviewHardProblemRoutingModule } from './overview-hard-problem-routing.module';
import { OverviewHardProblemComponent } from './overview-hard-problem.component';


@NgModule({
  declarations: [
    OverviewHardProblemComponent
  ],
  imports: [
    CommonModule,
    OverviewHardProblemRoutingModule
  ]
})
export class OverviewHardProblemModule { }
