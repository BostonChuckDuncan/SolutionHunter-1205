import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { OverviewFeaturesRoutingModule } from './overview-features-routing.module';
import { OverviewFeaturesComponent } from './overview-features.component';


@NgModule({
  declarations: [
    OverviewFeaturesComponent
  ],
  imports: [
    CommonModule,
    OverviewFeaturesRoutingModule
  ]
})
export class OverviewFeaturesModule { }
