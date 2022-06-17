import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Login } from '../Models/Login';


@Injectable({
  providedIn: 'root'
})
export class LoginService {

  constructor(private http:HttpClient) { }
  readonly baseurl="http://localhost:5000/logged";
  //readonly baseurl="http://localhost:25653/api/userlogin/login";
  formdata:Login=new Login();
  PostLogin():Observable<any>{
    console.warn("Postlogin before calling",this.formdata);
   return this.http.post(this.baseurl,this.formdata);

  }

}
