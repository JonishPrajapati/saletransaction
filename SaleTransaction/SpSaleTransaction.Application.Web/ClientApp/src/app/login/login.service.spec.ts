/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { LoginApiService } from './login.service';

describe('Service: Login', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [LoginApiService]
    });
  });

  it('should ...', inject([LoginApiService], (service: LoginApiService) => {
    expect(service).toBeTruthy();
  }));
});
