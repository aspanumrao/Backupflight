import { Component, OnInit } from '@angular/core';
import { FormBuilder, NgForm, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { Register } from '../Models/Register';
import { RegisterService } from '../service/register.service';



@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  constructor(public service:RegisterService,private toastr:ToastrService) { 
    
  }
  
  ngOnInit():void {

  }

  Register(f:NgForm){
    console.log("Inside the Register");
    this.service.postRegister().subscribe((result)=>{
      // console.warn(result);
      this.toastr.success("Airline has been Registerd");
    }
     
    );
  }

}
