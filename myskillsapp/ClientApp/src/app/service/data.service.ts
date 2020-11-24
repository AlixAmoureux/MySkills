import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Framework } from '../object/Framework';
import { Language } from '../object/Language';
import { Software } from '../object/Software';

@Injectable({
  providedIn: 'root'
})
export class DataService {
  constructor(public http: HttpClient, @Inject('BASE_URL') public baseUrl: string) {
  }

  public getLanguages(): Observable<Language[]> {
    return this.http.get<Language[]>(this.baseUrl + "api/language");
  }

  public getFrameworks(): Observable<Framework[]> {
    return this.http.get<Framework[]>(this.baseUrl + "api/framework");
  }

  public getSoftwares(): Observable<Software[]> {
    return this.http.get<Software[]>(this.baseUrl + "api/software");
  }
}
