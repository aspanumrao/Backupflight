import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Register } from '../Models/Register';
import { UserFlightSearch } from '../Models/UserFlightSearch';
import { UserflightsearchService } from '../service/userflightsearch.service';

@Component({
  selector: 'app-userflightsearch',
  templateUrl: './userflightsearch.component.html',
  styleUrls: ['./userflightsearch.component.css']
})
export class UserflightsearchComponent implements OnInit {

  constructor(public service:UserflightsearchService) { }
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

}
