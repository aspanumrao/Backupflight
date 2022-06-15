import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Login } from '../Models/Login';

@Injectable({
  providedIn: 'root'
})
export class NewuserService {
  readonly baseurl="http://localhost:5000/newuser";
  constructor(private http:HttpClient) { }
  formdata:Login=new Login();
  postNewUserRegisration(){
    console.warn("Postlogin before calling",this.formdata);
    return this.http.post(this.baseurl,this.formdata);
  }
}
