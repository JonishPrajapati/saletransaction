import { Observable } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { MvUserLogin } from './login.model';

@Injectable({
  providedIn: 'root'
})
export class LoginApiService {
 

  apiUrl = environment.apiUrl; // 'http://localhost:4200/api';

  constructor(private httpClient: HttpClient) {
  }
  getUserLogin(json):Observable<any> {
    return this.httpClient.post<any>(this.apiUrl + 'account/UserLogin', json, {headers: this.getHeaderOptions()});
  }



  getHeaderOptions(): HttpHeaders {

    const headers = new HttpHeaders();
    headers.set('Content-Type', 'application/json');
    headers.set('Access-Control-Allow-Origin', '*');
    headers.set('Access-Control-Allow-Methods', 'GET, POST');
    headers.set('Access-Control-Allow-Headers', 'Origin, Content-Type');

    return headers;
  }
}