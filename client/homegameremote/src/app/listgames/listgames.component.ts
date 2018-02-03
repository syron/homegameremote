import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Router } from '@angular/router';
import { ParamMap } from '@angular/router/src/shared';
import 'rxjs/add/operator/switchMap';
import { Observable } from 'rxjs/Observable';
import { Game } from '../models';
import { HomeGameAutoGameApiService } from '../home-game-auto-game-api.service';

@Component({
  selector: 'app-listgames',
  templateUrl: './listgames.component.html',
  styleUrls: ['./listgames.component.css']
})
export class ListgamesComponent implements OnInit {

  selectedGameConsoleId: string;

  games$: Observable<Array<Game>>;
  games: Array<Game>;

  constructor(private route: ActivatedRoute
            , public router: Router
            , private gameApi: HomeGameAutoGameApiService) {
    this.games$ = this.route.paramMap.switchMap((params: ParamMap) => {
      this.selectedGameConsoleId = params.get('consoleId');
      return this.gameApi.getByConsoleId(this.selectedGameConsoleId);
    });

    this.games$.subscribe(data => {
      this.games = data;
    });
  }

  ngOnInit() {
  }

}
