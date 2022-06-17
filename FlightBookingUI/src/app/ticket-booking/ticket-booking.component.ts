import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { DataService } from '../data.service';
import { BookingFlight } from '../Models/BookingFlight';
import { passenger } from '../Models/passenger';
import { TicketbookingService } from '../service/ticketbooking.service';

@Component({
  selector: 'app-ticket-booking',
  templateUrl: './ticket-booking.component.html',
  styleUrls: ['./ticket-booking.component.css']
})
export class TicketBookingComponent implements OnInit {
   bookflightdata:any;
  constructor(public service:TicketbookingService ,	private toastr:ToastrService,private dataservice: DataService,private _router:Router) {

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
 
   this.service.formdata.FlightNo=this.bookflightdata.flightNo;
   this.service.formdata.BookingFrom=this.bookflightdata.from;
   this.service.formdata.BookingTo=this.bookflightdata.to;
   this.service.formdata.BookingDepartureDate=this.bookflightdata.departureDate;
   this.service.formdata.BookingReturnDate=this.bookflightdata.returnDate;
   this.service.postBookingFlight().subscribe((result)=>
   { 
    this.toastr.success("your ticket  has been booked ");
    this._router.navigate(["/userdash"]);
    });
     
 }
  ngOnInit(): void {
    this.dataservice.book.subscribe(result=>{this.bookflightdata=result;console.warn("data service",result) });
  }
 
 
}
