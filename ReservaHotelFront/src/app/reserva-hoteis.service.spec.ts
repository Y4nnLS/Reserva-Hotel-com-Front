import { TestBed } from '@angular/core/testing';

import { ReservaHoteisService } from './reserva-hoteis.service';

describe('ReservaHoteisService', () => {
  let service: ReservaHoteisService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ReservaHoteisService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
