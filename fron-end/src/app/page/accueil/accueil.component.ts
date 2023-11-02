import { AccueilService } from './../../service/accueil.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-accueil',
  templateUrl: './accueil.component.html',
  styleUrls: ['./accueil.component.css']
})
export class AccueilComponent implements OnInit {

  post: any;

  constructor(private service: AccueilService)
  {

  }
  ngOnInit(): void {
    this.service.getJson('/asset/files/accueil.json').subscribe
      (
        (response: any) => { this.post = response;},
        (error: any) => { console.log(error); }
      );
  }
}
