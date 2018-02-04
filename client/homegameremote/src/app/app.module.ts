import { RouterModule, Routes } from '@angular/router';

import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { AppComponent } from './app.component';
import { HomeGameAutoGameApiService, HomeGameAutoGameConsoleApiService } from './services';
import { ListgameconsoleComponent } from './listgameconsole/listgameconsole.component';
import { ListgamesComponent } from './listgames/listgames.component';

import { CarouselModule, ModalModule, PopoverModule } from 'ngx-bootstrap';
import { NgxCarouselModule } from 'ngx-carousel';
import 'hammerjs';

const appRoutes: Routes = [
  { path: 'home', component: ListgameconsoleComponent },
  { path: 'games/:consoleId', component: ListgamesComponent },
  { path: '',
    redirectTo: '/home',
    pathMatch: 'full'
  }
];

@NgModule({
  declarations: [
    AppComponent,
    ListgameconsoleComponent,
    ListgamesComponent
  ],
  imports: [
    BrowserModule,    
    RouterModule.forRoot(appRoutes, {enableTracing: false}),
    NgxCarouselModule,
    CarouselModule.forRoot(),
    PopoverModule.forRoot(),
    ModalModule.forRoot(),
    HttpClientModule
  ],
  providers: [HomeGameAutoGameApiService, HomeGameAutoGameConsoleApiService],
  bootstrap: [AppComponent]
})
export class AppModule { }
