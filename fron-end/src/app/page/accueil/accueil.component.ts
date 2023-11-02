import { Observable, Subscriber } from 'rxjs';
import { AccueilService } from './../../service/accueil.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-accueil',
  templateUrl: './accueil.component.html',
  styleUrls: ['./accueil.component.css']
})
export class AccueilComponent implements OnInit {

  post !: any;
  constructor(private service: AccueilService)
  {

  }
  ngOnInit(): void {

    this.getdata();
  }
  getdata(): void
  {
     this.post = this.service.getJson("assets/files/accueil.json")
      .subscribe(x =>
        this.post = x
        );
  }
}
