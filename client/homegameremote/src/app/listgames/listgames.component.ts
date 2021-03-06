import { Component, OnInit, TemplateRef } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Router } from '@angular/router';
import { ParamMap } from '@angular/router/src/shared';
import 'rxjs/add/operator/switchMap';
import { Observable } from 'rxjs/Observable';
import { Game, GameConsole, StartGameStatus } from '../models';
import { HomeGameAutoGameApiService } from '../home-game-auto-game-api.service';
import { BsModalService } from 'ngx-bootstrap/modal';
import { BsModalRef } from 'ngx-bootstrap/modal/bs-modal-ref.service';
import { NgxCarousel } from 'ngx-carousel';
import { CarouselConfig } from 'ngx-bootstrap/carousel';
import { HomeGameAutoGameConsoleApiService } from '../home-game-auto-game-console-api.service';

@Component({
  selector: 'app-listgames',
  templateUrl: './listgames.component.html',
  styleUrls: ['./listgames.component.css']
})
export class ListgamesComponent implements OnInit {

  selectedGameConsoleId: string;

  games$: Observable<Array<Game>>;
  games: Array<Game>;
  gameConsole: GameConsole

  selectedGame: Game;
  startGameStatus: StartGameStatus = null;

  modalRef: BsModalRef;
  public carouselOne: NgxCarousel;

  constructor(private route: ActivatedRoute
            , public router: Router
            , private gameApi: HomeGameAutoGameApiService
            , private gameConsoleApi: HomeGameAutoGameConsoleApiService
            , private modalService: BsModalService) {
    this.games$ = this.route.paramMap.switchMap((params: ParamMap) => {
      this.selectedGameConsoleId = params.get('consoleId');

      this.gameConsoleApi.getById(this.selectedGameConsoleId).subscribe(data => {
        this.gameConsole = data;
      });

      return this.gameApi.getByConsoleId(this.selectedGameConsoleId);
    });

    this.games$.subscribe(data => {
      this.games = data;
    });
  }

  ngOnInit() {
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
 
  openGameOptions(game: Game, template: TemplateRef<any>) {
    this.selectedGame = game;
    this.modalRef = this.modalService.show(template);
  }

  get numberOfGames(): number {
    if (this.games != null)
      return this.games.length;
    else
      0;
  }

  startGame(game: Game) {
    this.gameApi.start(game.id).subscribe(data => {
      this.startGameStatus = data;
    });
  }

  onCloseStartGameModal() {
    this.modalRef.hide();
    this.startGameStatus = null;
    this.selectedGame = null;
  }
}
