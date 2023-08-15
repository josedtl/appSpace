import { TestBed } from '@angular/core/testing';

import { PersonanaturalService } from './personanatural.service';

describe('PersonanaturalService', () => {
  let service: PersonanaturalService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(PersonanaturalService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
