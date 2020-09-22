import { WebApiService } from './../../core/services/web-api.service';
import { Observable } from 'rxjs';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class UserDetailService {
  apiUrl = environment.apiUrl;
  snapshot: any;

constructor(private api: WebApiService) { }

getUserDetails(id):Observable<any> {
  return this.api.get('Account/UserDetail', { json: JSON.stringify({userId : id}) });
}

}

