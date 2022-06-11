import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { BookingFlight } from '../Models/BookingFlight';
import { passenger } from '../Models/passenger';
import { TicketbookingService } from '../service/ticketbooking.service';

@Component({
  selector: 'app-ticket-booking',
  templateUrl: './ticket-booking.component.html',
  styleUrls: ['./ticket-booking.component.css']
})
export class TicketBookingComponent implements OnInit {

  constructor(public service:TicketbookingService) {

   }
  
   public objBookflight:BookingFlight =new BookingFlight();
   public objpassenger:passenger=new passenger();
   addFieldValue() {
     console.warn("Row added started");
    this.objBookflight.listpassengers.push(this.objpassenger);
     this.service.formdata.listpassengers.push(this.objpassenger)
     this.objpassenger= new passenger();
   
 }
 
 deleteFieldValue(index:number) {
   console.warn("Row deletion started");
    this.objBookflight.listpassengers.splice(index, 1);
     this.service.formdata.listpassengers.splice(index, 1);
 }
 BookTicket(f:NgForm){
 
   console.warn("BookTicket Started");
   console.warn(f);
   this.service.postBookingFlight().subscribe((result)=>{
    console.warn(result);
  }
   
  );
     
 }
  ngOnInit(): void {
  }
 
 
}
