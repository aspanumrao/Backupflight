import { TestBed } from '@angular/core/testing';

import { AdminflightsService } from './adminflights.service';

describe('AdminflightsService', () => {
  let service: AdminflightsService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(AdminflightsService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
