
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AccueilComponent } from './page/accueil/accueil.component';
import { ContactComponent } from './page/contact/contact.component';
import { ConcertComponent } from './page/concert/concert.component';
import { MerchComponent } from './page/merch/merch.component';

const routes: Routes = [
  {path:'Accueil' ,component: AccueilComponent},
  {path:'Contact',component:ContactComponent},
  { path:'Concert', component: ConcertComponent},
   {path:'Merch',component: MerchComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
