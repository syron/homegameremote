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

  get numberOfGameConsoles(): number {
    if (this.gameConsoles != null)
      return this.gameConsoles.length;
    else
      return 0;
  }

}
