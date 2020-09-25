import { Component, OnInit } from '@angular/core';
import { MvUserDetail } from './user-detail';
import { UserDetailService } from './user-detail.service';
import { ActivatedRoute } from '@angular/router';
import { map } from 'rxjs/operators'


@Component({
  selector: 'app-user-detail',
  templateUrl: './user-detail.component.html',
  styleUrls: ['./user-detail.component.scss']
})
export class UserDetailComponent implements OnInit {
  
  errorMessage: string = null;
  displayedColumns: string[] ;
  dataSource: MvUserDetail[]=[];
  

  constructor(private router: ActivatedRoute,
               private userDetails: UserDetailService) {
                }

  ngOnInit():void {
      this.displayedColumns = ['UserId', 'Username','Password','InsertPersonId','InsertDate'];
      this.getUserDetails();
  }
  getUserDetails() {
        //  const id = this.router.snapshot.params['UserId'];
        //  console.log(id, "dfdf");
         
        // this.userDetails.getUserDetail(this.id).subscribe((response: any)=>{
        //   if(response){
        //     this.dataSource = response;
        //     this.errorMessageType.requestedData;
        //   }else{
        //     this.errorMessageType.requestedData;
        //   }
        
        // })

        
      ;
        
        
        this.router.paramMap.pipe(
          map(params =>{
            let userId = this.router.snapshot.params.UserId;
            console.log(userId);
            
            return this.userDetails.getUserDetail({UserId:userId}).subscribe((res) =>{
              if(res){
                this.dataSource = [res];
              }else{
                this.errorMessage = "No data available"
              }
            })
          })
       )
  }
  
  
  getAllUsers(){
    
    this.userDetails.getAllUser().subscribe((response: any)=>{
      console.log("hello");
        if(response && response.data){
          this.dataSource = response.data;
          console.log("res",this.dataSource);
          
        }else{
          this.errorMessage = "No Data Available"
        }
    })
  }


}
