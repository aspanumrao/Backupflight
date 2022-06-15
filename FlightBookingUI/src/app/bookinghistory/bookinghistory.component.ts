import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Bookinghistory } from '../Models/Bookinghistory';
import { BookinghistoryService } from '../service/bookinghistory.service';
import { ToastrService } from 'ngx-toastr';
import { DataService } from '../data.service';
@Component({
  selector: 'app-bookinghistory',
  templateUrl: './bookinghistory.component.html',
  styleUrls: ['./bookinghistory.component.css']
})

export class BookinghistoryComponent implements OnInit {
 
  email:string='';
  bookinghistorylist:Bookinghistory[]=[];
  constructor(public service:BookinghistoryService,private toastr:ToastrService) {

   }

  ngOnInit(): void {
  
  }

  SearchHistory(f:NgForm){
    console.warn("search history started ",f);
    this.service.postBookingHistory().subscribe(
      result=> {  this.bookinghistorylist=result as Bookinghistory[];
        console.warn("obj",result) ;     
               
      }
            
    );
  
  }
  cancleTicket(pnrno:string){
        this.service.postcancelticket(pnrno).subscribe(
          (result) => {
            this.toastr.success("Pnr number:"+pnrno+" has been cancled")
        }
       );
  }
}
