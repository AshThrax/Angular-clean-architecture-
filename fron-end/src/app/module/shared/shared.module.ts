import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { NgxAudioPlayerModule } from 'ngx-audio-player';


/*
  MODULE CUSTOME CONTENANT LES MODULES A integrer et Exporter:
*/
@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    HttpClientModule,
    FormsModule,
    NgxAudioPlayerModule
  ],
  exports: [
    HttpClientModule,
    FormsModule,
    NgxAudioPlayerModule
  ]
})
export class SharedModule { }
