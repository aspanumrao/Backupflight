import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';
import { DataService } from '../data.service';
import { Register } from '../Models/Register';
import { UserFlightSearch } from '../Models/UserFlightSearch';
import { UserflightsearchService } from '../service/userflightsearch.service';

@Component({
  selector: 'app-userflightsearch',
  templateUrl: './userflightsearch.component.html',
  styleUrls: ['./userflightsearch.component.css']
})
export class UserflightsearchComponent implements OnInit {

  constructor(public service:UserflightsearchService,private _router:Router,private dataservice: DataService) { }
  userflightsearchlist:UserFlightSearch[]=[];
  ngOnInit(): void {
   
  }

  SearchUserFlight(f:NgForm){
         console.warn(" started Inside the search",f);
    this.service.postuserflightsearch().subscribe(
      result=> { this.userflightsearchlist=result as UserFlightSearch[], console.warn(result),
        console.warn("list of array",this.userflightsearchlist)
      }
    );
  }
  //flight.flightNo,flight.from,flight.to,flight.departureDa
  Onclickbook(flightdeatils:any){
    this.dataservice.changeName(flightdeatils);
    this._router.navigate(["/ticket-booking"]);

  }

}
