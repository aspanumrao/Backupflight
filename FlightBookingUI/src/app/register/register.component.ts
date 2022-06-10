import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Register } from '../Models/Register';
import { RegisterService } from '../service/register.service';



@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  constructor(public service:RegisterService) { }

  ngOnInit():void {

  }

  Register(f:NgForm){
    console.log("Inside the Register");
    this.service.postRegister().subscribe((result)=>{
      console.warn(result);
    }
     
    );
  }
}
