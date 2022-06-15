import { Injectable } from '@angular/core';
import{HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';
import { Register } from '../Models/Register';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
 export class RegisterService {
  constructor(private http:HttpClient){
  }
 
  //readonly baseUrl="http://localhost:5000/register";
  formdata:Register= new Register();
  postRegister(){
    console.warn(this.formdata);
    return this.http.post(environment.apiUrl+"register",this.formdata);
    console.warn("end the ");
    }
 
}
