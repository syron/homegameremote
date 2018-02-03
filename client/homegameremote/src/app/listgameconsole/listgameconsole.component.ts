import { Component, OnInit } from '@angular/core';
import { HomeGameAutoGameConsoleApiService } from '../home-game-auto-game-console-api.service';
import { GameConsole } from '../models';
import { CarouselConfig } from 'ngx-bootstrap/carousel';

@Component({
  selector: 'app-listgameconsole',
  templateUrl: './listgameconsole.component.html',
  styleUrls: ['./listgameconsole.component.css'],
  providers: [
    { provide: CarouselConfig, useValue: { interval: 0, noPause: true, showIndicators: false } }
  ]
})
export class ListgameconsoleComponent implements OnInit {

  gameConsoles: Array<GameConsole>;

  constructor(private gameConsoleApi: HomeGameAutoGameConsoleApiService) { }

  ngOnInit() {
    this.gameConsoleApi.getAll().subscribe(data => {
      this.gameConsoles = data;
    });
  }

}
