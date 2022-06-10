import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Register } from '../Models/Register';

@Injectable({
  providedIn: 'root'
})
export class UserflightsearchService {
  readonly baseUrl="http://localhost:18227/api/flightsearch/flightsearch";
  constructor(private http:HttpClient) { }
  formdata:Register=new Register(); 
  postuserflightsearch(){
    console.warn("I am inside the post");
    return this.http.post(this.baseUrl,this.formdata)

  }
}
