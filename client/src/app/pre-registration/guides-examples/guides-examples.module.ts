import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { GuidesExamplesRoutingModule } from './guides-examples-routing.module';
import { GuidesExamplesComponent } from './guides-examples.component';


@NgModule({
  declarations: [
    GuidesExamplesComponent
  ],
  imports: [
    CommonModule,
    GuidesExamplesRoutingModule
  ]
})
export class GuidesExamplesModule { }
