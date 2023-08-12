import { TestBed } from '@angular/core/testing';

import { TipoElementoServiceService } from './tipo-elemento-service.service';

describe('TipoElementoServiceService', () => {
  let service: TipoElementoServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(TipoElementoServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
