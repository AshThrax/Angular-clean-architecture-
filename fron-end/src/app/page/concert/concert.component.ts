import { ConcertService } from './../../service/concert.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-concert',
  templateUrl: './concert.component.html',
  styleUrls: ['./concert.component.css']
})
export class ConcertComponent implements OnInit {

  jsonConcert !: any;

  constructor(private concertservice : ConcertService)
  {
  }

  ngOnInit(): void {
   this.concertservice.getConcert('/assets/files/concert.json')
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
