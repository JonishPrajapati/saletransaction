import { AfterViewInit, Component, OnDestroy, OnInit, ViewEncapsulation } from '@angular/core';
import { LoginService } from './login.service';
import { MvUserLogin } from './MvUserLogin';
import {FormBuilder,FormGroup,Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { MatSnackBar } from '@angular/material/snack-bar';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss'],
  encapsulation: ViewEncapsulation.None,
})
export class LoginComponent implements OnInit,AfterViewInit, OnDestroy {
  loginForm: FormGroup;
  errorMessage = null;
  errorMessageType : any = {
    invalidForm: 'Data Must be required',
    invalidLogin: 'Invalid Username or Password'
  }
  login: MvUserLogin = <MvUserLogin>{};

  constructor(public fb: FormBuilder,
    public loginService: LoginService,
    private router: Router,
    private snacbar: MatSnackBar
    ) { }
  ngOnDestroy(): void {
    throw new Error('Method not implemented.');
  }
  ngAfterViewInit(): void {
    throw new Error('Method not implemented.');
  }

  ngOnInit() {
    this.loginForm = this.fb.group({
      Username: ['', Validators.required],
      Password: ['', Validators.required]
    })
  }
 
  submitForm(){
    console.log("enter into form");
    
     if(!this.loginForm.valid ){
       this.openSnackBar(this.errorMessageType.invalidForm, "");
     }else{
       this.login.Username = this.Username.value.trim();
       this.login.Password = this.Password.value.trim();

       this.loginService.getLogin(this.login).subscribe((res)=>{
         if(res){
           this.openSnackBar("login successfull", "");
            console.log("login");
            this.router.navigate(['/user-detail']);
            
         }else{
           this.openSnackBar(this.errorMessageType.invalidLogin, "");
         }
       })
     }
  }
  get Username(): any{
    return this.loginForm.get('Username');
  }
  get Password() : any{
    return this.loginForm.get('Password');
  }

  openSnackBar(message,action){
    this.snacbar.open(message, action,{
      duration:3000,
      panelClass: ['login-snackbar'],
      verticalPosition: 'top',
      horizontalPosition: 'right',
    })
  }

}
