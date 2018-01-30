import { Component } from '@angular/core';
import { HomeGameAutoGameApiService } from './home-game-auto-game-api.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'app';

  constructor(private gameApi: HomeGameAutoGameApiService) {
    this.gameApi.getAll().subscribe(data => {
      console.log(data);
    });
  }
}
