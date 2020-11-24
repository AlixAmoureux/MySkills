import { Component, Input, Output, EventEmitter } from '@angular/core';
import { Framework } from '../../../object/Framework';

@Component({
  selector: 'app-framework',
  templateUrl: './framework.component.html',
  styleUrls: ['./framework.component.css']
})
export class FrameworkComponent {
  @Input("frameworks") public frameworks: Framework[];
  @Output() public frameworkChosen = new EventEmitter<number>();
  private frameworkChosenData = { id: 0, frameworkChosen: false };

  @Input()
  get languageIdChosen(): number {
    return this._languageIdChosen;
  }
  set languageIdChosen(tmpId: number) {
    this.frameworkChosenData = { id: 0, frameworkChosen: false };
    this._languageIdChosen = tmpId;
  }
  private _languageIdChosen: number;

  public chooseFramework(id: number) {
    this.frameworkChosenData = { id: id, frameworkChosen: true };
    this.frameworkChosen.emit(id);
  }

  public displayCssStyle(framework: Framework) {
    let foundLanguageId: Boolean = false;
    if (!this.frameworkChosenData.frameworkChosen) {
      if (framework.language !== undefined && framework.language !== null)
        if (framework.language.id === this.languageIdChosen)
          foundLanguageId = true;
    }
    else {
      if (framework.id === this.frameworkChosenData.id)
        foundLanguageId = true;
    }
    return foundLanguageId;
  }
}
