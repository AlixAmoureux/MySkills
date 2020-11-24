import { Component, Input, Output, EventEmitter } from '@angular/core';
import { Language } from '../../../object/Language';

@Component({
  selector: 'app-language',
  templateUrl: './language.component.html',
  styleUrls: ['./language.component.css']
})
export class LanguageComponent {
  @Input("languages") public languages: Language[];
  @Output() public languageChosen = new EventEmitter<number>();
  private languageChosenData = { id: 0, languageChosen: true };

  @Input()
  get frameworkIdChosen(): number {
    return this._frameworkIdChosen;
  }
  set frameworkIdChosen(tmpId: number) {
    this.languageChosenData = { id: 0, languageChosen: false };
    this._frameworkIdChosen = tmpId;
  }

  private _frameworkIdChosen: number;

  public ngOnInit() {
    this.chooseLanguage(0);
  }

  public chooseLanguage(id: number) {
    this.languageChosenData = { id: id, languageChosen: true };
    this.languageChosen.emit(id);
  }

  public displayCssStyle(language: Language) {
    let foundFrameworkId: Boolean = false;
    if (!this.languageChosenData.languageChosen) {
      if (language.framework !== undefined && language.framework !== null)
        if (language.framework.findIndex(framework => framework.id === this._frameworkIdChosen) !== -1)
          foundFrameworkId = true;
    }
    else {
      if (language.id === this.languageChosenData.id)
        foundFrameworkId = true;
    }
    return foundFrameworkId;
  }
}
