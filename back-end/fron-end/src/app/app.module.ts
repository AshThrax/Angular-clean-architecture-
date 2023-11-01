import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './Component/header/header.component';
import { FooterComponent } from './Component/footer/footer.component';
import { AccueilComponent } from './page/accueil/accueil.component';
import { ContactComponent } from './page/contact/contact.component';
import { ConcertComponent } from './page/concert/concert.component';
import { AlbumListComponent } from './Component/album-list/album-list.component';
import { MerchComponent } from './page/merch/merch.component';
import { AlbumSingleComponent } from './Component/album-single/album-single.component';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    FooterComponent,
    AccueilComponent,
    ContactComponent,
    ConcertComponent,
    AlbumListComponent,
    MerchComponent,
    AlbumSingleComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
