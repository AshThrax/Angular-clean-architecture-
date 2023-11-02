import { Observable } from 'rxjs/internal/Observable';
import { HttpClient } from '@angular/common/http';
import { Concert } from './../class/concert';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ConcertService {

  ConcertJsonFile!: any;
  constructor(private http: HttpClient) { }

  public getConcert(url:string):Observable<string> {
    return this.http.get<string>(url);
  }
}
