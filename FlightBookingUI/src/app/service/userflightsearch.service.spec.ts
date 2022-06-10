import { TestBed } from '@angular/core/testing';

import { UserflightsearchService } from './userflightsearch.service';

describe('UserflightsearchService', () => {
  let service: UserflightsearchService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(UserflightsearchService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
