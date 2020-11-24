import { NgModule } from '@angular/core';

import { MatCardModule } from '@angular/material/card';
import { MatIconModule } from '@angular/material/icon';
import { MatExpansionModule } from '@angular/material/expansion';

@NgModule({
  imports: [
    MatCardModule,
    MatIconModule,
    MatExpansionModule,
  ],
  exports: [
    MatCardModule,
    MatIconModule,
    MatExpansionModule,
  ]
})
export class AppMaterialModule { }
