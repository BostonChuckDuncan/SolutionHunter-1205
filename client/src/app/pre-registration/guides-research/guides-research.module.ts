import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { GuidesResearchRoutingModule } from './guides-research-routing.module';
import { GuidesResearchComponent } from './guides-research.component';


@NgModule({
  declarations: [
    GuidesResearchComponent
  ],
  imports: [
    CommonModule,
    GuidesResearchRoutingModule
  ]
})
export class GuidesResearchModule { }
