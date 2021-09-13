import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { OverviewFeaturesModule } from './overview-features/overview-features.module';
import { OverviewHardProblemModule } from './overview-hard-problem/overview-hard-problem.module';
import { OverviewUsingHunterModule } from './overview-using-hunter/overview-using-hunter.module';
import { OverviewWhatsHunterModule } from './overview-whats-hunter/overview-whats-hunter.module';
import { OveviewAboutAigaModule } from './oveview-about-aiga/oveview-about-aiga.module';
import { GuidesExamplesModule } from './guides-examples/guides-examples.module';
import { GuidesResearchModule } from './guides-research/guides-research.module';
import { GuidesTutorialsModule } from './guides-tutorials/guides-tutorials.module';
import { ContactsAboutUsModule } from './contacts-about-us/contacts-about-us.module';
import { ContactsConsultingModule } from './contacts-consulting/contacts-consulting.module';
import { ContactsContactUsModule } from './contacts-contact-us/contacts-contact-us.module';
import { ContactsUsSupportModule } from './contacts-us-support/contacts-us-support.module';



@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    ContactsAboutUsModule,
    ContactsConsultingModule,
    ContactsContactUsModule,
    ContactsUsSupportModule,
    GuidesExamplesModule,
    GuidesResearchModule,
    GuidesTutorialsModule,
    OverviewFeaturesModule,
    OverviewHardProblemModule,
    OverviewUsingHunterModule,
    OverviewWhatsHunterModule,
    OveviewAboutAigaModule
  ],
  exports: [
    ContactsAboutUsModule,
    ContactsConsultingModule,
    ContactsContactUsModule,
    ContactsUsSupportModule,
    GuidesExamplesModule,
    GuidesResearchModule,
    GuidesTutorialsModule,
    OverviewFeaturesModule,
    OverviewHardProblemModule,
    OverviewUsingHunterModule,
    OverviewWhatsHunterModule,
    OveviewAboutAigaModule
  ]
})
export class PreRegistrationModule { }
