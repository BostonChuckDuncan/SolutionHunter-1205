import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SplashPageComponent } from './SplashPage/SplashPage.component';
import { SplashPagePostComponent } from './SplashPagePost/SplashPagePost/SplashPagePost.component';

const routes: Routes = [
  { path: '', redirectTo: 'splashPage', pathMatch: 'full' },
  { path: 'splashPage', component: SplashPageComponent, pathMatch: 'full' },
  {
    path: 'splashPagePost',
    component: SplashPagePostComponent,
    pathMatch: 'full',
  },

  //  ------ PreRegistration
  {
    path: 'whatishunter',
    loadChildren: () => import('./pre-registration/overview-whats-hunter/overview-whats-hunter.module')
      .then(m => m.OverviewWhatsHunterModule)
  },
  {
    path: 'hardproblem',
    loadChildren: () => import('./pre-registration/overview-hard-problem/overview-hard-problem.module')
      .then(m => m.OverviewHardProblemModule)
  },
  {
    path: 'features',
    loadChildren: () => import('./pre-registration/overview-features/overview-features.module')
      .then(m => m.OverviewFeaturesModule)
  },
  {
    path: 'usinghunter',
    loadChildren: () => import('./pre-registration/overview-using-hunter/overview-using-hunter.module')
      .then(m => m.OverviewUsingHunterModule)
  },
  {
    path: 'aboutAIGA',
    loadChildren: () => import('./pre-registration/oveview-about-aiga/oveview-about-aiga.module')
      .then(m => m.OveviewAboutAigaModule)
  },
  {
    path: 'examples',
    loadChildren: () => import('./pre-registration/guides-examples/guides-examples.module')
      .then(m => m.GuidesExamplesModule)
  },
  {
    path: 'aboutResearch',
    loadChildren: () => import('./pre-registration/guides-research/guides-research.module')
      .then(m => m.GuidesResearchModule)
  },
  {
    path: 'tutorials',
    loadChildren: () => import('./pre-registration/guides-tutorials/guides-tutorials.module')
      .then(m => m.GuidesTutorialsModule)
  },
  {
    path: 'aboutUs',
    loadChildren: () => import('./pre-registration/contacts-about-us/contacts-about-us.module')
      .then(m => m.ContactsAboutUsModule)
  },
  {
    path: 'consulting',
    loadChildren: () => import('./pre-registration/contacts-consulting/contacts-consulting.module')
      .then(m => m.ContactsConsultingModule)
  },
  {
    path: 'contactUs',
    loadChildren: () => import('./pre-registration/contacts-contact-us/contacts-contact-us.module')
      .then(m => m.ContactsContactUsModule)
  },
  {
    path: 'support',
    loadChildren: () => import('./pre-registration/contacts-us-support/contacts-us-support.module')
      .then(m => m.ContactsUsSupportModule)
  },

  // { path: 'errors', component: ErrorsComponent },
  // { path: 'not-found', component: NotFoundComponent },
  // { path: 'server-error', component: ServerErrorComponent },
  // { path: '**', component: NotFoundComponent, pathMatch: 'full'},

  // example:
  // { path: 'consulting', component: ConsultingComponent, canActivate: [AuthGuard, ...] },
];

@NgModule({
  imports: [RouterModule.forRoot(routes, { relativeLinkResolution: 'legacy' })],
  exports: [RouterModule]
})
export class AppRoutingModule { }
