/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { ProductrateService } from './productrate.service';

describe('Service: Productrate', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [ProductrateService]
    });
  });

  it('should ...', inject([ProductrateService], (service: ProductrateService) => {
    expect(service).toBeTruthy();
  }));
});
