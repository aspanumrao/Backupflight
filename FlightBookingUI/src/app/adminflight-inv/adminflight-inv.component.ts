import { Component, OnInit } from '@angular/core';
import { FormArray, FormBuilder } from '@angular/forms';
import { AdminFlight } from '../Models/AdminFlight';

import { AdminflightsService } from '../service/adminflights.service';

@Component({
  selector: 'app-adminflight-inv',
  templateUrl: './adminflight-inv.component.html',
  styleUrls: ['./adminflight-inv.component.css']
})
export class AdminflightInvComponent implements OnInit {
 
  
  constructor(private adminflightservice:AdminflightsService) {

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
  Block(data:any){
     console.log("Blocking the Airline",data);
   }
   Modify(data:any){
    console.log("Schdeule modification the Airline",data);
   }
}
