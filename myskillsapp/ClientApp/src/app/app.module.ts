import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { AppComponent } from './app.component';
import { NavMenuComponent } from './component/nav-menu/nav-menu.component';
import { HomeComponent } from './component/home/home.component';
import { LanguageComponent } from './component/language-and-framework/language/language.component';
import { FrameworkComponent } from './component/language-and-framework/framework/framework.component';
import { LanguageAndFrameworkComponent } from './component/language-and-framework/language-and-framework.component';
import { AppRoutingModule } from './app.routing.module';
import { AppMaterialModule } from './app.material.module';
import { SoftwareComponent } from './component/software/software.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    LanguageAndFrameworkComponent,
    LanguageComponent,
    FrameworkComponent,
    SoftwareComponent
  ],
  imports: [
    BrowserAnimationsModule,
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    AppRoutingModule,
    AppMaterialModule

  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
