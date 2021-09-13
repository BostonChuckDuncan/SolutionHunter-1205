import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { OveviewAboutAigaComponent } from './oveview-about-aiga.component';

const routes: Routes = [{ path: '', component: OveviewAboutAigaComponent }];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class OveviewAboutAigaRoutingModule { }
