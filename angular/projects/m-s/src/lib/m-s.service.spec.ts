import { TestBed } from '@angular/core/testing';

import { MSService } from './m-s.service';

describe('MSService', () => {
  let service: MSService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(MSService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
