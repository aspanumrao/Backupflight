import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { BookingFlight } from '../Models/BookingFlight';

@Injectable({
  providedIn: 'root'
})
export class BookinghistoryService {
  //readonly baseUrl="http://localhost:5000/booked";
  //readonly baseUrl="http://localhost:29977/api/booking/history";
  //readonly baseUrl=environment.apiUrl;
  constructor(private http:HttpClient) {

   }
  email:string='';
   
  postBookingHistory(){
   //test="this.baseUrl ? this.email.toString()"
    console.warn("Post call here "+this.email);
   return this.http.post(environment.apiUrl+"allbookedticket/"+ this.email,"");
  }
  postcancelticket(pnrno:string){
    console.warn("Pnr in post call",pnrno);
    return this.http.post(environment.apiUrl+"cancelledticket/"+ pnrno,"");
  }
}
