import { TestBed } from '@angular/core/testing';

import { TipoInfraestructuraService } from './tipo-infraestructura.service';

describe('TipoInfraestructuraService', () => {
  let service: TipoInfraestructuraService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(TipoInfraestructuraService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
