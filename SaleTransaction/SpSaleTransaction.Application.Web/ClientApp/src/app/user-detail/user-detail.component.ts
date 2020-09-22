import { HttpClient, HttpHeaders } from '@angular/common/http';
import { AfterViewInit, Component, OnDestroy, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { MvUserDetail } from './user-detail.model';
import { UserDetailService } from './user-detail.service';

@Component({
  selector: 'app-user-detail',
  templateUrl: './user-detail.component.html',
  styleUrls: ['./user-detail.component.css']
})
export class UserDetailComponent implements OnInit {
  id: any
  displayedColumns : string[];
  dataSource: MvUserDetail[] = [];

  constructor(private router: ActivatedRoute,
              private userDetail: UserDetailService) { }
  

  ngOnInit() {
    this.displayedColumns = [
                              'UserId',
                              'Username'
                            ]
    this.getUserDetails();
  }
  getUserDetails() {
      this.id = this.router.snapshot.params['id'];
      this.userDetail.getUserDetails(this.id).subscribe(data => {
       this.dataSource = data
      })
  }
 

}
