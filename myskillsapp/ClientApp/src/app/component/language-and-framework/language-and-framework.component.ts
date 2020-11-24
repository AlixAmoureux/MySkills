import { Component } from '@angular/core';
import { DataService } from '../../service/data.service';
import { Framework } from '../../object/Framework';
import { Language } from '../../object/Language';

@Component({
  selector: 'app-language-and-framework',
  templateUrl: './language-and-framework.component.html',
  styleUrls: ['./language-and-framework.component.css']
})
export class LanguageAndFrameworkComponent {
  public languages: Language[];
  public frameworks: Framework[];
  public languageIdChosen: number = 0;
  public frameworkIdChosen: number = 0;

  public constructor(public dataService: DataService) {

  }

  ngOnInit() {
    this.getLanguageData();
    this.getFrameworkData();
  }

  getLanguageData() {
    this.dataService.getLanguages().subscribe(result => {
      this.languages = result;
    }, error => console.error(error), () => console.debug("Get languages completed"));
  }

  getFrameworkData() {
    this.dataService.getFrameworks().subscribe(result => {
      this.frameworks = result;
    }, error => console.error(error), () => console.debug("Get frameworks completed"));
  }

  languageChosen(languageId: number) {
    this.languageIdChosen = languageId;
  }

  frameworkChosen(frameworkId: number) {
    this.frameworkIdChosen = frameworkId;
  }
}
