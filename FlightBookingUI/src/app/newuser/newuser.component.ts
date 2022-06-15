import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { NewuserService } from '../service/newuser.service';

@Component({
  selector: 'app-newuser',
  templateUrl: './newuser.component.html',
  styleUrls: ['./newuser.component.css']
})
export class NewuserComponent implements OnInit {

  constructor(public service:NewuserService,private toastr:ToastrService, private _router:Router ) { }

  ngOnInit(): void {
  }
  UserRegistration(f:NgForm){
   this.service.postNewUserRegisration().subscribe(
   result=>{
     this.toastr.success("Registed");
   }

   )
  }
}
