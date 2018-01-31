import { RouterModule, Routes } from '@angular/router';

import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { AppComponent } from './app.component';
import { HomeGameAutoGameApiService, HomeGameAutoGameConsoleApiService } from './services';
import { ListgameconsoleComponent } from './listgameconsole/listgameconsole.component';

const appRoutes: Routes = [
  { path: 'home', component: ListgameconsoleComponent },
  { path: '',
    redirectTo: '/home',
    pathMatch: 'full'
  }
  //,
  //{ path: '**', component: PageNotFoundComponent }
];

@NgModule({
  declarations: [
    AppComponent,
    ListgameconsoleComponent
  ],
  imports: [
    BrowserModule,    
    RouterModule.forRoot(appRoutes, {enableTracing: false}),
    HttpClientModule
  ],
  providers: [HomeGameAutoGameApiService, HomeGameAutoGameConsoleApiService],
  bootstrap: [AppComponent]
})
export class AppModule { }
