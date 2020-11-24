import { async, TestBed } from '@angular/core/testing';
import { RouterTestingModule } from '@angular/router/testing';
import { DebugElement } from '@angular/core';
import { ComponentFixture } from '@angular/core/testing';
import { HomeComponent } from './home.component';
import { MatCardModule } from '@angular/material/card'; 
import { MatIconModule } from '@angular/material/icon';

describe('HomeComponent', () => {
  let comp: HomeComponent;
  let de: DebugElement;
  let fixture: ComponentFixture<HomeComponent>;

  beforeEach((() => {
    TestBed
      .configureTestingModule({
        imports: [
          RouterTestingModule,
          MatCardModule,
          MatIconModule
        ],
        declarations: [HomeComponent],
        providers: []
      });
    fixture = TestBed.createComponent(HomeComponent);
    comp = fixture.componentInstance;
  }));

  it('should create the component', (() => {
    expect(comp).toBeTruthy();
  }));

  it('should contains the card title and content', (() => {
    const cards = Array.from(
      document.getElementsByTagName('mat-card')
    );
    cards.forEach(card => {
      const cardTitle = card.getElementsByTagName('mat-card-title')[0]
        .textContent;
      const cardContent = card.getElementsByTagName('mat-card-content')[0]
        .textContent;
      expect(cardTitle).toContain("Welcome on my online skills presentation !");
      expect(cardContent).toContain("ASP.NET");
    });
  }));
});
