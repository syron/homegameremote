import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from '../environments/environment';
import { Game } from './game';
import { Observable } from 'rxjs/Observable';

@Injectable()
export class HomeGameAutoGameApiService {
  
  baseAddress: string = environment.apiEndpoint;

  constructor(private http: HttpClient) { }

  public getAll(): Observable<Array<Game>> {
    return this.http.get<Array<Game>>(this.baseAddress + 'games/');
  }

  public getByConsoleId(consoleId: string): Observable<Array<Game>> {
    return this.http.get<Array<Game>>(this.baseAddress + "games?consoleId=" + consoleId);
  }

  public getById(id: string): Observable<Game> {
    return this.http.get<Game>(this.baseAddress + "/games/" + id);
  }

}
