import { Component, OnInit } from '@angular/core';
import { FormArray, FormBuilder } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { AdminFlight } from '../Models/AdminFlight';

import { AdminflightsService } from '../service/adminflights.service';

@Component({
  selector: 'app-adminflight-inv',
  templateUrl: './adminflight-inv.component.html',
  styleUrls: ['./adminflight-inv.component.css']
})
export class AdminflightInvComponent implements OnInit {
 
  
  constructor(private adminflightservice:AdminflightsService,private toastr:ToastrService) {

   }

   newinventoryflights: AdminFlight[]=[];
  ngOnInit(): void {
    this.adminflightservice.getallflight()
     .subscribe(
       data => {  
      this.newinventoryflights = data as AdminFlight [] ,console.warn(data)
     } 
     );
    
  }
  Block(FlightId:number){
     console.log("Blocking the Airline",FlightId);
     this.adminflightservice.Postblockflight(FlightId).subscribe(
       result=>{
        this.toastr.success("Airline ID:"+ FlightId + "has been Blocked");
       }
     )
   }
  
}
