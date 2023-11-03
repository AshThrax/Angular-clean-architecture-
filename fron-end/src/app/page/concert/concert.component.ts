import { ConcertService } from './../../service/concert.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-concert',
  templateUrl: './concert.component.html',
  styleUrls: ['./concert.component.css']
})
export class ConcertComponent implements OnInit {

  jsonConcert !: any;
  /*
    injection du service lié a la page concert

  */
  constructor(private concertservice : ConcertService)
  {
  }
  /*
  * a l'initialisation du composant on récupère
    les donnée relative au donnée de cocert envoier par l'api
  */
  ngOnInit(): void {
   this.concertservice.getConcert('assets/files/concert.json')
                      .subscribe(
                          (response) => {
                              this.jsonConcert = response;
                              console.log('Donnée reçue', this.jsonConcert);
                        //
                        },
                          (error) => {
                          console.error('Error :', error);
                        }
                      );
  }
}
