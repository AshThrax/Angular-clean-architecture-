import { Album } from './../class/album';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/internal/Observable';

@Injectable({
  providedIn: 'root'
})
export class AccueilService {

  jsonAccueil !: string ;
  constructor(private http: HttpClient) { }

  public getJson (url: string): Observable<string>
  {
    return this.http.get<string>(url).subscribe(
      (response) => {
        this.jsonAccueil = response;
        console.log('Donnée reçue', this.jsonAccueil);
        //
      },
      (error) => {
        console.error('Error :', error);
      }
    );
  }
}
