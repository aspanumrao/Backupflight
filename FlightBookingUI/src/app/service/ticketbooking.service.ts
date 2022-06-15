import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { BookingFlight } from '../Models/BookingFlight';

@Injectable({
  providedIn: 'root'
})
export class TicketbookingService {

  readonly baseUrl="http://localhost:5000/booked";
  // readonly test1 ='http://localhost:29977/api/booking/book'
  constructor(private http:HttpClient) { 

  }
  formdata:BookingFlight= new BookingFlight();
  postBookingFlight(){
    console.warn("Post call started ");
    console.warn(this.formdata);
    return this.http.post(this.baseUrl,this.formdata);
    


  }
}
