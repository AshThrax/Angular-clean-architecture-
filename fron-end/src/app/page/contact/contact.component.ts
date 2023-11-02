import { ContactService } from './../../service/contact.service';
import { Component, OnInit } from '@angular/core';


@Component({
  selector: 'app-contact',
  templateUrl: './contact.component.html',
  styleUrls: ['./contact.component.css']
})
export class ContactComponent implements OnInit {
  jsonContact !: any;

  constructor(private contactservice: ContactService) { }

  ngOnInit(): void {
    this.contactservice.getContact('/assets/file/').subscribe(
        (response) =>{
        this.jsonContact = response;
        console.log('Donnée reçue', this.jsonContact);
        },
      (error) => {
        console.log('Error',error);

       }
      )
  }
}
