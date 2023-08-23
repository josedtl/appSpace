import { TestBed } from '@angular/core/testing';

import { PisoMainService } from './piso-main.service';

describe('PisoMainService', () => {
  let service: PisoMainService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(PisoMainService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
