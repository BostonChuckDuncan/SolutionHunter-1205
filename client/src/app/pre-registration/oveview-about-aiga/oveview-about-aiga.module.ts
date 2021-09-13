import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { OveviewAboutAigaRoutingModule } from './oveview-about-aiga-routing.module';
import { OveviewAboutAigaComponent } from './oveview-about-aiga.component';


@NgModule({
  declarations: [
    OveviewAboutAigaComponent
  ],
  imports: [
    CommonModule,
    OveviewAboutAigaRoutingModule
  ]
})
export class OveviewAboutAigaModule { }
