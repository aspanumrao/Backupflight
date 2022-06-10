import { Injectable } from '@angular/core';
import{HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';
import { Register } from '../Models/Register';

@Injectable({
  providedIn: 'root'
})
 export class RegisterService {
  constructor(private http:HttpClient){
  }
 
  readonly baseUrl="http://localhost:5000/register";
  formdata:Register= new Register();
  postRegister(){
    console.warn(this.formdata);
    return this.http.post(this.baseUrl,this.formdata);
    console.warn("end the ");
    }
 
}
