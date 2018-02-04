import { Component, OnInit } from '@angular/core';
import { HomeGameAutoGameConsoleApiService } from '../home-game-auto-game-console-api.service';
import { GameConsole } from '../models';
import { NgxCarousel } from 'ngx-carousel';


@Component({
  selector: 'app-listgameconsole',
  templateUrl: './listgameconsole.component.html',
  styleUrls: ['./listgameconsole.component.css'],
})
export class ListgameconsoleComponent implements OnInit {

  gameConsoles: Array<GameConsole>;

  public carouselOne: NgxCarousel;

  constructor(private gameConsoleApi: HomeGameAutoGameConsoleApiService) { }

  ngOnInit() {
    this.gameConsoleApi.getAll().subscribe(data => {
      this.gameConsoles = data;
    });

    this.carouselOne = {
      grid: {xs: 1, sm: 1, md: 1, lg: 1, all: 0},
      slide: 1,
      speed: 400,
      point: {
        visible: true
      },
      load: 2,
      touch: true,
      loop: true,
      custom: 'banner'
    }
  }

  public myfunc(event: Event) {
    // carouselLoad will trigger this funnction when your load value reaches
    // it is helps to load the data by parts to increase the performance of the app
    // must use feature to all carousel
  }

  get numberOfGameConsoles(): number {
    return this.gameConsoles.length;
  }

}
