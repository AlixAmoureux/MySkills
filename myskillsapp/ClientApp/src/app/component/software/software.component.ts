import { Component } from '@angular/core';
import { DataService } from '../../service/data.service';
import { Software } from '../../object/Software';

@Component({
  selector: 'app-software',
  templateUrl: './software.component.html',
  styleUrls: ['./software.component.css']
})
export class SoftwareComponent {

  public softwares: Software[];

  constructor(public dataService: DataService) {
    this.getSoftwaresData();
  }

  getSoftwaresData() {
    this.dataService.getSoftwares().subscribe(result => {
      this.softwares = result;
    }, error => console.error(error), () => console.debug("Get softwares completed"));
  }
}
