import { AfterViewInit, Component, OnDestroy, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import {MatSnackBar} from '@angular/material/snack-bar';
import { LoginApiService } from './login.service';
import { MvUserLogin } from './login.model';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit, AfterViewInit, OnDestroy {

  loginForm: FormGroup;
  login: MvUserLogin = {} as MvUserLogin;
  errorMessage: any;
  errorMessageType: any = {
    invFrom: 'Empty Form!',
    invLogin: 'Invalid Usernmae or Password!'
  };
  constructor(private fb: FormBuilder,
              private loginApiService: LoginApiService,
              private router: Router,
              private snackBar: MatSnackBar) { }


  ngOnDestroy(): void {
    throw new Error('Method not implemented.');
  }
  ngAfterViewInit(): void {
    this.loginForm.updateValueAndValidity();
  }

  ngOnInit() {
    this.loginForm = this.fb.group({
      Username: ['', Validators.required],
      Password: ['', Validators.required]
    });
  }
  submitForm() { // call server/api and authenticate
    this.errorMessage = null;
    if (this.loginForm.valid) {

      // const json = this.loginForm.value;
      this.login.Username = this.loginForm.get('Username').value.trim();
      this.login.Password = this.loginForm.get('Password').value.trim();
     
      this.loginApiService.getUserLogin(this.login).subscribe((response: any) => {
        console.log("clicked12");
        if (response) {

          this.openSnackBar('Login Success!', 'success');
         // this.router.navigate(['/user-detail']);
         
          
        } else {

          this.errorMessage = this.errorMessageType.invLogin;
        }
      });
    } else {

      this.errorMessage = this.errorMessageType.invForm;
    }
  }
  openSnackBar(message, action) {
    this.snackBar.open(message, action, {duration: 30000});
  }

}
