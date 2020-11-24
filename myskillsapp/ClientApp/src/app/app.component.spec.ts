import { async, TestBed  } from '@angular/core/testing';
import { RouterTestingModule } from '@angular/router/testing';
import { AppComponent } from './app.component';
import { NavMenuComponent } from './component/nav-menu/nav-menu.component';
import { DebugElement } from '@angular/core';
import { ComponentFixture } from '@angular/core/testing';

describe('AppComponent', () =>
{
  let app: AppComponent;
  let de: DebugElement;
  let fixture: ComponentFixture<AppComponent>;

  beforeEach((() => {
    TestBed
      .configureTestingModule({
        imports: [
          RouterTestingModule
        ],
        declarations: [AppComponent, NavMenuComponent],
        providers: []        
      });
      fixture = TestBed.createComponent(AppComponent);
      app = fixture.componentInstance;
      de = fixture.debugElement;
  }));

  it('should create the app', (() => {
    expect(app).toBeTruthy();
  }));

  it('should detect nav bar component', (() => {
    fixture.detectChanges();
    const compiled = fixture.debugElement.nativeElement;
    expect(compiled.querySelector('app-nav-menu')).not.toBe(null);
  }));
});