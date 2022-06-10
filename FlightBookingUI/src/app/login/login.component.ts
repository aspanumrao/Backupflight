import { Component, OnInit } from '@angular/core';
import { FormGroup,FormControl, NgForm } from '@angular/forms';
import { Login } from '../Models/Login';
import { LoginService } from '../service/login.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor(public service:LoginService ) { }

 LoginSubmit(f:NgForm){
  console.log("Inside the Login started",f);
 this.service.PostLogin().subscribe((result)=>{
   console.warn(result);
 }
 );
 }
  ngOnInit(): void {
  
  }

}
