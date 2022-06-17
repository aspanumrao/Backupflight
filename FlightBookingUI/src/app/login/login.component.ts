import { Component, OnInit } from '@angular/core';
import { FormGroup,FormControl, NgForm, FormBuilder } from '@angular/forms';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { Login } from '../Models/Login';
import { LoginService } from '../service/login.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
 
  constructor(public service:LoginService,private toastr:ToastrService, private _router:Router ) {
   
   }
  

 LoginSubmit(f:NgForm){
 
  console.log("Inside the Login started",f);
 this.service.PostLogin().subscribe((result)=>{
  if (result.value.token){
    if(this.service.formdata.username=='admin'){
      this.toastr.success("Login success");
      this._router.navigate(["/admindash"]);
     }
     else{
    this.toastr.success("Login success");
   this._router.navigate(["/userdash"]);
     }
  }
  else{
    this.toastr.warning("failed ");
  }
   
 }
 );
 }
  ngOnInit(): void {
  
  }
 

}
