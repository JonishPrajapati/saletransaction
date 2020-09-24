import { Component, OnInit } from '@angular/core';
import { MvUserDetail } from './user-detail';
import { UserDetailService } from './user-detail.service';
import { ActivatedRoute } from '@angular/router';



@Component({
  selector: 'app-user-detail',
  templateUrl: './user-detail.component.html',
  styleUrls: ['./user-detail.component.scss']
})
export class UserDetailComponent implements OnInit {

  id: any
  displayedColumns: string[] ;
  dataSource: MvUserDetail[] =[];
  errorMessage = null;
  errorMessageType : any = {
    requestedData: 'No data available',
    
  }

  constructor(private router: ActivatedRoute,
               private userDetails: UserDetailService) { }

  ngOnInit() {
      this.displayedColumns = ['UserId', 'Username']
      this.getUserDetails();
  }
  getUserDetails() {
         this.id = this.router.snapshot.params['id'];
        this.userDetails.getUserDetail(this.id).subscribe((response: any)=>{
        this.dataSource = response;
        this.errorMessageType.requestedData;
        })
  }

}
