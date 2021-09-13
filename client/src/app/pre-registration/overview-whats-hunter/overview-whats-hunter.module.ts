import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { OverviewWhatsHunterRoutingModule } from './overview-whats-hunter-routing.module';
import { OverviewWhatsHunterComponent } from './overview-whats-hunter.component';


@NgModule({
  declarations: [
    OverviewWhatsHunterComponent
  ],
  imports: [
    CommonModule,
    OverviewWhatsHunterRoutingModule
  ]
})
export class OverviewWhatsHunterModule { }
