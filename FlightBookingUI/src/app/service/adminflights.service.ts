import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class AdminflightsService {
  //readonly baseurl="http://localhost:6695/api/inventory/getallactiveflight";
 // readonly baseurl="http://localhost:25653/api/userlogin/login";
 // readonly baseUrl="http://localhost:5000/getall";
  constructor(private http:HttpClient) { }
  getallflight(){
   return this.http.get(environment.apiUrl+"getall")
  }
  Postblockflight(FlightId:number){
    return this.http.post(environment.apiUrl+"airlineblock/"+FlightId,"")
  }
}
