import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './component/home/home.component';
import { LanguageAndFrameworkComponent } from './component/language-and-framework/language-and-framework.component';
import { SoftwareComponent } from './component/software/software.component';

const routes: Routes = [
  { path: '', component: HomeComponent, pathMatch: 'full' },
  { path: 'languagesAndFrameworks', component: LanguageAndFrameworkComponent },
  { path: 'softwares', component: SoftwareComponent }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
