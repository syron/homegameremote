import { TestBed, inject } from '@angular/core/testing';

import { HomeGameAutoGameConsoleApiService } from './home-game-auto-game-console-api.service';

describe('HomeGameAutoGameConsoleApiService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [HomeGameAutoGameConsoleApiService]
    });
  });

  it('should be created', inject([HomeGameAutoGameConsoleApiService], (service: HomeGameAutoGameConsoleApiService) => {
    expect(service).toBeTruthy();
  }));
});
