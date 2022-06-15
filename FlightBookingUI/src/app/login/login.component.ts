import { Component, OnInit } from '@angular/core';
import { FormGroup,FormControl, NgForm, FormBuilder, Validators } from '@angular/forms';
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
  registerForm:any;
  isSubmitted = true;
  register:Login;
  constructor(private formBuilder: FormBuilder,public service:LoginService,private toastr:ToastrService, private _router:Router ) {
    this.register = {} as Login;
   }

 LoginSubmit(f:NgForm){
 
  console.log("Inside the Login started",f);
 this.service.PostLogin().subscribe((result)=>{
  if (result!=null){
  this.toastr.success("Login success");
  this._router.navigate(["/userdash"]);
  
  }
  else{
    this.toastr.warning("failed ");
  }
   
 }
 );
 }
  ngOnInit(): void {
    this.registerForm=this.formBuilder.group({
      username:[this.register.username, Validators.required],
      password: [this.register.password, Validators.required],
    })
  }
  get fk(){

    return this.registerForm.controls;

  }

}
