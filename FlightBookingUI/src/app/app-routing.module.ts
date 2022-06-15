import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdmindashComponent } from './admindash/admindash.component';
import { AdminflightInvComponent } from './adminflight-inv/adminflight-inv.component';
import { BookinghistoryComponent } from './bookinghistory/bookinghistory.component';
import { LoginComponent } from './login/login.component';
import { BookingFlight } from './Models/BookingFlight';
import { NewuserComponent } from './newuser/newuser.component';
import { RegisterComponent } from './register/register.component';
import { TicketBookingComponent } from './ticket-booking/ticket-booking.component';
import { UserdashComponent } from './userdash/userdash.component';
import { UserflightsearchComponent } from './userflightsearch/userflightsearch.component';

const routes: Routes = [
  {
    path:"login",
    component:LoginComponent

  },
  {
    path:"register",
    component:RegisterComponent

  },
  {
    path:"adminflight-inv",
    component:AdminflightInvComponent

  },
  {
    path:"userflightsearch",
    component:UserflightsearchComponent

  },
  {
    path:"ticket-booking",
    component:TicketBookingComponent

  },
  {
    path:"bookinghistory",
    component:BookinghistoryComponent

  },
  {
    path:"userdash",
    component:UserdashComponent

  },
  {
    path:"newuser",
    component:NewuserComponent

  },
  {
    path:"admindash",
    component:AdmindashComponent

  }


];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
