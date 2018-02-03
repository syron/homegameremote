import { Component, OnInit, TemplateRef } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Router } from '@angular/router';
import { ParamMap } from '@angular/router/src/shared';
import 'rxjs/add/operator/switchMap';
import { Observable } from 'rxjs/Observable';
import { Game } from '../models';
import { HomeGameAutoGameApiService } from '../home-game-auto-game-api.service';
import { BsModalService } from 'ngx-bootstrap/modal';
import { BsModalRef } from 'ngx-bootstrap/modal/bs-modal-ref.service';
import { CarouselConfig } from 'ngx-bootstrap/carousel';

@Component({
  selector: 'app-listgames',
  templateUrl: './listgames.component.html',
  styleUrls: ['./listgames.component.css'],
  providers: [
    { provide: CarouselConfig, useValue: { interval: 0, noPause: true, showIndicators: false } }
  ]
})
export class ListgamesComponent implements OnInit {

  selectedGameConsoleId: string;

  games$: Observable<Array<Game>>;
  games: Array<Game>;
  selectedGame: Game;

  modalRef: BsModalRef;

  constructor(private route: ActivatedRoute
            , public router: Router
            , private gameApi: HomeGameAutoGameApiService
            , private modalService: BsModalService) {
    this.games$ = this.route.paramMap.switchMap((params: ParamMap) => {
      this.selectedGameConsoleId = params.get('consoleId');
      return this.gameApi.getByConsoleId(this.selectedGameConsoleId);
    });

    this.games$.subscribe(data => {
      this.games = data;
    });
  }
 
  openGameOptions(game: Game, template: TemplateRef<any>) {
    this.selectedGame = game;
    this.modalRef = this.modalService.show(template);
  }


  ngOnInit() {
  }

}
