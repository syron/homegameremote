import { TestBed, inject } from '@angular/core/testing';

import { HomeGameAutoGameApiService } from './home-game-auto-game-api.service';

describe('HomeGameAutoGameApiService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [HomeGameAutoGameApiService]
    });
  });

  it('should be created', inject([HomeGameAutoGameApiService], (service: HomeGameAutoGameApiService) => {
    expect(service).toBeTruthy();
  }));
});
