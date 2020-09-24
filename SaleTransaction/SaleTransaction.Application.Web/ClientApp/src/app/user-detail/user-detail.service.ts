import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ApiServiceService } from '../../core/services/ApiService.service'

@Injectable({
  providedIn: 'root'
})
export class UserDetailService {

constructor(private api: ApiServiceService) { }
getUserDetail(UserId :any): Observable<any>{
  return this.api.get('account/userdetail',{ json: JSON.stringify({UserId : UserId}) });
}
}
