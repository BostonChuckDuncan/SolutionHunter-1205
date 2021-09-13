import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { GuidesTutorialsRoutingModule } from './guides-tutorials-routing.module';
import { GuidesTutorialsComponent } from './guides-tutorials.component';


@NgModule({
  declarations: [
    GuidesTutorialsComponent
  ],
  imports: [
    CommonModule,
    GuidesTutorialsRoutingModule
  ]
})
export class GuidesTutorialsModule { }
