import { Injectable } from '@angular/core';
import { environment } from '../environments/environment';
import { Observable } from 'rxjs/Observable';
import { GameConsole } from './gameconsole';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable()
export class HomeGameAutoGameConsoleApiService {

  baseAddress: string = environment.apiEndpoint;

  constructor(private http: HttpClient) { }

  public getAll(): Observable<Array<GameConsole>> {
    return this.http.get<Array<GameConsole>>(this.baseAddress + 'gameconsoles/');
  }

  public getById(id: string): Observable<GameConsole> {
    return this.http.get<GameConsole>(this.baseAddress + "gameconsoles/" + id);
  }

}
